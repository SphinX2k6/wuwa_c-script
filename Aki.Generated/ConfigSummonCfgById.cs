using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000995 RID: 2453
	public class ConfigSummonCfgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003992 RID: 14738 RVA: 0x0019F1A1 File Offset: 0x0019D3A1
		static ConfigSummonCfgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSummonCfgById.CreateStaticDefaultValue), new Action(ConfigSummonCfgById.ResetStaticDefaultValue));
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x0019F1C0 File Offset: 0x0019D3C0
		public static void CreateStaticDefaultValue()
		{
			ConfigSummonCfgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSummonCfgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_summon.db"),
				new ValueTuple<string, object>("文件", "z.召唤.xlsx"),
				new ValueTuple<string, object>("表名", "SummonCfg"),
				new ValueTuple<string, object>("语句", "select BinData from `SummonCfg` where id=?")
			});
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x0019F23F File Offset: 0x0019D43F
		public static void ResetStaticDefaultValue()
		{
			ConfigSummonCfgById.LogPair = null;
			ConfigSummonCfgById.HandleId = 0;
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x0019F24D File Offset: 0x0019D44D
		public static void Init()
		{
			ConfigSummonCfgById.HandleId = ConfigCommon.InitDataStatement(ConfigSummonCfgById.HandleId, "db_summon.db", "select BinData from `SummonCfg` where id=?");
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x0019F268 File Offset: 0x0019D468
		public static SummonCfg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSummonCfgById.HandleId, ConfigSummonCfgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SummonCfgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SummonCfg?(SummonCfg.GetRootAsSummonCfg(configBuffer));
				}
			}
			ConfigSummonCfgById.LogPair.Clear();
			ConfigSummonCfgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSummonCfgById.HandleId, 1, p0Id, ConfigSummonCfgById.LogPair) || ConfigCommon.Step(ConfigSummonCfgById.HandleId, true, ConfigSummonCfgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSummonCfgById.HandleId, ConfigSummonCfgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSummonCfgById.HandleId, 0, ConfigSummonCfgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSummonCfgById.HandleId, ConfigSummonCfgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SummonCfg rootAsSummonCfg = SummonCfg.GetRootAsSummonCfg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SummonCfgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSummonCfgById.HandleId, ConfigSummonCfgById.LogPair);
			return new SummonCfg?(rootAsSummonCfg);
		}

		// Token: 0x040042F9 RID: 17145
		private const string DB = "db_summon.db";

		// Token: 0x040042FA RID: 17146
		private const string FILE = "z.召唤.xlsx";

		// Token: 0x040042FB RID: 17147
		private const string TABLE = "SummonCfg";

		// Token: 0x040042FC RID: 17148
		private const string COMMAND = "select BinData from `SummonCfg` where id=?";

		// Token: 0x040042FD RID: 17149
		private const string KEY_PREFIX = "SummonCfgById";

		// Token: 0x040042FE RID: 17150
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042FF RID: 17151
		private static int HandleId;
	}
}
