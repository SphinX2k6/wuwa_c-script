using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extensions;
using UnrealEngine;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000160 RID: 352
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonDbConnectManager : IStaticVariableResetter
	{
		// Token: 0x06000C13 RID: 3091 RVA: 0x000390B8 File Offset: 0x000372B8
		static CommonDbConnectManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonDbConnectManager.CreateStaticDefaultValue), new Action(CommonDbConnectManager.ResetStaticDefaultValue));
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000390E1 File Offset: 0x000372E1
		private static int CreateIncrementId()
		{
			return ++CommonDbConnectManager.IncrementId;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000390F0 File Offset: 0x000372F0
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

		// Token: 0x06000C16 RID: 3094 RVA: 0x0003914F File Offset: 0x0003734F
		[NullableContext(1)]
		private static void LruClearer(ConnectDbObject data)
		{
			data.DisConnectStatement();
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00039158 File Offset: 0x00037358
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

		// Token: 0x06000C18 RID: 3096 RVA: 0x000391E0 File Offset: 0x000373E0
		[NullableContext(1)]
		private static CommonDbData InitConnectDbData(string dbName, string command, string culture)
		{
			int num = CommonDbConnectManager.CreateIncrementId();
			CommonDbData commonDbData = new CommonDbData(num, dbName, command, culture);
			CommonDbConnectManager.CommonDbDataMap[num] = commonDbData;
			return commonDbData;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0003920C File Offset: 0x0003740C
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

		// Token: 0x06000C1A RID: 3098 RVA: 0x00039254 File Offset: 0x00037454
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

		// Token: 0x06000C1B RID: 3099 RVA: 0x000393B8 File Offset: 0x000375B8
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

		// Token: 0x06000C1C RID: 3100 RVA: 0x00039434 File Offset: 0x00037634
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

		// Token: 0x06000C1D RID: 3101 RVA: 0x000394D0 File Offset: 0x000376D0
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

		// Token: 0x06000C1E RID: 3102 RVA: 0x00039570 File Offset: 0x00037770
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

		// Token: 0x06000C1F RID: 3103 RVA: 0x00039610 File Offset: 0x00037810
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

		// Token: 0x06000C20 RID: 3104 RVA: 0x000396B0 File Offset: 0x000378B0
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

		// Token: 0x06000C21 RID: 3105 RVA: 0x00039750 File Offset: 0x00037950
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

		// Token: 0x06000C22 RID: 3106 RVA: 0x000397F0 File Offset: 0x000379F0
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

		// Token: 0x06000C23 RID: 3107 RVA: 0x00039888 File Offset: 0x00037A88
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

		// Token: 0x06000C24 RID: 3108 RVA: 0x000398F8 File Offset: 0x00037AF8
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

		// Token: 0x06000C25 RID: 3109 RVA: 0x000399B4 File Offset: 0x00037BB4
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

		// Token: 0x06000C26 RID: 3110 RVA: 0x00039A88 File Offset: 0x00037C88
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

		// Token: 0x06000C27 RID: 3111 RVA: 0x00039B20 File Offset: 0x00037D20
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

		// Token: 0x06000C28 RID: 3112 RVA: 0x00039B60 File Offset: 0x00037D60
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

		// Token: 0x06000C29 RID: 3113 RVA: 0x00039C80 File Offset: 0x00037E80
		public static void CloseAllConnection()
		{
			Log.Instance.Info(ELogModule.CommonDbConnect, ELogAuthor.XXJ, "[CloseAllConnection]关闭所有Db连接", default(ReadOnlySpan<ValueTuple<string, object>>));
			CommonDbConnectManager.DbConnectLru.Clear();
			CommonDbConnectManager.HandleIdMap.Clear();
			CommonDbConnectManager.CommonDbDataMap.Clear();
			ConfigStatementLibSync.CloseAllConnection();
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00039CCC File Offset: 0x00037ECC
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

		// Token: 0x06000C2B RID: 3115 RVA: 0x00039D10 File Offset: 0x00037F10
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

		// Token: 0x06000C2C RID: 3116 RVA: 0x00039D54 File Offset: 0x00037F54
		[NullableContext(1)]
		private static string NormalizeDbName(string dbName)
		{
			return dbName.Trim().ToLowerInvariant();
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00039D64 File Offset: 0x00037F64
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

		// Token: 0x06000C2E RID: 3118 RVA: 0x00039ED0 File Offset: 0x000380D0
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

		// Token: 0x04000709 RID: 1801
		private static readonly int DB_CONNECT_LRU_SIZE = 200;

		// Token: 0x0400070A RID: 1802
		private static Stat InitDataStatementStat;

		// Token: 0x0400070B RID: 1803
		private static Stat GetLangStatementIdStat;

		// Token: 0x0400070C RID: 1804
		private static Stat BindBigIntStat;

		// Token: 0x0400070D RID: 1805
		private static Stat BindIntStat;

		// Token: 0x0400070E RID: 1806
		private static Stat BindFloatStat;

		// Token: 0x0400070F RID: 1807
		private static Stat BindBoolStat;

		// Token: 0x04000710 RID: 1808
		private static Stat BindStringStat;

		// Token: 0x04000711 RID: 1809
		private static Stat BindFloat64Stat;

		// Token: 0x04000712 RID: 1810
		private static Stat GetValueStat;

		// Token: 0x04000713 RID: 1811
		private static Stat GetValueIntStat;

		// Token: 0x04000714 RID: 1812
		private static int IncrementId;

		// Token: 0x04000715 RID: 1813
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private static Dictionary<string, Dictionary<string, int>> HandleIdMap;

		// Token: 0x04000716 RID: 1814
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, CommonDbData> CommonDbDataMap;

		// Token: 0x04000717 RID: 1815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Lru<int, ConnectDbObject> DbConnectLru;

		// Token: 0x04000718 RID: 1816
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Func<CommonDbData, bool> EditorCheckDbReconnectCreated;

		// Token: 0x020001E6 RID: 486
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040008ED RID: 2285
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<int, ConnectDbObject> <0>__LruCreator;

			// Token: 0x040008EE RID: 2286
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<ConnectDbObject> <1>__LruClearer;
		}
	}
}
