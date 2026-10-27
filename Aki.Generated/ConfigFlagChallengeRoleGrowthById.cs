using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000300 RID: 768
	public class ConfigFlagChallengeRoleGrowthById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001205 RID: 4613 RVA: 0x000BF65D File Offset: 0x000BD85D
		static ConfigFlagChallengeRoleGrowthById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleGrowthById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleGrowthById.ResetStaticDefaultValue));
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000BF67C File Offset: 0x000BD87C
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

		// Token: 0x06001207 RID: 4615 RVA: 0x000BF6FB File Offset: 0x000BD8FB
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthById.LogPair = null;
			ConfigFlagChallengeRoleGrowthById.HandleId = 0;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000BF709 File Offset: 0x000BD909
		public static void Init()
		{
			ConfigFlagChallengeRoleGrowthById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleGrowthById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleGrowth` where Id=?");
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000BF724 File Offset: 0x000BD924
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

		// Token: 0x040014E4 RID: 5348
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014E5 RID: 5349
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014E6 RID: 5350
		private const string TABLE = "FlagChallengeRoleGrowth";

		// Token: 0x040014E7 RID: 5351
		private const string COMMAND = "select BinData from `FlagChallengeRoleGrowth` where Id=?";

		// Token: 0x040014E8 RID: 5352
		private const string KEY_PREFIX = "FlagChallengeRoleGrowthById";

		// Token: 0x040014E9 RID: 5353
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014EA RID: 5354
		private static int HandleId;
	}
}
