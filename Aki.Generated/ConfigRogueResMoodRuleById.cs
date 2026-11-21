using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086C RID: 2156
	public class ConfigRogueResMoodRuleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600329A RID: 12954 RVA: 0x0017B104 File Offset: 0x00179304
		static ConfigRogueResMoodRuleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResMoodRuleById.CreateStaticDefaultValue), new Action(ConfigRogueResMoodRuleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x0017B124 File Offset: 0x00179324
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

		// Token: 0x0600329C RID: 12956 RVA: 0x0017B1A3 File Offset: 0x001793A3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResMoodRuleById.LogPair = null;
			ConfigRogueResMoodRuleById.HandleId = 0;
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0017B1B1 File Offset: 0x001793B1
		public static void Init()
		{
			ConfigRogueResMoodRuleById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResMoodRuleById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResMoodRule` where Id=?");
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x0017B1CC File Offset: 0x001793CC
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

		// Token: 0x04003ADA RID: 15066
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003ADB RID: 15067
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003ADC RID: 15068
		private const string TABLE = "RogueResMoodRule";

		// Token: 0x04003ADD RID: 15069
		private const string COMMAND = "select BinData from `RogueResMoodRule` where Id=?";

		// Token: 0x04003ADE RID: 15070
		private const string KEY_PREFIX = "RogueResMoodRuleById";

		// Token: 0x04003ADF RID: 15071
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AE0 RID: 15072
		private static int HandleId;
	}
}
