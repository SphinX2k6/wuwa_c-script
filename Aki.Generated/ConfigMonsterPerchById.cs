using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056D RID: 1389
	public class ConfigMonsterPerchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x00115308 File Offset: 0x00113508
		static ConfigMonsterPerchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterPerchById.CreateStaticDefaultValue), new Action(ConfigMonsterPerchById.ResetStaticDefaultValue));
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00115328 File Offset: 0x00113528
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterPerchById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterPerchById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物信息.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterPerch"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterPerch` where Id=?")
			});
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x001153A7 File Offset: 0x001135A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterPerchById.LogPair = null;
			ConfigMonsterPerchById.HandleId = 0;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x001153B5 File Offset: 0x001135B5
		public static void Init()
		{
			ConfigMonsterPerchById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterPerchById.HandleId, "db_monster_info.db", "select BinData from `MonsterPerch` where Id=?");
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x001153D0 File Offset: 0x001135D0
		public static MonsterPerch? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterPerchById.HandleId, ConfigMonsterPerchById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterPerchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterPerch?(MonsterPerch.GetRootAsMonsterPerch(configBuffer));
				}
			}
			ConfigMonsterPerchById.LogPair.Clear();
			ConfigMonsterPerchById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterPerchById.HandleId, 1, p0Id, ConfigMonsterPerchById.LogPair) || ConfigCommon.Step(ConfigMonsterPerchById.HandleId, true, ConfigMonsterPerchById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterPerchById.HandleId, ConfigMonsterPerchById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterPerchById.HandleId, 0, ConfigMonsterPerchById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterPerchById.HandleId, ConfigMonsterPerchById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterPerch rootAsMonsterPerch = MonsterPerch.GetRootAsMonsterPerch(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterPerchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterPerchById.HandleId, ConfigMonsterPerchById.LogPair);
			return new MonsterPerch?(rootAsMonsterPerch);
		}

		// Token: 0x040025DF RID: 9695
		private const string DB = "db_monster_info.db";

		// Token: 0x040025E0 RID: 9696
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x040025E1 RID: 9697
		private const string TABLE = "MonsterPerch";

		// Token: 0x040025E2 RID: 9698
		private const string COMMAND = "select BinData from `MonsterPerch` where Id=?";

		// Token: 0x040025E3 RID: 9699
		private const string KEY_PREFIX = "MonsterPerchById";

		// Token: 0x040025E4 RID: 9700
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025E5 RID: 9701
		private static int HandleId;
	}
}
