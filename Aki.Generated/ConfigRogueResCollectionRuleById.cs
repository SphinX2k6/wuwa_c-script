using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000859 RID: 2137
	public class ConfigRogueResCollectionRuleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003228 RID: 12840 RVA: 0x00178764 File Offset: 0x00176964
		static ConfigRogueResCollectionRuleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionRuleById.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionRuleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00178784 File Offset: 0x00176984
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

		// Token: 0x0600322A RID: 12842 RVA: 0x00178803 File Offset: 0x00176A03
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionRuleById.LogPair = null;
			ConfigRogueResCollectionRuleById.HandleId = 0;
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x00178811 File Offset: 0x00176A11
		public static void Init()
		{
			ConfigRogueResCollectionRuleById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionRuleById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollectionRule` where Id=?");
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x0017882C File Offset: 0x00176A2C
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

		// Token: 0x04003A55 RID: 14933
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A56 RID: 14934
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A57 RID: 14935
		private const string TABLE = "RogueResCollectionRule";

		// Token: 0x04003A58 RID: 14936
		private const string COMMAND = "select BinData from `RogueResCollectionRule` where Id=?";

		// Token: 0x04003A59 RID: 14937
		private const string KEY_PREFIX = "RogueResCollectionRuleById";

		// Token: 0x04003A5A RID: 14938
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A5B RID: 14939
		private static int HandleId;
	}
}
