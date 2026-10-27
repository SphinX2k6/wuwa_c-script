using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000545 RID: 1349
	public class ConfigMonsterBattleConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FAB RID: 8107 RVA: 0x0010C5D0 File Offset: 0x0010A7D0
		static ConfigMonsterBattleConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterBattleConfById.CreateStaticDefaultValue), new Action(ConfigMonsterBattleConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x0010C5F0 File Offset: 0x0010A7F0
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterBattleConfById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterBattleConfById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物战斗配置.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterBattleConf"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterBattleConf` where Id=?")
			});
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x0010C66F File Offset: 0x0010A86F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterBattleConfById.LogPair = null;
			ConfigMonsterBattleConfById.HandleId = 0;
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0010C67D File Offset: 0x0010A87D
		public static void Init()
		{
			ConfigMonsterBattleConfById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterBattleConfById.HandleId, "db_monster_info.db", "select BinData from `MonsterBattleConf` where Id=?");
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0010C698 File Offset: 0x0010A898
		public static MonsterBattleConf? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterBattleConfById.HandleId, ConfigMonsterBattleConfById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBattleConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterBattleConf?(MonsterBattleConf.GetRootAsMonsterBattleConf(configBuffer));
				}
			}
			ConfigMonsterBattleConfById.LogPair.Clear();
			ConfigMonsterBattleConfById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterBattleConfById.HandleId, 1, p0Id, ConfigMonsterBattleConfById.LogPair) || ConfigCommon.Step(ConfigMonsterBattleConfById.HandleId, true, ConfigMonsterBattleConfById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterBattleConfById.HandleId, ConfigMonsterBattleConfById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterBattleConfById.HandleId, 0, ConfigMonsterBattleConfById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterBattleConfById.HandleId, ConfigMonsterBattleConfById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterBattleConf rootAsMonsterBattleConf = MonsterBattleConf.GetRootAsMonsterBattleConf(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBattleConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterBattleConfById.HandleId, ConfigMonsterBattleConfById.LogPair);
			return new MonsterBattleConf?(rootAsMonsterBattleConf);
		}

		// Token: 0x040024C7 RID: 9415
		private const string DB = "db_monster_info.db";

		// Token: 0x040024C8 RID: 9416
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x040024C9 RID: 9417
		private const string TABLE = "MonsterBattleConf";

		// Token: 0x040024CA RID: 9418
		private const string COMMAND = "select BinData from `MonsterBattleConf` where Id=?";

		// Token: 0x040024CB RID: 9419
		private const string KEY_PREFIX = "MonsterBattleConfById";

		// Token: 0x040024CC RID: 9420
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024CD RID: 9421
		private static int HandleId;
	}
}
