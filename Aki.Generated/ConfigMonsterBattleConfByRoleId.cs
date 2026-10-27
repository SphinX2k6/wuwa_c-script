using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000546 RID: 1350
	public class ConfigMonsterBattleConfByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FB1 RID: 8113 RVA: 0x0010C818 File Offset: 0x0010AA18
		static ConfigMonsterBattleConfByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterBattleConfByRoleId.CreateStaticDefaultValue), new Action(ConfigMonsterBattleConfByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0010C838 File Offset: 0x0010AA38
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterBattleConfByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterBattleConfByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物战斗配置.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterBattleConf"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterBattleConf` where RoleMappingId=?")
			});
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x0010C8B7 File Offset: 0x0010AAB7
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterBattleConfByRoleId.LogPair = null;
			ConfigMonsterBattleConfByRoleId.HandleId = 0;
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0010C8C5 File Offset: 0x0010AAC5
		public static void Init()
		{
			ConfigMonsterBattleConfByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterBattleConfByRoleId.HandleId, "db_monster_info.db", "select BinData from `MonsterBattleConf` where RoleMappingId=?");
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0010C8E0 File Offset: 0x0010AAE0
		public static MonsterBattleConf? GetConfig(int p0RoleMappingId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterBattleConfByRoleId.HandleId, ConfigMonsterBattleConfByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBattleConfByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleMappingId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterBattleConf?(MonsterBattleConf.GetRootAsMonsterBattleConf(configBuffer));
				}
			}
			ConfigMonsterBattleConfByRoleId.LogPair.Clear();
			ConfigMonsterBattleConfByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleMappingId", p0RoleMappingId));
			if (!ConfigCommon.BindInt(ConfigMonsterBattleConfByRoleId.HandleId, 1, p0RoleMappingId, ConfigMonsterBattleConfByRoleId.LogPair) || ConfigCommon.Step(ConfigMonsterBattleConfByRoleId.HandleId, true, ConfigMonsterBattleConfByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterBattleConfByRoleId.HandleId, ConfigMonsterBattleConfByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterBattleConfByRoleId.HandleId, 0, ConfigMonsterBattleConfByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterBattleConfByRoleId.HandleId, ConfigMonsterBattleConfByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterBattleConf rootAsMonsterBattleConf = MonsterBattleConf.GetRootAsMonsterBattleConf(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBattleConfByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleMappingId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterBattleConfByRoleId.HandleId, ConfigMonsterBattleConfByRoleId.LogPair);
			return new MonsterBattleConf?(rootAsMonsterBattleConf);
		}

		// Token: 0x040024CE RID: 9422
		private const string DB = "db_monster_info.db";

		// Token: 0x040024CF RID: 9423
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x040024D0 RID: 9424
		private const string TABLE = "MonsterBattleConf";

		// Token: 0x040024D1 RID: 9425
		private const string COMMAND = "select BinData from `MonsterBattleConf` where RoleMappingId=?";

		// Token: 0x040024D2 RID: 9426
		private const string KEY_PREFIX = "MonsterBattleConfByRoleId";

		// Token: 0x040024D3 RID: 9427
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024D4 RID: 9428
		private static int HandleId;
	}
}
