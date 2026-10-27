using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000853 RID: 2131
	public class ConfigRogueResRoomPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003204 RID: 12804 RVA: 0x001744F4 File Offset: 0x001726F4
		static ConfigRogueResRoomPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResRoomPoolById.CreateStaticDefaultValue), new Action(ConfigRogueResRoomPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00174514 File Offset: 0x00172714
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

		// Token: 0x06003206 RID: 12806 RVA: 0x00174593 File Offset: 0x00172793
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResRoomPoolById.LogPair = null;
			ConfigRogueResRoomPoolById.HandleId = 0;
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x001745A1 File Offset: 0x001727A1
		public static void Init()
		{
			ConfigRogueResRoomPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResRoomPoolById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResRoomPool` where Id=?");
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x001745BC File Offset: 0x001727BC
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

		// Token: 0x04003A2B RID: 14891
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A2C RID: 14892
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A2D RID: 14893
		private const string TABLE = "RogueResRoomPool";

		// Token: 0x04003A2E RID: 14894
		private const string COMMAND = "select BinData from `RogueResRoomPool` where Id=?";

		// Token: 0x04003A2F RID: 14895
		private const string KEY_PREFIX = "RogueResRoomPoolById";

		// Token: 0x04003A30 RID: 14896
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A31 RID: 14897
		private static int HandleId;
	}
}
