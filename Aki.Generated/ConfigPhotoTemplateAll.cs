using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000717 RID: 1815
	public class ConfigPhotoTemplateAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A9A RID: 10906 RVA: 0x0014DAD0 File Offset: 0x0014BCD0
		static ConfigPhotoTemplateAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTemplateAll.CreateStaticDefaultValue), new Action(ConfigPhotoTemplateAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0014DAF0 File Offset: 0x0014BCF0
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

		// Token: 0x06002A9C RID: 10908 RVA: 0x0014DB6F File Offset: 0x0014BD6F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTemplateAll.LogPair = null;
			ConfigPhotoTemplateAll.HandleId = 0;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0014DB7D File Offset: 0x0014BD7D
		public static void Init()
		{
			ConfigPhotoTemplateAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTemplateAll.HandleId, "db_photonew.db", "select BinData from `PhotoTemplate`");
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0014DB98 File Offset: 0x0014BD98
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

		// Token: 0x04003187 RID: 12679
		private const string DB = "db_photonew.db";

		// Token: 0x04003188 RID: 12680
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003189 RID: 12681
		private const string TABLE = "PhotoTemplate";

		// Token: 0x0400318A RID: 12682
		private const string COMMAND = "select BinData from `PhotoTemplate`";

		// Token: 0x0400318B RID: 12683
		private const string KEY_PREFIX = "PhotoTemplateAll";

		// Token: 0x0400318C RID: 12684
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400318D RID: 12685
		private static int HandleId;
	}
}
