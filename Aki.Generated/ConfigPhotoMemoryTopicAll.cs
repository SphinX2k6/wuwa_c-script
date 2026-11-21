using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FC RID: 1788
	public class ConfigPhotoMemoryTopicAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029F8 RID: 10744 RVA: 0x0014A0CF File Offset: 0x001482CF
		static ConfigPhotoMemoryTopicAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryTopicAll.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryTopicAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0014A0F0 File Offset: 0x001482F0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMemoryTopicAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMemoryTopicAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fragmentmemory.db"),
				new ValueTuple<string, object>("文件", "j.记忆手册.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMemoryTopic"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMemoryTopic`")
			});
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0014A16F File Offset: 0x0014836F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryTopicAll.LogPair = null;
			ConfigPhotoMemoryTopicAll.HandleId = 0;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x0014A17D File Offset: 0x0014837D
		public static void Init()
		{
			ConfigPhotoMemoryTopicAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryTopicAll.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryTopic`");
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x0014A198 File Offset: 0x00148398
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMemoryTopic> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMemoryTopicAll.HandleId, ConfigPhotoMemoryTopicAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoMemoryTopic> readOnlyList = (IReadOnlyList<PhotoMemoryTopic>)ConfigCommon.GetConfig("PhotoMemoryTopicAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoMemoryTopic> list = new List<PhotoMemoryTopic>();
			while (ConfigCommon.Step(ConfigPhotoMemoryTopicAll.HandleId, false, ConfigPhotoMemoryTopicAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMemoryTopicAll.HandleId, 0, ConfigPhotoMemoryTopicAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoMemoryTopicAll.HandleId, ConfigPhotoMemoryTopicAll.LogPair);
					return null;
				}
				PhotoMemoryTopic rootAsPhotoMemoryTopic = PhotoMemoryTopic.GetRootAsPhotoMemoryTopic(new ByteBuffer(item2));
				list.Add(rootAsPhotoMemoryTopic);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoMemoryTopicAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoMemoryTopicAll.HandleId, ConfigPhotoMemoryTopicAll.LogPair);
			return list;
		}

		// Token: 0x040030CA RID: 12490
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x040030CB RID: 12491
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x040030CC RID: 12492
		private const string TABLE = "PhotoMemoryTopic";

		// Token: 0x040030CD RID: 12493
		private const string COMMAND = "select BinData from `PhotoMemoryTopic`";

		// Token: 0x040030CE RID: 12494
		private const string KEY_PREFIX = "PhotoMemoryTopicAll";

		// Token: 0x040030CF RID: 12495
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030D0 RID: 12496
		private static int HandleId;
	}
}
