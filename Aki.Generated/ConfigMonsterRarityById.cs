using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000570 RID: 1392
	public class ConfigMonsterRarityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020AD RID: 8365 RVA: 0x001159D0 File Offset: 0x00113BD0
		static ConfigMonsterRarityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterRarityById.CreateStaticDefaultValue), new Action(ConfigMonsterRarityById.ResetStaticDefaultValue));
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x001159F0 File Offset: 0x00113BF0
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterRarityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterRarityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物信息.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterRarity"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterRarity` where Id=?")
			});
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00115A6F File Offset: 0x00113C6F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterRarityById.LogPair = null;
			ConfigMonsterRarityById.HandleId = 0;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00115A7D File Offset: 0x00113C7D
		public static void Init()
		{
			ConfigMonsterRarityById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterRarityById.HandleId, "db_monster_info.db", "select BinData from `MonsterRarity` where Id=?");
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00115A98 File Offset: 0x00113C98
		public static MonsterRarity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterRarityById.HandleId, ConfigMonsterRarityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterRarityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterRarity?(MonsterRarity.GetRootAsMonsterRarity(configBuffer));
				}
			}
			ConfigMonsterRarityById.LogPair.Clear();
			ConfigMonsterRarityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterRarityById.HandleId, 1, p0Id, ConfigMonsterRarityById.LogPair) || ConfigCommon.Step(ConfigMonsterRarityById.HandleId, true, ConfigMonsterRarityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterRarityById.HandleId, ConfigMonsterRarityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterRarityById.HandleId, 0, ConfigMonsterRarityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterRarityById.HandleId, ConfigMonsterRarityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterRarity rootAsMonsterRarity = MonsterRarity.GetRootAsMonsterRarity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterRarityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterRarityById.HandleId, ConfigMonsterRarityById.LogPair);
			return new MonsterRarity?(rootAsMonsterRarity);
		}

		// Token: 0x040025F4 RID: 9716
		private const string DB = "db_monster_info.db";

		// Token: 0x040025F5 RID: 9717
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x040025F6 RID: 9718
		private const string TABLE = "MonsterRarity";

		// Token: 0x040025F7 RID: 9719
		private const string COMMAND = "select BinData from `MonsterRarity` where Id=?";

		// Token: 0x040025F8 RID: 9720
		private const string KEY_PREFIX = "MonsterRarityById";

		// Token: 0x040025F9 RID: 9721
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025FA RID: 9722
		private static int HandleId;
	}
}
