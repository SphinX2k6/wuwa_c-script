using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FE RID: 1790
	public class ConfigPhotoModeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A04 RID: 10756 RVA: 0x0014A4AC File Offset: 0x001486AC
		static ConfigPhotoModeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoModeAll.CreateStaticDefaultValue), new Action(ConfigPhotoModeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x0014A4CC File Offset: 0x001486CC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoModeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoModeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMode"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMode`")
			});
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x0014A54B File Offset: 0x0014874B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoModeAll.LogPair = null;
			ConfigPhotoModeAll.HandleId = 0;
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x0014A559 File Offset: 0x00148759
		public static void Init()
		{
			ConfigPhotoModeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoModeAll.HandleId, "db_photonew.db", "select BinData from `PhotoMode`");
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x0014A574 File Offset: 0x00148774
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMode> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoModeAll.HandleId, ConfigPhotoModeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoMode> readOnlyList = (IReadOnlyList<PhotoMode>)ConfigCommon.GetConfig("PhotoModeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoMode> list = new List<PhotoMode>();
			while (ConfigCommon.Step(ConfigPhotoModeAll.HandleId, false, ConfigPhotoModeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoModeAll.HandleId, 0, ConfigPhotoModeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoModeAll.HandleId, ConfigPhotoModeAll.LogPair);
					return null;
				}
				PhotoMode rootAsPhotoMode = PhotoMode.GetRootAsPhotoMode(new ByteBuffer(item2));
				list.Add(rootAsPhotoMode);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoModeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoModeAll.HandleId, ConfigPhotoModeAll.LogPair);
			return list;
		}

		// Token: 0x040030D8 RID: 12504
		private const string DB = "db_photonew.db";

		// Token: 0x040030D9 RID: 12505
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030DA RID: 12506
		private const string TABLE = "PhotoMode";

		// Token: 0x040030DB RID: 12507
		private const string COMMAND = "select BinData from `PhotoMode`";

		// Token: 0x040030DC RID: 12508
		private const string KEY_PREFIX = "PhotoModeAll";

		// Token: 0x040030DD RID: 12509
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030DE RID: 12510
		private static int HandleId;
	}
}
