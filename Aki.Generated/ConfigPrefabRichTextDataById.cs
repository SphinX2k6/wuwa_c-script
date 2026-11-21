using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076A RID: 1898
	public class ConfigPrefabRichTextDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C8D RID: 11405 RVA: 0x00158B8C File Offset: 0x00156D8C
		static ConfigPrefabRichTextDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabRichTextDataById.CreateStaticDefaultValue), new Action(ConfigPrefabRichTextDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00158BAC File Offset: 0x00156DAC
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

		// Token: 0x06002C8F RID: 11407 RVA: 0x00158C2B File Offset: 0x00156E2B
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabRichTextDataById.LogPair = null;
			ConfigPrefabRichTextDataById.HandleId = 0;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00158C39 File Offset: 0x00156E39
		public static void Init()
		{
			ConfigPrefabRichTextDataById.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabRichTextDataById.HandleId, "db_ui_prefabrichtextdata.db", "select BinData from `PrefabRichTextData` where Id=?");
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x00158C54 File Offset: 0x00156E54
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

		// Token: 0x040033CC RID: 13260
		private const string DB = "db_ui_prefabrichtextdata.db";

		// Token: 0x040033CD RID: 13261
		private const string FILE = "u.UiTextCollect/w.文本库富文本信息.csv";

		// Token: 0x040033CE RID: 13262
		private const string TABLE = "PrefabRichTextData";

		// Token: 0x040033CF RID: 13263
		private const string COMMAND = "select BinData from `PrefabRichTextData` where Id=?";

		// Token: 0x040033D0 RID: 13264
		private const string KEY_PREFIX = "PrefabRichTextDataById";

		// Token: 0x040033D1 RID: 13265
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033D2 RID: 13266
		private static int HandleId;
	}
}
