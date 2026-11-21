using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EC RID: 1772
	public class ConfigPhotoFightRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x001480C7 File Offset: 0x001462C7
		static ConfigPhotoFightRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x001480E8 File Offset: 0x001462E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightReward"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightReward`")
			});
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00148167 File Offset: 0x00146367
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardAll.LogPair = null;
			ConfigPhotoFightRewardAll.HandleId = 0;
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00148175 File Offset: 0x00146375
		public static void Init()
		{
			ConfigPhotoFightRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightReward`");
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00148190 File Offset: 0x00146390
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightRewardAll.HandleId, ConfigPhotoFightRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoFightReward> readOnlyList = (IReadOnlyList<PhotoFightReward>)ConfigCommon.GetConfig("PhotoFightRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoFightReward> list = new List<PhotoFightReward>();
			while (ConfigCommon.Step(ConfigPhotoFightRewardAll.HandleId, false, ConfigPhotoFightRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightRewardAll.HandleId, 0, ConfigPhotoFightRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightRewardAll.HandleId, ConfigPhotoFightRewardAll.LogPair);
					return null;
				}
				PhotoFightReward rootAsPhotoFightReward = PhotoFightReward.GetRootAsPhotoFightReward(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoFightRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightRewardAll.HandleId, ConfigPhotoFightRewardAll.LogPair);
			return list;
		}

		// Token: 0x0400305A RID: 12378
		private const string DB = "db_fightphotograph.db";

		// Token: 0x0400305B RID: 12379
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x0400305C RID: 12380
		private const string TABLE = "PhotoFightReward";

		// Token: 0x0400305D RID: 12381
		private const string COMMAND = "select BinData from `PhotoFightReward`";

		// Token: 0x0400305E RID: 12382
		private const string KEY_PREFIX = "PhotoFightRewardAll";

		// Token: 0x0400305F RID: 12383
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003060 RID: 12384
		private static int HandleId;
	}
}
