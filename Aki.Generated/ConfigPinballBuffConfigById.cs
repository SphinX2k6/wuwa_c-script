using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070E RID: 1806
	public class ConfigPinballBuffConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A64 RID: 10852 RVA: 0x00148F97 File Offset: 0x00147197
		static ConfigPinballBuffConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballBuffConfigById.CreateStaticDefaultValue), new Action(ConfigPinballBuffConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00148FB8 File Offset: 0x001471B8
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

		// Token: 0x06002A66 RID: 10854 RVA: 0x00149037 File Offset: 0x00147237
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballBuffConfigById.LogPair = null;
			ConfigPinballBuffConfigById.HandleId = 0;
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00149045 File Offset: 0x00147245
		public static void Init()
		{
			ConfigPinballBuffConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballBuffConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballBuffConfig` where BuffId=?");
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00149060 File Offset: 0x00147260
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

		// Token: 0x04003148 RID: 12616
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003149 RID: 12617
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x0400314A RID: 12618
		private const string TABLE = "PinballBuffConfig";

		// Token: 0x0400314B RID: 12619
		private const string COMMAND = "select BinData from `PinballBuffConfig` where BuffId=?";

		// Token: 0x0400314C RID: 12620
		private const string KEY_PREFIX = "PinballBuffConfigById";

		// Token: 0x0400314D RID: 12621
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400314E RID: 12622
		private static int HandleId;
	}
}
