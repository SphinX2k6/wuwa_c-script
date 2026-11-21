using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A06 RID: 2566
	public class ConfigSolarSchoolQuestRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C38 RID: 15416 RVA: 0x001B12D8 File Offset: 0x001AF4D8
		static ConfigSolarSchoolQuestRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestRewardById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x001B12F8 File Offset: 0x001AF4F8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuestReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuestReward` where Id=?")
			});
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x001B1377 File Offset: 0x001AF577
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestRewardById.LogPair = null;
			ConfigSolarSchoolQuestRewardById.HandleId = 0;
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x001B1385 File Offset: 0x001AF585
		public static void Init()
		{
			ConfigSolarSchoolQuestRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestRewardById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuestReward` where Id=?");
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x001B13A0 File Offset: 0x001AF5A0
		public static SolarSchoolQuestReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestRewardById.HandleId, ConfigSolarSchoolQuestRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolQuestReward?(SolarSchoolQuestReward.GetRootAsSolarSchoolQuestReward(configBuffer));
				}
			}
			ConfigSolarSchoolQuestRewardById.LogPair.Clear();
			ConfigSolarSchoolQuestRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolQuestRewardById.HandleId, 1, p0Id, ConfigSolarSchoolQuestRewardById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolQuestRewardById.HandleId, true, ConfigSolarSchoolQuestRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestRewardById.HandleId, ConfigSolarSchoolQuestRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestRewardById.HandleId, 0, ConfigSolarSchoolQuestRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestRewardById.HandleId, ConfigSolarSchoolQuestRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolQuestReward rootAsSolarSchoolQuestReward = SolarSchoolQuestReward.GetRootAsSolarSchoolQuestReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestRewardById.HandleId, ConfigSolarSchoolQuestRewardById.LogPair);
			return new SolarSchoolQuestReward?(rootAsSolarSchoolQuestReward);
		}

		// Token: 0x04004610 RID: 17936
		private const string DB = "db_solarschool.db";

		// Token: 0x04004611 RID: 17937
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x04004612 RID: 17938
		private const string TABLE = "SolarSchoolQuestReward";

		// Token: 0x04004613 RID: 17939
		private const string COMMAND = "select BinData from `SolarSchoolQuestReward` where Id=?";

		// Token: 0x04004614 RID: 17940
		private const string KEY_PREFIX = "SolarSchoolQuestRewardById";

		// Token: 0x04004615 RID: 17941
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004616 RID: 17942
		private static int HandleId;
	}
}
