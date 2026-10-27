using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070B RID: 1803
	public class ConfigPinballAvgStyleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A52 RID: 10834 RVA: 0x00148974 File Offset: 0x00146B74
		static ConfigPinballAvgStyleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballAvgStyleConfigById.CreateStaticDefaultValue), new Action(ConfigPinballAvgStyleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00148994 File Offset: 0x00146B94
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballAvgStyleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballAvgStyleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballAvgStyleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballAvgStyleConfig` where Id=?")
			});
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00148A13 File Offset: 0x00146C13
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballAvgStyleConfigById.LogPair = null;
			ConfigPinballAvgStyleConfigById.HandleId = 0;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00148A21 File Offset: 0x00146C21
		public static void Init()
		{
			ConfigPinballAvgStyleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballAvgStyleConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballAvgStyleConfig` where Id=?");
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00148A3C File Offset: 0x00146C3C
		public static PinballAvgStyleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballAvgStyleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballAvgStyleConfig?(PinballAvgStyleConfig.GetRootAsPinballAvgStyleConfig(configBuffer));
				}
			}
			ConfigPinballAvgStyleConfigById.LogPair.Clear();
			ConfigPinballAvgStyleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballAvgStyleConfigById.HandleId, 1, p0Id, ConfigPinballAvgStyleConfigById.LogPair) || ConfigCommon.Step(ConfigPinballAvgStyleConfigById.HandleId, true, ConfigPinballAvgStyleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballAvgStyleConfigById.HandleId, 0, ConfigPinballAvgStyleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballAvgStyleConfig rootAsPinballAvgStyleConfig = PinballAvgStyleConfig.GetRootAsPinballAvgStyleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballAvgStyleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair);
			return new PinballAvgStyleConfig?(rootAsPinballAvgStyleConfig);
		}

		// Token: 0x04003133 RID: 12595
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003134 RID: 12596
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x04003135 RID: 12597
		private const string TABLE = "PinballAvgStyleConfig";

		// Token: 0x04003136 RID: 12598
		private const string COMMAND = "select BinData from `PinballAvgStyleConfig` where Id=?";

		// Token: 0x04003137 RID: 12599
		private const string KEY_PREFIX = "PinballAvgStyleConfigById";

		// Token: 0x04003138 RID: 12600
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003139 RID: 12601
		private static int HandleId;
	}
}
