using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E7 RID: 2023
	public class ConfigResonantChainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F7C RID: 12156 RVA: 0x00165A93 File Offset: 0x00163C93
		static ConfigResonantChainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainById.CreateStaticDefaultValue), new Action(ConfigResonantChainById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00165AB4 File Offset: 0x00163CB4
		public static void CreateStaticDefaultValue()
		{
			ConfigResonantChainById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigResonantChainById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_resonate_chain.db"),
				new ValueTuple<string, object>("文件", "g.共鸣链.xlsx"),
				new ValueTuple<string, object>("表名", "ResonantChain"),
				new ValueTuple<string, object>("语句", "select BinData from `ResonantChain` where Id=?")
			});
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00165B33 File Offset: 0x00163D33
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainById.LogPair = null;
			ConfigResonantChainById.HandleId = 0;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00165B41 File Offset: 0x00163D41
		public static void Init()
		{
			ConfigResonantChainById.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainById.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where Id=?");
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00165B5C File Offset: 0x00163D5C
		public static ResonantChain? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigResonantChainById.HandleId, ConfigResonantChainById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ResonantChain?(ResonantChain.GetRootAsResonantChain(configBuffer));
				}
			}
			ConfigResonantChainById.LogPair.Clear();
			ConfigResonantChainById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigResonantChainById.HandleId, 1, p0Id, ConfigResonantChainById.LogPair) || ConfigCommon.Step(ConfigResonantChainById.HandleId, true, ConfigResonantChainById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigResonantChainById.HandleId, ConfigResonantChainById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigResonantChainById.HandleId, 0, ConfigResonantChainById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigResonantChainById.HandleId, ConfigResonantChainById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ResonantChain rootAsResonantChain = ResonantChain.GetRootAsResonantChain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigResonantChainById.HandleId, ConfigResonantChainById.LogPair);
			return new ResonantChain?(rootAsResonantChain);
		}

		// Token: 0x04003737 RID: 14135
		private const string DB = "db_resonate_chain.db";

		// Token: 0x04003738 RID: 14136
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x04003739 RID: 14137
		private const string TABLE = "ResonantChain";

		// Token: 0x0400373A RID: 14138
		private const string COMMAND = "select BinData from `ResonantChain` where Id=?";

		// Token: 0x0400373B RID: 14139
		private const string KEY_PREFIX = "ResonantChainById";

		// Token: 0x0400373C RID: 14140
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400373D RID: 14141
		private static int HandleId;
	}
}
