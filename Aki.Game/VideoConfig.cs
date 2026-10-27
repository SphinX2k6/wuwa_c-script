using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;

// Token: 0x02002CE7 RID: 11495
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class VideoConfig : ConfigBase
{
	// Token: 0x060181F9 RID: 98809 RVA: 0x006223CA File Offset: 0x006205CA
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060181FA RID: 98810 RVA: 0x006223CD File Offset: 0x006205CD
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060181FB RID: 98811 RVA: 0x006223D0 File Offset: 0x006205D0
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

	// Token: 0x060181FC RID: 98812 RVA: 0x0062242C File Offset: 0x0062062C
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

	// Token: 0x060181FD RID: 98813 RVA: 0x0062265C File Offset: 0x0062085C
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

	// Token: 0x060181FE RID: 98814 RVA: 0x0062280C File Offset: 0x00620A0C
	public string GetVideoCaptionText(VideoSubtitle videoCaption)
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(videoCaption.CaptionText, null);
		return PlotModel.Instance.PlotTextReplacer.Replace(localTextNew, false) ?? string.Empty;
	}

	// Token: 0x060181FF RID: 98815 RVA: 0x00622840 File Offset: 0x00620A40
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

	// Token: 0x17002084 RID: 8324
	// (get) Token: 0x06018200 RID: 98816 RVA: 0x006228B7 File Offset: 0x00620AB7
	public static VideoConfig Instance
	{
		get
		{
			return VideoConfig._Instance;
		}
	}

	// Token: 0x06018201 RID: 98817 RVA: 0x006228BE File Offset: 0x00620ABE
	public static VideoConfig GetOrCreateInstance()
	{
		if (VideoConfig._Instance == null)
		{
			VideoConfig.CreateInstance();
		}
		return VideoConfig._Instance;
	}

	// Token: 0x06018202 RID: 98818 RVA: 0x006228D2 File Offset: 0x00620AD2
	public static bool CreateInstance()
	{
		if (VideoConfig._Instance != null)
		{
			return true;
		}
		VideoConfig._Instance = new VideoConfig();
		return true;
	}

	// Token: 0x06018203 RID: 98819 RVA: 0x006228E8 File Offset: 0x00620AE8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018204 RID: 98820 RVA: 0x006228EA File Offset: 0x00620AEA
	public static void ResetStaticDefaultValue()
	{
		VideoConfig._Instance = null;
	}

	// Token: 0x06018205 RID: 98821 RVA: 0x006228F2 File Offset: 0x00620AF2
	static VideoConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoConfig.CreateStaticDefaultValue), new Action(VideoConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B366 RID: 45926
	[Nullable(2)]
	private static VideoConfig _Instance;
}
