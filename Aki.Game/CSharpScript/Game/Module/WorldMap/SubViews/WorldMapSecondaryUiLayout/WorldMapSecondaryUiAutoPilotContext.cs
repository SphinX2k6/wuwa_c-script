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
	// Token: 0x020036F6 RID: 14070
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapSecondaryUiAutoPilotContext
	{
		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x060249E3 RID: 149987 RVA: 0x00A577B2 File Offset: 0x00A559B2
		// (set) Token: 0x060249E4 RID: 149988 RVA: 0x00A577BA File Offset: 0x00A559BA
		public WorldMapSecondaryUiContext LayoutContext { get; private set; }

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x060249E5 RID: 149989 RVA: 0x00A577C3 File Offset: 0x00A559C3
		// (set) Token: 0x060249E6 RID: 149990 RVA: 0x00A577CB File Offset: 0x00A559CB
		[Nullable(2)]
		public Action<MarkItem> RefreshPanelCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x060249E7 RID: 149991 RVA: 0x00A577D4 File Offset: 0x00A559D4
		public WorldMapSecondaryUiAutoPilotContext(WorldMapSecondaryUiContext layoutContext)
		{
			this.LayoutContext = layoutContext;
		}

		// Token: 0x060249E8 RID: 149992 RVA: 0x00A577E3 File Offset: 0x00A559E3
		public void SetUiParent(UUIItem uiParent)
		{
			this.UiParent = uiParent;
		}

		// Token: 0x060249E9 RID: 149993 RVA: 0x00A577EC File Offset: 0x00A559EC
		public void SetDownStateBtnRoot(UUIItem downStateBtnRoot)
		{
			this.DownStateBtnRoot = downStateBtnRoot;
		}

		// Token: 0x060249EA RID: 149994 RVA: 0x00A577F5 File Offset: 0x00A559F5
		public void SetDownStateBtnRootActive(bool isActive)
		{
			UUIItem downStateBtnRoot = this.DownStateBtnRoot;
			if (downStateBtnRoot == null)
			{
				return;
			}
			downStateBtnRoot.SetUIActive(isActive);
		}

		// Token: 0x060249EB RID: 149995 RVA: 0x00A57808 File Offset: 0x00A55A08
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

		// Token: 0x060249EC RID: 149996 RVA: 0x00A57825 File Offset: 0x00A55A25
		public void UpdateAutoPilotNavBtn(bool isAutoPilotTracked, bool isInteractive)
		{
			AutoPilotNavBtnView autoPilotNavBtnView = this.AutoPilotNavBtnView;
			if (autoPilotNavBtnView == null)
			{
				return;
			}
			autoPilotNavBtnView.RefreshUi(isAutoPilotTracked, isInteractive);
		}

		// Token: 0x060249ED RID: 149997 RVA: 0x00A5783C File Offset: 0x00A55A3C
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

		// Token: 0x060249EE RID: 149998 RVA: 0x00A57898 File Offset: 0x00A55A98
		public void SetBtnGoQuickEnable(bool isEnable)
		{
			AutoPilotTrackBtnGroup autoPilotTrackBtnGroup = this.AutoPilotTrackBtnGroup;
			if (autoPilotTrackBtnGroup == null)
			{
				return;
			}
			autoPilotTrackBtnGroup.SetBtnGoQuickEnable(isEnable);
		}

		// Token: 0x060249EF RID: 149999 RVA: 0x00A578AB File Offset: 0x00A55AAB
		public void SetCloseSecondaryUiFunction(Action func)
		{
			this.CloseSecondaryUiFunction = func;
		}

		// Token: 0x060249F0 RID: 150000 RVA: 0x00A578B4 File Offset: 0x00A55AB4
		[NullableContext(2)]
		public void SetMap(BaseMap map)
		{
			this.Map = map;
		}

		// Token: 0x060249F1 RID: 150001 RVA: 0x00A578C0 File Offset: 0x00A55AC0
		public UniTask InitAutoPilotUi()
		{
			WorldMapSecondaryUiAutoPilotContext.<InitAutoPilotUi>d__24 <InitAutoPilotUi>d__;
			<InitAutoPilotUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAutoPilotUi>d__.<>4__this = this;
			<InitAutoPilotUi>d__.<>1__state = -1;
			<InitAutoPilotUi>d__.<>t__builder.Start<WorldMapSecondaryUiAutoPilotContext.<InitAutoPilotUi>d__24>(ref <InitAutoPilotUi>d__);
			return <InitAutoPilotUi>d__.<>t__builder.Task;
		}

		// Token: 0x060249F2 RID: 150002 RVA: 0x00A57903 File Offset: 0x00A55B03
		private void OnAutoPilotNavBtnClick()
		{
			this.OnHandleTrackAutoPilot(true).Forget();
		}

		// Token: 0x060249F3 RID: 150003 RVA: 0x00A57911 File Offset: 0x00A55B11
		private void OnCancelAutoPilotTrackBtnClick()
		{
			this.OnHandleTrackAutoPilot(false).Forget();
		}

		// Token: 0x060249F4 RID: 150004 RVA: 0x00A5791F File Offset: 0x00A55B1F
		private void OnQuickGoBtnClick()
		{
			if (AutoPilotModel.Instance.HideQuickTransferConfirmBox)
			{
				this.HandleQuickGotoAutoPilot();
				return;
			}
			this.ShowAutoPilotQuickGoToTeleportConfirmBox(new Action(this.HandleQuickGotoAutoPilot));
		}

		// Token: 0x060249F5 RID: 150005 RVA: 0x00A57948 File Offset: 0x00A55B48
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

		// Token: 0x060249F6 RID: 150006 RVA: 0x00A57994 File Offset: 0x00A55B94
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

		// Token: 0x060249F7 RID: 150007 RVA: 0x00A579E8 File Offset: 0x00A55BE8
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

		// Token: 0x060249F8 RID: 150008 RVA: 0x00A57A78 File Offset: 0x00A55C78
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

		// Token: 0x060249F9 RID: 150009 RVA: 0x00A57BB8 File Offset: 0x00A55DB8
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

		// Token: 0x060249FA RID: 150010 RVA: 0x00A57C4D File Offset: 0x00A55E4D
		public void UpdateAutoPilotState()
		{
			WorldMapSecondaryUiLayoutHelper.UpdateAutoPilotState(this);
		}

		// Token: 0x060249FB RID: 150011 RVA: 0x00A57C58 File Offset: 0x00A55E58
		public bool IsNeedCustomMarkCreate()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			return markItem.MarkType == EMarkType.Custom && !(markItem as CustomMarkItem).IsCreated;
		}

		// Token: 0x04014590 RID: 83344
		[Nullable(2)]
		private UUIItem UiParent;

		// Token: 0x04014591 RID: 83345
		[Nullable(2)]
		private UUIItem DownStateBtnRoot;

		// Token: 0x04014592 RID: 83346
		[Nullable(2)]
		private AutoPilotNavBtnView AutoPilotNavBtnView;

		// Token: 0x04014593 RID: 83347
		[Nullable(2)]
		private AutoPilotTrackBtnGroup AutoPilotTrackBtnGroup;

		// Token: 0x04014594 RID: 83348
		[Nullable(2)]
		private Action CloseSecondaryUiFunction;

		// Token: 0x04014595 RID: 83349
		[Nullable(2)]
		private BaseMap Map;
	}
}
