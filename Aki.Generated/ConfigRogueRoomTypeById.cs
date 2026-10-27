using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000863 RID: 2147
	public class ConfigRogueRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003264 RID: 12900 RVA: 0x001765F0 File Offset: 0x001747F0
		static ConfigRogueRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRogueRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x00176610 File Offset: 0x00174810
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

		// Token: 0x06003266 RID: 12902 RVA: 0x0017668F File Offset: 0x0017488F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueRoomTypeById.LogPair = null;
			ConfigRogueRoomTypeById.HandleId = 0;
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x0017669D File Offset: 0x0017489D
		public static void Init()
		{
			ConfigRogueRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueRoomTypeById.HandleId, "db_rogue.db", "select BinData from `RogueRoomType` where Id=?");
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x001766B8 File Offset: 0x001748B8
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

		// Token: 0x04003A9B RID: 15003
		private const string DB = "db_rogue.db";

		// Token: 0x04003A9C RID: 15004
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003A9D RID: 15005
		private const string TABLE = "RogueRoomType";

		// Token: 0x04003A9E RID: 15006
		private const string COMMAND = "select BinData from `RogueRoomType` where Id=?";

		// Token: 0x04003A9F RID: 15007
		private const string KEY_PREFIX = "RogueRoomTypeById";

		// Token: 0x04003AA0 RID: 15008
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AA1 RID: 15009
		private static int HandleId;
	}
}
