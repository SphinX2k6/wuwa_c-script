using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000418 RID: 1048
	public class ConfigI18nTexturesAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001899 RID: 6297 RVA: 0x000E4E25 File Offset: 0x000E3025
		static ConfigI18nTexturesAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigI18nTexturesAll.CreateStaticDefaultValue), new Action(ConfigI18nTexturesAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000E4E44 File Offset: 0x000E3044
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

		// Token: 0x0600189B RID: 6299 RVA: 0x000E4EC3 File Offset: 0x000E30C3
		public static void ResetStaticDefaultValue()
		{
			ConfigI18nTexturesAll.LogPair = null;
			ConfigI18nTexturesAll.HandleId = 0;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000E4ED1 File Offset: 0x000E30D1
		public static void Init()
		{
			ConfigI18nTexturesAll.HandleId = ConfigCommon.InitDataStatement(ConfigI18nTexturesAll.HandleId, "db_i18nresources.db", "select BinData from `I18nTextures`");
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000E4EEC File Offset: 0x000E30EC
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

		// Token: 0x04001C8C RID: 7308
		private const string DB = "db_i18nresources.db";

		// Token: 0x04001C8D RID: 7309
		private const string FILE = "i.i18n资源.xlsx";

		// Token: 0x04001C8E RID: 7310
		private const string TABLE = "I18nTextures";

		// Token: 0x04001C8F RID: 7311
		private const string COMMAND = "select BinData from `I18nTextures`";

		// Token: 0x04001C90 RID: 7312
		private const string KEY_PREFIX = "I18nTexturesAll";

		// Token: 0x04001C91 RID: 7313
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C92 RID: 7314
		private static int HandleId;
	}
}
