using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6A RID: 2666
	public class ConfigSummonCfgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E90 RID: 16016 RVA: 0x001BE535 File Offset: 0x001BC735
		static ConfigSummonCfgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSummonCfgById.CreateStaticDefaultValue), new Action(ConfigSummonCfgById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x001BE554 File Offset: 0x001BC754
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

		// Token: 0x06003E92 RID: 16018 RVA: 0x001BE5D3 File Offset: 0x001BC7D3
		public static void ResetStaticDefaultValue()
		{
			ConfigSummonCfgById.LogPair = null;
			ConfigSummonCfgById.HandleId = 0;
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x001BE5E1 File Offset: 0x001BC7E1
		public static void Init()
		{
			ConfigSummonCfgById.HandleId = ConfigCommon.InitDataStatement(ConfigSummonCfgById.HandleId, "db_summon.db", "select BinData from `SummonCfg` where id=?");
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x001BE5FC File Offset: 0x001BC7FC
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

		// Token: 0x040048CC RID: 18636
		private const string DB = "db_summon.db";

		// Token: 0x040048CD RID: 18637
		private const string FILE = "z.召唤.xlsx";

		// Token: 0x040048CE RID: 18638
		private const string TABLE = "SummonCfg";

		// Token: 0x040048CF RID: 18639
		private const string COMMAND = "select BinData from `SummonCfg` where id=?";

		// Token: 0x040048D0 RID: 18640
		private const string KEY_PREFIX = "SummonCfgById";

		// Token: 0x040048D1 RID: 18641
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048D2 RID: 18642
		private static int HandleId;
	}
}
