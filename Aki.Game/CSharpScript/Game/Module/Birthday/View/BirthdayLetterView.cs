using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Birthday.View
{
	// Token: 0x02004C0C RID: 19468
	[NullableContext(1)]
	[Nullable(0)]
	public class BirthdayLetterView : UiTickViewBase, IUiViewResource
	{
		// Token: 0x060308F3 RID: 198899 RVA: 0x00D886AF File Offset: 0x00D868AF
		public BirthdayLetterView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060308F4 RID: 198900 RVA: 0x00D886D8 File Offset: 0x00D868D8
		public string GetExtraResourceId([Nullable(2)] object param = null)
		{
			BirthdayInfo birthdayInfo = param as BirthdayInfo;
			if (birthdayInfo == null)
			{
				return "";
			}
			return BirthdayModel.Instance.GetLetterViewResource(birthdayInfo.Year);
		}

		// Token: 0x060308F5 RID: 198901 RVA: 0x00D88708 File Offset: 0x00D86908
		protected override string OnGetBgm()
		{
			BirthdayInfo birthdayInfo = this.OpenParam as BirthdayInfo;
			if (birthdayInfo == null)
			{
				return base.OnGetBgm();
			}
			string letterViewBgm = BirthdayModel.Instance.GetLetterViewBgm(birthdayInfo.Year);
			if (StringUtils.IsBlank(letterViewBgm))
			{
				return base.OnGetBgm();
			}
			return letterViewBgm;
		}

		// Token: 0x060308F6 RID: 198902 RVA: 0x00D8874C File Offset: 0x00D8694C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISizeControlByOther));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickGiftBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickPhotoBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickResetBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060308F7 RID: 198903 RVA: 0x00D889CC File Offset: 0x00D86BCC
		protected override UniTask OnBeforeStartAsync()
		{
			BirthdayLetterView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BirthdayLetterView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060308F8 RID: 198904 RVA: 0x00D88A10 File Offset: 0x00D86C10
		protected override void OnBeforeShow()
		{
			this.IsFirstOpen = BirthdayController.TryBirthDayRewardRequest(this.Year);
			int? selectedRoleId = BirthdayModel.Instance.GetSelectedRoleId(this.Year);
			if (this.BirthdayInfo.TriggerType != BirthdayDefine.ETriggerType.Natural && selectedRoleId != null)
			{
				int? num = selectedRoleId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					goto IL_64;
				}
			}
			BirthdayController.TrySelectBirthDayCardRoleRequest(this.RoleId, this.Year);
			IL_64:
			this.LoadRoleModel();
			this.BirthdayLetterInterval = ConfigCommonParamById.GetIntConfig("BirthdayEnvelopeInterval").Value;
			AudioSystem.Instance.SetState("mute_nature_voice", ERoleMuteAudioState.Mute, true);
			DateTime birthdayDate = BirthdayModel.Instance.GetBirthdayDate(this.Year);
			int month = birthdayDate.Month;
			int day = birthdayDate.Day;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "BirthdayLetterTime", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.Year,
				month,
				day
			}));
			this.RewardId = ConfigBirthDayByYear.GetConfig(this.Year, true).Value.BirthDayReward;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.RewardId);
			this.GiftScrollView.RefreshByData(dropPackagePreviewItemList, null, false);
			this.RefreshRoleInfo();
		}

		// Token: 0x060308F9 RID: 198905 RVA: 0x00D88B68 File Offset: 0x00D86D68
		private void RefreshRoleInfo()
		{
			if (this.EventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
				this.EventHandle = 0;
			}
			RoleBirthday? config = ConfigRoleBirthdayById.GetConfig(this.RoleId, true);
			if (config == null)
			{
				return;
			}
			this.SceneCameraId = config.Value.SceneCameraId;
			this.CardCameraId = config.Value.CardCameraId;
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(RoleConfig.Instance.GetRoleConfig(this.RoleId).Value.Name, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "BirthdayLetterTitle", new <>z__ReadOnlySingleElementList<object>(localTextNew));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), config.Value.CardTextKey, Array.Empty<object>());
			this.EventHandle = AudioSystem.Instance.PostEvent(config.Value.VoiceEvent, null, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?((ECallbackMask)9),
				CallbackHandler = delegate
				{
					bool durationHandled = false;
					return delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
					{
						if (callbackType == EAkCallbackType.Duration)
						{
							durationHandled = true;
							UAkDurationCallbackInfo uakDurationCallbackInfo = callbackInfo as UAkDurationCallbackInfo;
							this.ShowLetterContent(uakDurationCallbackInfo.Duration / 1000f);
							return;
						}
						if (callbackType == EAkCallbackType.EndOfEvent)
						{
							if (durationHandled)
							{
								return;
							}
							float valueOrDefault = ConfigCommonParamById.GetFloatConfig("BirthdayLetterDefaultDuration").GetValueOrDefault(10f);
							this.ShowLetterContent(valueOrDefault);
						}
					};
				}()
			}));
		}

		// Token: 0x060308FA RID: 198906 RVA: 0x00D88CA0 File Offset: 0x00D86EA0
		private void ShowLetterContent(float voiceDuration)
		{
			this.InitText(voiceDuration);
			this.ShowLetterPanel();
			base.GetUiSizeControlByOther(11).MinHeight = (int)Math.Ceiling((double)(base.GetScrollViewWithScrollbar(12).RootUIComp.Get().Height / 60f)) * 60;
		}

		// Token: 0x060308FB RID: 198907 RVA: 0x00D88CF1 File Offset: 0x00D86EF1
		private void LoadRoleModel()
		{
			UiModelBase model = this.UiSceneRoleActor.Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			if (uiModelActorComponent == null)
			{
				return;
			}
			uiModelActorComponent.SetTransformByTag("RoleCase");
		}

		// Token: 0x060308FC RID: 198908 RVA: 0x00D88D1C File Offset: 0x00D86F1C
		private void ShowLetterPanel()
		{
			UiCameraModel.Instance.PushCameraHandleByHandleName(this.CardCameraId, true, true, "1001", false, null);
			UiModelBase model = this.UiSceneRoleActor.Model;
			UiRoleStateMachineComponent uiRoleStateMachineComponent = (model != null) ? model.CheckGetComponent<UiRoleStateMachineComponent>() : null;
			if (uiRoleStateMachineComponent != null)
			{
				uiRoleStateMachineComponent.SetState(EPerformanceRoleState.Resonance, false, false, false);
			}
			this.IsLetterShow = true;
		}

		// Token: 0x060308FD RID: 198909 RVA: 0x00D88D70 File Offset: 0x00D86F70
		private void InitText(float voiceDuration)
		{
			if (this.TextPlayTweenEndCbWrapper != null)
			{
				ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
				if (textPlayTweenComp != null)
				{
					ULGUIPlayTween playTween = textPlayTweenComp.GetPlayTween();
					if (playTween != null)
					{
						playTween.UnregisterOnComplete(this.TextPlayTweenEndCbWrapper);
					}
				}
				this.TextPlayTweenEndCbWrapper = null;
			}
			if (this.TextPlayTweenEndCb != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnTweenEnd));
				this.TextPlayTweenEndCb = null;
			}
			this.TextAnimDataComp = (base.GetText(6).GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
			this.TextPlayTweenComp = (base.GetText(6).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			UUIEffectTextAnimation textAnimDataComp = this.TextAnimDataComp;
			if (textAnimDataComp != null)
			{
				textAnimDataComp.SetSelectorOffset(1f);
			}
			this.TextPlayTweenEndCb = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnTweenEnd));
			this.TextPlayTweenEndCbWrapper = this.TextPlayTweenComp.GetPlayTween().RegisterOnComplete(this.TextPlayTweenEndCb);
			this.VoiceDuration = voiceDuration;
			base.GetText(6).SetUIActive(false);
			this.ShowText();
		}

		// Token: 0x060308FE RID: 198910 RVA: 0x00D88E84 File Offset: 0x00D87084
		private void ShowText()
		{
			base.GetText(6).SetUIActive(true);
			if (this.TextPlayTweenComp != null)
			{
				this.TextAnimDataComp.SetSelectorOffset(1f);
				this.TextPlayTweenComp.GetPlayTween().duration = this.VoiceDuration + BirthdayModel.Instance.GetPlayTimeOffset();
				this.TextPlayTweenComp.Play();
			}
		}

		// Token: 0x060308FF RID: 198911 RVA: 0x00D88EE2 File Offset: 0x00D870E2
		private BirthdayRewardItem CreatePropItem()
		{
			return new BirthdayRewardItem();
		}

		// Token: 0x06030900 RID: 198912 RVA: 0x00D88EEC File Offset: 0x00D870EC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnBirthRoleChange, new Action<int>(this.OnBirthRoleChange));
			if (this.TextPlayTweenEndCbWrapper != null)
			{
				ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
				if (textPlayTweenComp != null)
				{
					ULGUIPlayTween playTween = textPlayTweenComp.GetPlayTween();
					if (playTween != null)
					{
						playTween.UnregisterOnComplete(this.TextPlayTweenEndCbWrapper);
					}
				}
				this.TextPlayTweenEndCbWrapper = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnTweenEnd));
			this.TextPlayTweenEndCb = null;
			if (this.UiSceneRoleActor != null)
			{
				UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.UiSceneRoleActor);
				this.UiSceneRoleActor = null;
			}
			AudioSystem.Instance.SetState("mute_nature_voice", ERoleMuteAudioState.None, true);
		}

		// Token: 0x06030901 RID: 198913 RVA: 0x00D88FA0 File Offset: 0x00D871A0
		private void OnClickBackBtn()
		{
			if (this.LastClickTimeStamp != 0 && TimeUtil.Instance.GetServerTimeStamp() - (double)this.LastClickTimeStamp < (double)this.BirthdayLetterInterval)
			{
				return;
			}
			this.LastClickTimeStamp = (int)TimeUtil.Instance.GetServerTimeStamp();
			if (this.IsLetterShow)
			{
				UiCameraModel.Instance.PushCameraHandleByHandleName(this.SceneCameraId, true, true, "1001", false, null);
				UiModelBase model = this.UiSceneRoleActor.Model;
				UiRoleStateMachineComponent uiRoleStateMachineComponent = (model != null) ? model.CheckGetComponent<UiRoleStateMachineComponent>() : null;
				if (uiRoleStateMachineComponent != null)
				{
					uiRoleStateMachineComponent.SetState(EPerformanceRoleState.Attribute_Perform, false, false, false);
				}
				base.PlaySequence("WindowClose", null, false);
				this.IsLetterShow = false;
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(BirthdayModel.Instance.GetLetterExitConfirmId(this.BirthdayInfo.Year));
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				this.CloseBirthdayLetterView();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06030902 RID: 198914 RVA: 0x00D89080 File Offset: 0x00D87280
		public void CloseBirthdayLetterView()
		{
			base.CloseMe(null);
			if (this.EventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
			}
			if (this.IsFirstOpen)
			{
				List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.RewardId);
				List<RewardItemData> list = new List<RewardItemData>();
				foreach (TItem titem in dropPackagePreviewItemList)
				{
					RewardItemData item = new RewardItemData(titem.ItemData.ItemId, titem.Count, null, EDropItemType.Normal);
					list.Add(item);
				}
				Action onCloseCallback = delegate()
				{
					SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.Birthday);
				};
				ItemRewardController.Instance.OpenCommonRewardView(1009, list, onCloseCallback);
				return;
			}
			SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.Birthday);
		}

		// Token: 0x06030903 RID: 198915 RVA: 0x00D8917C File Offset: 0x00D8737C
		private void OnClickGiftBtn()
		{
			if (this.LastClickTimeStamp != 0 && TimeUtil.Instance.GetServerTimeStamp() - (double)this.LastClickTimeStamp < (double)this.BirthdayLetterInterval)
			{
				return;
			}
			this.LastClickTimeStamp = (int)TimeUtil.Instance.GetServerTimeStamp();
			this.ShowLetterPanel();
			base.PlaySequence("WindowOpen", null, false);
		}

		// Token: 0x06030904 RID: 198916 RVA: 0x00D891D4 File Offset: 0x00D873D4
		private void OnClickPhotoBtn()
		{
			PhotographController.Instance.ScreenShot(new PhotoSaveViewParam
			{
				ScreenShot = true,
				PrepareFullScreenShot = false,
				IsHiddenBattleView = true,
				HandBookPhotoData = null,
				GachaData = null,
				FragmentMemory = null,
				RoleSkinData = null,
				ShareId = 7
			});
		}

		// Token: 0x06030905 RID: 198917 RVA: 0x00D89228 File Offset: 0x00D87428
		private void OnClickResetBtn()
		{
			UiManager.Instance.OpenViewWithLayer(EUiViewName.BirthdayRoleSelectView, ELayerType.Pop, new BirthdayInfo(BirthdayDefine.ETriggerType.ReSelect, this.Year, null), null);
		}

		// Token: 0x06030906 RID: 198918 RVA: 0x00D8925C File Offset: 0x00D8745C
		private void OnTweenEnd()
		{
			this.TextPlayTweenComp.Stop();
			this.TextAnimDataComp.SetSelectorOffset(0f);
		}

		// Token: 0x06030907 RID: 198919 RVA: 0x00D8927C File Offset: 0x00D8747C
		private void OnBirthRoleChange(int roleId)
		{
			this.RoleId = roleId;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
			int? num = (roleDataById != null) ? new int?(roleDataById.GetRoleSkinId()) : null;
			if (num == null)
			{
				num = new int?(ConfigRoleInfoById.GetConfig(this.RoleId, true).Value.SkinId);
			}
			RoleController.Instance.OnSelectedRoleChangeByConfig(roleId, num.Value, null);
			base.PlaySequence("WindowOpen", null, false);
			this.RefreshRoleInfo();
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(12);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.SetScrollValue(Vector2D.ZeroVector);
		}

		// Token: 0x04019B2A RID: 105258
		private const int HEIGHT_PER_LINE = 60;

		// Token: 0x04019B2B RID: 105259
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<BirthdayRewardItem, TItem> GiftScrollView;

		// Token: 0x04019B2C RID: 105260
		[Nullable(2)]
		private TsUiSceneRoleActor UiSceneRoleActor;

		// Token: 0x04019B2D RID: 105261
		private int RoleId;

		// Token: 0x04019B2E RID: 105262
		private int Year;

		// Token: 0x04019B2F RID: 105263
		private bool IsLetterShow = true;

		// Token: 0x04019B30 RID: 105264
		private string SceneCameraId = "";

		// Token: 0x04019B31 RID: 105265
		private string CardCameraId = "";

		// Token: 0x04019B32 RID: 105266
		private bool IsFirstOpen;

		// Token: 0x04019B33 RID: 105267
		private int RewardId;

		// Token: 0x04019B34 RID: 105268
		private int EventHandle;

		// Token: 0x04019B35 RID: 105269
		[Nullable(2)]
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x04019B36 RID: 105270
		[Nullable(2)]
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x04019B37 RID: 105271
		[Nullable(2)]
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x04019B38 RID: 105272
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x04019B39 RID: 105273
		private float VoiceDuration;

		// Token: 0x04019B3A RID: 105274
		private int LastClickTimeStamp;

		// Token: 0x04019B3B RID: 105275
		private int BirthdayLetterInterval;

		// Token: 0x04019B3C RID: 105276
		private BirthdayInfo BirthdayInfo;

		// Token: 0x0200A820 RID: 43040
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04033EF2 RID: 212722
			public const int ButtonBack = 0;

			// Token: 0x04033EF3 RID: 212723
			public const int ItemButtonPanel = 1;

			// Token: 0x04033EF4 RID: 212724
			public const int ItemLetterPanel = 2;

			// Token: 0x04033EF5 RID: 212725
			public const int ButtonPhoto = 3;

			// Token: 0x04033EF6 RID: 212726
			public const int ButtonGift = 4;

			// Token: 0x04033EF7 RID: 212727
			public const int TextTitle = 5;

			// Token: 0x04033EF8 RID: 212728
			public const int TextBless = 6;

			// Token: 0x04033EF9 RID: 212729
			public const int ScrollViewGift = 7;

			// Token: 0x04033EFA RID: 212730
			public const int ItemGift = 8;

			// Token: 0x04033EFB RID: 212731
			public const int TextTime = 9;

			// Token: 0x04033EFC RID: 212732
			public const int BtnReSelect = 10;

			// Token: 0x04033EFD RID: 212733
			public const int SpriteLine = 11;

			// Token: 0x04033EFE RID: 212734
			public const int SVInfo = 12;
		}
	}
}
