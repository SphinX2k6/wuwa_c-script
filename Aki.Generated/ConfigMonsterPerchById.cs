using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000557 RID: 1367
	public class ConfigMonsterPerchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x0010EBB4 File Offset: 0x0010CDB4
		static ConfigMonsterPerchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterPerchById.CreateStaticDefaultValue), new Action(ConfigMonsterPerchById.ResetStaticDefaultValue));
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0010EBD4 File Offset: 0x0010CDD4
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

		// Token: 0x06002019 RID: 8217 RVA: 0x0010EC53 File Offset: 0x0010CE53
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterPerchById.LogPair = null;
			ConfigMonsterPerchById.HandleId = 0;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0010EC61 File Offset: 0x0010CE61
		public static void Init()
		{
			ConfigMonsterPerchById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterPerchById.HandleId, "db_monster_info.db", "select BinData from `MonsterPerch` where Id=?");
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0010EC7C File Offset: 0x0010CE7C
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

		// Token: 0x04002545 RID: 9541
		private const string DB = "db_monster_info.db";

		// Token: 0x04002546 RID: 9542
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x04002547 RID: 9543
		private const string TABLE = "MonsterPerch";

		// Token: 0x04002548 RID: 9544
		private const string COMMAND = "select BinData from `MonsterPerch` where Id=?";

		// Token: 0x04002549 RID: 9545
		private const string KEY_PREFIX = "MonsterPerchById";

		// Token: 0x0400254A RID: 9546
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400254B RID: 9547
		private static int HandleId;
	}
}
