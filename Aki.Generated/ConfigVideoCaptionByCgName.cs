using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A73 RID: 2675
	public class ConfigVideoCaptionByCgName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EC6 RID: 16070 RVA: 0x001BCFE8 File Offset: 0x001BB1E8
		static ConfigVideoCaptionByCgName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoCaptionByCgName.CreateStaticDefaultValue), new Action(ConfigVideoCaptionByCgName.ResetStaticDefaultValue));
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x001BD008 File Offset: 0x001BB208
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

		// Token: 0x06003EC8 RID: 16072 RVA: 0x001BD087 File Offset: 0x001BB287
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoCaptionByCgName.LogPair = null;
			ConfigVideoCaptionByCgName.HandleId = 0;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x001BD095 File Offset: 0x001BB295
		public static void Init()
		{
			ConfigVideoCaptionByCgName.HandleId = ConfigCommon.InitDataStatement(ConfigVideoCaptionByCgName.HandleId, "db_cgvedio.db", "select BinData from `VideoCaption` where CgName=?");
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x001BD0B0 File Offset: 0x001BB2B0
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

		// Token: 0x0400490B RID: 18699
		private const string DB = "db_cgvedio.db";

		// Token: 0x0400490C RID: 18700
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x0400490D RID: 18701
		private const string TABLE = "VideoCaption";

		// Token: 0x0400490E RID: 18702
		private const string COMMAND = "select BinData from `VideoCaption` where CgName=?";

		// Token: 0x0400490F RID: 18703
		private const string KEY_PREFIX = "VideoCaptionByCgName";

		// Token: 0x04004910 RID: 18704
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004911 RID: 18705
		private static int HandleId;
	}
}
