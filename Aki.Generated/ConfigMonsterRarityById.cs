using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055A RID: 1370
	public class ConfigMonsterRarityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002029 RID: 8233 RVA: 0x0010F27C File Offset: 0x0010D47C
		static ConfigMonsterRarityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterRarityById.CreateStaticDefaultValue), new Action(ConfigMonsterRarityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0010F29C File Offset: 0x0010D49C
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

		// Token: 0x0600202B RID: 8235 RVA: 0x0010F31B File Offset: 0x0010D51B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterRarityById.LogPair = null;
			ConfigMonsterRarityById.HandleId = 0;
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0010F329 File Offset: 0x0010D529
		public static void Init()
		{
			ConfigMonsterRarityById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterRarityById.HandleId, "db_monster_info.db", "select BinData from `MonsterRarity` where Id=?");
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0010F344 File Offset: 0x0010D544
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

		// Token: 0x0400255A RID: 9562
		private const string DB = "db_monster_info.db";

		// Token: 0x0400255B RID: 9563
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x0400255C RID: 9564
		private const string TABLE = "MonsterRarity";

		// Token: 0x0400255D RID: 9565
		private const string COMMAND = "select BinData from `MonsterRarity` where Id=?";

		// Token: 0x0400255E RID: 9566
		private const string KEY_PREFIX = "MonsterRarityById";

		// Token: 0x0400255F RID: 9567
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002560 RID: 9568
		private static int HandleId;
	}
}
