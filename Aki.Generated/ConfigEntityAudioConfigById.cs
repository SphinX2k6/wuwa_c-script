using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000289 RID: 649
	public class ConfigEntityAudioConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x000B30DF File Offset: 0x000B12DF
		static ConfigEntityAudioConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityAudioConfigById.CreateStaticDefaultValue), new Action(ConfigEntityAudioConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000B3100 File Offset: 0x000B1300
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

		// Token: 0x06000F3D RID: 3901 RVA: 0x000B317F File Offset: 0x000B137F
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityAudioConfigById.LogPair = null;
			ConfigEntityAudioConfigById.HandleId = 0;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000B318D File Offset: 0x000B138D
		public static void Init()
		{
			ConfigEntityAudioConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEntityAudioConfigById.HandleId, "db_entity_audio.db", "select BinData from `EntityAudioConfig` where Id=?");
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000B31A8 File Offset: 0x000B13A8
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

		// Token: 0x040011A3 RID: 4515
		private const string DB = "db_entity_audio.db";

		// Token: 0x040011A4 RID: 4516
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x040011A5 RID: 4517
		private const string TABLE = "EntityAudioConfig";

		// Token: 0x040011A6 RID: 4518
		private const string COMMAND = "select BinData from `EntityAudioConfig` where Id=?";

		// Token: 0x040011A7 RID: 4519
		private const string KEY_PREFIX = "EntityAudioConfigById";

		// Token: 0x040011A8 RID: 4520
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011A9 RID: 4521
		private static int HandleId;
	}
}
