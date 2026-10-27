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
	// Token: 0x0200563A RID: 22074
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupView : UiPanelBase
	{
		// Token: 0x060381F8 RID: 229880 RVA: 0x00D4B563 File Offset: 0x00D49763
		public GridPopupView(GridPopupViewModelBase vm)
		{
			this.Vm = vm;
		}

		// Token: 0x060381F9 RID: 229881 RVA: 0x00D4B580 File Offset: 0x00D49780
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

		// Token: 0x060381FA RID: 229882 RVA: 0x00D4B69C File Offset: 0x00D4989C
		protected override UniTask OnBeforeStartAsync()
		{
			GridPopupView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GridPopupView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060381FB RID: 229883 RVA: 0x00D4B6DF File Offset: 0x00D498DF
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapEventDetailOpenOrClose, true);
		}

		// Token: 0x060381FC RID: 229884 RVA: 0x00D4B703 File Offset: 0x00D49903
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapEventDetailOpenOrClose, false);
		}

		// Token: 0x060381FD RID: 229885 RVA: 0x00D4B718 File Offset: 0x00D49918
		protected override void OnBeforeShow()
		{
			this.Refresh();
			base.GetButton(8).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x060381FE RID: 229886 RVA: 0x00D4B748 File Offset: 0x00D49948
		protected override UniTask OnShowAsyncImplementImplement()
		{
			GridPopupView.<OnShowAsyncImplementImplement>d__12 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<GridPopupView.<OnShowAsyncImplementImplement>d__12>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060381FF RID: 229887 RVA: 0x00D4B78C File Offset: 0x00D4998C
		protected override UniTask OnHideAsyncImplementImplement()
		{
			GridPopupView.<OnHideAsyncImplementImplement>d__13 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<GridPopupView.<OnHideAsyncImplementImplement>d__13>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06038200 RID: 229888 RVA: 0x00D4B7CF File Offset: 0x00D499CF
		public void Refresh()
		{
			this.OnRefreshCommon();
			this.OnRefreshComponent();
		}

		// Token: 0x06038201 RID: 229889 RVA: 0x00D4B7E0 File Offset: 0x00D499E0
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

		// Token: 0x06038202 RID: 229890 RVA: 0x00D4B9CE File Offset: 0x00D49BCE
		private void OnClickedBtnDetail()
		{
			this.Vm.GetBtnDetailFunc();
		}

		// Token: 0x06038203 RID: 229891 RVA: 0x00D4B9DB File Offset: 0x00D49BDB
		private void OnClickedClose()
		{
			this.Vm.OnClickedClose();
		}

		// Token: 0x06038204 RID: 229892 RVA: 0x00D4B9E8 File Offset: 0x00D49BE8
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

		// Token: 0x06038205 RID: 229893 RVA: 0x00D4BAA9 File Offset: 0x00D49CA9
		protected void OnRefreshComponent()
		{
			this.Vm.RefreshTop();
			this.Vm.RefreshBottom();
			this.Vm.RefreshFunctional();
		}

		// Token: 0x06038206 RID: 229894 RVA: 0x00D4BACC File Offset: 0x00D49CCC
		public UUIItem GetPanelTop()
		{
			return base.GetItem(5);
		}

		// Token: 0x06038207 RID: 229895 RVA: 0x00D4BAD5 File Offset: 0x00D49CD5
		public UUIItem GetPanelBottom()
		{
			return base.GetItem(6);
		}

		// Token: 0x06038208 RID: 229896 RVA: 0x00D4BADE File Offset: 0x00D49CDE
		public UUIItem GetPanelFunctional()
		{
			return base.GetItem(7);
		}

		// Token: 0x06038209 RID: 229897 RVA: 0x00D4BAE8 File Offset: 0x00D49CE8
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

		// Token: 0x0603820A RID: 229898 RVA: 0x00D4BB34 File Offset: 0x00D49D34
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

		// Token: 0x0603820B RID: 229899 RVA: 0x00D4BB80 File Offset: 0x00D49D80
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

		// Token: 0x0603820C RID: 229900 RVA: 0x00D4BBCC File Offset: 0x00D49DCC
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

		// Token: 0x0603820D RID: 229901 RVA: 0x00D4BC18 File Offset: 0x00D49E18
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

		// Token: 0x0603820E RID: 229902 RVA: 0x00D4BC64 File Offset: 0x00D49E64
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

		// Token: 0x0603820F RID: 229903 RVA: 0x00D4BCB0 File Offset: 0x00D49EB0
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

		// Token: 0x06038210 RID: 229904 RVA: 0x00D4BCFB File Offset: 0x00D49EFB
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

		// Token: 0x0401D872 RID: 120946
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D873 RID: 120947
		[Nullable(2)]
		protected PopupTypeRightItem UiBgItem;

		// Token: 0x0401D874 RID: 120948
		protected PopupComponentDescription Description;

		// Token: 0x0401D875 RID: 120949
		public PopupComponentConditionBar ConditionBar;

		// Token: 0x0401D876 RID: 120950
		private readonly Vector2D TempVector2D = Vector2D.Create();

		// Token: 0x0401D877 RID: 120951
		protected GridPopupViewModelBase Vm;
	}
}
