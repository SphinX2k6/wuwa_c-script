using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FB8 RID: 24504
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37View : ActivitySubViewBase
	{
		// Token: 0x0603E1C4 RID: 254404 RVA: 0x00EFF9B8 File Offset: 0x00EFDBB8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIText)),
				new ValueTuple<int, Type>(16, typeof(UUISprite)),
				new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(18, typeof(UUITexture)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUITexture)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickHelp)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickFirstReward)),
				new ValueTuple<int, Delegate>(17, new Action(this.OnClickGotoStore)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickArrowLeft)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickArrowRight)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickPreviewReward)),
				new ValueTuple<int, Delegate>(23, new Action(this.OnClickMagnifier))
			};
		}

		// Token: 0x0603E1C5 RID: 254405 RVA: 0x00EFFC90 File Offset: 0x00EFDE90
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUp37View.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUp37View.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1C6 RID: 254406 RVA: 0x00EFFCD3 File Offset: 0x00EFDED3
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (sequenceName == "Switch" && eventName == "Switch")
			{
				this.ApplyRotationIndex(this.PendingRotationIndex);
			}
		}

		// Token: 0x0603E1C7 RID: 254407 RVA: 0x00EFFCFC File Offset: 0x00EFDEFC
		protected override UniTask OnBeforeShowSelfAsync()
		{
			TotalTopUp37View.<OnBeforeShowSelfAsync>d__27 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<TotalTopUp37View.<OnBeforeShowSelfAsync>d__27>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1C8 RID: 254408 RVA: 0x00EFFD40 File Offset: 0x00EFDF40
		protected override UniTask OnBeforeHideSelfAsync()
		{
			TotalTopUp37View.<OnBeforeHideSelfAsync>d__28 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<TotalTopUp37View.<OnBeforeHideSelfAsync>d__28>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1C9 RID: 254409 RVA: 0x00EFFD83 File Offset: 0x00EFDF83
		protected override void OnBeforeHide()
		{
			this.ApplyVolumeState("mute", "切走活动页暂停视频与音乐");
			MediaPlayer videoPlayer = this.VideoPlayer;
			if (videoPlayer != null)
			{
				videoPlayer.PauseVideo("TotalTopUp37View");
			}
			this.PauseMusic();
		}

		// Token: 0x0603E1CA RID: 254410 RVA: 0x00EFFDB1 File Offset: 0x00EFDFB1
		protected override void OnBeforeShow()
		{
			MediaPlayer videoPlayer = this.VideoPlayer;
			if (videoPlayer != null)
			{
				videoPlayer.ResumeVideo("TotalTopUp37View");
			}
			if (this.MusicResumed)
			{
				this.ResumeMusic();
			}
		}

		// Token: 0x0603E1CB RID: 254411 RVA: 0x00EFFDD8 File Offset: 0x00EFDFD8
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(16);
			this.ProgressBarMaxWidth = ((sprite != null) ? sprite.GetWidth() : 0f);
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			this.Refresh(totalTopUpData);
			this.StartRotation(totalTopUpData.PageViewModel);
		}

		// Token: 0x0603E1CC RID: 254412 RVA: 0x00EFFE24 File Offset: 0x00EFE024
		protected override void OnRefreshView()
		{
			TotalTopUpUtil.Debug("TotalTopUp37View刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			TotalTopUpData data = this.ActivityBaseData as TotalTopUpData;
			this.Refresh(data);
		}

		// Token: 0x0603E1CD RID: 254413 RVA: 0x00EFFE58 File Offset: 0x00EFE058
		protected override void OnTimer(float gap)
		{
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			if (totalTopUpData == null)
			{
				return;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double time = (double)totalTopUpData.EndOpenTime - serverTime;
			this.RefreshTime(time);
			this.TickRotation(gap);
		}

		// Token: 0x0603E1CE RID: 254414 RVA: 0x00EFFE98 File Offset: 0x00EFE098
		private void Refresh(TotalTopUpData data)
		{
			TotalTopUpPageViewModel pageViewModel = data.PageViewModel;
			TotalTopUp37RewardListPanel rewardListPanel = this.RewardListPanel;
			if (rewardListPanel != null)
			{
				rewardListPanel.Refresh(pageViewModel);
			}
			this.ReapplyCurrentRotationMark();
			this.RefreshFirstReward(pageViewModel);
			this.RefreshProgress(pageViewModel);
		}

		// Token: 0x0603E1CF RID: 254415 RVA: 0x00EFFED4 File Offset: 0x00EFE0D4
		private void ReapplyCurrentRotationMark()
		{
			IReadOnlyList<TotalTopUpRotation> rotationList = this.GetRotationList();
			if (this.CurrentRotationIndex >= 0 && this.CurrentRotationIndex < rotationList.Count)
			{
				TotalTopUp37RewardListPanel rewardListPanel = this.RewardListPanel;
				if (rewardListPanel == null)
				{
					return;
				}
				rewardListPanel.MarkPreview(rotationList[this.CurrentRotationIndex].Id);
			}
		}

		// Token: 0x0603E1D0 RID: 254416 RVA: 0x00EFFF24 File Offset: 0x00EFE124
		private void RefreshFirstReward(TotalTopUpPageViewModel viewModel)
		{
			TotalTopUpPageRewardViewModel totalTopUpPageRewardViewModel = (viewModel.RewardViewModels.Count > 0) ? viewModel.RewardViewModels[0] : null;
			bool uiactive = totalTopUpPageRewardViewModel != null && totalTopUpPageRewardViewModel.State == ETotalTopUpRewardState.CanClaim;
			bool uiactive2 = totalTopUpPageRewardViewModel != null && totalTopUpPageRewardViewModel.State == ETotalTopUpRewardState.Claimed;
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive2);
			}
			UUIItem item3 = base.GetItem(22);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(uiactive);
		}

		// Token: 0x0603E1D1 RID: 254417 RVA: 0x00EFFFAC File Offset: 0x00EFE1AC
		private unsafe void RefreshProgress(TotalTopUpPageViewModel viewModel)
		{
			string message = "TotalTopUp37View进度刷新";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentScore", viewModel.CurrentScore);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NextScore", viewModel.NextScore);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ProgressPercent", viewModel.ProgressPercent);
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			UUIText text = base.GetText(15);
			if (text != null)
			{
				string inString = "<size=64>{0}/</size>{1}";
				string[] array = new string[2];
				int num = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(viewModel.CurrentScore);
				array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
				int num2 = 1;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(viewModel.NextScore);
				array[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
				text.SetText(StringUtils.Format(inString, array), true);
			}
			UUISprite sprite = base.GetSprite(16);
			if (sprite != null)
			{
				sprite.SetWidth(this.ProgressBarMaxWidth * viewModel.ProgressPercent);
			}
			bool flag = viewModel.ProgressPercent >= 1f;
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			UUIItem item3 = base.GetItem(14);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(!flag);
		}

		// Token: 0x0603E1D2 RID: 254418 RVA: 0x00F00110 File Offset: 0x00EFE310
		private void RefreshTime(double time)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(time);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, "TotalTopUp_1001", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? ""));
		}

		// Token: 0x0603E1D3 RID: 254419 RVA: 0x00F00158 File Offset: 0x00EFE358
		private void StartRotation(TotalTopUpPageViewModel viewModel)
		{
			IReadOnlyList<TotalTopUpRotation> rotationList = viewModel.RotationList;
			if (rotationList.Count <= 0)
			{
				this.AutoRotateEnabled = false;
				this.SetRotationBoardActive(false);
				return;
			}
			this.SetRotationBoardActive(true);
			this.InitPageDots(rotationList.Count);
			this.AutoRotateEnabled = true;
			this.ApplyRotationIndex(0);
		}

		// Token: 0x0603E1D4 RID: 254420 RVA: 0x00F001A8 File Offset: 0x00EFE3A8
		private void InitPageDots(int count)
		{
			this.PageDotSprites.Clear();
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			UUIItem parentAsUIItem = item.GetParentAsUIItem();
			AActor owner = item.GetOwner();
			for (int i = 0; i < count; i++)
			{
				UUIItem uuiitem = (i == 0) ? item : this.DuplicatePageDot(owner, parentAsUIItem);
				if (uuiitem != null)
				{
					UUIItem item2 = uuiitem.GetAttachUIChildren().Get(0);
					this.PageDotSprites.Add(item2);
				}
			}
		}

		// Token: 0x0603E1D5 RID: 254421 RVA: 0x00F00216 File Offset: 0x00EFE416
		[NullableContext(2)]
		private UUIItem DuplicatePageDot(AActor templateActor, UUIItem parentItem)
		{
			if (templateActor == null)
			{
				return null;
			}
			AActor aactor = LguiUtil.Instance.DuplicateActor(templateActor, parentItem);
			return ((aactor != null) ? aactor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
		}

		// Token: 0x0603E1D6 RID: 254422 RVA: 0x00F00244 File Offset: 0x00EFE444
		private void RefreshPageDot(int currentIndex)
		{
			for (int i = 0; i < this.PageDotSprites.Count; i++)
			{
				UUIItem uuiitem = this.PageDotSprites[i];
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(i == currentIndex);
				}
			}
		}

		// Token: 0x0603E1D7 RID: 254423 RVA: 0x00F00284 File Offset: 0x00EFE484
		private void TickRotation(float gap)
		{
			IReadOnlyList<TotalTopUpRotation> rotationList = this.GetRotationList();
			if (!this.AutoRotateEnabled || rotationList.Count <= 1)
			{
				return;
			}
			if (this.CurrentRotationIndex < 0 || this.CurrentRotationIndex >= rotationList.Count)
			{
				return;
			}
			TotalTopUpRotation totalTopUpRotation = rotationList[this.CurrentRotationIndex];
			this.RotationElapsedMs += gap;
			if (this.RotationElapsedMs >= (float)(totalTopUpRotation.ShowDuration * TimeUtil.Instance.InverseMillisecond))
			{
				int index = (this.CurrentRotationIndex + 1) % rotationList.Count;
				this.GotoRotationIndex(index);
			}
		}

		// Token: 0x0603E1D8 RID: 254424 RVA: 0x00F00310 File Offset: 0x00EFE510
		private void GotoRotationIndex(int index)
		{
			double nowSeconds = Time.Instance.NowSeconds;
			if (nowSeconds < this.NextRotationSwitchTime)
			{
				return;
			}
			IReadOnlyList<TotalTopUpRotation> rotationList = this.GetRotationList();
			if (index < 0 || index >= rotationList.Count)
			{
				return;
			}
			this.NextRotationSwitchTime = nowSeconds + 0.3;
			this.RotationElapsedMs = 0f;
			this.PendingRotationIndex = index;
			this.PlaySubViewSequence("Switch", false);
		}

		// Token: 0x0603E1D9 RID: 254425 RVA: 0x00F00378 File Offset: 0x00EFE578
		private void ApplyRotationIndex(int index)
		{
			IReadOnlyList<TotalTopUpRotation> rotationList = this.GetRotationList();
			if (index < 0 || index >= rotationList.Count)
			{
				return;
			}
			this.CurrentRotationIndex = index;
			this.RotationElapsedMs = 0f;
			this.ShowRotationPage(rotationList[index]);
		}

		// Token: 0x0603E1DA RID: 254426 RVA: 0x00F003BC File Offset: 0x00EFE5BC
		private void ShowRotationPage(TotalTopUpRotation rotation)
		{
			this.CurrentMusicName = (rotation.MusicName ?? "");
			this.ShowPreviewContent(rotation.PreviewType, rotation.ResourcePath);
			TotalTopUp37RewardListPanel rewardListPanel = this.RewardListPanel;
			if (rewardListPanel != null)
			{
				rewardListPanel.MarkPreview(rotation.Id);
			}
			this.RefreshPageDot(this.CurrentRotationIndex);
			this.RefreshArrowActive();
			this.RefreshPreviewName(rotation.PreviewName);
			this.RefreshPreviewScore(rotation.Id);
		}

		// Token: 0x0603E1DB RID: 254427 RVA: 0x00F00438 File Offset: 0x00EFE638
		private unsafe void ShowPreviewContent(int previewType, string resourcePath)
		{
			string message = "TotalTopUp37View轮播切页";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", this.CurrentRotationIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PreviewType", previewType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ResourcePath", resourcePath);
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (previewType == 1)
			{
				this.ShowImagePreview(resourcePath);
				return;
			}
			if (previewType != 2)
			{
				return;
			}
			this.ShowVideoPreview(resourcePath);
		}

		// Token: 0x0603E1DC RID: 254428 RVA: 0x00F004D0 File Offset: 0x00EFE6D0
		private void ShowImagePreview(string resourcePath)
		{
			this.StopVideo();
			this.StopMusic();
			this.CurrentVideoPath = "";
			base.SetButtonUiActive(3, false);
			base.SetButtonUiActive(23, false);
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUITexture texture = base.GetTexture(18);
			if (texture != null)
			{
				texture.SetUIActive(resourcePath.Length > 0);
			}
			if (resourcePath.Length > 0)
			{
				base.SetTextureByPath(resourcePath, texture, null, null);
			}
		}

		// Token: 0x0603E1DD RID: 254429 RVA: 0x00F00550 File Offset: 0x00EFE750
		private void ShowVideoPreview(string resourcePath)
		{
			UUITexture texture = base.GetTexture(18);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			bool flag = resourcePath.Length > 0;
			this.CurrentVideoPath = resourcePath;
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			base.SetButtonUiActive(23, flag);
			base.SetButtonUiActive(3, flag);
			if (!flag)
			{
				return;
			}
			this.VideoPlayer = (this.VideoPlayer ?? new MediaPlayer(base.GetTexture(20)));
			this.VideoPlayer.BindCallbackOnVideoEnd(new Action<string>(this.OnVideoLoopEnd));
			if (Info.Instance.PlatformType == ESourcePlatformType.Android)
			{
				this.LoadVideoMaterial().ContinueWith(delegate()
				{
					MediaPlayer videoPlayer = this.VideoPlayer;
					if (videoPlayer == null)
					{
						return;
					}
					videoPlayer.PlayVideo("TotalTopUp37View", resourcePath, true);
				}).Forget();
			}
			else
			{
				this.VideoPlayer.PlayVideo("TotalTopUp37View", resourcePath, true);
			}
			this.PlayMusicAndSync();
		}

		// Token: 0x0603E1DE RID: 254430 RVA: 0x00F00648 File Offset: 0x00EFE848
		private UniTask LoadVideoMaterial()
		{
			TotalTopUp37View.<LoadVideoMaterial>d__50 <LoadVideoMaterial>d__;
			<LoadVideoMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadVideoMaterial>d__.<>4__this = this;
			<LoadVideoMaterial>d__.<>1__state = -1;
			<LoadVideoMaterial>d__.<>t__builder.Start<TotalTopUp37View.<LoadVideoMaterial>d__50>(ref <LoadVideoMaterial>d__);
			return <LoadVideoMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1DF RID: 254431 RVA: 0x00F0068B File Offset: 0x00EFE88B
		private void StopVideo()
		{
			MediaPlayer videoPlayer = this.VideoPlayer;
			if (videoPlayer == null)
			{
				return;
			}
			videoPlayer.StopVideo("TotalTopUp37View");
		}

		// Token: 0x0603E1E0 RID: 254432 RVA: 0x00F006A4 File Offset: 0x00EFE8A4
		[NullableContext(2)]
		private void OnVideoLoopEnd(string videoName)
		{
			TotalTopUpUtil.Debug("[音频]视频循环重置音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.PlayMusicAndSync();
		}

		// Token: 0x0603E1E1 RID: 254433 RVA: 0x00F006CC File Offset: 0x00EFE8CC
		private unsafe void PlayMusicAndSync()
		{
			this.StopMusic();
			if (this.CurrentMusicName.Length <= 0)
			{
				return;
			}
			this.MusicHandle = AudioSystem.Instance.PostEvent(this.CurrentMusicName);
			AudioSystem.Instance.ExecuteAction(this.MusicHandle, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			int videoPositionMs = this.GetVideoPositionMs();
			string message = "[音频]主页音乐起播并同步";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MusicName", this.CurrentMusicName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VideoPositionMs", videoPositionMs);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MusicResumed", this.MusicResumed);
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.SeekMusicTo(videoPositionMs);
			if (this.MusicResumed)
			{
				AudioSystem.Instance.ExecuteAction(this.MusicHandle, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
		}

		// Token: 0x0603E1E2 RID: 254434 RVA: 0x00F007E8 File Offset: 0x00EFE9E8
		private unsafe void ApplyVolumeState(string state, string reason)
		{
			string message = "[音频]TotalTopUp37View视频音量切换";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("State", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			AudioSystem.Instance.SetState("ui_video_volume", state, true);
		}

		// Token: 0x0603E1E3 RID: 254435 RVA: 0x00F00850 File Offset: 0x00EFEA50
		private int GetVideoPositionMs()
		{
			MediaPlayer videoPlayer = this.VideoPlayer;
			FTimespan ftimespan = (videoPlayer != null) ? videoPlayer.GetPlayTime() : null;
			if (ftimespan == null)
			{
				return 0;
			}
			return (int)UKismetMathLibrary.GetTotalMilliseconds(ftimespan);
		}

		// Token: 0x0603E1E4 RID: 254436 RVA: 0x00F00884 File Offset: 0x00EFEA84
		private void SeekMusicTo(int positionMs)
		{
			if (this.CurrentMusicName.Length <= 0 || this.MusicHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.SeekOnEvent(this.CurrentMusicName, positionMs, new SeekOnEventArgs?(new SeekOnEventArgs
			{
				Handle = new int?(this.MusicHandle)
			}));
		}

		// Token: 0x0603E1E5 RID: 254437 RVA: 0x00F008DC File Offset: 0x00EFEADC
		private void StopMusic()
		{
			if (this.MusicHandle == 0)
			{
				return;
			}
			string message = "[音频]主页音乐停止";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MusicHandle", this.MusicHandle);
			TotalTopUpUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			AudioSystem.Instance.ExecuteAction(this.MusicHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.MusicHandle = 0;
		}

		// Token: 0x0603E1E6 RID: 254438 RVA: 0x00F00950 File Offset: 0x00EFEB50
		private void PauseMusic()
		{
			if (this.MusicHandle == 0)
			{
				return;
			}
			string message = "[音频]主页音乐暂停";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MusicHandle", this.MusicHandle);
			TotalTopUpUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			AudioSystem.Instance.ExecuteAction(this.MusicHandle, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
		}

		// Token: 0x0603E1E7 RID: 254439 RVA: 0x00F009BC File Offset: 0x00EFEBBC
		private void ResumeMusic()
		{
			if (this.MusicHandle == 0)
			{
				return;
			}
			string message = "[音频]主页音乐恢复";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MusicHandle", this.MusicHandle);
			TotalTopUpUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			AudioSystem.Instance.ExecuteAction(this.MusicHandle, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
		}

		// Token: 0x0603E1E8 RID: 254440 RVA: 0x00F00A26 File Offset: 0x00EFEC26
		private void RefreshPreviewName(string previewName)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), previewName, Array.Empty<object>());
		}

		// Token: 0x0603E1E9 RID: 254441 RVA: 0x00F00A40 File Offset: 0x00EFEC40
		private void RefreshPreviewScore(int rewardId)
		{
			int rewardScore = (this.ActivityBaseData as TotalTopUpData).PageViewModel.GetRewardScore(rewardId);
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(rewardScore);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603E1EA RID: 254442 RVA: 0x00F00A90 File Offset: 0x00EFEC90
		private void RefreshArrowActive()
		{
			bool value = this.GetRotationList().Count > 1;
			base.SetButtonUiActive(5, value);
			base.SetButtonUiActive(4, value);
		}

		// Token: 0x0603E1EB RID: 254443 RVA: 0x00F00ABC File Offset: 0x00EFECBC
		private void SetRotationBoardActive(bool active)
		{
			base.SetButtonUiActive(5, active);
			base.SetButtonUiActive(4, active);
		}

		// Token: 0x0603E1EC RID: 254444 RVA: 0x00F00ACE File Offset: 0x00EFECCE
		private IReadOnlyList<TotalTopUpRotation> GetRotationList()
		{
			return (this.ActivityBaseData as TotalTopUpData).PageViewModel.RotationList;
		}

		// Token: 0x0603E1ED RID: 254445 RVA: 0x00F00AE5 File Offset: 0x00EFECE5
		private void OnClickArrowLeft()
		{
			this.GotoRotationIndex(this.WrapRotationIndex(this.CurrentRotationIndex - 1));
		}

		// Token: 0x0603E1EE RID: 254446 RVA: 0x00F00AFB File Offset: 0x00EFECFB
		private void OnClickArrowRight()
		{
			this.GotoRotationIndex(this.WrapRotationIndex(this.CurrentRotationIndex + 1));
		}

		// Token: 0x0603E1EF RID: 254447 RVA: 0x00F00B14 File Offset: 0x00EFED14
		private int WrapRotationIndex(int index)
		{
			int count = this.GetRotationList().Count;
			if (count <= 0)
			{
				return 0;
			}
			return (index % count + count) % count;
		}

		// Token: 0x0603E1F0 RID: 254448 RVA: 0x00F00B3C File Offset: 0x00EFED3C
		private void OnClickMagnifier()
		{
			if (this.CurrentVideoPath.Length <= 0)
			{
				return;
			}
			this.TryReportVideoOpen();
			this.AutoRotateEnabled = false;
			this.ApplyVolumeState("normal", "进全屏");
			if (!this.MusicResumed)
			{
				this.MusicResumed = true;
				this.SeekMusicTo(this.GetVideoPositionMs());
				this.ResumeMusic();
			}
			TotalTopUp37VideoFullScreenParam totalTopUp37VideoFullScreenParam = new TotalTopUp37VideoFullScreenParam();
			totalTopUp37VideoFullScreenParam.ResourcePath = this.CurrentVideoPath;
			totalTopUp37VideoFullScreenParam.OnClose = new Action(this.OnFullScreenClose);
			UiManager.Instance.OpenView(EUiViewName.TotalTopUp37VideoFullScreenView, totalTopUp37VideoFullScreenParam, null);
		}

		// Token: 0x0603E1F1 RID: 254449 RVA: 0x00F00BCC File Offset: 0x00EFEDCC
		private void TryReportVideoOpen()
		{
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			if (totalTopUpData == null)
			{
				return;
			}
			TotalTopUpPageViewModel pageViewModel = totalTopUpData.PageViewModel;
			IReadOnlyList<TotalTopUpRotation> readOnlyList = (pageViewModel != null) ? pageViewModel.RotationList : null;
			if (readOnlyList == null || this.CurrentRotationIndex < 0 || this.CurrentRotationIndex >= readOnlyList.Count)
			{
				return;
			}
			TotalTopUpRotation totalTopUpRotation = readOnlyList[this.CurrentRotationIndex];
			if (totalTopUpRotation.ByteBuffer == null)
			{
				return;
			}
			TotalTopUpVideoOpenLogData totalTopUpVideoOpenLogData = new TotalTopUpVideoOpenLogData();
			totalTopUpVideoOpenLogData.i_activity_id = totalTopUpData.Id;
			totalTopUpVideoOpenLogData.i_reward_id = totalTopUpRotation.Id;
			LogReportController.Instance.LogReport(totalTopUpVideoOpenLogData);
		}

		// Token: 0x0603E1F2 RID: 254450 RVA: 0x00F00C58 File Offset: 0x00EFEE58
		private void OnClickPreviewReward()
		{
			IReadOnlyList<TotalTopUpRotation> rotationList = this.GetRotationList();
			if (this.CurrentRotationIndex < 0 || this.CurrentRotationIndex >= rotationList.Count)
			{
				return;
			}
			TotalTopUpPageRewardViewModel rewardViewModel = (this.ActivityBaseData as TotalTopUpData).PageViewModel.GetRewardViewModel(rotationList[this.CurrentRotationIndex].Id);
			if (rewardViewModel == null)
			{
				return;
			}
			rewardViewModel.PreviewReward();
		}

		// Token: 0x0603E1F3 RID: 254451 RVA: 0x00F00CB7 File Offset: 0x00EFEEB7
		private void OnFullScreenClose()
		{
			this.ApplyVolumeState("mute", "全屏回页签常态");
			this.RotationElapsedMs = 0f;
			this.AutoRotateEnabled = true;
		}

		// Token: 0x0603E1F4 RID: 254452 RVA: 0x00F00CDB File Offset: 0x00EFEEDB
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(516);
		}

		// Token: 0x0603E1F5 RID: 254453 RVA: 0x00F00CEC File Offset: 0x00EFEEEC
		private void OnClickFirstReward()
		{
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			TotalTopUpPageRewardViewModel totalTopUpPageRewardViewModel = (totalTopUpData.PageViewModel.RewardViewModels.Count > 0) ? totalTopUpData.PageViewModel.RewardViewModels[0] : null;
			if (totalTopUpPageRewardViewModel == null)
			{
				return;
			}
			if (totalTopUpPageRewardViewModel.State == ETotalTopUpRewardState.CanClaim)
			{
				totalTopUpPageRewardViewModel.Claim();
				return;
			}
			totalTopUpPageRewardViewModel.PreviewReward();
		}

		// Token: 0x0603E1F6 RID: 254454 RVA: 0x00F00D47 File Offset: 0x00EFEF47
		private void OnClickGotoStore()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				(this.ActivityBaseData as TotalTopUpData).PageViewModel.GotoStore();
			});
		}

		// Token: 0x0603E1F7 RID: 254455 RVA: 0x00F00D65 File Offset: 0x00EFEF65
		protected override void OnBeforeDestroy()
		{
			this.ApplyVolumeState("none", "销毁兜底");
			this.StopMusic();
			MediaPlayer videoPlayer = this.VideoPlayer;
			if (videoPlayer != null)
			{
				videoPlayer.Clear();
			}
			this.VideoPlayer = null;
		}

		// Token: 0x0402072B RID: 132907
		private const int HELP_ID = 516;

		// Token: 0x0402072C RID: 132908
		private const string PROGRESS_SCORE_FORMAT = "<size=64>{0}/</size>{1}";

		// Token: 0x0402072D RID: 132909
		private const string VIDEO_NAME = "TotalTopUp37View";

		// Token: 0x0402072E RID: 132910
		private const string VIDEO_MATERIAL_ID = "M_VideoTextureMat_TextureClip";

		// Token: 0x0402072F RID: 132911
		private const string SWITCH_SEQUENCE_NAME = "Switch";

		// Token: 0x04020730 RID: 132912
		private const double ROTATION_SWITCH_INTERVAL = 0.3;

		// Token: 0x04020731 RID: 132913
		private const string VIDEO_VOLUME_STATE_GROUP = "ui_video_volume";

		// Token: 0x04020732 RID: 132914
		private const string VIDEO_VOLUME_MUTE = "mute";

		// Token: 0x04020733 RID: 132915
		private const string VIDEO_VOLUME_NORMAL = "normal";

		// Token: 0x04020734 RID: 132916
		private const string VIDEO_VOLUME_NONE = "none";

		// Token: 0x04020735 RID: 132917
		[Nullable(2)]
		private TotalTopUp37RewardListPanel RewardListPanel;

		// Token: 0x04020736 RID: 132918
		private float ProgressBarMaxWidth;

		// Token: 0x04020737 RID: 132919
		private int CurrentRotationIndex;

		// Token: 0x04020738 RID: 132920
		private int PendingRotationIndex;

		// Token: 0x04020739 RID: 132921
		private double NextRotationSwitchTime;

		// Token: 0x0402073A RID: 132922
		private float RotationElapsedMs;

		// Token: 0x0402073B RID: 132923
		private bool AutoRotateEnabled;

		// Token: 0x0402073C RID: 132924
		private readonly List<UUIItem> PageDotSprites = new List<UUIItem>();

		// Token: 0x0402073D RID: 132925
		[Nullable(2)]
		private MediaPlayer VideoPlayer;

		// Token: 0x0402073E RID: 132926
		private bool VideoMaterialLoaded;

		// Token: 0x0402073F RID: 132927
		private string CurrentVideoPath = "";

		// Token: 0x04020740 RID: 132928
		private string CurrentMusicName = "";

		// Token: 0x04020741 RID: 132929
		private int MusicHandle;

		// Token: 0x04020742 RID: 132930
		private bool MusicResumed;

		// Token: 0x0200C28B RID: 49803
		[NullableContext(0)]
		private class ENode
		{
			// Token: 0x0403AC47 RID: 240711
			public const int BtnHelpInfo = 0;

			// Token: 0x0403AC48 RID: 240712
			public const int TextTime = 1;

			// Token: 0x0403AC49 RID: 240713
			public const int TextTitle = 2;

			// Token: 0x0403AC4A RID: 240714
			public const int BtnMagnifier = 3;

			// Token: 0x0403AC4B RID: 240715
			public const int BtnArrowRight = 4;

			// Token: 0x0403AC4C RID: 240716
			public const int BtnArrowLeft = 5;

			// Token: 0x0403AC4D RID: 240717
			public const int PanelPageHorizontal = 6;

			// Token: 0x0403AC4E RID: 240718
			public const int PanelPage = 7;

			// Token: 0x0403AC4F RID: 240719
			public const int TextTips = 8;

			// Token: 0x0403AC50 RID: 240720
			public const int BtnCommon = 9;

			// Token: 0x0403AC51 RID: 240721
			public const int ItemRedDot = 10;

			// Token: 0x0403AC52 RID: 240722
			public const int PanelDone = 11;

			// Token: 0x0403AC53 RID: 240723
			public const int PanelItem = 12;

			// Token: 0x0403AC54 RID: 240724
			public const int TextTips2 = 13;

			// Token: 0x0403AC55 RID: 240725
			public const int PanelNum = 14;

			// Token: 0x0403AC56 RID: 240726
			public const int TextCurrentScore = 15;

			// Token: 0x0403AC57 RID: 240727
			public const int SpriteProgressBar = 16;

			// Token: 0x0403AC58 RID: 240728
			public const int BtnCommon2 = 17;

			// Token: 0x0403AC59 RID: 240729
			public const int TextureImage = 18;

			// Token: 0x0403AC5A RID: 240730
			public const int PanelVideo = 19;

			// Token: 0x0403AC5B RID: 240731
			public const int TextureVideo = 20;

			// Token: 0x0403AC5C RID: 240732
			public const int MaxTipsItem = 21;

			// Token: 0x0403AC5D RID: 240733
			public const int FirstRewardEffectItem = 22;

			// Token: 0x0403AC5E RID: 240734
			public const int BtnFullScreen = 23;
		}
	}
}
