using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200224C RID: 8780
[NullableContext(1)]
[Nullable(0)]
public class VolumeView : UiViewBase
{
	// Token: 0x06015B27 RID: 88871 RVA: 0x0064AEA3 File Offset: 0x006490A3
	public VolumeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015B28 RID: 88872 RVA: 0x0064AEB4 File Offset: 0x006490B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(3, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<float>(this.SetMasterVolume)),
			new ValueTuple<int, Delegate>(1, new Action<float>(this.SetMusicVolume)),
			new ValueTuple<int, Delegate>(2, new Action<float>(this.SetVoiceVolume)),
			new ValueTuple<int, Delegate>(3, new Action<float>(this.SetSfxVolume)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnCloseView)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnPlayMusic)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnPlayVoice)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnPlaySfx)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnPlayAllEvent))
		};
	}

	// Token: 0x06015B29 RID: 88873 RVA: 0x0064B075 File Offset: 0x00649275
	protected override void OnStart()
	{
		this.InitVolumceSlider();
	}

	// Token: 0x06015B2A RID: 88874 RVA: 0x0064B07D File Offset: 0x0064927D
	private void SetChildVolume(float value)
	{
		this.SetMusicVolume(value);
		this.SetVoiceVolume(value);
		this.SetSfxVolume(value);
	}

	// Token: 0x06015B2B RID: 88875 RVA: 0x0064B094 File Offset: 0x00649294
	private void InitVolumceSlider()
	{
		base.GetSlider(0).SetValue((float)this.MaxVolume, true);
		base.GetSlider(1).SetValue((float)this.MaxVolume, true);
		base.GetSlider(2).SetValue((float)this.MaxVolume, true);
		base.GetSlider(3).SetValue((float)this.MaxVolume, true);
	}

	// Token: 0x06015B2C RID: 88876 RVA: 0x0064B0F1 File Offset: 0x006492F1
	private void SetMasterVolume(float value)
	{
		this.MasterVolume = (int)value;
		this.SetChildVolume(value);
	}

	// Token: 0x06015B2D RID: 88877 RVA: 0x0064B102 File Offset: 0x00649302
	private void SetVoiceVolume(float value)
	{
		this.VoiceVolume = (int)value;
		if (this.VoiceVolume > this.MasterVolume)
		{
			this.VoiceVolume = this.MasterVolume;
		}
		UAkGameplayStatics.SetRTPCValue(null, (float)this.VoiceVolume, 0, null, VolumeView.Vocal_Audio_Bus_Volume);
	}

	// Token: 0x06015B2E RID: 88878 RVA: 0x0064B13A File Offset: 0x0064933A
	private void SetMusicVolume(float value)
	{
		this.MusicVolume = (int)value;
		if (this.MusicVolume > this.MasterVolume)
		{
			this.MusicVolume = this.MasterVolume;
		}
		UAkGameplayStatics.SetRTPCValue(null, (float)this.MusicVolume, 0, null, VolumeView.Music_Audio_Bus_Volume);
	}

	// Token: 0x06015B2F RID: 88879 RVA: 0x0064B172 File Offset: 0x00649372
	private void SetSfxVolume(float value)
	{
		this.SfxVolume = (int)value;
		if (this.SfxVolume > this.MasterVolume)
		{
			this.SfxVolume = this.MasterVolume;
		}
		UAkGameplayStatics.SetRTPCValue(null, (float)this.SfxVolume, 0, null, VolumeView.SFX_Audio_Bus_Volume);
	}

	// Token: 0x06015B30 RID: 88880 RVA: 0x0064B1AA File Offset: 0x006493AA
	private void OnCloseView()
	{
		UiManager.Instance.CloseView(EUiViewName.VolumeView, null);
	}

	// Token: 0x06015B31 RID: 88881 RVA: 0x0064B1BC File Offset: 0x006493BC
	private void OnPlayMusic()
	{
		this.PlayAudio("/Game/Aki/WwiseAudio/Events/Default_Work_Unit/Music_Event/Music_Play_Event/Test_Music.Test_Music");
	}

	// Token: 0x06015B32 RID: 88882 RVA: 0x0064B1C9 File Offset: 0x006493C9
	private void OnPlayVoice()
	{
		this.PlayAudio("/Game/Aki/WwiseAudio/Events/Default_Work_Unit/Vocal_Event/Play_Role_Atk_Vo_Test.Play_Role_Atk_Vo_Test");
	}

	// Token: 0x06015B33 RID: 88883 RVA: 0x0064B1D6 File Offset: 0x006493D6
	private void OnPlaySfx()
	{
		this.PlayAudio("/Game/Aki/WwiseAudio/Events/Default_Work_Unit/SFX_Event/SFX_Play_Event/Play_Swim_Stand.Play_Swim_Stand");
	}

	// Token: 0x06015B34 RID: 88884 RVA: 0x0064B1E4 File Offset: 0x006493E4
	private void OnPlayAllEvent()
	{
		this.FileDisplay("/Game/Aki/WwiseAudio/Events");
		this.PlayNum = 0;
		this.FailNum = 0;
		Log.Instance.Info(ELogModule.Audio, ELogAuthor.LRA, "开始进行音频播放检测!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.DoPlayAudio();
	}

	// Token: 0x06015B35 RID: 88885 RVA: 0x0064B22C File Offset: 0x0064942C
	private unsafe void DoPlayAudio()
	{
		if (this.FileList != null && this.PlayNum < this.FileList.Num())
		{
			string path = this.FileList.Get(this.PlayNum);
			string audioEventPath = this.DoTruePath(path);
			this.PlayNum++;
			this.PlayAudio(audioEventPath);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LRA;
		string message = "音频播放检测完毕!!!";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("总数", this.FileList.Num().ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实际检测总数", this.PlayNum.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("失败总数", this.FailNum.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06015B36 RID: 88886 RVA: 0x0064B318 File Offset: 0x00649518
	[NullableContext(2)]
	private void PlayAudio(string audioEventPath)
	{
		AActor playerActor = Global.BaseCharacter;
		if (AudioController.Instance.GetAudioEvent(audioEventPath, false) != null)
		{
			int? num = AudioController.Instance.PlayAudioByEventPath(audioEventPath, playerActor, null, null, null, true, "");
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					goto IL_C3;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LRA;
			string message = "音频播放失败!!!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", audioEventPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.FailNum++;
			IL_C3:
			AudioController.Instance.StopAudio(playerActor);
			this.DoPlayAudio();
			return;
		}
		AudioController.Instance.LoadAndAddCallback(audioEventPath, delegate
		{
			int? num4 = AudioController.Instance.PlayAudioByEventPath(audioEventPath, playerActor, null, null, null, true, "");
			if (num4 != null)
			{
				int? num5 = num4;
				int num6 = 0;
				if (!(num5.GetValueOrDefault() == num6 & num5 != null))
				{
					goto IL_97;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.LRA;
			string message2 = "音频播放失败!!!";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", audioEventPath);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.FailNum++;
			IL_97:
			AudioController.Instance.StopAudio(playerActor);
			this.DoPlayAudio();
		}, null);
	}

	// Token: 0x06015B37 RID: 88887 RVA: 0x0064B41C File Offset: 0x0064961C
	protected override void OnBeforeDestroy()
	{
		AudioController.Instance.StopAudio(base.GetRootActor());
	}

	// Token: 0x06015B38 RID: 88888 RVA: 0x0064B430 File Offset: 0x00649630
	private void FileDisplay(string filePath)
	{
		this.FileList = UKuroStaticLibrary.FindFilesSorted(filePath, "*");
		List<int> list = new List<int>();
		for (int i = 0; i < this.FileList.Num(); i++)
		{
			if (this.FileList.Get(i).Contains("FOLDER"))
			{
				list.Add(i);
			}
		}
		list.Reverse();
		foreach (int index in list)
		{
			this.FileList.RemoveAt(index);
		}
	}

	// Token: 0x06015B39 RID: 88889 RVA: 0x0064B4D8 File Offset: 0x006496D8
	[return: Nullable(2)]
	private string DoTruePath(string path)
	{
		int num = path.IndexOf('.');
		if (num == -1)
		{
			return null;
		}
		int num2 = path.LastIndexOf('/');
		if (num2 == -1)
		{
			return null;
		}
		string newValue = path.Substring(num2 + 1, num - num2 - 1);
		string text = path.Replace("uasset", newValue);
		int num3 = text.IndexOf("/Aki");
		if (num3 == -1)
		{
			return null;
		}
		string oldValue = text.Substring(0, num3);
		return text.Replace(oldValue, "/Game");
	}

	// Token: 0x0400B72A RID: 46890
	private static readonly FName Vocal_Audio_Bus_Volume = new FName("volume_voice");

	// Token: 0x0400B72B RID: 46891
	private static readonly FName Music_Audio_Bus_Volume = new FName("volume_music");

	// Token: 0x0400B72C RID: 46892
	private static readonly FName SFX_Audio_Bus_Volume = new FName("volume_sfx");

	// Token: 0x0400B72D RID: 46893
	private readonly int MaxVolume = 100;

	// Token: 0x0400B72E RID: 46894
	private int MasterVolume;

	// Token: 0x0400B72F RID: 46895
	private int VoiceVolume;

	// Token: 0x0400B730 RID: 46896
	private int MusicVolume;

	// Token: 0x0400B731 RID: 46897
	private int SfxVolume;

	// Token: 0x0400B732 RID: 46898
	private int PlayNum;

	// Token: 0x0400B733 RID: 46899
	private int FailNum;

	// Token: 0x0400B734 RID: 46900
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> FileList;

	// Token: 0x020084AC RID: 33964
	[NullableContext(0)]
	private class EVolumeViewComponent
	{
		// Token: 0x0402AC87 RID: 175239
		public const int MasterVolumeSlider = 0;

		// Token: 0x0402AC88 RID: 175240
		public const int MusicVolumeSlider = 1;

		// Token: 0x0402AC89 RID: 175241
		public const int VoiceVolumeSlider = 2;

		// Token: 0x0402AC8A RID: 175242
		public const int SfxVolumeSlider = 3;

		// Token: 0x0402AC8B RID: 175243
		public const int CloseButton = 4;

		// Token: 0x0402AC8C RID: 175244
		public const int MusicButton = 5;

		// Token: 0x0402AC8D RID: 175245
		public const int VoiceButton = 6;

		// Token: 0x0402AC8E RID: 175246
		public const int SFXButton = 7;

		// Token: 0x0402AC8F RID: 175247
		public const int PlayAllEventButton = 8;
	}
}
