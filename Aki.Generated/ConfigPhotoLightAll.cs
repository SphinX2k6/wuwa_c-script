using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F7 RID: 1783
	public class ConfigPhotoLightAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029DA RID: 10714 RVA: 0x0014962B File Offset: 0x0014782B
		static ConfigPhotoLightAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoLightAll.CreateStaticDefaultValue), new Action(ConfigPhotoLightAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x0014964C File Offset: 0x0014784C
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

		// Token: 0x060029DC RID: 10716 RVA: 0x001496CB File Offset: 0x001478CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoLightAll.LogPair = null;
			ConfigPhotoLightAll.HandleId = 0;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x001496D9 File Offset: 0x001478D9
		public static void Init()
		{
			ConfigPhotoLightAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoLightAll.HandleId, "db_photonew.db", "select BinData from `PhotoLight`");
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x001496F4 File Offset: 0x001478F4
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

		// Token: 0x040030A7 RID: 12455
		private const string DB = "db_photonew.db";

		// Token: 0x040030A8 RID: 12456
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030A9 RID: 12457
		private const string TABLE = "PhotoLight";

		// Token: 0x040030AA RID: 12458
		private const string COMMAND = "select BinData from `PhotoLight`";

		// Token: 0x040030AB RID: 12459
		private const string KEY_PREFIX = "PhotoLightAll";

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
