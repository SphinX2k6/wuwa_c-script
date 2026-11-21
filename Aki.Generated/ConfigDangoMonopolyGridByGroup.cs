using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FC RID: 508
	public class ConfigDangoMonopolyGridByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BEB RID: 3051 RVA: 0x000A097C File Offset: 0x0009EB7C
		static ConfigDangoMonopolyGridByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyGridByGroup.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyGridByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000A099C File Offset: 0x0009EB9C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyGridByGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyGridByGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyGrid"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyGrid` where GridGroupId=?")
			});
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000A0A1B File Offset: 0x0009EC1B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyGridByGroup.LogPair = null;
			ConfigDangoMonopolyGridByGroup.HandleId = 0;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000A0A29 File Offset: 0x0009EC29
		public static void Init()
		{
			ConfigDangoMonopolyGridByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyGridByGroup.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyGrid` where GridGroupId=?");
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000A0A44 File Offset: 0x0009EC44
		[NullableContext(2)]
		public static IReadOnlyList<DangoMonopolyGrid> GetConfigList(int p0GridGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyGridByGroup.HandleId, ConfigDangoMonopolyGridByGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyGridByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GridGroupId);
				IReadOnlyList<DangoMonopolyGrid> readOnlyList = (IReadOnlyList<DangoMonopolyGrid>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDangoMonopolyGridByGroup.LogPair.Clear();
			ConfigDangoMonopolyGridByGroup.LogPair.Add(new ValueTuple<string, object>("GridGroupId", p0GridGroupId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyGridByGroup.HandleId, 1, p0GridGroupId, ConfigDangoMonopolyGridByGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigDangoMonopolyGridByGroup.HandleId, ConfigDangoMonopolyGridByGroup.LogPair);
				return null;
			}
			List<DangoMonopolyGrid> list = new List<DangoMonopolyGrid>();
			while (ConfigCommon.Step(ConfigDangoMonopolyGridByGroup.HandleId, false, ConfigDangoMonopolyGridByGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyGridByGroup.HandleId, 0, ConfigDangoMonopolyGridByGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoMonopolyGridByGroup.HandleId, ConfigDangoMonopolyGridByGroup.LogPair);
					return null;
				}
				DangoMonopolyGrid rootAsDangoMonopolyGrid = DangoMonopolyGrid.GetRootAsDangoMonopolyGrid(new ByteBuffer(item2));
				list.Add(rootAsDangoMonopolyGrid);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyGridByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GridGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyGridByGroup.HandleId, ConfigDangoMonopolyGridByGroup.LogPair);
			return list;
		}

		// Token: 0x04000DC8 RID: 3528
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DC9 RID: 3529
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DCA RID: 3530
		private const string TABLE = "DangoMonopolyGrid";

		// Token: 0x04000DCB RID: 3531
		private const string COMMAND = "select BinData from `DangoMonopolyGrid` where GridGroupId=?";

		// Token: 0x04000DCC RID: 3532
		private const string KEY_PREFIX = "DangoMonopolyGridByGroup";

		// Token: 0x04000DCD RID: 3533
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DCE RID: 3534
		private static int HandleId;
	}
}
