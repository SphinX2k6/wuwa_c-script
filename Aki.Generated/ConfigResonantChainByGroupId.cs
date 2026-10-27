using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E4 RID: 2020
	public class ConfigResonantChainByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F6A RID: 12138 RVA: 0x00165330 File Offset: 0x00163530
		static ConfigResonantChainByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainByGroupId.CreateStaticDefaultValue), new Action(ConfigResonantChainByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00165350 File Offset: 0x00163550
		public static void CreateStaticDefaultValue()
		{
			ConfigResonantChainByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigResonantChainByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_resonate_chain.db"),
				new ValueTuple<string, object>("文件", "g.共鸣链.xlsx"),
				new ValueTuple<string, object>("表名", "ResonantChain"),
				new ValueTuple<string, object>("语句", "select BinData from `ResonantChain` where GroupId=?")
			});
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x001653CF File Offset: 0x001635CF
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainByGroupId.LogPair = null;
			ConfigResonantChainByGroupId.HandleId = 0;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x001653DD File Offset: 0x001635DD
		public static void Init()
		{
			ConfigResonantChainByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainByGroupId.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where GroupId=?");
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x001653F8 File Offset: 0x001635F8
		[NullableContext(2)]
		public static IReadOnlyList<ResonantChain> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigResonantChainByGroupId.HandleId, ConfigResonantChainByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<ResonantChain> readOnlyList = (IReadOnlyList<ResonantChain>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigResonantChainByGroupId.LogPair.Clear();
			ConfigResonantChainByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigResonantChainByGroupId.HandleId, 1, p0GroupId, ConfigResonantChainByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigResonantChainByGroupId.HandleId, ConfigResonantChainByGroupId.LogPair);
				return null;
			}
			List<ResonantChain> list = new List<ResonantChain>();
			while (ConfigCommon.Step(ConfigResonantChainByGroupId.HandleId, false, ConfigResonantChainByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigResonantChainByGroupId.HandleId, 0, ConfigResonantChainByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigResonantChainByGroupId.HandleId, ConfigResonantChainByGroupId.LogPair);
					return null;
				}
				ResonantChain rootAsResonantChain = ResonantChain.GetRootAsResonantChain(new ByteBuffer(item2));
				list.Add(rootAsResonantChain);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigResonantChainByGroupId.HandleId, ConfigResonantChainByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003722 RID: 14114
		private const string DB = "db_resonate_chain.db";

		// Token: 0x04003723 RID: 14115
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x04003724 RID: 14116
		private const string TABLE = "ResonantChain";

		// Token: 0x04003725 RID: 14117
		private const string COMMAND = "select BinData from `ResonantChain` where GroupId=?";

		// Token: 0x04003726 RID: 14118
		private const string KEY_PREFIX = "ResonantChainByGroupId";

		// Token: 0x04003727 RID: 14119
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003728 RID: 14120
		private static int HandleId;
	}
}
