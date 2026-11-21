using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055C RID: 1372
	public class ConfigMonsterBattleConfByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002035 RID: 8245 RVA: 0x00112F6C File Offset: 0x0011116C
		static ConfigMonsterBattleConfByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterBattleConfByRoleId.CreateStaticDefaultValue), new Action(ConfigMonsterBattleConfByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00112F8C File Offset: 0x0011118C
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

		// Token: 0x06002037 RID: 8247 RVA: 0x0011300B File Offset: 0x0011120B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterBattleConfByRoleId.LogPair = null;
			ConfigMonsterBattleConfByRoleId.HandleId = 0;
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00113019 File Offset: 0x00111219
		public static void Init()
		{
			ConfigMonsterBattleConfByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterBattleConfByRoleId.HandleId, "db_monster_info.db", "select BinData from `MonsterBattleConf` where RoleMappingId=?");
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00113034 File Offset: 0x00111234
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

		// Token: 0x04002568 RID: 9576
		private const string DB = "db_monster_info.db";

		// Token: 0x04002569 RID: 9577
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x0400256A RID: 9578
		private const string TABLE = "MonsterBattleConf";

		// Token: 0x0400256B RID: 9579
		private const string COMMAND = "select BinData from `MonsterBattleConf` where RoleMappingId=?";

		// Token: 0x0400256C RID: 9580
		private const string KEY_PREFIX = "MonsterBattleConfByRoleId";

		// Token: 0x0400256D RID: 9581
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400256E RID: 9582
		private static int HandleId;
	}
}
