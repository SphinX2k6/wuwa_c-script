using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000571 RID: 1393
	public class ConfigMonsterSizeIdById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020B3 RID: 8371 RVA: 0x00115C18 File Offset: 0x00113E18
		static ConfigMonsterSizeIdById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterSizeIdById.CreateStaticDefaultValue), new Action(ConfigMonsterSizeIdById.ResetStaticDefaultValue));
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00115C38 File Offset: 0x00113E38
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterSizeIdById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterSizeIdById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物战斗配置.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterSizeId"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterSizeId` where Id=?")
			});
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00115CB7 File Offset: 0x00113EB7
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterSizeIdById.LogPair = null;
			ConfigMonsterSizeIdById.HandleId = 0;
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00115CC5 File Offset: 0x00113EC5
		public static void Init()
		{
			ConfigMonsterSizeIdById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterSizeIdById.HandleId, "db_monster_info.db", "select BinData from `MonsterSizeId` where Id=?");
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00115CE0 File Offset: 0x00113EE0
		public static MonsterSizeId? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterSizeIdById.HandleId, ConfigMonsterSizeIdById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterSizeIdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterSizeId?(MonsterSizeId.GetRootAsMonsterSizeId(configBuffer));
				}
			}
			ConfigMonsterSizeIdById.LogPair.Clear();
			ConfigMonsterSizeIdById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterSizeIdById.HandleId, 1, p0Id, ConfigMonsterSizeIdById.LogPair) || ConfigCommon.Step(ConfigMonsterSizeIdById.HandleId, true, ConfigMonsterSizeIdById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterSizeIdById.HandleId, ConfigMonsterSizeIdById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterSizeIdById.HandleId, 0, ConfigMonsterSizeIdById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterSizeIdById.HandleId, ConfigMonsterSizeIdById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterSizeId rootAsMonsterSizeId = MonsterSizeId.GetRootAsMonsterSizeId(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterSizeIdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterSizeIdById.HandleId, ConfigMonsterSizeIdById.LogPair);
			return new MonsterSizeId?(rootAsMonsterSizeId);
		}

		// Token: 0x040025FB RID: 9723
		private const string DB = "db_monster_info.db";

		// Token: 0x040025FC RID: 9724
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x040025FD RID: 9725
		private const string TABLE = "MonsterSizeId";

		// Token: 0x040025FE RID: 9726
		private const string COMMAND = "select BinData from `MonsterSizeId` where Id=?";

		// Token: 0x040025FF RID: 9727
		private const string KEY_PREFIX = "MonsterSizeIdById";

		// Token: 0x04002600 RID: 9728
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002601 RID: 9729
		private static int HandleId;
	}
}
