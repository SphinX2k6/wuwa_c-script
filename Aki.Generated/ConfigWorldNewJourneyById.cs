using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B71 RID: 2929
	public class ConfigWorldNewJourneyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044BB RID: 17595 RVA: 0x001E1FEB File Offset: 0x001E01EB
		static ConfigWorldNewJourneyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldNewJourneyById.CreateStaticDefaultValue), new Action(ConfigWorldNewJourneyById.ResetStaticDefaultValue));
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x001E200C File Offset: 0x001E020C
		public static void CreateStaticDefaultValue()
		{
			ConfigWorldNewJourneyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWorldNewJourneyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_worldnewjourney.db"),
				new ValueTuple<string, object>("文件", "m.鸣域新程活动.xlsx"),
				new ValueTuple<string, object>("表名", "WorldNewJourney"),
				new ValueTuple<string, object>("语句", "select BinData from `WorldNewJourney` where Id=?")
			});
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x001E208B File Offset: 0x001E028B
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldNewJourneyById.LogPair = null;
			ConfigWorldNewJourneyById.HandleId = 0;
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x001E2099 File Offset: 0x001E0299
		public static void Init()
		{
			ConfigWorldNewJourneyById.HandleId = ConfigCommon.InitDataStatement(ConfigWorldNewJourneyById.HandleId, "db_worldnewjourney.db", "select BinData from `WorldNewJourney` where Id=?");
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x001E20B4 File Offset: 0x001E02B4
		public static WorldNewJourney? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWorldNewJourneyById.HandleId, ConfigWorldNewJourneyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldNewJourneyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WorldNewJourney?(WorldNewJourney.GetRootAsWorldNewJourney(configBuffer));
				}
			}
			ConfigWorldNewJourneyById.LogPair.Clear();
			ConfigWorldNewJourneyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWorldNewJourneyById.HandleId, 1, p0Id, ConfigWorldNewJourneyById.LogPair) || ConfigCommon.Step(ConfigWorldNewJourneyById.HandleId, true, ConfigWorldNewJourneyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWorldNewJourneyById.HandleId, ConfigWorldNewJourneyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWorldNewJourneyById.HandleId, 0, ConfigWorldNewJourneyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWorldNewJourneyById.HandleId, ConfigWorldNewJourneyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WorldNewJourney rootAsWorldNewJourney = WorldNewJourney.GetRootAsWorldNewJourney(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldNewJourneyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWorldNewJourneyById.HandleId, ConfigWorldNewJourneyById.LogPair);
			return new WorldNewJourney?(rootAsWorldNewJourney);
		}

		// Token: 0x04004FFD RID: 20477
		private const string DB = "db_worldnewjourney.db";

		// Token: 0x04004FFE RID: 20478
		private const string FILE = "m.鸣域新程活动.xlsx";

		// Token: 0x04004FFF RID: 20479
		private const string TABLE = "WorldNewJourney";

		// Token: 0x04005000 RID: 20480
		private const string COMMAND = "select BinData from `WorldNewJourney` where Id=?";

		// Token: 0x04005001 RID: 20481
		private const string KEY_PREFIX = "WorldNewJourneyById";

		// Token: 0x04005002 RID: 20482
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04005003 RID: 20483
		private static int HandleId;
	}
}
