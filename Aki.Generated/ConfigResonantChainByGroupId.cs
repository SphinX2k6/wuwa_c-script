using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000800 RID: 2048
	public class ConfigResonantChainByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003012 RID: 12306 RVA: 0x0016C618 File Offset: 0x0016A818
		static ConfigResonantChainByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainByGroupId.CreateStaticDefaultValue), new Action(ConfigResonantChainByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x0016C638 File Offset: 0x0016A838
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

		// Token: 0x06003014 RID: 12308 RVA: 0x0016C6B7 File Offset: 0x0016A8B7
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainByGroupId.LogPair = null;
			ConfigResonantChainByGroupId.HandleId = 0;
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x0016C6C5 File Offset: 0x0016A8C5
		public static void Init()
		{
			ConfigResonantChainByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainByGroupId.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where GroupId=?");
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x0016C6E0 File Offset: 0x0016A8E0
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

		// Token: 0x040037E6 RID: 14310
		private const string DB = "db_resonate_chain.db";

		// Token: 0x040037E7 RID: 14311
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x040037E8 RID: 14312
		private const string TABLE = "ResonantChain";

		// Token: 0x040037E9 RID: 14313
		private const string COMMAND = "select BinData from `ResonantChain` where GroupId=?";

		// Token: 0x040037EA RID: 14314
		private const string KEY_PREFIX = "ResonantChainByGroupId";

		// Token: 0x040037EB RID: 14315
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037EC RID: 14316
		private static int HandleId;
	}
}
