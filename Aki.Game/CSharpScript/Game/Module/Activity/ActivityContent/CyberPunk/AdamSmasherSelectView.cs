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
	// Token: 0x020068A8 RID: 26792
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamSmasherSelectView : UiViewBase
	{
		// Token: 0x06042DAB RID: 273835 RVA: 0x01046A38 File Offset: 0x01044C38
		public AdamSmasherSelectView(UiViewInfo viewInfo)
		{
			FRotator frotator = new FRotator(0f, 0f, 0f);
			FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
			FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble2;
			this.CacheTransform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			base..ctor(viewInfo);
		}

		// Token: 0x06042DAC RID: 273836 RVA: 0x01046AE4 File Offset: 0x01044CE4
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

		// Token: 0x06042DAD RID: 273837 RVA: 0x01046C4C File Offset: 0x01044E4C
		protected override UniTask OnBeforeStartAsync()
		{
			AdamSmasherSelectView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdamSmasherSelectView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042DAE RID: 273838 RVA: 0x01046C90 File Offset: 0x01044E90
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

		// Token: 0x06042DAF RID: 273839 RVA: 0x01046D8D File Offset: 0x01044F8D
		private void MarkBossEntranceFirstClicked()
		{
			if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.CyberPunkBossEntranceFirstClicked, false))
			{
				return;
			}
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.CyberPunkBossEntranceFirstClicked, true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, CyberPunkController.Instance.CurrentActivityId);
		}

		// Token: 0x06042DB0 RID: 273840 RVA: 0x01046DC3 File Offset: 0x01044FC3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06042DB1 RID: 273841 RVA: 0x01046DE1 File Offset: 0x01044FE1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06042DB2 RID: 273842 RVA: 0x01046DFF File Offset: 0x01044FFF
		protected override void OnBeforeDestroy()
		{
			this.ClearMaterialControllers();
			this.ClearSceneEffects("[AdamSmasherSelectView.OnBeforeDestroy]");
		}

		// Token: 0x06042DB3 RID: 273843 RVA: 0x01046E14 File Offset: 0x01045014
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

		// Token: 0x06042DB4 RID: 273844 RVA: 0x01046EEC File Offset: 0x010450EC
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

		// Token: 0x06042DB5 RID: 273845 RVA: 0x01046F48 File Offset: 0x01045148
		protected override void OnHandleReleaseScene()
		{
			this.ClearMaterialControllers();
			this.ClearSceneEffects("[AdamSmasherSelectView.OnHandleReleaseScene]");
			UiSceneManager.Instance.DestroyAdamSmasherSkeletalHandle();
		}

		// Token: 0x06042DB6 RID: 273846 RVA: 0x01046F65 File Offset: 0x01045165
		private void RefreshView()
		{
			this.RefreshStageList();
			this.RefreshSelectedStage();
			this.RefreshRemainTime();
		}

		// Token: 0x06042DB7 RID: 273847 RVA: 0x01046F7C File Offset: 0x0104517C
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

		// Token: 0x06042DB8 RID: 273848 RVA: 0x01047034 File Offset: 0x01045234
		private void RefreshSelectedStage()
		{
			this.RefreshRightPanel();
		}

		// Token: 0x06042DB9 RID: 273849 RVA: 0x0104703C File Offset: 0x0104523C
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

		// Token: 0x06042DBA RID: 273850 RVA: 0x010471E4 File Offset: 0x010453E4
		private void RefreshRewardList()
		{
			List<TItem> selectedStageRewardPreview = AdamSmasherController.Instance.GetSelectedStageRewardPreview(this.SelectedStageId);
			if (selectedStageRewardPreview != null && selectedStageRewardPreview.Count > 0)
			{
				this.RewardScroll.RefreshByData(selectedStageRewardPreview, null, false);
			}
		}

		// Token: 0x06042DBB RID: 273851 RVA: 0x0104721C File Offset: 0x0104541C
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

		// Token: 0x06042DBC RID: 273852 RVA: 0x01047284 File Offset: 0x01045484
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

		// Token: 0x06042DBD RID: 273853 RVA: 0x010472C0 File Offset: 0x010454C0
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

		// Token: 0x06042DBE RID: 273854 RVA: 0x01047330 File Offset: 0x01045530
		public void ChangeStageId(int stageId)
		{
			this.SelectedStageId = stageId;
			this.RefreshAllStageToggleState();
			this.RefreshSelectedStage();
			this.RefreshStageScenePresentation().Forget();
		}

		// Token: 0x06042DBF RID: 273855 RVA: 0x01047350 File Offset: 0x01045550
		private UniTask RefreshStageScenePresentation()
		{
			AdamSmasherSelectView.<RefreshStageScenePresentation>d__31 <RefreshStageScenePresentation>d__;
			<RefreshStageScenePresentation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshStageScenePresentation>d__.<>4__this = this;
			<RefreshStageScenePresentation>d__.<>1__state = -1;
			<RefreshStageScenePresentation>d__.<>t__builder.Start<AdamSmasherSelectView.<RefreshStageScenePresentation>d__31>(ref <RefreshStageScenePresentation>d__);
			return <RefreshStageScenePresentation>d__.<>t__builder.Task;
		}

		// Token: 0x06042DC0 RID: 273856 RVA: 0x01047394 File Offset: 0x01045594
		private EdgeRunnerLordGym? GetSelectedStageConfig()
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetStageConfig(this.SelectedStageId);
		}

		// Token: 0x06042DC1 RID: 273857 RVA: 0x010473C0 File Offset: 0x010455C0
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

		// Token: 0x06042DC2 RID: 273858 RVA: 0x01047428 File Offset: 0x01045628
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

		// Token: 0x06042DC3 RID: 273859 RVA: 0x01047474 File Offset: 0x01045674
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

		// Token: 0x06042DC4 RID: 273860 RVA: 0x01047504 File Offset: 0x01045704
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

		// Token: 0x06042DC5 RID: 273861 RVA: 0x010475B8 File Offset: 0x010457B8
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

		// Token: 0x06042DC6 RID: 273862 RVA: 0x01047634 File Offset: 0x01045834
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

		// Token: 0x06042DC7 RID: 273863 RVA: 0x010476C8 File Offset: 0x010458C8
		private void OnClickChallenge(int a)
		{
			UiManager.Instance.OpenView(EUiViewName.AdamSmasherFormationView, this.SelectedStageId, null);
		}

		// Token: 0x06042DC8 RID: 273864 RVA: 0x010476E5 File Offset: 0x010458E5
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(0);
		}

		// Token: 0x06042DC9 RID: 273865 RVA: 0x010476F4 File Offset: 0x010458F4
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

		// Token: 0x06042DCA RID: 273866 RVA: 0x01047744 File Offset: 0x01045944
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

		// Token: 0x06042DCB RID: 273867 RVA: 0x01047780 File Offset: 0x01045980
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

		// Token: 0x06042DCC RID: 273868 RVA: 0x01047802 File Offset: 0x01045A02
		private AdamSmasherStageItem CreateStageItem()
		{
			return new AdamSmasherStageItem();
		}

		// Token: 0x06042DCD RID: 273869 RVA: 0x01047809 File Offset: 0x01045A09
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => AdamSmasherController.Instance.IsStageCleared(this.SelectedStageId))
			};
		}

		// Token: 0x04022CA3 RID: 142499
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022CA4 RID: 142500
		[Nullable(2)]
		private ButtonItem ChallengeButtonItem;

		// Token: 0x04022CA5 RID: 142501
		[Nullable(2)]
		private AdamSmasherLockBtnPanel LockBtnItem;

		// Token: 0x04022CA6 RID: 142502
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AdamSmasherStageItem, IAdamSmasherStageItemData> StageListLayout;

		// Token: 0x04022CA7 RID: 142503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x04022CA8 RID: 142504
		private IReadOnlyList<EdgeRunnerLordGym> CachedStageList = Array.Empty<EdgeRunnerLordGym>();

		// Token: 0x04022CA9 RID: 142505
		private int SelectedStageId = 1;

		// Token: 0x04022CAA RID: 142506
		private readonly List<int> SceneEffectHandleList = new List<int>();

		// Token: 0x04022CAB RID: 142507
		private readonly List<int> MaterialControllerHandleList = new List<int>();

		// Token: 0x04022CAC RID: 142508
		private readonly FTransformDouble CacheTransform;

		// Token: 0x0200CA77 RID: 51831
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D32A RID: 250666
			Caption,
			// Token: 0x0403D32B RID: 250667
			StageList,
			// Token: 0x0403D32C RID: 250668
			SpStageItem,
			// Token: 0x0403D32D RID: 250669
			RemainTimeText,
			// Token: 0x0403D32E RID: 250670
			BossNameText,
			// Token: 0x0403D32F RID: 250671
			BossLevelText,
			// Token: 0x0403D330 RID: 250672
			BuffTitleText,
			// Token: 0x0403D331 RID: 250673
			BuffDescScroll,
			// Token: 0x0403D332 RID: 250674
			BuffDescText,
			// Token: 0x0403D333 RID: 250675
			RecordTitleText,
			// Token: 0x0403D334 RID: 250676
			RecordValueText,
			// Token: 0x0403D335 RID: 250677
			RewardScroll,
			// Token: 0x0403D336 RID: 250678
			RewardItem,
			// Token: 0x0403D337 RID: 250679
			ChallengeButton,
			// Token: 0x0403D338 RID: 250680
			LockButton
		}
	}
}
