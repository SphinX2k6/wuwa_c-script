using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace CSharpScript.Core.Utils
{
	// Token: 0x02000129 RID: 297
	public class GeneratedUtils
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x000340B4 File Offset: 0x000322B4
		public static void Init()
		{
			Aki.Common.Proxy.Log.SetInstance(global::Log.Instance);
			Func<int, string, string, int> initDataStatementFunc;
			if ((initDataStatementFunc = GeneratedUtils.<>O.<0>__InitDataStatement) == null)
			{
				initDataStatementFunc = (GeneratedUtils.<>O.<0>__InitDataStatement = new Func<int, string, string, int>(global::ConfigCommon.InitDataStatement));
			}
			Aki.Common.Proxy.ConfigCommon.InitDataStatementFunc = initDataStatementFunc;
			Func<int, LogList<ValueTuple<string, object>>, bool> checkStatementFunc;
			if ((checkStatementFunc = GeneratedUtils.<>O.<1>__CheckStatement) == null)
			{
				checkStatementFunc = (GeneratedUtils.<>O.<1>__CheckStatement = new Func<int, LogList<ValueTuple<string, object>>, bool>(global::ConfigCommon.CheckStatement));
			}
			Aki.Common.Proxy.ConfigCommon.CheckStatementFunc = checkStatementFunc;
			Func<int, int, int, LogList<ValueTuple<string, object>>, bool> bindIntFunc;
			if ((bindIntFunc = GeneratedUtils.<>O.<2>__BindInt) == null)
			{
				bindIntFunc = (GeneratedUtils.<>O.<2>__BindInt = new Func<int, int, int, LogList<ValueTuple<string, object>>, bool>(global::ConfigCommon.BindInt));
			}
			Aki.Common.Proxy.ConfigCommon.BindIntFunc = bindIntFunc;
			Func<int, bool, LogList<ValueTuple<string, object>>, int> stepFunc;
			if ((stepFunc = GeneratedUtils.<>O.<3>__Step) == null)
			{
				stepFunc = (GeneratedUtils.<>O.<3>__Step = new Func<int, bool, LogList<ValueTuple<string, object>>, int>(global::ConfigCommon.Step));
			}
			Aki.Common.Proxy.ConfigCommon.StepFunc = stepFunc;
			Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, byte[]>> getValueFunc;
			if ((getValueFunc = GeneratedUtils.<>O.<4>__GetValue) == null)
			{
				getValueFunc = (GeneratedUtils.<>O.<4>__GetValue = new Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, byte[]>>(global::ConfigCommon.GetValue));
			}
			Aki.Common.Proxy.ConfigCommon.GetValueFunc = getValueFunc;
			Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, int?>> getValueIntFunc;
			if ((getValueIntFunc = GeneratedUtils.<>O.<5>__GetValueInt) == null)
			{
				getValueIntFunc = (GeneratedUtils.<>O.<5>__GetValueInt = new Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, int?>>(global::ConfigCommon.GetValueInt));
			}
			Aki.Common.Proxy.ConfigCommon.GetValueIntFunc = getValueIntFunc;
			Func<int, LogList<ValueTuple<string, object>>, bool> resetFunc;
			if ((resetFunc = GeneratedUtils.<>O.<6>__Reset) == null)
			{
				resetFunc = (GeneratedUtils.<>O.<6>__Reset = new Func<int, LogList<ValueTuple<string, object>>, bool>(global::ConfigCommon.Reset));
			}
			Aki.Common.Proxy.ConfigCommon.ResetFunc = resetFunc;
			Func<int, int, string, LogList<ValueTuple<string, object>>, bool> bindStringFunc;
			if ((bindStringFunc = GeneratedUtils.<>O.<7>__BindString) == null)
			{
				bindStringFunc = (GeneratedUtils.<>O.<7>__BindString = new Func<int, int, string, LogList<ValueTuple<string, object>>, bool>(global::ConfigCommon.BindString));
			}
			Aki.Common.Proxy.ConfigCommon.BindStringFunc = bindStringFunc;
			Func<string, string, string, string, int> getLangStatementIdFunc;
			if ((getLangStatementIdFunc = GeneratedUtils.<>O.<8>__GetLangStatementId) == null)
			{
				getLangStatementIdFunc = (GeneratedUtils.<>O.<8>__GetLangStatementId = new Func<string, string, string, string, int>(global::ConfigCommon.GetLangStatementId));
			}
			Aki.Common.Proxy.ConfigCommon.GetLangStatementIdFunc = getLangStatementIdFunc;
			Action<string, string> clearLangAllStatementIdAction;
			if ((clearLangAllStatementIdAction = GeneratedUtils.<>O.<9>__ClearLangAllStatementId) == null)
			{
				clearLangAllStatementIdAction = (GeneratedUtils.<>O.<9>__ClearLangAllStatementId = new Action<string, string>(global::ConfigCommon.ClearLangAllStatementId));
			}
			Aki.Common.Proxy.ConfigCommon.ClearLangAllStatementIdAction = clearLangAllStatementIdAction;
			Func<int, int, bool, LogList<ValueTuple<string, object>>, bool> bindBoolFunc;
			if ((bindBoolFunc = GeneratedUtils.<>O.<10>__BindBool) == null)
			{
				bindBoolFunc = (GeneratedUtils.<>O.<10>__BindBool = new Func<int, int, bool, LogList<ValueTuple<string, object>>, bool>(global::ConfigCommon.BindBool));
			}
			Aki.Common.Proxy.ConfigCommon.BindBoolFunc = bindBoolFunc;
			Func<int, int, double, LogList<ValueTuple<string, object>>, bool> bindFloat64Func;
			if ((bindFloat64Func = GeneratedUtils.<>O.<11>__BindFloat64) == null)
			{
				bindFloat64Func = (GeneratedUtils.<>O.<11>__BindFloat64 = new Func<int, int, double, LogList<ValueTuple<string, object>>, bool>(global::ConfigCommon.BindFloat64));
			}
			Aki.Common.Proxy.ConfigCommon.BindFloat64Func = bindFloat64Func;
			Func<int, int, long, LogList<ValueTuple<string, object>>, bool> bindBigIntFunc;
			if ((bindBigIntFunc = GeneratedUtils.<>O.<12>__BindBigInt) == null)
			{
				bindBigIntFunc = (GeneratedUtils.<>O.<12>__BindBigInt = new Func<int, int, long, LogList<ValueTuple<string, object>>, bool>(global::ConfigCommon.BindBigInt));
			}
			Aki.Common.Proxy.ConfigCommon.BindBigIntFunc = bindBigIntFunc;
			Func<string, object> getConfigFunc;
			if ((getConfigFunc = GeneratedUtils.<>O.<13>__GetConfig) == null)
			{
				getConfigFunc = (GeneratedUtils.<>O.<13>__GetConfig = new Func<string, object>(global::ConfigCommon.GetConfig));
			}
			Aki.Common.Proxy.ConfigCommon.GetConfigFunc = getConfigFunc;
			Action<string, object, int> saveConfigAction;
			if ((saveConfigAction = GeneratedUtils.<>O.<14>__SaveConfig) == null)
			{
				saveConfigAction = (GeneratedUtils.<>O.<14>__SaveConfig = new Action<string, object, int>(global::ConfigCommon.SaveConfig));
			}
			Aki.Common.Proxy.ConfigCommon.SaveConfigAction = saveConfigAction;
			Func<string, ByteBuffer> getConfigBufferFunc;
			if ((getConfigBufferFunc = GeneratedUtils.<>O.<15>__GetConfigBuffer) == null)
			{
				getConfigBufferFunc = (GeneratedUtils.<>O.<15>__GetConfigBuffer = new Func<string, ByteBuffer>(global::ConfigCommon.GetConfigBuffer));
			}
			Aki.Common.Proxy.ConfigCommon.GetConfigBufferFunc = getConfigBufferFunc;
			Action<string, ByteBuffer, int> saveConfigBufferAction;
			if ((saveConfigBufferAction = GeneratedUtils.<>O.<16>__SaveConfigBuffer) == null)
			{
				saveConfigBufferAction = (GeneratedUtils.<>O.<16>__SaveConfigBuffer = new Action<string, ByteBuffer, int>(global::ConfigCommon.SaveConfigBuffer));
			}
			Aki.Common.Proxy.ConfigCommon.SaveConfigBufferAction = saveConfigBufferAction;
			Aki.Common.Proxy.ConfigCommon.AllConfigStatementStat = global::ConfigCommon.AllConfigStatementStat;
			Aki.Common.Proxy.DeserializeConfig.SetInstance(global::DeserializeConfig.Instance);
			Aki.Common.Proxy.LanguageSystem.SetInstance(global::LanguageSystem.Instance);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003430C File Offset: 0x0003250C
		public static void Clear()
		{
			Aki.Common.Proxy.ConfigCommon.InitDataStatementFunc = null;
			Aki.Common.Proxy.ConfigCommon.CheckStatementFunc = null;
			Aki.Common.Proxy.ConfigCommon.BindIntFunc = null;
			Aki.Common.Proxy.ConfigCommon.StepFunc = null;
			Aki.Common.Proxy.ConfigCommon.GetValueFunc = null;
			Aki.Common.Proxy.ConfigCommon.GetValueIntFunc = null;
			Aki.Common.Proxy.ConfigCommon.ResetFunc = null;
			Aki.Common.Proxy.ConfigCommon.BindStringFunc = null;
			Aki.Common.Proxy.ConfigCommon.GetLangStatementIdFunc = null;
			Aki.Common.Proxy.ConfigCommon.ClearLangAllStatementIdAction = null;
			Aki.Common.Proxy.ConfigCommon.BindBoolFunc = null;
			Aki.Common.Proxy.ConfigCommon.BindFloat64Func = null;
			Aki.Common.Proxy.ConfigCommon.BindBigIntFunc = null;
			Aki.Common.Proxy.ConfigCommon.GetConfigFunc = null;
			Aki.Common.Proxy.ConfigCommon.SaveConfigAction = null;
			Aki.Common.Proxy.ConfigCommon.GetConfigBufferFunc = null;
			Aki.Common.Proxy.ConfigCommon.SaveConfigBufferAction = null;
			Aki.Common.Proxy.ConfigCommon.AllConfigStatementStat = null;
			Aki.Common.Proxy.DeserializeConfig.SetInstance(null);
			Aki.Common.Proxy.LanguageSystem.SetInstance(null);
			Aki.Common.Proxy.Log.SetInstance(null);
		}

		// Token: 0x020001D5 RID: 469
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400088D RID: 2189
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Func<int, string, string, int> <0>__InitDataStatement;

			// Token: 0x0400088E RID: 2190
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2
			})]
			public static Func<int, LogList<ValueTuple<string, object>>, bool> <1>__CheckStatement;

			// Token: 0x0400088F RID: 2191
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2
			})]
			public static Func<int, int, int, LogList<ValueTuple<string, object>>, bool> <2>__BindInt;

			// Token: 0x04000890 RID: 2192
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2
			})]
			public static Func<int, bool, LogList<ValueTuple<string, object>>, int> <3>__Step;

			// Token: 0x04000891 RID: 2193
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2,
				0,
				2
			})]
			public static Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, byte[]>> <4>__GetValue;

			// Token: 0x04000892 RID: 2194
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2,
				0
			})]
			public static Func<int, int, LogList<ValueTuple<string, object>>, ValueTuple<bool, int?>> <5>__GetValueInt;

			// Token: 0x04000893 RID: 2195
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2
			})]
			public static Func<int, LogList<ValueTuple<string, object>>, bool> <6>__Reset;

			// Token: 0x04000894 RID: 2196
			[Nullable(new byte[]
			{
				0,
				1,
				1,
				0,
				1,
				2
			})]
			public static Func<int, int, string, LogList<ValueTuple<string, object>>, bool> <7>__BindString;

			// Token: 0x04000895 RID: 2197
			[Nullable(new byte[]
			{
				0,
				1,
				1,
				1,
				1
			})]
			public static Func<string, string, string, string, int> <8>__GetLangStatementId;

			// Token: 0x04000896 RID: 2198
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<string, string> <9>__ClearLangAllStatementId;

			// Token: 0x04000897 RID: 2199
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2
			})]
			public static Func<int, int, bool, LogList<ValueTuple<string, object>>, bool> <10>__BindBool;

			// Token: 0x04000898 RID: 2200
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2
			})]
			public static Func<int, int, double, LogList<ValueTuple<string, object>>, bool> <11>__BindFloat64;

			// Token: 0x04000899 RID: 2201
			[Nullable(new byte[]
			{
				0,
				1,
				0,
				1,
				2
			})]
			public static Func<int, int, long, LogList<ValueTuple<string, object>>, bool> <12>__BindBigInt;

			// Token: 0x0400089A RID: 2202
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Func<string, object> <13>__GetConfig;

			// Token: 0x0400089B RID: 2203
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<string, object, int> <14>__SaveConfig;

			// Token: 0x0400089C RID: 2204
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Func<string, ByteBuffer> <15>__GetConfigBuffer;

			// Token: 0x0400089D RID: 2205
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<string, ByteBuffer, int> <16>__SaveConfigBuffer;
		}
	}
}
