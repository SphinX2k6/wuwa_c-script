using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DC RID: 1244
	public class ConfigLangImageResourceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D33 RID: 7475 RVA: 0x00101C0C File Offset: 0x000FFE0C
		static ConfigLangImageResourceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLangImageResourceById.CreateStaticDefaultValue), new Action(ConfigLangImageResourceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00101C2C File Offset: 0x000FFE2C
		public static void CreateStaticDefaultValue()
		{
			ConfigLangImageResourceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLangImageResourceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_langimage.db"),
				new ValueTuple<string, object>("文件", "d.多语言图片资源.xlsx"),
				new ValueTuple<string, object>("表名", "LangImageResource"),
				new ValueTuple<string, object>("语句", "select BinData from `LangImageResource` where Id=?")
			});
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00101CAB File Offset: 0x000FFEAB
		public static void ResetStaticDefaultValue()
		{
			ConfigLangImageResourceById.LogPair = null;
			ConfigLangImageResourceById.HandleId = 0;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x00101CB9 File Offset: 0x000FFEB9
		public static void Init()
		{
			ConfigLangImageResourceById.HandleId = ConfigCommon.InitDataStatement(ConfigLangImageResourceById.HandleId, "db_langimage.db", "select BinData from `LangImageResource` where Id=?");
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00101CD4 File Offset: 0x000FFED4
		public static LangImageResource? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("LangImageResourceById#" + p0Id);
				if (configBuffer != null)
				{
					return new LangImageResource?(LangImageResource.GetRootAsLangImageResource(configBuffer));
				}
			}
			ConfigLangImageResourceById.LogPair.Clear();
			ConfigLangImageResourceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigLangImageResourceById.HandleId, 1, p0Id, ConfigLangImageResourceById.LogPair) || ConfigCommon.Step(ConfigLangImageResourceById.HandleId, true, ConfigLangImageResourceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLangImageResourceById.HandleId, 0, ConfigLangImageResourceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LangImageResource rootAsLangImageResource = LangImageResource.GetRootAsLangImageResource(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("LangImageResourceById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair);
			return new LangImageResource?(rootAsLangImageResource);
		}

		// Token: 0x040021E8 RID: 8680
		private const string DB = "db_langimage.db";

		// Token: 0x040021E9 RID: 8681
		private const string FILE = "d.多语言图片资源.xlsx";

		// Token: 0x040021EA RID: 8682
		private const string TABLE = "LangImageResource";

		// Token: 0x040021EB RID: 8683
		private const string COMMAND = "select BinData from `LangImageResource` where Id=?";

		// Token: 0x040021EC RID: 8684
		private const string KEY_PREFIX = "LangImageResourceById";

		// Token: 0x040021ED RID: 8685
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021EE RID: 8686
		private static int HandleId;
	}
}
