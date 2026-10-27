using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000275 RID: 629
	public class ConfigEntityAudioConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x000ACE1B File Offset: 0x000AB01B
		static ConfigEntityAudioConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityAudioConfigById.CreateStaticDefaultValue), new Action(ConfigEntityAudioConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000ACE3C File Offset: 0x000AB03C
		public static void CreateStaticDefaultValue()
		{
			ConfigEntityAudioConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntityAudioConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "EntityAudioConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EntityAudioConfig` where Id=?")
			});
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000ACEBB File Offset: 0x000AB0BB
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityAudioConfigById.LogPair = null;
			ConfigEntityAudioConfigById.HandleId = 0;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000ACEC9 File Offset: 0x000AB0C9
		public static void Init()
		{
			ConfigEntityAudioConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEntityAudioConfigById.HandleId, "db_entity_audio.db", "select BinData from `EntityAudioConfig` where Id=?");
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000ACEE4 File Offset: 0x000AB0E4
		public static EntityAudioConfig? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntityAudioConfigById.HandleId, ConfigEntityAudioConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("EntityAudioConfigById#" + p0Id);
				if (configBuffer != null)
				{
					return new EntityAudioConfig?(EntityAudioConfig.GetRootAsEntityAudioConfig(configBuffer));
				}
			}
			ConfigEntityAudioConfigById.LogPair.Clear();
			ConfigEntityAudioConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigEntityAudioConfigById.HandleId, 1, p0Id, ConfigEntityAudioConfigById.LogPair) || ConfigCommon.Step(ConfigEntityAudioConfigById.HandleId, true, ConfigEntityAudioConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntityAudioConfigById.HandleId, ConfigEntityAudioConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntityAudioConfigById.HandleId, 0, ConfigEntityAudioConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntityAudioConfigById.HandleId, ConfigEntityAudioConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntityAudioConfig rootAsEntityAudioConfig = EntityAudioConfig.GetRootAsEntityAudioConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("EntityAudioConfigById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntityAudioConfigById.HandleId, ConfigEntityAudioConfigById.LogPair);
			return new EntityAudioConfig?(rootAsEntityAudioConfig);
		}

		// Token: 0x04001117 RID: 4375
		private const string DB = "db_entity_audio.db";

		// Token: 0x04001118 RID: 4376
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x04001119 RID: 4377
		private const string TABLE = "EntityAudioConfig";

		// Token: 0x0400111A RID: 4378
		private const string COMMAND = "select BinData from `EntityAudioConfig` where Id=?";

		// Token: 0x0400111B RID: 4379
		private const string KEY_PREFIX = "EntityAudioConfigById";

		// Token: 0x0400111C RID: 4380
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400111D RID: 4381
		private static int HandleId;
	}
}
