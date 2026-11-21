using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0A RID: 2570
	public class ConfigSolarSchoolRewardsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C50 RID: 15440 RVA: 0x001B1A8F File Offset: 0x001AFC8F
		static ConfigSolarSchoolRewardsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRewardsById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRewardsById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x001B1AB0 File Offset: 0x001AFCB0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRewardsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRewardsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRewards"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRewards` where Id=?")
			});
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x001B1B2F File Offset: 0x001AFD2F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRewardsById.LogPair = null;
			ConfigSolarSchoolRewardsById.HandleId = 0;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x001B1B3D File Offset: 0x001AFD3D
		public static void Init()
		{
			ConfigSolarSchoolRewardsById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRewardsById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRewards` where Id=?");
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x001B1B58 File Offset: 0x001AFD58
		public static SolarSchoolRewards? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRewardsById.HandleId, ConfigSolarSchoolRewardsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRewardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolRewards?(SolarSchoolRewards.GetRootAsSolarSchoolRewards(configBuffer));
				}
			}
			ConfigSolarSchoolRewardsById.LogPair.Clear();
			ConfigSolarSchoolRewardsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRewardsById.HandleId, 1, p0Id, ConfigSolarSchoolRewardsById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolRewardsById.HandleId, true, ConfigSolarSchoolRewardsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRewardsById.HandleId, ConfigSolarSchoolRewardsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRewardsById.HandleId, 0, ConfigSolarSchoolRewardsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRewardsById.HandleId, ConfigSolarSchoolRewardsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolRewards rootAsSolarSchoolRewards = SolarSchoolRewards.GetRootAsSolarSchoolRewards(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRewardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRewardsById.HandleId, ConfigSolarSchoolRewardsById.LogPair);
			return new SolarSchoolRewards?(rootAsSolarSchoolRewards);
		}

		// Token: 0x0400462C RID: 17964
		private const string DB = "db_solarschool.db";

		// Token: 0x0400462D RID: 17965
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x0400462E RID: 17966
		private const string TABLE = "SolarSchoolRewards";

		// Token: 0x0400462F RID: 17967
		private const string COMMAND = "select BinData from `SolarSchoolRewards` where Id=?";

		// Token: 0x04004630 RID: 17968
		private const string KEY_PREFIX = "SolarSchoolRewardsById";

		// Token: 0x04004631 RID: 17969
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004632 RID: 17970
		private static int HandleId;
	}
}
