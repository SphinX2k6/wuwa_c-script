using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000417 RID: 1047
	public class ConfigI18nResourcesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x000E4C2B File Offset: 0x000E2E2B
		static ConfigI18nResourcesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigI18nResourcesById.CreateStaticDefaultValue), new Action(ConfigI18nResourcesById.ResetStaticDefaultValue));
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000E4C4C File Offset: 0x000E2E4C
		public static void CreateStaticDefaultValue()
		{
			ConfigI18nResourcesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigI18nResourcesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_i18nresources.db"),
				new ValueTuple<string, object>("文件", "i.i18n资源.xlsx"),
				new ValueTuple<string, object>("表名", "I18nResources"),
				new ValueTuple<string, object>("语句", "select BinData from `I18nResources` where Id=?")
			});
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x000E4CCB File Offset: 0x000E2ECB
		public static void ResetStaticDefaultValue()
		{
			ConfigI18nResourcesById.LogPair = null;
			ConfigI18nResourcesById.HandleId = 0;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000E4CD9 File Offset: 0x000E2ED9
		public static void Init()
		{
			ConfigI18nResourcesById.HandleId = ConfigCommon.InitDataStatement(ConfigI18nResourcesById.HandleId, "db_i18nresources.db", "select BinData from `I18nResources` where Id=?");
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x000E4CF4 File Offset: 0x000E2EF4
		public static I18nResources? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigI18nResourcesById.HandleId, ConfigI18nResourcesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("I18nResourcesById#" + p0Id);
				if (configBuffer != null)
				{
					return new I18nResources?(I18nResources.GetRootAsI18nResources(configBuffer));
				}
			}
			ConfigI18nResourcesById.LogPair.Clear();
			ConfigI18nResourcesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigI18nResourcesById.HandleId, 1, p0Id, ConfigI18nResourcesById.LogPair) || ConfigCommon.Step(ConfigI18nResourcesById.HandleId, true, ConfigI18nResourcesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigI18nResourcesById.HandleId, ConfigI18nResourcesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigI18nResourcesById.HandleId, 0, ConfigI18nResourcesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigI18nResourcesById.HandleId, ConfigI18nResourcesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			I18nResources rootAsI18nResources = I18nResources.GetRootAsI18nResources(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("I18nResourcesById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigI18nResourcesById.HandleId, ConfigI18nResourcesById.LogPair);
			return new I18nResources?(rootAsI18nResources);
		}

		// Token: 0x04001C85 RID: 7301
		private const string DB = "db_i18nresources.db";

		// Token: 0x04001C86 RID: 7302
		private const string FILE = "i.i18n资源.xlsx";

		// Token: 0x04001C87 RID: 7303
		private const string TABLE = "I18nResources";

		// Token: 0x04001C88 RID: 7304
		private const string COMMAND = "select BinData from `I18nResources` where Id=?";

		// Token: 0x04001C89 RID: 7305
		private const string KEY_PREFIX = "I18nResourcesById";

		// Token: 0x04001C8A RID: 7306
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C8B RID: 7307
		private static int HandleId;
	}
}
