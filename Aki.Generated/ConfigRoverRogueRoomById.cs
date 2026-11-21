using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000940 RID: 2368
	public class ConfigRoverRogueRoomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003793 RID: 14227 RVA: 0x00196A18 File Offset: 0x00194C18
		static ConfigRoverRogueRoomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoomById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoomById.ResetStaticDefaultValue));
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00196A38 File Offset: 0x00194C38
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

		// Token: 0x06003795 RID: 14229 RVA: 0x00196AB7 File Offset: 0x00194CB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoomById.LogPair = null;
			ConfigRoverRogueRoomById.HandleId = 0;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00196AC5 File Offset: 0x00194CC5
		public static void Init()
		{
			ConfigRoverRogueRoomById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoomById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoom` where Id=?");
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00196AE0 File Offset: 0x00194CE0
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

		// Token: 0x040040A6 RID: 16550
		private const string DB = "db_roverlike.db";

		// Token: 0x040040A7 RID: 16551
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x040040A8 RID: 16552
		private const string TABLE = "RoverRogueRoom";

		// Token: 0x040040A9 RID: 16553
		private const string COMMAND = "select BinData from `RoverRogueRoom` where Id=?";

		// Token: 0x040040AA RID: 16554
		private const string KEY_PREFIX = "RoverRogueRoomById";

		// Token: 0x040040AB RID: 16555
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040AC RID: 16556
		private static int HandleId;
	}
}
