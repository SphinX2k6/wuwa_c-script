using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E0 RID: 1760
	public class ConfigPhotoCollectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x00146868 File Offset: 0x00144A68
		static ConfigPhotoCollectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoCollectionAll.CreateStaticDefaultValue), new Action(ConfigPhotoCollectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00146888 File Offset: 0x00144A88
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoCollectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoCollectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photocollection.db"),
				new ValueTuple<string, object>("文件", "j.技能采集配置.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoCollection`")
			});
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00146907 File Offset: 0x00144B07
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoCollectionAll.LogPair = null;
			ConfigPhotoCollectionAll.HandleId = 0;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00146915 File Offset: 0x00144B15
		public static void Init()
		{
			ConfigPhotoCollectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoCollectionAll.HandleId, "db_photocollection.db", "select BinData from `PhotoCollection`");
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00146930 File Offset: 0x00144B30
		[NullableContext(2)]
		public static IReadOnlyList<PhotoCollection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoCollectionAll.HandleId, ConfigPhotoCollectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoCollection> readOnlyList = (IReadOnlyList<PhotoCollection>)ConfigCommon.GetConfig("PhotoCollectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoCollection> list = new List<PhotoCollection>();
			while (ConfigCommon.Step(ConfigPhotoCollectionAll.HandleId, false, ConfigPhotoCollectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoCollectionAll.HandleId, 0, ConfigPhotoCollectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoCollectionAll.HandleId, ConfigPhotoCollectionAll.LogPair);
					return null;
				}
				PhotoCollection rootAsPhotoCollection = PhotoCollection.GetRootAsPhotoCollection(new ByteBuffer(item2));
				list.Add(rootAsPhotoCollection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoCollectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoCollectionAll.HandleId, ConfigPhotoCollectionAll.LogPair);
			return list;
		}

		// Token: 0x04003006 RID: 12294
		private const string DB = "db_photocollection.db";

		// Token: 0x04003007 RID: 12295
		private const string FILE = "j.技能采集配置.xlsx";

		// Token: 0x04003008 RID: 12296
		private const string TABLE = "PhotoCollection";

		// Token: 0x04003009 RID: 12297
		private const string COMMAND = "select BinData from `PhotoCollection`";

		// Token: 0x0400300A RID: 12298
		private const string KEY_PREFIX = "PhotoCollectionAll";

		// Token: 0x0400300B RID: 12299
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400300C RID: 12300
		private static int HandleId;
	}
}
