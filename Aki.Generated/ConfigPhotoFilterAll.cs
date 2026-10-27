using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D8 RID: 1752
	public class ConfigPhotoFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002920 RID: 10528 RVA: 0x00141DE3 File Offset: 0x0013FFE3
		static ConfigPhotoFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFilterAll.CreateStaticDefaultValue), new Action(ConfigPhotoFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00141E04 File Offset: 0x00140004
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

		// Token: 0x06002922 RID: 10530 RVA: 0x00141E83 File Offset: 0x00140083
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFilterAll.LogPair = null;
			ConfigPhotoFilterAll.HandleId = 0;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00141E91 File Offset: 0x00140091
		public static void Init()
		{
			ConfigPhotoFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFilterAll.HandleId, "db_photograph.db", "select BinData from `PhotoFilter`");
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00141EAC File Offset: 0x001400AC
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

		// Token: 0x04002FCE RID: 12238
		private const string DB = "db_photograph.db";

		// Token: 0x04002FCF RID: 12239
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04002FD0 RID: 12240
		private const string TABLE = "PhotoFilter";

		// Token: 0x04002FD1 RID: 12241
		private const string COMMAND = "select BinData from `PhotoFilter`";

		// Token: 0x04002FD2 RID: 12242
		private const string KEY_PREFIX = "PhotoFilterAll";

		// Token: 0x04002FD3 RID: 12243
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FD4 RID: 12244
		private static int HandleId;
	}
}
