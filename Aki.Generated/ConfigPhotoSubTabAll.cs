using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F9 RID: 1785
	public class ConfigPhotoSubTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029E6 RID: 10726 RVA: 0x0014640C File Offset: 0x0014460C
		static ConfigPhotoSubTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSubTabAll.CreateStaticDefaultValue), new Action(ConfigPhotoSubTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0014642C File Offset: 0x0014462C
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

		// Token: 0x060029E8 RID: 10728 RVA: 0x001464AB File Offset: 0x001446AB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSubTabAll.LogPair = null;
			ConfigPhotoSubTabAll.HandleId = 0;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x001464B9 File Offset: 0x001446B9
		public static void Init()
		{
			ConfigPhotoSubTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSubTabAll.HandleId, "db_photonew.db", "select BinData from `PhotoSubTab`");
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x001464D4 File Offset: 0x001446D4
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

		// Token: 0x040030B5 RID: 12469
		private const string DB = "db_photonew.db";

		// Token: 0x040030B6 RID: 12470
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030B7 RID: 12471
		private const string TABLE = "PhotoSubTab";

		// Token: 0x040030B8 RID: 12472
		private const string COMMAND = "select BinData from `PhotoSubTab`";

		// Token: 0x040030B9 RID: 12473
		private const string KEY_PREFIX = "PhotoSubTabAll";

		// Token: 0x040030BA RID: 12474
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030BB RID: 12475
		private static int HandleId;
	}
}
