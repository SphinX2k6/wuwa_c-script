using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086F RID: 2159
	public class ConfigRogueResRoomPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032AC RID: 12972 RVA: 0x0017B7DC File Offset: 0x001799DC
		static ConfigRogueResRoomPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResRoomPoolById.CreateStaticDefaultValue), new Action(ConfigRogueResRoomPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x0017B7FC File Offset: 0x001799FC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResRoomPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResRoomPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResRoomPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResRoomPool` where Id=?")
			});
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0017B87B File Offset: 0x00179A7B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResRoomPoolById.LogPair = null;
			ConfigRogueResRoomPoolById.HandleId = 0;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x0017B889 File Offset: 0x00179A89
		public static void Init()
		{
			ConfigRogueResRoomPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResRoomPoolById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResRoomPool` where Id=?");
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0017B8A4 File Offset: 0x00179AA4
		public static RogueResRoomPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResRoomPoolById.HandleId, ConfigRogueResRoomPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResRoomPool?(RogueResRoomPool.GetRootAsRogueResRoomPool(configBuffer));
				}
			}
			ConfigRogueResRoomPoolById.LogPair.Clear();
			ConfigRogueResRoomPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResRoomPoolById.HandleId, 1, p0Id, ConfigRogueResRoomPoolById.LogPair) || ConfigCommon.Step(ConfigRogueResRoomPoolById.HandleId, true, ConfigRogueResRoomPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResRoomPoolById.HandleId, ConfigRogueResRoomPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResRoomPoolById.HandleId, 0, ConfigRogueResRoomPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResRoomPoolById.HandleId, ConfigRogueResRoomPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResRoomPool rootAsRogueResRoomPool = RogueResRoomPool.GetRootAsRogueResRoomPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResRoomPoolById.HandleId, ConfigRogueResRoomPoolById.LogPair);
			return new RogueResRoomPool?(rootAsRogueResRoomPool);
		}

		// Token: 0x04003AEF RID: 15087
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AF0 RID: 15088
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AF1 RID: 15089
		private const string TABLE = "RogueResRoomPool";

		// Token: 0x04003AF2 RID: 15090
		private const string COMMAND = "select BinData from `RogueResRoomPool` where Id=?";

		// Token: 0x04003AF3 RID: 15091
		private const string KEY_PREFIX = "RogueResRoomPoolById";

		// Token: 0x04003AF4 RID: 15092
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AF5 RID: 15093
		private static int HandleId;
	}
}
