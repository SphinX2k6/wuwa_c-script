using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015E RID: 350
	public class ConfigChipHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x00087E14 File Offset: 0x00086014
		static ConfigChipHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipHandBookByType.CreateStaticDefaultValue), new Action(ConfigChipHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00087E34 File Offset: 0x00086034
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

		// Token: 0x06000837 RID: 2103 RVA: 0x00087EB3 File Offset: 0x000860B3
		public static void ResetStaticDefaultValue()
		{
			ConfigChipHandBookByType.LogPair = null;
			ConfigChipHandBookByType.HandleId = 0;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00087EC1 File Offset: 0x000860C1
		public static void Init()
		{
			ConfigChipHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigChipHandBookByType.HandleId, "db_handbook.db", "select BinData from `ChipHandBook` where Type=?");
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00087EDC File Offset: 0x000860DC
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

		// Token: 0x04000976 RID: 2422
		private const string DB = "db_handbook.db";

		// Token: 0x04000977 RID: 2423
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04000978 RID: 2424
		private const string TABLE = "ChipHandBook";

		// Token: 0x04000979 RID: 2425
		private const string COMMAND = "select BinData from `ChipHandBook` where Type=?";

		// Token: 0x0400097A RID: 2426
		private const string KEY_PREFIX = "ChipHandBookByType";

		// Token: 0x0400097B RID: 2427
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400097C RID: 2428
		private static int HandleId;
	}
}
