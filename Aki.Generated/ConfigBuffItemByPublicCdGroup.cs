using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000128 RID: 296
	public class ConfigBuffItemByPublicCdGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006F1 RID: 1777 RVA: 0x00080E74 File Offset: 0x0007F074
		static ConfigBuffItemByPublicCdGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffItemByPublicCdGroup.CreateStaticDefaultValue), new Action(ConfigBuffItemByPublicCdGroup.ResetStaticDefaultValue));
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00080E94 File Offset: 0x0007F094
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffItemByPublicCdGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffItemByPublicCdGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_itemattributereward.db"),
				new ValueTuple<string, object>("文件", "s.属性奖励.xlsx"),
				new ValueTuple<string, object>("表名", "BuffItem"),
				new ValueTuple<string, object>("语句", "select BinData from `BuffItem` where PublicCdGroup=?")
			});
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00080F13 File Offset: 0x0007F113
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffItemByPublicCdGroup.LogPair = null;
			ConfigBuffItemByPublicCdGroup.HandleId = 0;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00080F21 File Offset: 0x0007F121
		public static void Init()
		{
			ConfigBuffItemByPublicCdGroup.HandleId = ConfigCommon.InitDataStatement(ConfigBuffItemByPublicCdGroup.HandleId, "db_itemattributereward.db", "select BinData from `BuffItem` where PublicCdGroup=?");
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00080F3C File Offset: 0x0007F13C
		[NullableContext(2)]
		public static IReadOnlyList<BuffItem> GetConfigList(int p0PublicCdGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffItemByPublicCdGroup.HandleId, ConfigBuffItemByPublicCdGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffItemByPublicCdGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PublicCdGroup);
				IReadOnlyList<BuffItem> readOnlyList = (IReadOnlyList<BuffItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBuffItemByPublicCdGroup.LogPair.Clear();
			ConfigBuffItemByPublicCdGroup.LogPair.Add(new ValueTuple<string, object>("PublicCdGroup", p0PublicCdGroup));
			if (!ConfigCommon.BindInt(ConfigBuffItemByPublicCdGroup.HandleId, 1, p0PublicCdGroup, ConfigBuffItemByPublicCdGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigBuffItemByPublicCdGroup.HandleId, ConfigBuffItemByPublicCdGroup.LogPair);
				return null;
			}
			List<BuffItem> list = new List<BuffItem>();
			while (ConfigCommon.Step(ConfigBuffItemByPublicCdGroup.HandleId, false, ConfigBuffItemByPublicCdGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffItemByPublicCdGroup.HandleId, 0, ConfigBuffItemByPublicCdGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBuffItemByPublicCdGroup.HandleId, ConfigBuffItemByPublicCdGroup.LogPair);
					return null;
				}
				BuffItem rootAsBuffItem = BuffItem.GetRootAsBuffItem(new ByteBuffer(item2));
				list.Add(rootAsBuffItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffItemByPublicCdGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PublicCdGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBuffItemByPublicCdGroup.HandleId, ConfigBuffItemByPublicCdGroup.LogPair);
			return list;
		}

		// Token: 0x040007FC RID: 2044
		private const string DB = "db_itemattributereward.db";

		// Token: 0x040007FD RID: 2045
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x040007FE RID: 2046
		private const string TABLE = "BuffItem";

		// Token: 0x040007FF RID: 2047
		private const string COMMAND = "select BinData from `BuffItem` where PublicCdGroup=?";

		// Token: 0x04000800 RID: 2048
		private const string KEY_PREFIX = "BuffItemByPublicCdGroup";

		// Token: 0x04000801 RID: 2049
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000802 RID: 2050
		private static int HandleId;
	}
}
