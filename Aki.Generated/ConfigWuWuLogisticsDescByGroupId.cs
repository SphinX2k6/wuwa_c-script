using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B76 RID: 2934
	public class ConfigWuWuLogisticsDescByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044D9 RID: 17625 RVA: 0x001E2A51 File Offset: 0x001E0C51
		static ConfigWuWuLogisticsDescByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuLogisticsDescByGroupId.CreateStaticDefaultValue), new Action(ConfigWuWuLogisticsDescByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x001E2A70 File Offset: 0x001E0C70
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

		// Token: 0x060044DB RID: 17627 RVA: 0x001E2AEF File Offset: 0x001E0CEF
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuLogisticsDescByGroupId.LogPair = null;
			ConfigWuWuLogisticsDescByGroupId.HandleId = 0;
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x001E2AFD File Offset: 0x001E0CFD
		public static void Init()
		{
			ConfigWuWuLogisticsDescByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuLogisticsDescByGroupId.HandleId, "db_wuwutask.db", "select BinData from `WuWuLogisticsDesc` where GroupId=?");
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x001E2B18 File Offset: 0x001E0D18
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

		// Token: 0x04005020 RID: 20512
		private const string DB = "db_wuwutask.db";

		// Token: 0x04005021 RID: 20513
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04005022 RID: 20514
		private const string TABLE = "WuWuLogisticsDesc";

		// Token: 0x04005023 RID: 20515
		private const string COMMAND = "select BinData from `WuWuLogisticsDesc` where GroupId=?";

		// Token: 0x04005024 RID: 20516
		private const string KEY_PREFIX = "WuWuLogisticsDescByGroupId";

		// Token: 0x04005025 RID: 20517
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04005026 RID: 20518
		private static int HandleId;
	}
}
