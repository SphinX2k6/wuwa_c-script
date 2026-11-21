using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056C RID: 1388
	public class ConfigMonsterInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002095 RID: 8341 RVA: 0x001150C1 File Offset: 0x001132C1
		static ConfigMonsterInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterInfoById.CreateStaticDefaultValue), new Action(ConfigMonsterInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x001150E0 File Offset: 0x001132E0
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物信息.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterInfo` where Id=?")
			});
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0011515F File Offset: 0x0011335F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterInfoById.LogPair = null;
			ConfigMonsterInfoById.HandleId = 0;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0011516D File Offset: 0x0011336D
		public static void Init()
		{
			ConfigMonsterInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterInfoById.HandleId, "db_monster_info.db", "select BinData from `MonsterInfo` where Id=?");
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00115188 File Offset: 0x00113388
		public static MonsterInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterInfo?(MonsterInfo.GetRootAsMonsterInfo(configBuffer));
				}
			}
			ConfigMonsterInfoById.LogPair.Clear();
			ConfigMonsterInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterInfoById.HandleId, 1, p0Id, ConfigMonsterInfoById.LogPair) || ConfigCommon.Step(ConfigMonsterInfoById.HandleId, true, ConfigMonsterInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterInfoById.HandleId, 0, ConfigMonsterInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterInfo rootAsMonsterInfo = MonsterInfo.GetRootAsMonsterInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair);
			return new MonsterInfo?(rootAsMonsterInfo);
		}

		// Token: 0x040025D8 RID: 9688
		private const string DB = "db_monster_info.db";

		// Token: 0x040025D9 RID: 9689
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x040025DA RID: 9690
		private const string TABLE = "MonsterInfo";

		// Token: 0x040025DB RID: 9691
		private const string COMMAND = "select BinData from `MonsterInfo` where Id=?";

		// Token: 0x040025DC RID: 9692
		private const string KEY_PREFIX = "MonsterInfoById";

		// Token: 0x040025DD RID: 9693
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025DE RID: 9694
		private static int HandleId;
	}
}
