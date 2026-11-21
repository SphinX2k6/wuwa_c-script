using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000314 RID: 788
	public class ConfigFlagChallengeRoleGrowthByActivityIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x000C58CB File Offset: 0x000C3ACB
		static ConfigFlagChallengeRoleGrowthByActivityIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000C58EC File Offset: 0x000C3AEC
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

		// Token: 0x0600127F RID: 4735 RVA: 0x000C596B File Offset: 0x000C3B6B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.LogPair = null;
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId = 0;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000C5979 File Offset: 0x000C3B79
		public static void Init()
		{
			ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleGrowthByActivityIdAndLevel.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleGrowth` where ActivityId=? AND Level=?");
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000C5994 File Offset: 0x000C3B94
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

		// Token: 0x04001570 RID: 5488
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001571 RID: 5489
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x04001572 RID: 5490
		private const string TABLE = "FlagChallengeRoleGrowth";

		// Token: 0x04001573 RID: 5491
		private const string COMMAND = "select BinData from `FlagChallengeRoleGrowth` where ActivityId=? AND Level=?";

		// Token: 0x04001574 RID: 5492
		private const string KEY_PREFIX = "FlagChallengeRoleGrowthByActivityIdAndLevel";

		// Token: 0x04001575 RID: 5493
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001576 RID: 5494
		private static int HandleId;
	}
}
