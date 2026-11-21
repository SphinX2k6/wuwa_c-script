using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069F RID: 1695
	public class ConfigPhantomBattleTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027CA RID: 10186 RVA: 0x0013E2CC File Offset: 0x0013C4CC
		static ConfigPhantomBattleTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleTaskTabById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x0013E2EC File Offset: 0x0013C4EC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleTaskTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleTaskTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleTaskTab` where Id=?")
			});
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0013E36B File Offset: 0x0013C56B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleTaskTabById.LogPair = null;
			ConfigPhantomBattleTaskTabById.HandleId = 0;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0013E379 File Offset: 0x0013C579
		public static void Init()
		{
			ConfigPhantomBattleTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleTaskTabById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleTaskTab` where Id=?");
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0013E394 File Offset: 0x0013C594
		public static PhantomBattleTaskTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleTaskTabById.HandleId, ConfigPhantomBattleTaskTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleTaskTab?(PhantomBattleTaskTab.GetRootAsPhantomBattleTaskTab(configBuffer));
				}
			}
			ConfigPhantomBattleTaskTabById.LogPair.Clear();
			ConfigPhantomBattleTaskTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleTaskTabById.HandleId, 1, p0Id, ConfigPhantomBattleTaskTabById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleTaskTabById.HandleId, true, ConfigPhantomBattleTaskTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleTaskTabById.HandleId, ConfigPhantomBattleTaskTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleTaskTabById.HandleId, 0, ConfigPhantomBattleTaskTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleTaskTabById.HandleId, ConfigPhantomBattleTaskTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleTaskTab rootAsPhantomBattleTaskTab = PhantomBattleTaskTab.GetRootAsPhantomBattleTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleTaskTabById.HandleId, ConfigPhantomBattleTaskTabById.LogPair);
			return new PhantomBattleTaskTab?(rootAsPhantomBattleTaskTab);
		}

		// Token: 0x04002E3F RID: 11839
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E40 RID: 11840
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E41 RID: 11841
		private const string TABLE = "PhantomBattleTaskTab";

		// Token: 0x04002E42 RID: 11842
		private const string COMMAND = "select BinData from `PhantomBattleTaskTab` where Id=?";

		// Token: 0x04002E43 RID: 11843
		private const string KEY_PREFIX = "PhantomBattleTaskTabById";

		// Token: 0x04002E44 RID: 11844
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E45 RID: 11845
		private static int HandleId;
	}
}
