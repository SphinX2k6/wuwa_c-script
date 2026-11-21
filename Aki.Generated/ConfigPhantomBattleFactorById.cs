using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068F RID: 1679
	public class ConfigPhantomBattleFactorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600276A RID: 10090 RVA: 0x0013C0A7 File Offset: 0x0013A2A7
		static ConfigPhantomBattleFactorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleFactorById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleFactorById.ResetStaticDefaultValue));
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0013C0C8 File Offset: 0x0013A2C8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleFactorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleFactorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleFactor"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleFactor` where Id=?")
			});
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0013C147 File Offset: 0x0013A347
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleFactorById.LogPair = null;
			ConfigPhantomBattleFactorById.HandleId = 0;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0013C155 File Offset: 0x0013A355
		public static void Init()
		{
			ConfigPhantomBattleFactorById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleFactorById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleFactor` where Id=?");
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0013C170 File Offset: 0x0013A370
		public static PhantomBattleFactor? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleFactorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleFactor?(PhantomBattleFactor.GetRootAsPhantomBattleFactor(configBuffer));
				}
			}
			ConfigPhantomBattleFactorById.LogPair.Clear();
			ConfigPhantomBattleFactorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleFactorById.HandleId, 1, p0Id, ConfigPhantomBattleFactorById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleFactorById.HandleId, true, ConfigPhantomBattleFactorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleFactorById.HandleId, 0, ConfigPhantomBattleFactorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleFactor rootAsPhantomBattleFactor = PhantomBattleFactor.GetRootAsPhantomBattleFactor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleFactorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair);
			return new PhantomBattleFactor?(rootAsPhantomBattleFactor);
		}

		// Token: 0x04002DCF RID: 11727
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DD0 RID: 11728
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002DD1 RID: 11729
		private const string TABLE = "PhantomBattleFactor";

		// Token: 0x04002DD2 RID: 11730
		private const string COMMAND = "select BinData from `PhantomBattleFactor` where Id=?";

		// Token: 0x04002DD3 RID: 11731
		private const string KEY_PREFIX = "PhantomBattleFactorById";

		// Token: 0x04002DD4 RID: 11732
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DD5 RID: 11733
		private static int HandleId;
	}
}
