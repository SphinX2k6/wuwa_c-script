using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000864 RID: 2148
	public class ConfigRogueResEventCueByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600326A RID: 12906 RVA: 0x00179FC8 File Offset: 0x001781C8
		static ConfigRogueResEventCueByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventCueByType.CreateStaticDefaultValue), new Action(ConfigRogueResEventCueByType.ResetStaticDefaultValue));
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00179FE8 File Offset: 0x001781E8
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

		// Token: 0x0600326C RID: 12908 RVA: 0x0017A067 File Offset: 0x00178267
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventCueByType.LogPair = null;
			ConfigRogueResEventCueByType.HandleId = 0;
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x0017A075 File Offset: 0x00178275
		public static void Init()
		{
			ConfigRogueResEventCueByType.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventCueByType.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventCue` where Type=?");
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x0017A090 File Offset: 0x00178290
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

		// Token: 0x04003AA2 RID: 15010
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AA3 RID: 15011
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AA4 RID: 15012
		private const string TABLE = "RogueResEventCue";

		// Token: 0x04003AA5 RID: 15013
		private const string COMMAND = "select BinData from `RogueResEventCue` where Type=?";

		// Token: 0x04003AA6 RID: 15014
		private const string KEY_PREFIX = "RogueResEventCueByType";

		// Token: 0x04003AA7 RID: 15015
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AA8 RID: 15016
		private static int HandleId;
	}
}
