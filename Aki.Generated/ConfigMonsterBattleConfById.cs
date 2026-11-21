using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055B RID: 1371
	public class ConfigMonsterBattleConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600202F RID: 8239 RVA: 0x00112D24 File Offset: 0x00110F24
		static ConfigMonsterBattleConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterBattleConfById.CreateStaticDefaultValue), new Action(ConfigMonsterBattleConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00112D44 File Offset: 0x00110F44
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

		// Token: 0x06002031 RID: 8241 RVA: 0x00112DC3 File Offset: 0x00110FC3
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterBattleConfById.LogPair = null;
			ConfigMonsterBattleConfById.HandleId = 0;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00112DD1 File Offset: 0x00110FD1
		public static void Init()
		{
			ConfigMonsterBattleConfById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterBattleConfById.HandleId, "db_monster_info.db", "select BinData from `MonsterBattleConf` where Id=?");
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00112DEC File Offset: 0x00110FEC
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

		// Token: 0x04002561 RID: 9569
		private const string DB = "db_monster_info.db";

		// Token: 0x04002562 RID: 9570
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x04002563 RID: 9571
		private const string TABLE = "MonsterBattleConf";

		// Token: 0x04002564 RID: 9572
		private const string COMMAND = "select BinData from `MonsterBattleConf` where Id=?";

		// Token: 0x04002565 RID: 9573
		private const string KEY_PREFIX = "MonsterBattleConfById";

		// Token: 0x04002566 RID: 9574
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002567 RID: 9575
		private static int HandleId;
	}
}
