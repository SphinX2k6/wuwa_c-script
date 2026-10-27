using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061F RID: 1567
	public class ConfigObservatoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x00129B25 File Offset: 0x00127D25
		static ConfigObservatoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigObservatoryAll.CreateStaticDefaultValue), new Action(ConfigObservatoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00129B44 File Offset: 0x00127D44
		public static void CreateStaticDefaultValue()
		{
			ConfigObservatoryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigObservatoryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weather.db"),
				new ValueTuple<string, object>("文件", "t.天气系统.xlsx"),
				new ValueTuple<string, object>("表名", "Observatory"),
				new ValueTuple<string, object>("语句", "select BinData from `Observatory`")
			});
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00129BC3 File Offset: 0x00127DC3
		public static void ResetStaticDefaultValue()
		{
			ConfigObservatoryAll.LogPair = null;
			ConfigObservatoryAll.HandleId = 0;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00129BD1 File Offset: 0x00127DD1
		public static void Init()
		{
			ConfigObservatoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigObservatoryAll.HandleId, "db_weather.db", "select BinData from `Observatory`");
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00129BEC File Offset: 0x00127DEC
		[NullableContext(2)]
		public static IReadOnlyList<Observatory> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigObservatoryAll.HandleId, ConfigObservatoryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Observatory> readOnlyList = (IReadOnlyList<Observatory>)ConfigCommon.GetConfig("ObservatoryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Observatory> list = new List<Observatory>();
			while (ConfigCommon.Step(ConfigObservatoryAll.HandleId, false, ConfigObservatoryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigObservatoryAll.HandleId, 0, ConfigObservatoryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigObservatoryAll.HandleId, ConfigObservatoryAll.LogPair);
					return null;
				}
				Observatory rootAsObservatory = Observatory.GetRootAsObservatory(new ByteBuffer(item2));
				list.Add(rootAsObservatory);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ObservatoryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigObservatoryAll.HandleId, ConfigObservatoryAll.LogPair);
			return list;
		}

		// Token: 0x04002ABF RID: 10943
		private const string DB = "db_weather.db";

		// Token: 0x04002AC0 RID: 10944
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04002AC1 RID: 10945
		private const string TABLE = "Observatory";

		// Token: 0x04002AC2 RID: 10946
		private const string COMMAND = "select BinData from `Observatory`";

		// Token: 0x04002AC3 RID: 10947
		private const string KEY_PREFIX = "ObservatoryAll";

		// Token: 0x04002AC4 RID: 10948
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AC5 RID: 10949
		private static int HandleId;
	}
}
