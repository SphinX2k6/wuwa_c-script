using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083D RID: 2109
	public class ConfigRogueResCollectionRuleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003180 RID: 12672 RVA: 0x0017147C File Offset: 0x0016F67C
		static ConfigRogueResCollectionRuleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionRuleById.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionRuleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0017149C File Offset: 0x0016F69C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCollectionRuleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCollectionRuleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCollectionRule"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCollectionRule` where Id=?")
			});
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0017151B File Offset: 0x0016F71B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionRuleById.LogPair = null;
			ConfigRogueResCollectionRuleById.HandleId = 0;
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00171529 File Offset: 0x0016F729
		public static void Init()
		{
			ConfigRogueResCollectionRuleById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionRuleById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollectionRule` where Id=?");
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00171544 File Offset: 0x0016F744
		public static RogueResCollectionRule? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCollectionRuleById.HandleId, ConfigRogueResCollectionRuleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionRuleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCollectionRule?(RogueResCollectionRule.GetRootAsRogueResCollectionRule(configBuffer));
				}
			}
			ConfigRogueResCollectionRuleById.LogPair.Clear();
			ConfigRogueResCollectionRuleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResCollectionRuleById.HandleId, 1, p0Id, ConfigRogueResCollectionRuleById.LogPair) || ConfigCommon.Step(ConfigRogueResCollectionRuleById.HandleId, true, ConfigRogueResCollectionRuleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionRuleById.HandleId, ConfigRogueResCollectionRuleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCollectionRuleById.HandleId, 0, ConfigRogueResCollectionRuleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionRuleById.HandleId, ConfigRogueResCollectionRuleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCollectionRule rootAsRogueResCollectionRule = RogueResCollectionRule.GetRootAsRogueResCollectionRule(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionRuleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCollectionRuleById.HandleId, ConfigRogueResCollectionRuleById.LogPair);
			return new RogueResCollectionRule?(rootAsRogueResCollectionRule);
		}

		// Token: 0x04003991 RID: 14737
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003992 RID: 14738
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003993 RID: 14739
		private const string TABLE = "RogueResCollectionRule";

		// Token: 0x04003994 RID: 14740
		private const string COMMAND = "select BinData from `RogueResCollectionRule` where Id=?";

		// Token: 0x04003995 RID: 14741
		private const string KEY_PREFIX = "RogueResCollectionRuleById";

		// Token: 0x04003996 RID: 14742
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003997 RID: 14743
		private static int HandleId;
	}
}
