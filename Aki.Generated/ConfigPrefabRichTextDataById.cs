using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000752 RID: 1874
	public class ConfigPrefabRichTextDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BFD RID: 11261 RVA: 0x00152110 File Offset: 0x00150310
		static ConfigPrefabRichTextDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabRichTextDataById.CreateStaticDefaultValue), new Action(ConfigPrefabRichTextDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x00152130 File Offset: 0x00150330
		public static void CreateStaticDefaultValue()
		{
			ConfigPrefabRichTextDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPrefabRichTextDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui_prefabrichtextdata.db"),
				new ValueTuple<string, object>("文件", "u.UiTextCollect/w.文本库富文本信息.csv"),
				new ValueTuple<string, object>("表名", "PrefabRichTextData"),
				new ValueTuple<string, object>("语句", "select BinData from `PrefabRichTextData` where Id=?")
			});
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x001521AF File Offset: 0x001503AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabRichTextDataById.LogPair = null;
			ConfigPrefabRichTextDataById.HandleId = 0;
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x001521BD File Offset: 0x001503BD
		public static void Init()
		{
			ConfigPrefabRichTextDataById.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabRichTextDataById.HandleId, "db_ui_prefabrichtextdata.db", "select BinData from `PrefabRichTextData` where Id=?");
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x001521D8 File Offset: 0x001503D8
		public static PrefabRichTextData? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPrefabRichTextDataById.HandleId, ConfigPrefabRichTextDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("PrefabRichTextDataById#" + p0Id);
				if (configBuffer != null)
				{
					return new PrefabRichTextData?(PrefabRichTextData.GetRootAsPrefabRichTextData(configBuffer));
				}
			}
			ConfigPrefabRichTextDataById.LogPair.Clear();
			ConfigPrefabRichTextDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigPrefabRichTextDataById.HandleId, 1, p0Id, ConfigPrefabRichTextDataById.LogPair) || ConfigCommon.Step(ConfigPrefabRichTextDataById.HandleId, false, ConfigPrefabRichTextDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPrefabRichTextDataById.HandleId, ConfigPrefabRichTextDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPrefabRichTextDataById.HandleId, 0, ConfigPrefabRichTextDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPrefabRichTextDataById.HandleId, ConfigPrefabRichTextDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PrefabRichTextData rootAsPrefabRichTextData = PrefabRichTextData.GetRootAsPrefabRichTextData(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("PrefabRichTextDataById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPrefabRichTextDataById.HandleId, ConfigPrefabRichTextDataById.LogPair);
			return new PrefabRichTextData?(rootAsPrefabRichTextData);
		}

		// Token: 0x04003324 RID: 13092
		private const string DB = "db_ui_prefabrichtextdata.db";

		// Token: 0x04003325 RID: 13093
		private const string FILE = "u.UiTextCollect/w.文本库富文本信息.csv";

		// Token: 0x04003326 RID: 13094
		private const string TABLE = "PrefabRichTextData";

		// Token: 0x04003327 RID: 13095
		private const string COMMAND = "select BinData from `PrefabRichTextData` where Id=?";

		// Token: 0x04003328 RID: 13096
		private const string KEY_PREFIX = "PrefabRichTextDataById";

		// Token: 0x04003329 RID: 13097
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400332A RID: 13098
		private static int HandleId;
	}
}
