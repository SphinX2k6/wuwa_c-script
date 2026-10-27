using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002CF2 RID: 11506
[NullableContext(1)]
[Nullable(0)]
public class VolumeView : UiViewBase
{
	// Token: 0x06018286 RID: 98950 RVA: 0x00624EDF File Offset: 0x006230DF
	public VolumeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06018287 RID: 98951 RVA: 0x00624EF0 File Offset: 0x006230F0
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

	// Token: 0x06018288 RID: 98952 RVA: 0x006250B1 File Offset: 0x006232B1
	protected override void OnStart()
	{
		this.InitVolumceSlider();
	}

	// Token: 0x06018289 RID: 98953 RVA: 0x006250B9 File Offset: 0x006232B9
	private void SetChildVolume(float value)
	{
		this.SetMusicVolume(value);
		this.SetVoiceVolume(value);
		this.SetSfxVolume(value);
	}

	// Token: 0x0601828A RID: 98954 RVA: 0x006250D0 File Offset: 0x006232D0
	private void InitVolumceSlider()
	{
		base.GetSlider(0).SetValue((float)this.MaxVolume, true);
		base.GetSlider(1).SetValue((float)this.MaxVolume, true);
		base.GetSlider(2).SetValue((float)this.MaxVolume, true);
		base.GetSlider(3).SetValue((float)this.MaxVolume, true);
	}

	// Token: 0x0601828B RID: 98955 RVA: 0x0062512D File Offset: 0x0062332D
	private void SetMasterVolume(float value)
	{
		this.MasterVolume = (int)value;
		this.SetChildVolume(value);
	}

	// Token: 0x0601828C RID: 98956 RVA: 0x0062513E File Offset: 0x0062333E
	private void SetVoiceVolume(float value)
	{
		this.VoiceVolume = (int)value;
		if (this.VoiceVolume > this.MasterVolume)
		{
			this.VoiceVolume = this.MasterVolume;
		}
		UAkGameplayStatics.SetRTPCValue(null, (float)this.VoiceVolume, 0, null, VolumeView.Vocal_Audio_Bus_Volume);
	}

	// Token: 0x0601828D RID: 98957 RVA: 0x00625176 File Offset: 0x00623376
	private void SetMusicVolume(float value)
	{
		this.MusicVolume = (int)value;
		if (this.MusicVolume > this.MasterVolume)
		{
			this.MusicVolume = this.MasterVolume;
		}
		UAkGameplayStatics.SetRTPCValue(null, (float)this.MusicVolume, 0, null, VolumeView.Music_Audio_Bus_Volume);
	}

	// Token: 0x0601828E RID: 98958 RVA: 0x006251AE File Offset: 0x006233AE
	private void SetSfxVolume(float value)
	{
		this.SfxVolume = (int)value;
		if (this.SfxVolume > this.MasterVolume)
		{
			this.SfxVolume = this.MasterVolume;
		}
		UAkGameplayStatics.SetRTPCValue(null, (float)this.SfxVolume, 0, null, VolumeView.SFX_Audio_Bus_Volume);
	}

	// Token: 0x0601828F RID: 98959 RVA: 0x006251E6 File Offset: 0x006233E6
	private void OnCloseView()
	{
		UiManager.Instance.CloseView(EUiViewName.VolumeView, null);
	}

	// Token: 0x06018290 RID: 98960 RVA: 0x006251F8 File Offset: 0x006233F8
	private void OnPlayMusic()
	{
		this.PlayAudio("/Game/Aki/WwiseAudio/Events/Default_Work_Unit/Music_Event/Music_Play_Event/Test_Music.Test_Music");
	}

	// Token: 0x06018291 RID: 98961 RVA: 0x00625205 File Offset: 0x00623405
	private void OnPlayVoice()
	{
		this.PlayAudio("/Game/Aki/WwiseAudio/Events/Default_Work_Unit/Vocal_Event/Play_Role_Atk_Vo_Test.Play_Role_Atk_Vo_Test");
	}

	// Token: 0x06018292 RID: 98962 RVA: 0x00625212 File Offset: 0x00623412
	private void OnPlaySfx()
	{
		this.PlayAudio("/Game/Aki/WwiseAudio/Events/Default_Work_Unit/SFX_Event/SFX_Play_Event/Play_Swim_Stand.Play_Swim_Stand");
	}

	// Token: 0x06018293 RID: 98963 RVA: 0x00625220 File Offset: 0x00623420
	private void OnPlayAllEvent()
	{
		this.FileDisplay("/Game/Aki/WwiseAudio/Events");
		this.PlayNum = 0;
		this.FailNum = 0;
		Log.Instance.Info(ELogModule.Audio, ELogAuthor.LRA, "开始进行音频播放检测!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.DoPlayAudio();
	}

	// Token: 0x06018294 RID: 98964 RVA: 0x00625268 File Offset: 0x00623468
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

	// Token: 0x06018295 RID: 98965 RVA: 0x00625354 File Offset: 0x00623554
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

	// Token: 0x06018296 RID: 98966 RVA: 0x00625458 File Offset: 0x00623658
	protected override void OnBeforeDestroy()
	{
		AudioController.Instance.StopAudio(base.GetRootActor());
	}

	// Token: 0x06018297 RID: 98967 RVA: 0x0062546C File Offset: 0x0062366C
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

	// Token: 0x06018298 RID: 98968 RVA: 0x00625514 File Offset: 0x00623714
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

	// Token: 0x0400B3B5 RID: 46005
	private static readonly FName Vocal_Audio_Bus_Volume = new FName("volume_voice");

	// Token: 0x0400B3B6 RID: 46006
	private static readonly FName Music_Audio_Bus_Volume = new FName("volume_music");

	// Token: 0x0400B3B7 RID: 46007
	private static readonly FName SFX_Audio_Bus_Volume = new FName("volume_sfx");

	// Token: 0x0400B3B8 RID: 46008
	private readonly int MaxVolume = 100;

	// Token: 0x0400B3B9 RID: 46009
	private int MasterVolume;

	// Token: 0x0400B3BA RID: 46010
	private int VoiceVolume;

	// Token: 0x0400B3BB RID: 46011
	private int MusicVolume;

	// Token: 0x0400B3BC RID: 46012
	private int SfxVolume;

	// Token: 0x0400B3BD RID: 46013
	private int PlayNum;

	// Token: 0x0400B3BE RID: 46014
	private int FailNum;

	// Token: 0x0400B3BF RID: 46015
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> FileList;

	// Token: 0x02009284 RID: 37508
	[NullableContext(0)]
	private class EVolumeViewComponent
	{
		// Token: 0x0402F5FD RID: 194045
		public const int MasterVolumeSlider = 0;

		// Token: 0x0402F5FE RID: 194046
		public const int MusicVolumeSlider = 1;

		// Token: 0x0402F5FF RID: 194047
		public const int VoiceVolumeSlider = 2;

		// Token: 0x0402F600 RID: 194048
		public const int SfxVolumeSlider = 3;

		// Token: 0x0402F601 RID: 194049
		public const int CloseButton = 4;

		// Token: 0x0402F602 RID: 194050
		public const int MusicButton = 5;

		// Token: 0x0402F603 RID: 194051
		public const int VoiceButton = 6;

		// Token: 0x0402F604 RID: 194052
		public const int SFXButton = 7;

		// Token: 0x0402F605 RID: 194053
		public const int PlayAllEventButton = 8;
	}
}
