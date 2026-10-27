using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D6 RID: 1750
	public class ConfigPhotoFightRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002914 RID: 10516 RVA: 0x00141A17 File Offset: 0x0013FC17
		static ConfigPhotoFightRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardTabAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00141A38 File Offset: 0x0013FC38
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

		// Token: 0x06002916 RID: 10518 RVA: 0x00141AB7 File Offset: 0x0013FCB7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardTabAll.LogPair = null;
			ConfigPhotoFightRewardTabAll.HandleId = 0;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00141AC5 File Offset: 0x0013FCC5
		public static void Init()
		{
			ConfigPhotoFightRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardTabAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightRewardTab`");
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00141AE0 File Offset: 0x0013FCE0
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

		// Token: 0x04002FC0 RID: 12224
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002FC1 RID: 12225
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002FC2 RID: 12226
		private const string TABLE = "PhotoFightRewardTab";

		// Token: 0x04002FC3 RID: 12227
		private const string COMMAND = "select BinData from `PhotoFightRewardTab`";

		// Token: 0x04002FC4 RID: 12228
		private const string KEY_PREFIX = "PhotoFightRewardTabAll";

		// Token: 0x04002FC5 RID: 12229
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FC6 RID: 12230
		private static int HandleId;
	}
}
