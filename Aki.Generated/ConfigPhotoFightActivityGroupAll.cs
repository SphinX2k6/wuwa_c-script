using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EA RID: 1770
	public class ConfigPhotoFightActivityGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x00147CFC File Offset: 0x00145EFC
		static ConfigPhotoFightActivityGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityGroupAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00147D1C File Offset: 0x00145F1C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightActivityGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightActivityGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightActivityGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightActivityGroup`")
			});
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00147D9B File Offset: 0x00145F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityGroupAll.LogPair = null;
			ConfigPhotoFightActivityGroupAll.HandleId = 0;
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00147DA9 File Offset: 0x00145FA9
		public static void Init()
		{
			ConfigPhotoFightActivityGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityGroupAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivityGroup`");
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00147DC4 File Offset: 0x00145FC4
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightActivityGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightActivityGroupAll.HandleId, ConfigPhotoFightActivityGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoFightActivityGroup> readOnlyList = (IReadOnlyList<PhotoFightActivityGroup>)ConfigCommon.GetConfig("PhotoFightActivityGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoFightActivityGroup> list = new List<PhotoFightActivityGroup>();
			while (ConfigCommon.Step(ConfigPhotoFightActivityGroupAll.HandleId, false, ConfigPhotoFightActivityGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightActivityGroupAll.HandleId, 0, ConfigPhotoFightActivityGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightActivityGroupAll.HandleId, ConfigPhotoFightActivityGroupAll.LogPair);
					return null;
				}
				PhotoFightActivityGroup rootAsPhotoFightActivityGroup = PhotoFightActivityGroup.GetRootAsPhotoFightActivityGroup(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightActivityGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoFightActivityGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightActivityGroupAll.HandleId, ConfigPhotoFightActivityGroupAll.LogPair);
			return list;
		}

		// Token: 0x0400304C RID: 12364
		private const string DB = "db_fightphotograph.db";

		// Token: 0x0400304D RID: 12365
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x0400304E RID: 12366
		private const string TABLE = "PhotoFightActivityGroup";

		// Token: 0x0400304F RID: 12367
		private const string COMMAND = "select BinData from `PhotoFightActivityGroup`";

		// Token: 0x04003050 RID: 12368
		private const string KEY_PREFIX = "PhotoFightActivityGroupAll";

		// Token: 0x04003051 RID: 12369
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003052 RID: 12370
		private static int HandleId;
	}
}
