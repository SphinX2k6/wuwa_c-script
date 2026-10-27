using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Common.Proxy
{
	// Token: 0x0200001E RID: 30
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfigCommon
	{
		// Token: 0x060000CD RID: 205 RVA: 0x0000B231 File Offset: 0x00009431
		public static int InitDataStatement(int handleId, string dbName, string command)
		{
			Func<int, string, string, int> initDataStatementFunc = ConfigCommon.InitDataStatementFunc;
			if (initDataStatementFunc == null)
			{
				return 0;
			}
			return initDataStatementFunc(handleId, dbName, command);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000B246 File Offset: 0x00009446
		public static bool CheckStatement(int handleId, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, LogList<ValueTuple<string, object>>, bool> checkStatementFunc = ConfigCommon.CheckStatementFunc;
			return checkStatementFunc != null && checkStatementFunc(handleId, pairs);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000B25A File Offset: 0x0000945A
		public static bool BindInt(int handleId, int bindingIndex, int value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, int, int, LogList<ValueTuple<string, object>>, bool> bindIntFunc = ConfigCommon.BindIntFunc;
			return bindIntFunc != null && bindIntFunc(handleId, bindingIndex, value, pairs);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000B270 File Offset: 0x00009470
		public static int Step(int handleId, bool errZero = false, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, bool, LogList<ValueTuple<string, object>>, int> stepFunc = ConfigCommon.StepFunc;
			if (stepFunc == null)
			{
				return 0;
			}
			return stepFunc(handleId, errZero, pairs);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000B288 File Offset: 0x00009488
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTuple<bool, byte[]> GetValue(int handleId, int columnIndex, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, byte[]>> getValueFunc = ConfigCommon.GetValueFunc;
			if (getValueFunc == null)
			{
				return default(ValueTuple<bool, byte[]>);
			}
			return getValueFunc(handleId, columnIndex, pairs);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[NullableContext(0)]
		public static ValueTuple<bool, int?> GetValueInt(int handleId, int columnIndex, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, int?>> getValueIntFunc = ConfigCommon.GetValueIntFunc;
			if (getValueIntFunc == null)
			{
				return default(ValueTuple<bool, int?>);
			}
			return getValueIntFunc(handleId, columnIndex, pairs);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000B2D8 File Offset: 0x000094D8
		public static bool Reset(int handleId, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, LogList<ValueTuple<string, object>>, bool> resetFunc = ConfigCommon.ResetFunc;
			return resetFunc != null && resetFunc(handleId, pairs);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000B2EC File Offset: 0x000094EC
		public static bool BindString(int handleId, int bindingIndex, string value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, int, string, LogList<ValueTuple<string, object>>, bool> bindStringFunc = ConfigCommon.BindStringFunc;
			return bindStringFunc != null && bindStringFunc(handleId, bindingIndex, value, pairs);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000B302 File Offset: 0x00009502
		public static int GetLangStatementId(string tableName, string dbName, string command, string culture = "")
		{
			Func<string, string, string, string, int> getLangStatementIdFunc = ConfigCommon.GetLangStatementIdFunc;
			if (getLangStatementIdFunc == null)
			{
				return 0;
			}
			return getLangStatementIdFunc(tableName, dbName, command, culture);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000B318 File Offset: 0x00009518
		public static void ClearLangAllStatementId(string tableName, string dbName)
		{
			Action<string, string> clearLangAllStatementIdAction = ConfigCommon.ClearLangAllStatementIdAction;
			if (clearLangAllStatementIdAction == null)
			{
				return;
			}
			clearLangAllStatementIdAction(tableName, dbName);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000B32B File Offset: 0x0000952B
		public static bool BindBool(int handleId, int bindingIndex, bool value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, int, bool, LogList<ValueTuple<string, object>>, bool> bindBoolFunc = ConfigCommon.BindBoolFunc;
			return bindBoolFunc != null && bindBoolFunc(handleId, bindingIndex, value, pairs);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000B341 File Offset: 0x00009541
		public static bool BindFloat64(int handleId, int bindingIndex, double value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, int, double, LogList<ValueTuple<string, object>>, bool> bindFloat64Func = ConfigCommon.BindFloat64Func;
			return bindFloat64Func != null && bindFloat64Func(handleId, bindingIndex, value, pairs);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000B357 File Offset: 0x00009557
		public static bool BindBigInt(int handleId, int bindingIndex, long value, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			Func<int, int, long, LogList<ValueTuple<string, object>>, bool> bindBigIntFunc = ConfigCommon.BindBigIntFunc;
			return bindBigIntFunc != null && bindBigIntFunc(handleId, bindingIndex, value, pairs);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000B36D File Offset: 0x0000956D
		[return: Nullable(2)]
		public static object GetConfig(string key)
		{
			Func<string, object> getConfigFunc = ConfigCommon.GetConfigFunc;
			if (getConfigFunc == null)
			{
				return null;
			}
			return getConfigFunc(key);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000B380 File Offset: 0x00009580
		public static void SaveConfig(string key, object config, int valueSize = 1)
		{
			Action<string, object, int> saveConfigAction = ConfigCommon.SaveConfigAction;
			if (saveConfigAction == null)
			{
				return;
			}
			saveConfigAction(key, config, valueSize);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000B394 File Offset: 0x00009594
		[return: Nullable(2)]
		public static ByteBuffer GetConfigBuffer(string key)
		{
			Func<string, ByteBuffer> getConfigBufferFunc = ConfigCommon.GetConfigBufferFunc;
			if (getConfigBufferFunc == null)
			{
				return null;
			}
			return getConfigBufferFunc(key);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000B3A7 File Offset: 0x000095A7
		public static void SaveConfigBuffer(string key, ByteBuffer configBuffer, int valueSize = 1)
		{
			Action<string, ByteBuffer, int> saveConfigBufferAction = ConfigCommon.SaveConfigBufferAction;
			if (saveConfigBufferAction == null)
			{
				return;
			}
			saveConfigBufferAction(key, configBuffer, valueSize);
		}

		// Token: 0x04000222 RID: 546
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Func<int, string, string, int> InitDataStatementFunc;

		// Token: 0x04000223 RID: 547
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, LogList<ValueTuple<string, object>>, bool> CheckStatementFunc;

		// Token: 0x04000224 RID: 548
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, int, LogList<ValueTuple<string, object>>, bool> BindIntFunc;

		// Token: 0x04000225 RID: 549
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, bool, LogList<ValueTuple<string, object>>, int> StepFunc;

		// Token: 0x04000226 RID: 550
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2,
			0,
			2
		})]
		public static Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, byte[]>> GetValueFunc;

		// Token: 0x04000227 RID: 551
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2,
			0
		})]
		public static Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, int?>> GetValueIntFunc;

		// Token: 0x04000228 RID: 552
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, LogList<ValueTuple<string, object>>, bool> ResetFunc;

		// Token: 0x04000229 RID: 553
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, string, LogList<ValueTuple<string, object>>, bool> BindStringFunc;

		// Token: 0x0400022A RID: 554
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1
		})]
		public static Func<string, string, string, string, int> GetLangStatementIdFunc;

		// Token: 0x0400022B RID: 555
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Action<string, string> ClearLangAllStatementIdAction;

		// Token: 0x0400022C RID: 556
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, bool, LogList<ValueTuple<string, object>>, bool> BindBoolFunc;

		// Token: 0x0400022D RID: 557
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, double, LogList<ValueTuple<string, object>>, bool> BindFloat64Func;

		// Token: 0x0400022E RID: 558
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, long, LogList<ValueTuple<string, object>>, bool> BindBigIntFunc;

		// Token: 0x0400022F RID: 559
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public static Func<string, object> GetConfigFunc;

		// Token: 0x04000230 RID: 560
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Action<string, object, int> SaveConfigAction;

		// Token: 0x04000231 RID: 561
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public static Func<string, ByteBuffer> GetConfigBufferFunc;

		// Token: 0x04000232 RID: 562
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Action<string, ByteBuffer, int> SaveConfigBufferAction;

		// Token: 0x04000233 RID: 563
		[Nullable(2)]
		public static IStat AllConfigStatementStat;
	}
}
