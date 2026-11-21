using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087F RID: 2175
	public class ConfigRogueRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600330C RID: 13068 RVA: 0x0017D8D8 File Offset: 0x0017BAD8
		static ConfigRogueRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRogueRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x0017D8F8 File Offset: 0x0017BAF8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueRoomTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueRoomTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueRoomType` where Id=?")
			});
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x0017D977 File Offset: 0x0017BB77
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueRoomTypeById.LogPair = null;
			ConfigRogueRoomTypeById.HandleId = 0;
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0017D985 File Offset: 0x0017BB85
		public static void Init()
		{
			ConfigRogueRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueRoomTypeById.HandleId, "db_rogue.db", "select BinData from `RogueRoomType` where Id=?");
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0017D9A0 File Offset: 0x0017BBA0
		public static RogueRoomType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueRoomTypeById.HandleId, ConfigRogueRoomTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueRoomType?(RogueRoomType.GetRootAsRogueRoomType(configBuffer));
				}
			}
			ConfigRogueRoomTypeById.LogPair.Clear();
			ConfigRogueRoomTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueRoomTypeById.HandleId, 1, p0Id, ConfigRogueRoomTypeById.LogPair) || ConfigCommon.Step(ConfigRogueRoomTypeById.HandleId, true, ConfigRogueRoomTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueRoomTypeById.HandleId, ConfigRogueRoomTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueRoomTypeById.HandleId, 0, ConfigRogueRoomTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueRoomTypeById.HandleId, ConfigRogueRoomTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueRoomType rootAsRogueRoomType = RogueRoomType.GetRootAsRogueRoomType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueRoomTypeById.HandleId, ConfigRogueRoomTypeById.LogPair);
			return new RogueRoomType?(rootAsRogueRoomType);
		}

		// Token: 0x04003B5F RID: 15199
		private const string DB = "db_rogue.db";

		// Token: 0x04003B60 RID: 15200
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B61 RID: 15201
		private const string TABLE = "RogueRoomType";

		// Token: 0x04003B62 RID: 15202
		private const string COMMAND = "select BinData from `RogueRoomType` where Id=?";

		// Token: 0x04003B63 RID: 15203
		private const string KEY_PREFIX = "RogueRoomTypeById";

		// Token: 0x04003B64 RID: 15204
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B65 RID: 15205
		private static int HandleId;
	}
}
