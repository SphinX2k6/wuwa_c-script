using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DF RID: 1759
	public class ConfigPhotoLightAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600294A RID: 10570 RVA: 0x00142BAF File Offset: 0x00140DAF
		static ConfigPhotoLightAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoLightAll.CreateStaticDefaultValue), new Action(ConfigPhotoLightAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00142BD0 File Offset: 0x00140DD0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoLightAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoLightAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoLight"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoLight`")
			});
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00142C4F File Offset: 0x00140E4F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoLightAll.LogPair = null;
			ConfigPhotoLightAll.HandleId = 0;
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00142C5D File Offset: 0x00140E5D
		public static void Init()
		{
			ConfigPhotoLightAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoLightAll.HandleId, "db_photonew.db", "select BinData from `PhotoLight`");
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00142C78 File Offset: 0x00140E78
		[NullableContext(2)]
		public static IReadOnlyList<PhotoLight> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoLightAll.HandleId, ConfigPhotoLightAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoLight> readOnlyList = (IReadOnlyList<PhotoLight>)ConfigCommon.GetConfig("PhotoLightAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoLight> list = new List<PhotoLight>();
			while (ConfigCommon.Step(ConfigPhotoLightAll.HandleId, false, ConfigPhotoLightAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoLightAll.HandleId, 0, ConfigPhotoLightAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoLightAll.HandleId, ConfigPhotoLightAll.LogPair);
					return null;
				}
				PhotoLight rootAsPhotoLight = PhotoLight.GetRootAsPhotoLight(new ByteBuffer(item2));
				list.Add(rootAsPhotoLight);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoLightAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoLightAll.HandleId, ConfigPhotoLightAll.LogPair);
			return list;
		}

		// Token: 0x04002FFF RID: 12287
		private const string DB = "db_photonew.db";

		// Token: 0x04003000 RID: 12288
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003001 RID: 12289
		private const string TABLE = "PhotoLight";

		// Token: 0x04003002 RID: 12290
		private const string COMMAND = "select BinData from `PhotoLight`";

		// Token: 0x04003003 RID: 12291
		private const string KEY_PREFIX = "PhotoLightAll";

		// Token: 0x04003004 RID: 12292
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003005 RID: 12293
		private static int HandleId;
	}
}
