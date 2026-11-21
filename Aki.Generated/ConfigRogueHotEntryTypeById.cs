using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000843 RID: 2115
	public class ConfigRogueHotEntryTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031A4 RID: 12708 RVA: 0x001757B0 File Offset: 0x001739B0
		static ConfigRogueHotEntryTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryTypeById.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x001757D0 File Offset: 0x001739D0
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

		// Token: 0x060031A6 RID: 12710 RVA: 0x0017584F File Offset: 0x00173A4F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryTypeById.LogPair = null;
			ConfigRogueHotEntryTypeById.HandleId = 0;
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x0017585D File Offset: 0x00173A5D
		public static void Init()
		{
			ConfigRogueHotEntryTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryTypeById.HandleId, "db_rogue.db", "select BinData from `RogueHotEntryType` where Id=?");
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x00175878 File Offset: 0x00173A78
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

		// Token: 0x040039BB RID: 14779
		private const string DB = "db_rogue.db";

		// Token: 0x040039BC RID: 14780
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040039BD RID: 14781
		private const string TABLE = "RogueHotEntryType";

		// Token: 0x040039BE RID: 14782
		private const string COMMAND = "select BinData from `RogueHotEntryType` where Id=?";

		// Token: 0x040039BF RID: 14783
		private const string KEY_PREFIX = "RogueHotEntryTypeById";

		// Token: 0x040039C0 RID: 14784
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039C1 RID: 14785
		private static int HandleId;
	}
}
