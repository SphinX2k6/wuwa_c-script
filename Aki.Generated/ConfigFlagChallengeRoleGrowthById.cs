using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000315 RID: 789
	public class ConfigFlagChallengeRoleGrowthById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x000C5B69 File Offset: 0x000C3D69
		static ConfigFlagChallengeRoleGrowthById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleGrowthById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleGrowthById.ResetStaticDefaultValue));
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000C5B88 File Offset: 0x000C3D88
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleGrowthById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleGrowth` where Id=?")
			});
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000C5C07 File Offset: 0x000C3E07
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthById.LogPair = null;
			ConfigFlagChallengeRoleGrowthById.HandleId = 0;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000C5C15 File Offset: 0x000C3E15
		public static void Init()
		{
			ConfigFlagChallengeRoleGrowthById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleGrowthById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleGrowth` where Id=?");
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000C5C30 File Offset: 0x000C3E30
		public static FlagChallengeRoleGrowth? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleGrowthById.HandleId, ConfigFlagChallengeRoleGrowthById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleGrowthById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeRoleGrowth?(FlagChallengeRoleGrowth.GetRootAsFlagChallengeRoleGrowth(configBuffer));
				}
			}
			ConfigFlagChallengeRoleGrowthById.LogPair.Clear();
			ConfigFlagChallengeRoleGrowthById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleGrowthById.HandleId, 1, p0Id, ConfigFlagChallengeRoleGrowthById.LogPair) || ConfigCommon.Step(ConfigFlagChallengeRoleGrowthById.HandleId, true, ConfigFlagChallengeRoleGrowthById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthById.HandleId, ConfigFlagChallengeRoleGrowthById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleGrowthById.HandleId, 0, ConfigFlagChallengeRoleGrowthById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthById.HandleId, ConfigFlagChallengeRoleGrowthById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeRoleGrowth rootAsFlagChallengeRoleGrowth = FlagChallengeRoleGrowth.GetRootAsFlagChallengeRoleGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleGrowthById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthById.HandleId, ConfigFlagChallengeRoleGrowthById.LogPair);
			return new FlagChallengeRoleGrowth?(rootAsFlagChallengeRoleGrowth);
		}

		// Token: 0x04001577 RID: 5495
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001578 RID: 5496
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x04001579 RID: 5497
		private const string TABLE = "FlagChallengeRoleGrowth";

		// Token: 0x0400157A RID: 5498
		private const string COMMAND = "select BinData from `FlagChallengeRoleGrowth` where Id=?";

		// Token: 0x0400157B RID: 5499
		private const string KEY_PREFIX = "FlagChallengeRoleGrowthById";

		// Token: 0x0400157C RID: 5500
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400157D RID: 5501
		private static int HandleId;
	}
}
