using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A2 RID: 1698
	public class ConfigPhantomBattleWinSeqById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027DC RID: 10204 RVA: 0x0013E8F0 File Offset: 0x0013CAF0
		static ConfigPhantomBattleWinSeqById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleWinSeqById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleWinSeqById.ResetStaticDefaultValue));
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x0013E910 File Offset: 0x0013CB10
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

		// Token: 0x060027DE RID: 10206 RVA: 0x0013E98F File Offset: 0x0013CB8F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleWinSeqById.LogPair = null;
			ConfigPhantomBattleWinSeqById.HandleId = 0;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0013E99D File Offset: 0x0013CB9D
		public static void Init()
		{
			ConfigPhantomBattleWinSeqById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleWinSeqById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleWinSeq` where Id=?");
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0013E9B8 File Offset: 0x0013CBB8
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

		// Token: 0x04002E54 RID: 11860
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E55 RID: 11861
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E56 RID: 11862
		private const string TABLE = "PhantomBattleWinSeq";

		// Token: 0x04002E57 RID: 11863
		private const string COMMAND = "select BinData from `PhantomBattleWinSeq` where Id=?";

		// Token: 0x04002E58 RID: 11864
		private const string KEY_PREFIX = "PhantomBattleWinSeqById";

		// Token: 0x04002E59 RID: 11865
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E5A RID: 11866
		private static int HandleId;
	}
}
