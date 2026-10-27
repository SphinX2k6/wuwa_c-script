using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092D RID: 2349
	public class ConfigSilentAreaDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003721 RID: 14113 RVA: 0x0019114B File Offset: 0x0018F34B
		static ConfigSilentAreaDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSilentAreaDetectionAll.CreateStaticDefaultValue), new Action(ConfigSilentAreaDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0019116C File Offset: 0x0018F36C
		public static void CreateStaticDefaultValue()
		{
			ConfigSilentAreaDetectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSilentAreaDetectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "SilentAreaDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `SilentAreaDetection`")
			});
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x001911EB File Offset: 0x0018F3EB
		public static void ResetStaticDefaultValue()
		{
			ConfigSilentAreaDetectionAll.LogPair = null;
			ConfigSilentAreaDetectionAll.HandleId = 0;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x001911F9 File Offset: 0x0018F3F9
		public static void Init()
		{
			ConfigSilentAreaDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigSilentAreaDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `SilentAreaDetection`");
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00191214 File Offset: 0x0018F414
		[NullableContext(2)]
		public static IReadOnlyList<SilentAreaDetection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSilentAreaDetectionAll.HandleId, ConfigSilentAreaDetectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SilentAreaDetection> readOnlyList = (IReadOnlyList<SilentAreaDetection>)ConfigCommon.GetConfig("SilentAreaDetectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SilentAreaDetection> list = new List<SilentAreaDetection>();
			while (ConfigCommon.Step(ConfigSilentAreaDetectionAll.HandleId, false, ConfigSilentAreaDetectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSilentAreaDetectionAll.HandleId, 0, ConfigSilentAreaDetectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSilentAreaDetectionAll.HandleId, ConfigSilentAreaDetectionAll.LogPair);
					return null;
				}
				SilentAreaDetection rootAsSilentAreaDetection = SilentAreaDetection.GetRootAsSilentAreaDetection(new ByteBuffer(item2));
				list.Add(rootAsSilentAreaDetection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SilentAreaDetectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSilentAreaDetectionAll.HandleId, ConfigSilentAreaDetectionAll.LogPair);
			return list;
		}

		// Token: 0x04004021 RID: 16417
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04004022 RID: 16418
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04004023 RID: 16419
		private const string TABLE = "SilentAreaDetection";

		// Token: 0x04004024 RID: 16420
		private const string COMMAND = "select BinData from `SilentAreaDetection`";

		// Token: 0x04004025 RID: 16421
		private const string KEY_PREFIX = "SilentAreaDetectionAll";

		// Token: 0x04004026 RID: 16422
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004027 RID: 16423
		private static int HandleId;
	}
}
