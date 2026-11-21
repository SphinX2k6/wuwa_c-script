using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000697 RID: 1687
	public class ConfigPhantomBattleMasterLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600279A RID: 10138 RVA: 0x0013D15F File Offset: 0x0013B35F
		static ConfigPhantomBattleMasterLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterLevelById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0013D180 File Offset: 0x0013B380
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMasterLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMasterLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMasterLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMasterLevel` where Id=?")
			});
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x0013D1FF File Offset: 0x0013B3FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterLevelById.LogPair = null;
			ConfigPhantomBattleMasterLevelById.HandleId = 0;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x0013D20D File Offset: 0x0013B40D
		public static void Init()
		{
			ConfigPhantomBattleMasterLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterLevelById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterLevel` where Id=?");
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x0013D228 File Offset: 0x0013B428
		public static PhantomBattleMasterLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMasterLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleMasterLevel?(PhantomBattleMasterLevel.GetRootAsPhantomBattleMasterLevel(configBuffer));
				}
			}
			ConfigPhantomBattleMasterLevelById.LogPair.Clear();
			ConfigPhantomBattleMasterLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleMasterLevelById.HandleId, 1, p0Id, ConfigPhantomBattleMasterLevelById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleMasterLevelById.HandleId, true, ConfigPhantomBattleMasterLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMasterLevelById.HandleId, 0, ConfigPhantomBattleMasterLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleMasterLevel rootAsPhantomBattleMasterLevel = PhantomBattleMasterLevel.GetRootAsPhantomBattleMasterLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMasterLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair);
			return new PhantomBattleMasterLevel?(rootAsPhantomBattleMasterLevel);
		}

		// Token: 0x04002E07 RID: 11783
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E08 RID: 11784
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E09 RID: 11785
		private const string TABLE = "PhantomBattleMasterLevel";

		// Token: 0x04002E0A RID: 11786
		private const string COMMAND = "select BinData from `PhantomBattleMasterLevel` where Id=?";

		// Token: 0x04002E0B RID: 11787
		private const string KEY_PREFIX = "PhantomBattleMasterLevelById";

		// Token: 0x04002E0C RID: 11788
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E0D RID: 11789
		private static int HandleId;
	}
}
