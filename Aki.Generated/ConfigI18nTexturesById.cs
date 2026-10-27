using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000419 RID: 1049
	public class ConfigI18nTexturesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600189F RID: 6303 RVA: 0x000E4FB7 File Offset: 0x000E31B7
		static ConfigI18nTexturesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigI18nTexturesById.CreateStaticDefaultValue), new Action(ConfigI18nTexturesById.ResetStaticDefaultValue));
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000E4FD8 File Offset: 0x000E31D8
		public static void CreateStaticDefaultValue()
		{
			ConfigI18nTexturesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigI18nTexturesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_i18nresources.db"),
				new ValueTuple<string, object>("文件", "i.i18n资源.xlsx"),
				new ValueTuple<string, object>("表名", "I18nTextures"),
				new ValueTuple<string, object>("语句", "select BinData from `I18nTextures` where Id=?")
			});
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000E5057 File Offset: 0x000E3257
		public static void ResetStaticDefaultValue()
		{
			ConfigI18nTexturesById.LogPair = null;
			ConfigI18nTexturesById.HandleId = 0;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x000E5065 File Offset: 0x000E3265
		public static void Init()
		{
			ConfigI18nTexturesById.HandleId = ConfigCommon.InitDataStatement(ConfigI18nTexturesById.HandleId, "db_i18nresources.db", "select BinData from `I18nTextures` where Id=?");
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000E5080 File Offset: 0x000E3280
		public static I18nTextures? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigI18nTexturesById.HandleId, ConfigI18nTexturesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("I18nTexturesById#" + p0Id);
				if (configBuffer != null)
				{
					return new I18nTextures?(I18nTextures.GetRootAsI18nTextures(configBuffer));
				}
			}
			ConfigI18nTexturesById.LogPair.Clear();
			ConfigI18nTexturesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigI18nTexturesById.HandleId, 1, p0Id, ConfigI18nTexturesById.LogPair) || ConfigCommon.Step(ConfigI18nTexturesById.HandleId, true, ConfigI18nTexturesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigI18nTexturesById.HandleId, ConfigI18nTexturesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigI18nTexturesById.HandleId, 0, ConfigI18nTexturesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigI18nTexturesById.HandleId, ConfigI18nTexturesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			I18nTextures rootAsI18nTextures = I18nTextures.GetRootAsI18nTextures(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("I18nTexturesById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigI18nTexturesById.HandleId, ConfigI18nTexturesById.LogPair);
			return new I18nTextures?(rootAsI18nTextures);
		}

		// Token: 0x04001C93 RID: 7315
		private const string DB = "db_i18nresources.db";

		// Token: 0x04001C94 RID: 7316
		private const string FILE = "i.i18n资源.xlsx";

		// Token: 0x04001C95 RID: 7317
		private const string TABLE = "I18nTextures";

		// Token: 0x04001C96 RID: 7318
		private const string COMMAND = "select BinData from `I18nTextures` where Id=?";

		// Token: 0x04001C97 RID: 7319
		private const string KEY_PREFIX = "I18nTexturesById";

		// Token: 0x04001C98 RID: 7320
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C99 RID: 7321
		private static int HandleId;
	}
}
