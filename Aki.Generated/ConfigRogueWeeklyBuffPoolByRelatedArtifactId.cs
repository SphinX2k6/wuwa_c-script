using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000872 RID: 2162
	public class ConfigRogueWeeklyBuffPoolByRelatedArtifactId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032BE RID: 12990 RVA: 0x00178538 File Offset: 0x00176738
		static ConfigRogueWeeklyBuffPoolByRelatedArtifactId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.ResetStaticDefaultValue));
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00178558 File Offset: 0x00176758
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBuffPool` where RelatedArtifactId=?")
			});
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x001785D7 File Offset: 0x001767D7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair = null;
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId = 0;
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x001785E5 File Offset: 0x001767E5
		public static void Init()
		{
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBuffPool` where RelatedArtifactId=?");
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00178600 File Offset: 0x00176800
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyBuffPool> GetConfigList(int p0RelatedArtifactId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolByRelatedArtifactId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelatedArtifactId);
				IReadOnlyList<RogueWeeklyBuffPool> readOnlyList = (IReadOnlyList<RogueWeeklyBuffPool>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair.Clear();
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair.Add(new ValueTuple<string, object>("RelatedArtifactId", p0RelatedArtifactId));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, 1, p0RelatedArtifactId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair))
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
				return null;
			}
			List<RogueWeeklyBuffPool> list = new List<RogueWeeklyBuffPool>();
			while (ConfigCommon.Step(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, false, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, 0, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
					return null;
				}
				RogueWeeklyBuffPool rootAsRogueWeeklyBuffPool = RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyBuffPool);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolByRelatedArtifactId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelatedArtifactId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
			return list;
		}

		// Token: 0x04003B04 RID: 15108
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B05 RID: 15109
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B06 RID: 15110
		private const string TABLE = "RogueWeeklyBuffPool";

		// Token: 0x04003B07 RID: 15111
		private const string COMMAND = "select BinData from `RogueWeeklyBuffPool` where RelatedArtifactId=?";

		// Token: 0x04003B08 RID: 15112
		private const string KEY_PREFIX = "RogueWeeklyBuffPoolByRelatedArtifactId";

		// Token: 0x04003B09 RID: 15113
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B0A RID: 15114
		private static int HandleId;
	}
}
