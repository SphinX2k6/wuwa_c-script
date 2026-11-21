using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000942 RID: 2370
	public class ConfigRoverRogueRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600379F RID: 14239 RVA: 0x00196EA8 File Offset: 0x001950A8
		static ConfigRoverRogueRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00196EC8 File Offset: 0x001950C8
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

		// Token: 0x060037A1 RID: 14241 RVA: 0x00196F47 File Offset: 0x00195147
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoomTypeById.LogPair = null;
			ConfigRoverRogueRoomTypeById.HandleId = 0;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00196F55 File Offset: 0x00195155
		public static void Init()
		{
			ConfigRoverRogueRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoomTypeById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoomType` where Id=?");
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00196F70 File Offset: 0x00195170
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

		// Token: 0x040040B4 RID: 16564
		private const string DB = "db_roverlike.db";

		// Token: 0x040040B5 RID: 16565
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x040040B6 RID: 16566
		private const string TABLE = "RoverRogueRoomType";

		// Token: 0x040040B7 RID: 16567
		private const string COMMAND = "select BinData from `RoverRogueRoomType` where Id=?";

		// Token: 0x040040B8 RID: 16568
		private const string KEY_PREFIX = "RoverRogueRoomTypeById";

		// Token: 0x040040B9 RID: 16569
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040BA RID: 16570
		private static int HandleId;
	}
}
