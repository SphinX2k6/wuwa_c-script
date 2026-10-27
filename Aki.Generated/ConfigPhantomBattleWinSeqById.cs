using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068A RID: 1674
	public class ConfigPhantomBattleWinSeqById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600274C RID: 10060 RVA: 0x00137E74 File Offset: 0x00136074
		static ConfigPhantomBattleWinSeqById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleWinSeqById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleWinSeqById.ResetStaticDefaultValue));
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00137E94 File Offset: 0x00136094
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleWinSeqById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleWinSeqById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleWinSeq"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleWinSeq` where Id=?")
			});
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00137F13 File Offset: 0x00136113
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleWinSeqById.LogPair = null;
			ConfigPhantomBattleWinSeqById.HandleId = 0;
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00137F21 File Offset: 0x00136121
		public static void Init()
		{
			ConfigPhantomBattleWinSeqById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleWinSeqById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleWinSeq` where Id=?");
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00137F3C File Offset: 0x0013613C
		public static PhantomBattleWinSeq? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleWinSeqById.HandleId, ConfigPhantomBattleWinSeqById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleWinSeqById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleWinSeq?(PhantomBattleWinSeq.GetRootAsPhantomBattleWinSeq(configBuffer));
				}
			}
			ConfigPhantomBattleWinSeqById.LogPair.Clear();
			ConfigPhantomBattleWinSeqById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleWinSeqById.HandleId, 1, p0Id, ConfigPhantomBattleWinSeqById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleWinSeqById.HandleId, true, ConfigPhantomBattleWinSeqById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleWinSeqById.HandleId, ConfigPhantomBattleWinSeqById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleWinSeqById.HandleId, 0, ConfigPhantomBattleWinSeqById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleWinSeqById.HandleId, ConfigPhantomBattleWinSeqById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleWinSeq rootAsPhantomBattleWinSeq = PhantomBattleWinSeq.GetRootAsPhantomBattleWinSeq(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleWinSeqById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleWinSeqById.HandleId, ConfigPhantomBattleWinSeqById.LogPair);
			return new PhantomBattleWinSeq?(rootAsPhantomBattleWinSeq);
		}

		// Token: 0x04002DAC RID: 11692
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DAD RID: 11693
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DAE RID: 11694
		private const string TABLE = "PhantomBattleWinSeq";

		// Token: 0x04002DAF RID: 11695
		private const string COMMAND = "select BinData from `PhantomBattleWinSeq` where Id=?";

		// Token: 0x04002DB0 RID: 11696
		private const string KEY_PREFIX = "PhantomBattleWinSeqById";

		// Token: 0x04002DB1 RID: 11697
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DB2 RID: 11698
		private static int HandleId;
	}
}
