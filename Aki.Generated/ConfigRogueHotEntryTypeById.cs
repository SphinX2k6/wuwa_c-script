using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000827 RID: 2087
	public class ConfigRogueHotEntryTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030FC RID: 12540 RVA: 0x0016E4C8 File Offset: 0x0016C6C8
		static ConfigRogueHotEntryTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryTypeById.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x0016E4E8 File Offset: 0x0016C6E8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueHotEntryTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueHotEntryTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueHotEntryType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueHotEntryType` where Id=?")
			});
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x0016E567 File Offset: 0x0016C767
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryTypeById.LogPair = null;
			ConfigRogueHotEntryTypeById.HandleId = 0;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x0016E575 File Offset: 0x0016C775
		public static void Init()
		{
			ConfigRogueHotEntryTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryTypeById.HandleId, "db_rogue.db", "select BinData from `RogueHotEntryType` where Id=?");
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x0016E590 File Offset: 0x0016C790
		public static RogueHotEntryType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueHotEntryTypeById.HandleId, ConfigRogueHotEntryTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueHotEntryType?(RogueHotEntryType.GetRootAsRogueHotEntryType(configBuffer));
				}
			}
			ConfigRogueHotEntryTypeById.LogPair.Clear();
			ConfigRogueHotEntryTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueHotEntryTypeById.HandleId, 1, p0Id, ConfigRogueHotEntryTypeById.LogPair) || ConfigCommon.Step(ConfigRogueHotEntryTypeById.HandleId, true, ConfigRogueHotEntryTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryTypeById.HandleId, ConfigRogueHotEntryTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueHotEntryTypeById.HandleId, 0, ConfigRogueHotEntryTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryTypeById.HandleId, ConfigRogueHotEntryTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueHotEntryType rootAsRogueHotEntryType = RogueHotEntryType.GetRootAsRogueHotEntryType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueHotEntryTypeById.HandleId, ConfigRogueHotEntryTypeById.LogPair);
			return new RogueHotEntryType?(rootAsRogueHotEntryType);
		}

		// Token: 0x040038F7 RID: 14583
		private const string DB = "db_rogue.db";

		// Token: 0x040038F8 RID: 14584
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040038F9 RID: 14585
		private const string TABLE = "RogueHotEntryType";

		// Token: 0x040038FA RID: 14586
		private const string COMMAND = "select BinData from `RogueHotEntryType` where Id=?";

		// Token: 0x040038FB RID: 14587
		private const string KEY_PREFIX = "RogueHotEntryTypeById";

		// Token: 0x040038FC RID: 14588
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038FD RID: 14589
		private static int HandleId;
	}
}
