using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001EA RID: 490
	public class ConfigDangoMonopolyGridByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x0009AA44 File Offset: 0x00098C44
		static ConfigDangoMonopolyGridByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyGridByGroup.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyGridByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0009AA64 File Offset: 0x00098C64
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

		// Token: 0x06000B81 RID: 2945 RVA: 0x0009AAE3 File Offset: 0x00098CE3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyGridByGroup.LogPair = null;
			ConfigDangoMonopolyGridByGroup.HandleId = 0;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0009AAF1 File Offset: 0x00098CF1
		public static void Init()
		{
			ConfigDangoMonopolyGridByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyGridByGroup.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyGrid` where GridGroupId=?");
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0009AB0C File Offset: 0x00098D0C
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

		// Token: 0x04000D4A RID: 3402
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D4B RID: 3403
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D4C RID: 3404
		private const string TABLE = "DangoMonopolyGrid";

		// Token: 0x04000D4D RID: 3405
		private const string COMMAND = "select BinData from `DangoMonopolyGrid` where GridGroupId=?";

		// Token: 0x04000D4E RID: 3406
		private const string KEY_PREFIX = "DangoMonopolyGridByGroup";

		// Token: 0x04000D4F RID: 3407
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D50 RID: 3408
		private static int HandleId;
	}
}
