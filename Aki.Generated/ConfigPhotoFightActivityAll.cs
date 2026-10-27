using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CF RID: 1743
	public class ConfigPhotoFightActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028EA RID: 10474 RVA: 0x00140C5C File Offset: 0x0013EE5C
		static ConfigPhotoFightActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00140C7C File Offset: 0x0013EE7C
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

		// Token: 0x060028EC RID: 10476 RVA: 0x00140CFB File Offset: 0x0013EEFB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityAll.LogPair = null;
			ConfigPhotoFightActivityAll.HandleId = 0;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00140D09 File Offset: 0x0013EF09
		public static void Init()
		{
			ConfigPhotoFightActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivity`");
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00140D24 File Offset: 0x0013EF24
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

		// Token: 0x04002F8F RID: 12175
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002F90 RID: 12176
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002F91 RID: 12177
		private const string TABLE = "PhotoFightActivity";

		// Token: 0x04002F92 RID: 12178
		private const string COMMAND = "select BinData from `PhotoFightActivity`";

		// Token: 0x04002F93 RID: 12179
		private const string KEY_PREFIX = "PhotoFightActivityAll";

		// Token: 0x04002F94 RID: 12180
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F95 RID: 12181
		private static int HandleId;
	}
}
