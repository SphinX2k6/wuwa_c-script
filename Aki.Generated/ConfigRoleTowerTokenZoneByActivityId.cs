using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000916 RID: 2326
	public class ConfigRoleTowerTokenZoneByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003697 RID: 13975 RVA: 0x0019119F File Offset: 0x0018F39F
		static ConfigRoleTowerTokenZoneByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenZoneByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenZoneByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x001911C0 File Offset: 0x0018F3C0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenZoneByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenZoneByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerTokenZone"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerTokenZone` where ActivityId=?")
			});
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x0019123F File Offset: 0x0018F43F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenZoneByActivityId.LogPair = null;
			ConfigRoleTowerTokenZoneByActivityId.HandleId = 0;
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x0019124D File Offset: 0x0018F44D
		public static void Init()
		{
			ConfigRoleTowerTokenZoneByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenZoneByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerTokenZone` where ActivityId=?");
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x00191268 File Offset: 0x0018F468
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerTokenZone> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenZoneByActivityId.HandleId, ConfigRoleTowerTokenZoneByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenZoneByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoleTowerTokenZone> readOnlyList = (IReadOnlyList<RoleTowerTokenZone>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerTokenZoneByActivityId.LogPair.Clear();
			ConfigRoleTowerTokenZoneByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerTokenZoneByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerTokenZoneByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenZoneByActivityId.HandleId, ConfigRoleTowerTokenZoneByActivityId.LogPair);
				return null;
			}
			List<RoleTowerTokenZone> list = new List<RoleTowerTokenZone>();
			while (ConfigCommon.Step(ConfigRoleTowerTokenZoneByActivityId.HandleId, false, ConfigRoleTowerTokenZoneByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenZoneByActivityId.HandleId, 0, ConfigRoleTowerTokenZoneByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerTokenZoneByActivityId.HandleId, ConfigRoleTowerTokenZoneByActivityId.LogPair);
					return null;
				}
				RoleTowerTokenZone rootAsRoleTowerTokenZone = RoleTowerTokenZone.GetRootAsRoleTowerTokenZone(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerTokenZone);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenZoneByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenZoneByActivityId.HandleId, ConfigRoleTowerTokenZoneByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003F80 RID: 16256
		private const string DB = "db_roletower.db";

		// Token: 0x04003F81 RID: 16257
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F82 RID: 16258
		private const string TABLE = "RoleTowerTokenZone";

		// Token: 0x04003F83 RID: 16259
		private const string COMMAND = "select BinData from `RoleTowerTokenZone` where ActivityId=?";

		// Token: 0x04003F84 RID: 16260
		private const string KEY_PREFIX = "RoleTowerTokenZoneByActivityId";

		// Token: 0x04003F85 RID: 16261
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F86 RID: 16262
		private static int HandleId;
	}
}
