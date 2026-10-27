using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A76 RID: 2678
	public class ConfigVideoQteByCgName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ED8 RID: 16088 RVA: 0x001BD69C File Offset: 0x001BB89C
		static ConfigVideoQteByCgName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoQteByCgName.CreateStaticDefaultValue), new Action(ConfigVideoQteByCgName.ResetStaticDefaultValue));
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x001BD6BC File Offset: 0x001BB8BC
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

		// Token: 0x06003EDA RID: 16090 RVA: 0x001BD73B File Offset: 0x001BB93B
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoQteByCgName.LogPair = null;
			ConfigVideoQteByCgName.HandleId = 0;
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x001BD749 File Offset: 0x001BB949
		public static void Init()
		{
			ConfigVideoQteByCgName.HandleId = ConfigCommon.InitDataStatement(ConfigVideoQteByCgName.HandleId, "db_cgvedio.db", "select BinData from `VideoQte` where CgName=?");
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x001BD764 File Offset: 0x001BB964
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

		// Token: 0x04004920 RID: 18720
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004921 RID: 18721
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004922 RID: 18722
		private const string TABLE = "VideoQte";

		// Token: 0x04004923 RID: 18723
		private const string COMMAND = "select BinData from `VideoQte` where CgName=?";

		// Token: 0x04004924 RID: 18724
		private const string KEY_PREFIX = "VideoQteByCgName";

		// Token: 0x04004925 RID: 18725
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004926 RID: 18726
		private static int HandleId;
	}
}
