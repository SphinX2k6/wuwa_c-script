using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087C RID: 2172
	public class ConfigRogueWeeklyRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032FA RID: 13050 RVA: 0x00179917 File Offset: 0x00177B17
		static ConfigRogueWeeklyRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00179938 File Offset: 0x00177B38
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyRoomTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyRoomType` where Id=?")
			});
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x001799B7 File Offset: 0x00177BB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomTypeById.LogPair = null;
			ConfigRogueWeeklyRoomTypeById.HandleId = 0;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x001799C5 File Offset: 0x00177BC5
		public static void Init()
		{
			ConfigRogueWeeklyRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomTypeById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomType` where Id=?");
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x001799E0 File Offset: 0x00177BE0
		public static RogueWeeklyRoomType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyRoomTypeById.HandleId, ConfigRogueWeeklyRoomTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyRoomType?(RogueWeeklyRoomType.GetRootAsRogueWeeklyRoomType(configBuffer));
				}
			}
			ConfigRogueWeeklyRoomTypeById.LogPair.Clear();
			ConfigRogueWeeklyRoomTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyRoomTypeById.HandleId, 1, p0Id, ConfigRogueWeeklyRoomTypeById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyRoomTypeById.HandleId, true, ConfigRogueWeeklyRoomTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRoomTypeById.HandleId, ConfigRogueWeeklyRoomTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyRoomTypeById.HandleId, 0, ConfigRogueWeeklyRoomTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRoomTypeById.HandleId, ConfigRogueWeeklyRoomTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyRoomType rootAsRogueWeeklyRoomType = RogueWeeklyRoomType.GetRootAsRogueWeeklyRoomType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyRoomTypeById.HandleId, ConfigRogueWeeklyRoomTypeById.LogPair);
			return new RogueWeeklyRoomType?(rootAsRogueWeeklyRoomType);
		}

		// Token: 0x04003B4A RID: 15178
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B4B RID: 15179
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B4C RID: 15180
		private const string TABLE = "RogueWeeklyRoomType";

		// Token: 0x04003B4D RID: 15181
		private const string COMMAND = "select BinData from `RogueWeeklyRoomType` where Id=?";

		// Token: 0x04003B4E RID: 15182
		private const string KEY_PREFIX = "RogueWeeklyRoomTypeById";

		// Token: 0x04003B4F RID: 15183
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B50 RID: 15184
		private static int HandleId;
	}
}
