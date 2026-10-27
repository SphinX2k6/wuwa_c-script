using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055B RID: 1371
	public class ConfigMonsterSizeIdById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600202F RID: 8239 RVA: 0x0010F4C4 File Offset: 0x0010D6C4
		static ConfigMonsterSizeIdById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterSizeIdById.CreateStaticDefaultValue), new Action(ConfigMonsterSizeIdById.ResetStaticDefaultValue));
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x0010F4E4 File Offset: 0x0010D6E4
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

		// Token: 0x06002031 RID: 8241 RVA: 0x0010F563 File Offset: 0x0010D763
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterSizeIdById.LogPair = null;
			ConfigMonsterSizeIdById.HandleId = 0;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0010F571 File Offset: 0x0010D771
		public static void Init()
		{
			ConfigMonsterSizeIdById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterSizeIdById.HandleId, "db_monster_info.db", "select BinData from `MonsterSizeId` where Id=?");
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0010F58C File Offset: 0x0010D78C
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

		// Token: 0x04002561 RID: 9569
		private const string DB = "db_monster_info.db";

		// Token: 0x04002562 RID: 9570
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x04002563 RID: 9571
		private const string TABLE = "MonsterSizeId";

		// Token: 0x04002564 RID: 9572
		private const string COMMAND = "select BinData from `MonsterSizeId` where Id=?";

		// Token: 0x04002565 RID: 9573
		private const string KEY_PREFIX = "MonsterSizeIdById";

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
