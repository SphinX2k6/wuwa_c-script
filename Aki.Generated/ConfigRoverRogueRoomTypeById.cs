using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F7 RID: 2295
	public class ConfigRoverRogueRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035DD RID: 13789 RVA: 0x00189C88 File Offset: 0x00187E88
		static ConfigRoverRogueRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00189CA8 File Offset: 0x00187EA8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoomTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoomTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoomType` where Id=?")
			});
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00189D27 File Offset: 0x00187F27
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoomTypeById.LogPair = null;
			ConfigRoverRogueRoomTypeById.HandleId = 0;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00189D35 File Offset: 0x00187F35
		public static void Init()
		{
			ConfigRoverRogueRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoomTypeById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoomType` where Id=?");
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x00189D50 File Offset: 0x00187F50
		public static RoverRogueRoomType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoomTypeById.HandleId, ConfigRoverRogueRoomTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueRoomType?(RoverRogueRoomType.GetRootAsRoverRogueRoomType(configBuffer));
				}
			}
			ConfigRoverRogueRoomTypeById.LogPair.Clear();
			ConfigRoverRogueRoomTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoomTypeById.HandleId, 1, p0Id, ConfigRoverRogueRoomTypeById.LogPair) || ConfigCommon.Step(ConfigRoverRogueRoomTypeById.HandleId, true, ConfigRoverRogueRoomTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomTypeById.HandleId, ConfigRoverRogueRoomTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoomTypeById.HandleId, 0, ConfigRoverRogueRoomTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomTypeById.HandleId, ConfigRoverRogueRoomTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueRoomType rootAsRoverRogueRoomType = RoverRogueRoomType.GetRootAsRoverRogueRoomType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoomTypeById.HandleId, ConfigRoverRogueRoomTypeById.LogPair);
			return new RoverRogueRoomType?(rootAsRoverRogueRoomType);
		}

		// Token: 0x04003EA7 RID: 16039
		private const string DB = "db_roverlike.db";

		// Token: 0x04003EA8 RID: 16040
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x04003EA9 RID: 16041
		private const string TABLE = "RoverRogueRoomType";

		// Token: 0x04003EAA RID: 16042
		private const string COMMAND = "select BinData from `RoverRogueRoomType` where Id=?";

		// Token: 0x04003EAB RID: 16043
		private const string KEY_PREFIX = "RoverRogueRoomTypeById";

		// Token: 0x04003EAC RID: 16044
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EAD RID: 16045
		private static int HandleId;
	}
}
