using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042E RID: 1070
	public class ConfigI18nTexturesAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600191D RID: 6429 RVA: 0x000EB579 File Offset: 0x000E9779
		static ConfigI18nTexturesAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigI18nTexturesAll.CreateStaticDefaultValue), new Action(ConfigI18nTexturesAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000EB598 File Offset: 0x000E9798
		public static void CreateStaticDefaultValue()
		{
			ConfigI18nTexturesAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigI18nTexturesAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_i18nresources.db"),
				new ValueTuple<string, object>("文件", "i.i18n资源.xlsx"),
				new ValueTuple<string, object>("表名", "I18nTextures"),
				new ValueTuple<string, object>("语句", "select BinData from `I18nTextures`")
			});
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x000EB617 File Offset: 0x000E9817
		public static void ResetStaticDefaultValue()
		{
			ConfigI18nTexturesAll.LogPair = null;
			ConfigI18nTexturesAll.HandleId = 0;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000EB625 File Offset: 0x000E9825
		public static void Init()
		{
			ConfigI18nTexturesAll.HandleId = ConfigCommon.InitDataStatement(ConfigI18nTexturesAll.HandleId, "db_i18nresources.db", "select BinData from `I18nTextures`");
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000EB640 File Offset: 0x000E9840
		[NullableContext(2)]
		public static IReadOnlyList<I18nTextures> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigI18nTexturesAll.HandleId, ConfigI18nTexturesAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<I18nTextures> readOnlyList = (IReadOnlyList<I18nTextures>)ConfigCommon.GetConfig("I18nTexturesAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<I18nTextures> list = new List<I18nTextures>();
			while (ConfigCommon.Step(ConfigI18nTexturesAll.HandleId, false, ConfigI18nTexturesAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigI18nTexturesAll.HandleId, 0, ConfigI18nTexturesAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigI18nTexturesAll.HandleId, ConfigI18nTexturesAll.LogPair);
					return null;
				}
				I18nTextures rootAsI18nTextures = I18nTextures.GetRootAsI18nTextures(new ByteBuffer(item2));
				list.Add(rootAsI18nTextures);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("I18nTexturesAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigI18nTexturesAll.HandleId, ConfigI18nTexturesAll.LogPair);
			return list;
		}

		// Token: 0x04001D26 RID: 7462
		private const string DB = "db_i18nresources.db";

		// Token: 0x04001D27 RID: 7463
		private const string FILE = "i.i18n资源.xlsx";

		// Token: 0x04001D28 RID: 7464
		private const string TABLE = "I18nTextures";

		// Token: 0x04001D29 RID: 7465
		private const string COMMAND = "select BinData from `I18nTextures`";

		// Token: 0x04001D2A RID: 7466
		private const string KEY_PREFIX = "I18nTexturesAll";

		// Token: 0x04001D2B RID: 7467
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D2C RID: 7468
		private static int HandleId;
	}
}
