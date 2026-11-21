using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070F RID: 1807
	public class ConfigPhotoStickerAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A6A RID: 10858 RVA: 0x0014CAAC File Offset: 0x0014ACAC
		static ConfigPhotoStickerAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoStickerAll.CreateStaticDefaultValue), new Action(ConfigPhotoStickerAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x0014CACC File Offset: 0x0014ACCC
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

		// Token: 0x06002A6C RID: 10860 RVA: 0x0014CB4B File Offset: 0x0014AD4B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoStickerAll.LogPair = null;
			ConfigPhotoStickerAll.HandleId = 0;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0014CB59 File Offset: 0x0014AD59
		public static void Init()
		{
			ConfigPhotoStickerAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoStickerAll.HandleId, "db_photonew.db", "select BinData from `PhotoSticker`");
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x0014CB74 File Offset: 0x0014AD74
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

		// Token: 0x0400314F RID: 12623
		private const string DB = "db_photonew.db";

		// Token: 0x04003150 RID: 12624
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003151 RID: 12625
		private const string TABLE = "PhotoSticker";

		// Token: 0x04003152 RID: 12626
		private const string COMMAND = "select BinData from `PhotoSticker`";

		// Token: 0x04003153 RID: 12627
		private const string KEY_PREFIX = "PhotoStickerAll";

		// Token: 0x04003154 RID: 12628
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003155 RID: 12629
		private static int HandleId;
	}
}
