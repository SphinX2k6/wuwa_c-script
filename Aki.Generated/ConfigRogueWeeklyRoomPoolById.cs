using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000896 RID: 2198
	public class ConfigRogueWeeklyRoomPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003396 RID: 13206 RVA: 0x00180823 File Offset: 0x0017EA23
		static ConfigRogueWeeklyRoomPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomPoolById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00180844 File Offset: 0x0017EA44
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyRoomPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyRoomPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyRoomPool` where Id=?")
			});
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x001808C3 File Offset: 0x0017EAC3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomPoolById.LogPair = null;
			ConfigRogueWeeklyRoomPoolById.HandleId = 0;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x001808D1 File Offset: 0x0017EAD1
		public static void Init()
		{
			ConfigRogueWeeklyRoomPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomPoolById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomPool` where Id=?");
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x001808EC File Offset: 0x0017EAEC
		public static RogueWeeklyRoomPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyRoomPoolById.HandleId, ConfigRogueWeeklyRoomPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyRoomPool?(RogueWeeklyRoomPool.GetRootAsRogueWeeklyRoomPool(configBuffer));
				}
			}
			ConfigRogueWeeklyRoomPoolById.LogPair.Clear();
			ConfigRogueWeeklyRoomPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyRoomPoolById.HandleId, 1, p0Id, ConfigRogueWeeklyRoomPoolById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyRoomPoolById.HandleId, true, ConfigRogueWeeklyRoomPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRoomPoolById.HandleId, ConfigRogueWeeklyRoomPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyRoomPoolById.HandleId, 0, ConfigRogueWeeklyRoomPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRoomPoolById.HandleId, ConfigRogueWeeklyRoomPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyRoomPool rootAsRogueWeeklyRoomPool = RogueWeeklyRoomPool.GetRootAsRogueWeeklyRoomPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyRoomPoolById.HandleId, ConfigRogueWeeklyRoomPoolById.LogPair);
			return new RogueWeeklyRoomPool?(rootAsRogueWeeklyRoomPool);
		}

		// Token: 0x04003C00 RID: 15360
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003C01 RID: 15361
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003C02 RID: 15362
		private const string TABLE = "RogueWeeklyRoomPool";

		// Token: 0x04003C03 RID: 15363
		private const string COMMAND = "select BinData from `RogueWeeklyRoomPool` where Id=?";

		// Token: 0x04003C04 RID: 15364
		private const string KEY_PREFIX = "RogueWeeklyRoomPoolById";

		// Token: 0x04003C05 RID: 15365
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C06 RID: 15366
		private static int HandleId;
	}
}
