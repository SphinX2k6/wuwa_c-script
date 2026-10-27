using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000459 RID: 1113
	public class ConfigItemHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A20 RID: 6688 RVA: 0x000ED25C File Offset: 0x000EB45C
		static ConfigItemHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookByType.CreateStaticDefaultValue), new Action(ConfigItemHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000ED27C File Offset: 0x000EB47C
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

		// Token: 0x06001A22 RID: 6690 RVA: 0x000ED2FB File Offset: 0x000EB4FB
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookByType.LogPair = null;
			ConfigItemHandBookByType.HandleId = 0;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000ED309 File Offset: 0x000EB509
		public static void Init()
		{
			ConfigItemHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookByType.HandleId, "db_handbook.db", "select BinData from `ItemHandBook` where Type=?");
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000ED324 File Offset: 0x000EB524
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

		// Token: 0x04001E53 RID: 7763
		private const string DB = "db_handbook.db";

		// Token: 0x04001E54 RID: 7764
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001E55 RID: 7765
		private const string TABLE = "ItemHandBook";

		// Token: 0x04001E56 RID: 7766
		private const string COMMAND = "select BinData from `ItemHandBook` where Type=?";

		// Token: 0x04001E57 RID: 7767
		private const string KEY_PREFIX = "ItemHandBookByType";

		// Token: 0x04001E58 RID: 7768
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E59 RID: 7769
		private static int HandleId;
	}
}
