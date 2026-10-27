using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E6 RID: 1766
	public class ConfigPhotoModeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002974 RID: 10612 RVA: 0x00143A30 File Offset: 0x00141C30
		static ConfigPhotoModeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoModeAll.CreateStaticDefaultValue), new Action(ConfigPhotoModeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00143A50 File Offset: 0x00141C50
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoModeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoModeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMode"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMode`")
			});
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00143ACF File Offset: 0x00141CCF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoModeAll.LogPair = null;
			ConfigPhotoModeAll.HandleId = 0;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00143ADD File Offset: 0x00141CDD
		public static void Init()
		{
			ConfigPhotoModeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoModeAll.HandleId, "db_photonew.db", "select BinData from `PhotoMode`");
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00143AF8 File Offset: 0x00141CF8
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMode> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoModeAll.HandleId, ConfigPhotoModeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoMode> readOnlyList = (IReadOnlyList<PhotoMode>)ConfigCommon.GetConfig("PhotoModeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoMode> list = new List<PhotoMode>();
			while (ConfigCommon.Step(ConfigPhotoModeAll.HandleId, false, ConfigPhotoModeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoModeAll.HandleId, 0, ConfigPhotoModeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoModeAll.HandleId, ConfigPhotoModeAll.LogPair);
					return null;
				}
				PhotoMode rootAsPhotoMode = PhotoMode.GetRootAsPhotoMode(new ByteBuffer(item2));
				list.Add(rootAsPhotoMode);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoModeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoModeAll.HandleId, ConfigPhotoModeAll.LogPair);
			return list;
		}

		// Token: 0x04003030 RID: 12336
		private const string DB = "db_photonew.db";

		// Token: 0x04003031 RID: 12337
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003032 RID: 12338
		private const string TABLE = "PhotoMode";

		// Token: 0x04003033 RID: 12339
		private const string COMMAND = "select BinData from `PhotoMode`";

		// Token: 0x04003034 RID: 12340
		private const string KEY_PREFIX = "PhotoModeAll";

		// Token: 0x04003035 RID: 12341
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003036 RID: 12342
		private static int HandleId;
	}
}
