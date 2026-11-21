using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016E RID: 366
	public class ConfigChipHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x0008D970 File Offset: 0x0008BB70
		static ConfigChipHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipHandBookByType.CreateStaticDefaultValue), new Action(ConfigChipHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0008D990 File Offset: 0x0008BB90
		public static void CreateStaticDefaultValue()
		{
			ConfigChipHandBookByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChipHandBookByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChipHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `ChipHandBook` where Type=?")
			});
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0008DA0F File Offset: 0x0008BC0F
		public static void ResetStaticDefaultValue()
		{
			ConfigChipHandBookByType.LogPair = null;
			ConfigChipHandBookByType.HandleId = 0;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0008DA1D File Offset: 0x0008BC1D
		public static void Init()
		{
			ConfigChipHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigChipHandBookByType.HandleId, "db_handbook.db", "select BinData from `ChipHandBook` where Type=?");
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0008DA38 File Offset: 0x0008BC38
		[NullableContext(2)]
		public static IReadOnlyList<ChipHandBook> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChipHandBookByType.HandleId, ConfigChipHandBookByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<ChipHandBook> readOnlyList = (IReadOnlyList<ChipHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigChipHandBookByType.LogPair.Clear();
			ConfigChipHandBookByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigChipHandBookByType.HandleId, 1, p0Type, ConfigChipHandBookByType.LogPair))
			{
				ConfigCommon.Reset(ConfigChipHandBookByType.HandleId, ConfigChipHandBookByType.LogPair);
				return null;
			}
			List<ChipHandBook> list = new List<ChipHandBook>();
			while (ConfigCommon.Step(ConfigChipHandBookByType.HandleId, false, ConfigChipHandBookByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChipHandBookByType.HandleId, 0, ConfigChipHandBookByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChipHandBookByType.HandleId, ConfigChipHandBookByType.LogPair);
					return null;
				}
				ChipHandBook rootAsChipHandBook = ChipHandBook.GetRootAsChipHandBook(new ByteBuffer(item2));
				list.Add(rootAsChipHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigChipHandBookByType.HandleId, ConfigChipHandBookByType.LogPair);
			return list;
		}

		// Token: 0x040009E6 RID: 2534
		private const string DB = "db_handbook.db";

		// Token: 0x040009E7 RID: 2535
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040009E8 RID: 2536
		private const string TABLE = "ChipHandBook";

		// Token: 0x040009E9 RID: 2537
		private const string COMMAND = "select BinData from `ChipHandBook` where Type=?";

		// Token: 0x040009EA RID: 2538
		private const string KEY_PREFIX = "ChipHandBookByType";

		// Token: 0x040009EB RID: 2539
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009EC RID: 2540
		private static int HandleId;
	}
}
