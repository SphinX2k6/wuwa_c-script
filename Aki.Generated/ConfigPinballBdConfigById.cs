using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070C RID: 1804
	public class ConfigPinballBdConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A58 RID: 10840 RVA: 0x00148BBC File Offset: 0x00146DBC
		static ConfigPinballBdConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballBdConfigById.CreateStaticDefaultValue), new Action(ConfigPinballBdConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00148BDC File Offset: 0x00146DDC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballBdConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballBdConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballBdConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballBdConfig` where Id=?")
			});
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00148C5B File Offset: 0x00146E5B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballBdConfigById.LogPair = null;
			ConfigPinballBdConfigById.HandleId = 0;
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00148C69 File Offset: 0x00146E69
		public static void Init()
		{
			ConfigPinballBdConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballBdConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballBdConfig` where Id=?");
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00148C84 File Offset: 0x00146E84
		public static PinballBdConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballBdConfigById.HandleId, ConfigPinballBdConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballBdConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballBdConfig?(PinballBdConfig.GetRootAsPinballBdConfig(configBuffer));
				}
			}
			ConfigPinballBdConfigById.LogPair.Clear();
			ConfigPinballBdConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballBdConfigById.HandleId, 1, p0Id, ConfigPinballBdConfigById.LogPair) || ConfigCommon.Step(ConfigPinballBdConfigById.HandleId, true, ConfigPinballBdConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballBdConfigById.HandleId, ConfigPinballBdConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballBdConfigById.HandleId, 0, ConfigPinballBdConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballBdConfigById.HandleId, ConfigPinballBdConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballBdConfig rootAsPinballBdConfig = PinballBdConfig.GetRootAsPinballBdConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballBdConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballBdConfigById.HandleId, ConfigPinballBdConfigById.LogPair);
			return new PinballBdConfig?(rootAsPinballBdConfig);
		}

		// Token: 0x0400313A RID: 12602
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400313B RID: 12603
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x0400313C RID: 12604
		private const string TABLE = "PinballBdConfig";

		// Token: 0x0400313D RID: 12605
		private const string COMMAND = "select BinData from `PinballBdConfig` where Id=?";

		// Token: 0x0400313E RID: 12606
		private const string KEY_PREFIX = "PinballBdConfigById";

		// Token: 0x0400313F RID: 12607
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003140 RID: 12608
		private static int HandleId;
	}
}
