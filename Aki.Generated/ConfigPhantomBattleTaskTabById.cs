using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000687 RID: 1671
	public class ConfigPhantomBattleTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600273A RID: 10042 RVA: 0x00137850 File Offset: 0x00135A50
		static ConfigPhantomBattleTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleTaskTabById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00137870 File Offset: 0x00135A70
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

		// Token: 0x0600273C RID: 10044 RVA: 0x001378EF File Offset: 0x00135AEF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleTaskTabById.LogPair = null;
			ConfigPhantomBattleTaskTabById.HandleId = 0;
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x001378FD File Offset: 0x00135AFD
		public static void Init()
		{
			ConfigPhantomBattleTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleTaskTabById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleTaskTab` where Id=?");
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00137918 File Offset: 0x00135B18
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

		// Token: 0x04002D97 RID: 11671
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D98 RID: 11672
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D99 RID: 11673
		private const string TABLE = "PhantomBattleTaskTab";

		// Token: 0x04002D9A RID: 11674
		private const string COMMAND = "select BinData from `PhantomBattleTaskTab` where Id=?";

		// Token: 0x04002D9B RID: 11675
		private const string KEY_PREFIX = "PhantomBattleTaskTabById";

		// Token: 0x04002D9C RID: 11676
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D9D RID: 11677
		private static int HandleId;
	}
}
