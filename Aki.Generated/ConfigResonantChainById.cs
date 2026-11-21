using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000803 RID: 2051
	public class ConfigResonantChainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x0016CD7B File Offset: 0x0016AF7B
		static ConfigResonantChainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResonantChainById.CreateStaticDefaultValue), new Action(ConfigResonantChainById.ResetStaticDefaultValue));
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x0016CD9C File Offset: 0x0016AF9C
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

		// Token: 0x06003026 RID: 12326 RVA: 0x0016CE1B File Offset: 0x0016B01B
		public static void ResetStaticDefaultValue()
		{
			ConfigResonantChainById.LogPair = null;
			ConfigResonantChainById.HandleId = 0;
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x0016CE29 File Offset: 0x0016B029
		public static void Init()
		{
			ConfigResonantChainById.HandleId = ConfigCommon.InitDataStatement(ConfigResonantChainById.HandleId, "db_resonate_chain.db", "select BinData from `ResonantChain` where Id=?");
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x0016CE44 File Offset: 0x0016B044
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

		// Token: 0x040037FB RID: 14331
		private const string DB = "db_resonate_chain.db";

		// Token: 0x040037FC RID: 14332
		private const string FILE = "g.共鸣链.xlsx";

		// Token: 0x040037FD RID: 14333
		private const string TABLE = "ResonantChain";

		// Token: 0x040037FE RID: 14334
		private const string COMMAND = "select BinData from `ResonantChain` where Id=?";

		// Token: 0x040037FF RID: 14335
		private const string KEY_PREFIX = "ResonantChainById";

		// Token: 0x04003800 RID: 14336
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003801 RID: 14337
		private static int HandleId;
	}
}
