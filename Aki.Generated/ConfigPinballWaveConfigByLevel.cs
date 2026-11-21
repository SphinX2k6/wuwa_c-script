using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074D RID: 1869
	public class ConfigPinballWaveConfigByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BDE RID: 11230 RVA: 0x00154E44 File Offset: 0x00153044
		static ConfigPinballWaveConfigByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWaveConfigByLevel.CreateStaticDefaultValue), new Action(ConfigPinballWaveConfigByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00154E64 File Offset: 0x00153064
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWaveConfigByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWaveConfigByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWaveConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWaveConfig` where Level=?")
			});
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00154EE3 File Offset: 0x001530E3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWaveConfigByLevel.LogPair = null;
			ConfigPinballWaveConfigByLevel.HandleId = 0;
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00154EF1 File Offset: 0x001530F1
		public static void Init()
		{
			ConfigPinballWaveConfigByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWaveConfigByLevel.HandleId, "db_pinballbattle.db", "select BinData from `PinballWaveConfig` where Level=?");
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00154F0C File Offset: 0x0015310C
		[NullableContext(2)]
		public static IReadOnlyList<PinballWaveConfig> GetConfigList(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWaveConfigByLevel.HandleId, ConfigPinballWaveConfigByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWaveConfigByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				IReadOnlyList<PinballWaveConfig> readOnlyList = (IReadOnlyList<PinballWaveConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPinballWaveConfigByLevel.LogPair.Clear();
			ConfigPinballWaveConfigByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigPinballWaveConfigByLevel.HandleId, 1, p0Level, ConfigPinballWaveConfigByLevel.LogPair))
			{
				ConfigCommon.Reset(ConfigPinballWaveConfigByLevel.HandleId, ConfigPinballWaveConfigByLevel.LogPair);
				return null;
			}
			List<PinballWaveConfig> list = new List<PinballWaveConfig>();
			while (ConfigCommon.Step(ConfigPinballWaveConfigByLevel.HandleId, false, ConfigPinballWaveConfigByLevel.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWaveConfigByLevel.HandleId, 0, ConfigPinballWaveConfigByLevel.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballWaveConfigByLevel.HandleId, ConfigPinballWaveConfigByLevel.LogPair);
					return null;
				}
				PinballWaveConfig rootAsPinballWaveConfig = PinballWaveConfig.GetRootAsPinballWaveConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballWaveConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWaveConfigByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballWaveConfigByLevel.HandleId, ConfigPinballWaveConfigByLevel.LogPair);
			return list;
		}

		// Token: 0x04003301 RID: 13057
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003302 RID: 13058
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003303 RID: 13059
		private const string TABLE = "PinballWaveConfig";

		// Token: 0x04003304 RID: 13060
		private const string COMMAND = "select BinData from `PinballWaveConfig` where Level=?";

		// Token: 0x04003305 RID: 13061
		private const string KEY_PREFIX = "PinballWaveConfigByLevel";

		// Token: 0x04003306 RID: 13062
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003307 RID: 13063
		private static int HandleId;
	}
}
