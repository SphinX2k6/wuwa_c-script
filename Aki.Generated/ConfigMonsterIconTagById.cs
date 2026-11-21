using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056B RID: 1387
	public class ConfigMonsterIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600208F RID: 8335 RVA: 0x00114EC8 File Offset: 0x001130C8
		static ConfigMonsterIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterIconTagById.CreateStaticDefaultValue), new Action(ConfigMonsterIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00114EE8 File Offset: 0x001130E8
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterIconTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterIconTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_component_config.db"),
				new ValueTuple<string, object>("文件", "t.通用组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterIconTag"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterIconTag` where Id=?")
			});
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00114F67 File Offset: 0x00113167
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterIconTagById.LogPair = null;
			ConfigMonsterIconTagById.HandleId = 0;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00114F75 File Offset: 0x00113175
		public static void Init()
		{
			ConfigMonsterIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterIconTagById.HandleId, "db_component_config.db", "select BinData from `MonsterIconTag` where Id=?");
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00114F90 File Offset: 0x00113190
		public static MonsterIconTag? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterIconTagById.HandleId, ConfigMonsterIconTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("MonsterIconTagById#" + p0Id);
				if (configBuffer != null)
				{
					return new MonsterIconTag?(MonsterIconTag.GetRootAsMonsterIconTag(configBuffer));
				}
			}
			ConfigMonsterIconTagById.LogPair.Clear();
			ConfigMonsterIconTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigMonsterIconTagById.HandleId, 1, p0Id, ConfigMonsterIconTagById.LogPair) || ConfigCommon.Step(ConfigMonsterIconTagById.HandleId, true, ConfigMonsterIconTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterIconTagById.HandleId, ConfigMonsterIconTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterIconTagById.HandleId, 0, ConfigMonsterIconTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterIconTagById.HandleId, ConfigMonsterIconTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterIconTag rootAsMonsterIconTag = MonsterIconTag.GetRootAsMonsterIconTag(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("MonsterIconTagById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterIconTagById.HandleId, ConfigMonsterIconTagById.LogPair);
			return new MonsterIconTag?(rootAsMonsterIconTag);
		}

		// Token: 0x040025D1 RID: 9681
		private const string DB = "db_component_config.db";

		// Token: 0x040025D2 RID: 9682
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x040025D3 RID: 9683
		private const string TABLE = "MonsterIconTag";

		// Token: 0x040025D4 RID: 9684
		private const string COMMAND = "select BinData from `MonsterIconTag` where Id=?";

		// Token: 0x040025D5 RID: 9685
		private const string KEY_PREFIX = "MonsterIconTagById";

		// Token: 0x040025D6 RID: 9686
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025D7 RID: 9687
		private static int HandleId;
	}
}
