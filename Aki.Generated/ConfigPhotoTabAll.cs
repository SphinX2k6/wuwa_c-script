using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000714 RID: 1812
	public class ConfigPhotoTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A88 RID: 10888 RVA: 0x0014D4AC File Offset: 0x0014B6AC
		static ConfigPhotoTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTabAll.CreateStaticDefaultValue), new Action(ConfigPhotoTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x0014D4CC File Offset: 0x0014B6CC
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

		// Token: 0x06002A8A RID: 10890 RVA: 0x0014D54B File Offset: 0x0014B74B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTabAll.LogPair = null;
			ConfigPhotoTabAll.HandleId = 0;
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x0014D559 File Offset: 0x0014B759
		public static void Init()
		{
			ConfigPhotoTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTabAll.HandleId, "db_photonew.db", "select BinData from `PhotoTab`");
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x0014D574 File Offset: 0x0014B774
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

		// Token: 0x04003172 RID: 12658
		private const string DB = "db_photonew.db";

		// Token: 0x04003173 RID: 12659
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003174 RID: 12660
		private const string TABLE = "PhotoTab";

		// Token: 0x04003175 RID: 12661
		private const string COMMAND = "select BinData from `PhotoTab`";

		// Token: 0x04003176 RID: 12662
		private const string KEY_PREFIX = "PhotoTabAll";

		// Token: 0x04003177 RID: 12663
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003178 RID: 12664
		private static int HandleId;
	}
}
