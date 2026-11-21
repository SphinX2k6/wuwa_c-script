using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Common.Proxy
{
	// Token: 0x0200001F RID: 31
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfigCommon
	{
		// Token: 0x0600013A RID: 314 RVA: 0x0000E9FD File Offset: 0x0000CBFD
		public static int InitDataStatement(int handleId, string dbName, string command)
		{
			Func<int, string, string, int> initDataStatementFunc = ConfigCommon.InitDataStatementFunc;
			if (initDataStatementFunc == null)
			{
				return 0;
			}
			return initDataStatementFunc(handleId, dbName, command);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000EA12 File Offset: 0x0000CC12
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

		// Token: 0x0600013C RID: 316 RVA: 0x0000EA26 File Offset: 0x0000CC26
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

		// Token: 0x0600013D RID: 317 RVA: 0x0000EA3C File Offset: 0x0000CC3C
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

		// Token: 0x0600013E RID: 318 RVA: 0x0000EA54 File Offset: 0x0000CC54
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

		// Token: 0x0600013F RID: 319 RVA: 0x0000EA7C File Offset: 0x0000CC7C
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

		// Token: 0x06000140 RID: 320 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
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

		// Token: 0x06000141 RID: 321 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
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

		// Token: 0x06000142 RID: 322 RVA: 0x0000EACE File Offset: 0x0000CCCE
		public static int GetLangStatementId(string tableName, string dbName, string command, string culture = "")
		{
			Func<string, string, string, string, int> getLangStatementIdFunc = ConfigCommon.GetLangStatementIdFunc;
			if (getLangStatementIdFunc == null)
			{
				return 0;
			}
			return getLangStatementIdFunc(tableName, dbName, command, culture);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		public static void ClearLangAllStatementId(string tableName, string dbName)
		{
			Action<string, string> clearLangAllStatementIdAction = ConfigCommon.ClearLangAllStatementIdAction;
			if (clearLangAllStatementIdAction == null)
			{
				return;
			}
			clearLangAllStatementIdAction(tableName, dbName);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000EAF7 File Offset: 0x0000CCF7
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

		// Token: 0x06000145 RID: 325 RVA: 0x0000EB0D File Offset: 0x0000CD0D
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

		// Token: 0x06000146 RID: 326 RVA: 0x0000EB23 File Offset: 0x0000CD23
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

		// Token: 0x06000147 RID: 327 RVA: 0x0000EB39 File Offset: 0x0000CD39
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

		// Token: 0x06000148 RID: 328 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		public static void SaveConfig(string key, object config, int valueSize = 1)
		{
			Action<string, object, int> saveConfigAction = ConfigCommon.SaveConfigAction;
			if (saveConfigAction == null)
			{
				return;
			}
			saveConfigAction(key, config, valueSize);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000EB60 File Offset: 0x0000CD60
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

		// Token: 0x0600014A RID: 330 RVA: 0x0000EB73 File Offset: 0x0000CD73
		public static void SaveConfigBuffer(string key, ByteBuffer configBuffer, int valueSize = 1)
		{
			Action<string, ByteBuffer, int> saveConfigBufferAction = ConfigCommon.SaveConfigBufferAction;
			if (saveConfigBufferAction == null)
			{
				return;
			}
			saveConfigBufferAction(key, configBuffer, valueSize);
		}

		// Token: 0x04000227 RID: 551
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Func<int, string, string, int> InitDataStatementFunc;

		// Token: 0x04000228 RID: 552
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, LogList<ValueTuple<string, object>>, bool> CheckStatementFunc;

		// Token: 0x04000229 RID: 553
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, int, LogList<ValueTuple<string, object>>, bool> BindIntFunc;

		// Token: 0x0400022A RID: 554
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, bool, LogList<ValueTuple<string, object>>, int> StepFunc;

		// Token: 0x0400022B RID: 555
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

		// Token: 0x0400022C RID: 556
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

		// Token: 0x0400022D RID: 557
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, LogList<ValueTuple<string, object>>, bool> ResetFunc;

		// Token: 0x0400022E RID: 558
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

		// Token: 0x0400022F RID: 559
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1
		})]
		public static Func<string, string, string, string, int> GetLangStatementIdFunc;

		// Token: 0x04000230 RID: 560
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Action<string, string> ClearLangAllStatementIdAction;

		// Token: 0x04000231 RID: 561
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, bool, LogList<ValueTuple<string, object>>, bool> BindBoolFunc;

		// Token: 0x04000232 RID: 562
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, double, LogList<ValueTuple<string, object>>, bool> BindFloat64Func;

		// Token: 0x04000233 RID: 563
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			2
		})]
		public static Func<int, int, long, LogList<ValueTuple<string, object>>, bool> BindBigIntFunc;

		// Token: 0x04000234 RID: 564
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public static Func<string, object> GetConfigFunc;

		// Token: 0x04000235 RID: 565
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Action<string, object, int> SaveConfigAction;

		// Token: 0x04000236 RID: 566
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public static Func<string, ByteBuffer> GetConfigBufferFunc;

		// Token: 0x04000237 RID: 567
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Action<string, ByteBuffer, int> SaveConfigBufferAction;

		// Token: 0x04000238 RID: 568
		[Nullable(2)]
		public static IStat AllConfigStatementStat;
	}
}
