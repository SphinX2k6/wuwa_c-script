using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000978 RID: 2424
	public class ConfigSilentAreaDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038E3 RID: 14563 RVA: 0x0019E36B File Offset: 0x0019C56B
		static ConfigSilentAreaDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSilentAreaDetectionAll.CreateStaticDefaultValue), new Action(ConfigSilentAreaDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0019E38C File Offset: 0x0019C58C
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

		// Token: 0x060038E5 RID: 14565 RVA: 0x0019E40B File Offset: 0x0019C60B
		public static void ResetStaticDefaultValue()
		{
			ConfigSilentAreaDetectionAll.LogPair = null;
			ConfigSilentAreaDetectionAll.HandleId = 0;
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x0019E419 File Offset: 0x0019C619
		public static void Init()
		{
			ConfigSilentAreaDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigSilentAreaDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `SilentAreaDetection`");
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0019E434 File Offset: 0x0019C634
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

		// Token: 0x0400422E RID: 16942
		private const string DB = "db_adventure_detect.db";

		// Token: 0x0400422F RID: 16943
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04004230 RID: 16944
		private const string TABLE = "SilentAreaDetection";

		// Token: 0x04004231 RID: 16945
		private const string COMMAND = "select BinData from `SilentAreaDetection`";

		// Token: 0x04004232 RID: 16946
		private const string KEY_PREFIX = "SilentAreaDetectionAll";

		// Token: 0x04004233 RID: 16947
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004234 RID: 16948
		private static int HandleId;
	}
}
