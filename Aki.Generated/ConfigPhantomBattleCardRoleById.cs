using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066B RID: 1643
	public class ConfigPhantomBattleCardRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002692 RID: 9874 RVA: 0x00133C1B File Offset: 0x00131E1B
		static ConfigPhantomBattleCardRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRoleById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00133C3C File Offset: 0x00131E3C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardRole"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardRole` where Id=?")
			});
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00133CBB File Offset: 0x00131EBB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleById.LogPair = null;
			ConfigPhantomBattleCardRoleById.HandleId = 0;
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00133CC9 File Offset: 0x00131EC9
		public static void Init()
		{
			ConfigPhantomBattleCardRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRoleById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardRole` where Id=?");
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00133CE4 File Offset: 0x00131EE4
		public static PhantomBattleCardRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardRoleById.HandleId, ConfigPhantomBattleCardRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardRole?(PhantomBattleCardRole.GetRootAsPhantomBattleCardRole(configBuffer));
				}
			}
			ConfigPhantomBattleCardRoleById.LogPair.Clear();
			ConfigPhantomBattleCardRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardRoleById.HandleId, 1, p0Id, ConfigPhantomBattleCardRoleById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardRoleById.HandleId, true, ConfigPhantomBattleCardRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardRoleById.HandleId, ConfigPhantomBattleCardRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardRoleById.HandleId, 0, ConfigPhantomBattleCardRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardRoleById.HandleId, ConfigPhantomBattleCardRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardRole rootAsPhantomBattleCardRole = PhantomBattleCardRole.GetRootAsPhantomBattleCardRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardRoleById.HandleId, ConfigPhantomBattleCardRoleById.LogPair);
			return new PhantomBattleCardRole?(rootAsPhantomBattleCardRole);
		}

		// Token: 0x04002CD3 RID: 11475
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CD4 RID: 11476
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CD5 RID: 11477
		private const string TABLE = "PhantomBattleCardRole";

		// Token: 0x04002CD6 RID: 11478
		private const string COMMAND = "select BinData from `PhantomBattleCardRole` where Id=?";

		// Token: 0x04002CD7 RID: 11479
		private const string KEY_PREFIX = "PhantomBattleCardRoleById";

		// Token: 0x04002CD8 RID: 11480
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CD9 RID: 11481
		private static int HandleId;
	}
}
