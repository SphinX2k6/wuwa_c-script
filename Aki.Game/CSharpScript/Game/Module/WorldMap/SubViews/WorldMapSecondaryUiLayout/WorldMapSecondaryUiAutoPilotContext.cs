using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.WorldMap.SubViews.AutoPilot;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout
{
	// Token: 0x020047C5 RID: 18373
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapSecondaryUiAutoPilotContext
	{
		// Token: 0x17007892 RID: 30866
		// (get) Token: 0x06030213 RID: 197139 RVA: 0x00B279A6 File Offset: 0x00B25BA6
		// (set) Token: 0x06030214 RID: 197140 RVA: 0x00B279AE File Offset: 0x00B25BAE
		public WorldMapSecondaryUiContext LayoutContext { get; private set; }

		// Token: 0x17007893 RID: 30867
		// (get) Token: 0x06030215 RID: 197141 RVA: 0x00B279B7 File Offset: 0x00B25BB7
		// (set) Token: 0x06030216 RID: 197142 RVA: 0x00B279BF File Offset: 0x00B25BBF
		[Nullable(2)]
		public Action<MarkItem> RefreshPanelCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06030217 RID: 197143 RVA: 0x00B279C8 File Offset: 0x00B25BC8
		public WorldMapSecondaryUiAutoPilotContext(WorldMapSecondaryUiContext layoutContext)
		{
			this.LayoutContext = layoutContext;
		}

		// Token: 0x06030218 RID: 197144 RVA: 0x00B279D7 File Offset: 0x00B25BD7
		public void SetUiParent(UUIItem uiParent)
		{
			this.UiParent = uiParent;
		}

		// Token: 0x06030219 RID: 197145 RVA: 0x00B279E0 File Offset: 0x00B25BE0
		public void SetDownStateBtnRoot(UUIItem downStateBtnRoot)
		{
			this.DownStateBtnRoot = downStateBtnRoot;
		}

		// Token: 0x0603021A RID: 197146 RVA: 0x00B279E9 File Offset: 0x00B25BE9
		public void SetDownStateBtnRootActive(bool isActive)
		{
			UUIItem downStateBtnRoot = this.DownStateBtnRoot;
			if (downStateBtnRoot == null)
			{
				return;
			}
			downStateBtnRoot.SetUIActive(isActive);
		}

		// Token: 0x0603021B RID: 197147 RVA: 0x00B279FC File Offset: 0x00B25BFC
		public void SetAutoPilotNavBtnActive(bool isActive)
		{
			AutoPilotNavBtnView autoPilotNavBtnView = this.AutoPilotNavBtnView;
			if (autoPilotNavBtnView == null)
			{
				return;
			}
			UUIItem originalItem = autoPilotNavBtnView.GetOriginalItem();
			if (originalItem == null)
			{
				return;
			}
			originalItem.SetUIActive(isActive);
		}

		// Token: 0x0603021C RID: 197148 RVA: 0x00B27A19 File Offset: 0x00B25C19
		public void UpdateAutoPilotNavBtn(bool isAutoPilotTracked, bool isInteractive)
		{
			AutoPilotNavBtnView autoPilotNavBtnView = this.AutoPilotNavBtnView;
			if (autoPilotNavBtnView == null)
			{
				return;
			}
			autoPilotNavBtnView.RefreshUi(isAutoPilotTracked, isInteractive);
		}

		// Token: 0x0603021D RID: 197149 RVA: 0x00B27A30 File Offset: 0x00B25C30
		public void RefreshAutoPilotTrackBtnGroup(bool isAutoPilotTrack)
		{
			AutoPilotTrackBtnGroup autoPilotTrackBtnGroup = this.AutoPilotTrackBtnGroup;
			if (autoPilotTrackBtnGroup != null)
			{
				UUIItem originalItem = autoPilotTrackBtnGroup.GetOriginalItem();
				if (originalItem != null)
				{
					originalItem.SetUIActive(isAutoPilotTrack);
				}
			}
			if (isAutoPilotTrack)
			{
				AutoPilotFindPathResult findPathResult = AutoPilotModel.Instance.GetFindPathResult();
				this.SetBtnGoQuickEnable(TeleportModel.Instance.AllowTeleportByUi && (findPathResult == null || !findPathResult.GetIsShowPlayerToTargetLine()));
			}
		}

		// Token: 0x0603021E RID: 197150 RVA: 0x00B27A8C File Offset: 0x00B25C8C
		public void SetBtnGoQuickEnable(bool isEnable)
		{
			AutoPilotTrackBtnGroup autoPilotTrackBtnGroup = this.AutoPilotTrackBtnGroup;
			if (autoPilotTrackBtnGroup == null)
			{
				return;
			}
			autoPilotTrackBtnGroup.SetBtnGoQuickEnable(isEnable);
		}

		// Token: 0x0603021F RID: 197151 RVA: 0x00B27A9F File Offset: 0x00B25C9F
		public void SetCloseSecondaryUiFunction(Action func)
		{
			this.CloseSecondaryUiFunction = func;
		}

		// Token: 0x06030220 RID: 197152 RVA: 0x00B27AA8 File Offset: 0x00B25CA8
		[NullableContext(2)]
		public void SetMap(BaseMap map)
		{
			this.Map = map;
		}

		// Token: 0x06030221 RID: 197153 RVA: 0x00B27AB4 File Offset: 0x00B25CB4
		public UniTask InitAutoPilotUi()
		{
			WorldMapSecondaryUiAutoPilotContext.<InitAutoPilotUi>d__24 <InitAutoPilotUi>d__;
			<InitAutoPilotUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAutoPilotUi>d__.<>4__this = this;
			<InitAutoPilotUi>d__.<>1__state = -1;
			<InitAutoPilotUi>d__.<>t__builder.Start<WorldMapSecondaryUiAutoPilotContext.<InitAutoPilotUi>d__24>(ref <InitAutoPilotUi>d__);
			return <InitAutoPilotUi>d__.<>t__builder.Task;
		}

		// Token: 0x06030222 RID: 197154 RVA: 0x00B27AF7 File Offset: 0x00B25CF7
		private void OnAutoPilotNavBtnClick()
		{
			this.OnHandleTrackAutoPilot(true).Forget();
		}

		// Token: 0x06030223 RID: 197155 RVA: 0x00B27B05 File Offset: 0x00B25D05
		private void OnCancelAutoPilotTrackBtnClick()
		{
			this.OnHandleTrackAutoPilot(false).Forget();
		}

		// Token: 0x06030224 RID: 197156 RVA: 0x00B27B13 File Offset: 0x00B25D13
		private void OnQuickGoBtnClick()
		{
			if (AutoPilotModel.Instance.HideQuickTransferConfirmBox)
			{
				this.HandleQuickGotoAutoPilot();
				return;
			}
			this.ShowAutoPilotQuickGoToTeleportConfirmBox(new Action(this.HandleQuickGotoAutoPilot));
		}

		// Token: 0x06030225 RID: 197157 RVA: 0x00B27B3C File Offset: 0x00B25D3C
		protected UniTask OnHandleTrackAutoPilot(bool isAutoPilotTrack)
		{
			WorldMapSecondaryUiAutoPilotContext.<OnHandleTrackAutoPilot>d__28 <OnHandleTrackAutoPilot>d__;
			<OnHandleTrackAutoPilot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHandleTrackAutoPilot>d__.<>4__this = this;
			<OnHandleTrackAutoPilot>d__.isAutoPilotTrack = isAutoPilotTrack;
			<OnHandleTrackAutoPilot>d__.<>1__state = -1;
			<OnHandleTrackAutoPilot>d__.<>t__builder.Start<WorldMapSecondaryUiAutoPilotContext.<OnHandleTrackAutoPilot>d__28>(ref <OnHandleTrackAutoPilot>d__);
			return <OnHandleTrackAutoPilot>d__.<>t__builder.Task;
		}

		// Token: 0x06030226 RID: 197158 RVA: 0x00B27B88 File Offset: 0x00B25D88
		private UniTask HandleTrackAndUiPerform(MarkItem markItem, bool isAutoPilotTrack)
		{
			WorldMapSecondaryUiAutoPilotContext.<HandleTrackAndUiPerform>d__29 <HandleTrackAndUiPerform>d__;
			<HandleTrackAndUiPerform>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleTrackAndUiPerform>d__.<>4__this = this;
			<HandleTrackAndUiPerform>d__.markItem = markItem;
			<HandleTrackAndUiPerform>d__.isAutoPilotTrack = isAutoPilotTrack;
			<HandleTrackAndUiPerform>d__.<>1__state = -1;
			<HandleTrackAndUiPerform>d__.<>t__builder.Start<WorldMapSecondaryUiAutoPilotContext.<HandleTrackAndUiPerform>d__29>(ref <HandleTrackAndUiPerform>d__);
			return <HandleTrackAndUiPerform>d__.<>t__builder.Task;
		}

		// Token: 0x06030227 RID: 197159 RVA: 0x00B27BDC File Offset: 0x00B25DDC
		private void OnCreateMarkItem(DynamicMarkCreateInfo info)
		{
			if (info.MarkType != EMarkType.Custom)
			{
				return;
			}
			BaseMap map = this.Map;
			MarkItem markItem = (map != null) ? map.GetMarkItem(EMarkType.Custom, info.MarkId.Value) : null;
			if (markItem == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AutoPilot;
				ELogAuthor author = ELogAuthor.CB;
				string message = "获取不到创建的自定义标记";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", info.MarkId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			CustomMarkItem customMarkItem = markItem as CustomMarkItem;
			customMarkItem.IsCreated = true;
			this.HandleTrackAndUiPerform(customMarkItem, true).Forget();
		}

		// Token: 0x06030228 RID: 197160 RVA: 0x00B27C6C File Offset: 0x00B25E6C
		protected void HandleQuickGotoAutoPilot()
		{
			AutoPilotFindPathResult findPathResult = AutoPilotModel.Instance.GetFindPathResult();
			if (findPathResult == null)
			{
				Log.Instance.Error(ELogModule.AutoPilot, ELogAuthor.CB, "快速前往寻路起点失败，寻路结果为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			bool flag;
			if (worldEntity == null)
			{
				flag = false;
			}
			else
			{
				CharacterDriveVehicleComponent component = worldEntity.GetComponent<CharacterDriveVehicleComponent>();
				flag = ((component != null) ? new bool?(component.IsDriver) : null).GetValueOrDefault();
			}
			if (flag)
			{
				TeleportController.Instance.TeleportPlayerInVehicle(new ITeleportContextParam
				{
					ClientReason = "QuickGotoAutoPilot",
					TargetPosition = findPathResult.StartPoint.ToUeVector(false),
					TargetRotation = findPathResult.GetStartRotator(),
					TeleportMode = new ETeleportMode?(ETeleportMode.Loading)
				}).ContinueWith(delegate(bool _)
				{
					Action closeSecondaryUiFunction = this.CloseSecondaryUiFunction;
					if (closeSecondaryUiFunction == null)
					{
						return;
					}
					closeSecondaryUiFunction();
				}).Forget();
				return;
			}
			TeleportController.Instance.TeleportPlayer(new ITeleportContextParam
			{
				ClientReason = "QuickGotoAutoPilot",
				TargetPosition = findPathResult.StartPoint.ToUeVector(false),
				TargetRotation = findPathResult.GetStartRotator(),
				TeleportMode = new ETeleportMode?(ETeleportMode.Loading)
			}).ContinueWith(delegate(bool _)
			{
				Action closeSecondaryUiFunction = this.CloseSecondaryUiFunction;
				if (closeSecondaryUiFunction == null)
				{
					return;
				}
				closeSecondaryUiFunction();
			}).Forget();
		}

		// Token: 0x06030229 RID: 197161 RVA: 0x00B27DAC File Offset: 0x00B25FAC
		private void ShowAutoPilotQuickGoToTeleportConfirmBox(Action callback)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AutoPilotQuickGoToTeleportConfirm);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleTextKey = "Text_FastTravelConfirmToggle_text";
			confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
			{
				AutoPilotModel.Instance.HideQuickTransferConfirmBox = isSelectOn;
			});
			Action value = delegate()
			{
				AutoPilotModel.Instance.HideQuickTransferConfirmBox = false;
			};
			confirmBoxDataNew.FunctionMap[1] = value;
			confirmBoxDataNew.FunctionMap[2] = callback;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603022A RID: 197162 RVA: 0x00B27E41 File Offset: 0x00B26041
		public void UpdateAutoPilotState()
		{
			WorldMapSecondaryUiLayoutHelper.UpdateAutoPilotState(this);
		}

		// Token: 0x0603022B RID: 197163 RVA: 0x00B27E4C File Offset: 0x00B2604C
		public bool IsNeedCustomMarkCreate()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			return markItem.MarkType == EMarkType.Custom && !(markItem as CustomMarkItem).IsCreated;
		}

		// Token: 0x04019EDF RID: 106207
		[Nullable(2)]
		private UUIItem UiParent;

		// Token: 0x04019EE0 RID: 106208
		[Nullable(2)]
		private UUIItem DownStateBtnRoot;

		// Token: 0x04019EE1 RID: 106209
		[Nullable(2)]
		private AutoPilotNavBtnView AutoPilotNavBtnView;

		// Token: 0x04019EE2 RID: 106210
		[Nullable(2)]
		private AutoPilotTrackBtnGroup AutoPilotTrackBtnGroup;

		// Token: 0x04019EE3 RID: 106211
		[Nullable(2)]
		private Action CloseSecondaryUiFunction;

		// Token: 0x04019EE4 RID: 106212
		[Nullable(2)]
		private BaseMap Map;
	}
}
