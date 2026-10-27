using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200002A RID: 42
	public class ConfigAbyssRoomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0005F5BB File Offset: 0x0005D7BB
		static ConfigAbyssRoomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoomById.CreateStaticDefaultValue), new Action(ConfigAbyssRoomById.ResetStaticDefaultValue));
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0005F5DC File Offset: 0x0005D7DC
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoomById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoomById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoom"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoom` where Id=?")
			});
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0005F65B File Offset: 0x0005D85B
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoomById.LogPair = null;
			ConfigAbyssRoomById.HandleId = 0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0005F669 File Offset: 0x0005D869
		public static void Init()
		{
			ConfigAbyssRoomById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoomById.HandleId, "db_dangoabyss.db", "select BinData from `AbyssRoom` where Id=?");
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0005F684 File Offset: 0x0005D884
		public static AbyssRoom? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoomById.HandleId, ConfigAbyssRoomById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssRoom?(AbyssRoom.GetRootAsAbyssRoom(configBuffer));
				}
			}
			ConfigAbyssRoomById.LogPair.Clear();
			ConfigAbyssRoomById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssRoomById.HandleId, 1, p0Id, ConfigAbyssRoomById.LogPair) || ConfigCommon.Step(ConfigAbyssRoomById.HandleId, true, ConfigAbyssRoomById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRoomById.HandleId, ConfigAbyssRoomById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoomById.HandleId, 0, ConfigAbyssRoomById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRoomById.HandleId, ConfigAbyssRoomById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssRoom rootAsAbyssRoom = AbyssRoom.GetRootAsAbyssRoom(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRoomById.HandleId, ConfigAbyssRoomById.LogPair);
			return new AbyssRoom?(rootAsAbyssRoom);
		}

		// Token: 0x0400010A RID: 266
		private const string DB = "db_dangoabyss.db";

		// Token: 0x0400010B RID: 267
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x0400010C RID: 268
		private const string TABLE = "AbyssRoom";

		// Token: 0x0400010D RID: 269
		private const string COMMAND = "select BinData from `AbyssRoom` where Id=?";

		// Token: 0x0400010E RID: 270
		private const string KEY_PREFIX = "AbyssRoomById";

		// Token: 0x0400010F RID: 271
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000110 RID: 272
		private static int HandleId;
	}
}
