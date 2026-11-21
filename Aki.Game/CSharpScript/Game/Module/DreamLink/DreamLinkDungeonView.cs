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
	// Token: 0x02004A82 RID: 19074
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkDungeonView : UiTickViewBase
	{
		// Token: 0x0602FBB3 RID: 195507 RVA: 0x00D50471 File Offset: 0x00D4E671
		[NullableContext(1)]
		public DreamLinkDungeonView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602FBB4 RID: 195508 RVA: 0x00D50498 File Offset: 0x00D4E698
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

		// Token: 0x0602FBB5 RID: 195509 RVA: 0x00D50829 File Offset: 0x00D4EA29
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSelectRoleDreamDungeon, new Action<int>(this.OnSelectRoleDungeon));
		}

		// Token: 0x0602FBB6 RID: 195510 RVA: 0x00D50847 File Offset: 0x00D4EA47
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSelectRoleDreamDungeon, new Action<int>(this.OnSelectRoleDungeon));
		}

		// Token: 0x0602FBB7 RID: 195511 RVA: 0x00D50868 File Offset: 0x00D4EA68
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkDungeonView.<OnBeforeStartAsync>d__45 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkDungeonView.<OnBeforeStartAsync>d__45>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBB8 RID: 195512 RVA: 0x00D508AC File Offset: 0x00D4EAAC
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DreamLinkDungeonView.<OnBeforeShowAsyncImplementImplement>d__46 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DreamLinkDungeonView.<OnBeforeShowAsyncImplementImplement>d__46>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBB9 RID: 195513 RVA: 0x00D508F0 File Offset: 0x00D4EAF0
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

		// Token: 0x0602FBBA RID: 195514 RVA: 0x00D50AC1 File Offset: 0x00D4ECC1
		protected override void OnAfterShow()
		{
			this.InitProgressAnim();
		}

		// Token: 0x0602FBBB RID: 195515 RVA: 0x00D50ACC File Offset: 0x00D4ECCC
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

		// Token: 0x0602FBBC RID: 195516 RVA: 0x00D50C14 File Offset: 0x00D4EE14
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

		// Token: 0x0602FBBD RID: 195517 RVA: 0x00D50D1C File Offset: 0x00D4EF1C
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

		// Token: 0x0602FBBE RID: 195518 RVA: 0x00D50DD2 File Offset: 0x00D4EFD2
		protected void RefreshView()
		{
			this.RefreshPreNextButton();
			this.RefreshDoorState();
			this.RefreshEnterButton();
			this.RefreshReward();
		}

		// Token: 0x0602FBBF RID: 195519 RVA: 0x00D50DEC File Offset: 0x00D4EFEC
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

		// Token: 0x0602FBC0 RID: 195520 RVA: 0x00D50E94 File Offset: 0x00D4F094
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

		// Token: 0x0602FBC1 RID: 195521 RVA: 0x00D51060 File Offset: 0x00D4F260
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

		// Token: 0x0602FBC2 RID: 195522 RVA: 0x00D51100 File Offset: 0x00D4F300
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

		// Token: 0x0602FBC3 RID: 195523 RVA: 0x00D511C0 File Offset: 0x00D4F3C0
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

		// Token: 0x0602FBC4 RID: 195524 RVA: 0x00D51260 File Offset: 0x00D4F460
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

		// Token: 0x0602FBC5 RID: 195525 RVA: 0x00D512BC File Offset: 0x00D4F4BC
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

		// Token: 0x0602FBC6 RID: 195526 RVA: 0x00D51354 File Offset: 0x00D4F554
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

		// Token: 0x0602FBC7 RID: 195527 RVA: 0x00D5147C File Offset: 0x00D4F67C
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

		// Token: 0x0602FBC8 RID: 195528 RVA: 0x00D515AC File Offset: 0x00D4F7AC
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

		// Token: 0x0602FBC9 RID: 195529 RVA: 0x00D516B4 File Offset: 0x00D4F8B4
		protected UniTask PlayDoorSequence()
		{
			DreamLinkDungeonView.<PlayDoorSequence>d__63 <PlayDoorSequence>d__;
			<PlayDoorSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDoorSequence>d__.<>4__this = this;
			<PlayDoorSequence>d__.<>1__state = -1;
			<PlayDoorSequence>d__.<>t__builder.Start<DreamLinkDungeonView.<PlayDoorSequence>d__63>(ref <PlayDoorSequence>d__);
			return <PlayDoorSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBCA RID: 195530 RVA: 0x00D516F8 File Offset: 0x00D4F8F8
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

		// Token: 0x0602FBCB RID: 195531 RVA: 0x00D51744 File Offset: 0x00D4F944
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

		// Token: 0x0602FBCC RID: 195532 RVA: 0x00D517B0 File Offset: 0x00D4F9B0
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

		// Token: 0x0602FBCD RID: 195533 RVA: 0x00D5188C File Offset: 0x00D4FA8C
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

		// Token: 0x0602FBCE RID: 195534 RVA: 0x00D518E8 File Offset: 0x00D4FAE8
		private void OnBtnMask()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0602FBCF RID: 195535 RVA: 0x00D51900 File Offset: 0x00D4FB00
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

		// Token: 0x0602FBD0 RID: 195536 RVA: 0x00D51961 File Offset: 0x00D4FB61
		private void OnBtnPre()
		{
			this.CurrentPageIndex--;
			this.CurrentPageIndex = Math.Max(0, this.CurrentPageIndex);
			this.SelectInstIndex = this.CurrentPageIndex * 3;
			this.RefreshView();
			this.RefreshEnvironment(false);
		}

		// Token: 0x0602FBD1 RID: 195537 RVA: 0x00D5199E File Offset: 0x00D4FB9E
		private void OnBtnNext()
		{
			this.CurrentPageIndex++;
			this.CurrentPageIndex = Math.Min(2, this.CurrentPageIndex);
			this.SelectInstIndex = this.CurrentPageIndex * 3;
			this.RefreshView();
			this.RefreshEnvironment(false);
		}

		// Token: 0x0602FBD2 RID: 195538 RVA: 0x00D519DC File Offset: 0x00D4FBDC
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

		// Token: 0x04019568 RID: 103784
		private const int PER_PAGE_COUNT = 3;

		// Token: 0x04019569 RID: 103785
		private const int MAX_PAGE_COUNT = 2;

		// Token: 0x0401956A RID: 103786
		[Nullable(1)]
		private const string DOOR_OPEN_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_Door.Ani_Door";

		// Token: 0x0401956B RID: 103787
		[Nullable(1)]
		private const string DOOR_CLOSE_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_Door_close.Ani_Door_close";

		// Token: 0x0401956C RID: 103788
		[Nullable(1)]
		private const string RED_WEATHER_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_rad.Ani_UIMap_Roguelike_rad";

		// Token: 0x0401956D RID: 103789
		[Nullable(1)]
		private const string BLUE_WEATHER_SEQUENCE_PATH = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike.Ani_UIMap_Roguelike";

		// Token: 0x0401956E RID: 103790
		[Nullable(1)]
		private const string SELECT_WAVE_EFFECT_PATH = "/Game/Aki/Render/Shaders/PostProcess/WaterWave/M_WaterWave.M_WaterWave";

		// Token: 0x0401956F RID: 103791
		[Nullable(1)]
		private const string SHAKE_CAMERA_SEQUENCE = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_loop.Ani_UIMap_Roguelike_loop";

		// Token: 0x04019570 RID: 103792
		[Nullable(1)]
		private const string SWITCH_SEQUENCE = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_l.Ani_UIMap_Roguelike_l";

		// Token: 0x04019571 RID: 103793
		[Nullable(1)]
		private const string UNLICK_SEQUNECE = "/Game/Aki/Map/UISceneLevel/UI_Scene/LevelSequence/Ani_UIMap_Roguelike_CamA.Ani_UIMap_Roguelike_CamA";

		// Token: 0x04019572 RID: 103794
		private const int DREAMLINK_DUNGEON_HELP_ID = 135;

		// Token: 0x04019573 RID: 103795
		private PopupCaptionItem CaptionItem;

		// Token: 0x04019574 RID: 103796
		private SkeletalObserverHandle RoleHandle;

		// Token: 0x04019575 RID: 103797
		private DreamLinkRoleInstancePanel DreamLinkDungeonRolePanel;

		// Token: 0x04019576 RID: 103798
		private ULevelSequencePlayer ShowSequencePlayer;

		// Token: 0x04019577 RID: 103799
		private ALevelSequenceActor ShowSequenceActor;

		// Token: 0x04019578 RID: 103800
		private ALevelSequenceActor ShakeSequenceActor;

		// Token: 0x04019579 RID: 103801
		private ALevelSequenceActor LockSequenceActor;

		// Token: 0x0401957A RID: 103802
		private ALevelSequenceActor UnlockSequenceActor;

		// Token: 0x0401957B RID: 103803
		private int SelectInstIndex;

		// Token: 0x0401957C RID: 103804
		private int CurrentPageIndex;

		// Token: 0x0401957D RID: 103805
		private AActor OriginCameraActor;

		// Token: 0x0401957E RID: 103806
		private AActor DoorCameraActor;

		// Token: 0x0401957F RID: 103807
		private UMaterialInstanceDynamic PostProcessMaterialDynamicInstance;

		// Token: 0x04019580 RID: 103808
		private int PostProcessHandleId;

		// Token: 0x04019581 RID: 103809
		private DreamLinkDungeonView.EEnvironmentState? CurrentEnvironmentState;

		// Token: 0x04019582 RID: 103810
		[Nullable(1)]
		private SkeletalObserverHandle[] ItemModelHandleList = new SkeletalObserverHandle[0];

		// Token: 0x04019583 RID: 103811
		private AActor SequenceCameraActor;

		// Token: 0x04019584 RID: 103812
		private DreamLinkScoreRewardItem RewardItem;

		// Token: 0x04019585 RID: 103813
		private DreamLinkCatProgressItem CatProgressItem;

		// Token: 0x04019586 RID: 103814
		private LevelSequencePlayer EnterButtonLevelSequencePlayer;

		// Token: 0x04019587 RID: 103815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04019588 RID: 103816
		private bool FirstIn = true;

		// Token: 0x04019589 RID: 103817
		private FVectorDouble? EffectStartPosition;

		// Token: 0x0401958A RID: 103818
		private FVectorDouble? EffectEndPosition;

		// Token: 0x0401958B RID: 103819
		private ULTweener MoveTweener;

		// Token: 0x0401958C RID: 103820
		private DreamLinkDungeonView.EDreamLinkEnterButtonState? CurrentEnterButtonState;

		// Token: 0x0401958D RID: 103821
		[Nullable(1)]
		private readonly FFrameTime LoopStartFrame = new FFrameTime();

		// Token: 0x0200A6DF RID: 42719
		[NullableContext(0)]
		private class EDreamLinkDungeonViewDefine
		{
			// Token: 0x0403391F RID: 211231
			public const int CaptionItem = 0;

			// Token: 0x04033920 RID: 211232
			public const int SpriteProgress = 1;

			// Token: 0x04033921 RID: 211233
			public const int PanelLayout = 2;

			// Token: 0x04033922 RID: 211234
			public const int PanelRole = 3;

			// Token: 0x04033923 RID: 211235
			public const int BtnPre = 4;

			// Token: 0x04033924 RID: 211236
			public const int BtnNext = 5;

			// Token: 0x04033925 RID: 211237
			public const int BtnEnter = 6;

			// Token: 0x04033926 RID: 211238
			public const int BtnReward = 7;

			// Token: 0x04033927 RID: 211239
			public const int CatProgress = 8;

			// Token: 0x04033928 RID: 211240
			public const int PermanentReward = 9;

			// Token: 0x04033929 RID: 211241
			public const int RewardLayout = 10;

			// Token: 0x0403392A RID: 211242
			public const int RewardLayoutItem = 11;

			// Token: 0x0403392B RID: 211243
			public const int BtnMask = 12;

			// Token: 0x0403392C RID: 211244
			public const int TrailEffect = 13;

			// Token: 0x0403392D RID: 211245
			public const int BurstEffect = 14;

			// Token: 0x0403392E RID: 211246
			public const int TxtDungeonName = 15;

			// Token: 0x0403392F RID: 211247
			public const int DungeonDonePanel = 16;

			// Token: 0x04033930 RID: 211248
			public const int CausticPanel = 17;

			// Token: 0x04033931 RID: 211249
			public const int LeftBtnRedDot = 18;

			// Token: 0x04033932 RID: 211250
			public const int RightBtnRedDot = 19;
		}

		// Token: 0x0200A6E0 RID: 42720
		[NullableContext(0)]
		private enum EEnvironmentState
		{
			// Token: 0x04033934 RID: 211252
			DreamLinkDungeon,
			// Token: 0x04033935 RID: 211253
			Door
		}

		// Token: 0x0200A6E1 RID: 42721
		[NullableContext(0)]
		private enum EDreamLinkEnterButtonState
		{
			// Token: 0x04033937 RID: 211255
			Blue,
			// Token: 0x04033938 RID: 211256
			Red
		}
	}
}
