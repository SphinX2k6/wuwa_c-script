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
	// Token: 0x02004A86 RID: 19078
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkRewardViewLimit : UiTickViewBase
	{
		// Token: 0x0602FBFE RID: 195582 RVA: 0x00D524A7 File Offset: 0x00D506A7
		[NullableContext(1)]
		public DreamLinkRewardViewLimit(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602FBFF RID: 195583 RVA: 0x00D524C4 File Offset: 0x00D506C4
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

		// Token: 0x0602FC00 RID: 195584 RVA: 0x00D52590 File Offset: 0x00D50790
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRewardViewLimit.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRewardViewLimit.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC01 RID: 195585 RVA: 0x00D525D4 File Offset: 0x00D507D4
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

		// Token: 0x0602FC02 RID: 195586 RVA: 0x00D52640 File Offset: 0x00D50840
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DreamLinkLimitRewardRefresh, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0602FC03 RID: 195587 RVA: 0x00D5265E File Offset: 0x00D5085E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DreamLinkLimitRewardRefresh, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0602FC04 RID: 195588 RVA: 0x00D5267C File Offset: 0x00D5087C
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

		// Token: 0x0602FC05 RID: 195589 RVA: 0x00D52698 File Offset: 0x00D50898
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

		// Token: 0x0602FC06 RID: 195590 RVA: 0x00D527B4 File Offset: 0x00D509B4
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

		// Token: 0x0602FC07 RID: 195591 RVA: 0x00D52881 File Offset: 0x00D50A81
		private void RefreshCurrentView()
		{
			this.RefreshTabViewRedDot(this.CurrentTabIndex);
			this.RefreshLayout(this.CurrentTabIndex).Forget();
			this.SpecialRewardItem.Refresh();
		}

		// Token: 0x0602FC08 RID: 195592 RVA: 0x00D528AB File Offset: 0x00D50AAB
		[NullableContext(1)]
		private CommonTabItemData[] GetTabItemData()
		{
			return this.TabComponent.CreateTabItemDataByLength(this.ActivityDataBase.GetLimitTimeRewardTypeLength()).ToArray();
		}

		// Token: 0x0602FC09 RID: 195593 RVA: 0x00D528C8 File Offset: 0x00D50AC8
		[NullableContext(1)]
		private CommonTabItem ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602FC0A RID: 195594 RVA: 0x00D528D0 File Offset: 0x00D50AD0
		private void RefreshTabViewRedDot(int index)
		{
			int tabId = index + 1;
			this.TabComponent.GetTabItemByIndex(index).SetRedDotState(this.ActivityDataBase.CheckHasLimitTimeTabReward(tabId));
		}

		// Token: 0x0602FC0B RID: 195595 RVA: 0x00D528FE File Offset: 0x00D50AFE
		private void OnTypeButtonClicked(int index)
		{
			this.RefreshLayout(index).Forget();
		}

		// Token: 0x0602FC0C RID: 195596 RVA: 0x00D5290C File Offset: 0x00D50B0C
		[NullableContext(1)]
		private CommonTabData GetCommonData(int index)
		{
			string text;
			string icon;
			this.ActivityDataBase.GetTypeInfoByTabId(index + 1).Deconstruct(out text, out icon);
			string textId = text;
			return new CommonTabData(icon, new CommonTabTitleData(textId, Array.Empty<object>()), null);
		}

		// Token: 0x0602FC0D RID: 195597 RVA: 0x00D52944 File Offset: 0x00D50B44
		[NullableContext(1)]
		private DreamLinkRewardLimitTimeItem CreateTaskItem()
		{
			return new DreamLinkRewardLimitTimeItem();
		}

		// Token: 0x0602FC0E RID: 195598 RVA: 0x00D5294C File Offset: 0x00D50B4C
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

		// Token: 0x0602FC0F RID: 195599 RVA: 0x00D52998 File Offset: 0x00D50B98
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

		// Token: 0x0602FC10 RID: 195600 RVA: 0x00D52A08 File Offset: 0x00D50C08
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
				this.SequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams
				{
					Frame = this.SequencePlayer.GetEndTime().Time,
					MarkedFrame = "A",
					PositionType = EMovieScenePositionType.MarkedFrame,
					UpdateMethod = EUpdatePositionMethod.Play
				});
				Action startCallback2 = startCallback;
				if (startCallback2 == null)
				{
					return;
				}
				startCallback2();
			}, 100, this.MemoryTag);
		}

		// Token: 0x0602FC11 RID: 195601 RVA: 0x00D52A64 File Offset: 0x00D50C64
		private void PlayAutoRotate()
		{
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("WeaponRoot").Value, ECollectActorType.UI);
			this.WeaponHandle = new DreamLinkWeaponModelHandle(actorWithTag);
			int value = ConfigCommonParamById.GetIntConfig("DreamLinkModelRotateTime").Value;
			this.WeaponHandle.SetRotateParam((float)value, ERotateAxis.Yaw, true);
			this.WeaponHandle.StartRotate();
		}

		// Token: 0x0401959A RID: 103834
		private DreamLinkData ActivityDataBase;

		// Token: 0x0401959B RID: 103835
		private bool LimitTimeRewardOn = true;

		// Token: 0x0401959C RID: 103836
		[Nullable(1)]
		private string RemainTimeText = "";

		// Token: 0x0401959D RID: 103837
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401959E RID: 103838
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DreamLinkRewardLimitTimeItem, DreamLinkRewardData> TaskLayout;

		// Token: 0x0401959F RID: 103839
		private int CurrentTabIndex;

		// Token: 0x040195A0 RID: 103840
		private DreamLinkRewardSpecialItem SpecialRewardItem;

		// Token: 0x040195A1 RID: 103841
		private ActivityWeaponDescribeComponent WeaponItem;

		// Token: 0x040195A2 RID: 103842
		private ULevelSequencePlayer SequencePlayer;

		// Token: 0x040195A3 RID: 103843
		private ALevelSequenceActor SequenceActor;

		// Token: 0x040195A4 RID: 103844
		private AActor OriginCameraActor;

		// Token: 0x040195A5 RID: 103845
		private AActor SceneCameraActor;

		// Token: 0x040195A6 RID: 103846
		private DreamLinkWeaponModelHandle WeaponHandle;

		// Token: 0x0200A6FA RID: 42746
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403398E RID: 211342
			public const int CommonTabComponent = 0;

			// Token: 0x0403398F RID: 211343
			public const int Layout = 1;

			// Token: 0x04033990 RID: 211344
			public const int TxtTime = 2;

			// Token: 0x04033991 RID: 211345
			public const int PanelSpecial = 3;

			// Token: 0x04033992 RID: 211346
			public const int WeaponAttributeItem = 4;
		}
	}
}
