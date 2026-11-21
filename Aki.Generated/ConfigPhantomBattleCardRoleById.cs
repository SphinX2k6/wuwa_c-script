using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000683 RID: 1667
	public class ConfigPhantomBattleCardRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002722 RID: 10018 RVA: 0x0013A697 File Offset: 0x00138897
		static ConfigPhantomBattleCardRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRoleById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x0013A6B8 File Offset: 0x001388B8
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

		// Token: 0x06002724 RID: 10020 RVA: 0x0013A737 File Offset: 0x00138937
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleById.LogPair = null;
			ConfigPhantomBattleCardRoleById.HandleId = 0;
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x0013A745 File Offset: 0x00138945
		public static void Init()
		{
			ConfigPhantomBattleCardRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRoleById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardRole` where Id=?");
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x0013A760 File Offset: 0x00138960
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

		// Token: 0x04002D7B RID: 11643
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D7C RID: 11644
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D7D RID: 11645
		private const string TABLE = "PhantomBattleCardRole";

		// Token: 0x04002D7E RID: 11646
		private const string COMMAND = "select BinData from `PhantomBattleCardRole` where Id=?";

		// Token: 0x04002D7F RID: 11647
		private const string KEY_PREFIX = "PhantomBattleCardRoleById";

		// Token: 0x04002D80 RID: 11648
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D81 RID: 11649
		private static int HandleId;
	}
}
