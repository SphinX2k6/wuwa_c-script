using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C8 RID: 1736
	public class ConfigPhotoCollectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028C0 RID: 10432 RVA: 0x0013FDEC File Offset: 0x0013DFEC
		static ConfigPhotoCollectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoCollectionAll.CreateStaticDefaultValue), new Action(ConfigPhotoCollectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0013FE0C File Offset: 0x0013E00C
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

		// Token: 0x060028C2 RID: 10434 RVA: 0x0013FE8B File Offset: 0x0013E08B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoCollectionAll.LogPair = null;
			ConfigPhotoCollectionAll.HandleId = 0;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0013FE99 File Offset: 0x0013E099
		public static void Init()
		{
			ConfigPhotoCollectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoCollectionAll.HandleId, "db_photocollection.db", "select BinData from `PhotoCollection`");
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0013FEB4 File Offset: 0x0013E0B4
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

		// Token: 0x04002F5E RID: 12126
		private const string DB = "db_photocollection.db";

		// Token: 0x04002F5F RID: 12127
		private const string FILE = "j.技能采集配置.xlsx";

		// Token: 0x04002F60 RID: 12128
		private const string TABLE = "PhotoCollection";

		// Token: 0x04002F61 RID: 12129
		private const string COMMAND = "select BinData from `PhotoCollection`";

		// Token: 0x04002F62 RID: 12130
		private const string KEY_PREFIX = "PhotoCollectionAll";

		// Token: 0x04002F63 RID: 12131
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F64 RID: 12132
		private static int HandleId;
	}
}
