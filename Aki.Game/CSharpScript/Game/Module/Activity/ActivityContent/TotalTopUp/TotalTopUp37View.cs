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
	// Token: 0x02004F9F RID: 20383
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37View : ActivitySubViewBase
	{
		// Token: 0x0603315E RID: 209246 RVA: 0x00E51674 File Offset: 0x00E4F874
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

		// Token: 0x0603315F RID: 209247 RVA: 0x00E5194C File Offset: 0x00E4FB4C
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUp37View.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUp37View.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033160 RID: 209248 RVA: 0x00E5198F File Offset: 0x00E4FB8F
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (sequenceName == "Switch" && eventName == "Switch")
			{
				this.ApplyRotationIndex(this.PendingRotationIndex);
			}
		}

		// Token: 0x06033161 RID: 209249 RVA: 0x00E519B8 File Offset: 0x00E4FBB8
		protected override UniTask OnBeforeShowSelfAsync()
		{
			TotalTopUp37View.<OnBeforeShowSelfAsync>d__27 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<TotalTopUp37View.<OnBeforeShowSelfAsync>d__27>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033162 RID: 209250 RVA: 0x00E519FC File Offset: 0x00E4FBFC
		protected override UniTask OnBeforeHideSelfAsync()
		{
			TotalTopUp37View.<OnBeforeHideSelfAsync>d__28 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<TotalTopUp37View.<OnBeforeHideSelfAsync>d__28>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033163 RID: 209251 RVA: 0x00E51A3F File Offset: 0x00E4FC3F
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

		// Token: 0x06033164 RID: 209252 RVA: 0x00E51A6D File Offset: 0x00E4FC6D
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

		// Token: 0x06033165 RID: 209253 RVA: 0x00E51A94 File Offset: 0x00E4FC94
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(16);
			this.ProgressBarMaxWidth = ((sprite != null) ? sprite.GetWidth() : 0f);
			TotalTopUpData totalTopUpData = this.ActivityBaseData as TotalTopUpData;
			this.Refresh(totalTopUpData);
			this.StartRotation(totalTopUpData.PageViewModel);
		}

		// Token: 0x06033166 RID: 209254 RVA: 0x00E51AE0 File Offset: 0x00E4FCE0
		protected override void OnRefreshView()
		{
			TotalTopUpUtil.Debug("TotalTopUp37View刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			TotalTopUpData data = this.ActivityBaseData as TotalTopUpData;
			this.Refresh(data);
		}

		// Token: 0x06033167 RID: 209255 RVA: 0x00E51B14 File Offset: 0x00E4FD14
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

		// Token: 0x06033168 RID: 209256 RVA: 0x00E51B54 File Offset: 0x00E4FD54
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

		// Token: 0x06033169 RID: 209257 RVA: 0x00E51B90 File Offset: 0x00E4FD90
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

		// Token: 0x0603316A RID: 209258 RVA: 0x00E51BE0 File Offset: 0x00E4FDE0
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

		// Token: 0x0603316B RID: 209259 RVA: 0x00E51C68 File Offset: 0x00E4FE68
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

		// Token: 0x0603316C RID: 209260 RVA: 0x00E51DCC File Offset: 0x00E4FFCC
		private void RefreshTime(double time)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(time);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, "TotalTopUp_1001", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? ""));
		}

		// Token: 0x0603316D RID: 209261 RVA: 0x00E51E14 File Offset: 0x00E50014
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

		// Token: 0x0603316E RID: 209262 RVA: 0x00E51E64 File Offset: 0x00E50064
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

		// Token: 0x0603316F RID: 209263 RVA: 0x00E51ED2 File Offset: 0x00E500D2
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

		// Token: 0x06033170 RID: 209264 RVA: 0x00E51F00 File Offset: 0x00E50100
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

		// Token: 0x06033171 RID: 209265 RVA: 0x00E51F40 File Offset: 0x00E50140
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

		// Token: 0x06033172 RID: 209266 RVA: 0x00E51FCC File Offset: 0x00E501CC
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

		// Token: 0x06033173 RID: 209267 RVA: 0x00E52034 File Offset: 0x00E50234
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

		// Token: 0x06033174 RID: 209268 RVA: 0x00E52078 File Offset: 0x00E50278
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

		// Token: 0x06033175 RID: 209269 RVA: 0x00E520F4 File Offset: 0x00E502F4
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

		// Token: 0x06033176 RID: 209270 RVA: 0x00E5218C File Offset: 0x00E5038C
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

		// Token: 0x06033177 RID: 209271 RVA: 0x00E5220C File Offset: 0x00E5040C
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

		// Token: 0x06033178 RID: 209272 RVA: 0x00E52304 File Offset: 0x00E50504
		private UniTask LoadVideoMaterial()
		{
			TotalTopUp37View.<LoadVideoMaterial>d__50 <LoadVideoMaterial>d__;
			<LoadVideoMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadVideoMaterial>d__.<>4__this = this;
			<LoadVideoMaterial>d__.<>1__state = -1;
			<LoadVideoMaterial>d__.<>t__builder.Start<TotalTopUp37View.<LoadVideoMaterial>d__50>(ref <LoadVideoMaterial>d__);
			return <LoadVideoMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x06033179 RID: 209273 RVA: 0x00E52347 File Offset: 0x00E50547
		private void StopVideo()
		{
			MediaPlayer videoPlayer = this.VideoPlayer;
			if (videoPlayer == null)
			{
				return;
			}
			videoPlayer.StopVideo("TotalTopUp37View");
		}

		// Token: 0x0603317A RID: 209274 RVA: 0x00E52360 File Offset: 0x00E50560
		[NullableContext(2)]
		private void OnVideoLoopEnd(string videoName)
		{
			TotalTopUpUtil.Debug("[音频]视频循环重置音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.PlayMusicAndSync();
		}

		// Token: 0x0603317B RID: 209275 RVA: 0x00E52388 File Offset: 0x00E50588
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

		// Token: 0x0603317C RID: 209276 RVA: 0x00E524A4 File Offset: 0x00E506A4
		private unsafe void ApplyVolumeState(string state, string reason)
		{
			string message = "[音频]TotalTopUp37View视频音量切换";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("State", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			AudioSystem.Instance.SetState("ui_video_volume", state, true);
		}

		// Token: 0x0603317D RID: 209277 RVA: 0x00E5250C File Offset: 0x00E5070C
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

		// Token: 0x0603317E RID: 209278 RVA: 0x00E52540 File Offset: 0x00E50740
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

		// Token: 0x0603317F RID: 209279 RVA: 0x00E52598 File Offset: 0x00E50798
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

		// Token: 0x06033180 RID: 209280 RVA: 0x00E5260C File Offset: 0x00E5080C
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

		// Token: 0x06033181 RID: 209281 RVA: 0x00E52678 File Offset: 0x00E50878
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

		// Token: 0x06033182 RID: 209282 RVA: 0x00E526E2 File Offset: 0x00E508E2
		private void RefreshPreviewName(string previewName)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), previewName, Array.Empty<object>());
		}

		// Token: 0x06033183 RID: 209283 RVA: 0x00E526FC File Offset: 0x00E508FC
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

		// Token: 0x06033184 RID: 209284 RVA: 0x00E5274C File Offset: 0x00E5094C
		private void RefreshArrowActive()
		{
			bool value = this.GetRotationList().Count > 1;
			base.SetButtonUiActive(5, value);
			base.SetButtonUiActive(4, value);
		}

		// Token: 0x06033185 RID: 209285 RVA: 0x00E52778 File Offset: 0x00E50978
		private void SetRotationBoardActive(bool active)
		{
			base.SetButtonUiActive(5, active);
			base.SetButtonUiActive(4, active);
		}

		// Token: 0x06033186 RID: 209286 RVA: 0x00E5278A File Offset: 0x00E5098A
		private IReadOnlyList<TotalTopUpRotation> GetRotationList()
		{
			return (this.ActivityBaseData as TotalTopUpData).PageViewModel.RotationList;
		}

		// Token: 0x06033187 RID: 209287 RVA: 0x00E527A1 File Offset: 0x00E509A1
		private void OnClickArrowLeft()
		{
			this.GotoRotationIndex(this.WrapRotationIndex(this.CurrentRotationIndex - 1));
		}

		// Token: 0x06033188 RID: 209288 RVA: 0x00E527B7 File Offset: 0x00E509B7
		private void OnClickArrowRight()
		{
			this.GotoRotationIndex(this.WrapRotationIndex(this.CurrentRotationIndex + 1));
		}

		// Token: 0x06033189 RID: 209289 RVA: 0x00E527D0 File Offset: 0x00E509D0
		private int WrapRotationIndex(int index)
		{
			int count = this.GetRotationList().Count;
			if (count <= 0)
			{
				return 0;
			}
			return (index % count + count) % count;
		}

		// Token: 0x0603318A RID: 209290 RVA: 0x00E527F8 File Offset: 0x00E509F8
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

		// Token: 0x0603318B RID: 209291 RVA: 0x00E52888 File Offset: 0x00E50A88
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

		// Token: 0x0603318C RID: 209292 RVA: 0x00E52914 File Offset: 0x00E50B14
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

		// Token: 0x0603318D RID: 209293 RVA: 0x00E52973 File Offset: 0x00E50B73
		private void OnFullScreenClose()
		{
			this.ApplyVolumeState("mute", "全屏回页签常态");
			this.RotationElapsedMs = 0f;
			this.AutoRotateEnabled = true;
		}

		// Token: 0x0603318E RID: 209294 RVA: 0x00E52997 File Offset: 0x00E50B97
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(516);
		}

		// Token: 0x0603318F RID: 209295 RVA: 0x00E529A8 File Offset: 0x00E50BA8
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

		// Token: 0x06033190 RID: 209296 RVA: 0x00E52A03 File Offset: 0x00E50C03
		private void OnClickGotoStore()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				(this.ActivityBaseData as TotalTopUpData).PageViewModel.GotoStore();
			});
		}

		// Token: 0x06033191 RID: 209297 RVA: 0x00E52A21 File Offset: 0x00E50C21
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

		// Token: 0x0401B1FD RID: 111101
		private const int HELP_ID = 516;

		// Token: 0x0401B1FE RID: 111102
		private const string PROGRESS_SCORE_FORMAT = "<size=64>{0}/</size>{1}";

		// Token: 0x0401B1FF RID: 111103
		private const string VIDEO_NAME = "TotalTopUp37View";

		// Token: 0x0401B200 RID: 111104
		private const string VIDEO_MATERIAL_ID = "M_VideoTextureMat_TextureClip";

		// Token: 0x0401B201 RID: 111105
		private const string SWITCH_SEQUENCE_NAME = "Switch";

		// Token: 0x0401B202 RID: 111106
		private const double ROTATION_SWITCH_INTERVAL = 0.3;

		// Token: 0x0401B203 RID: 111107
		private const string VIDEO_VOLUME_STATE_GROUP = "ui_video_volume";

		// Token: 0x0401B204 RID: 111108
		private const string VIDEO_VOLUME_MUTE = "mute";

		// Token: 0x0401B205 RID: 111109
		private const string VIDEO_VOLUME_NORMAL = "normal";

		// Token: 0x0401B206 RID: 111110
		private const string VIDEO_VOLUME_NONE = "none";

		// Token: 0x0401B207 RID: 111111
		[Nullable(2)]
		private TotalTopUp37RewardListPanel RewardListPanel;

		// Token: 0x0401B208 RID: 111112
		private float ProgressBarMaxWidth;

		// Token: 0x0401B209 RID: 111113
		private int CurrentRotationIndex;

		// Token: 0x0401B20A RID: 111114
		private int PendingRotationIndex;

		// Token: 0x0401B20B RID: 111115
		private double NextRotationSwitchTime;

		// Token: 0x0401B20C RID: 111116
		private float RotationElapsedMs;

		// Token: 0x0401B20D RID: 111117
		private bool AutoRotateEnabled;

		// Token: 0x0401B20E RID: 111118
		private readonly List<UUIItem> PageDotSprites = new List<UUIItem>();

		// Token: 0x0401B20F RID: 111119
		[Nullable(2)]
		private MediaPlayer VideoPlayer;

		// Token: 0x0401B210 RID: 111120
		private bool VideoMaterialLoaded;

		// Token: 0x0401B211 RID: 111121
		private string CurrentVideoPath = "";

		// Token: 0x0401B212 RID: 111122
		private string CurrentMusicName = "";

		// Token: 0x0401B213 RID: 111123
		private int MusicHandle;

		// Token: 0x0401B214 RID: 111124
		private bool MusicResumed;

		// Token: 0x0200AC96 RID: 44182
		[NullableContext(0)]
		private class ENode
		{
			// Token: 0x04035623 RID: 218659
			public const int BtnHelpInfo = 0;

			// Token: 0x04035624 RID: 218660
			public const int TextTime = 1;

			// Token: 0x04035625 RID: 218661
			public const int TextTitle = 2;

			// Token: 0x04035626 RID: 218662
			public const int BtnMagnifier = 3;

			// Token: 0x04035627 RID: 218663
			public const int BtnArrowRight = 4;

			// Token: 0x04035628 RID: 218664
			public const int BtnArrowLeft = 5;

			// Token: 0x04035629 RID: 218665
			public const int PanelPageHorizontal = 6;

			// Token: 0x0403562A RID: 218666
			public const int PanelPage = 7;

			// Token: 0x0403562B RID: 218667
			public const int TextTips = 8;

			// Token: 0x0403562C RID: 218668
			public const int BtnCommon = 9;

			// Token: 0x0403562D RID: 218669
			public const int ItemRedDot = 10;

			// Token: 0x0403562E RID: 218670
			public const int PanelDone = 11;

			// Token: 0x0403562F RID: 218671
			public const int PanelItem = 12;

			// Token: 0x04035630 RID: 218672
			public const int TextTips2 = 13;

			// Token: 0x04035631 RID: 218673
			public const int PanelNum = 14;

			// Token: 0x04035632 RID: 218674
			public const int TextCurrentScore = 15;

			// Token: 0x04035633 RID: 218675
			public const int SpriteProgressBar = 16;

			// Token: 0x04035634 RID: 218676
			public const int BtnCommon2 = 17;

			// Token: 0x04035635 RID: 218677
			public const int TextureImage = 18;

			// Token: 0x04035636 RID: 218678
			public const int PanelVideo = 19;

			// Token: 0x04035637 RID: 218679
			public const int TextureVideo = 20;

			// Token: 0x04035638 RID: 218680
			public const int MaxTipsItem = 21;

			// Token: 0x04035639 RID: 218681
			public const int FirstRewardEffectItem = 22;

			// Token: 0x0403563A RID: 218682
			public const int BtnFullScreen = 23;
		}
	}
}
