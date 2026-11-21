using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000840 RID: 2112
	public class ConfigRogueHotEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003192 RID: 12690 RVA: 0x001750D8 File Offset: 0x001732D8
		static ConfigRogueHotEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryById.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x001750F8 File Offset: 0x001732F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueHotEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueHotEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueHotEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueHotEntry` where Id=?")
			});
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00175177 File Offset: 0x00173377
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryById.LogPair = null;
			ConfigRogueHotEntryById.HandleId = 0;
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00175185 File Offset: 0x00173385
		public static void Init()
		{
			ConfigRogueHotEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryById.HandleId, "db_rogue.db", "select BinData from `RogueHotEntry` where Id=?");
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x001751A0 File Offset: 0x001733A0
		public static RogueHotEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueHotEntryById.HandleId, ConfigRogueHotEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueHotEntry?(RogueHotEntry.GetRootAsRogueHotEntry(configBuffer));
				}
			}
			ConfigRogueHotEntryById.LogPair.Clear();
			ConfigRogueHotEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueHotEntryById.HandleId, 1, p0Id, ConfigRogueHotEntryById.LogPair) || ConfigCommon.Step(ConfigRogueHotEntryById.HandleId, true, ConfigRogueHotEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryById.HandleId, ConfigRogueHotEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueHotEntryById.HandleId, 0, ConfigRogueHotEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryById.HandleId, ConfigRogueHotEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueHotEntry rootAsRogueHotEntry = RogueHotEntry.GetRootAsRogueHotEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueHotEntryById.HandleId, ConfigRogueHotEntryById.LogPair);
			return new RogueHotEntry?(rootAsRogueHotEntry);
		}

		// Token: 0x040039A6 RID: 14758
		private const string DB = "db_rogue.db";

		// Token: 0x040039A7 RID: 14759
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040039A8 RID: 14760
		private const string TABLE = "RogueHotEntry";

		// Token: 0x040039A9 RID: 14761
		private const string COMMAND = "select BinData from `RogueHotEntry` where Id=?";

		// Token: 0x040039AA RID: 14762
		private const string KEY_PREFIX = "RogueHotEntryById";

		// Token: 0x040039AB RID: 14763
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039AC RID: 14764
		private static int HandleId;
	}
}
