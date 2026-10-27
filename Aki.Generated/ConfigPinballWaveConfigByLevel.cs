using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000735 RID: 1845
	public class ConfigPinballWaveConfigByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B4E RID: 11086 RVA: 0x0014E3C8 File Offset: 0x0014C5C8
		static ConfigPinballWaveConfigByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWaveConfigByLevel.CreateStaticDefaultValue), new Action(ConfigPinballWaveConfigByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x0014E3E8 File Offset: 0x0014C5E8
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

		// Token: 0x06002B50 RID: 11088 RVA: 0x0014E467 File Offset: 0x0014C667
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWaveConfigByLevel.LogPair = null;
			ConfigPinballWaveConfigByLevel.HandleId = 0;
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x0014E475 File Offset: 0x0014C675
		public static void Init()
		{
			ConfigPinballWaveConfigByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWaveConfigByLevel.HandleId, "db_pinballbattle.db", "select BinData from `PinballWaveConfig` where Level=?");
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x0014E490 File Offset: 0x0014C690
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

		// Token: 0x04003259 RID: 12889
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400325A RID: 12890
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x0400325B RID: 12891
		private const string TABLE = "PinballWaveConfig";

		// Token: 0x0400325C RID: 12892
		private const string COMMAND = "select BinData from `PinballWaveConfig` where Level=?";

		// Token: 0x0400325D RID: 12893
		private const string KEY_PREFIX = "PinballWaveConfigByLevel";

		// Token: 0x0400325E RID: 12894
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400325F RID: 12895
		private static int HandleId;
	}
}
