using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000188 RID: 392
	public class ConfigCollaborativeContentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000931 RID: 2353 RVA: 0x0009104C File Offset: 0x0008F24C
		static ConfigCollaborativeContentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCollaborativeContentAll.CreateStaticDefaultValue), new Action(ConfigCollaborativeContentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0009106C File Offset: 0x0008F26C
		public static void CreateStaticDefaultValue()
		{
			ConfigCollaborativeContentAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCollaborativeContentAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_collaborativecontent.db"),
				new ValueTuple<string, object>("文件", "l.联动内容.xlsx"),
				new ValueTuple<string, object>("表名", "CollaborativeContent"),
				new ValueTuple<string, object>("语句", "select BinData from `CollaborativeContent`")
			});
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000910EB File Offset: 0x0008F2EB
		public static void ResetStaticDefaultValue()
		{
			ConfigCollaborativeContentAll.LogPair = null;
			ConfigCollaborativeContentAll.HandleId = 0;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000910F9 File Offset: 0x0008F2F9
		public static void Init()
		{
			ConfigCollaborativeContentAll.HandleId = ConfigCommon.InitDataStatement(ConfigCollaborativeContentAll.HandleId, "db_collaborativecontent.db", "select BinData from `CollaborativeContent`");
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00091114 File Offset: 0x0008F314
		[NullableContext(2)]
		public static IReadOnlyList<CollaborativeContent> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCollaborativeContentAll.HandleId, ConfigCollaborativeContentAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CollaborativeContent> readOnlyList = (IReadOnlyList<CollaborativeContent>)ConfigCommon.GetConfig("CollaborativeContentAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CollaborativeContent> list = new List<CollaborativeContent>();
			while (ConfigCommon.Step(ConfigCollaborativeContentAll.HandleId, false, ConfigCollaborativeContentAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCollaborativeContentAll.HandleId, 0, ConfigCollaborativeContentAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCollaborativeContentAll.HandleId, ConfigCollaborativeContentAll.LogPair);
					return null;
				}
				CollaborativeContent rootAsCollaborativeContent = CollaborativeContent.GetRootAsCollaborativeContent(new ByteBuffer(item2));
				list.Add(rootAsCollaborativeContent);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CollaborativeContentAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCollaborativeContentAll.HandleId, ConfigCollaborativeContentAll.LogPair);
			return list;
		}

		// Token: 0x04000A9C RID: 2716
		private const string DB = "db_collaborativecontent.db";

		// Token: 0x04000A9D RID: 2717
		private const string FILE = "l.联动内容.xlsx";

		// Token: 0x04000A9E RID: 2718
		private const string TABLE = "CollaborativeContent";

		// Token: 0x04000A9F RID: 2719
		private const string COMMAND = "select BinData from `CollaborativeContent`";

		// Token: 0x04000AA0 RID: 2720
		private const string KEY_PREFIX = "CollaborativeContentAll";

		// Token: 0x04000AA1 RID: 2721
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AA2 RID: 2722
		private static int HandleId;
	}
}
