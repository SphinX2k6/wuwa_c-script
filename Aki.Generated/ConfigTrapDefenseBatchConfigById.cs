using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF3 RID: 2803
	public class ConfigTrapDefenseBatchConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041C6 RID: 16838 RVA: 0x001D0BA8 File Offset: 0x001CEDA8
		static ConfigTrapDefenseBatchConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBatchConfigById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBatchConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x001D0BC8 File Offset: 0x001CEDC8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBatchConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBatchConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefensebatchconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.塔防波次配置/*.csv*"),
				new ValueTuple<string, object>("表名", "TrapDefenseBatchConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBatchConfig` where Id=?")
			});
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x001D0C47 File Offset: 0x001CEE47
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBatchConfigById.LogPair = null;
			ConfigTrapDefenseBatchConfigById.HandleId = 0;
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x001D0C55 File Offset: 0x001CEE55
		public static void Init()
		{
			ConfigTrapDefenseBatchConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBatchConfigById.HandleId, "db_trapdefensebatchconfig.db", "select BinData from `TrapDefenseBatchConfig` where Id=?");
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x001D0C70 File Offset: 0x001CEE70
		public static TrapDefenseBatchConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBatchConfigById.HandleId, ConfigTrapDefenseBatchConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBatchConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBatchConfig?(TrapDefenseBatchConfig.GetRootAsTrapDefenseBatchConfig(configBuffer));
				}
			}
			ConfigTrapDefenseBatchConfigById.LogPair.Clear();
			ConfigTrapDefenseBatchConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBatchConfigById.HandleId, 1, p0Id, ConfigTrapDefenseBatchConfigById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBatchConfigById.HandleId, true, ConfigTrapDefenseBatchConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBatchConfigById.HandleId, ConfigTrapDefenseBatchConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBatchConfigById.HandleId, 0, ConfigTrapDefenseBatchConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBatchConfigById.HandleId, ConfigTrapDefenseBatchConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBatchConfig rootAsTrapDefenseBatchConfig = TrapDefenseBatchConfig.GetRootAsTrapDefenseBatchConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBatchConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBatchConfigById.HandleId, ConfigTrapDefenseBatchConfigById.LogPair);
			return new TrapDefenseBatchConfig?(rootAsTrapDefenseBatchConfig);
		}

		// Token: 0x04004C8B RID: 19595
		private const string DB = "db_trapdefensebatchconfig.db";

		// Token: 0x04004C8C RID: 19596
		private const string FILE = "k.可视化编辑/c.Csv/t.塔防波次配置/*.csv*";

		// Token: 0x04004C8D RID: 19597
		private const string TABLE = "TrapDefenseBatchConfig";

		// Token: 0x04004C8E RID: 19598
		private const string COMMAND = "select BinData from `TrapDefenseBatchConfig` where Id=?";

		// Token: 0x04004C8F RID: 19599
		private const string KEY_PREFIX = "TrapDefenseBatchConfigById";

		// Token: 0x04004C90 RID: 19600
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C91 RID: 19601
		private static int HandleId;
	}
}
