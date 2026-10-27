using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071C RID: 1820
	public class ConfigPinballLevelConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AB8 RID: 10936 RVA: 0x0014AD5B File Offset: 0x00148F5B
		static ConfigPinballLevelConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballLevelConfigById.CreateStaticDefaultValue), new Action(ConfigPinballLevelConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0014AD7C File Offset: 0x00148F7C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballLevelConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballLevelConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballLevelConfig` where Id=?")
			});
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0014ADFB File Offset: 0x00148FFB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballLevelConfigById.LogPair = null;
			ConfigPinballLevelConfigById.HandleId = 0;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0014AE09 File Offset: 0x00149009
		public static void Init()
		{
			ConfigPinballLevelConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballLevelConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballLevelConfig` where Id=?");
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0014AE24 File Offset: 0x00149024
		public static PinballLevelConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballLevelConfig?(PinballLevelConfig.GetRootAsPinballLevelConfig(configBuffer));
				}
			}
			ConfigPinballLevelConfigById.LogPair.Clear();
			ConfigPinballLevelConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballLevelConfigById.HandleId, 1, p0Id, ConfigPinballLevelConfigById.LogPair) || ConfigCommon.Step(ConfigPinballLevelConfigById.HandleId, true, ConfigPinballLevelConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballLevelConfigById.HandleId, 0, ConfigPinballLevelConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballLevelConfig rootAsPinballLevelConfig = PinballLevelConfig.GetRootAsPinballLevelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballLevelConfigById.HandleId, ConfigPinballLevelConfigById.LogPair);
			return new PinballLevelConfig?(rootAsPinballLevelConfig);
		}

		// Token: 0x040031AA RID: 12714
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031AB RID: 12715
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x040031AC RID: 12716
		private const string TABLE = "PinballLevelConfig";

		// Token: 0x040031AD RID: 12717
		private const string COMMAND = "select BinData from `PinballLevelConfig` where Id=?";

		// Token: 0x040031AE RID: 12718
		private const string KEY_PREFIX = "PinballLevelConfigById";

		// Token: 0x040031AF RID: 12719
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031B0 RID: 12720
		private static int HandleId;
	}
}
