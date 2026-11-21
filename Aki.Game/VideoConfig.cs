using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;

// Token: 0x02002240 RID: 8768
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class VideoConfig : ConfigBase
{
	// Token: 0x06015A78 RID: 88696 RVA: 0x0064803E File Offset: 0x0064623E
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06015A79 RID: 88697 RVA: 0x00648041 File Offset: 0x00646241
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06015A7A RID: 88698 RVA: 0x00648044 File Offset: 0x00646244
	public VideoData? GetVideoData(string videoName)
	{
		EPlayerGender eplayerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (eplayerGender == EPlayerGender.None)
		{
			eplayerGender = EPlayerGender.Female;
		}
		VideoData? config = ConfigVideoDataByCgNameAndGirlOrBoy.GetConfig(videoName, (int)eplayerGender, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Video;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "找不到cg视频配置！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名称", videoName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06015A7B RID: 88699 RVA: 0x006480A0 File Offset: 0x006462A0
	public IReadOnlyList<VideoSubtitle> GetVideoCaptions(string videoName, string language)
	{
		IReadOnlyList<VideoCaption> configList = ConfigVideoCaptionByCgName.GetConfigList(videoName, true);
		if (configList == null || configList.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Video;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "找不到cg字幕配置！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名称", videoName);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<VideoSubtitle>();
		}
		List<VideoSubtitle> list = new List<VideoSubtitle>();
		if (!(language == "en"))
		{
			if (!(language == "ja"))
			{
				if (!(language == "ko"))
				{
					goto IL_18F;
				}
				goto IL_133;
			}
		}
		else
		{
			using (IEnumerator<VideoCaption> enumerator = configList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VideoCaption videoCaption = enumerator.Current;
					if (videoCaption.DurationEn != 0)
					{
						list.Add(new VideoSubtitle(videoCaption.ShowMomentEn, videoCaption.DurationEn, videoCaption.CaptionText, videoCaption.CaptionId, videoCaption.IsPlaySubtitleVoice));
					}
				}
				goto IL_18F;
			}
		}
		using (IEnumerator<VideoCaption> enumerator = configList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				VideoCaption videoCaption2 = enumerator.Current;
				if (videoCaption2.DurationJa != 0)
				{
					list.Add(new VideoSubtitle(videoCaption2.ShowMomentJa, videoCaption2.DurationJa, videoCaption2.CaptionText, videoCaption2.CaptionId, videoCaption2.IsPlaySubtitleVoice));
				}
			}
			goto IL_18F;
		}
		IL_133:
		foreach (VideoCaption videoCaption3 in configList)
		{
			if (videoCaption3.DurationKo != 0)
			{
				list.Add(new VideoSubtitle(videoCaption3.ShowMomentKo, videoCaption3.DurationKo, videoCaption3.CaptionText, videoCaption3.CaptionId, videoCaption3.IsPlaySubtitleVoice));
			}
		}
		IL_18F:
		if (list.Count > 0)
		{
			return list;
		}
		foreach (VideoCaption videoCaption4 in configList)
		{
			list.Add(new VideoSubtitle(videoCaption4.ShowMoment, videoCaption4.Duration, videoCaption4.CaptionText, videoCaption4.CaptionId, videoCaption4.IsPlaySubtitleVoice));
		}
		return list;
	}

	// Token: 0x06015A7C RID: 88700 RVA: 0x006482D0 File Offset: 0x006464D0
	public IReadOnlyList<VideoQteConfig> GetVideoQte(string videoName, string language)
	{
		IReadOnlyList<VideoQte> configList = ConfigVideoQteByCgName.GetConfigList(videoName, true);
		if (configList == null || configList.Count == 0)
		{
			return new List<VideoQteConfig>();
		}
		List<VideoQteConfig> list = new List<VideoQteConfig>();
		if (!(language == "en"))
		{
			if (!(language == "ja"))
			{
				if (!(language == "ko"))
				{
					goto IL_125;
				}
				goto IL_DE;
			}
		}
		else
		{
			using (IEnumerator<VideoQte> enumerator = configList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VideoQte videoQte = enumerator.Current;
					if (videoQte.ShowMomentEn != 0)
					{
						list.Add(new VideoQteConfig(videoQte.ShowMomentEn, videoQte.QteId));
					}
				}
				goto IL_125;
			}
		}
		using (IEnumerator<VideoQte> enumerator = configList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				VideoQte videoQte2 = enumerator.Current;
				if (videoQte2.ShowMomentJa != 0)
				{
					list.Add(new VideoQteConfig(videoQte2.ShowMomentJa, videoQte2.QteId));
				}
			}
			goto IL_125;
		}
		IL_DE:
		foreach (VideoQte videoQte3 in configList)
		{
			if (videoQte3.ShowMomentKo != 0)
			{
				list.Add(new VideoQteConfig(videoQte3.ShowMomentKo, videoQte3.QteId));
			}
		}
		IL_125:
		if (list.Count > 0)
		{
			return list;
		}
		foreach (VideoQte videoQte4 in configList)
		{
			list.Add(new VideoQteConfig(videoQte4.ShowMoment, videoQte4.QteId));
		}
		return list;
	}

	// Token: 0x06015A7D RID: 88701 RVA: 0x00648480 File Offset: 0x00646680
	public string GetVideoCaptionText(VideoSubtitle videoCaption)
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(videoCaption.CaptionText, null);
		return PlotModel.Instance.PlotTextReplacer.Replace(localTextNew, false) ?? string.Empty;
	}

	// Token: 0x06015A7E RID: 88702 RVA: 0x006484B4 File Offset: 0x006466B4
	public IReadOnlyList<VideoSound> GetVideoSounds(string videoName)
	{
		IReadOnlyList<VideoSound> configList = ConfigVideoSoundByCgNameAndGirlOrBoy.GetConfigList(videoName, 2, true);
		if (configList == null || configList.Count == 0)
		{
			EPlayerGender eplayerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (eplayerGender == EPlayerGender.None)
			{
				eplayerGender = EPlayerGender.Female;
			}
			configList = ConfigVideoSoundByCgNameAndGirlOrBoy.GetConfigList(videoName, (int)eplayerGender, true);
		}
		if (configList == null || configList.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Video;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "找不到cg字幕配置！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名称", videoName);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<VideoSound>();
		}
		return configList;
	}

	// Token: 0x170020D7 RID: 8407
	// (get) Token: 0x06015A7F RID: 88703 RVA: 0x0064852B File Offset: 0x0064672B
	public static VideoConfig Instance
	{
		get
		{
			return VideoConfig._Instance;
		}
	}

	// Token: 0x06015A80 RID: 88704 RVA: 0x00648532 File Offset: 0x00646732
	public static VideoConfig GetOrCreateInstance()
	{
		if (VideoConfig._Instance == null)
		{
			VideoConfig.CreateInstance();
		}
		return VideoConfig._Instance;
	}

	// Token: 0x06015A81 RID: 88705 RVA: 0x00648546 File Offset: 0x00646746
	public static bool CreateInstance()
	{
		if (VideoConfig._Instance != null)
		{
			return true;
		}
		VideoConfig._Instance = new VideoConfig();
		return true;
	}

	// Token: 0x06015A82 RID: 88706 RVA: 0x0064855C File Offset: 0x0064675C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015A83 RID: 88707 RVA: 0x0064855E File Offset: 0x0064675E
	public static void ResetStaticDefaultValue()
	{
		VideoConfig._Instance = null;
	}

	// Token: 0x06015A84 RID: 88708 RVA: 0x00648566 File Offset: 0x00646766
	static VideoConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoConfig.CreateStaticDefaultValue), new Action(VideoConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B6D2 RID: 46802
	[Nullable(2)]
	private static VideoConfig _Instance;
}
