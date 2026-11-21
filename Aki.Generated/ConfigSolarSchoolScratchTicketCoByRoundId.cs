using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1E RID: 2590
	public class ConfigSolarSchoolScratchTicketCoByRoundId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CC8 RID: 15560 RVA: 0x001B4477 File Offset: 0x001B2677
		static ConfigSolarSchoolScratchTicketCoByRoundId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolScratchTicketCoByRoundId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolScratchTicketCoByRoundId.ResetStaticDefaultValue));
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x001B4498 File Offset: 0x001B2698
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketCoByRoundId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolScratchTicketCoByRoundId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolScratchTicketCo"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolScratchTicketCo` where RoundId=?")
			});
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x001B4517 File Offset: 0x001B2717
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketCoByRoundId.LogPair = null;
			ConfigSolarSchoolScratchTicketCoByRoundId.HandleId = 0;
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x001B4525 File Offset: 0x001B2725
		public static void Init()
		{
			ConfigSolarSchoolScratchTicketCoByRoundId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolScratchTicketCo` where RoundId=?");
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x001B4540 File Offset: 0x001B2740
		public static SolarSchoolScratchTicketCo? GetConfig(int p0RoundId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, ConfigSolarSchoolScratchTicketCoByRoundId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolScratchTicketCoByRoundId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolScratchTicketCo?(SolarSchoolScratchTicketCo.GetRootAsSolarSchoolScratchTicketCo(configBuffer));
				}
			}
			ConfigSolarSchoolScratchTicketCoByRoundId.LogPair.Clear();
			ConfigSolarSchoolScratchTicketCoByRoundId.LogPair.Add(new ValueTuple<string, object>("RoundId", p0RoundId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, 1, p0RoundId, ConfigSolarSchoolScratchTicketCoByRoundId.LogPair) || ConfigCommon.Step(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, true, ConfigSolarSchoolScratchTicketCoByRoundId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, ConfigSolarSchoolScratchTicketCoByRoundId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, 0, ConfigSolarSchoolScratchTicketCoByRoundId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, ConfigSolarSchoolScratchTicketCoByRoundId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolScratchTicketCo rootAsSolarSchoolScratchTicketCo = SolarSchoolScratchTicketCo.GetRootAsSolarSchoolScratchTicketCo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolScratchTicketCoByRoundId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolScratchTicketCoByRoundId.HandleId, ConfigSolarSchoolScratchTicketCoByRoundId.LogPair);
			return new SolarSchoolScratchTicketCo?(rootAsSolarSchoolScratchTicketCo);
		}

		// Token: 0x040046B8 RID: 18104
		private const string DB = "db_solarschool.db";

		// Token: 0x040046B9 RID: 18105
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040046BA RID: 18106
		private const string TABLE = "SolarSchoolScratchTicketCo";

		// Token: 0x040046BB RID: 18107
		private const string COMMAND = "select BinData from `SolarSchoolScratchTicketCo` where RoundId=?";

		// Token: 0x040046BC RID: 18108
		private const string KEY_PREFIX = "SolarSchoolScratchTicketCoByRoundId";

		// Token: 0x040046BD RID: 18109
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046BE RID: 18110
		private static int HandleId;
	}
}
