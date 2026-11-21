using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E7 RID: 1767
	public class ConfigPhotoFightActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600297A RID: 10618 RVA: 0x001476D8 File Offset: 0x001458D8
		static ConfigPhotoFightActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x001476F8 File Offset: 0x001458F8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightActivity`")
			});
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00147777 File Offset: 0x00145977
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityAll.LogPair = null;
			ConfigPhotoFightActivityAll.HandleId = 0;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00147785 File Offset: 0x00145985
		public static void Init()
		{
			ConfigPhotoFightActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivity`");
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x001477A0 File Offset: 0x001459A0
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightActivityAll.HandleId, ConfigPhotoFightActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoFightActivity> readOnlyList = (IReadOnlyList<PhotoFightActivity>)ConfigCommon.GetConfig("PhotoFightActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoFightActivity> list = new List<PhotoFightActivity>();
			while (ConfigCommon.Step(ConfigPhotoFightActivityAll.HandleId, false, ConfigPhotoFightActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightActivityAll.HandleId, 0, ConfigPhotoFightActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightActivityAll.HandleId, ConfigPhotoFightActivityAll.LogPair);
					return null;
				}
				PhotoFightActivity rootAsPhotoFightActivity = PhotoFightActivity.GetRootAsPhotoFightActivity(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoFightActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightActivityAll.HandleId, ConfigPhotoFightActivityAll.LogPair);
			return list;
		}

		// Token: 0x04003037 RID: 12343
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04003038 RID: 12344
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04003039 RID: 12345
		private const string TABLE = "PhotoFightActivity";

		// Token: 0x0400303A RID: 12346
		private const string COMMAND = "select BinData from `PhotoFightActivity`";

		// Token: 0x0400303B RID: 12347
		private const string KEY_PREFIX = "PhotoFightActivityAll";

		// Token: 0x0400303C RID: 12348
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400303D RID: 12349
		private static int HandleId;
	}
}
