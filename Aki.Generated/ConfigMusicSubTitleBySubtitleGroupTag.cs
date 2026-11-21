using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F8 RID: 1528
	public class ConfigMusicSubTitleBySubtitleGroupTag : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023DF RID: 9183 RVA: 0x00127D84 File Offset: 0x00125F84
		static ConfigMusicSubTitleBySubtitleGroupTag()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicSubTitleBySubtitleGroupTag.CreateStaticDefaultValue), new Action(ConfigMusicSubTitleBySubtitleGroupTag.ResetStaticDefaultValue));
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00127DA4 File Offset: 0x00125FA4
		public static void CreateStaticDefaultValue()
		{
			ConfigMusicSubTitleBySubtitleGroupTag.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMusicSubTitleBySubtitleGroupTag.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_musicsubtitle.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/y.音乐字幕/*.csv*"),
				new ValueTuple<string, object>("表名", "MusicSubTitle"),
				new ValueTuple<string, object>("语句", "select BinData from `MusicSubTitle` where SubtitleGroupTag=?")
			});
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00127E23 File Offset: 0x00126023
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicSubTitleBySubtitleGroupTag.LogPair = null;
			ConfigMusicSubTitleBySubtitleGroupTag.HandleId = 0;
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00127E31 File Offset: 0x00126031
		public static void Init()
		{
			ConfigMusicSubTitleBySubtitleGroupTag.HandleId = ConfigCommon.InitDataStatement(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, "db_musicsubtitle.db", "select BinData from `MusicSubTitle` where SubtitleGroupTag=?");
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00127E4C File Offset: 0x0012604C
		[return: Nullable(2)]
		public static IReadOnlyList<MusicSubTitle> GetConfigList(string p0SubtitleGroupTag, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, ConfigMusicSubTitleBySubtitleGroupTag.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MusicSubTitle> readOnlyList = (IReadOnlyList<MusicSubTitle>)ConfigCommon.GetConfig("MusicSubTitleBySubtitleGroupTag#" + p0SubtitleGroupTag);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMusicSubTitleBySubtitleGroupTag.LogPair.Clear();
			ConfigMusicSubTitleBySubtitleGroupTag.LogPair.Add(new ValueTuple<string, object>("SubtitleGroupTag", p0SubtitleGroupTag));
			if (!ConfigCommon.BindString(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, 1, p0SubtitleGroupTag, ConfigMusicSubTitleBySubtitleGroupTag.LogPair))
			{
				ConfigCommon.Reset(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, ConfigMusicSubTitleBySubtitleGroupTag.LogPair);
				return null;
			}
			List<MusicSubTitle> list = new List<MusicSubTitle>();
			while (ConfigCommon.Step(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, false, ConfigMusicSubTitleBySubtitleGroupTag.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, 0, ConfigMusicSubTitleBySubtitleGroupTag.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, ConfigMusicSubTitleBySubtitleGroupTag.LogPair);
					return null;
				}
				MusicSubTitle rootAsMusicSubTitle = MusicSubTitle.GetRootAsMusicSubTitle(new ByteBuffer(item2));
				list.Add(rootAsMusicSubTitle);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MusicSubTitleBySubtitleGroupTag#" + p0SubtitleGroupTag, list, list.Count);
			}
			ConfigCommon.Reset(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, ConfigMusicSubTitleBySubtitleGroupTag.LogPair);
			return list;
		}

		// Token: 0x040029AE RID: 10670
		private const string DB = "db_musicsubtitle.db";

		// Token: 0x040029AF RID: 10671
		private const string FILE = "k.可视化编辑/c.Csv/y.音乐字幕/*.csv*";

		// Token: 0x040029B0 RID: 10672
		private const string TABLE = "MusicSubTitle";

		// Token: 0x040029B1 RID: 10673
		private const string COMMAND = "select BinData from `MusicSubTitle` where SubtitleGroupTag=?";

		// Token: 0x040029B2 RID: 10674
		private const string KEY_PREFIX = "MusicSubTitleBySubtitleGroupTag";

		// Token: 0x040029B3 RID: 10675
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029B4 RID: 10676
		private static int HandleId;
	}
}
