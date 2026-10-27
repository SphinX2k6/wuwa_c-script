using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FC RID: 1788
	public class ConfigPhotoTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029F8 RID: 10744 RVA: 0x00146A30 File Offset: 0x00144C30
		static ConfigPhotoTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTabAll.CreateStaticDefaultValue), new Action(ConfigPhotoTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00146A50 File Offset: 0x00144C50
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoTab`")
			});
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00146ACF File Offset: 0x00144CCF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTabAll.LogPair = null;
			ConfigPhotoTabAll.HandleId = 0;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00146ADD File Offset: 0x00144CDD
		public static void Init()
		{
			ConfigPhotoTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTabAll.HandleId, "db_photonew.db", "select BinData from `PhotoTab`");
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00146AF8 File Offset: 0x00144CF8
		[NullableContext(2)]
		public static IReadOnlyList<PhotoTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoTabAll.HandleId, ConfigPhotoTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoTab> readOnlyList = (IReadOnlyList<PhotoTab>)ConfigCommon.GetConfig("PhotoTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoTab> list = new List<PhotoTab>();
			while (ConfigCommon.Step(ConfigPhotoTabAll.HandleId, false, ConfigPhotoTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoTabAll.HandleId, 0, ConfigPhotoTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoTabAll.HandleId, ConfigPhotoTabAll.LogPair);
					return null;
				}
				PhotoTab rootAsPhotoTab = PhotoTab.GetRootAsPhotoTab(new ByteBuffer(item2));
				list.Add(rootAsPhotoTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoTabAll.HandleId, ConfigPhotoTabAll.LogPair);
			return list;
		}

		// Token: 0x040030CA RID: 12490
		private const string DB = "db_photonew.db";

		// Token: 0x040030CB RID: 12491
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030CC RID: 12492
		private const string TABLE = "PhotoTab";

		// Token: 0x040030CD RID: 12493
		private const string COMMAND = "select BinData from `PhotoTab`";

		// Token: 0x040030CE RID: 12494
		private const string KEY_PREFIX = "PhotoTabAll";

		// Token: 0x040030CF RID: 12495
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030D0 RID: 12496
		private static int HandleId;
	}
}
