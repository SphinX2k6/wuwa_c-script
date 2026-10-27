using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AAA RID: 23210
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkRewardViewLimit : UiTickViewBase
	{
		// Token: 0x0603ACB2 RID: 240818 RVA: 0x00E01EFD File Offset: 0x00E000FD
		[NullableContext(1)]
		public DreamLinkRewardViewLimit(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ACB3 RID: 240819 RVA: 0x00E01F18 File Offset: 0x00E00118
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603ACB4 RID: 240820 RVA: 0x00E01FE4 File Offset: 0x00E001E4
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRewardViewLimit.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRewardViewLimit.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACB5 RID: 240821 RVA: 0x00E02028 File Offset: 0x00E00228
		protected override void OnStart()
		{
			this.RemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			int previewWeaponId = this.ActivityDataBase.GetPreviewWeaponId();
			WeaponTrialData weaponTrialData = new WeaponTrialData();
			weaponTrialData.SetTrialId(previewWeaponId, true);
			this.WeaponItem.Refresh(weaponTrialData.GetItemId(), false);
			this.WeaponItem.SetLookButtonVisible(true);
			this.WeaponItem.BindWeaponPreviewFunction(new int[]
			{
				previewWeaponId
			}, 0);
		}

		// Token: 0x0603ACB6 RID: 240822 RVA: 0x00E02094 File Offset: 0x00E00294
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DreamLinkLimitRewardRefresh, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0603ACB7 RID: 240823 RVA: 0x00E020B2 File Offset: 0x00E002B2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DreamLinkLimitRewardRefresh, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0603ACB8 RID: 240824 RVA: 0x00E020D0 File Offset: 0x00E002D0
		protected override void OnTick(float delta)
		{
			this.OnRefreshTime();
			DreamLinkWeaponModelHandle weaponHandle = this.WeaponHandle;
			if (weaponHandle == null)
			{
				return;
			}
			weaponHandle.Tick(delta);
		}

		// Token: 0x0603ACB9 RID: 240825 RVA: 0x00E020EC File Offset: 0x00E002EC
		protected override void OnHandleLoadScene()
		{
			this.OriginCameraActor = CameraModel.Instance.MainModel.CurrentCameraActor;
			this.SceneCameraActor = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("DoorCamera").Value, ECollectActorType.UI);
			CameraController.Instance.SetViewTarget(this.SceneCameraActor, "DreamLinkRewardViewLimit.OpenAndStartSequence", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("Weapon1").Value, ECollectActorType.UI);
			AActor actorWithTag2 = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("Weapon2").Value, ECollectActorType.UI);
			AActor[] array = new AActor[]
			{
				actorWithTag,
				actorWithTag2
			};
			for (int i = 0; i < array.Length; i++)
			{
				USkeletalMeshComponent uskeletalMeshComponent = array[i].GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
				uskeletalMeshComponent.SetTickableWhenPaused(true);
				uskeletalMeshComponent.SetForcedLOD(1);
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("Sequence_DreamLinkRewardStart");
			this.PlaySceneLevelSequence(resourcePath, new Action(this.PlayAutoRotate));
		}

		// Token: 0x0603ACBA RID: 240826 RVA: 0x00E02208 File Offset: 0x00E00408
		protected override void OnBeforeDestroy()
		{
			CameraController.Instance.SetViewTarget(this.OriginCameraActor, "DreamLinkRewardViewLimit.OnBeforeDestroy", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
			this.OriginCameraActor = null;
			this.SceneCameraActor = null;
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			if (sequenceActor != null && sequenceActor.IsValid())
			{
				ALevelSequenceActor sequenceActor2 = this.SequenceActor;
				if (sequenceActor2 != null)
				{
					sequenceActor2.K2_DestroyActor();
				}
				this.SequenceActor = null;
			}
			ULevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsValid())
			{
				ULevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.Stop();
				}
				this.SequencePlayer = null;
			}
			DreamLinkWeaponModelHandle weaponHandle = this.WeaponHandle;
			if (weaponHandle != null)
			{
				weaponHandle.StopRotate();
			}
			DreamLinkWeaponModelHandle weaponHandle2 = this.WeaponHandle;
			if (weaponHandle2 == null)
			{
				return;
			}
			weaponHandle2.Destroy();
		}

		// Token: 0x0603ACBB RID: 240827 RVA: 0x00E022D5 File Offset: 0x00E004D5
		private void RefreshCurrentView()
		{
			this.RefreshTabViewRedDot(this.CurrentTabIndex);
			this.RefreshLayout(this.CurrentTabIndex).Forget();
			this.SpecialRewardItem.Refresh();
		}

		// Token: 0x0603ACBC RID: 240828 RVA: 0x00E022FF File Offset: 0x00E004FF
		[NullableContext(1)]
		private CommonTabItemData[] GetTabItemData()
		{
			return this.TabComponent.CreateTabItemDataByLength(this.ActivityDataBase.GetLimitTimeRewardTypeLength()).ToArray();
		}

		// Token: 0x0603ACBD RID: 240829 RVA: 0x00E0231C File Offset: 0x00E0051C
		[NullableContext(1)]
		private CommonTabItem ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0603ACBE RID: 240830 RVA: 0x00E02324 File Offset: 0x00E00524
		private void RefreshTabViewRedDot(int index)
		{
			int tabId = index + 1;
			this.TabComponent.GetTabItemByIndex(index).SetRedDotState(this.ActivityDataBase.CheckHasLimitTimeTabReward(tabId));
		}

		// Token: 0x0603ACBF RID: 240831 RVA: 0x00E02352 File Offset: 0x00E00552
		private void OnTypeButtonClicked(int index)
		{
			this.RefreshLayout(index).Forget();
		}

		// Token: 0x0603ACC0 RID: 240832 RVA: 0x00E02360 File Offset: 0x00E00560
		[NullableContext(1)]
		private CommonTabData GetCommonData(int index)
		{
			string text;
			string icon;
			this.ActivityDataBase.GetTypeInfoByTabId(index + 1).Deconstruct(out text, out icon);
			string textId = text;
			return new CommonTabData(icon, new CommonTabTitleData(textId, Array.Empty<object>()), null);
		}

		// Token: 0x0603ACC1 RID: 240833 RVA: 0x00E02398 File Offset: 0x00E00598
		[NullableContext(1)]
		private DreamLinkRewardLimitTimeItem CreateTaskItem()
		{
			return new DreamLinkRewardLimitTimeItem();
		}

		// Token: 0x0603ACC2 RID: 240834 RVA: 0x00E023A0 File Offset: 0x00E005A0
		private UniTask RefreshLayout(int index)
		{
			DreamLinkRewardViewLimit.<RefreshLayout>d__30 <RefreshLayout>d__;
			<RefreshLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLayout>d__.<>4__this = this;
			<RefreshLayout>d__.index = index;
			<RefreshLayout>d__.<>1__state = -1;
			<RefreshLayout>d__.<>t__builder.Start<DreamLinkRewardViewLimit.<RefreshLayout>d__30>(ref <RefreshLayout>d__);
			return <RefreshLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACC3 RID: 240835 RVA: 0x00E023EC File Offset: 0x00E005EC
		private void OnRefreshTime()
		{
			if (!this.LimitTimeRewardOn)
			{
				return;
			}
			long limitTimeEndTime = this.ActivityDataBase.GetLimitTimeEndTime();
			double serverTime = TimeUtil.Instance.GetServerTime();
			if ((double)limitTimeEndTime - serverTime < 0.0)
			{
				this.LimitTimeRewardOn = false;
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(limitTimeEndTime, this.RemainTimeText);
			base.GetText(2).SetText(remainTimeText, true);
		}

		// Token: 0x0603ACC4 RID: 240836 RVA: 0x00E0245C File Offset: 0x00E0065C
		[NullableContext(1)]
		protected void PlaySceneLevelSequence(string levelSequencePath, [Nullable(2)] Action startCallback = null)
		{
			if (this.SequencePlayer != null)
			{
				this.SequencePlayer.Stop();
				this.SequencePlayer = null;
			}
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(levelSequencePath, delegate([Nullable(2)] ULevelSequence levelSequence, string _)
			{
				if (!ObjectUtils.IsValid(levelSequence))
				{
					return;
				}
				ALevelSequenceActor alevelSequenceActor = ActorSystem.Instance.Spawn(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null) as ALevelSequenceActor;
				alevelSequenceActor.SetSequence(levelSequence);
				alevelSequenceActor.PlaybackSettings = new FMovieSceneSequencePlaybackSettings
				{
					bRestoreState = false,
					bPauseAtEnd = true
				};
				alevelSequenceActor.SetTickableWhenPaused(true);
				UKuroSequenceRuntimeFunctionLibrary.SetSequenceInUiScene(levelSequence, true);
				this.SequenceActor = alevelSequenceActor;
				this.SequencePlayer = alevelSequenceActor.SequencePlayer;
				this.SequenceActor.bOverrideInstanceData = true;
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
				FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(RenderModuleController.Instance.GetKuroCurrentUiSceneTransform().Value);
				udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
				this.SequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams(this.SequencePlayer.GetEndTime().Time, 0f, "A", EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play));
				Action startCallback2 = startCallback;
				if (startCallback2 == null)
				{
					return;
				}
				startCallback2();
			}, 100, this.MemoryTag);
		}

		// Token: 0x0603ACC5 RID: 240837 RVA: 0x00E024B8 File Offset: 0x00E006B8
		private void PlayAutoRotate()
		{
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("WeaponRoot").Value, ECollectActorType.UI);
			this.WeaponHandle = new DreamLinkWeaponModelHandle(actorWithTag);
			int value = ConfigCommonParamById.GetIntConfig("DreamLinkModelRotateTime").Value;
			this.WeaponHandle.SetRotateParam((float)value, ERotateAxis.Yaw, true);
			this.WeaponHandle.StartRotate();
		}

		// Token: 0x0401EAF3 RID: 125683
		private DreamLinkData ActivityDataBase;

		// Token: 0x0401EAF4 RID: 125684
		private bool LimitTimeRewardOn = true;

		// Token: 0x0401EAF5 RID: 125685
		[Nullable(1)]
		private string RemainTimeText = "";

		// Token: 0x0401EAF6 RID: 125686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401EAF7 RID: 125687
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DreamLinkRewardLimitTimeItem, DreamLinkRewardData> TaskLayout;

		// Token: 0x0401EAF8 RID: 125688
		private int CurrentTabIndex;

		// Token: 0x0401EAF9 RID: 125689
		private DreamLinkRewardSpecialItem SpecialRewardItem;

		// Token: 0x0401EAFA RID: 125690
		private ActivityWeaponDescribeComponent WeaponItem;

		// Token: 0x0401EAFB RID: 125691
		private ULevelSequencePlayer SequencePlayer;

		// Token: 0x0401EAFC RID: 125692
		private ALevelSequenceActor SequenceActor;

		// Token: 0x0401EAFD RID: 125693
		private AActor OriginCameraActor;

		// Token: 0x0401EAFE RID: 125694
		private AActor SceneCameraActor;

		// Token: 0x0401EAFF RID: 125695
		private DreamLinkWeaponModelHandle WeaponHandle;

		// Token: 0x0200BCF1 RID: 48369
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038FC3 RID: 233411
			public const int CommonTabComponent = 0;

			// Token: 0x04038FC4 RID: 233412
			public const int Layout = 1;

			// Token: 0x04038FC5 RID: 233413
			public const int TxtTime = 2;

			// Token: 0x04038FC6 RID: 233414
			public const int PanelSpecial = 3;

			// Token: 0x04038FC7 RID: 233415
			public const int WeaponAttributeItem = 4;
		}
	}
}
