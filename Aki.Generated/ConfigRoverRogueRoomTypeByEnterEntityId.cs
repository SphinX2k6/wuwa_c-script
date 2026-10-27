using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F6 RID: 2294
	public class ConfigRoverRogueRoomTypeByEnterEntityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035D7 RID: 13783 RVA: 0x00189A40 File Offset: 0x00187C40
		static ConfigRoverRogueRoomTypeByEnterEntityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoomTypeByEnterEntityId.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoomTypeByEnterEntityId.ResetStaticDefaultValue));
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00189A60 File Offset: 0x00187C60
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoomType` where EnterEntityId=?")
			});
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00189ADF File Offset: 0x00187CDF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair = null;
			ConfigRoverRogueRoomTypeByEnterEntityId.HandleId = 0;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00189AED File Offset: 0x00187CED
		public static void Init()
		{
			ConfigRoverRogueRoomTypeByEnterEntityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoomType` where EnterEntityId=?");
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00189B08 File Offset: 0x00187D08
		public static RoverRogueRoomType? GetConfig(int p0EnterEntityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomTypeByEnterEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EnterEntityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueRoomType?(RoverRogueRoomType.GetRootAsRoverRogueRoomType(configBuffer));
				}
			}
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair.Clear();
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair.Add(new ValueTuple<string, object>("EnterEntityId", p0EnterEntityId));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, 1, p0EnterEntityId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair) || ConfigCommon.Step(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, true, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, 0, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueRoomType rootAsRoverRogueRoomType = RoverRogueRoomType.GetRootAsRoverRogueRoomType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomTypeByEnterEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EnterEntityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
			return new RoverRogueRoomType?(rootAsRoverRogueRoomType);
		}

		// Token: 0x04003EA0 RID: 16032
		private const string DB = "db_roverlike.db";

		// Token: 0x04003EA1 RID: 16033
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x04003EA2 RID: 16034
		private const string TABLE = "RoverRogueRoomType";

		// Token: 0x04003EA3 RID: 16035
		private const string COMMAND = "select BinData from `RoverRogueRoomType` where EnterEntityId=?";

		// Token: 0x04003EA4 RID: 16036
		private const string KEY_PREFIX = "RoverRogueRoomTypeByEnterEntityId";

		// Token: 0x04003EA5 RID: 16037
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EA6 RID: 16038
		private static int HandleId;
	}
}
