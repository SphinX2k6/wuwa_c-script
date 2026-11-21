using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F6 RID: 2294
	public class ConfigRoleTowerLevelByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035D7 RID: 13783 RVA: 0x0018D0DB File Offset: 0x0018B2DB
		static ConfigRoleTowerLevelByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerLevelByGroupId.CreateStaticDefaultValue), new Action(ConfigRoleTowerLevelByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0018D0FC File Offset: 0x0018B2FC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerLevelByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerLevelByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerLevel` where GroupId=?")
			});
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x0018D17B File Offset: 0x0018B37B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerLevelByGroupId.LogPair = null;
			ConfigRoleTowerLevelByGroupId.HandleId = 0;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x0018D189 File Offset: 0x0018B389
		public static void Init()
		{
			ConfigRoleTowerLevelByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerLevelByGroupId.HandleId, "db_roletower.db", "select BinData from `RoleTowerLevel` where GroupId=?");
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0018D1A4 File Offset: 0x0018B3A4
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerLevel> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerLevelByGroupId.HandleId, ConfigRoleTowerLevelByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<RoleTowerLevel> readOnlyList = (IReadOnlyList<RoleTowerLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerLevelByGroupId.LogPair.Clear();
			ConfigRoleTowerLevelByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerLevelByGroupId.HandleId, 1, p0GroupId, ConfigRoleTowerLevelByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerLevelByGroupId.HandleId, ConfigRoleTowerLevelByGroupId.LogPair);
				return null;
			}
			List<RoleTowerLevel> list = new List<RoleTowerLevel>();
			while (ConfigCommon.Step(ConfigRoleTowerLevelByGroupId.HandleId, false, ConfigRoleTowerLevelByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerLevelByGroupId.HandleId, 0, ConfigRoleTowerLevelByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerLevelByGroupId.HandleId, ConfigRoleTowerLevelByGroupId.LogPair);
					return null;
				}
				RoleTowerLevel rootAsRoleTowerLevel = RoleTowerLevel.GetRootAsRoleTowerLevel(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerLevelByGroupId.HandleId, ConfigRoleTowerLevelByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003EA0 RID: 16032
		private const string DB = "db_roletower.db";

		// Token: 0x04003EA1 RID: 16033
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003EA2 RID: 16034
		private const string TABLE = "RoleTowerLevel";

		// Token: 0x04003EA3 RID: 16035
		private const string COMMAND = "select BinData from `RoleTowerLevel` where GroupId=?";

		// Token: 0x04003EA4 RID: 16036
		private const string KEY_PREFIX = "RoleTowerLevelByGroupId";

		// Token: 0x04003EA5 RID: 16037
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EA6 RID: 16038
		private static int HandleId;
	}
}
