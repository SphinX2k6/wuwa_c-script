using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000715 RID: 1813
	public class ConfigPinballDailyConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A8E RID: 10894 RVA: 0x00149E27 File Offset: 0x00148027
		static ConfigPinballDailyConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDailyConfigById.CreateStaticDefaultValue), new Action(ConfigPinballDailyConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00149E48 File Offset: 0x00148048
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballDailyConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballDailyConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballDailyConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballDailyConfig` where Id=?")
			});
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00149EC7 File Offset: 0x001480C7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDailyConfigById.LogPair = null;
			ConfigPinballDailyConfigById.HandleId = 0;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x00149ED5 File Offset: 0x001480D5
		public static void Init()
		{
			ConfigPinballDailyConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDailyConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballDailyConfig` where Id=?");
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00149EF0 File Offset: 0x001480F0
		public static PinballDailyConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballDailyConfigById.HandleId, ConfigPinballDailyConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballDailyConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballDailyConfig?(PinballDailyConfig.GetRootAsPinballDailyConfig(configBuffer));
				}
			}
			ConfigPinballDailyConfigById.LogPair.Clear();
			ConfigPinballDailyConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballDailyConfigById.HandleId, 1, p0Id, ConfigPinballDailyConfigById.LogPair) || ConfigCommon.Step(ConfigPinballDailyConfigById.HandleId, true, ConfigPinballDailyConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballDailyConfigById.HandleId, ConfigPinballDailyConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballDailyConfigById.HandleId, 0, ConfigPinballDailyConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballDailyConfigById.HandleId, ConfigPinballDailyConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballDailyConfig rootAsPinballDailyConfig = PinballDailyConfig.GetRootAsPinballDailyConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballDailyConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballDailyConfigById.HandleId, ConfigPinballDailyConfigById.LogPair);
			return new PinballDailyConfig?(rootAsPinballDailyConfig);
		}

		// Token: 0x04003179 RID: 12665
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400317A RID: 12666
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x0400317B RID: 12667
		private const string TABLE = "PinballDailyConfig";

		// Token: 0x0400317C RID: 12668
		private const string COMMAND = "select BinData from `PinballDailyConfig` where Id=?";

		// Token: 0x0400317D RID: 12669
		private const string KEY_PREFIX = "PinballDailyConfigById";

		// Token: 0x0400317E RID: 12670
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400317F RID: 12671
		private static int HandleId;
	}
}
