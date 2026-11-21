using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000801 RID: 2049
	public class ConfigResonantChainByGroupIdAndGroupIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003018 RID: 12312 RVA: 0x0016C84F File Offset: 0x0016AA4F
		static ConfigResonantChainByGroupIdAndGroupIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainByGroupIdAndGroupIndex.CreateStaticDefaultValue), new Action(ConfigResonantChainByGroupIdAndGroupIndex.ResetStaticDefaultValue));
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x0016C870 File Offset: 0x0016AA70
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

		// Token: 0x0600301A RID: 12314 RVA: 0x0016C8EF File Offset: 0x0016AAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainByGroupIdAndGroupIndex.LogPair = null;
			ConfigResonantChainByGroupIdAndGroupIndex.HandleId = 0;
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x0016C8FD File Offset: 0x0016AAFD
		public static void Init()
		{
			ConfigResonantChainByGroupIdAndGroupIndex.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainByGroupIdAndGroupIndex.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where GroupId=? AND GroupIndex=?");
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0016C918 File Offset: 0x0016AB18
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

		// Token: 0x040037ED RID: 14317
		private const string DB = "db_resonate_chain.db";

		// Token: 0x040037EE RID: 14318
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x040037EF RID: 14319
		private const string TABLE = "ResonantChain";

		// Token: 0x040037F0 RID: 14320
		private const string COMMAND = "select BinData from `ResonantChain` where GroupId=? AND GroupIndex=?";

		// Token: 0x040037F1 RID: 14321
		private const string KEY_PREFIX = "ResonantChainByGroupIdAndGroupIndex";

		// Token: 0x040037F2 RID: 14322
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037F3 RID: 14323
		private static int HandleId;
	}
}
