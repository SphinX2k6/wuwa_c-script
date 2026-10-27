using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000854 RID: 2132
	public class ConfigRogueResRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600320A RID: 12810 RVA: 0x0017473C File Offset: 0x0017293C
		static ConfigRogueResRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRogueResRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x0017475C File Offset: 0x0017295C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResRoomTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResRoomTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResRoomType` where Id=?")
			});
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x001747DB File Offset: 0x001729DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResRoomTypeById.LogPair = null;
			ConfigRogueResRoomTypeById.HandleId = 0;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x001747E9 File Offset: 0x001729E9
		public static void Init()
		{
			ConfigRogueResRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResRoomTypeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResRoomType` where Id=?");
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x00174804 File Offset: 0x00172A04
		public static RogueResRoomType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResRoomType?(RogueResRoomType.GetRootAsRogueResRoomType(configBuffer));
				}
			}
			ConfigRogueResRoomTypeById.LogPair.Clear();
			ConfigRogueResRoomTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResRoomTypeById.HandleId, 1, p0Id, ConfigRogueResRoomTypeById.LogPair) || ConfigCommon.Step(ConfigRogueResRoomTypeById.HandleId, true, ConfigRogueResRoomTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResRoomTypeById.HandleId, 0, ConfigRogueResRoomTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResRoomType rootAsRogueResRoomType = RogueResRoomType.GetRootAsRogueResRoomType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair);
			return new RogueResRoomType?(rootAsRogueResRoomType);
		}

		// Token: 0x04003A32 RID: 14898
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A33 RID: 14899
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A34 RID: 14900
		private const string TABLE = "RogueResRoomType";

		// Token: 0x04003A35 RID: 14901
		private const string COMMAND = "select BinData from `RogueResRoomType` where Id=?";

		// Token: 0x04003A36 RID: 14902
		private const string KEY_PREFIX = "RogueResRoomTypeById";

		// Token: 0x04003A37 RID: 14903
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A38 RID: 14904
		private static int HandleId;
	}
}
