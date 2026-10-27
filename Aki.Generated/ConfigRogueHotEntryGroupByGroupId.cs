using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000825 RID: 2085
	public class ConfigRogueHotEntryGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030F0 RID: 12528 RVA: 0x0016E038 File Offset: 0x0016C238
		static ConfigRogueHotEntryGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0016E058 File Offset: 0x0016C258
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueHotEntryGroupByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueHotEntryGroupByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueHotEntryGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueHotEntryGroup` where GroupId=?")
			});
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0016E0D7 File Offset: 0x0016C2D7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryGroupByGroupId.LogPair = null;
			ConfigRogueHotEntryGroupByGroupId.HandleId = 0;
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0016E0E5 File Offset: 0x0016C2E5
		public static void Init()
		{
			ConfigRogueHotEntryGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryGroupByGroupId.HandleId, "db_rogue.db", "select BinData from `RogueHotEntryGroup` where GroupId=?");
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0016E100 File Offset: 0x0016C300
		public static RogueHotEntryGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueHotEntryGroup?(RogueHotEntryGroup.GetRootAsRogueHotEntryGroup(configBuffer));
				}
			}
			ConfigRogueHotEntryGroupByGroupId.LogPair.Clear();
			ConfigRogueHotEntryGroupByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRogueHotEntryGroupByGroupId.HandleId, 1, p0GroupId, ConfigRogueHotEntryGroupByGroupId.LogPair) || ConfigCommon.Step(ConfigRogueHotEntryGroupByGroupId.HandleId, true, ConfigRogueHotEntryGroupByGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueHotEntryGroupByGroupId.HandleId, 0, ConfigRogueHotEntryGroupByGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueHotEntryGroup rootAsRogueHotEntryGroup = RogueHotEntryGroup.GetRootAsRogueHotEntryGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair);
			return new RogueHotEntryGroup?(rootAsRogueHotEntryGroup);
		}

		// Token: 0x040038E9 RID: 14569
		private const string DB = "db_rogue.db";

		// Token: 0x040038EA RID: 14570
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040038EB RID: 14571
		private const string TABLE = "RogueHotEntryGroup";

		// Token: 0x040038EC RID: 14572
		private const string COMMAND = "select BinData from `RogueHotEntryGroup` where GroupId=?";

		// Token: 0x040038ED RID: 14573
		private const string KEY_PREFIX = "RogueHotEntryGroupByGroupId";

		// Token: 0x040038EE RID: 14574
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038EF RID: 14575
		private static int HandleId;
	}
}
