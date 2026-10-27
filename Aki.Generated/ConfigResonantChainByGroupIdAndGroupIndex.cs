using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E5 RID: 2021
	public class ConfigResonantChainByGroupIdAndGroupIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F70 RID: 12144 RVA: 0x00165567 File Offset: 0x00163767
		static ConfigResonantChainByGroupIdAndGroupIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainByGroupIdAndGroupIndex.CreateStaticDefaultValue), new Action(ConfigResonantChainByGroupIdAndGroupIndex.ResetStaticDefaultValue));
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00165588 File Offset: 0x00163788
		public static void CreateStaticDefaultValue()
		{
			ConfigResonantChainByGroupIdAndGroupIndex.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigResonantChainByGroupIdAndGroupIndex.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_resonate_chain.db"),
				new ValueTuple<string, object>("文件", "g.共鸣链.xlsx"),
				new ValueTuple<string, object>("表名", "ResonantChain"),
				new ValueTuple<string, object>("语句", "select BinData from `ResonantChain` where GroupId=? AND GroupIndex=?")
			});
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00165607 File Offset: 0x00163807
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainByGroupIdAndGroupIndex.LogPair = null;
			ConfigResonantChainByGroupIdAndGroupIndex.HandleId = 0;
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00165615 File Offset: 0x00163815
		public static void Init()
		{
			ConfigResonantChainByGroupIdAndGroupIndex.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where GroupId=? AND GroupIndex=?");
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00165630 File Offset: 0x00163830
		public static ResonantChain? GetConfig(int p0GroupId, int p1GroupIndex, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, ConfigResonantChainByGroupIdAndGroupIndex.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainByGroupIdAndGroupIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupIndex);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ResonantChain?(ResonantChain.GetRootAsResonantChain(configBuffer));
				}
			}
			ConfigResonantChainByGroupIdAndGroupIndex.LogPair.Clear();
			ConfigResonantChainByGroupIdAndGroupIndex.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			ConfigResonantChainByGroupIdAndGroupIndex.LogPair.Add(new ValueTuple<string, object>("GroupIndex", p1GroupIndex));
			if (!ConfigCommon.BindInt(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, 1, p0GroupId, ConfigResonantChainByGroupIdAndGroupIndex.LogPair) || !ConfigCommon.BindInt(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, 2, p1GroupIndex, ConfigResonantChainByGroupIdAndGroupIndex.LogPair) || ConfigCommon.Step(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, true, ConfigResonantChainByGroupIdAndGroupIndex.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, ConfigResonantChainByGroupIdAndGroupIndex.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, 0, ConfigResonantChainByGroupIdAndGroupIndex.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, ConfigResonantChainByGroupIdAndGroupIndex.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ResonantChain rootAsResonantChain = ResonantChain.GetRootAsResonantChain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ResonantChainByGroupIdAndGroupIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupIndex);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, ConfigResonantChainByGroupIdAndGroupIndex.LogPair);
			return new ResonantChain?(rootAsResonantChain);
		}

		// Token: 0x04003729 RID: 14121
		private const string DB = "db_resonate_chain.db";

		// Token: 0x0400372A RID: 14122
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x0400372B RID: 14123
		private const string TABLE = "ResonantChain";

		// Token: 0x0400372C RID: 14124
		private const string COMMAND = "select BinData from `ResonantChain` where GroupId=? AND GroupIndex=?";

		// Token: 0x0400372D RID: 14125
		private const string KEY_PREFIX = "ResonantChainByGroupIdAndGroupIndex";

		// Token: 0x0400372E RID: 14126
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400372F RID: 14127
		private static int HandleId;
	}
}
