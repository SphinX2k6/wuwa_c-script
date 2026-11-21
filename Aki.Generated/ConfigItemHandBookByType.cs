using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046F RID: 1135
	public class ConfigItemHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AA4 RID: 6820 RVA: 0x000F39B0 File Offset: 0x000F1BB0
		static ConfigItemHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookByType.CreateStaticDefaultValue), new Action(ConfigItemHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000F39D0 File Offset: 0x000F1BD0
		public static void CreateStaticDefaultValue()
		{
			ConfigItemHandBookByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemHandBookByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ItemHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemHandBook` where Type=?")
			});
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000F3A4F File Offset: 0x000F1C4F
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookByType.LogPair = null;
			ConfigItemHandBookByType.HandleId = 0;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000F3A5D File Offset: 0x000F1C5D
		public static void Init()
		{
			ConfigItemHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookByType.HandleId, "db_handbook.db", "select BinData from `ItemHandBook` where Type=?");
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000F3A78 File Offset: 0x000F1C78
		[NullableContext(2)]
		public static IReadOnlyList<ItemHandBook> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemHandBookByType.HandleId, ConfigItemHandBookByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<ItemHandBook> readOnlyList = (IReadOnlyList<ItemHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigItemHandBookByType.LogPair.Clear();
			ConfigItemHandBookByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigItemHandBookByType.HandleId, 1, p0Type, ConfigItemHandBookByType.LogPair))
			{
				ConfigCommon.Reset(ConfigItemHandBookByType.HandleId, ConfigItemHandBookByType.LogPair);
				return null;
			}
			List<ItemHandBook> list = new List<ItemHandBook>();
			while (ConfigCommon.Step(ConfigItemHandBookByType.HandleId, false, ConfigItemHandBookByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemHandBookByType.HandleId, 0, ConfigItemHandBookByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigItemHandBookByType.HandleId, ConfigItemHandBookByType.LogPair);
					return null;
				}
				ItemHandBook rootAsItemHandBook = ItemHandBook.GetRootAsItemHandBook(new ByteBuffer(item2));
				list.Add(rootAsItemHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigItemHandBookByType.HandleId, ConfigItemHandBookByType.LogPair);
			return list;
		}

		// Token: 0x04001EED RID: 7917
		private const string DB = "db_handbook.db";

		// Token: 0x04001EEE RID: 7918
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001EEF RID: 7919
		private const string TABLE = "ItemHandBook";

		// Token: 0x04001EF0 RID: 7920
		private const string COMMAND = "select BinData from `ItemHandBook` where Type=?";

		// Token: 0x04001EF1 RID: 7921
		private const string KEY_PREFIX = "ItemHandBookByType";

		// Token: 0x04001EF2 RID: 7922
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EF3 RID: 7923
		private static int HandleId;
	}
}
