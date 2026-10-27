using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FF RID: 1791
	public class ConfigPhotoTemplateAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A0A RID: 10762 RVA: 0x00147054 File Offset: 0x00145254
		static ConfigPhotoTemplateAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTemplateAll.CreateStaticDefaultValue), new Action(ConfigPhotoTemplateAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00147074 File Offset: 0x00145274
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoTemplateAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoTemplateAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoTemplate"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoTemplate`")
			});
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x001470F3 File Offset: 0x001452F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTemplateAll.LogPair = null;
			ConfigPhotoTemplateAll.HandleId = 0;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00147101 File Offset: 0x00145301
		public static void Init()
		{
			ConfigPhotoTemplateAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTemplateAll.HandleId, "db_photonew.db", "select BinData from `PhotoTemplate`");
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0014711C File Offset: 0x0014531C
		[NullableContext(2)]
		public static IReadOnlyList<PhotoTemplate> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoTemplateAll.HandleId, ConfigPhotoTemplateAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoTemplate> readOnlyList = (IReadOnlyList<PhotoTemplate>)ConfigCommon.GetConfig("PhotoTemplateAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoTemplate> list = new List<PhotoTemplate>();
			while (ConfigCommon.Step(ConfigPhotoTemplateAll.HandleId, false, ConfigPhotoTemplateAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoTemplateAll.HandleId, 0, ConfigPhotoTemplateAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoTemplateAll.HandleId, ConfigPhotoTemplateAll.LogPair);
					return null;
				}
				PhotoTemplate rootAsPhotoTemplate = PhotoTemplate.GetRootAsPhotoTemplate(new ByteBuffer(item2));
				list.Add(rootAsPhotoTemplate);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoTemplateAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoTemplateAll.HandleId, ConfigPhotoTemplateAll.LogPair);
			return list;
		}

		// Token: 0x040030DF RID: 12511
		private const string DB = "db_photonew.db";

		// Token: 0x040030E0 RID: 12512
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030E1 RID: 12513
		private const string TABLE = "PhotoTemplate";

		// Token: 0x040030E2 RID: 12514
		private const string COMMAND = "select BinData from `PhotoTemplate`";

		// Token: 0x040030E3 RID: 12515
		private const string KEY_PREFIX = "PhotoTemplateAll";

		// Token: 0x040030E4 RID: 12516
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030E5 RID: 12517
		private static int HandleId;
	}
}
