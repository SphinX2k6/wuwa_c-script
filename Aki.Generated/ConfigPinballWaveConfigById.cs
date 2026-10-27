using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000734 RID: 1844
	public class ConfigPinballWaveConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B48 RID: 11080 RVA: 0x0014E180 File Offset: 0x0014C380
		static ConfigPinballWaveConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWaveConfigById.CreateStaticDefaultValue), new Action(ConfigPinballWaveConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x0014E1A0 File Offset: 0x0014C3A0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWaveConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWaveConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWaveConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWaveConfig` where Id=?")
			});
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x0014E21F File Offset: 0x0014C41F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWaveConfigById.LogPair = null;
			ConfigPinballWaveConfigById.HandleId = 0;
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x0014E22D File Offset: 0x0014C42D
		public static void Init()
		{
			ConfigPinballWaveConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWaveConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWaveConfig` where Id=?");
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x0014E248 File Offset: 0x0014C448
		public static PinballWaveConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWaveConfigById.HandleId, ConfigPinballWaveConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWaveConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWaveConfig?(PinballWaveConfig.GetRootAsPinballWaveConfig(configBuffer));
				}
			}
			ConfigPinballWaveConfigById.LogPair.Clear();
			ConfigPinballWaveConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWaveConfigById.HandleId, 1, p0Id, ConfigPinballWaveConfigById.LogPair) || ConfigCommon.Step(ConfigPinballWaveConfigById.HandleId, true, ConfigPinballWaveConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWaveConfigById.HandleId, ConfigPinballWaveConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWaveConfigById.HandleId, 0, ConfigPinballWaveConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWaveConfigById.HandleId, ConfigPinballWaveConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWaveConfig rootAsPinballWaveConfig = PinballWaveConfig.GetRootAsPinballWaveConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWaveConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWaveConfigById.HandleId, ConfigPinballWaveConfigById.LogPair);
			return new PinballWaveConfig?(rootAsPinballWaveConfig);
		}

		// Token: 0x04003252 RID: 12882
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003253 RID: 12883
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003254 RID: 12884
		private const string TABLE = "PinballWaveConfig";

		// Token: 0x04003255 RID: 12885
		private const string COMMAND = "select BinData from `PinballWaveConfig` where Id=?";

		// Token: 0x04003256 RID: 12886
		private const string KEY_PREFIX = "PinballWaveConfigById";

		// Token: 0x04003257 RID: 12887
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003258 RID: 12888
		private static int HandleId;
	}
}
