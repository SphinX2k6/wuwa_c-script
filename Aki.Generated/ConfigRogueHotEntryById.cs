using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000824 RID: 2084
	public class ConfigRogueHotEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030EA RID: 12522 RVA: 0x0016DDF0 File Offset: 0x0016BFF0
		static ConfigRogueHotEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryById.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x0016DE10 File Offset: 0x0016C010
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

		// Token: 0x060030EC RID: 12524 RVA: 0x0016DE8F File Offset: 0x0016C08F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryById.LogPair = null;
			ConfigRogueHotEntryById.HandleId = 0;
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0016DE9D File Offset: 0x0016C09D
		public static void Init()
		{
			ConfigRogueHotEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryById.HandleId, "db_rogue.db", "select BinData from `RogueHotEntry` where Id=?");
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x0016DEB8 File Offset: 0x0016C0B8
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

		// Token: 0x040038E2 RID: 14562
		private const string DB = "db_rogue.db";

		// Token: 0x040038E3 RID: 14563
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040038E4 RID: 14564
		private const string TABLE = "RogueHotEntry";

		// Token: 0x040038E5 RID: 14565
		private const string COMMAND = "select BinData from `RogueHotEntry` where Id=?";

		// Token: 0x040038E6 RID: 14566
		private const string KEY_PREFIX = "RogueHotEntryById";

		// Token: 0x040038E7 RID: 14567
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038E8 RID: 14568
		private static int HandleId;
	}
}
