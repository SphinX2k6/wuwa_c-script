using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000417 RID: 1047
	public class ConfigHonamiStoryPollutionStageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001891 RID: 6289 RVA: 0x000E82FB File Offset: 0x000E64FB
		static ConfigHonamiStoryPollutionStageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPollutionStageById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPollutionStageById.ResetStaticDefaultValue));
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x000E831C File Offset: 0x000E651C
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

		// Token: 0x06001893 RID: 6291 RVA: 0x000E839B File Offset: 0x000E659B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPollutionStageById.LogPair = null;
			ConfigHonamiStoryPollutionStageById.HandleId = 0;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000E83A9 File Offset: 0x000E65A9
		public static void Init()
		{
			ConfigHonamiStoryPollutionStageById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPollutionStageById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPollutionStage` where Id = ?");
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x000E83C4 File Offset: 0x000E65C4
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

		// Token: 0x04001C85 RID: 7301
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C86 RID: 7302
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001C87 RID: 7303
		private const string TABLE = "HonamiStoryPollutionStage";

		// Token: 0x04001C88 RID: 7304
		private const string COMMAND = "select BinData from `HonamiStoryPollutionStage` where Id = ?";

		// Token: 0x04001C89 RID: 7305
		private const string KEY_PREFIX = "HonamiStoryPollutionStageById";

		// Token: 0x04001C8A RID: 7306
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C8B RID: 7307
		private static int HandleId;
	}
}
