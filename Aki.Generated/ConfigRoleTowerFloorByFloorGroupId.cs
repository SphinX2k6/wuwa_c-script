using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F3 RID: 2291
	public class ConfigRoleTowerFloorByFloorGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035C5 RID: 13765 RVA: 0x0018CAC8 File Offset: 0x0018ACC8
		static ConfigRoleTowerFloorByFloorGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerFloorByFloorGroupId.CreateStaticDefaultValue), new Action(ConfigRoleTowerFloorByFloorGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0018CAE8 File Offset: 0x0018ACE8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerFloorByFloorGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerFloorByFloorGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerFloor"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerFloor` where FloorGroupId=?")
			});
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0018CB67 File Offset: 0x0018AD67
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerFloorByFloorGroupId.LogPair = null;
			ConfigRoleTowerFloorByFloorGroupId.HandleId = 0;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x0018CB75 File Offset: 0x0018AD75
		public static void Init()
		{
			ConfigRoleTowerFloorByFloorGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerFloorByFloorGroupId.HandleId, "db_roletower.db", "select BinData from `RoleTowerFloor` where FloorGroupId=?");
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x0018CB90 File Offset: 0x0018AD90
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerFloor> GetConfigList(int p0FloorGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerFloorByFloorGroupId.HandleId, ConfigRoleTowerFloorByFloorGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerFloorByFloorGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FloorGroupId);
				IReadOnlyList<RoleTowerFloor> readOnlyList = (IReadOnlyList<RoleTowerFloor>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerFloorByFloorGroupId.LogPair.Clear();
			ConfigRoleTowerFloorByFloorGroupId.LogPair.Add(new ValueTuple<string, object>("FloorGroupId", p0FloorGroupId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerFloorByFloorGroupId.HandleId, 1, p0FloorGroupId, ConfigRoleTowerFloorByFloorGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerFloorByFloorGroupId.HandleId, ConfigRoleTowerFloorByFloorGroupId.LogPair);
				return null;
			}
			List<RoleTowerFloor> list = new List<RoleTowerFloor>();
			while (ConfigCommon.Step(ConfigRoleTowerFloorByFloorGroupId.HandleId, false, ConfigRoleTowerFloorByFloorGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerFloorByFloorGroupId.HandleId, 0, ConfigRoleTowerFloorByFloorGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerFloorByFloorGroupId.HandleId, ConfigRoleTowerFloorByFloorGroupId.LogPair);
					return null;
				}
				RoleTowerFloor rootAsRoleTowerFloor = RoleTowerFloor.GetRootAsRoleTowerFloor(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerFloor);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerFloorByFloorGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FloorGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerFloorByFloorGroupId.HandleId, ConfigRoleTowerFloorByFloorGroupId.LogPair);
			return list;
		}

		// Token: 0x04003E8B RID: 16011
		private const string DB = "db_roletower.db";

		// Token: 0x04003E8C RID: 16012
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003E8D RID: 16013
		private const string TABLE = "RoleTowerFloor";

		// Token: 0x04003E8E RID: 16014
		private const string COMMAND = "select BinData from `RoleTowerFloor` where FloorGroupId=?";

		// Token: 0x04003E8F RID: 16015
		private const string KEY_PREFIX = "RoleTowerFloorByFloorGroupId";

		// Token: 0x04003E90 RID: 16016
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E91 RID: 16017
		private static int HandleId;
	}
}
