using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000861 RID: 2145
	public class ConfigRogueRoomPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003258 RID: 12888 RVA: 0x00176160 File Offset: 0x00174360
		static ConfigRogueRoomPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueRoomPoolById.CreateStaticDefaultValue), new Action(ConfigRogueRoomPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00176180 File Offset: 0x00174380
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueRoomPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueRoomPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueRoomPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueRoomPool` where Id=?")
			});
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x001761FF File Offset: 0x001743FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueRoomPoolById.LogPair = null;
			ConfigRogueRoomPoolById.HandleId = 0;
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x0017620D File Offset: 0x0017440D
		public static void Init()
		{
			ConfigRogueRoomPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueRoomPoolById.HandleId, "db_rogue.db", "select BinData from `RogueRoomPool` where Id=?");
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x00176228 File Offset: 0x00174428
		public static RogueRoomPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueRoomPool?(RogueRoomPool.GetRootAsRogueRoomPool(configBuffer));
				}
			}
			ConfigRogueRoomPoolById.LogPair.Clear();
			ConfigRogueRoomPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueRoomPoolById.HandleId, 1, p0Id, ConfigRogueRoomPoolById.LogPair) || ConfigCommon.Step(ConfigRogueRoomPoolById.HandleId, true, ConfigRogueRoomPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueRoomPoolById.HandleId, 0, ConfigRogueRoomPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueRoomPool rootAsRogueRoomPool = RogueRoomPool.GetRootAsRogueRoomPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair);
			return new RogueRoomPool?(rootAsRogueRoomPool);
		}

		// Token: 0x04003A8D RID: 14989
		private const string DB = "db_rogue.db";

		// Token: 0x04003A8E RID: 14990
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003A8F RID: 14991
		private const string TABLE = "RogueRoomPool";

		// Token: 0x04003A90 RID: 14992
		private const string COMMAND = "select BinData from `RogueRoomPool` where Id=?";

		// Token: 0x04003A91 RID: 14993
		private const string KEY_PREFIX = "RogueRoomPoolById";

		// Token: 0x04003A92 RID: 14994
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A93 RID: 14995
		private static int HandleId;
	}
}
