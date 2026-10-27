using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E0 RID: 1504
	public class ConfigMusicSubTitleBySubtitleGroupTag : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600234F RID: 9039 RVA: 0x00121308 File Offset: 0x0011F508
		static ConfigMusicSubTitleBySubtitleGroupTag()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicSubTitleBySubtitleGroupTag.CreateStaticDefaultValue), new Action(ConfigMusicSubTitleBySubtitleGroupTag.ResetStaticDefaultValue));
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00121328 File Offset: 0x0011F528
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

		// Token: 0x06002351 RID: 9041 RVA: 0x001213A7 File Offset: 0x0011F5A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicSubTitleBySubtitleGroupTag.LogPair = null;
			ConfigMusicSubTitleBySubtitleGroupTag.HandleId = 0;
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x001213B5 File Offset: 0x0011F5B5
		public static void Init()
		{
			ConfigMusicSubTitleBySubtitleGroupTag.HandleId = ConfigCommon.InitDataStatement(ConfigMusicSubTitleBySubtitleGroupTag.HandleId, "db_musicsubtitle.db", "select BinData from `MusicSubTitle` where SubtitleGroupTag=?");
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x001213D0 File Offset: 0x0011F5D0
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

		// Token: 0x04002906 RID: 10502
		private const string DB = "db_musicsubtitle.db";

		// Token: 0x04002907 RID: 10503
		private const string FILE = "k.可视化编辑/c.Csv/y.音乐字幕/*.csv*";

		// Token: 0x04002908 RID: 10504
		private const string TABLE = "MusicSubTitle";

		// Token: 0x04002909 RID: 10505
		private const string COMMAND = "select BinData from `MusicSubTitle` where SubtitleGroupTag=?";

		// Token: 0x0400290A RID: 10506
		private const string KEY_PREFIX = "MusicSubTitleBySubtitleGroupTag";

		// Token: 0x0400290B RID: 10507
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400290C RID: 10508
		private static int HandleId;
	}
}
