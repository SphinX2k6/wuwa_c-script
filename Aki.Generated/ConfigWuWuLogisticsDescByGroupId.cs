using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA1 RID: 2721
	public class ConfigWuWuLogisticsDescByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x001C36BD File Offset: 0x001C18BD
		static ConfigWuWuLogisticsDescByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuLogisticsDescByGroupId.CreateStaticDefaultValue), new Action(ConfigWuWuLogisticsDescByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x001C36DC File Offset: 0x001C18DC
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuLogisticsDescByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuLogisticsDescByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuLogisticsDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuLogisticsDesc` where GroupId=?")
			});
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x001C375B File Offset: 0x001C195B
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuLogisticsDescByGroupId.LogPair = null;
			ConfigWuWuLogisticsDescByGroupId.HandleId = 0;
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x001C3769 File Offset: 0x001C1969
		public static void Init()
		{
			ConfigWuWuLogisticsDescByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuLogisticsDescByGroupId.HandleId, "db_wuwutask.db", "select BinData from `WuWuLogisticsDesc` where GroupId=?");
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x001C3784 File Offset: 0x001C1984
		[NullableContext(2)]
		public static IReadOnlyList<WuWuLogisticsDesc> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuLogisticsDescByGroupId.HandleId, ConfigWuWuLogisticsDescByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuLogisticsDescByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<WuWuLogisticsDesc> readOnlyList = (IReadOnlyList<WuWuLogisticsDesc>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWuWuLogisticsDescByGroupId.LogPair.Clear();
			ConfigWuWuLogisticsDescByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigWuWuLogisticsDescByGroupId.HandleId, 1, p0GroupId, ConfigWuWuLogisticsDescByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigWuWuLogisticsDescByGroupId.HandleId, ConfigWuWuLogisticsDescByGroupId.LogPair);
				return null;
			}
			List<WuWuLogisticsDesc> list = new List<WuWuLogisticsDesc>();
			while (ConfigCommon.Step(ConfigWuWuLogisticsDescByGroupId.HandleId, false, ConfigWuWuLogisticsDescByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuLogisticsDescByGroupId.HandleId, 0, ConfigWuWuLogisticsDescByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWuWuLogisticsDescByGroupId.HandleId, ConfigWuWuLogisticsDescByGroupId.LogPair);
					return null;
				}
				WuWuLogisticsDesc rootAsWuWuLogisticsDesc = WuWuLogisticsDesc.GetRootAsWuWuLogisticsDesc(new ByteBuffer(item2));
				list.Add(rootAsWuWuLogisticsDesc);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuLogisticsDescByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWuWuLogisticsDescByGroupId.HandleId, ConfigWuWuLogisticsDescByGroupId.LogPair);
			return list;
		}

		// Token: 0x04004A4D RID: 19021
		private const string DB = "db_wuwutask.db";

		// Token: 0x04004A4E RID: 19022
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04004A4F RID: 19023
		private const string TABLE = "WuWuLogisticsDesc";

		// Token: 0x04004A50 RID: 19024
		private const string COMMAND = "select BinData from `WuWuLogisticsDesc` where GroupId=?";

		// Token: 0x04004A51 RID: 19025
		private const string KEY_PREFIX = "WuWuLogisticsDescByGroupId";

		// Token: 0x04004A52 RID: 19026
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A53 RID: 19027
		private static int HandleId;
	}
}
