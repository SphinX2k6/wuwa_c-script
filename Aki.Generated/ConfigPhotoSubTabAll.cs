using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000711 RID: 1809
	public class ConfigPhotoSubTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A76 RID: 10870 RVA: 0x0014CE88 File Offset: 0x0014B088
		static ConfigPhotoSubTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSubTabAll.CreateStaticDefaultValue), new Action(ConfigPhotoSubTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0014CEA8 File Offset: 0x0014B0A8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSubTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSubTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSubTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSubTab`")
			});
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0014CF27 File Offset: 0x0014B127
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSubTabAll.LogPair = null;
			ConfigPhotoSubTabAll.HandleId = 0;
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x0014CF35 File Offset: 0x0014B135
		public static void Init()
		{
			ConfigPhotoSubTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSubTabAll.HandleId, "db_photonew.db", "select BinData from `PhotoSubTab`");
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0014CF50 File Offset: 0x0014B150
		[NullableContext(2)]
		public static IReadOnlyList<PhotoSubTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSubTabAll.HandleId, ConfigPhotoSubTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoSubTab> readOnlyList = (IReadOnlyList<PhotoSubTab>)ConfigCommon.GetConfig("PhotoSubTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoSubTab> list = new List<PhotoSubTab>();
			while (ConfigCommon.Step(ConfigPhotoSubTabAll.HandleId, false, ConfigPhotoSubTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSubTabAll.HandleId, 0, ConfigPhotoSubTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoSubTabAll.HandleId, ConfigPhotoSubTabAll.LogPair);
					return null;
				}
				PhotoSubTab rootAsPhotoSubTab = PhotoSubTab.GetRootAsPhotoSubTab(new ByteBuffer(item2));
				list.Add(rootAsPhotoSubTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoSubTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoSubTabAll.HandleId, ConfigPhotoSubTabAll.LogPair);
			return list;
		}

		// Token: 0x0400315D RID: 12637
		private const string DB = "db_photonew.db";

		// Token: 0x0400315E RID: 12638
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400315F RID: 12639
		private const string TABLE = "PhotoSubTab";

		// Token: 0x04003160 RID: 12640
		private const string COMMAND = "select BinData from `PhotoSubTab`";

		// Token: 0x04003161 RID: 12641
		private const string KEY_PREFIX = "PhotoSubTabAll";

		// Token: 0x04003162 RID: 12642
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003163 RID: 12643
		private static int HandleId;
	}
}
