using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000256 RID: 598
	public class ConfigEffectConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E08 RID: 3592 RVA: 0x000A8CEC File Offset: 0x000A6EEC
		static ConfigEffectConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectConfigById.CreateStaticDefaultValue), new Action(ConfigEffectConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x000A8D0C File Offset: 0x000A6F0C
		public static void CreateStaticDefaultValue()
		{
			ConfigEffectConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEffectConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_effect.db"),
				new ValueTuple<string, object>("文件", "t.特效.xlsx"),
				new ValueTuple<string, object>("表名", "EffectConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EffectConfig` where Id=?")
			});
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000A8D8B File Offset: 0x000A6F8B
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectConfigById.LogPair = null;
			ConfigEffectConfigById.HandleId = 0;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x000A8D99 File Offset: 0x000A6F99
		public static void Init()
		{
			ConfigEffectConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEffectConfigById.HandleId, "db_effect.db", "select BinData from `EffectConfig` where Id=?");
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000A8DB4 File Offset: 0x000A6FB4
		public static EffectConfig? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEffectConfigById.HandleId, ConfigEffectConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("EffectConfigById#" + p0Id);
				if (configBuffer != null)
				{
					return new EffectConfig?(EffectConfig.GetRootAsEffectConfig(configBuffer));
				}
			}
			ConfigEffectConfigById.LogPair.Clear();
			ConfigEffectConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigEffectConfigById.HandleId, 1, p0Id, ConfigEffectConfigById.LogPair) || ConfigCommon.Step(ConfigEffectConfigById.HandleId, true, ConfigEffectConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEffectConfigById.HandleId, ConfigEffectConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEffectConfigById.HandleId, 0, ConfigEffectConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEffectConfigById.HandleId, ConfigEffectConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EffectConfig rootAsEffectConfig = EffectConfig.GetRootAsEffectConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("EffectConfigById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEffectConfigById.HandleId, ConfigEffectConfigById.LogPair);
			return new EffectConfig?(rootAsEffectConfig);
		}

		// Token: 0x0400103E RID: 4158
		private const string DB = "db_effect.db";

		// Token: 0x0400103F RID: 4159
		private const string FILE = "t.特效.xlsx";

		// Token: 0x04001040 RID: 4160
		private const string TABLE = "EffectConfig";

		// Token: 0x04001041 RID: 4161
		private const string COMMAND = "select BinData from `EffectConfig` where Id=?";

		// Token: 0x04001042 RID: 4162
		private const string KEY_PREFIX = "EffectConfigById";

		// Token: 0x04001043 RID: 4163
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001044 RID: 4164
		private static int HandleId;
	}
}
