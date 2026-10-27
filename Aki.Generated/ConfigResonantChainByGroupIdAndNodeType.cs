using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E6 RID: 2022
	public class ConfigResonantChainByGroupIdAndNodeType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F76 RID: 12150 RVA: 0x00165805 File Offset: 0x00163A05
		static ConfigResonantChainByGroupIdAndNodeType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainByGroupIdAndNodeType.CreateStaticDefaultValue), new Action(ConfigResonantChainByGroupIdAndNodeType.ResetStaticDefaultValue));
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00165824 File Offset: 0x00163A24
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

		// Token: 0x06002F78 RID: 12152 RVA: 0x001658A3 File Offset: 0x00163AA3
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainByGroupIdAndNodeType.LogPair = null;
			ConfigResonantChainByGroupIdAndNodeType.HandleId = 0;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x001658B1 File Offset: 0x00163AB1
		public static void Init()
		{
			ConfigResonantChainByGroupIdAndNodeType.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainByGroupIdAndNodeType.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where GroupId=? AND NodeType=?");
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x001658CC File Offset: 0x00163ACC
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

		// Token: 0x04003730 RID: 14128
		private const string DB = "db_resonate_chain.db";

		// Token: 0x04003731 RID: 14129
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x04003732 RID: 14130
		private const string TABLE = "ResonantChain";

		// Token: 0x04003733 RID: 14131
		private const string COMMAND = "select BinData from `ResonantChain` where GroupId=? AND NodeType=?";

		// Token: 0x04003734 RID: 14132
		private const string KEY_PREFIX = "ResonantChainByGroupIdAndNodeType";

		// Token: 0x04003735 RID: 14133
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003736 RID: 14134
		private static int HandleId;
	}
}
