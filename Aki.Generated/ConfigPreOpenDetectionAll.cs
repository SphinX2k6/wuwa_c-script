using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000777 RID: 1911
	public class ConfigPreOpenDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CDB RID: 11483 RVA: 0x0015A550 File Offset: 0x00158750
		static ConfigPreOpenDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreOpenDetectionAll.CreateStaticDefaultValue), new Action(ConfigPreOpenDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0015A570 File Offset: 0x00158770
		public static void CreateStaticDefaultValue()
		{
			ConfigPreOpenDetectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreOpenDetectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "PreOpenDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `PreOpenDetection`")
			});
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x0015A5EF File Offset: 0x001587EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPreOpenDetectionAll.LogPair = null;
			ConfigPreOpenDetectionAll.HandleId = 0;
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x0015A5FD File Offset: 0x001587FD
		public static void Init()
		{
			ConfigPreOpenDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreOpenDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `PreOpenDetection`");
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0015A618 File Offset: 0x00158818
		[NullableContext(2)]
		public static IReadOnlyList<PreOpenDetection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreOpenDetectionAll.HandleId, ConfigPreOpenDetectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PreOpenDetection> readOnlyList = (IReadOnlyList<PreOpenDetection>)ConfigCommon.GetConfig("PreOpenDetectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PreOpenDetection> list = new List<PreOpenDetection>();
			while (ConfigCommon.Step(ConfigPreOpenDetectionAll.HandleId, false, ConfigPreOpenDetectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreOpenDetectionAll.HandleId, 0, ConfigPreOpenDetectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPreOpenDetectionAll.HandleId, ConfigPreOpenDetectionAll.LogPair);
					return null;
				}
				PreOpenDetection rootAsPreOpenDetection = PreOpenDetection.GetRootAsPreOpenDetection(new ByteBuffer(item2));
				list.Add(rootAsPreOpenDetection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PreOpenDetectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPreOpenDetectionAll.HandleId, ConfigPreOpenDetectionAll.LogPair);
			return list;
		}

		// Token: 0x04003427 RID: 13351
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04003428 RID: 13352
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04003429 RID: 13353
		private const string TABLE = "PreOpenDetection";

		// Token: 0x0400342A RID: 13354
		private const string COMMAND = "select BinData from `PreOpenDetection`";

		// Token: 0x0400342B RID: 13355
		private const string KEY_PREFIX = "PreOpenDetectionAll";

		// Token: 0x0400342C RID: 13356
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400342D RID: 13357
		private static int HandleId;
	}
}
