using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F5 RID: 2293
	public class ConfigRoverRogueRoomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035D1 RID: 13777 RVA: 0x001897F8 File Offset: 0x001879F8
		static ConfigRoverRogueRoomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoomById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoomById.ResetStaticDefaultValue));
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00189818 File Offset: 0x00187A18
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoomById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoomById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoom"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoom` where Id=?")
			});
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x00189897 File Offset: 0x00187A97
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoomById.LogPair = null;
			ConfigRoverRogueRoomById.HandleId = 0;
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x001898A5 File Offset: 0x00187AA5
		public static void Init()
		{
			ConfigRoverRogueRoomById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoomById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoom` where Id=?");
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x001898C0 File Offset: 0x00187AC0
		public static RoverRogueRoom? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoomById.HandleId, ConfigRoverRogueRoomById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueRoom?(RoverRogueRoom.GetRootAsRoverRogueRoom(configBuffer));
				}
			}
			ConfigRoverRogueRoomById.LogPair.Clear();
			ConfigRoverRogueRoomById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoomById.HandleId, 1, p0Id, ConfigRoverRogueRoomById.LogPair) || ConfigCommon.Step(ConfigRoverRogueRoomById.HandleId, true, ConfigRoverRogueRoomById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomById.HandleId, ConfigRoverRogueRoomById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoomById.HandleId, 0, ConfigRoverRogueRoomById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomById.HandleId, ConfigRoverRogueRoomById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueRoom rootAsRoverRogueRoom = RoverRogueRoom.GetRootAsRoverRogueRoom(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoomById.HandleId, ConfigRoverRogueRoomById.LogPair);
			return new RoverRogueRoom?(rootAsRoverRogueRoom);
		}

		// Token: 0x04003E99 RID: 16025
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E9A RID: 16026
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x04003E9B RID: 16027
		private const string TABLE = "RoverRogueRoom";

		// Token: 0x04003E9C RID: 16028
		private const string COMMAND = "select BinData from `RoverRogueRoom` where Id=?";

		// Token: 0x04003E9D RID: 16029
		private const string KEY_PREFIX = "RoverRogueRoomById";

		// Token: 0x04003E9E RID: 16030
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E9F RID: 16031
		private static int HandleId;
	}
}
