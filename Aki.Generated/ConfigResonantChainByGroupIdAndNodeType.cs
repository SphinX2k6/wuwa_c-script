using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000802 RID: 2050
	public class ConfigResonantChainByGroupIdAndNodeType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600301E RID: 12318 RVA: 0x0016CAED File Offset: 0x0016ACED
		static ConfigResonantChainByGroupIdAndNodeType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainByGroupIdAndNodeType.CreateStaticDefaultValue), new Action(ConfigResonantChainByGroupIdAndNodeType.ResetStaticDefaultValue));
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x0016CB0C File Offset: 0x0016AD0C
		public static void CreateStaticDefaultValue()
		{
			ConfigResonantChainByGroupIdAndNodeType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigResonantChainByGroupIdAndNodeType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_resonate_chain.db"),
				new ValueTuple<string, object>("文件", "g.共鸣链.xlsx"),
				new ValueTuple<string, object>("表名", "ResonantChain"),
				new ValueTuple<string, object>("语句", "select BinData from `ResonantChain` where GroupId=? AND NodeType=?")
			});
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0016CB8B File Offset: 0x0016AD8B
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainByGroupIdAndNodeType.LogPair = null;
			ConfigResonantChainByGroupIdAndNodeType.HandleId = 0;
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x0016CB99 File Offset: 0x0016AD99
		public static void Init()
		{
			ConfigResonantChainByGroupIdAndNodeType.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainByGroupIdAndNodeType.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where GroupId=? AND NodeType=?");
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x0016CBB4 File Offset: 0x0016ADB4
		[NullableContext(2)]
		public static IReadOnlyList<ResonantChain> GetConfigList(int p0GroupId, int p1NodeType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigResonantChainByGroupIdAndNodeType.HandleId, ConfigResonantChainByGroupIdAndNodeType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainByGroupIdAndNodeType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1NodeType);
				IReadOnlyList<ResonantChain> readOnlyList = (IReadOnlyList<ResonantChain>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigResonantChainByGroupIdAndNodeType.LogPair.Clear();
			ConfigResonantChainByGroupIdAndNodeType.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			ConfigResonantChainByGroupIdAndNodeType.LogPair.Add(new ValueTuple<string, object>("NodeType", p1NodeType));
			if (!ConfigCommon.BindInt(ConfigResonantChainByGroupIdAndNodeType.HandleId, 1, p0GroupId, ConfigResonantChainByGroupIdAndNodeType.LogPair) || !ConfigCommon.BindInt(ConfigResonantChainByGroupIdAndNodeType.HandleId, 2, p1NodeType, ConfigResonantChainByGroupIdAndNodeType.LogPair))
			{
				ConfigCommon.Reset(ConfigResonantChainByGroupIdAndNodeType.HandleId, ConfigResonantChainByGroupIdAndNodeType.LogPair);
				return null;
			}
			List<ResonantChain> list = new List<ResonantChain>();
			while (ConfigCommon.Step(ConfigResonantChainByGroupIdAndNodeType.HandleId, false, ConfigResonantChainByGroupIdAndNodeType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigResonantChainByGroupIdAndNodeType.HandleId, 0, ConfigResonantChainByGroupIdAndNodeType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigResonantChainByGroupIdAndNodeType.HandleId, ConfigResonantChainByGroupIdAndNodeType.LogPair);
					return null;
				}
				ResonantChain rootAsResonantChain = ResonantChain.GetRootAsResonantChain(new ByteBuffer(item2));
				list.Add(rootAsResonantChain);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainByGroupIdAndNodeType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1NodeType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigResonantChainByGroupIdAndNodeType.HandleId, ConfigResonantChainByGroupIdAndNodeType.LogPair);
			return list;
		}

		// Token: 0x040037F4 RID: 14324
		private const string DB = "db_resonate_chain.db";

		// Token: 0x040037F5 RID: 14325
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x040037F6 RID: 14326
		private const string TABLE = "ResonantChain";

		// Token: 0x040037F7 RID: 14327
		private const string COMMAND = "select BinData from `ResonantChain` where GroupId=? AND NodeType=?";

		// Token: 0x040037F8 RID: 14328
		private const string KEY_PREFIX = "ResonantChainByGroupIdAndNodeType";

		// Token: 0x040037F9 RID: 14329
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037FA RID: 14330
		private static int HandleId;
	}
}
