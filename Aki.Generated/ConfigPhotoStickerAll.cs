using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F7 RID: 1783
	public class ConfigPhotoStickerAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029DA RID: 10714 RVA: 0x00146030 File Offset: 0x00144230
		static ConfigPhotoStickerAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoStickerAll.CreateStaticDefaultValue), new Action(ConfigPhotoStickerAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00146050 File Offset: 0x00144250
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoStickerAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoStickerAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSticker"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSticker`")
			});
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x001460CF File Offset: 0x001442CF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoStickerAll.LogPair = null;
			ConfigPhotoStickerAll.HandleId = 0;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x001460DD File Offset: 0x001442DD
		public static void Init()
		{
			ConfigPhotoStickerAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoStickerAll.HandleId, "db_photonew.db", "select BinData from `PhotoSticker`");
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x001460F8 File Offset: 0x001442F8
		[NullableContext(2)]
		public static IReadOnlyList<PhotoSticker> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoStickerAll.HandleId, ConfigPhotoStickerAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoSticker> readOnlyList = (IReadOnlyList<PhotoSticker>)ConfigCommon.GetConfig("PhotoStickerAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoSticker> list = new List<PhotoSticker>();
			while (ConfigCommon.Step(ConfigPhotoStickerAll.HandleId, false, ConfigPhotoStickerAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoStickerAll.HandleId, 0, ConfigPhotoStickerAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoStickerAll.HandleId, ConfigPhotoStickerAll.LogPair);
					return null;
				}
				PhotoSticker rootAsPhotoSticker = PhotoSticker.GetRootAsPhotoSticker(new ByteBuffer(item2));
				list.Add(rootAsPhotoSticker);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoStickerAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoStickerAll.HandleId, ConfigPhotoStickerAll.LogPair);
			return list;
		}

		// Token: 0x040030A7 RID: 12455
		private const string DB = "db_photonew.db";

		// Token: 0x040030A8 RID: 12456
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030A9 RID: 12457
		private const string TABLE = "PhotoSticker";

		// Token: 0x040030AA RID: 12458
		private const string COMMAND = "select BinData from `PhotoSticker`";

		// Token: 0x040030AB RID: 12459
		private const string KEY_PREFIX = "PhotoStickerAll";

		// Token: 0x040030AC RID: 12460
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030AD RID: 12461
		private static int HandleId;
	}
}
