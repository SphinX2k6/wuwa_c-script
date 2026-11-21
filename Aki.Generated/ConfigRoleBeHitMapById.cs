using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A5 RID: 2213
	public class ConfigRoleBeHitMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033F0 RID: 13296 RVA: 0x0018277B File Offset: 0x0018097B
		static ConfigRoleBeHitMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBeHitMapById.CreateStaticDefaultValue), new Action(ConfigRoleBeHitMapById.ResetStaticDefaultValue));
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x0018279C File Offset: 0x0018099C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBeHitMapById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBeHitMapById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolebehitmap.db"),
				new ValueTuple<string, object>("文件", "j.角色受击状态机.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBeHitMap"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBeHitMap` where Id=?")
			});
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x0018281B File Offset: 0x00180A1B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBeHitMapById.LogPair = null;
			ConfigRoleBeHitMapById.HandleId = 0;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00182829 File Offset: 0x00180A29
		public static void Init()
		{
			ConfigRoleBeHitMapById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBeHitMapById.HandleId, "db_rolebehitmap.db", "select BinData from `RoleBeHitMap` where Id=?");
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00182844 File Offset: 0x00180A44
		public static RoleBeHitMap? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBeHitMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleBeHitMap?(RoleBeHitMap.GetRootAsRoleBeHitMap(configBuffer));
				}
			}
			ConfigRoleBeHitMapById.LogPair.Clear();
			ConfigRoleBeHitMapById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleBeHitMapById.HandleId, 1, p0Id, ConfigRoleBeHitMapById.LogPair) || ConfigCommon.Step(ConfigRoleBeHitMapById.HandleId, true, ConfigRoleBeHitMapById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBeHitMapById.HandleId, 0, ConfigRoleBeHitMapById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleBeHitMap rootAsRoleBeHitMap = RoleBeHitMap.GetRootAsRoleBeHitMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBeHitMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair);
			return new RoleBeHitMap?(rootAsRoleBeHitMap);
		}

		// Token: 0x04003C69 RID: 15465
		private const string DB = "db_rolebehitmap.db";

		// Token: 0x04003C6A RID: 15466
		private const string FILE = "j.角色受击状态机.xlsx";

		// Token: 0x04003C6B RID: 15467
		private const string TABLE = "RoleBeHitMap";

		// Token: 0x04003C6C RID: 15468
		private const string COMMAND = "select BinData from `RoleBeHitMap` where Id=?";

		// Token: 0x04003C6D RID: 15469
		private const string KEY_PREFIX = "RoleBeHitMapById";

		// Token: 0x04003C6E RID: 15470
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C6F RID: 15471
		private static int HandleId;
	}
}
