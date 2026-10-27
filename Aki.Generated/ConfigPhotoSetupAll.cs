using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F4 RID: 1780
	public class ConfigPhotoSetupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029C8 RID: 10696 RVA: 0x00145A0C File Offset: 0x00143C0C
		static ConfigPhotoSetupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSetupAll.CreateStaticDefaultValue), new Action(ConfigPhotoSetupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00145A2C File Offset: 0x00143C2C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSetupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSetupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSetup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSetup`")
			});
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00145AAB File Offset: 0x00143CAB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSetupAll.LogPair = null;
			ConfigPhotoSetupAll.HandleId = 0;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00145AB9 File Offset: 0x00143CB9
		public static void Init()
		{
			ConfigPhotoSetupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSetupAll.HandleId, "db_photograph.db", "select BinData from `PhotoSetup`");
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00145AD4 File Offset: 0x00143CD4
		[NullableContext(2)]
		public static IReadOnlyList<PhotoSetup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSetupAll.HandleId, ConfigPhotoSetupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoSetup> readOnlyList = (IReadOnlyList<PhotoSetup>)ConfigCommon.GetConfig("PhotoSetupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoSetup> list = new List<PhotoSetup>();
			while (ConfigCommon.Step(ConfigPhotoSetupAll.HandleId, false, ConfigPhotoSetupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSetupAll.HandleId, 0, ConfigPhotoSetupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoSetupAll.HandleId, ConfigPhotoSetupAll.LogPair);
					return null;
				}
				PhotoSetup rootAsPhotoSetup = PhotoSetup.GetRootAsPhotoSetup(new ByteBuffer(item2));
				list.Add(rootAsPhotoSetup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoSetupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoSetupAll.HandleId, ConfigPhotoSetupAll.LogPair);
			return list;
		}

		// Token: 0x04003092 RID: 12434
		private const string DB = "db_photograph.db";

		// Token: 0x04003093 RID: 12435
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003094 RID: 12436
		private const string TABLE = "PhotoSetup";

		// Token: 0x04003095 RID: 12437
		private const string COMMAND = "select BinData from `PhotoSetup`";

		// Token: 0x04003096 RID: 12438
		private const string KEY_PREFIX = "PhotoSetupAll";

		// Token: 0x04003097 RID: 12439
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003098 RID: 12440
		private static int HandleId;
	}
}
