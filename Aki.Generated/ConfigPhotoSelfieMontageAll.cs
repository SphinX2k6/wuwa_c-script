using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F1 RID: 1777
	public class ConfigPhotoSelfieMontageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029B6 RID: 10678 RVA: 0x001453F9 File Offset: 0x001435F9
		static ConfigPhotoSelfieMontageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSelfieMontageAll.CreateStaticDefaultValue), new Action(ConfigPhotoSelfieMontageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00145418 File Offset: 0x00143618
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

		// Token: 0x060029B8 RID: 10680 RVA: 0x00145497 File Offset: 0x00143697
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageAll.LogPair = null;
			ConfigPhotoSelfieMontageAll.HandleId = 0;
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x001454A5 File Offset: 0x001436A5
		public static void Init()
		{
			ConfigPhotoSelfieMontageAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSelfieMontageAll.HandleId, "db_photonew.db", "select BinData from `PhotoSelfieMontage`");
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x001454C0 File Offset: 0x001436C0
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

		// Token: 0x0400307D RID: 12413
		private const string DB = "db_photonew.db";

		// Token: 0x0400307E RID: 12414
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400307F RID: 12415
		private const string TABLE = "PhotoSelfieMontage";

		// Token: 0x04003080 RID: 12416
		private const string COMMAND = "select BinData from `PhotoSelfieMontage`";

		// Token: 0x04003081 RID: 12417
		private const string KEY_PREFIX = "PhotoSelfieMontageAll";

		// Token: 0x04003082 RID: 12418
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003083 RID: 12419
		private static int HandleId;
	}
}
