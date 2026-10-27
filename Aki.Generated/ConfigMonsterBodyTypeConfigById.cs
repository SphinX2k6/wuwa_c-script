using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000547 RID: 1351
	public class ConfigMonsterBodyTypeConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FB7 RID: 8119 RVA: 0x0010CA60 File Offset: 0x0010AC60
		static ConfigMonsterBodyTypeConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterBodyTypeConfigById.CreateStaticDefaultValue), new Action(ConfigMonsterBodyTypeConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x0010CA80 File Offset: 0x0010AC80
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterBodyTypeConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterBodyTypeConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物信息.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterBodyTypeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterBodyTypeConfig` where Id = ?")
			});
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x0010CAFF File Offset: 0x0010ACFF
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterBodyTypeConfigById.LogPair = null;
			ConfigMonsterBodyTypeConfigById.HandleId = 0;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0010CB0D File Offset: 0x0010AD0D
		public static void Init()
		{
			ConfigMonsterBodyTypeConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterBodyTypeConfigById.HandleId, "db_monster_info.db", "select BinData from `MonsterBodyTypeConfig` where Id = ?");
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0010CB28 File Offset: 0x0010AD28
		public static MonsterBodyTypeConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBodyTypeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterBodyTypeConfig?(MonsterBodyTypeConfig.GetRootAsMonsterBodyTypeConfig(configBuffer));
				}
			}
			ConfigMonsterBodyTypeConfigById.LogPair.Clear();
			ConfigMonsterBodyTypeConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterBodyTypeConfigById.HandleId, 1, p0Id, ConfigMonsterBodyTypeConfigById.LogPair) || ConfigCommon.Step(ConfigMonsterBodyTypeConfigById.HandleId, true, ConfigMonsterBodyTypeConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterBodyTypeConfigById.HandleId, 0, ConfigMonsterBodyTypeConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterBodyTypeConfig rootAsMonsterBodyTypeConfig = MonsterBodyTypeConfig.GetRootAsMonsterBodyTypeConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBodyTypeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair);
			return new MonsterBodyTypeConfig?(rootAsMonsterBodyTypeConfig);
		}

		// Token: 0x040024D5 RID: 9429
		private const string DB = "db_monster_info.db";

		// Token: 0x040024D6 RID: 9430
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x040024D7 RID: 9431
		private const string TABLE = "MonsterBodyTypeConfig";

		// Token: 0x040024D8 RID: 9432
		private const string COMMAND = "select BinData from `MonsterBodyTypeConfig` where Id = ?";

		// Token: 0x040024D9 RID: 9433
		private const string KEY_PREFIX = "MonsterBodyTypeConfigById";

		// Token: 0x040024DA RID: 9434
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024DB RID: 9435
		private static int HandleId;
	}
}
