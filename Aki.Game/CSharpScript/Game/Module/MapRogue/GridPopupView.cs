using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004610 RID: 17936
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupView : UiPanelBase
	{
		// Token: 0x0602D0F6 RID: 184566 RVA: 0x00C992AB File Offset: 0x00C974AB
		public GridPopupView(GridPopupViewModelBase vm)
		{
			this.Vm = vm;
		}

		// Token: 0x0602D0F7 RID: 184567 RVA: 0x00C992C8 File Offset: 0x00C974C8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickedBtnDetail)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickedMask))
			};
		}

		// Token: 0x0602D0F8 RID: 184568 RVA: 0x00C993E4 File Offset: 0x00C975E4
		protected override UniTask OnBeforeStartAsync()
		{
			GridPopupView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GridPopupView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0F9 RID: 184569 RVA: 0x00C99427 File Offset: 0x00C97627
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapEventDetailOpenOrClose, true);
		}

		// Token: 0x0602D0FA RID: 184570 RVA: 0x00C9944B File Offset: 0x00C9764B
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapEventDetailOpenOrClose, false);
		}

		// Token: 0x0602D0FB RID: 184571 RVA: 0x00C99460 File Offset: 0x00C97660
		protected override void OnBeforeShow()
		{
			this.Refresh();
			base.GetButton(8).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0602D0FC RID: 184572 RVA: 0x00C99490 File Offset: 0x00C97690
		protected override UniTask OnShowAsyncImplementImplement()
		{
			GridPopupView.<OnShowAsyncImplementImplement>d__12 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<GridPopupView.<OnShowAsyncImplementImplement>d__12>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0FD RID: 184573 RVA: 0x00C994D4 File Offset: 0x00C976D4
		protected override UniTask OnHideAsyncImplementImplement()
		{
			GridPopupView.<OnHideAsyncImplementImplement>d__13 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<GridPopupView.<OnHideAsyncImplementImplement>d__13>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0FE RID: 184574 RVA: 0x00C99517 File Offset: 0x00C97717
		public void Refresh()
		{
			this.OnRefreshCommon();
			this.OnRefreshComponent();
		}

		// Token: 0x0602D0FF RID: 184575 RVA: 0x00C99528 File Offset: 0x00C97728
		protected void OnRefreshCommon()
		{
			UUISprite sprite = base.GetSprite(1);
			UUIText text = base.GetText(2);
			UUIText text2 = base.GetText(3);
			UUIButtonComponent button = base.GetButton(4);
			RogueResGridEvent? gridEventConfigById = MapRogueConfig.Instance.GetGridEventConfigById(this.Vm.GridData.GridEventId);
			if (gridEventConfigById == null)
			{
				return;
			}
			if (!StringUtils.IsEmpty(gridEventConfigById.Value.Icon))
			{
				this.SetSpriteByPath(gridEventConfigById.Value.Icon, sprite, false, null, null);
			}
			LguiUtil.Instance.SetLocalTextNew(text, gridEventConfigById.Value.Title, Array.Empty<object>());
			this.Description.SetDescriptionByTextId(gridEventConfigById.Value.Desc, Array.Empty<string>());
			string subTxtInfo = this.Vm.GetSubTxtInfo();
			if (subTxtInfo != null)
			{
				text2.SetText(subTxtInfo, true);
			}
			text2.SetUIActive(!StringUtils.IsEmpty(subTxtInfo));
			button.RootUIComp.Get().SetUIActive(this.Vm.HasBtnDetail);
			bool flag = this.Vm.EventAvailable();
			this.ConditionBar.SetUiActive(!flag);
			if (!flag)
			{
				this.ConditionBar.SetButtonVisible(false);
				EMovePathType moveState = this.Vm.GameInfo.MoveState;
				if (moveState == EMovePathType.CannotAchieve)
				{
					this.ConditionBar.SetTextByTextId("RogueRes_Block_UnableMove", Array.Empty<string>());
					return;
				}
				if (moveState == EMovePathType.EventInterrupt)
				{
					this.ConditionBar.SetTextByTextId("RogueRes_Block_UnableMove_Event", Array.Empty<string>());
					return;
				}
				CondInfo conditionInfo = this.Vm.GridData.ConditionInfo;
				if (conditionInfo == null)
				{
					return;
				}
				PopupComponentConditionBar conditionBar = this.ConditionBar;
				string condText = gridEventConfigById.Value.CondText;
				string[] array = new string[2];
				int num = 0;
				int num2 = conditionInfo.Current;
				array[num] = num2.ToString();
				array[1] = conditionInfo.Target.ToString();
				conditionBar.SetTextByTextId(condText, array);
			}
		}

		// Token: 0x0602D100 RID: 184576 RVA: 0x00C99716 File Offset: 0x00C97916
		private void OnClickedBtnDetail()
		{
			this.Vm.GetBtnDetailFunc();
		}

		// Token: 0x0602D101 RID: 184577 RVA: 0x00C99723 File Offset: 0x00C97923
		private void OnClickedClose()
		{
			this.Vm.OnClickedClose();
		}

		// Token: 0x0602D102 RID: 184578 RVA: 0x00C99730 File Offset: 0x00C97930
		private void OnClickedMask()
		{
			if (this.Vm.IsEnd)
			{
				return;
			}
			if (this.Vm.EventAvailable())
			{
				MapRogueGameInfo gameInfo = this.Vm.GameInfo;
				TsCharacterController characterController = Global.CharacterController;
				ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
				this.TempVector2D.Reset();
				if (characterController != null)
				{
					Vector2D inputPosition = characterController.GetInputPosition(0);
					if (inputPosition != null)
					{
						this.TempVector2D.AdditionEqual(inputPosition);
						ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
						FVector2D fvector2D = this.TempVector2D.ToUeVector2D(false);
						FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
						if (gameInfo.IsPosInGridRange((int)fvector2D2.X, (int)fvector2D2.Y, gameInfo.CurSelectedIndex))
						{
							this.Vm.MoveButtonFunction(0);
							return;
						}
					}
				}
			}
			this.Vm.OnClickedClose();
		}

		// Token: 0x0602D103 RID: 184579 RVA: 0x00C997F1 File Offset: 0x00C979F1
		protected void OnRefreshComponent()
		{
			this.Vm.RefreshTop();
			this.Vm.RefreshBottom();
			this.Vm.RefreshFunctional();
		}

		// Token: 0x0602D104 RID: 184580 RVA: 0x00C99814 File Offset: 0x00C97A14
		public UUIItem GetPanelTop()
		{
			return base.GetItem(5);
		}

		// Token: 0x0602D105 RID: 184581 RVA: 0x00C9981D File Offset: 0x00C97A1D
		public UUIItem GetPanelBottom()
		{
			return base.GetItem(6);
		}

		// Token: 0x0602D106 RID: 184582 RVA: 0x00C99826 File Offset: 0x00C97A26
		public UUIItem GetPanelFunctional()
		{
			return base.GetItem(7);
		}

		// Token: 0x0602D107 RID: 184583 RVA: 0x00C99830 File Offset: 0x00C97A30
		[NullableContext(2)]
		private UniTask InitComponentDescription(UUIItem parentItem = null)
		{
			GridPopupView.<InitComponentDescription>d__23 <InitComponentDescription>d__;
			<InitComponentDescription>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitComponentDescription>d__.<>4__this = this;
			<InitComponentDescription>d__.parentItem = parentItem;
			<InitComponentDescription>d__.<>1__state = -1;
			<InitComponentDescription>d__.<>t__builder.Start<GridPopupView.<InitComponentDescription>d__23>(ref <InitComponentDescription>d__);
			return <InitComponentDescription>d__.<>t__builder.Task;
		}

		// Token: 0x0602D108 RID: 184584 RVA: 0x00C9987C File Offset: 0x00C97A7C
		[NullableContext(2)]
		private UniTask InitConditionBar(UUIItem parentItem = null)
		{
			GridPopupView.<InitConditionBar>d__24 <InitConditionBar>d__;
			<InitConditionBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitConditionBar>d__.<>4__this = this;
			<InitConditionBar>d__.parentItem = parentItem;
			<InitConditionBar>d__.<>1__state = -1;
			<InitConditionBar>d__.<>t__builder.Start<GridPopupView.<InitConditionBar>d__24>(ref <InitConditionBar>d__);
			return <InitConditionBar>d__.<>t__builder.Task;
		}

		// Token: 0x0602D109 RID: 184585 RVA: 0x00C998C8 File Offset: 0x00C97AC8
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<PopupComponentFunctionButton> InitComponentButton(UUIItem parentItem = null)
		{
			GridPopupView.<InitComponentButton>d__25 <InitComponentButton>d__;
			<InitComponentButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<PopupComponentFunctionButton>.Create();
			<InitComponentButton>d__.<>4__this = this;
			<InitComponentButton>d__.parentItem = parentItem;
			<InitComponentButton>d__.<>1__state = -1;
			<InitComponentButton>d__.<>t__builder.Start<GridPopupView.<InitComponentButton>d__25>(ref <InitComponentButton>d__);
			return <InitComponentButton>d__.<>t__builder.Task;
		}

		// Token: 0x0602D10A RID: 184586 RVA: 0x00C99914 File Offset: 0x00C97B14
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<PopupComponentRecommendTip> InitRecommendTip(UUIItem parentItem = null)
		{
			GridPopupView.<InitRecommendTip>d__26 <InitRecommendTip>d__;
			<InitRecommendTip>d__.<>t__builder = AsyncUniTaskMethodBuilder<PopupComponentRecommendTip>.Create();
			<InitRecommendTip>d__.<>4__this = this;
			<InitRecommendTip>d__.parentItem = parentItem;
			<InitRecommendTip>d__.<>1__state = -1;
			<InitRecommendTip>d__.<>t__builder.Start<GridPopupView.<InitRecommendTip>d__26>(ref <InitRecommendTip>d__);
			return <InitRecommendTip>d__.<>t__builder.Task;
		}

		// Token: 0x0602D10B RID: 184587 RVA: 0x00C99960 File Offset: 0x00C97B60
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<PopupComponentInfoList> InitInfoList(UUIItem parentItem = null)
		{
			GridPopupView.<InitInfoList>d__27 <InitInfoList>d__;
			<InitInfoList>d__.<>t__builder = AsyncUniTaskMethodBuilder<PopupComponentInfoList>.Create();
			<InitInfoList>d__.<>4__this = this;
			<InitInfoList>d__.parentItem = parentItem;
			<InitInfoList>d__.<>1__state = -1;
			<InitInfoList>d__.<>t__builder.Start<GridPopupView.<InitInfoList>d__27>(ref <InitInfoList>d__);
			return <InitInfoList>d__.<>t__builder.Task;
		}

		// Token: 0x0602D10C RID: 184588 RVA: 0x00C999AC File Offset: 0x00C97BAC
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<PopupComponentEventCost> InitEventCost(UUIItem parentItem = null)
		{
			GridPopupView.<InitEventCost>d__28 <InitEventCost>d__;
			<InitEventCost>d__.<>t__builder = AsyncUniTaskMethodBuilder<PopupComponentEventCost>.Create();
			<InitEventCost>d__.<>4__this = this;
			<InitEventCost>d__.parentItem = parentItem;
			<InitEventCost>d__.<>1__state = -1;
			<InitEventCost>d__.<>t__builder.Start<GridPopupView.<InitEventCost>d__28>(ref <InitEventCost>d__);
			return <InitEventCost>d__.<>t__builder.Task;
		}

		// Token: 0x0602D10D RID: 184589 RVA: 0x00C999F8 File Offset: 0x00C97BF8
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<PopupComponentRewardList> InitRewardList(UUIItem parentItem = null)
		{
			GridPopupView.<InitRewardList>d__29 <InitRewardList>d__;
			<InitRewardList>d__.<>t__builder = AsyncUniTaskMethodBuilder<PopupComponentRewardList>.Create();
			<InitRewardList>d__.<>4__this = this;
			<InitRewardList>d__.parentItem = parentItem;
			<InitRewardList>d__.<>1__state = -1;
			<InitRewardList>d__.<>t__builder.Start<GridPopupView.<InitRewardList>d__29>(ref <InitRewardList>d__);
			return <InitRewardList>d__.<>t__builder.Task;
		}

		// Token: 0x0602D10E RID: 184590 RVA: 0x00C99A43 File Offset: 0x00C97C43
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
			return this.Vm.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x040182FD RID: 99069
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040182FE RID: 99070
		[Nullable(2)]
		protected PopupTypeRightItem UiBgItem;

		// Token: 0x040182FF RID: 99071
		protected PopupComponentDescription Description;

		// Token: 0x04018300 RID: 99072
		public PopupComponentConditionBar ConditionBar;

		// Token: 0x04018301 RID: 99073
		private readonly Vector2D TempVector2D = Vector2D.Create();

		// Token: 0x04018302 RID: 99074
		protected GridPopupViewModelBase Vm;
	}
}
