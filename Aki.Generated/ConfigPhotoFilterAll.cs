using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F0 RID: 1776
	public class ConfigPhotoFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029B0 RID: 10672 RVA: 0x0014885F File Offset: 0x00146A5F
		static ConfigPhotoFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFilterAll.CreateStaticDefaultValue), new Action(ConfigPhotoFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00148880 File Offset: 0x00146A80
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFilter`")
			});
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x001488FF File Offset: 0x00146AFF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFilterAll.LogPair = null;
			ConfigPhotoFilterAll.HandleId = 0;
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0014890D File Offset: 0x00146B0D
		public static void Init()
		{
			ConfigPhotoFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFilterAll.HandleId, "db_photograph.db", "select BinData from `PhotoFilter`");
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00148928 File Offset: 0x00146B28
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFilterAll.HandleId, ConfigPhotoFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoFilter> readOnlyList = (IReadOnlyList<PhotoFilter>)ConfigCommon.GetConfig("PhotoFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoFilter> list = new List<PhotoFilter>();
			while (ConfigCommon.Step(ConfigPhotoFilterAll.HandleId, false, ConfigPhotoFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFilterAll.HandleId, 0, ConfigPhotoFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFilterAll.HandleId, ConfigPhotoFilterAll.LogPair);
					return null;
				}
				PhotoFilter rootAsPhotoFilter = PhotoFilter.GetRootAsPhotoFilter(new ByteBuffer(item2));
				list.Add(rootAsPhotoFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFilterAll.HandleId, ConfigPhotoFilterAll.LogPair);
			return list;
		}

		// Token: 0x04003076 RID: 12406
		private const string DB = "db_photograph.db";

		// Token: 0x04003077 RID: 12407
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003078 RID: 12408
		private const string TABLE = "PhotoFilter";

		// Token: 0x04003079 RID: 12409
		private const string COMMAND = "select BinData from `PhotoFilter`";

		// Token: 0x0400307A RID: 12410
		private const string KEY_PREFIX = "PhotoFilterAll";

		// Token: 0x0400307B RID: 12411
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400307C RID: 12412
		private static int HandleId;
	}
}
