using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EE RID: 1774
	public class ConfigPhotoFightRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029A4 RID: 10660 RVA: 0x00148493 File Offset: 0x00146693
		static ConfigPhotoFightRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardTabAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x001484B4 File Offset: 0x001466B4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightRewardTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightRewardTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightRewardTab`")
			});
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00148533 File Offset: 0x00146733
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardTabAll.LogPair = null;
			ConfigPhotoFightRewardTabAll.HandleId = 0;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00148541 File Offset: 0x00146741
		public static void Init()
		{
			ConfigPhotoFightRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardTabAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightRewardTab`");
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x0014855C File Offset: 0x0014675C
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightRewardTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightRewardTabAll.HandleId, ConfigPhotoFightRewardTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoFightRewardTab> readOnlyList = (IReadOnlyList<PhotoFightRewardTab>)ConfigCommon.GetConfig("PhotoFightRewardTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoFightRewardTab> list = new List<PhotoFightRewardTab>();
			while (ConfigCommon.Step(ConfigPhotoFightRewardTabAll.HandleId, false, ConfigPhotoFightRewardTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightRewardTabAll.HandleId, 0, ConfigPhotoFightRewardTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightRewardTabAll.HandleId, ConfigPhotoFightRewardTabAll.LogPair);
					return null;
				}
				PhotoFightRewardTab rootAsPhotoFightRewardTab = PhotoFightRewardTab.GetRootAsPhotoFightRewardTab(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightRewardTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoFightRewardTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightRewardTabAll.HandleId, ConfigPhotoFightRewardTabAll.LogPair);
			return list;
		}

		// Token: 0x04003068 RID: 12392
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04003069 RID: 12393
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x0400306A RID: 12394
		private const string TABLE = "PhotoFightRewardTab";

		// Token: 0x0400306B RID: 12395
		private const string COMMAND = "select BinData from `PhotoFightRewardTab`";

		// Token: 0x0400306C RID: 12396
		private const string KEY_PREFIX = "PhotoFightRewardTabAll";

		// Token: 0x0400306D RID: 12397
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400306E RID: 12398
		private static int HandleId;
	}
}
