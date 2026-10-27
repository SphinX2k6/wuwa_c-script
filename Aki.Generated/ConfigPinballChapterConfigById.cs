using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070F RID: 1807
	public class ConfigPinballChapterConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A6A RID: 10858 RVA: 0x001491E0 File Offset: 0x001473E0
		static ConfigPinballChapterConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballChapterConfigById.CreateStaticDefaultValue), new Action(ConfigPinballChapterConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00149200 File Offset: 0x00147400
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballChapterConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballChapterConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballChapterConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballChapterConfig` where Id=?")
			});
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x0014927F File Offset: 0x0014747F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballChapterConfigById.LogPair = null;
			ConfigPinballChapterConfigById.HandleId = 0;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0014928D File Offset: 0x0014748D
		public static void Init()
		{
			ConfigPinballChapterConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballChapterConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballChapterConfig` where Id=?");
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x001492A8 File Offset: 0x001474A8
		public static PinballChapterConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballChapterConfigById.HandleId, ConfigPinballChapterConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballChapterConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballChapterConfig?(PinballChapterConfig.GetRootAsPinballChapterConfig(configBuffer));
				}
			}
			ConfigPinballChapterConfigById.LogPair.Clear();
			ConfigPinballChapterConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballChapterConfigById.HandleId, 1, p0Id, ConfigPinballChapterConfigById.LogPair) || ConfigCommon.Step(ConfigPinballChapterConfigById.HandleId, true, ConfigPinballChapterConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballChapterConfigById.HandleId, ConfigPinballChapterConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballChapterConfigById.HandleId, 0, ConfigPinballChapterConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballChapterConfigById.HandleId, ConfigPinballChapterConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballChapterConfig rootAsPinballChapterConfig = PinballChapterConfig.GetRootAsPinballChapterConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballChapterConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballChapterConfigById.HandleId, ConfigPinballChapterConfigById.LogPair);
			return new PinballChapterConfig?(rootAsPinballChapterConfig);
		}

		// Token: 0x0400314F RID: 12623
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003150 RID: 12624
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x04003151 RID: 12625
		private const string TABLE = "PinballChapterConfig";

		// Token: 0x04003152 RID: 12626
		private const string COMMAND = "select BinData from `PinballChapterConfig` where Id=?";

		// Token: 0x04003153 RID: 12627
		private const string KEY_PREFIX = "PinballChapterConfigById";

		// Token: 0x04003154 RID: 12628
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003155 RID: 12629
		private static int HandleId;
	}
}
