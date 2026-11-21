using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4B RID: 2891
	public class ConfigVideoQteByCgName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043D6 RID: 17366 RVA: 0x001DCA30 File Offset: 0x001DAC30
		static ConfigVideoQteByCgName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoQteByCgName.CreateStaticDefaultValue), new Action(ConfigVideoQteByCgName.ResetStaticDefaultValue));
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x001DCA50 File Offset: 0x001DAC50
		public static void CreateStaticDefaultValue()
		{
			ConfigVideoQteByCgName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigVideoQteByCgName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cgvedio.db"),
				new ValueTuple<string, object>("文件", "g.过场cg.xlsx"),
				new ValueTuple<string, object>("表名", "VideoQte"),
				new ValueTuple<string, object>("语句", "select BinData from `VideoQte` where CgName=?")
			});
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x001DCACF File Offset: 0x001DACCF
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoQteByCgName.LogPair = null;
			ConfigVideoQteByCgName.HandleId = 0;
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x001DCADD File Offset: 0x001DACDD
		public static void Init()
		{
			ConfigVideoQteByCgName.HandleId = ConfigCommon.InitDataStatement(ConfigVideoQteByCgName.HandleId, "db_cgvedio.db", "select BinData from `VideoQte` where CgName=?");
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x001DCAF8 File Offset: 0x001DACF8
		[return: Nullable(2)]
		public static IReadOnlyList<VideoQte> GetConfigList(string p0CgName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigVideoQteByCgName.HandleId, ConfigVideoQteByCgName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<VideoQte> readOnlyList = (IReadOnlyList<VideoQte>)ConfigCommon.GetConfig("VideoQteByCgName#" + p0CgName);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigVideoQteByCgName.LogPair.Clear();
			ConfigVideoQteByCgName.LogPair.Add(new ValueTuple<string, object>("CgName", p0CgName));
			if (!ConfigCommon.BindString(ConfigVideoQteByCgName.HandleId, 1, p0CgName, ConfigVideoQteByCgName.LogPair))
			{
				ConfigCommon.Reset(ConfigVideoQteByCgName.HandleId, ConfigVideoQteByCgName.LogPair);
				return null;
			}
			List<VideoQte> list = new List<VideoQte>();
			while (ConfigCommon.Step(ConfigVideoQteByCgName.HandleId, false, ConfigVideoQteByCgName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigVideoQteByCgName.HandleId, 0, ConfigVideoQteByCgName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigVideoQteByCgName.HandleId, ConfigVideoQteByCgName.LogPair);
					return null;
				}
				VideoQte rootAsVideoQte = VideoQte.GetRootAsVideoQte(new ByteBuffer(item2));
				list.Add(rootAsVideoQte);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("VideoQteByCgName#" + p0CgName, list, list.Count);
			}
			ConfigCommon.Reset(ConfigVideoQteByCgName.HandleId, ConfigVideoQteByCgName.LogPair);
			return list;
		}

		// Token: 0x04004EF3 RID: 20211
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004EF4 RID: 20212
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004EF5 RID: 20213
		private const string TABLE = "VideoQte";

		// Token: 0x04004EF6 RID: 20214
		private const string COMMAND = "select BinData from `VideoQte` where CgName=?";

		// Token: 0x04004EF7 RID: 20215
		private const string KEY_PREFIX = "VideoQteByCgName";

		// Token: 0x04004EF8 RID: 20216
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EF9 RID: 20217
		private static int HandleId;
	}
}
