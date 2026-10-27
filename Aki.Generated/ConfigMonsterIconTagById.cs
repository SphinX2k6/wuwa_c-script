using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000555 RID: 1365
	public class ConfigMonsterIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600200B RID: 8203 RVA: 0x0010E774 File Offset: 0x0010C974
		static ConfigMonsterIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterIconTagById.CreateStaticDefaultValue), new Action(ConfigMonsterIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0010E794 File Offset: 0x0010C994
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

		// Token: 0x0600200D RID: 8205 RVA: 0x0010E813 File Offset: 0x0010CA13
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterIconTagById.LogPair = null;
			ConfigMonsterIconTagById.HandleId = 0;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0010E821 File Offset: 0x0010CA21
		public static void Init()
		{
			ConfigMonsterIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterIconTagById.HandleId, "db_component_config.db", "select BinData from `MonsterIconTag` where Id=?");
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0010E83C File Offset: 0x0010CA3C
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

		// Token: 0x04002537 RID: 9527
		private const string DB = "db_component_config.db";

		// Token: 0x04002538 RID: 9528
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x04002539 RID: 9529
		private const string TABLE = "MonsterIconTag";

		// Token: 0x0400253A RID: 9530
		private const string COMMAND = "select BinData from `MonsterIconTag` where Id=?";

		// Token: 0x0400253B RID: 9531
		private const string KEY_PREFIX = "MonsterIconTagById";

		// Token: 0x0400253C RID: 9532
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400253D RID: 9533
		private static int HandleId;
	}
}
