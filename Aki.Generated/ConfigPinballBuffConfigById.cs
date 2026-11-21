using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000726 RID: 1830
	public class ConfigPinballBuffConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AF4 RID: 10996 RVA: 0x0014FA13 File Offset: 0x0014DC13
		static ConfigPinballBuffConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballBuffConfigById.CreateStaticDefaultValue), new Action(ConfigPinballBuffConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x0014FA34 File Offset: 0x0014DC34
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballBuffConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballBuffConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_通用.xlsx"),
				new ValueTuple<string, object>("表名", "PinballBuffConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballBuffConfig` where BuffId=?")
			});
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0014FAB3 File Offset: 0x0014DCB3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballBuffConfigById.LogPair = null;
			ConfigPinballBuffConfigById.HandleId = 0;
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0014FAC1 File Offset: 0x0014DCC1
		public static void Init()
		{
			ConfigPinballBuffConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballBuffConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballBuffConfig` where BuffId=?");
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0014FADC File Offset: 0x0014DCDC
		public static PinballBuffConfig? GetConfig(int p0BuffId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballBuffConfigById.HandleId, ConfigPinballBuffConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballBuffConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BuffId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballBuffConfig?(PinballBuffConfig.GetRootAsPinballBuffConfig(configBuffer));
				}
			}
			ConfigPinballBuffConfigById.LogPair.Clear();
			ConfigPinballBuffConfigById.LogPair.Add(new ValueTuple<string, object>("BuffId", p0BuffId));
			if (!ConfigCommon.BindInt(ConfigPinballBuffConfigById.HandleId, 1, p0BuffId, ConfigPinballBuffConfigById.LogPair) || ConfigCommon.Step(ConfigPinballBuffConfigById.HandleId, true, ConfigPinballBuffConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballBuffConfigById.HandleId, ConfigPinballBuffConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballBuffConfigById.HandleId, 0, ConfigPinballBuffConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballBuffConfigById.HandleId, ConfigPinballBuffConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballBuffConfig rootAsPinballBuffConfig = PinballBuffConfig.GetRootAsPinballBuffConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballBuffConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BuffId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballBuffConfigById.HandleId, ConfigPinballBuffConfigById.LogPair);
			return new PinballBuffConfig?(rootAsPinballBuffConfig);
		}

		// Token: 0x040031F0 RID: 12784
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031F1 RID: 12785
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x040031F2 RID: 12786
		private const string TABLE = "PinballBuffConfig";

		// Token: 0x040031F3 RID: 12787
		private const string COMMAND = "select BinData from `PinballBuffConfig` where BuffId=?";

		// Token: 0x040031F4 RID: 12788
		private const string KEY_PREFIX = "PinballBuffConfigById";

		// Token: 0x040031F5 RID: 12789
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031F6 RID: 12790
		private static int HandleId;
	}
}
