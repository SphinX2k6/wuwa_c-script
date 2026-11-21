using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A08 RID: 2568
	public class ConfigSolarSchoolRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C44 RID: 15428 RVA: 0x001B16B3 File Offset: 0x001AF8B3
		static ConfigSolarSchoolRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRewardById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x001B16D4 File Offset: 0x001AF8D4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolReward` where Id=?")
			});
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x001B1753 File Offset: 0x001AF953
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRewardById.LogPair = null;
			ConfigSolarSchoolRewardById.HandleId = 0;
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x001B1761 File Offset: 0x001AF961
		public static void Init()
		{
			ConfigSolarSchoolRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRewardById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolReward` where Id=?");
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x001B177C File Offset: 0x001AF97C
		public static SolarSchoolReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRewardById.HandleId, ConfigSolarSchoolRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolReward?(SolarSchoolReward.GetRootAsSolarSchoolReward(configBuffer));
				}
			}
			ConfigSolarSchoolRewardById.LogPair.Clear();
			ConfigSolarSchoolRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRewardById.HandleId, 1, p0Id, ConfigSolarSchoolRewardById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolRewardById.HandleId, true, ConfigSolarSchoolRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRewardById.HandleId, ConfigSolarSchoolRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRewardById.HandleId, 0, ConfigSolarSchoolRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRewardById.HandleId, ConfigSolarSchoolRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolReward rootAsSolarSchoolReward = SolarSchoolReward.GetRootAsSolarSchoolReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRewardById.HandleId, ConfigSolarSchoolRewardById.LogPair);
			return new SolarSchoolReward?(rootAsSolarSchoolReward);
		}

		// Token: 0x0400461E RID: 17950
		private const string DB = "db_solarschool.db";

		// Token: 0x0400461F RID: 17951
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x04004620 RID: 17952
		private const string TABLE = "SolarSchoolReward";

		// Token: 0x04004621 RID: 17953
		private const string COMMAND = "select BinData from `SolarSchoolReward` where Id=?";

		// Token: 0x04004622 RID: 17954
		private const string KEY_PREFIX = "SolarSchoolRewardById";

		// Token: 0x04004623 RID: 17955
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004624 RID: 17956
		private static int HandleId;
	}
}
