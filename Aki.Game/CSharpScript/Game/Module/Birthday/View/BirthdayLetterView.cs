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
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Birthday.View
{
	// Token: 0x02005C2C RID: 23596
	[NullableContext(1)]
	[Nullable(0)]
	public class BirthdayLetterView : UiTickViewBase, IUiViewResource
	{
		// Token: 0x0603B9A8 RID: 244136 RVA: 0x00E3832B File Offset: 0x00E3652B
		public BirthdayLetterView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B9A9 RID: 244137 RVA: 0x00E38354 File Offset: 0x00E36554
		public string GetExtraResourceId([Nullable(2)] object param = null)
		{
			BirthdayInfo birthdayInfo = param as BirthdayInfo;
			if (birthdayInfo == null)
			{
				return "";
			}
			return BirthdayModel.Instance.GetLetterViewResource(birthdayInfo.Year);
		}

		// Token: 0x0603B9AA RID: 244138 RVA: 0x00E38384 File Offset: 0x00E36584
		protected override string OnGetLoopAudioEvent()
		{
			BirthdayInfo birthdayInfo = this.OpenParam as BirthdayInfo;
			if (birthdayInfo == null)
			{
				return base.OnGetLoopAudioEvent();
			}
			string letterViewBgm = BirthdayModel.Instance.GetLetterViewBgm(birthdayInfo.Year);
			if (StringUtils.IsBlank(letterViewBgm))
			{
				return base.OnGetLoopAudioEvent();
			}
			return letterViewBgm;
		}

		// Token: 0x0603B9AB RID: 244139 RVA: 0x00E383C8 File Offset: 0x00E365C8
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

		// Token: 0x0603B9AC RID: 244140 RVA: 0x00E38648 File Offset: 0x00E36848
		protected override UniTask OnBeforeStartAsync()
		{
			BirthdayLetterView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BirthdayLetterView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B9AD RID: 244141 RVA: 0x00E3868C File Offset: 0x00E3688C
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

		// Token: 0x0603B9AE RID: 244142 RVA: 0x00E387E4 File Offset: 0x00E369E4
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

		// Token: 0x0603B9AF RID: 244143 RVA: 0x00E3891C File Offset: 0x00E36B1C
		private void ShowLetterContent(float voiceDuration)
		{
			this.InitText(voiceDuration);
			this.ShowLetterPanel();
			base.GetUiSizeControlByOther(11).MinHeight = (int)Math.Ceiling((double)(base.GetScrollViewWithScrollbar(12).RootUIComp.Get().Height / 60f)) * 60;
		}

		// Token: 0x0603B9B0 RID: 244144 RVA: 0x00E3896D File Offset: 0x00E36B6D
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

		// Token: 0x0603B9B1 RID: 244145 RVA: 0x00E38998 File Offset: 0x00E36B98
		private void ShowLetterPanel()
		{
			UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(this.CardCameraId, true, true, "1001", false, null, null);
			UiModelBase model = this.UiSceneRoleActor.Model;
			UiRoleStateMachineComponent uiRoleStateMachineComponent = (model != null) ? model.CheckGetComponent<UiRoleStateMachineComponent>() : null;
			if (uiRoleStateMachineComponent != null)
			{
				uiRoleStateMachineComponent.SetState(EPerformanceRoleState.Resonance, false, false, false);
			}
			this.IsLetterShow = true;
		}

		// Token: 0x0603B9B2 RID: 244146 RVA: 0x00E389F8 File Offset: 0x00E36BF8
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

		// Token: 0x0603B9B3 RID: 244147 RVA: 0x00E38B0C File Offset: 0x00E36D0C
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

		// Token: 0x0603B9B4 RID: 244148 RVA: 0x00E38B6A File Offset: 0x00E36D6A
		private BirthdayRewardItem CreatePropItem()
		{
			return new BirthdayRewardItem();
		}

		// Token: 0x0603B9B5 RID: 244149 RVA: 0x00E38B74 File Offset: 0x00E36D74
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

		// Token: 0x0603B9B6 RID: 244150 RVA: 0x00E38C28 File Offset: 0x00E36E28
		private void OnClickBackBtn()
		{
			if (this.LastClickTimeStamp != 0 && TimeUtil.Instance.GetServerTimeStamp() - (double)this.LastClickTimeStamp < (double)this.BirthdayLetterInterval)
			{
				return;
			}
			this.LastClickTimeStamp = (int)TimeUtil.Instance.GetServerTimeStamp();
			if (this.IsLetterShow)
			{
				UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(this.SceneCameraId, true, true, "1001", false, null, null);
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

		// Token: 0x0603B9B7 RID: 244151 RVA: 0x00E38D10 File Offset: 0x00E36F10
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

		// Token: 0x0603B9B8 RID: 244152 RVA: 0x00E38E0C File Offset: 0x00E3700C
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

		// Token: 0x0603B9B9 RID: 244153 RVA: 0x00E38E64 File Offset: 0x00E37064
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

		// Token: 0x0603B9BA RID: 244154 RVA: 0x00E38EB8 File Offset: 0x00E370B8
		private void OnClickResetBtn()
		{
			UiManager.Instance.OpenViewWithLayer(EUiViewName.BirthdayRoleSelectView, ELayerType.Pop, new BirthdayInfo(BirthdayDefine.ETriggerType.ReSelect, this.Year, null), null);
		}

		// Token: 0x0603B9BB RID: 244155 RVA: 0x00E38EEC File Offset: 0x00E370EC
		private void OnTweenEnd()
		{
			this.TextPlayTweenComp.Stop();
			this.TextAnimDataComp.SetSelectorOffset(0f);
		}

		// Token: 0x0603B9BC RID: 244156 RVA: 0x00E38F0C File Offset: 0x00E3710C
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

		// Token: 0x0401F079 RID: 127097
		private const int HEIGHT_PER_LINE = 60;

		// Token: 0x0401F07A RID: 127098
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<BirthdayRewardItem, TItem> GiftScrollView;

		// Token: 0x0401F07B RID: 127099
		[Nullable(2)]
		private TsUiSceneRoleActor UiSceneRoleActor;

		// Token: 0x0401F07C RID: 127100
		private int RoleId;

		// Token: 0x0401F07D RID: 127101
		private int Year;

		// Token: 0x0401F07E RID: 127102
		private bool IsLetterShow = true;

		// Token: 0x0401F07F RID: 127103
		private string SceneCameraId = "";

		// Token: 0x0401F080 RID: 127104
		private string CardCameraId = "";

		// Token: 0x0401F081 RID: 127105
		private bool IsFirstOpen;

		// Token: 0x0401F082 RID: 127106
		private int RewardId;

		// Token: 0x0401F083 RID: 127107
		private int EventHandle;

		// Token: 0x0401F084 RID: 127108
		[Nullable(2)]
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x0401F085 RID: 127109
		[Nullable(2)]
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x0401F086 RID: 127110
		[Nullable(2)]
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x0401F087 RID: 127111
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x0401F088 RID: 127112
		private float VoiceDuration;

		// Token: 0x0401F089 RID: 127113
		private int LastClickTimeStamp;

		// Token: 0x0401F08A RID: 127114
		private int BirthdayLetterInterval;

		// Token: 0x0401F08B RID: 127115
		private BirthdayInfo BirthdayInfo;

		// Token: 0x0200BE18 RID: 48664
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403952F RID: 234799
			public const int ButtonBack = 0;

			// Token: 0x04039530 RID: 234800
			public const int ItemButtonPanel = 1;

			// Token: 0x04039531 RID: 234801
			public const int ItemLetterPanel = 2;

			// Token: 0x04039532 RID: 234802
			public const int ButtonPhoto = 3;

			// Token: 0x04039533 RID: 234803
			public const int ButtonGift = 4;

			// Token: 0x04039534 RID: 234804
			public const int TextTitle = 5;

			// Token: 0x04039535 RID: 234805
			public const int TextBless = 6;

			// Token: 0x04039536 RID: 234806
			public const int ScrollViewGift = 7;

			// Token: 0x04039537 RID: 234807
			public const int ItemGift = 8;

			// Token: 0x04039538 RID: 234808
			public const int TextTime = 9;

			// Token: 0x04039539 RID: 234809
			public const int BtnReSelect = 10;

			// Token: 0x0403953A RID: 234810
			public const int SpriteLine = 11;

			// Token: 0x0403953B RID: 234811
			public const int SVInfo = 12;
		}
	}
}
