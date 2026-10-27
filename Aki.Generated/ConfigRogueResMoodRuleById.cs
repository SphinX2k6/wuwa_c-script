using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000850 RID: 2128
	public class ConfigRogueResMoodRuleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031F2 RID: 12786 RVA: 0x00173E1C File Offset: 0x0017201C
		static ConfigRogueResMoodRuleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResMoodRuleById.CreateStaticDefaultValue), new Action(ConfigRogueResMoodRuleById.ResetStaticDefaultValue));
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00173E3C File Offset: 0x0017203C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResMoodRuleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResMoodRuleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResMoodRule"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResMoodRule` where Id=?")
			});
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x00173EBB File Offset: 0x001720BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResMoodRuleById.LogPair = null;
			ConfigRogueResMoodRuleById.HandleId = 0;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x00173EC9 File Offset: 0x001720C9
		public static void Init()
		{
			ConfigRogueResMoodRuleById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResMoodRuleById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResMoodRule` where Id=?");
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x00173EE4 File Offset: 0x001720E4
		public static RogueResMoodRule? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResMoodRuleById.HandleId, ConfigRogueResMoodRuleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResMoodRuleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResMoodRule?(RogueResMoodRule.GetRootAsRogueResMoodRule(configBuffer));
				}
			}
			ConfigRogueResMoodRuleById.LogPair.Clear();
			ConfigRogueResMoodRuleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResMoodRuleById.HandleId, 1, p0Id, ConfigRogueResMoodRuleById.LogPair) || ConfigCommon.Step(ConfigRogueResMoodRuleById.HandleId, true, ConfigRogueResMoodRuleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResMoodRuleById.HandleId, ConfigRogueResMoodRuleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResMoodRuleById.HandleId, 0, ConfigRogueResMoodRuleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResMoodRuleById.HandleId, ConfigRogueResMoodRuleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResMoodRule rootAsRogueResMoodRule = RogueResMoodRule.GetRootAsRogueResMoodRule(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResMoodRuleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResMoodRuleById.HandleId, ConfigRogueResMoodRuleById.LogPair);
			return new RogueResMoodRule?(rootAsRogueResMoodRule);
		}

		// Token: 0x04003A16 RID: 14870
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A17 RID: 14871
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A18 RID: 14872
		private const string TABLE = "RogueResMoodRule";

		// Token: 0x04003A19 RID: 14873
		private const string COMMAND = "select BinData from `RogueResMoodRule` where Id=?";

		// Token: 0x04003A1A RID: 14874
		private const string KEY_PREFIX = "RogueResMoodRuleById";

		// Token: 0x04003A1B RID: 14875
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A1C RID: 14876
		private static int HandleId;
	}
}
