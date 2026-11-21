using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057F8 RID: 22520
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamSmasherSelectView : UiViewBase
	{
		// Token: 0x06037903 RID: 227587 RVA: 0x00F88048 File Offset: 0x00F86248
		public AdamSmasherSelectView(UiViewInfo viewInfo)
		{
			FRotator frotator = new FRotator(0f, 0f, 0f);
			FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
			FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble2;
			this.CacheTransform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			base..ctor(viewInfo);
		}

		// Token: 0x06037904 RID: 227588 RVA: 0x00F880F4 File Offset: 0x00F862F4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIItem))
			};
		}

		// Token: 0x06037905 RID: 227589 RVA: 0x00F8825C File Offset: 0x00F8645C
		protected override UniTask OnBeforeStartAsync()
		{
			AdamSmasherSelectView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdamSmasherSelectView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037906 RID: 227590 RVA: 0x00F882A0 File Offset: 0x00F864A0
		protected override void OnStart()
		{
			ActivityModel instance = ActivityModel.Instance;
			ActivityBaseData activityBaseData = (instance != null) ? instance.GetActivityById(CyberPunkController.Instance.CurrentActivityId) : null;
			if (activityBaseData != null && activityBaseData.CheckIfClose() && AdamSmasherController.Instance.IsInAdamSmasherDungeon())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool Result)
				{
					base.CloseMe(null);
				});
			}
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickClose));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelp));
			this.CaptionItem.SetHomeBtnShowState(true);
			this.ChallengeButtonItem.SetFunction(new Action<int>(this.OnClickChallenge));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "AdamChallenge_Name", Array.Empty<object>());
			this.StageListLayout = new GenericLayout<AdamSmasherStageItem, IAdamSmasherStageItemData>(base.GetVerticalLayout(1), new Func<AdamSmasherStageItem>(this.CreateStageItem), null, false, true);
			this.InitStageList();
			this.RefreshView();
			this.MarkBossEntranceFirstClicked();
		}

		// Token: 0x06037907 RID: 227591 RVA: 0x00F8839D File Offset: 0x00F8659D
		private void MarkBossEntranceFirstClicked()
		{
			if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.CyberPunkBossEntranceFirstClicked, false))
			{
				return;
			}
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.CyberPunkBossEntranceFirstClicked, true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, CyberPunkController.Instance.CurrentActivityId);
		}

		// Token: 0x06037908 RID: 227592 RVA: 0x00F883D3 File Offset: 0x00F865D3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06037909 RID: 227593 RVA: 0x00F883F1 File Offset: 0x00F865F1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603790A RID: 227594 RVA: 0x00F8840F File Offset: 0x00F8660F
		protected override void OnBeforeDestroy()
		{
			this.ClearMaterialControllers();
			this.ClearSceneEffects("[AdamSmasherSelectView.OnBeforeDestroy]");
		}

		// Token: 0x0603790B RID: 227595 RVA: 0x00F88424 File Offset: 0x00F86624
		private void InitStageList()
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			this.CachedStageList = (((instance != null) ? instance.GetStageConfigList(CyberPunkController.Instance.CurrentActivityId) : null) ?? Array.Empty<EdgeRunnerLordGym>());
			if (this.CachedStageList.Count == 0)
			{
				Log.Instance.Warn(ELogModule.Activity, ELogAuthor.SWC, "[AdamSmasherSelectView] 关卡列表为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int num = 0;
			for (int i = this.CachedStageList.Count - 1; i >= 0; i--)
			{
				EdgeRunnerLordGym edgeRunnerLordGym = this.CachedStageList[i];
				if (AdamSmasherController.Instance.IsStageUnlocked(edgeRunnerLordGym.Id))
				{
					num = edgeRunnerLordGym.Id;
					break;
				}
			}
			if (num == 0 && this.CachedStageList.Count > 0)
			{
				num = this.CachedStageList[0].Id;
			}
			this.SelectedStageId = num;
		}

		// Token: 0x0603790C RID: 227596 RVA: 0x00F884FC File Offset: 0x00F866FC
		protected override void OnHandleLoadScene()
		{
			if (!UiSceneManager.Instance.HasAdamSmasherSkeletalHandle())
			{
				UiSceneManager.Instance.InitAdamSmasherSkeletalHandle();
			}
			SkeletalObserverHandle adamSmasherSkeletalHandle = UiSceneManager.Instance.GetAdamSmasherSkeletalHandle();
			if (((adamSmasherSkeletalHandle != null) ? adamSmasherSkeletalHandle.Model : null) != null)
			{
				UiModelUtil.Instance.SetTransformByTag(adamSmasherSkeletalHandle.Model, "MonsterCase");
			}
			this.RefreshStageScenePresentation().Forget();
		}

		// Token: 0x0603790D RID: 227597 RVA: 0x00F88558 File Offset: 0x00F86758
		protected override void OnHandleReleaseScene()
		{
			this.ClearMaterialControllers();
			this.ClearSceneEffects("[AdamSmasherSelectView.OnHandleReleaseScene]");
			UiSceneManager.Instance.DestroyAdamSmasherSkeletalHandle();
		}

		// Token: 0x0603790E RID: 227598 RVA: 0x00F88575 File Offset: 0x00F86775
		private void RefreshView()
		{
			this.RefreshStageList();
			this.RefreshSelectedStage();
			this.RefreshRemainTime();
		}

		// Token: 0x0603790F RID: 227599 RVA: 0x00F8858C File Offset: 0x00F8678C
		private void RefreshStageList()
		{
			List<IAdamSmasherStageItemData> list = new List<IAdamSmasherStageItemData>();
			for (int i = 0; i < this.CachedStageList.Count; i++)
			{
				EdgeRunnerLordGym edgeRunnerLordGym = this.CachedStageList[i];
				list.Add(new AdamSmasherStageItemData
				{
					StageId = edgeRunnerLordGym.Id,
					IndexText = (i + 1).ToString(),
					Name = (edgeRunnerLordGym.Title ?? ""),
					IsUnlocked = AdamSmasherController.Instance.IsStageUnlocked(edgeRunnerLordGym.Id),
					IsHard = (edgeRunnerLordGym.IsHard == 1)
				});
			}
			this.StageListLayout.RefreshByData(list, delegate
			{
				this.RefreshAllStageToggleState();
			}, false);
		}

		// Token: 0x06037910 RID: 227600 RVA: 0x00F88644 File Offset: 0x00F86844
		private void RefreshSelectedStage()
		{
			this.RefreshRightPanel();
		}

		// Token: 0x06037911 RID: 227601 RVA: 0x00F8864C File Offset: 0x00F8684C
		private void RefreshRightPanel()
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			EdgeRunnerLordGym? edgeRunnerLordGym = (instance != null) ? instance.GetStageConfig(this.SelectedStageId) : null;
			if (edgeRunnerLordGym == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "AdamChallenge_Level", new <>z__ReadOnlySingleElementList<object>(edgeRunnerLordGym.Value.Level));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), edgeRunnerLordGym.Value.Title, Array.Empty<object>());
			if (edgeRunnerLordGym.Value.BuffNumLength > 0)
			{
				string[] array = new string[edgeRunnerLordGym.Value.BuffNumLength];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = edgeRunnerLordGym.Value.BuffNum(i);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), edgeRunnerLordGym.Value.BuffDesc, array);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), edgeRunnerLordGym.Value.BuffDesc, Array.Empty<object>());
			}
			string stageRecordText = AdamSmasherController.Instance.GetStageRecordText(this.SelectedStageId);
			if (!string.IsNullOrEmpty(stageRecordText))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "AdamChallenge_BestScore", Array.Empty<object>());
				base.GetText(10).SetText(stageRecordText, true);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "NoPassRecord", Array.Empty<object>());
				base.GetText(10).SetText("", true);
			}
			this.RefreshRewardList();
			this.RefreshChallengeButtonState();
		}

		// Token: 0x06037912 RID: 227602 RVA: 0x00F887F4 File Offset: 0x00F869F4
		private void RefreshRewardList()
		{
			List<TItem> selectedStageRewardPreview = AdamSmasherController.Instance.GetSelectedStageRewardPreview(this.SelectedStageId);
			if (selectedStageRewardPreview != null && selectedStageRewardPreview.Count > 0)
			{
				this.RewardScroll.RefreshByData(selectedStageRewardPreview, null, false);
			}
		}

		// Token: 0x06037913 RID: 227603 RVA: 0x00F8882C File Offset: 0x00F86A2C
		private void RefreshChallengeButtonState()
		{
			bool flag = AdamSmasherController.Instance.IsStageUnlocked(this.SelectedStageId);
			ButtonItem challengeButtonItem = this.ChallengeButtonItem;
			if (challengeButtonItem != null)
			{
				challengeButtonItem.SetEnableClick(flag);
			}
			UUIButtonComponent button = base.GetButton(13);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			AdamSmasherLockBtnPanel lockBtnItem = this.LockBtnItem;
			if (lockBtnItem == null)
			{
				return;
			}
			lockBtnItem.SetUiActive(!flag);
		}

		// Token: 0x06037914 RID: 227604 RVA: 0x00F88894 File Offset: 0x00F86A94
		private void RefreshRemainTime()
		{
			CyberPunkController instance = CyberPunkController.Instance;
			string text = (instance != null) ? instance.GetTimeVisibleAndRemainTimeText() : null;
			if (!string.IsNullOrEmpty(text))
			{
				UUIText text2 = base.GetText(3);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(text, true);
			}
		}

		// Token: 0x06037915 RID: 227605 RVA: 0x00F888D0 File Offset: 0x00F86AD0
		private void RefreshAllStageToggleState()
		{
			GenericLayout<AdamSmasherStageItem, IAdamSmasherStageItemData> stageListLayout = this.StageListLayout;
			List<AdamSmasherStageItem> list = (stageListLayout != null) ? stageListLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (AdamSmasherStageItem adamSmasherStageItem in list)
			{
				adamSmasherStageItem.SetToggleActive(adamSmasherStageItem.GetStageId() == this.SelectedStageId);
			}
		}

		// Token: 0x06037916 RID: 227606 RVA: 0x00F88940 File Offset: 0x00F86B40
		public void ChangeStageId(int stageId)
		{
			this.SelectedStageId = stageId;
			this.RefreshAllStageToggleState();
			this.RefreshSelectedStage();
			this.RefreshStageScenePresentation().Forget();
		}

		// Token: 0x06037917 RID: 227607 RVA: 0x00F88960 File Offset: 0x00F86B60
		private UniTask RefreshStageScenePresentation()
		{
			AdamSmasherSelectView.<RefreshStageScenePresentation>d__31 <RefreshStageScenePresentation>d__;
			<RefreshStageScenePresentation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshStageScenePresentation>d__.<>4__this = this;
			<RefreshStageScenePresentation>d__.<>1__state = -1;
			<RefreshStageScenePresentation>d__.<>t__builder.Start<AdamSmasherSelectView.<RefreshStageScenePresentation>d__31>(ref <RefreshStageScenePresentation>d__);
			return <RefreshStageScenePresentation>d__.<>t__builder.Task;
		}

		// Token: 0x06037918 RID: 227608 RVA: 0x00F889A4 File Offset: 0x00F86BA4
		private EdgeRunnerLordGym? GetSelectedStageConfig()
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetStageConfig(this.SelectedStageId);
		}

		// Token: 0x06037919 RID: 227609 RVA: 0x00F889D0 File Offset: 0x00F86BD0
		private void RefreshSceneEffects(EdgeRunnerLordGym stageConfig)
		{
			string text = stageConfig.LordUISceneEffect ?? "";
			this.ClearSceneEffects("[AdamSmasherSelectView.RefreshSceneEffects]");
			if (StringUtils.IsBlank(text))
			{
				return;
			}
			List<int> sceneEffectHandleList = this.SceneEffectHandleList;
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.CacheTransform);
			sceneEffectHandleList.Add(instance.SpawnEffect(world, ftransformDouble, text, "AdamSmasherSceneEffect", null, EEffectType.UiScene3D, null, null, null, false, false));
		}

		// Token: 0x0603791A RID: 227610 RVA: 0x00F88A38 File Offset: 0x00F86C38
		private UniTask LoadStageModel(EdgeRunnerLordGym stageConfig)
		{
			AdamSmasherSelectView.<LoadStageModel>d__34 <LoadStageModel>d__;
			<LoadStageModel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadStageModel>d__.<>4__this = this;
			<LoadStageModel>d__.stageConfig = stageConfig;
			<LoadStageModel>d__.<>1__state = -1;
			<LoadStageModel>d__.<>t__builder.Start<AdamSmasherSelectView.<LoadStageModel>d__34>(ref <LoadStageModel>d__);
			return <LoadStageModel>d__.<>t__builder.Task;
		}

		// Token: 0x0603791B RID: 227611 RVA: 0x00F88A84 File Offset: 0x00F86C84
		private void ApplyModelTransform(EdgeRunnerLordGym stageConfig, UiModelActorComponent actorComponent)
		{
			float[] locationArray = stageConfig.GetLocationArray();
			float[] rotatorArray = stageConfig.GetRotatorArray();
			float[] zoomArray = stageConfig.GetZoomArray();
			if (locationArray == null || rotatorArray == null || zoomArray == null || locationArray.Length < 3 || rotatorArray.Length < 3 || zoomArray.Length < 3)
			{
				return;
			}
			FRotator frotator = new FRotator(rotatorArray[0], rotatorArray[1], rotatorArray[2]);
			FVector fvector = new FVector(locationArray[0], locationArray[1], locationArray[2]);
			FVector fvector2 = new FVector(zoomArray[0], zoomArray[1], zoomArray[2]);
			FTransform newTransform = new FTransform(ref frotator, ref fvector, ref fvector2);
			FHitResult fhitResult = new FHitResult();
			actorComponent.SetAllMeshComponentRelativeTransform(newTransform, false, ref fhitResult, false);
		}

		// Token: 0x0603791C RID: 227612 RVA: 0x00F88B14 File Offset: 0x00F86D14
		private void ApplyModelMaterialController(string materialControllerPath, UiModelLoadComponent loadComponent)
		{
			this.ClearMaterialControllers();
			if (StringUtils.IsBlank(materialControllerPath))
			{
				return;
			}
			SkeletalObserverHandle adamSmasherSkeletalHandle = UiSceneManager.Instance.GetAdamSmasherSkeletalHandle();
			UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent;
			if (adamSmasherSkeletalHandle == null)
			{
				uiModelRenderingMaterialComponent = null;
			}
			else
			{
				UiModelBase model = adamSmasherSkeletalHandle.Model;
				uiModelRenderingMaterialComponent = ((model != null) ? model.CheckGetComponent<UiModelRenderingMaterialComponent>() : null);
			}
			UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent2 = uiModelRenderingMaterialComponent;
			PD_CharacterControllerData_C pd_CharacterControllerData_C = loadComponent.GetLoadedResource(materialControllerPath) as PD_CharacterControllerData_C;
			if (pd_CharacterControllerData_C == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[AdamSmasherSelectView] 材质控制器加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MaterialController", materialControllerPath);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int? num = (uiModelRenderingMaterialComponent2 != null) ? new int?(uiModelRenderingMaterialComponent2.AddRenderingMaterialByData(pd_CharacterControllerData_C)) : null;
			if (num != null)
			{
				this.MaterialControllerHandleList.Add(num.Value);
			}
		}

		// Token: 0x0603791D RID: 227613 RVA: 0x00F88BC8 File Offset: 0x00F86DC8
		private void ClearSceneEffects(string reason)
		{
			foreach (int num in this.SceneEffectHandleList)
			{
				if (EffectSystem.Instance.IsValid(num))
				{
					EffectSystem.Instance.StopEffectById(num, reason, true, null);
				}
			}
			this.SceneEffectHandleList.Clear();
		}

		// Token: 0x0603791E RID: 227614 RVA: 0x00F88C44 File Offset: 0x00F86E44
		private void ClearMaterialControllers()
		{
			if (this.MaterialControllerHandleList.Count <= 0)
			{
				return;
			}
			SkeletalObserverHandle adamSmasherSkeletalHandle = UiSceneManager.Instance.GetAdamSmasherSkeletalHandle();
			UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent;
			if (adamSmasherSkeletalHandle == null)
			{
				uiModelRenderingMaterialComponent = null;
			}
			else
			{
				UiModelBase model = adamSmasherSkeletalHandle.Model;
				uiModelRenderingMaterialComponent = ((model != null) ? model.CheckGetComponent<UiModelRenderingMaterialComponent>() : null);
			}
			UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent2 = uiModelRenderingMaterialComponent;
			foreach (int materialId in this.MaterialControllerHandleList)
			{
				if (uiModelRenderingMaterialComponent2 != null)
				{
					uiModelRenderingMaterialComponent2.RemoveRenderingMaterial(materialId);
				}
			}
			this.MaterialControllerHandleList.Clear();
		}

		// Token: 0x0603791F RID: 227615 RVA: 0x00F88CD8 File Offset: 0x00F86ED8
		private void OnClickChallenge(int a)
		{
			UiManager.Instance.OpenView(EUiViewName.AdamSmasherFormationView, this.SelectedStageId, null);
		}

		// Token: 0x06037920 RID: 227616 RVA: 0x00F88CF5 File Offset: 0x00F86EF5
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(0);
		}

		// Token: 0x06037921 RID: 227617 RVA: 0x00F88D04 File Offset: 0x00F86F04
		private void OnClickClose()
		{
			if (AdamSmasherController.Instance.IsInAdamSmasherDungeon())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CyberPunkExitDungeonConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool Result)
					{
						base.CloseMe(null);
					});
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06037922 RID: 227618 RVA: 0x00F88D54 File Offset: 0x00F86F54
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(CyberPunkController.Instance.CurrentActivityId))
			{
				if (AdamSmasherController.Instance.IsInAdamSmasherDungeon())
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
					return;
				}
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x06037923 RID: 227619 RVA: 0x00F88D90 File Offset: 0x00F86F90
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "BackToBattleViewBtn"))
			{
				return null;
			}
			UActorComponent componentInChildren = ULGUIBPLibrary.GetComponentInChildren(base.GetRootActor(), TsUiHomeHelper.StaticClass(), false);
			AActor aactor = (componentInChildren != null) ? componentInChildren.GetOwner() : null;
			if (aactor == null)
			{
				return null;
			}
			UUIButtonComponent uuibuttonComponent = ULGUIBPLibrary.GetComponentInChildren(aactor, UUIButtonComponent.StaticClass(), false) as UUIButtonComponent;
			UUIItem uuiitem = (uuibuttonComponent != null) ? uuibuttonComponent.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x06037924 RID: 227620 RVA: 0x00F88E12 File Offset: 0x00F87012
		private AdamSmasherStageItem CreateStageItem()
		{
			return new AdamSmasherStageItem();
		}

		// Token: 0x06037925 RID: 227621 RVA: 0x00F88E19 File Offset: 0x00F87019
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => AdamSmasherController.Instance.IsStageCleared(this.SelectedStageId))
			};
		}

		// Token: 0x0401D4FF RID: 120063
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D500 RID: 120064
		[Nullable(2)]
		private ButtonItem ChallengeButtonItem;

		// Token: 0x0401D501 RID: 120065
		[Nullable(2)]
		private AdamSmasherLockBtnPanel LockBtnItem;

		// Token: 0x0401D502 RID: 120066
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AdamSmasherStageItem, IAdamSmasherStageItemData> StageListLayout;

		// Token: 0x0401D503 RID: 120067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401D504 RID: 120068
		private IReadOnlyList<EdgeRunnerLordGym> CachedStageList = Array.Empty<EdgeRunnerLordGym>();

		// Token: 0x0401D505 RID: 120069
		private int SelectedStageId = 1;

		// Token: 0x0401D506 RID: 120070
		private readonly List<int> SceneEffectHandleList = new List<int>();

		// Token: 0x0401D507 RID: 120071
		private readonly List<int> MaterialControllerHandleList = new List<int>();

		// Token: 0x0401D508 RID: 120072
		private readonly FTransformDouble CacheTransform;

		// Token: 0x0200B43F RID: 46143
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037C05 RID: 228357
			Caption,
			// Token: 0x04037C06 RID: 228358
			StageList,
			// Token: 0x04037C07 RID: 228359
			SpStageItem,
			// Token: 0x04037C08 RID: 228360
			RemainTimeText,
			// Token: 0x04037C09 RID: 228361
			BossNameText,
			// Token: 0x04037C0A RID: 228362
			BossLevelText,
			// Token: 0x04037C0B RID: 228363
			BuffTitleText,
			// Token: 0x04037C0C RID: 228364
			BuffDescScroll,
			// Token: 0x04037C0D RID: 228365
			BuffDescText,
			// Token: 0x04037C0E RID: 228366
			RecordTitleText,
			// Token: 0x04037C0F RID: 228367
			RecordValueText,
			// Token: 0x04037C10 RID: 228368
			RewardScroll,
			// Token: 0x04037C11 RID: 228369
			RewardItem,
			// Token: 0x04037C12 RID: 228370
			ChallengeButton,
			// Token: 0x04037C13 RID: 228371
			LockButton
		}
	}
}
