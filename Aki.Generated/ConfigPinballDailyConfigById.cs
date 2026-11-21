using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072D RID: 1837
	public class ConfigPinballDailyConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B1E RID: 11038 RVA: 0x001508A3 File Offset: 0x0014EAA3
		static ConfigPinballDailyConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDailyConfigById.CreateStaticDefaultValue), new Action(ConfigPinballDailyConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x001508C4 File Offset: 0x0014EAC4
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

		// Token: 0x06002B20 RID: 11040 RVA: 0x00150943 File Offset: 0x0014EB43
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDailyConfigById.LogPair = null;
			ConfigPinballDailyConfigById.HandleId = 0;
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00150951 File Offset: 0x0014EB51
		public static void Init()
		{
			ConfigPinballDailyConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDailyConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballDailyConfig` where Id=?");
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0015096C File Offset: 0x0014EB6C
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

		// Token: 0x04003221 RID: 12833
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003222 RID: 12834
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x04003223 RID: 12835
		private const string TABLE = "PinballDailyConfig";

		// Token: 0x04003224 RID: 12836
		private const string COMMAND = "select BinData from `PinballDailyConfig` where Id=?";

		// Token: 0x04003225 RID: 12837
		private const string KEY_PREFIX = "PinballDailyConfigById";

		// Token: 0x04003226 RID: 12838
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003227 RID: 12839
		private static int HandleId;
	}
}
