using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000401 RID: 1025
	public class ConfigHonamiStoryPollutionStageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600180D RID: 6157 RVA: 0x000E1BA7 File Offset: 0x000DFDA7
		static ConfigHonamiStoryPollutionStageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPollutionStageById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPollutionStageById.ResetStaticDefaultValue));
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000E1BC8 File Offset: 0x000DFDC8
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPollutionStageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPollutionStageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPollutionStage"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPollutionStage` where Id = ?")
			});
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000E1C47 File Offset: 0x000DFE47
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPollutionStageById.LogPair = null;
			ConfigHonamiStoryPollutionStageById.HandleId = 0;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000E1C55 File Offset: 0x000DFE55
		public static void Init()
		{
			ConfigHonamiStoryPollutionStageById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPollutionStageById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPollutionStage` where Id = ?");
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000E1C70 File Offset: 0x000DFE70
		public static HonamiStoryPollutionStage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPollutionStageById.HandleId, ConfigHonamiStoryPollutionStageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPollutionStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPollutionStage?(HonamiStoryPollutionStage.GetRootAsHonamiStoryPollutionStage(configBuffer));
				}
			}
			ConfigHonamiStoryPollutionStageById.LogPair.Clear();
			ConfigHonamiStoryPollutionStageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPollutionStageById.HandleId, 1, p0Id, ConfigHonamiStoryPollutionStageById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPollutionStageById.HandleId, true, ConfigHonamiStoryPollutionStageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPollutionStageById.HandleId, ConfigHonamiStoryPollutionStageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPollutionStageById.HandleId, 0, ConfigHonamiStoryPollutionStageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPollutionStageById.HandleId, ConfigHonamiStoryPollutionStageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPollutionStage rootAsHonamiStoryPollutionStage = HonamiStoryPollutionStage.GetRootAsHonamiStoryPollutionStage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPollutionStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPollutionStageById.HandleId, ConfigHonamiStoryPollutionStageById.LogPair);
			return new HonamiStoryPollutionStage?(rootAsHonamiStoryPollutionStage);
		}

		// Token: 0x04001BEB RID: 7147
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BEC RID: 7148
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001BED RID: 7149
		private const string TABLE = "HonamiStoryPollutionStage";

		// Token: 0x04001BEE RID: 7150
		private const string COMMAND = "select BinData from `HonamiStoryPollutionStage` where Id = ?";

		// Token: 0x04001BEF RID: 7151
		private const string KEY_PREFIX = "HonamiStoryPollutionStageById";

		// Token: 0x04001BF0 RID: 7152
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BF1 RID: 7153
		private static int HandleId;
	}
}
