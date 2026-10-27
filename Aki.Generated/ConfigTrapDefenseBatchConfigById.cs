using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1E RID: 2590
	public class ConfigTrapDefenseBatchConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CC8 RID: 15560 RVA: 0x001B1814 File Offset: 0x001AFA14
		static ConfigTrapDefenseBatchConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBatchConfigById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBatchConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x001B1834 File Offset: 0x001AFA34
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

		// Token: 0x06003CCA RID: 15562 RVA: 0x001B18B3 File Offset: 0x001AFAB3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBatchConfigById.LogPair = null;
			ConfigTrapDefenseBatchConfigById.HandleId = 0;
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x001B18C1 File Offset: 0x001AFAC1
		public static void Init()
		{
			ConfigTrapDefenseBatchConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBatchConfigById.HandleId, "db_trapdefensebatchconfig.db", "select BinData from `TrapDefenseBatchConfig` where Id=?");
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x001B18DC File Offset: 0x001AFADC
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

		// Token: 0x040046B8 RID: 18104
		private const string DB = "db_trapdefensebatchconfig.db";

		// Token: 0x040046B9 RID: 18105
		private const string FILE = "k.可视化编辑/c.Csv/t.塔防波次配置/*.csv*";

		// Token: 0x040046BA RID: 18106
		private const string TABLE = "TrapDefenseBatchConfig";

		// Token: 0x040046BB RID: 18107
		private const string COMMAND = "select BinData from `TrapDefenseBatchConfig` where Id=?";

		// Token: 0x040046BC RID: 18108
		private const string KEY_PREFIX = "TrapDefenseBatchConfigById";

		// Token: 0x040046BD RID: 18109
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046BE RID: 18110
		private static int HandleId;
	}
}
