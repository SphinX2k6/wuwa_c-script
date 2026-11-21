using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B48 RID: 2888
	public class ConfigVideoCaptionByCgName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043C4 RID: 17348 RVA: 0x001DC37C File Offset: 0x001DA57C
		static ConfigVideoCaptionByCgName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoCaptionByCgName.CreateStaticDefaultValue), new Action(ConfigVideoCaptionByCgName.ResetStaticDefaultValue));
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x001DC39C File Offset: 0x001DA59C
		public static void CreateStaticDefaultValue()
		{
			ConfigVideoCaptionByCgName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigVideoCaptionByCgName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cgvedio.db"),
				new ValueTuple<string, object>("文件", "g.过场cg.xlsx"),
				new ValueTuple<string, object>("表名", "VideoCaption"),
				new ValueTuple<string, object>("语句", "select BinData from `VideoCaption` where CgName=?")
			});
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x001DC41B File Offset: 0x001DA61B
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoCaptionByCgName.LogPair = null;
			ConfigVideoCaptionByCgName.HandleId = 0;
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x001DC429 File Offset: 0x001DA629
		public static void Init()
		{
			ConfigVideoCaptionByCgName.HandleId = ConfigCommon.InitDataStatement(ConfigVideoCaptionByCgName.HandleId, "db_cgvedio.db", "select BinData from `VideoCaption` where CgName=?");
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x001DC444 File Offset: 0x001DA644
		[return: Nullable(2)]
		public static IReadOnlyList<VideoCaption> GetConfigList(string p0CgName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigVideoCaptionByCgName.HandleId, ConfigVideoCaptionByCgName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<VideoCaption> readOnlyList = (IReadOnlyList<VideoCaption>)ConfigCommon.GetConfig("VideoCaptionByCgName#" + p0CgName);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigVideoCaptionByCgName.LogPair.Clear();
			ConfigVideoCaptionByCgName.LogPair.Add(new ValueTuple<string, object>("CgName", p0CgName));
			if (!ConfigCommon.BindString(ConfigVideoCaptionByCgName.HandleId, 1, p0CgName, ConfigVideoCaptionByCgName.LogPair))
			{
				ConfigCommon.Reset(ConfigVideoCaptionByCgName.HandleId, ConfigVideoCaptionByCgName.LogPair);
				return null;
			}
			List<VideoCaption> list = new List<VideoCaption>();
			while (ConfigCommon.Step(ConfigVideoCaptionByCgName.HandleId, false, ConfigVideoCaptionByCgName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigVideoCaptionByCgName.HandleId, 0, ConfigVideoCaptionByCgName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigVideoCaptionByCgName.HandleId, ConfigVideoCaptionByCgName.LogPair);
					return null;
				}
				VideoCaption rootAsVideoCaption = VideoCaption.GetRootAsVideoCaption(new ByteBuffer(item2));
				list.Add(rootAsVideoCaption);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("VideoCaptionByCgName#" + p0CgName, list, list.Count);
			}
			ConfigCommon.Reset(ConfigVideoCaptionByCgName.HandleId, ConfigVideoCaptionByCgName.LogPair);
			return list;
		}

		// Token: 0x04004EDE RID: 20190
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004EDF RID: 20191
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004EE0 RID: 20192
		private const string TABLE = "VideoCaption";

		// Token: 0x04004EE1 RID: 20193
		private const string COMMAND = "select BinData from `VideoCaption` where CgName=?";

		// Token: 0x04004EE2 RID: 20194
		private const string KEY_PREFIX = "VideoCaptionByCgName";

		// Token: 0x04004EE3 RID: 20195
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EE4 RID: 20196
		private static int HandleId;
	}
}
