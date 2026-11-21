using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DD RID: 1245
	public class ConfigLangOfLogoByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D39 RID: 7481 RVA: 0x00101E05 File Offset: 0x00100005
		static ConfigLangOfLogoByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLangOfLogoByName.CreateStaticDefaultValue), new Action(ConfigLangOfLogoByName.ResetStaticDefaultValue));
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00101E24 File Offset: 0x00100024
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

		// Token: 0x06001D3B RID: 7483 RVA: 0x00101EA3 File Offset: 0x001000A3
		public static void ResetStaticDefaultValue()
		{
			ConfigLangOfLogoByName.LogPair = null;
			ConfigLangOfLogoByName.HandleId = 0;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00101EB1 File Offset: 0x001000B1
		public static void Init()
		{
			ConfigLangOfLogoByName.HandleId = ConfigCommon.InitDataStatement(ConfigLangOfLogoByName.HandleId, "db_langoflogo.db", "select BinData from `LangOfLogo` where Name=?");
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00101ECC File Offset: 0x001000CC
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

		// Token: 0x040021EF RID: 8687
		private const string DB = "db_langoflogo.db";

		// Token: 0x040021F0 RID: 8688
		private const string FILE = "l.Logo多语言表.xlsx";

		// Token: 0x040021F1 RID: 8689
		private const string TABLE = "LangOfLogo";

		// Token: 0x040021F2 RID: 8690
		private const string COMMAND = "select BinData from `LangOfLogo` where Name=?";

		// Token: 0x040021F3 RID: 8691
		private const string KEY_PREFIX = "LangOfLogoByName";

		// Token: 0x040021F4 RID: 8692
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021F5 RID: 8693
		private static int HandleId;
	}
}
