using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000848 RID: 2120
	public class ConfigRogueResEventCueByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031C2 RID: 12738 RVA: 0x00172CE0 File Offset: 0x00170EE0
		static ConfigRogueResEventCueByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventCueByType.CreateStaticDefaultValue), new Action(ConfigRogueResEventCueByType.ResetStaticDefaultValue));
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x00172D00 File Offset: 0x00170F00
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventCueByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventCueByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEventCue"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEventCue` where Type=?")
			});
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x00172D7F File Offset: 0x00170F7F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventCueByType.LogPair = null;
			ConfigRogueResEventCueByType.HandleId = 0;
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x00172D8D File Offset: 0x00170F8D
		public static void Init()
		{
			ConfigRogueResEventCueByType.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventCueByType.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventCue` where Type=?");
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x00172DA8 File Offset: 0x00170FA8
		public static RogueResEventCue? GetConfig(string p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventCueByType.HandleId, ConfigRogueResEventCueByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("RogueResEventCueByType#" + p0Type);
				if (configBuffer != null)
				{
					return new RogueResEventCue?(RogueResEventCue.GetRootAsRogueResEventCue(configBuffer));
				}
			}
			ConfigRogueResEventCueByType.LogPair.Clear();
			ConfigRogueResEventCueByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindString(ConfigRogueResEventCueByType.HandleId, 1, p0Type, ConfigRogueResEventCueByType.LogPair) || ConfigCommon.Step(ConfigRogueResEventCueByType.HandleId, true, ConfigRogueResEventCueByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventCueByType.HandleId, ConfigRogueResEventCueByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventCueByType.HandleId, 0, ConfigRogueResEventCueByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventCueByType.HandleId, ConfigRogueResEventCueByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEventCue rootAsRogueResEventCue = RogueResEventCue.GetRootAsRogueResEventCue(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("RogueResEventCueByType#" + p0Type, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventCueByType.HandleId, ConfigRogueResEventCueByType.LogPair);
			return new RogueResEventCue?(rootAsRogueResEventCue);
		}

		// Token: 0x040039DE RID: 14814
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039DF RID: 14815
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039E0 RID: 14816
		private const string TABLE = "RogueResEventCue";

		// Token: 0x040039E1 RID: 14817
		private const string COMMAND = "select BinData from `RogueResEventCue` where Type=?";

		// Token: 0x040039E2 RID: 14818
		private const string KEY_PREFIX = "RogueResEventCueByType";

		// Token: 0x040039E3 RID: 14819
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039E4 RID: 14820
		private static int HandleId;
	}
}
