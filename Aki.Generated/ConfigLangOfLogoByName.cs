using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C7 RID: 1223
	public class ConfigLangOfLogoByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CB5 RID: 7349 RVA: 0x000FB6B1 File Offset: 0x000F98B1
		static ConfigLangOfLogoByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLangOfLogoByName.CreateStaticDefaultValue), new Action(ConfigLangOfLogoByName.ResetStaticDefaultValue));
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000FB6D0 File Offset: 0x000F98D0
		public static void CreateStaticDefaultValue()
		{
			ConfigLangOfLogoByName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLangOfLogoByName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_langoflogo.db"),
				new ValueTuple<string, object>("文件", "l.Logo多语言表.xlsx"),
				new ValueTuple<string, object>("表名", "LangOfLogo"),
				new ValueTuple<string, object>("语句", "select BinData from `LangOfLogo` where Name=?")
			});
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000FB74F File Offset: 0x000F994F
		public static void ResetStaticDefaultValue()
		{
			ConfigLangOfLogoByName.LogPair = null;
			ConfigLangOfLogoByName.HandleId = 0;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000FB75D File Offset: 0x000F995D
		public static void Init()
		{
			ConfigLangOfLogoByName.HandleId = ConfigCommon.InitDataStatement(ConfigLangOfLogoByName.HandleId, "db_langoflogo.db", "select BinData from `LangOfLogo` where Name=?");
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000FB778 File Offset: 0x000F9978
		public static LangOfLogo? GetConfig(string p0Name, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLangOfLogoByName.HandleId, ConfigLangOfLogoByName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("LangOfLogoByName#" + p0Name);
				if (configBuffer != null)
				{
					return new LangOfLogo?(LangOfLogo.GetRootAsLangOfLogo(configBuffer));
				}
			}
			ConfigLangOfLogoByName.LogPair.Clear();
			ConfigLangOfLogoByName.LogPair.Add(new ValueTuple<string, object>("Name", p0Name));
			if (!ConfigCommon.BindString(ConfigLangOfLogoByName.HandleId, 1, p0Name, ConfigLangOfLogoByName.LogPair) || ConfigCommon.Step(ConfigLangOfLogoByName.HandleId, true, ConfigLangOfLogoByName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLangOfLogoByName.HandleId, ConfigLangOfLogoByName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLangOfLogoByName.HandleId, 0, ConfigLangOfLogoByName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLangOfLogoByName.HandleId, ConfigLangOfLogoByName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LangOfLogo rootAsLangOfLogo = LangOfLogo.GetRootAsLangOfLogo(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("LangOfLogoByName#" + p0Name, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLangOfLogoByName.HandleId, ConfigLangOfLogoByName.LogPair);
			return new LangOfLogo?(rootAsLangOfLogo);
		}

		// Token: 0x04002155 RID: 8533
		private const string DB = "db_langoflogo.db";

		// Token: 0x04002156 RID: 8534
		private const string FILE = "l.Logo多语言表.xlsx";

		// Token: 0x04002157 RID: 8535
		private const string TABLE = "LangOfLogo";

		// Token: 0x04002158 RID: 8536
		private const string COMMAND = "select BinData from `LangOfLogo` where Name=?";

		// Token: 0x04002159 RID: 8537
		private const string KEY_PREFIX = "LangOfLogoByName";

		// Token: 0x0400215A RID: 8538
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400215B RID: 8539
		private static int HandleId;
	}
}
