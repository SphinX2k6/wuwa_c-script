using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000137 RID: 311
	public class ConfigBuffItemByPublicCdGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x000867D8 File Offset: 0x000849D8
		static ConfigBuffItemByPublicCdGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffItemByPublicCdGroup.CreateStaticDefaultValue), new Action(ConfigBuffItemByPublicCdGroup.ResetStaticDefaultValue));
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000867F8 File Offset: 0x000849F8
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

		// Token: 0x0600074D RID: 1869 RVA: 0x00086877 File Offset: 0x00084A77
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffItemByPublicCdGroup.LogPair = null;
			ConfigBuffItemByPublicCdGroup.HandleId = 0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00086885 File Offset: 0x00084A85
		public static void Init()
		{
			ConfigBuffItemByPublicCdGroup.HandleId = ConfigCommon.InitDataStatement(ConfigBuffItemByPublicCdGroup.HandleId, "db_itemattributereward.db", "select BinData from `BuffItem` where PublicCdGroup=?");
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000868A0 File Offset: 0x00084AA0
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

		// Token: 0x04000865 RID: 2149
		private const string DB = "db_itemattributereward.db";

		// Token: 0x04000866 RID: 2150
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x04000867 RID: 2151
		private const string TABLE = "BuffItem";

		// Token: 0x04000868 RID: 2152
		private const string COMMAND = "select BinData from `BuffItem` where PublicCdGroup=?";

		// Token: 0x04000869 RID: 2153
		private const string KEY_PREFIX = "BuffItemByPublicCdGroup";

		// Token: 0x0400086A RID: 2154
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400086B RID: 2155
		private static int HandleId;
	}
}
