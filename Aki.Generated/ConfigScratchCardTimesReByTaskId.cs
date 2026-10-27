using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FF RID: 2303
	public class ConfigScratchCardTimesReByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600360D RID: 13837 RVA: 0x0018AE04 File Offset: 0x00189004
		static ConfigScratchCardTimesReByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardTimesReByTaskId.CreateStaticDefaultValue), new Action(ConfigScratchCardTimesReByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0018AE24 File Offset: 0x00189024
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

		// Token: 0x0600360F RID: 13839 RVA: 0x0018AEA3 File Offset: 0x001890A3
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardTimesReByTaskId.LogPair = null;
			ConfigScratchCardTimesReByTaskId.HandleId = 0;
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0018AEB1 File Offset: 0x001890B1
		public static void Init()
		{
			ConfigScratchCardTimesReByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardTimesReByTaskId.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardTimesRe` where TaskId=?");
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x0018AECC File Offset: 0x001890CC
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

		// Token: 0x04003EDF RID: 16095
		private const string DB = "db_scratchcard.db";

		// Token: 0x04003EE0 RID: 16096
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x04003EE1 RID: 16097
		private const string TABLE = "ScratchCardTimesRe";

		// Token: 0x04003EE2 RID: 16098
		private const string COMMAND = "select BinData from `ScratchCardTimesRe` where TaskId=?";

		// Token: 0x04003EE3 RID: 16099
		private const string KEY_PREFIX = "ScratchCardTimesReByTaskId";

		// Token: 0x04003EE4 RID: 16100
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EE5 RID: 16101
		private static int HandleId;
	}
}
