using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000898 RID: 2200
	public class ConfigRogueWeeklyRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033A2 RID: 13218 RVA: 0x00180BFF File Offset: 0x0017EDFF
		static ConfigRogueWeeklyRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00180C20 File Offset: 0x0017EE20
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

		// Token: 0x060033A4 RID: 13220 RVA: 0x00180C9F File Offset: 0x0017EE9F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomTypeById.LogPair = null;
			ConfigRogueWeeklyRoomTypeById.HandleId = 0;
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00180CAD File Offset: 0x0017EEAD
		public static void Init()
		{
			ConfigRogueWeeklyRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomTypeById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomType` where Id=?");
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00180CC8 File Offset: 0x0017EEC8
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

		// Token: 0x04003C0E RID: 15374
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003C0F RID: 15375
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003C10 RID: 15376
		private const string TABLE = "RogueWeeklyRoomType";

		// Token: 0x04003C11 RID: 15377
		private const string COMMAND = "select BinData from `RogueWeeklyRoomType` where Id=?";

		// Token: 0x04003C12 RID: 15378
		private const string KEY_PREFIX = "RogueWeeklyRoomTypeById";

		// Token: 0x04003C13 RID: 15379
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C14 RID: 15380
		private static int HandleId;
	}
}
