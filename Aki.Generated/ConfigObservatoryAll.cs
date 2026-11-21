using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000637 RID: 1591
	public class ConfigObservatoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x001305A1 File Offset: 0x0012E7A1
		static ConfigObservatoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigObservatoryAll.CreateStaticDefaultValue), new Action(ConfigObservatoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x001305C0 File Offset: 0x0012E7C0
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

		// Token: 0x0600255C RID: 9564 RVA: 0x0013063F File Offset: 0x0012E83F
		public static void ResetStaticDefaultValue()
		{
			ConfigObservatoryAll.LogPair = null;
			ConfigObservatoryAll.HandleId = 0;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0013064D File Offset: 0x0012E84D
		public static void Init()
		{
			ConfigObservatoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigObservatoryAll.HandleId, "db_weather.db", "select BinData from `Observatory`");
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00130668 File Offset: 0x0012E868
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

		// Token: 0x04002B67 RID: 11111
		private const string DB = "db_weather.db";

		// Token: 0x04002B68 RID: 11112
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04002B69 RID: 11113
		private const string TABLE = "Observatory";

		// Token: 0x04002B6A RID: 11114
		private const string COMMAND = "select BinData from `Observatory`";

		// Token: 0x04002B6B RID: 11115
		private const string KEY_PREFIX = "ObservatoryAll";

		// Token: 0x04002B6C RID: 11116
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B6D RID: 11117
		private static int HandleId;
	}
}
