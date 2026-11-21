using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090C RID: 2316
	public class ConfigRoleTowerStarByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600365B RID: 13915 RVA: 0x0018FDBF File Offset: 0x0018DFBF
		static ConfigRoleTowerStarByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerStarByGroupId.CreateStaticDefaultValue), new Action(ConfigRoleTowerStarByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x0018FDE0 File Offset: 0x0018DFE0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerStarByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerStarByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerStar"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerStar` where GroupId=?")
			});
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0018FE5F File Offset: 0x0018E05F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerStarByGroupId.LogPair = null;
			ConfigRoleTowerStarByGroupId.HandleId = 0;
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x0018FE6D File Offset: 0x0018E06D
		public static void Init()
		{
			ConfigRoleTowerStarByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerStarByGroupId.HandleId, "db_roletower.db", "select BinData from `RoleTowerStar` where GroupId=?");
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0018FE88 File Offset: 0x0018E088
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerStar> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerStarByGroupId.HandleId, ConfigRoleTowerStarByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStarByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<RoleTowerStar> readOnlyList = (IReadOnlyList<RoleTowerStar>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerStarByGroupId.LogPair.Clear();
			ConfigRoleTowerStarByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerStarByGroupId.HandleId, 1, p0GroupId, ConfigRoleTowerStarByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerStarByGroupId.HandleId, ConfigRoleTowerStarByGroupId.LogPair);
				return null;
			}
			List<RoleTowerStar> list = new List<RoleTowerStar>();
			while (ConfigCommon.Step(ConfigRoleTowerStarByGroupId.HandleId, false, ConfigRoleTowerStarByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerStarByGroupId.HandleId, 0, ConfigRoleTowerStarByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerStarByGroupId.HandleId, ConfigRoleTowerStarByGroupId.LogPair);
					return null;
				}
				RoleTowerStar rootAsRoleTowerStar = RoleTowerStar.GetRootAsRoleTowerStar(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerStar);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStarByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerStarByGroupId.HandleId, ConfigRoleTowerStarByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003F3A RID: 16186
		private const string DB = "db_roletower.db";

		// Token: 0x04003F3B RID: 16187
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003F3C RID: 16188
		private const string TABLE = "RoleTowerStar";

		// Token: 0x04003F3D RID: 16189
		private const string COMMAND = "select BinData from `RoleTowerStar` where GroupId=?";

		// Token: 0x04003F3E RID: 16190
		private const string KEY_PREFIX = "RoleTowerStarByGroupId";

		// Token: 0x04003F3F RID: 16191
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F40 RID: 16192
		private static int HandleId;
	}
}
