using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DA RID: 1754
	public class ConfigPhotoFrameAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600292C RID: 10540 RVA: 0x001421C0 File Offset: 0x001403C0
		static ConfigPhotoFrameAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFrameAll.CreateStaticDefaultValue), new Action(ConfigPhotoFrameAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x001421E0 File Offset: 0x001403E0
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

		// Token: 0x0600292E RID: 10542 RVA: 0x0014225F File Offset: 0x0014045F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFrameAll.LogPair = null;
			ConfigPhotoFrameAll.HandleId = 0;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0014226D File Offset: 0x0014046D
		public static void Init()
		{
			ConfigPhotoFrameAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFrameAll.HandleId, "db_photonew.db", "select BinData from `PhotoFrame`");
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00142288 File Offset: 0x00140488
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

		// Token: 0x04002FDC RID: 12252
		private const string DB = "db_photonew.db";

		// Token: 0x04002FDD RID: 12253
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002FDE RID: 12254
		private const string TABLE = "PhotoFrame";

		// Token: 0x04002FDF RID: 12255
		private const string COMMAND = "select BinData from `PhotoFrame`";

		// Token: 0x04002FE0 RID: 12256
		private const string KEY_PREFIX = "PhotoFrameAll";

		// Token: 0x04002FE1 RID: 12257
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FE2 RID: 12258
		private static int HandleId;
	}
}
