using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000727 RID: 1831
	public class ConfigPinballChapterConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x0014FC5C File Offset: 0x0014DE5C
		static ConfigPinballChapterConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballChapterConfigById.CreateStaticDefaultValue), new Action(ConfigPinballChapterConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x0014FC7C File Offset: 0x0014DE7C
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

		// Token: 0x06002AFC RID: 11004 RVA: 0x0014FCFB File Offset: 0x0014DEFB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballChapterConfigById.LogPair = null;
			ConfigPinballChapterConfigById.HandleId = 0;
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0014FD09 File Offset: 0x0014DF09
		public static void Init()
		{
			ConfigPinballChapterConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballChapterConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballChapterConfig` where Id=?");
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x0014FD24 File Offset: 0x0014DF24
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

		// Token: 0x040031F7 RID: 12791
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031F8 RID: 12792
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x040031F9 RID: 12793
		private const string TABLE = "PinballChapterConfig";

		// Token: 0x040031FA RID: 12794
		private const string COMMAND = "select BinData from `PinballChapterConfig` where Id=?";

		// Token: 0x040031FB RID: 12795
		private const string KEY_PREFIX = "PinballChapterConfigById";

		// Token: 0x040031FC RID: 12796
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031FD RID: 12797
		private static int HandleId;
	}
}
