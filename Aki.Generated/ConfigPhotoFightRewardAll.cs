using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D4 RID: 1748
	public class ConfigPhotoFightRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002908 RID: 10504 RVA: 0x0014164B File Offset: 0x0013F84B
		static ConfigPhotoFightRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x0014166C File Offset: 0x0013F86C
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

		// Token: 0x0600290A RID: 10506 RVA: 0x001416EB File Offset: 0x0013F8EB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardAll.LogPair = null;
			ConfigPhotoFightRewardAll.HandleId = 0;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x001416F9 File Offset: 0x0013F8F9
		public static void Init()
		{
			ConfigPhotoFightRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightReward`");
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00141714 File Offset: 0x0013F914
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

		// Token: 0x04002FB2 RID: 12210
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002FB3 RID: 12211
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002FB4 RID: 12212
		private const string TABLE = "PhotoFightReward";

		// Token: 0x04002FB5 RID: 12213
		private const string COMMAND = "select BinData from `PhotoFightReward`";

		// Token: 0x04002FB6 RID: 12214
		private const string KEY_PREFIX = "PhotoFightRewardAll";

		// Token: 0x04002FB7 RID: 12215
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FB8 RID: 12216
		private static int HandleId;
	}
}
