using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9C RID: 2716
	public class ConfigWorldNewJourneyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FBD RID: 16317 RVA: 0x001C2C57 File Offset: 0x001C0E57
		static ConfigWorldNewJourneyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldNewJourneyById.CreateStaticDefaultValue), new Action(ConfigWorldNewJourneyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x001C2C78 File Offset: 0x001C0E78
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

		// Token: 0x06003FBF RID: 16319 RVA: 0x001C2CF7 File Offset: 0x001C0EF7
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldNewJourneyById.LogPair = null;
			ConfigWorldNewJourneyById.HandleId = 0;
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x001C2D05 File Offset: 0x001C0F05
		public static void Init()
		{
			ConfigWorldNewJourneyById.HandleId = ConfigCommon.InitDataStatement(ConfigWorldNewJourneyById.HandleId, "db_worldnewjourney.db", "select BinData from `WorldNewJourney` where Id=?");
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x001C2D20 File Offset: 0x001C0F20
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

		// Token: 0x04004A2A RID: 18986
		private const string DB = "db_worldnewjourney.db";

		// Token: 0x04004A2B RID: 18987
		private const string FILE = "m.鸣域新程活动.xlsx";

		// Token: 0x04004A2C RID: 18988
		private const string TABLE = "WorldNewJourney";

		// Token: 0x04004A2D RID: 18989
		private const string COMMAND = "select BinData from `WorldNewJourney` where Id=?";

		// Token: 0x04004A2E RID: 18990
		private const string KEY_PREFIX = "WorldNewJourneyById";

		// Token: 0x04004A2F RID: 18991
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A30 RID: 18992
		private static int HandleId;
	}
}
