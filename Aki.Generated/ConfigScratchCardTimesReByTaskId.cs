using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094A RID: 2378
	public class ConfigScratchCardTimesReByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037CF RID: 14287 RVA: 0x00198024 File Offset: 0x00196224
		static ConfigScratchCardTimesReByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardTimesReByTaskId.CreateStaticDefaultValue), new Action(ConfigScratchCardTimesReByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00198044 File Offset: 0x00196244
		public static void CreateStaticDefaultValue()
		{
			ConfigScratchCardTimesReByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigScratchCardTimesReByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_scratchcard.db"),
				new ValueTuple<string, object>("文件", "g.刮刮乐.xlsx"),
				new ValueTuple<string, object>("表名", "ScratchCardTimesRe"),
				new ValueTuple<string, object>("语句", "select BinData from `ScratchCardTimesRe` where TaskId=?")
			});
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x001980C3 File Offset: 0x001962C3
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardTimesReByTaskId.LogPair = null;
			ConfigScratchCardTimesReByTaskId.HandleId = 0;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x001980D1 File Offset: 0x001962D1
		public static void Init()
		{
			ConfigScratchCardTimesReByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardTimesReByTaskId.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardTimesRe` where TaskId=?");
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x001980EC File Offset: 0x001962EC
		public static ScratchCardTimesRe? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigScratchCardTimesReByTaskId.HandleId, ConfigScratchCardTimesReByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardTimesReByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ScratchCardTimesRe?(ScratchCardTimesRe.GetRootAsScratchCardTimesRe(configBuffer));
				}
			}
			ConfigScratchCardTimesReByTaskId.LogPair.Clear();
			ConfigScratchCardTimesReByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigScratchCardTimesReByTaskId.HandleId, 1, p0TaskId, ConfigScratchCardTimesReByTaskId.LogPair) || ConfigCommon.Step(ConfigScratchCardTimesReByTaskId.HandleId, true, ConfigScratchCardTimesReByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigScratchCardTimesReByTaskId.HandleId, ConfigScratchCardTimesReByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigScratchCardTimesReByTaskId.HandleId, 0, ConfigScratchCardTimesReByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigScratchCardTimesReByTaskId.HandleId, ConfigScratchCardTimesReByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ScratchCardTimesRe rootAsScratchCardTimesRe = ScratchCardTimesRe.GetRootAsScratchCardTimesRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardTimesReByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigScratchCardTimesReByTaskId.HandleId, ConfigScratchCardTimesReByTaskId.LogPair);
			return new ScratchCardTimesRe?(rootAsScratchCardTimesRe);
		}

		// Token: 0x040040EC RID: 16620
		private const string DB = "db_scratchcard.db";

		// Token: 0x040040ED RID: 16621
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x040040EE RID: 16622
		private const string TABLE = "ScratchCardTimesRe";

		// Token: 0x040040EF RID: 16623
		private const string COMMAND = "select BinData from `ScratchCardTimesRe` where TaskId=?";

		// Token: 0x040040F0 RID: 16624
		private const string KEY_PREFIX = "ScratchCardTimesReByTaskId";

		// Token: 0x040040F1 RID: 16625
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040F2 RID: 16626
		private static int HandleId;
	}
}
