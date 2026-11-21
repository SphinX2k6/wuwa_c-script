using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F7 RID: 2295
	public class ConfigRoleTowerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035DD RID: 13789 RVA: 0x0018D313 File Offset: 0x0018B513
		static ConfigRoleTowerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerLevelById.CreateStaticDefaultValue), new Action(ConfigRoleTowerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0018D334 File Offset: 0x0018B534
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerLevel` where Id=?")
			});
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0018D3B3 File Offset: 0x0018B5B3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerLevelById.LogPair = null;
			ConfigRoleTowerLevelById.HandleId = 0;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0018D3C1 File Offset: 0x0018B5C1
		public static void Init()
		{
			ConfigRoleTowerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerLevelById.HandleId, "db_roletower.db", "select BinData from `RoleTowerLevel` where Id=?");
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0018D3DC File Offset: 0x0018B5DC
		public static RoleTowerLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerLevelById.HandleId, ConfigRoleTowerLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerLevel?(RoleTowerLevel.GetRootAsRoleTowerLevel(configBuffer));
				}
			}
			ConfigRoleTowerLevelById.LogPair.Clear();
			ConfigRoleTowerLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerLevelById.HandleId, 1, p0Id, ConfigRoleTowerLevelById.LogPair) || ConfigCommon.Step(ConfigRoleTowerLevelById.HandleId, true, ConfigRoleTowerLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerLevelById.HandleId, ConfigRoleTowerLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerLevelById.HandleId, 0, ConfigRoleTowerLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerLevelById.HandleId, ConfigRoleTowerLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerLevel rootAsRoleTowerLevel = RoleTowerLevel.GetRootAsRoleTowerLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerLevelById.HandleId, ConfigRoleTowerLevelById.LogPair);
			return new RoleTowerLevel?(rootAsRoleTowerLevel);
		}

		// Token: 0x04003EA7 RID: 16039
		private const string DB = "db_roletower.db";

		// Token: 0x04003EA8 RID: 16040
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003EA9 RID: 16041
		private const string TABLE = "RoleTowerLevel";

		// Token: 0x04003EAA RID: 16042
		private const string COMMAND = "select BinData from `RoleTowerLevel` where Id=?";

		// Token: 0x04003EAB RID: 16043
		private const string KEY_PREFIX = "RoleTowerLevelById";

		// Token: 0x04003EAC RID: 16044
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EAD RID: 16045
		private static int HandleId;
	}
}
