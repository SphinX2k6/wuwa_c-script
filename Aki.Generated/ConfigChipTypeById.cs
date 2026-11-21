using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000170 RID: 368
	public class ConfigChipTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x0008DD3B File Offset: 0x0008BF3B
		static ConfigChipTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipTypeById.CreateStaticDefaultValue), new Action(ConfigChipTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0008DD5C File Offset: 0x0008BF5C
		public static void CreateStaticDefaultValue()
		{
			ConfigChipTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChipTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChipType"),
				new ValueTuple<string, object>("语句", "select BinData from `ChipType` where Id=?")
			});
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0008DDDB File Offset: 0x0008BFDB
		public static void ResetStaticDefaultValue()
		{
			ConfigChipTypeById.LogPair = null;
			ConfigChipTypeById.HandleId = 0;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0008DDE9 File Offset: 0x0008BFE9
		public static void Init()
		{
			ConfigChipTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigChipTypeById.HandleId, "db_handbook.db", "select BinData from `ChipType` where Id=?");
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0008DE04 File Offset: 0x0008C004
		public static ChipType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChipType?(ChipType.GetRootAsChipType(configBuffer));
				}
			}
			ConfigChipTypeById.LogPair.Clear();
			ConfigChipTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChipTypeById.HandleId, 1, p0Id, ConfigChipTypeById.LogPair) || ConfigCommon.Step(ConfigChipTypeById.HandleId, true, ConfigChipTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChipTypeById.HandleId, 0, ConfigChipTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChipType rootAsChipType = ChipType.GetRootAsChipType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair);
			return new ChipType?(rootAsChipType);
		}

		// Token: 0x040009F4 RID: 2548
		private const string DB = "db_handbook.db";

		// Token: 0x040009F5 RID: 2549
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040009F6 RID: 2550
		private const string TABLE = "ChipType";

		// Token: 0x040009F7 RID: 2551
		private const string COMMAND = "select BinData from `ChipType` where Id=?";

		// Token: 0x040009F8 RID: 2552
		private const string KEY_PREFIX = "ChipTypeById";

		// Token: 0x040009F9 RID: 2553
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009FA RID: 2554
		private static int HandleId;
	}
}
