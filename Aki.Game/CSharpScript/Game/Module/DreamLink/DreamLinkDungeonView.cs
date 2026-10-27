using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA6 RID: 23206
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkDungeonView : UiTickViewBase
	{
		// Token: 0x0603AC67 RID: 240743 RVA: 0x00DFFEBD File Offset: 0x00DFE0BD
		[NullableContext(1)]
		public DreamLinkDungeonView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603AC68 RID: 240744 RVA: 0x00DFFEE4 File Offset: 0x00DFE0E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnPre));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnBtnNext));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnEnter));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnBtnReward));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnBtnMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603AC69 RID: 240745 RVA: 0x00E00275 File Offset: 0x00DFE475
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSelectRoleDreamDungeon, new Action<int>(this.OnSelectRoleDungeon));
		}

		// Token: 0x0603AC6A RID: 240746 RVA: 0x00E00293 File Offset: 0x00DFE493
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectRoleDreamDungeon, new Action<int>(this.OnSelectRoleDungeon));
		}

		// Token: 0x0603AC6B RID: 240747 RVA: 0x00E002B4 File Offset: 0x00DFE4B4
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkDungeonView.<OnBeforeStartAsync>d__45 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkDungeonView.<OnBeforeStartAsync>d__45>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC6C RID: 240748 RVA: 0x00E002F8 File Offset: 0x00DFE4F8
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DreamLinkDungeonView.<OnBeforeShowAsyncImplementImplement>d__46 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DreamLinkDungeonView.<OnBeforeShowAsyncImplementImplement>d__46>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC6D RID: 240749 RVA: 0x00E0033C File Offset: 0x00DFE53C
		protected override void OnBeforeShow()
		{
			this.ShakeSequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.ShakeSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("KuroUiSceneRoot").Value, ECollectActorType.UI);
			this.LockSequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData2 = this.LockSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			this.UnlockSequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData3 = this.UnlockSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(actorWithTag.D_GetTransform());
			udefaultLevelSequenceInstanceData2.TransformOrigin = transformOrigin;
			udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
			udefaultLevelSequenceInstanceData3.TransformOrigin = transformOrigin;
			this.SequenceCameraActor = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SequenceCamera").Value, ECollectActorType.UI);
			this.DoorCameraActor = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("DoorCamera").Value, ECollectActorType.UI);
			this.RefreshView();
			this.RefreshEnvironment(true);
			this.RefreshRoleList(true);
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			RogueRoleInstData roleInstDataByIndex = currentActivityData.GetRoleInstDataByIndex(this.SelectInstIndex);
			if (roleInstDataByIndex != null && roleInstDataByIndex.IsFinish)
			{
				ALevelSequenceActor unlockSequenceActor = this.UnlockSequenceActor;
				if (unlockSequenceActor != null)
				{
					ULevelSequencePlayer sequencePlayer = unlockSequenceActor.SequencePlayer;
					if (sequencePlayer != null)
					{
						sequencePlayer.Play();
					}
				}
				if (!this.FirstIn)
				{
					ALevelSequenceActor unlockSequenceActor2 = this.UnlockSequenceActor;
					if (unlockSequenceActor2 != null)
					{
						ULevelSequencePlayer sequencePlayer2 = unlockSequenceActor2.SequencePlayer;
						if (sequencePlayer2 != null)
						{
							sequencePlayer2.JumpToFrame(this.UnlockSequenceActor.SequencePlayer.GetEndTime().Time);
						}
					}
				}
			}
			else
			{
				ALevelSequenceActor lockSequenceActor = this.LockSequenceActor;
				if (lockSequenceActor != null)
				{
					ULevelSequencePlayer sequencePlayer3 = lockSequenceActor.SequencePlayer;
					if (sequencePlayer3 != null)
					{
						sequencePlayer3.Play();
					}
				}
				if (!this.FirstIn)
				{
					ALevelSequenceActor lockSequenceActor2 = this.LockSequenceActor;
					if (lockSequenceActor2 != null)
					{
						ULevelSequencePlayer sequencePlayer4 = lockSequenceActor2.SequencePlayer;
						if (sequencePlayer4 != null)
						{
							sequencePlayer4.JumpToFrame(this.LockSequenceActor.SequencePlayer.GetEndTime().Time);
						}
					}
				}
			}
			this.FirstIn = false;
		}

		// Token: 0x0603AC6E RID: 240750 RVA: 0x00E0050D File Offset: 0x00DFE70D
		protected override void OnAfterShow()
		{
			this.InitProgressAnim();
		}

		// Token: 0x0603AC6F RID: 240751 RVA: 0x00E00518 File Offset: 0x00DFE718
		protected override void OnAfterHide()
		{
			if (this.ShowSequencePlayer != null && this.ShowSequencePlayer.IsValid())
			{
				this.ShowSequencePlayer.Stop();
				this.ShowSequencePlayer = null;
			}
			if (this.MoveTweener != null && this.MoveTweener.IsValid())
			{
				this.MoveTweener.Kill(false);
				this.MoveTweener = null;
			}
			if (this.LockSequenceActor != null && this.LockSequenceActor.IsValid())
			{
				this.LockSequenceActor.SequencePlayer.Stop();
				this.LockSequenceActor.K2_DestroyActor();
				this.LockSequenceActor = null;
			}
			if (this.ShakeSequenceActor != null && this.ShakeSequenceActor.IsValid())
			{
				this.ShakeSequenceActor.SequencePlayer.Stop();
				this.ShakeSequenceActor.K2_DestroyActor();
				this.ShakeSequenceActor = null;
			}
			if (this.ShowSequenceActor != null && this.ShowSequenceActor.IsValid())
			{
				this.ShowSequenceActor.K2_DestroyActor();
				this.ShowSequenceActor = null;
			}
			this.ClearWaveEffect();
			UKuroRenderingRuntimeBPPluginBPLibrary.RemovePostprocessMaterial(this.RootActor, this.PostProcessHandleId);
			this.PostProcessMaterialDynamicInstance = null;
			CameraController.Instance.SetViewTarget(this.OriginCameraActor, "DreamLinkDungeonView.OnBeforeDestroy", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		}

		// Token: 0x0603AC70 RID: 240752 RVA: 0x00E00660 File Offset: 0x00DFE860
		protected override void OnBeforeDestroy()
		{
			SkeletalObserverHandle roleHandle = this.RoleHandle;
			UiModelActorComponent uiModelActorComponent;
			if (roleHandle == null)
			{
				uiModelActorComponent = null;
			}
			else
			{
				UiModelBase model = roleHandle.Model;
				uiModelActorComponent = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
			}
			UiModelActorComponent uiModelActorComponent2 = uiModelActorComponent;
			if (uiModelActorComponent2 != null && uiModelActorComponent2.MainMeshComponent != null && uiModelActorComponent2.MainMeshComponent.IsValid())
			{
				uiModelActorComponent2.MainMeshComponent.ForcedLodModel = 0;
			}
			SkeletalObserverHandle[] itemModelHandleList = this.ItemModelHandleList;
			for (int i = 0; i < itemModelHandleList.Length; i++)
			{
				UiModelBase model2 = itemModelHandleList[i].Model;
				UiModelActorComponent uiModelActorComponent3 = (model2 != null) ? model2.CheckGetComponent<UiModelActorComponent>() : null;
				if (uiModelActorComponent3 != null && uiModelActorComponent3.MainMeshComponent != null && uiModelActorComponent3.MainMeshComponent.IsValid())
				{
					uiModelActorComponent3.MainMeshComponent.ForcedLodModel = 0;
				}
			}
			UiSceneManager.Instance.DestroyDreamLinkRoleSkeletalHandle();
			this.RoleHandle = null;
			this.ItemModelHandleList = new SkeletalObserverHandle[0];
			UiSceneManager.Instance.DestroyAllDreamLinkWeaponSkeletalHandle();
			CameraController.Instance.SetViewTarget(this.OriginCameraActor, "DreamLinkDungeonView.OnBeforeDestroy", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
			UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
		}

		// Token: 0x0603AC71 RID: 240753 RVA: 0x00E00768 File Offset: 0x00DFE968
		[NullableContext(1)]
		protected void LoadModel(int roleId, string animationPath, int dungeonId)
		{
			DreamLinkDungeonView.<>c__DisplayClass51_0 CS$<>8__locals1 = new DreamLinkDungeonView.<>c__DisplayClass51_0();
			CS$<>8__locals1.roleId = roleId;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dungeonId = dungeonId;
			DreamLinkDungeonView.<>c__DisplayClass51_0 CS$<>8__locals2 = CS$<>8__locals1;
			UiModelBase model = this.RoleHandle.Model;
			CS$<>8__locals2.uiRoleDataComponent = ((model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null);
			if (CS$<>8__locals1.uiRoleDataComponent != null && CS$<>8__locals1.uiRoleDataComponent.RoleConfigId == CS$<>8__locals1.roleId)
			{
				return;
			}
			SkeletalObserverHandle[] itemModelHandleList = this.ItemModelHandleList;
			for (int i = 0; i < itemModelHandleList.Length; i++)
			{
				UiModelBase model2 = itemModelHandleList[i].Model;
				UiModelDataComponent uiModelDataComponent = (model2 != null) ? model2.CheckGetComponent<UiModelDataComponent>() : null;
				if (uiModelDataComponent != null)
				{
					uiModelDataComponent.SetVisible(false);
				}
			}
			ResourceSystem.Instance.LoadAsync<UAnimationAsset>(animationPath, delegate([Nullable(2)] UAnimationAsset asset, string _)
			{
				if (asset == null)
				{
					return;
				}
				if (CS$<>8__locals1.uiRoleDataComponent != null && CS$<>8__locals1.uiRoleDataComponent.RoleConfigId == CS$<>8__locals1.roleId)
				{
					return;
				}
				UiModelBase model3 = CS$<>8__locals1.<>4__this.RoleHandle.Model;
				UiRoleLoadComponent uiRoleLoadComponent = (model3 != null) ? model3.CheckGetComponent<UiRoleLoadComponent>() : null;
				if (uiRoleLoadComponent != null)
				{
					uiRoleLoadComponent.LoadModelByRoleConfigId(CS$<>8__locals1.roleId, -1, true, delegate
					{
						UiModelBase model4 = CS$<>8__locals1.<>4__this.RoleHandle.Model;
						UiModelAnimationComponent uiModelAnimationComponent = (model4 != null) ? model4.CheckGetComponent<UiModelAnimationComponent>() : null;
						if (uiModelAnimationComponent != null)
						{
							uiModelAnimationComponent.PlayAnimation(asset, true);
						}
						UiModelBase model5 = CS$<>8__locals1.<>4__this.RoleHandle.Model;
						UiModelActorComponent uiModelActorComponent = (model5 != null) ? model5.CheckGetComponent<UiModelActorComponent>() : null;
						if (uiModelActorComponent != null)
						{
							uiModelActorComponent.SetTransformByTag("RoleCase");
							if (uiModelActorComponent.MainMeshComponent != null && uiModelActorComponent.MainMeshComponent.IsValid())
							{
								uiModelActorComponent.MainMeshComponent.ForcedLodModel = 1;
							}
						}
						UiModelBase model6 = CS$<>8__locals1.<>4__this.RoleHandle.Model;
						UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = (model6 != null) ? model6.CheckGetComponent<UiModelRenderingMaterialComponent>() : null;
						string effectPath = EffectUtil.GetEffectPath("ChangeRoleMaterialController");
						PD_CharacterControllerData_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<PD_CharacterControllerData_C>(effectPath);
						if (uiModelRenderingMaterialComponent != null && loadedAsset != null)
						{
							uiModelRenderingMaterialComponent.AddRenderingMaterialByData(loadedAsset);
						}
						UiModelUtil.Instance.PlayEffectOnRoot(CS$<>8__locals1.<>4__this.RoleHandle.Model, "ChangeRoleEffect");
						DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
						if (currentActivityData == null)
						{
							return;
						}
						if (!currentActivityData.GetRoleInstDataByIndex(CS$<>8__locals1.<>4__this.SelectInstIndex).IsFinish)
						{
							string effectPath2 = EffectUtil.GetEffectPath("DreamLinkLockMaterialController");
							PD_CharacterControllerData_C loadedAsset2 = ResourceSystem.Instance.GetLoadedAsset<PD_CharacterControllerData_C>(effectPath2);
							if (uiModelRenderingMaterialComponent != null && loadedAsset2 != null)
							{
								uiModelRenderingMaterialComponent.AddRenderingMaterialByData(loadedAsset2);
							}
						}
						CS$<>8__locals1.<>4__this.LoadItemModel(CS$<>8__locals1.dungeonId);
					});
				}
			}, 100, this.MemoryTag);
		}

		// Token: 0x0603AC72 RID: 240754 RVA: 0x00E0081E File Offset: 0x00DFEA1E
		protected void RefreshView()
		{
			this.RefreshPreNextButton();
			this.RefreshDoorState();
			this.RefreshEnterButton();
			this.RefreshReward();
		}

		// Token: 0x0603AC73 RID: 240755 RVA: 0x00E00838 File Offset: 0x00DFEA38
		protected void RefreshReward()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			RogueRoleInstData currentSelectInst = currentActivityData.GetRoleInstDataByIndex(this.SelectInstIndex);
			if (currentSelectInst == null)
			{
				return;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(currentSelectInst.InstId);
			if (config == null)
			{
				return;
			}
			List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(config.Value.FirstRewardId, null);
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(exchangeRewardPreviewRewardList, delegate
			{
				GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout2 = this.RewardLayout;
				foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in ((rewardLayout2 != null) ? rewardLayout2.GetLayoutItemMap().Values : null))
				{
					commonItemSmallItemGrid.SetReceivedVisible(currentSelectInst.IsFinish);
				}
			}, false);
		}

		// Token: 0x0603AC74 RID: 240756 RVA: 0x00E008E0 File Offset: 0x00DFEAE0
		protected void RefreshEnterButton()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			DreamLinkDungeonView.EDreamLinkEnterButtonState edreamLinkEnterButtonState = (currentActivityData.GetInstStage() == EDreamLinkStage.First) ? DreamLinkDungeonView.EDreamLinkEnterButtonState.Blue : DreamLinkDungeonView.EDreamLinkEnterButtonState.Red;
			DreamLinkDungeonView.EDreamLinkEnterButtonState? currentEnterButtonState = this.CurrentEnterButtonState;
			DreamLinkDungeonView.EDreamLinkEnterButtonState edreamLinkEnterButtonState2 = edreamLinkEnterButtonState;
			if (!(currentEnterButtonState.GetValueOrDefault() == edreamLinkEnterButtonState2 & currentEnterButtonState != null))
			{
				if (edreamLinkEnterButtonState == DreamLinkDungeonView.EDreamLinkEnterButtonState.Blue)
				{
					this.CurrentEnterButtonState = new DreamLinkDungeonView.EDreamLinkEnterButtonState?(DreamLinkDungeonView.EDreamLinkEnterButtonState.Blue);
					LevelSequencePlayer enterButtonLevelSequencePlayer = this.EnterButtonLevelSequencePlayer;
					if (enterButtonLevelSequencePlayer != null)
					{
						enterButtonLevelSequencePlayer.PlayLevelSequenceByName("Blue", false, null, false);
					}
				}
				else
				{
					this.CurrentEnterButtonState = new DreamLinkDungeonView.EDreamLinkEnterButtonState?(DreamLinkDungeonView.EDreamLinkEnterButtonState.Red);
					LevelSequencePlayer enterButtonLevelSequencePlayer2 = this.EnterButtonLevelSequencePlayer;
					if (enterButtonLevelSequencePlayer2 != null)
					{
						enterButtonLevelSequencePlayer2.PlayLevelSequenceByName("Red", false, null, false);
					}
				}
			}
			if (this.CurrentEnvironmentState.GetValueOrDefault() == DreamLinkDungeonView.EEnvironmentState.Door)
			{
				UUIButtonComponent button = base.GetButton(6);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(!currentActivityData.IsDreamLinkFunctionUnlock(8));
				}
				base.GetItem(16).SetUIActive(false);
				base.GetText(15).SetText("", true);
				return;
			}
			RogueRoleInstData roleInstDataByIndex = currentActivityData.GetRoleInstDataByIndex(this.SelectInstIndex);
			if (roleInstDataByIndex == null)
			{
				return;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(roleInstDataByIndex.InstId);
			if (config == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), config.Value.MapName, Array.Empty<object>());
			UUIButtonComponent button2 = base.GetButton(6);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(!roleInstDataByIndex.IsFinish);
			}
			base.GetItem(16).SetUIActive(false);
			base.GetItem(18).SetUIActive(currentActivityData.CheckDungeonRedDotStateByPage(this.CurrentPageIndex - 1, 3));
			base.GetItem(19).SetUIActive(currentActivityData.CheckDungeonRedDotStateByPage(this.CurrentPageIndex + 1, 3));
		}

		// Token: 0x0603AC75 RID: 240757 RVA: 0x00E00AAC File Offset: 0x00DFECAC
		protected void RefreshEnvironment(bool isForce = false)
		{
			DreamLinkDungeonView.<>c__DisplayClass55_0 CS$<>8__locals1 = new DreamLinkDungeonView.<>c__DisplayClass55_0();
			CS$<>8__locals1.<>4__this = this;
			DreamLinkDungeonView.EEnvironmentState? currentEnvironmentState = this.CurrentEnvironmentState;
			DreamLinkDungeonView.EEnvironmentState eenvironmentState = DreamLinkDungeonView.EEnvironmentState.DreamLinkDungeon;
			if ((currentEnvironmentState.GetValueOrDefault() == eenvironmentState & currentEnvironmentState != null) && !isForce)
			{
				this.RefreshRoleList(true);
				return;
			}
			CS$<>8__locals1.dreamLinkData = DreamLinkController.Instance.GetCurrentActivityData();
			if (CS$<>8__locals1.dreamLinkData == null || this.CurrentPageIndex >= 2)
			{
				return;
			}
			bool flag = this.CurrentEnvironmentState.GetValueOrDefault() == DreamLinkDungeonView.EEnvironmentState.Door;
			this.CurrentEnvironmentState = new DreamLinkDungeonView.EEnvironmentState?(DreamLinkDungeonView.EEnvironmentState.DreamLinkDungeon);
			if (flag)
			{
				this.PlayBlackScreen(new Action(CS$<>8__locals1.<RefreshEnvironment>g__playEnvironmentSequence|0), "DreamLinkDungeonView.RefreshEnvironment");
				return;
			}
			CS$<>8__locals1.<RefreshEnvironment>g__playEnvironmentSequence|0();
		}

		// Token: 0x0603AC76 RID: 240758 RVA: 0x00E00B4C File Offset: 0x00DFED4C
		protected void RefreshPreNextButton()
		{
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(this.CurrentPageIndex > 0);
			}
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (this.CurrentPageIndex == 1)
			{
				UUIButtonComponent button2 = base.GetButton(5);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetUIActive(currentActivityData.IsAllInstFinished());
				return;
			}
			else
			{
				int finishInstCount = currentActivityData.GetFinishInstCount();
				int lastUnlockInst = currentActivityData.GetLastUnlockInst();
				UUIButtonComponent button3 = base.GetButton(5);
				if (button3 == null)
				{
					return;
				}
				button3.RootUIComp.Get().SetUIActive((this.CurrentPageIndex + 1) * 3 <= finishInstCount && this.CurrentPageIndex * 3 <= lastUnlockInst && this.CurrentPageIndex < 2);
				return;
			}
		}

		// Token: 0x0603AC77 RID: 240759 RVA: 0x00E00C0C File Offset: 0x00DFEE0C
		protected void RefreshRoleList(bool isInit = true)
		{
			if (this.CurrentEnvironmentState.GetValueOrDefault() == DreamLinkDungeonView.EEnvironmentState.Door)
			{
				UUIItem item = base.GetItem(2);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					return;
				}
				List<RogueRoleInstData> instListByPages = currentActivityData.GetInstListByPages(this.CurrentPageIndex, 3);
				if (instListByPages.Count > 0)
				{
					this.DreamLinkDungeonRolePanel.Refresh(instListByPages.ToArray(), isInit ? (this.SelectInstIndex % 3) : 0);
					this.PlaySelectWaveEffect();
					UUIItem item2 = base.GetItem(2);
					if (item2 == null)
					{
						return;
					}
					item2.SetUIActive(true);
					return;
				}
				else
				{
					UUIItem item3 = base.GetItem(2);
					if (item3 == null)
					{
						return;
					}
					item3.SetUIActive(false);
					return;
				}
			}
		}

		// Token: 0x0603AC78 RID: 240760 RVA: 0x00E00CAC File Offset: 0x00DFEEAC
		protected void RefreshDoorState()
		{
			if (this.CurrentPageIndex < 2)
			{
				return;
			}
			if (DreamLinkController.Instance.GetCurrentActivityData() == null)
			{
				return;
			}
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetAlpha(0f);
			}
			this.RefreshRoleList(true);
			this.CurrentEnvironmentState = new DreamLinkDungeonView.EEnvironmentState?(DreamLinkDungeonView.EEnvironmentState.Door);
			this.ClearWaveEffect();
			this.PlayDoorSequence();
		}

		// Token: 0x0603AC79 RID: 240761 RVA: 0x00E00D08 File Offset: 0x00DFEF08
		protected void InitDefaultSelectIndex()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			int num = (currentActivityData.DungeonProgressRecord == currentActivityData.GetCurrentCatProgress()) ? currentActivityData.GetLastUnlockInst() : currentActivityData.GetLastFinishInst();
			this.CurrentPageIndex = num / 3;
			this.SelectInstIndex = num;
			if (this.CurrentPageIndex >= 2)
			{
				this.CurrentEnvironmentState = new DreamLinkDungeonView.EEnvironmentState?(DreamLinkDungeonView.EEnvironmentState.Door);
			}
			else
			{
				this.CurrentEnvironmentState = new DreamLinkDungeonView.EEnvironmentState?(DreamLinkDungeonView.EEnvironmentState.DreamLinkDungeon);
				this.SelectInstIndex = num;
			}
			if (this.CurrentPageIndex >= 2)
			{
				this.CurrentEnvironmentState = new DreamLinkDungeonView.EEnvironmentState?(DreamLinkDungeonView.EEnvironmentState.Door);
				return;
			}
			this.CurrentEnvironmentState = new DreamLinkDungeonView.EEnvironmentState?(DreamLinkDungeonView.EEnvironmentState.DreamLinkDungeon);
		}

		// Token: 0x0603AC7A RID: 240762 RVA: 0x00E00DA0 File Offset: 0x00DFEFA0
		protected void InitProgressAnim()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			if (currentActivityData.DungeonProgressRecord == currentActivityData.GetCurrentCatProgress())
			{
				return;
			}
			int index = currentActivityData.GetLastFinishInst() % 3;
			UUIItem item = base.GetItem(8);
			this.EffectStartPosition = this.DreamLinkDungeonRolePanel.GetLocationByIndex(index);
			FHitResult fhitResult = new FHitResult();
			base.GetUiNiagara(13).D_K2_SetWorldLocation(this.EffectStartPosition.Value, false, ref fhitResult, false);
			FVectorDouble location = item.D_GetRelativeTransform().GetLocation();
			FVectorDouble fvectorDouble = new FVectorDouble((double)(item.Width / 2f), (double)(-(double)item.Height / 2f), 0.0);
			this.EffectEndPosition = new FVectorDouble?(location + fvectorDouble);
			UUINiagara uiNiagara = base.GetUiNiagara(13);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(true);
			}
			FVector endValue = UKismetMathLibrary.Conv_VectorDoubleToVector(this.EffectEndPosition.Value);
			this.MoveTweener = ULTweenBPLibrary.LocalPositionTo(base.GetUiNiagara(13), endValue, 1f, 0f, LTweenEase.InCubic);
			ULTweener moveTweener = this.MoveTweener;
			if (moveTweener == null)
			{
				return;
			}
			moveTweener.OnCompleteCallBack.Bind(delegate()
			{
				UUINiagara uiNiagara2 = base.GetUiNiagara(13);
				if (uiNiagara2 != null)
				{
					uiNiagara2.SetUIActive(false);
				}
				UUINiagara uiNiagara3 = base.GetUiNiagara(14);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(true);
				}
				DreamLinkCatProgressItem catProgressItem = this.CatProgressItem;
				if (catProgressItem == null)
				{
					return;
				}
				catProgressItem.PlayAddProgressAnim();
			});
		}

		// Token: 0x0603AC7B RID: 240763 RVA: 0x00E00EC8 File Offset: 0x00DFF0C8
		protected void LoadItemModel(int dungeonId)
		{
			DreamLinkRoleDungeon? roleConfig = DreamLinkConfig.Instance.GetDreamLinkRoleDungeonConfig(dungeonId);
			if (roleConfig == null)
			{
				return;
			}
			int num = 0;
			foreach (KeyValuePair<string, string> keyValuePair in roleConfig.Value.WeaponShowConfig())
			{
				string value = keyValuePair.Value;
				string modelId = keyValuePair.Key;
				if (this.ItemModelHandleList.Length <= num)
				{
					SkeletalObserverHandle[] array = new SkeletalObserverHandle[this.ItemModelHandleList.Length + 1];
					this.ItemModelHandleList.CopyTo(array, 0);
					array[this.ItemModelHandleList.Length] = UiSceneManager.Instance.InitDreamLinkWeaponSkeletalHandle();
					this.ItemModelHandleList = array;
				}
				SkeletalObserverHandle handle = this.ItemModelHandleList[num];
				num++;
				ResourceSystem.Instance.LoadAsync<UAnimationAsset>(value, delegate([Nullable(2)] UAnimationAsset asset, string _)
				{
					if (asset == null)
					{
						return;
					}
					UiModelBase model = handle.Model;
					UiModelLoadComponent uiModelLoadComponent = (model != null) ? model.CheckGetComponent<UiModelLoadComponent>() : null;
					if (uiModelLoadComponent != null)
					{
						uiModelLoadComponent.LoadModelByModelId(int.Parse(modelId), true, delegate
						{
							UiModelBase model2 = handle.Model;
							UiModelAnimationComponent uiModelAnimationComponent = (model2 != null) ? model2.CheckGetComponent<UiModelAnimationComponent>() : null;
							if (uiModelAnimationComponent != null)
							{
								uiModelAnimationComponent.PlayAnimation(asset, true);
							}
							UiModelBase model3 = handle.Model;
							UiModelActorComponent uiModelActorComponent = (model3 != null) ? model3.CheckGetComponent<UiModelActorComponent>() : null;
							SkeletalObserverHandle roleHandle = this.RoleHandle;
							UiModelActorComponent uiModelActorComponent2;
							if (roleHandle == null)
							{
								uiModelActorComponent2 = null;
							}
							else
							{
								UiModelBase model4 = roleHandle.Model;
								uiModelActorComponent2 = ((model4 != null) ? model4.CheckGetComponent<UiModelActorComponent>() : null);
							}
							UiModelActorComponent uiModelActorComponent3 = uiModelActorComponent2;
							if (((uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null) != null && uiModelActorComponent.MainMeshComponent.IsValid())
							{
								uiModelActorComponent.MainMeshComponent.ForcedLodModel = 1;
							}
							if (uiModelActorComponent != null && uiModelActorComponent3 != null)
							{
								if (roleConfig.Value.WeaponShowCase().ContainsKey(modelId))
								{
									AActor actor = uiModelActorComponent.Actor;
									if (actor != null)
									{
										actor.K2_AttachToComponent(uiModelActorComponent3.MainMeshComponent, new FName(roleConfig.Value.WeaponShowCase()[modelId]), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
									}
									FHitResult fhitResult = null;
									AActor actor2 = uiModelActorComponent.Actor;
									if (actor2 != null)
									{
										actor2.K2_SetActorRelativeTransform(MathUtils.Instance.DefaultTransform, false, ref fhitResult, false);
									}
								}
								else
								{
									uiModelActorComponent.SetTransformByTag("RoleCase");
								}
							}
							UiModelBase model5 = handle.Model;
							UiModelDataComponent uiModelDataComponent = (model5 != null) ? model5.CheckGetComponent<UiModelDataComponent>() : null;
							if (uiModelDataComponent != null)
							{
								uiModelDataComponent.SetVisible(true);
							}
							UiModelUtil.Instance.PlayEffectOnRoot(handle.Model, "ChangeRoleEffect");
							DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
							if (currentActivityData == null)
							{
								return;
							}
							UiModelBase model6 = handle.Model;
							UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = (model6 != null) ? model6.CheckGetComponent<UiModelRenderingMaterialComponent>() : null;
							if (!currentActivityData.GetRoleInstDataByIndex(this.SelectInstIndex).IsFinish)
							{
								string effectPath = EffectUtil.GetEffectPath("DreamLinkLockMaterialController");
								PD_CharacterControllerData_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<PD_CharacterControllerData_C>(effectPath);
								if (uiModelRenderingMaterialComponent != null && loadedAsset != null)
								{
									uiModelRenderingMaterialComponent.AddRenderingMaterialByData(loadedAsset);
								}
							}
						}, null);
					}
				}, 100, this.MemoryTag);
			}
		}

		// Token: 0x0603AC7C RID: 240764 RVA: 0x00E00FF8 File Offset: 0x00DFF1F8
		protected void OnSelectRoleDungeon(int dungeonId)
		{
			if (this.CurrentEnvironmentState.GetValueOrDefault() == DreamLinkDungeonView.EEnvironmentState.Door)
			{
				return;
			}
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			this.SelectInstIndex = currentActivityData.GetRoleInstDataIndex(dungeonId);
			DreamLinkRoleDungeon? dreamLinkRoleDungeonConfig = DreamLinkConfig.Instance.GetDreamLinkRoleDungeonConfig(dungeonId);
			this.LoadModel(dreamLinkRoleDungeonConfig.Value.RoleId, dreamLinkRoleDungeonConfig.Value.AnimationPath, dungeonId);
			this.PlaySelectWaveEffect();
			this.RefreshReward();
			this.RefreshEnterButton();
			RogueRoleInstData roleInstDataByIndex = currentActivityData.GetRoleInstDataByIndex(this.SelectInstIndex);
			if (roleInstDataByIndex == null || !roleInstDataByIndex.IsFinish)
			{
				ALevelSequenceActor unlockSequenceActor = this.UnlockSequenceActor;
				if (unlockSequenceActor != null)
				{
					ULevelSequencePlayer sequencePlayer = unlockSequenceActor.SequencePlayer;
					if (sequencePlayer != null)
					{
						sequencePlayer.Stop();
					}
				}
				ALevelSequenceActor lockSequenceActor = this.LockSequenceActor;
				if (lockSequenceActor == null)
				{
					return;
				}
				ULevelSequencePlayer sequencePlayer2 = lockSequenceActor.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.Play();
				return;
			}
			else
			{
				ALevelSequenceActor lockSequenceActor2 = this.LockSequenceActor;
				if (lockSequenceActor2 != null)
				{
					ULevelSequencePlayer sequencePlayer3 = lockSequenceActor2.SequencePlayer;
					if (sequencePlayer3 != null)
					{
						sequencePlayer3.Stop();
					}
				}
				ALevelSequenceActor unlockSequenceActor2 = this.UnlockSequenceActor;
				if (unlockSequenceActor2 == null)
				{
					return;
				}
				ULevelSequencePlayer sequencePlayer4 = unlockSequenceActor2.SequencePlayer;
				if (sequencePlayer4 == null)
				{
					return;
				}
				sequencePlayer4.Play();
				return;
			}
		}

		// Token: 0x0603AC7D RID: 240765 RVA: 0x00E01100 File Offset: 0x00DFF300
		protected UniTask PlayDoorSequence()
		{
			DreamLinkDungeonView.<PlayDoorSequence>d__63 <PlayDoorSequence>d__;
			<PlayDoorSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDoorSequence>d__.<>4__this = this;
			<PlayDoorSequence>d__.<>1__state = -1;
			<PlayDoorSequence>d__.<>t__builder.Start<DreamLinkDungeonView.<PlayDoorSequence>d__63>(ref <PlayDoorSequence>d__);
			return <PlayDoorSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC7E RID: 240766 RVA: 0x00E01144 File Offset: 0x00DFF344
		[NullableContext(1)]
		protected UniTask PlayBlackScreen(Action callback, string reason)
		{
			DreamLinkDungeonView.<PlayBlackScreen>d__64 <PlayBlackScreen>d__;
			<PlayBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBlackScreen>d__.callback = callback;
			<PlayBlackScreen>d__.reason = reason;
			<PlayBlackScreen>d__.<>1__state = -1;
			<PlayBlackScreen>d__.<>t__builder.Start<DreamLinkDungeonView.<PlayBlackScreen>d__64>(ref <PlayBlackScreen>d__);
			return <PlayBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC7F RID: 240767 RVA: 0x00E01190 File Offset: 0x00DFF390
		[NullableContext(1)]
		protected void PlaySceneLevelSequence(string levelSequencePath, bool isPauseOnEnd = false, bool isRestoreState = false, bool isOffset = true)
		{
			if (this.ShowSequencePlayer != null)
			{
				this.ShowSequencePlayer.Stop();
				this.ShowSequencePlayer = null;
			}
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(levelSequencePath, delegate([Nullable(2)] ULevelSequence levelSequenceObject, string _)
			{
				if (ObjectUtils.IsValid(levelSequenceObject))
				{
					UKuroSceneInteractionActorSystem ukuroSceneInteractionActorSystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroSceneInteractionActorSystem.StaticClass()) as UKuroSceneInteractionActorSystem;
					ALevelSequenceActor alevelSequenceActor = null;
					ULevelSequencePlayer.CreateLevelSequencePlayer(GlobalData.World, levelSequenceObject, new FMovieSceneSequencePlaybackSettings(), ref alevelSequenceActor);
					FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
					fmovieSceneSequencePlaybackSettings.bRestoreState = isRestoreState;
					fmovieSceneSequencePlaybackSettings.bPauseAtEnd = isPauseOnEnd;
					alevelSequenceActor.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
					alevelSequenceActor.SetTickableWhenPaused(true);
					alevelSequenceActor.SetSequence(levelSequenceObject);
					ukuroSceneInteractionActorSystem.SetSequenceWithTargetLevelActor(alevelSequenceActor, levelSequenceObject, this.DoorCameraActor);
					UKuroSequenceRuntimeFunctionLibrary.SetSequenceInUiScene(levelSequenceObject, true);
					ALevelSequenceActor shakeSequenceActor = this.ShakeSequenceActor;
					if (shakeSequenceActor != null)
					{
						ULevelSequencePlayer sequencePlayer = shakeSequenceActor.SequencePlayer;
						if (sequencePlayer != null)
						{
							sequencePlayer.PlayLooping(-1);
						}
					}
					ULevelSequencePlayer sequencePlayer2 = alevelSequenceActor.SequencePlayer;
					if (sequencePlayer2 != null)
					{
						sequencePlayer2.Play();
					}
					if (isOffset)
					{
						alevelSequenceActor.bOverrideInstanceData = true;
						UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = alevelSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
						FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("KuroUiSceneRoot").Value, ECollectActorType.UI).D_GetTransform());
						udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
					}
					this.ShowSequencePlayer = alevelSequenceActor.SequencePlayer;
					this.ShowSequenceActor = alevelSequenceActor;
				}
			}, 100, this.MemoryTag);
		}

		// Token: 0x0603AC80 RID: 240768 RVA: 0x00E011FC File Offset: 0x00DFF3FC
		public void PlaySelectWaveEffect()
		{
			FVector2D? screenPositionByIndex = this.DreamLinkDungeonRolePanel.GetScreenPositionByIndex(this.SelectInstIndex % 3);
			if (screenPositionByIndex == null)
			{
				return;
			}
			APlayerController characterController = Global.CharacterController;
			int num = 0;
			int num2 = 0;
			characterController.GetViewportSize(ref num, ref num2);
			Vector2D vector2D = Vector2D.Create((double)num, (double)num2);
			FVector2D fvector2D = UKismetMathLibrary.Divide_Vector2DVector2D(screenPositionByIndex.Value, vector2D.ToUeVector2D(false));
			UMaterialInstanceDynamic postProcessMaterialDynamicInstance = this.PostProcessMaterialDynamicInstance;
			if (postProcessMaterialDynamicInstance != null)
			{
				postProcessMaterialDynamicInstance.SetScalarParameterValue(FNameUtil.GetDynamicFName("Center1X").Value, fvector2D.X);
			}
			UMaterialInstanceDynamic postProcessMaterialDynamicInstance2 = this.PostProcessMaterialDynamicInstance;
			if (postProcessMaterialDynamicInstance2 != null)
			{
				postProcessMaterialDynamicInstance2.SetScalarParameterValue(FNameUtil.GetDynamicFName("Center1Y").Value, fvector2D.Y);
			}
			UMaterialInstanceDynamic postProcessMaterialDynamicInstance3 = this.PostProcessMaterialDynamicInstance;
			if (postProcessMaterialDynamicInstance3 == null)
			{
				return;
			}
			postProcessMaterialDynamicInstance3.SetScalarParameterValue(FNameUtil.GetDynamicFName("CommonStrength").Value, 0.05f);
		}

		// Token: 0x0603AC81 RID: 240769 RVA: 0x00E012D8 File Offset: 0x00DFF4D8
		public void ClearWaveEffect()
		{
			UMaterialInstanceDynamic postProcessMaterialDynamicInstance = this.PostProcessMaterialDynamicInstance;
			if (postProcessMaterialDynamicInstance != null)
			{
				postProcessMaterialDynamicInstance.SetScalarParameterValue(FNameUtil.GetDynamicFName("CommonStrength").Value, 0f);
			}
			UMaterialInstanceDynamic postProcessMaterialDynamicInstance2 = this.PostProcessMaterialDynamicInstance;
			if (postProcessMaterialDynamicInstance2 == null)
			{
				return;
			}
			postProcessMaterialDynamicInstance2.SetScalarParameterValue(FNameUtil.GetDynamicFName("ClickStrength").Value, 0f);
		}

		// Token: 0x0603AC82 RID: 240770 RVA: 0x00E01334 File Offset: 0x00DFF534
		private void OnBtnMask()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0603AC83 RID: 240771 RVA: 0x00E0134C File Offset: 0x00DFF54C
		private void OnBtnReward(EToggleState _)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			bool flag = extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				this.RefreshReward();
			}
			UUIButtonComponent button = base.GetButton(12);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(flag);
		}

		// Token: 0x0603AC84 RID: 240772 RVA: 0x00E013AD File Offset: 0x00DFF5AD
		private void OnBtnPre()
		{
			this.CurrentPageIndex--;
			this.CurrentPageIndex = Math.Max(0, this.CurrentPageIndex);
			this.SelectInstIndex = this.CurrentPageIndex * 3;
			this.RefreshView();
			this.RefreshEnvironment(false);
		}

		// Token: 0x0603AC85 RID: 240773 RVA: 0x00E013EA File Offset: 0x00DFF5EA
		private void OnBtnNext()
		{
			this.CurrentPageIndex++;
			this.CurrentPageIndex = Math.Min(2, this.CurrentPageIndex);
			this.SelectInstIndex = this.CurrentPageIndex * 3;
			this.RefreshView();
			this.RefreshEnvironment(false);
		}

		// Token: 0x0603AC86 RID: 240774 RVA: 0x00E01428 File Offset: 0x00DFF628
		private void OnBtnEnter()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			if (this.CurrentEnvironmentState.GetValueOrDefault() == DreamLinkDungeonView.EEnvironmentState.Door)
			{
				RogueWhiteCat activityConfig = currentActivityData.GetActivityConfig();
				if (!currentActivityData.IsDreamLinkFunctionUnlock(3))
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, activityConfig.FirstWhiteCatQuestId, null);
					return;
				}
			}
			else
			{
				RogueRoleInstData roleInstDataByIndex = currentActivityData.GetRoleInstDataByIndex(this.SelectInstIndex);
				if (roleInstDataByIndex == null)
				{
					return;
				}
				if (!roleInstDataByIndex.IsUnlock)
				{
					ScrollingTipsController.Instance.ShowTipsById("DreamLinkDungeonUnlockTips", Array.Empty<object>());
					return;
				}
				if (roleInstDataByIndex.IsFinish)
				{
					ScrollingTipsController.Instance.ShowTipsById("DreamLinkDungeonFinishedTips", Array.Empty<object>());
					return;
				}
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequencePurely("FadeOut", true, false);
				}
				DreamLinkController.Instance.RoguelikeRoleInstStartRequest(this.SelectInstIndex);
			}
		}

		// Token: 0x0401EAC1 RID: 125633
		private const int PER_PAGE_COUNT = 3;

		// Token: 0x0401EAC2 RID: 125634
		private const int MAX_PAGE_COUNT = 2;

		// Token: 0x0401EAC3 RID: 125635
		[Nullable(1)]
		private const string DOOR_OPEN_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_Door.Ani_Door";

		// Token: 0x0401EAC4 RID: 125636
		[Nullable(1)]
		private const string DOOR_CLOSE_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_Door_close.Ani_Door_close";

		// Token: 0x0401EAC5 RID: 125637
		[Nullable(1)]
		private const string RED_WEATHER_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_rad.Ani_UIMap_Roguelike_rad";

		// Token: 0x0401EAC6 RID: 125638
		[Nullable(1)]
		private const string BLUE_WEATHER_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike.Ani_UIMap_Roguelike";

		// Token: 0x0401EAC7 RID: 125639
		[Nullable(1)]
		private const string SELECT_WAVE_EFFECT_PATH = "/Game/Aki/Render/Shaders/PostProcess/WaterWave/M_WaterWave.M_WaterWave";

		// Token: 0x0401EAC8 RID: 125640
		[Nullable(1)]
		private const string SHAKE_CAMERA_SEQUENCE = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_loop.Ani_UIMap_Roguelike_loop";

		// Token: 0x0401EAC9 RID: 125641
		[Nullable(1)]
		private const string SWITCH_SEQUENCE = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_l.Ani_UIMap_Roguelike_l";

		// Token: 0x0401EACA RID: 125642
		[Nullable(1)]
		private const string UNLICK_SEQUNECE = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_CamA.Ani_UIMap_Roguelike_CamA";

		// Token: 0x0401EACB RID: 125643
		private const int DREAMLINK_DUNGEON_HELP_ID = 135;

		// Token: 0x0401EACC RID: 125644
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401EACD RID: 125645
		private SkeletalObserverHandle RoleHandle;

		// Token: 0x0401EACE RID: 125646
		private DreamLinkRoleInstancePanel DreamLinkDungeonRolePanel;

		// Token: 0x0401EACF RID: 125647
		private ULevelSequencePlayer ShowSequencePlayer;

		// Token: 0x0401EAD0 RID: 125648
		private ALevelSequenceActor ShowSequenceActor;

		// Token: 0x0401EAD1 RID: 125649
		private ALevelSequenceActor ShakeSequenceActor;

		// Token: 0x0401EAD2 RID: 125650
		private ALevelSequenceActor LockSequenceActor;

		// Token: 0x0401EAD3 RID: 125651
		private ALevelSequenceActor UnlockSequenceActor;

		// Token: 0x0401EAD4 RID: 125652
		private int SelectInstIndex;

		// Token: 0x0401EAD5 RID: 125653
		private int CurrentPageIndex;

		// Token: 0x0401EAD6 RID: 125654
		private AActor OriginCameraActor;

		// Token: 0x0401EAD7 RID: 125655
		private AActor DoorCameraActor;

		// Token: 0x0401EAD8 RID: 125656
		private UMaterialInstanceDynamic PostProcessMaterialDynamicInstance;

		// Token: 0x0401EAD9 RID: 125657
		private int PostProcessHandleId;

		// Token: 0x0401EADA RID: 125658
		private DreamLinkDungeonView.EEnvironmentState? CurrentEnvironmentState;

		// Token: 0x0401EADB RID: 125659
		[Nullable(1)]
		private SkeletalObserverHandle[] ItemModelHandleList = new SkeletalObserverHandle[0];

		// Token: 0x0401EADC RID: 125660
		private AActor SequenceCameraActor;

		// Token: 0x0401EADD RID: 125661
		private DreamLinkScoreRewardItem RewardItem;

		// Token: 0x0401EADE RID: 125662
		private DreamLinkCatProgressItem CatProgressItem;

		// Token: 0x0401EADF RID: 125663
		private LevelSequencePlayer EnterButtonLevelSequencePlayer;

		// Token: 0x0401EAE0 RID: 125664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401EAE1 RID: 125665
		private bool FirstIn = true;

		// Token: 0x0401EAE2 RID: 125666
		private FVectorDouble? EffectStartPosition;

		// Token: 0x0401EAE3 RID: 125667
		private FVectorDouble? EffectEndPosition;

		// Token: 0x0401EAE4 RID: 125668
		private ULTweener MoveTweener;

		// Token: 0x0401EAE5 RID: 125669
		private DreamLinkDungeonView.EDreamLinkEnterButtonState? CurrentEnterButtonState;

		// Token: 0x0401EAE6 RID: 125670
		[Nullable(1)]
		private readonly FFrameTime LoopStartFrame = new FFrameTime();

		// Token: 0x0200BCD6 RID: 48342
		[NullableContext(0)]
		private class EDreamLinkDungeonViewDefine
		{
			// Token: 0x04038F54 RID: 233300
			public const int CaptionItem = 0;

			// Token: 0x04038F55 RID: 233301
			public const int SpriteProgress = 1;

			// Token: 0x04038F56 RID: 233302
			public const int PanelLayout = 2;

			// Token: 0x04038F57 RID: 233303
			public const int PanelRole = 3;

			// Token: 0x04038F58 RID: 233304
			public const int BtnPre = 4;

			// Token: 0x04038F59 RID: 233305
			public const int BtnNext = 5;

			// Token: 0x04038F5A RID: 233306
			public const int BtnEnter = 6;

			// Token: 0x04038F5B RID: 233307
			public const int BtnReward = 7;

			// Token: 0x04038F5C RID: 233308
			public const int CatProgress = 8;

			// Token: 0x04038F5D RID: 233309
			public const int PermanentReward = 9;

			// Token: 0x04038F5E RID: 233310
			public const int RewardLayout = 10;

			// Token: 0x04038F5F RID: 233311
			public const int RewardLayoutItem = 11;

			// Token: 0x04038F60 RID: 233312
			public const int BtnMask = 12;

			// Token: 0x04038F61 RID: 233313
			public const int TrailEffect = 13;

			// Token: 0x04038F62 RID: 233314
			public const int BurstEffect = 14;

			// Token: 0x04038F63 RID: 233315
			public const int TxtDungeonName = 15;

			// Token: 0x04038F64 RID: 233316
			public const int DungeonDonePanel = 16;

			// Token: 0x04038F65 RID: 233317
			public const int CausticPanel = 17;

			// Token: 0x04038F66 RID: 233318
			public const int LeftBtnRedDot = 18;

			// Token: 0x04038F67 RID: 233319
			public const int RightBtnRedDot = 19;
		}

		// Token: 0x0200BCD7 RID: 48343
		[NullableContext(0)]
		private enum EEnvironmentState
		{
			// Token: 0x04038F69 RID: 233321
			DreamLinkDungeon,
			// Token: 0x04038F6A RID: 233322
			Door
		}

		// Token: 0x0200BCD8 RID: 48344
		[NullableContext(0)]
		private enum EDreamLinkEnterButtonState
		{
			// Token: 0x04038F6C RID: 233324
			Blue,
			// Token: 0x04038F6D RID: 233325
			Red
		}
	}
}
