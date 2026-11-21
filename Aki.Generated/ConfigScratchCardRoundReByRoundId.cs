using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000949 RID: 2377
	public class ConfigScratchCardRoundReByRoundId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037C9 RID: 14281 RVA: 0x00197DDB File Offset: 0x00195FDB
		static ConfigScratchCardRoundReByRoundId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardRoundReByRoundId.CreateStaticDefaultValue), new Action(ConfigScratchCardRoundReByRoundId.ResetStaticDefaultValue));
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00197DFC File Offset: 0x00195FFC
		public static void CreateStaticDefaultValue()
		{
			ConfigScratchCardRoundReByRoundId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigScratchCardRoundReByRoundId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_scratchcard.db"),
				new ValueTuple<string, object>("文件", "g.刮刮乐.xlsx"),
				new ValueTuple<string, object>("表名", "ScratchCardRoundRe"),
				new ValueTuple<string, object>("语句", "select BinData from `ScratchCardRoundRe` where RoundId=?")
			});
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00197E7B File Offset: 0x0019607B
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardRoundReByRoundId.LogPair = null;
			ConfigScratchCardRoundReByRoundId.HandleId = 0;
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00197E89 File Offset: 0x00196089
		public static void Init()
		{
			ConfigScratchCardRoundReByRoundId.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardRoundReByRoundId.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardRoundRe` where RoundId=?");
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00197EA4 File Offset: 0x001960A4
		public static ScratchCardRoundRe? GetConfig(int p0RoundId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRoundReByRoundId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ScratchCardRoundRe?(ScratchCardRoundRe.GetRootAsScratchCardRoundRe(configBuffer));
				}
			}
			ConfigScratchCardRoundReByRoundId.LogPair.Clear();
			ConfigScratchCardRoundReByRoundId.LogPair.Add(new ValueTuple<string, object>("RoundId", p0RoundId));
			if (!ConfigCommon.BindInt(ConfigScratchCardRoundReByRoundId.HandleId, 1, p0RoundId, ConfigScratchCardRoundReByRoundId.LogPair) || ConfigCommon.Step(ConfigScratchCardRoundReByRoundId.HandleId, true, ConfigScratchCardRoundReByRoundId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigScratchCardRoundReByRoundId.HandleId, 0, ConfigScratchCardRoundReByRoundId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ScratchCardRoundRe rootAsScratchCardRoundRe = ScratchCardRoundRe.GetRootAsScratchCardRoundRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRoundReByRoundId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigScratchCardRoundReByRoundId.HandleId, ConfigScratchCardRoundReByRoundId.LogPair);
			return new ScratchCardRoundRe?(rootAsScratchCardRoundRe);
		}

		// Token: 0x040040E5 RID: 16613
		private const string DB = "db_scratchcard.db";

		// Token: 0x040040E6 RID: 16614
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x040040E7 RID: 16615
		private const string TABLE = "ScratchCardRoundRe";

		// Token: 0x040040E8 RID: 16616
		private const string COMMAND = "select BinData from `ScratchCardRoundRe` where RoundId=?";

		// Token: 0x040040E9 RID: 16617
		private const string KEY_PREFIX = "ScratchCardRoundReByRoundId";

		// Token: 0x040040EA RID: 16618
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040EB RID: 16619
		private static int HandleId;
	}
}
