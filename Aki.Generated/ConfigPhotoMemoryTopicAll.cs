using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E4 RID: 1764
	public class ConfigPhotoMemoryTopicAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x00143653 File Offset: 0x00141853
		static ConfigPhotoMemoryTopicAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryTopicAll.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryTopicAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00143674 File Offset: 0x00141874
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

		// Token: 0x0600296A RID: 10602 RVA: 0x001436F3 File Offset: 0x001418F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryTopicAll.LogPair = null;
			ConfigPhotoMemoryTopicAll.HandleId = 0;
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00143701 File Offset: 0x00141901
		public static void Init()
		{
			ConfigPhotoMemoryTopicAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryTopicAll.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryTopic`");
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0014371C File Offset: 0x0014191C
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

		// Token: 0x04003022 RID: 12322
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x04003023 RID: 12323
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x04003024 RID: 12324
		private const string TABLE = "PhotoMemoryTopic";

		// Token: 0x04003025 RID: 12325
		private const string COMMAND = "select BinData from `PhotoMemoryTopic`";

		// Token: 0x04003026 RID: 12326
		private const string KEY_PREFIX = "PhotoMemoryTopicAll";

		// Token: 0x04003027 RID: 12327
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003028 RID: 12328
		private static int HandleId;
	}
}
