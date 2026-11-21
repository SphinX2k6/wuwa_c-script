using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extensions;
using UnrealEngine;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000165 RID: 357
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonDbConnectManager : IStaticVariableResetter
	{
		// Token: 0x06000C72 RID: 3186 RVA: 0x00039DFC File Offset: 0x00037FFC
		static CommonDbConnectManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonDbConnectManager.CreateStaticDefaultValue), new Action(CommonDbConnectManager.ResetStaticDefaultValue));
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00039E25 File Offset: 0x00038025
		private static int CreateIncrementId()
		{
			return ++CommonDbConnectManager.IncrementId;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00039E34 File Offset: 0x00038034
		[NullableContext(1)]
		private static ConnectDbObject LruCreator(int incrementId)
		{
			CommonDbData dbData;
			if (CommonDbConnectManager.CommonDbDataMap.TryGetValue(incrementId, out dbData))
			{
				ConnectDbObject connectDbObject = new ConnectDbObject();
				connectDbObject.ConnectStatement(dbData);
				return connectDbObject;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 1);
			defaultInterpolatedStringHandler.AppendLiteral("创建 ConnectDbObject失败, incrementId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(incrementId);
			defaultInterpolatedStringHandler.AppendLiteral("，可能是没有执行InitConnectDbData");
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00039E93 File Offset: 0x00038093
		[NullableContext(1)]
		private static void LruClearer(ConnectDbObject data)
		{
			data.DisConnectStatement();
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00039E9C File Offset: 0x0003809C
		private static ConnectDbObject CreateOrGetConnectDbObject(int incrementId)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.DbConnectLru.Get(incrementId);
			if (connectDbObject == null)
			{
				CommonDbData commonDbData;
				if (CommonDbConnectManager.EditorCheckDbReconnectCreated != null && CommonDbConnectManager.CommonDbDataMap.TryGetValue(incrementId, out commonDbData) && CommonDbConnectManager.EditorCheckDbReconnectCreated(commonDbData))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.CommonDbConnect;
					ELogAuthor author = ELogAuthor.JYT;
					string message = "[EditorCheckDbReconnectCreated] 编辑器检查阻止Db重连";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dbName", commonDbData.DbName);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
				connectDbObject = CommonDbConnectManager.DbConnectLru.Create(incrementId);
			}
			CommonDbConnectManager.DbConnectLru.Put(connectDbObject);
			return connectDbObject;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00039F24 File Offset: 0x00038124
		[NullableContext(1)]
		private static CommonDbData InitConnectDbData(string dbName, string command, string culture)
		{
			int num = CommonDbConnectManager.CreateIncrementId();
			CommonDbData commonDbData = new CommonDbData(num, dbName, command, culture);
			CommonDbConnectManager.CommonDbDataMap[num] = commonDbData;
			return commonDbData;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00039F50 File Offset: 0x00038150
		[NullableContext(1)]
		public static int InitDataStatement(int incrementId, string dbName, string command)
		{
			if (incrementId != 0)
			{
				return incrementId;
			}
			if (string.IsNullOrEmpty(dbName))
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "dbName为空！请确认该配置表在拆分Db表中是否有正确配置！", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return CommonDbConnectManager.InitConnectDbData(dbName, command, string.Empty).IncrementId;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00039F98 File Offset: 0x00038198
		[NullableContext(1)]
		public unsafe static int GetLangStatementId(string tableName, string dbName, string command, string culture = "")
		{
			if (string.IsNullOrEmpty(dbName))
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "dbName为空！请确认该配置表在拆分Db表中是否有正确配置！", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			string text = (!string.IsNullOrEmpty(culture)) ? culture : LanguageSystem.Instance.PackageLanguage;
			string key = dbName + tableName;
			Dictionary<string, int> dictionary;
			if (!CommonDbConnectManager.HandleIdMap.TryGetValue(key, out dictionary))
			{
				dictionary = new Dictionary<string, int>();
				CommonDbConnectManager.HandleIdMap[key] = dictionary;
			}
			int result;
			if (dictionary.TryGetValue(text, out result))
			{
				return result;
			}
			CommonDbData commonDbData = CommonDbConnectManager.InitConnectDbData(dbName, command, text);
			int incrementId = commonDbData.IncrementId;
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(commonDbData.IncrementId);
			if (connectDbObject == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CommonDbConnect;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "创建Db连接对象失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dbName", dbName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return incrementId;
			}
			int handleId = connectDbObject.HandleId;
			if (handleId != -2)
			{
				if (handleId == -1)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.CommonDbConnect;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "找不到语言表Db连接";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("dbName", dbName);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			else
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.CommonDbConnect;
				ELogAuthor author3 = ELogAuthor.XXJ;
				string message3 = "创建语言表语句失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dbName", dbName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("command", command);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			dictionary[text] = incrementId;
			return incrementId;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003A0FC File Offset: 0x000382FC
		[NullableContext(1)]
		public static void ClearLangAllStatementId(string tableName, string dbName)
		{
			string key = dbName + tableName;
			Dictionary<string, int> dictionary;
			if (CommonDbConnectManager.HandleIdMap.TryGetValue(key, out dictionary) && dictionary.Count > 0)
			{
				foreach (int inId in dictionary.Values)
				{
					UKuroPrepareStatementLib.DestroyStatement(inId);
				}
			}
			CommonDbConnectManager.HandleIdMap.Remove(key);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003A178 File Offset: 0x00038378
		public static bool CheckStatement(int incrementId, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			string text = string.Empty;
			bool result = true;
			if (incrementId <= 0)
			{
				text = "未调用InitDataStatement进行初始化";
			}
			else
			{
				ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
				if (connectDbObject == null)
				{
					Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[CheckStatement]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				switch (connectDbObject.HandleId)
				{
				case -2:
					text = "语句创建不成功！";
					break;
				case -1:
					text = "找不到该语句的 DB 连接！";
					break;
				case 0:
					text = "语句未初始化！";
					break;
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				result = false;
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, text, pairs);
			}
			return result;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0003A214 File Offset: 0x00038414
		public static bool BindBigInt(int incrementId, int bindingIndex, long value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[BindBigInt]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int handleId = connectDbObject.HandleId;
			bool flag = UKuroPrepareStatementLib.SetBindingValueBigInt(handleId, bindingIndex, value);
			if (!flag)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				pairs.Add(new ValueTuple<string, object>("bindingIndex", bindingIndex));
				pairs.Add(new ValueTuple<string, object>("value", value));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "绑定参数 int64 失败", pairs);
			}
			return flag;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0003A2B4 File Offset: 0x000384B4
		public static bool BindInt(int incrementId, int bindingIndex, int value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[BindInt]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int handleId = connectDbObject.HandleId;
			bool flag = UKuroPrepareStatementLib.SetBindingValueInt(handleId, bindingIndex, value);
			if (!flag)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				pairs.Add(new ValueTuple<string, object>("bindingIndex", bindingIndex));
				pairs.Add(new ValueTuple<string, object>("value", value));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "绑定参数 int32 失败", pairs);
			}
			return flag;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003A354 File Offset: 0x00038554
		public static bool BindFloat(int incrementId, int bindingIndex, float value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[BindFloat]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int handleId = connectDbObject.HandleId;
			bool flag = UKuroPrepareStatementLib.SetBindingValueFloat(handleId, bindingIndex, value);
			if (!flag)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				pairs.Add(new ValueTuple<string, object>("bindingIndex", bindingIndex));
				pairs.Add(new ValueTuple<string, object>("value", value));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "绑定参数 float 失败", pairs);
			}
			return flag;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003A3F4 File Offset: 0x000385F4
		public static bool BindFloat64(int incrementId, int bindingIndex, double value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[BindFloat64]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int handleId = connectDbObject.HandleId;
			bool flag = UKuroPrepareStatementLib.SetBindingValueFloat64(handleId, bindingIndex, value);
			if (!flag)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				pairs.Add(new ValueTuple<string, object>("bindingIndex", bindingIndex));
				pairs.Add(new ValueTuple<string, object>("value", value));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "绑定参数 float64 失败", pairs);
			}
			return flag;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003A494 File Offset: 0x00038694
		public static bool BindBool(int incrementId, int bindingIndex, bool value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[BindBool]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int handleId = connectDbObject.HandleId;
			bool flag = UKuroPrepareStatementLib.SetBindingValueBool(handleId, bindingIndex, value);
			if (!flag)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				pairs.Add(new ValueTuple<string, object>("bindingIndex", bindingIndex));
				pairs.Add(new ValueTuple<string, object>("value", value));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "绑定参数 bool 失败", pairs);
			}
			return flag;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003A534 File Offset: 0x00038734
		[NullableContext(1)]
		public static bool BindString(int incrementId, int bindingIndex, string value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[BindString]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int handleId = connectDbObject.HandleId;
			bool flag = UKuroPrepareStatementLib.SetBindingValueString(handleId, bindingIndex, value);
			if (!flag)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				pairs.Add(new ValueTuple<string, object>("bindingIndex", bindingIndex));
				pairs.Add(new ValueTuple<string, object>("value", value));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "绑定参数 string 失败", pairs);
			}
			return flag;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003A5CC File Offset: 0x000387CC
		public static bool Reset(int incrementId, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[Reset]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int handleId = connectDbObject.HandleId;
			bool flag = UKuroPrepareStatementLib.Reset(handleId);
			if (!flag)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "重置语句失败！", pairs);
			}
			return flag;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003A63C File Offset: 0x0003883C
		public static int Step(int incrementId, bool errZero = false, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[Step]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return 0;
			}
			int handleId = connectDbObject.HandleId;
			int result = UKuroPrepareStatementLib.Step(handleId);
			string text = null;
			switch (result)
			{
			case -4:
				text = "执行查询出错！";
				break;
			case -3:
				text = "事务繁忙中，查询失败！";
				break;
			case -2:
				text = "创建的语句无效或已被释放！";
				break;
			case -1:
				text = "找不到创建的语句，确认语句是否已调用过销毁，但业务还持有着句柄！";
				break;
			case 0:
				text = (errZero ? "配置表中没有该数据，请确认该问题，或修改为合理的查询！" : null);
				break;
			}
			if (text != null)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, text, pairs);
			}
			return result;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003A6F8 File Offset: 0x000388F8
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTuple<bool, byte[]> GetValue(int incrementId, int columnIndex, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[GetValue]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(87, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CommonDbConnectManager->GetValue失败, incrementId:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(incrementId);
				defaultInterpolatedStringHandler.AppendLiteral("，columnIndex:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(columnIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" 未调用InitDataStatement进行初始化");
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			int handleId = connectDbObject.HandleId;
			FArrayBuffer buffer = default(FArrayBuffer);
			bool columnValueBytes = UKuroPrepareStatementLib.GetColumnValueBytes(handleId, columnIndex, ref buffer);
			if (!columnValueBytes)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "获取配置表字段数值出错", pairs);
			}
			byte[] item = columnValueBytes ? buffer.ToByteArray() : null;
			return new ValueTuple<bool, byte[]>(columnValueBytes, item);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003A7CC File Offset: 0x000389CC
		[NullableContext(0)]
		public static ValueTuple<bool, int?> GetValueInt(int incrementId, int columnIndex, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.CreateOrGetConnectDbObject(incrementId);
			if (connectDbObject == null)
			{
				Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[GetValueInt]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return new ValueTuple<bool, int?>(false, null);
			}
			int handleId = connectDbObject.HandleId;
			int num = 0;
			bool columnValueInt = UKuroPrepareStatementLib.GetColumnValueInt32(handleId, columnIndex, ref num);
			if (!columnValueInt)
			{
				pairs.Add(new ValueTuple<string, object>("handleId", handleId));
				Log.Instance.ErrorWithLogList(ELogModule.CommonDbConnect, ELogAuthor.CYK, "获取配置表int字段数值出错", pairs);
			}
			int value = columnValueInt ? num : 0;
			return new ValueTuple<bool, int?>(columnValueInt, new int?(value));
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0003A864 File Offset: 0x00038A64
		public static void ClearBind(int incrementId)
		{
			ConnectDbObject connectDbObject = CommonDbConnectManager.DbConnectLru.Get(incrementId);
			if (connectDbObject != null)
			{
				connectDbObject.DisConnectStatement();
				return;
			}
			Log.Instance.Error(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[ClearBind]未调用InitDataStatement进行初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0003A8A4 File Offset: 0x00038AA4
		[NullableContext(1)]
		public static bool UnloadDb(string dbName)
		{
			bool flag = false;
			int num = 0;
			string b = CommonDbConnectManager.NormalizeDbName(dbName);
			foreach (KeyValuePair<int, CommonDbData> keyValuePair in CommonDbConnectManager.CommonDbDataMap)
			{
				if (CommonDbConnectManager.NormalizeDbName(keyValuePair.Value.DbName) == b)
				{
					ConnectDbObject connectDbObject = CommonDbConnectManager.DbConnectLru.Get(keyValuePair.Key);
					if (connectDbObject != null)
					{
						num++;
						flag = CommonDbConnectManager.DbConnectLru.RemoveExternal(connectDbObject);
						connectDbObject.DisConnectStatement();
					}
				}
			}
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CommonDbConnect;
				ELogAuthor author = ELogAuthor.JYT;
				string message = "卸载数据库成功";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dbName", dbName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else if (num == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.CommonDbConnect;
				ELogAuthor author2 = ELogAuthor.JYT;
				string message2 = "未找到可卸载的数据库连接";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("dbName", dbName);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			else
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.CommonDbConnect;
				ELogAuthor author3 = ELogAuthor.JYT;
				string message3 = "卸载数据库失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("dbName", dbName);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			return flag;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0003A9C4 File Offset: 0x00038BC4
		public static void CloseAllConnection()
		{
			Log.Instance.Info(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[CloseAllConnection]关闭所有Db连接", default(ReadOnlySpan<ValueTuple<string, object>>));
			CommonDbConnectManager.DbConnectLru.Clear();
			CommonDbConnectManager.HandleIdMap.Clear();
			CommonDbConnectManager.CommonDbDataMap.Clear();
			ConfigStatementLibSync.CloseAllConnection();
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0003AA10 File Offset: 0x00038C10
		public static void LogConnection()
		{
			int size = CommonDbConnectManager.DbConnectLru.Size;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonDbConnect;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[LogConnection]连接Db数量";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("connectionCount", size);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0003AA54 File Offset: 0x00038C54
		public static void DynamicChangeLruCapacity(int capacity)
		{
			CommonDbConnectManager.DbConnectLru.Capacity = capacity;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonDbConnect;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[DynamicChangeLruCapacity]修改Db连接LRU容量";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("capacity", capacity);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0003AA98 File Offset: 0x00038C98
		[NullableContext(1)]
		private static string NormalizeDbName(string dbName)
		{
			return dbName.Trim().ToLowerInvariant();
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0003AAA8 File Offset: 0x00038CA8
		public static void CreateStaticDefaultValue()
		{
			CommonDbConnectManager.InitDataStatementStat = Stat.Create("CommonDbConnectManager.InitDataStatement", "", "");
			CommonDbConnectManager.GetLangStatementIdStat = Stat.Create("CommonDbConnectManager.GetLangStatementId", "", "");
			CommonDbConnectManager.BindBigIntStat = Stat.Create("CommonDbConnectManager.BindBigInt", "", "");
			CommonDbConnectManager.BindIntStat = Stat.Create("CommonDbConnectManager.BindInt", "", "");
			CommonDbConnectManager.BindFloatStat = Stat.Create("CommonDbConnectManager.BindFloat", "", "");
			CommonDbConnectManager.BindBoolStat = Stat.Create("CommonDbConnectManager.BindBool", "", "");
			CommonDbConnectManager.BindStringStat = Stat.Create("CommonDbConnectManager.BindString", "", "");
			CommonDbConnectManager.BindFloat64Stat = Stat.Create("CommonDbConnectManager.BindFloat64Stat", "", "");
			CommonDbConnectManager.GetValueStat = Stat.Create("CommonDbConnectManager.GetValue", "", "");
			CommonDbConnectManager.GetValueIntStat = Stat.Create("CommonDbConnectManager.GetValueInt", "", "");
			CommonDbConnectManager.IncrementId = 0;
			CommonDbConnectManager.HandleIdMap = new Dictionary<string, Dictionary<string, int>>();
			CommonDbConnectManager.CommonDbDataMap = new Dictionary<int, CommonDbData>();
			CommonDbConnectManager.EditorCheckDbReconnectCreated = null;
			int db_CONNECT_LRU_SIZE = CommonDbConnectManager.DB_CONNECT_LRU_SIZE;
			Func<int, ConnectDbObject> creator;
			if ((creator = CommonDbConnectManager.<>O.<0>__LruCreator) == null)
			{
				creator = (CommonDbConnectManager.<>O.<0>__LruCreator = new Func<int, ConnectDbObject>(CommonDbConnectManager.LruCreator));
			}
			Action<ConnectDbObject> clearer;
			if ((clearer = CommonDbConnectManager.<>O.<1>__LruClearer) == null)
			{
				clearer = (CommonDbConnectManager.<>O.<1>__LruClearer = new Action<ConnectDbObject>(CommonDbConnectManager.LruClearer));
			}
			CommonDbConnectManager.DbConnectLru = new Lru<int, ConnectDbObject>(db_CONNECT_LRU_SIZE, creator, clearer);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0003AC14 File Offset: 0x00038E14
		public static void ResetStaticDefaultValue()
		{
			CommonDbConnectManager.InitDataStatementStat = null;
			CommonDbConnectManager.GetLangStatementIdStat = null;
			CommonDbConnectManager.BindBigIntStat = null;
			CommonDbConnectManager.BindIntStat = null;
			CommonDbConnectManager.BindFloatStat = null;
			CommonDbConnectManager.BindBoolStat = null;
			CommonDbConnectManager.BindStringStat = null;
			CommonDbConnectManager.BindFloat64Stat = null;
			CommonDbConnectManager.GetValueStat = null;
			CommonDbConnectManager.GetValueIntStat = null;
			CommonDbConnectManager.IncrementId = 0;
			CommonDbConnectManager.HandleIdMap = null;
			CommonDbConnectManager.CommonDbDataMap = null;
			CommonDbConnectManager.EditorCheckDbReconnectCreated = null;
			CommonDbConnectManager.DbConnectLru = null;
		}

		// Token: 0x04000718 RID: 1816
		private static readonly int DB_CONNECT_LRU_SIZE = 200;

		// Token: 0x04000719 RID: 1817
		private static Stat InitDataStatementStat;

		// Token: 0x0400071A RID: 1818
		private static Stat GetLangStatementIdStat;

		// Token: 0x0400071B RID: 1819
		private static Stat BindBigIntStat;

		// Token: 0x0400071C RID: 1820
		private static Stat BindIntStat;

		// Token: 0x0400071D RID: 1821
		private static Stat BindFloatStat;

		// Token: 0x0400071E RID: 1822
		private static Stat BindBoolStat;

		// Token: 0x0400071F RID: 1823
		private static Stat BindStringStat;

		// Token: 0x04000720 RID: 1824
		private static Stat BindFloat64Stat;

		// Token: 0x04000721 RID: 1825
		private static Stat GetValueStat;

		// Token: 0x04000722 RID: 1826
		private static Stat GetValueIntStat;

		// Token: 0x04000723 RID: 1827
		private static int IncrementId;

		// Token: 0x04000724 RID: 1828
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private static Dictionary<string, Dictionary<string, int>> HandleIdMap;

		// Token: 0x04000725 RID: 1829
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, CommonDbData> CommonDbDataMap;

		// Token: 0x04000726 RID: 1830
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Lru<int, ConnectDbObject> DbConnectLru;

		// Token: 0x04000727 RID: 1831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Func<CommonDbData, bool> EditorCheckDbReconnectCreated;

		// Token: 0x020001EA RID: 490
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400090E RID: 2318
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<int, ConnectDbObject> <0>__LruCreator;

			// Token: 0x0400090F RID: 2319
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<ConnectDbObject> <1>__LruClearer;
		}
	}
}
