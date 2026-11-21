using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A24 RID: 23076
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolGalleryOpDetailView : UiViewBase
	{
		// Token: 0x06038D48 RID: 232776 RVA: 0x00FE8F50 File Offset: 0x00FE7150
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.BtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D49 RID: 232777 RVA: 0x00FE9038 File Offset: 0x00FE7238
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolGalleryOpDetailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolGalleryOpDetailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D4A RID: 232778 RVA: 0x00FE907C File Offset: 0x00FE727C
		private UniTask LoadVideoMaterial()
		{
			SolarSchoolGalleryOpDetailView.<LoadVideoMaterial>d__10 <LoadVideoMaterial>d__;
			<LoadVideoMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadVideoMaterial>d__.<>4__this = this;
			<LoadVideoMaterial>d__.<>1__state = -1;
			<LoadVideoMaterial>d__.<>t__builder.Start<SolarSchoolGalleryOpDetailView.<LoadVideoMaterial>d__10>(ref <LoadVideoMaterial>d__);
			return <LoadVideoMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x06038D4B RID: 232779 RVA: 0x00FE90BF File Offset: 0x00FE72BF
		private void CancelMaterialLoad()
		{
			if (this.MaterialLoadHandle == -1)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.MaterialLoadHandle);
			this.MaterialLoadHandle = -1;
		}

		// Token: 0x06038D4C RID: 232780 RVA: 0x00FE90E2 File Offset: 0x00FE72E2
		private void OnVideoStart(string _)
		{
			this.PlayAudio();
		}

		// Token: 0x06038D4D RID: 232781 RVA: 0x00FE90EA File Offset: 0x00FE72EA
		private void OnVideoEnd(string _)
		{
			this.PlayAudio();
		}

		// Token: 0x06038D4E RID: 232782 RVA: 0x00FE90F4 File Offset: 0x00FE72F4
		private string GetAudioEventName()
		{
			string audioResource = this.Data.Config.AudioResource;
			if (string.IsNullOrEmpty(audioResource))
			{
				return null;
			}
			return AudioSystem.Instance.parseAudioEventPathInConfig(audioResource);
		}

		// Token: 0x06038D4F RID: 232783 RVA: 0x00FE9128 File Offset: 0x00FE7328
		private void PlayAudio()
		{
			this.StopAudio();
			string audioEventName = this.GetAudioEventName();
			if (audioEventName == null)
			{
				return;
			}
			this.AudioHandle = AudioSystem.Instance.PostEvent(audioEventName);
		}

		// Token: 0x06038D50 RID: 232784 RVA: 0x00FE9158 File Offset: 0x00FE7358
		private void StopAudio()
		{
			if (this.AudioHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, null);
			this.AudioHandle = 0;
		}

		// Token: 0x06038D51 RID: 232785 RVA: 0x00FE9190 File Offset: 0x00FE7390
		private void SetAudioPaused(bool isPaused)
		{
			if (this.AudioHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, isPaused ? EAudioActionType.Pause : EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
		}

		// Token: 0x06038D52 RID: 232786 RVA: 0x00FE91D8 File Offset: 0x00FE73D8
		private void SeekAudioToVideo()
		{
			if (this.AudioHandle == 0)
			{
				return;
			}
			string audioEventName = this.GetAudioEventName();
			MediaPlayer mediaPlayer = this.MediaPlayer;
			FTimespan ftimespan = (mediaPlayer != null) ? mediaPlayer.GetPlayTime() : null;
			if (audioEventName == null || ftimespan == null)
			{
				return;
			}
			int position = (int)UKismetMathLibrary.GetTotalMilliseconds(ftimespan);
			AudioSystem.Instance.SeekOnEvent(audioEventName, position, new SeekOnEventArgs?(new SeekOnEventArgs
			{
				Handle = new int?(this.AudioHandle)
			}));
		}

		// Token: 0x06038D53 RID: 232787 RVA: 0x00FE924C File Offset: 0x00FE744C
		private void BtnClick()
		{
			if (!this.IsPlaying)
			{
				UiAudioSystem.Instance.PlayViewBgm(this, string.Empty);
				MediaPlayer mediaPlayer = this.MediaPlayer;
				if (mediaPlayer != null)
				{
					mediaPlayer.PlayVideo(this.Data.Config.Video, this.Data.Config.Video, true);
				}
				base.GetItem(3).SetUIActive(false);
				this.IsPlaying = true;
				return;
			}
			if (this.IsPaused)
			{
				MediaPlayer mediaPlayer2 = this.MediaPlayer;
				if (mediaPlayer2 != null)
				{
					mediaPlayer2.ResumeVideo(this.Data.Config.Video);
				}
			}
			else
			{
				MediaPlayer mediaPlayer3 = this.MediaPlayer;
				if (mediaPlayer3 != null)
				{
					mediaPlayer3.PauseVideo(this.Data.Config.Video);
				}
			}
			this.IsPaused = !this.IsPaused;
			this.SetAudioPaused(this.IsPaused);
			if (!this.IsPaused)
			{
				this.SeekAudioToVideo();
			}
			base.GetItem(3).SetUIActive(this.IsPaused);
		}

		// Token: 0x06038D54 RID: 232788 RVA: 0x00FE933F File Offset: 0x00FE753F
		[NullableContext(1)]
		public SolarSchoolGalleryOpDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D55 RID: 232789 RVA: 0x00FE934F File Offset: 0x00FE754F
		protected override void OnStart()
		{
			this.Data = (this.OpenParam as SolarSchoolGalleryData);
		}

		// Token: 0x06038D56 RID: 232790 RVA: 0x00FE9362 File Offset: 0x00FE7562
		protected override void OnBeforeDestroy()
		{
			this.StopAudio();
			this.CancelMaterialLoad();
			MediaPlayer mediaPlayer = this.MediaPlayer;
			if (mediaPlayer != null)
			{
				mediaPlayer.Clear();
			}
			this.MediaPlayer = null;
		}

		// Token: 0x0401DE90 RID: 122512
		private SolarSchoolShortCaptionItem CaptionItem;

		// Token: 0x0401DE91 RID: 122513
		private SolarSchoolGalleryData Data;

		// Token: 0x0401DE92 RID: 122514
		private MediaPlayer MediaPlayer;

		// Token: 0x0401DE93 RID: 122515
		private bool IsPlaying;

		// Token: 0x0401DE94 RID: 122516
		private bool IsPaused;

		// Token: 0x0401DE95 RID: 122517
		private int AudioHandle;

		// Token: 0x0401DE96 RID: 122518
		private int MaterialLoadHandle = -1;

		// Token: 0x0200B5EF RID: 46575
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038434 RID: 230452
			public const int CaptionItem = 0;

			// Token: 0x04038435 RID: 230453
			public const int Btn = 1;

			// Token: 0x04038436 RID: 230454
			public const int Cg = 2;

			// Token: 0x04038437 RID: 230455
			public const int PauseItem = 3;
		}
	}
}
