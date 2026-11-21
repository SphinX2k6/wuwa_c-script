using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000709 RID: 1801
	public class ConfigPhotoSelfieMontageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x0014BE75 File Offset: 0x0014A075
		static ConfigPhotoSelfieMontageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSelfieMontageAll.CreateStaticDefaultValue), new Action(ConfigPhotoSelfieMontageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x0014BE94 File Offset: 0x0014A094
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSelfieMontageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSelfieMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSelfieMontage`")
			});
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x0014BF13 File Offset: 0x0014A113
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageAll.LogPair = null;
			ConfigPhotoSelfieMontageAll.HandleId = 0;
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x0014BF21 File Offset: 0x0014A121
		public static void Init()
		{
			ConfigPhotoSelfieMontageAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSelfieMontageAll.HandleId, "db_photonew.db", "select BinData from `PhotoSelfieMontage`");
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x0014BF3C File Offset: 0x0014A13C
		[NullableContext(2)]
		public static IReadOnlyList<PhotoSelfieMontage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSelfieMontageAll.HandleId, ConfigPhotoSelfieMontageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoSelfieMontage> readOnlyList = (IReadOnlyList<PhotoSelfieMontage>)ConfigCommon.GetConfig("PhotoSelfieMontageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoSelfieMontage> list = new List<PhotoSelfieMontage>();
			while (ConfigCommon.Step(ConfigPhotoSelfieMontageAll.HandleId, false, ConfigPhotoSelfieMontageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSelfieMontageAll.HandleId, 0, ConfigPhotoSelfieMontageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoSelfieMontageAll.HandleId, ConfigPhotoSelfieMontageAll.LogPair);
					return null;
				}
				PhotoSelfieMontage rootAsPhotoSelfieMontage = PhotoSelfieMontage.GetRootAsPhotoSelfieMontage(new ByteBuffer(item2));
				list.Add(rootAsPhotoSelfieMontage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoSelfieMontageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoSelfieMontageAll.HandleId, ConfigPhotoSelfieMontageAll.LogPair);
			return list;
		}

		// Token: 0x04003125 RID: 12581
		private const string DB = "db_photonew.db";

		// Token: 0x04003126 RID: 12582
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003127 RID: 12583
		private const string TABLE = "PhotoSelfieMontage";

		// Token: 0x04003128 RID: 12584
		private const string COMMAND = "select BinData from `PhotoSelfieMontage`";

		// Token: 0x04003129 RID: 12585
		private const string KEY_PREFIX = "PhotoSelfieMontageAll";

		// Token: 0x0400312A RID: 12586
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400312B RID: 12587
		private static int HandleId;
	}
}
