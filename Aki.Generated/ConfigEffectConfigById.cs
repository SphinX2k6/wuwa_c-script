using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026A RID: 618
	public class ConfigEffectConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E80 RID: 3712 RVA: 0x000AEFB0 File Offset: 0x000AD1B0
		static ConfigEffectConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectConfigById.CreateStaticDefaultValue), new Action(ConfigEffectConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000AEFD0 File Offset: 0x000AD1D0
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

		// Token: 0x06000E82 RID: 3714 RVA: 0x000AF04F File Offset: 0x000AD24F
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectConfigById.LogPair = null;
			ConfigEffectConfigById.HandleId = 0;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000AF05D File Offset: 0x000AD25D
		public static void Init()
		{
			ConfigEffectConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEffectConfigById.HandleId, "db_effect.db", "select BinData from `EffectConfig` where Id=?");
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000AF078 File Offset: 0x000AD278
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

		// Token: 0x040010CA RID: 4298
		private const string DB = "db_effect.db";

		// Token: 0x040010CB RID: 4299
		private const string FILE = "t.特效.xlsx";

		// Token: 0x040010CC RID: 4300
		private const string TABLE = "EffectConfig";

		// Token: 0x040010CD RID: 4301
		private const string COMMAND = "select BinData from `EffectConfig` where Id=?";

		// Token: 0x040010CE RID: 4302
		private const string KEY_PREFIX = "EffectConfigById";

		// Token: 0x040010CF RID: 4303
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010D0 RID: 4304
		private static int HandleId;
	}
}
