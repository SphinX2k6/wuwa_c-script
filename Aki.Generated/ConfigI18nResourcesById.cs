using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042D RID: 1069
	public class ConfigI18nResourcesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001917 RID: 6423 RVA: 0x000EB37F File Offset: 0x000E957F
		static ConfigI18nResourcesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigI18nResourcesById.CreateStaticDefaultValue), new Action(ConfigI18nResourcesById.ResetStaticDefaultValue));
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000EB3A0 File Offset: 0x000E95A0
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

		// Token: 0x06001919 RID: 6425 RVA: 0x000EB41F File Offset: 0x000E961F
		public static void ResetStaticDefaultValue()
		{
			ConfigI18nResourcesById.LogPair = null;
			ConfigI18nResourcesById.HandleId = 0;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000EB42D File Offset: 0x000E962D
		public static void Init()
		{
			ConfigI18nResourcesById.HandleId = ConfigCommon.InitDataStatement(ConfigI18nResourcesById.HandleId, "db_i18nresources.db", "select BinData from `I18nResources` where Id=?");
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000EB448 File Offset: 0x000E9648
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

		// Token: 0x04001D1F RID: 7455
		private const string DB = "db_i18nresources.db";

		// Token: 0x04001D20 RID: 7456
		private const string FILE = "i.i18n资源.xlsx";

		// Token: 0x04001D21 RID: 7457
		private const string TABLE = "I18nResources";

		// Token: 0x04001D22 RID: 7458
		private const string COMMAND = "select BinData from `I18nResources` where Id=?";

		// Token: 0x04001D23 RID: 7459
		private const string KEY_PREFIX = "I18nResourcesById";

		// Token: 0x04001D24 RID: 7460
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D25 RID: 7461
		private static int HandleId;
	}
}
