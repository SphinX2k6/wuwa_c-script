using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087A RID: 2170
	public class ConfigRogueWeeklyRoomPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032EE RID: 13038 RVA: 0x0017953B File Offset: 0x0017773B
		static ConfigRogueWeeklyRoomPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomPoolById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x0017955C File Offset: 0x0017775C
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

		// Token: 0x060032F0 RID: 13040 RVA: 0x001795DB File Offset: 0x001777DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomPoolById.LogPair = null;
			ConfigRogueWeeklyRoomPoolById.HandleId = 0;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x001795E9 File Offset: 0x001777E9
		public static void Init()
		{
			ConfigRogueWeeklyRoomPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomPoolById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomPool` where Id=?");
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x00179604 File Offset: 0x00177804
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

		// Token: 0x04003B3C RID: 15164
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B3D RID: 15165
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B3E RID: 15166
		private const string TABLE = "RogueWeeklyRoomPool";

		// Token: 0x04003B3F RID: 15167
		private const string COMMAND = "select BinData from `RogueWeeklyRoomPool` where Id=?";

		// Token: 0x04003B40 RID: 15168
		private const string KEY_PREFIX = "RogueWeeklyRoomPoolById";

		// Token: 0x04003B41 RID: 15169
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B42 RID: 15170
		private static int HandleId;
	}
}
