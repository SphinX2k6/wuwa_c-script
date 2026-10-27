using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FF RID: 767
	public class ConfigFlagChallengeRoleGrowthByActivityIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011FF RID: 4607 RVA: 0x000BF3BF File Offset: 0x000BD5BF
		static ConfigFlagChallengeRoleGrowthByActivityIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000BF3E0 File Offset: 0x000BD5E0
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleGrowth` where ActivityId=? AND Level=?")
			});
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x000BF45F File Offset: 0x000BD65F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair = null;
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId = 0;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x000BF46D File Offset: 0x000BD66D
		public static void Init()
		{
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleGrowth` where ActivityId=? AND Level=?");
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x000BF488 File Offset: 0x000BD688
		public static FlagChallengeRoleGrowth? GetConfig(int p0ActivityId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleGrowthByActivityIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeRoleGrowth?(FlagChallengeRoleGrowth.GetRootAsFlagChallengeRoleGrowth(configBuffer));
				}
			}
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair.Clear();
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, 1, p0ActivityId, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, 2, p1Level, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair) || ConfigCommon.Step(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, true, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, 0, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeRoleGrowth rootAsFlagChallengeRoleGrowth = FlagChallengeRoleGrowth.GetRootAsFlagChallengeRoleGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleGrowthByActivityIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair);
			return new FlagChallengeRoleGrowth?(rootAsFlagChallengeRoleGrowth);
		}

		// Token: 0x040014DD RID: 5341
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014DE RID: 5342
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014DF RID: 5343
		private const string TABLE = "FlagChallengeRoleGrowth";

		// Token: 0x040014E0 RID: 5344
		private const string COMMAND = "select BinData from `FlagChallengeRoleGrowth` where ActivityId=? AND Level=?";

		// Token: 0x040014E1 RID: 5345
		private const string KEY_PREFIX = "FlagChallengeRoleGrowthByActivityIdAndLevel";

		// Token: 0x040014E2 RID: 5346
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014E3 RID: 5347
		private static int HandleId;
	}
}
