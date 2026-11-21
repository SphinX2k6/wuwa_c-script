using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F2 RID: 1778
	public class ConfigPhotoFrameAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029BC RID: 10684 RVA: 0x00148C3C File Offset: 0x00146E3C
		static ConfigPhotoFrameAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFrameAll.CreateStaticDefaultValue), new Action(ConfigPhotoFrameAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00148C5C File Offset: 0x00146E5C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFrameAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFrameAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFrame"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFrame`")
			});
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00148CDB File Offset: 0x00146EDB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFrameAll.LogPair = null;
			ConfigPhotoFrameAll.HandleId = 0;
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00148CE9 File Offset: 0x00146EE9
		public static void Init()
		{
			ConfigPhotoFrameAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFrameAll.HandleId, "db_photonew.db", "select BinData from `PhotoFrame`");
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00148D04 File Offset: 0x00146F04
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFrame> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFrameAll.HandleId, ConfigPhotoFrameAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoFrame> readOnlyList = (IReadOnlyList<PhotoFrame>)ConfigCommon.GetConfig("PhotoFrameAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoFrame> list = new List<PhotoFrame>();
			while (ConfigCommon.Step(ConfigPhotoFrameAll.HandleId, false, ConfigPhotoFrameAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFrameAll.HandleId, 0, ConfigPhotoFrameAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFrameAll.HandleId, ConfigPhotoFrameAll.LogPair);
					return null;
				}
				PhotoFrame rootAsPhotoFrame = PhotoFrame.GetRootAsPhotoFrame(new ByteBuffer(item2));
				list.Add(rootAsPhotoFrame);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoFrameAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFrameAll.HandleId, ConfigPhotoFrameAll.LogPair);
			return list;
		}

		// Token: 0x04003084 RID: 12420
		private const string DB = "db_photonew.db";

		// Token: 0x04003085 RID: 12421
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003086 RID: 12422
		private const string TABLE = "PhotoFrame";

		// Token: 0x04003087 RID: 12423
		private const string COMMAND = "select BinData from `PhotoFrame`";

		// Token: 0x04003088 RID: 12424
		private const string KEY_PREFIX = "PhotoFrameAll";

		// Token: 0x04003089 RID: 12425
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400308A RID: 12426
		private static int HandleId;
	}
}
