using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016D RID: 365
	public class ConfigChipHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x0008D727 File Offset: 0x0008B927
		static ConfigChipHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipHandBookById.CreateStaticDefaultValue), new Action(ConfigChipHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0008D748 File Offset: 0x0008B948
		public static void CreateStaticDefaultValue()
		{
			ConfigChipHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChipHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChipHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `ChipHandBook` where Id=?")
			});
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0008D7C7 File Offset: 0x0008B9C7
		public static void ResetStaticDefaultValue()
		{
			ConfigChipHandBookById.LogPair = null;
			ConfigChipHandBookById.HandleId = 0;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0008D7D5 File Offset: 0x0008B9D5
		public static void Init()
		{
			ConfigChipHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigChipHandBookById.HandleId, "db_handbook.db", "select BinData from `ChipHandBook` where Id=?");
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0008D7F0 File Offset: 0x0008B9F0
		public static ChipHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChipHandBook?(ChipHandBook.GetRootAsChipHandBook(configBuffer));
				}
			}
			ConfigChipHandBookById.LogPair.Clear();
			ConfigChipHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChipHandBookById.HandleId, 1, p0Id, ConfigChipHandBookById.LogPair) || ConfigCommon.Step(ConfigChipHandBookById.HandleId, true, ConfigChipHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChipHandBookById.HandleId, 0, ConfigChipHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChipHandBook rootAsChipHandBook = ChipHandBook.GetRootAsChipHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChipHandBookById.HandleId, ConfigChipHandBookById.LogPair);
			return new ChipHandBook?(rootAsChipHandBook);
		}

		// Token: 0x040009DF RID: 2527
		private const string DB = "db_handbook.db";

		// Token: 0x040009E0 RID: 2528
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040009E1 RID: 2529
		private const string TABLE = "ChipHandBook";

		// Token: 0x040009E2 RID: 2530
		private const string COMMAND = "select BinData from `ChipHandBook` where Id=?";

		// Token: 0x040009E3 RID: 2531
		private const string KEY_PREFIX = "ChipHandBookById";

		// Token: 0x040009E4 RID: 2532
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009E5 RID: 2533
		private static int HandleId;
	}
}
