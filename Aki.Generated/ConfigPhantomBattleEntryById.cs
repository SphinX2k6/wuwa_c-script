using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068D RID: 1677
	public class ConfigPhantomBattleEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600275E RID: 10078 RVA: 0x0013BCCC File Offset: 0x00139ECC
		static ConfigPhantomBattleEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleEntryById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x0013BCEC File Offset: 0x00139EEC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleEntry` where Id=?")
			});
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0013BD6B File Offset: 0x00139F6B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleEntryById.LogPair = null;
			ConfigPhantomBattleEntryById.HandleId = 0;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0013BD79 File Offset: 0x00139F79
		public static void Init()
		{
			ConfigPhantomBattleEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleEntryById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleEntry` where Id=?");
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0013BD94 File Offset: 0x00139F94
		public static PhantomBattleEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleEntry?(PhantomBattleEntry.GetRootAsPhantomBattleEntry(configBuffer));
				}
			}
			ConfigPhantomBattleEntryById.LogPair.Clear();
			ConfigPhantomBattleEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleEntryById.HandleId, 1, p0Id, ConfigPhantomBattleEntryById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleEntryById.HandleId, true, ConfigPhantomBattleEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleEntryById.HandleId, 0, ConfigPhantomBattleEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleEntry rootAsPhantomBattleEntry = PhantomBattleEntry.GetRootAsPhantomBattleEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair);
			return new PhantomBattleEntry?(rootAsPhantomBattleEntry);
		}

		// Token: 0x04002DC1 RID: 11713
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DC2 RID: 11714
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002DC3 RID: 11715
		private const string TABLE = "PhantomBattleEntry";

		// Token: 0x04002DC4 RID: 11716
		private const string COMMAND = "select BinData from `PhantomBattleEntry` where Id=?";

		// Token: 0x04002DC5 RID: 11717
		private const string KEY_PREFIX = "PhantomBattleEntryById";

		// Token: 0x04002DC6 RID: 11718
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DC7 RID: 11719
		private static int HandleId;
	}
}
