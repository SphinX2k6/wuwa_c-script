using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout
{
	// Token: 0x020036F9 RID: 14073
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapSecondaryUiLayoutB : WorldMapSecondaryUi
	{
		// Token: 0x06024A49 RID: 150089 RVA: 0x00A58D4C File Offset: 0x00A56F4C
		protected unsafe override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = WorldMapDefine.SecondaryUiPanelComponentsRegisterInfoB;
			int num = 1;
			List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
			Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Delegate>(10, new Action(this.OnDelBtnClick));
			this.BtnBindInfo = list;
		}

		// Token: 0x06024A4A RID: 150090 RVA: 0x00A58DA4 File Offset: 0x00A56FA4
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapSecondaryUiLayoutB.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapSecondaryUiLayoutB.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024A4B RID: 150091 RVA: 0x00A58DE8 File Offset: 0x00A56FE8
		private void InitButtons()
		{
			this.LeftConfirmBtn = new ButtonItem(base.GetItem(7));
			this.LeftConfirmBtn.SetFunction(new Action<int>(this.OnLeftConfirmBtnClick));
			this.RightConfirmBtn = new ButtonItem(base.GetItem(8));
			this.RightConfirmBtn.SetFunction(new Action<int>(this.OnRightConfirmBtnClick));
			this.MiddleCenterBtn = new ButtonItem(base.GetButton(12).RootUIComp);
			this.MiddleCenterBtn.SetFunction(new Action<int>(this.OnMiddleCenterBtnClick));
		}

		// Token: 0x06024A4C RID: 150092 RVA: 0x00A58E7E File Offset: 0x00A5707E
		private void InitLayoutContext()
		{
			this.LayoutContext = new WorldMapSecondaryUiContext();
			this.LayoutContext.TrackButtonItem = this.LeftConfirmBtn;
			this.LayoutContext.MapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
		}

		// Token: 0x06024A4D RID: 150093 RVA: 0x00A58EB0 File Offset: 0x00A570B0
		[NullableContext(1)]
		private UniTask InitAutoPilotContext(WorldMapSecondaryUiContext layoutContext)
		{
			WorldMapSecondaryUiLayoutB.<InitAutoPilotContext>d__10 <InitAutoPilotContext>d__;
			<InitAutoPilotContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAutoPilotContext>d__.<>4__this = this;
			<InitAutoPilotContext>d__.layoutContext = layoutContext;
			<InitAutoPilotContext>d__.<>1__state = -1;
			<InitAutoPilotContext>d__.<>t__builder.Start<WorldMapSecondaryUiLayoutB.<InitAutoPilotContext>d__10>(ref <InitAutoPilotContext>d__);
			return <InitAutoPilotContext>d__.<>t__builder.Task;
		}

		// Token: 0x06024A4E RID: 150094 RVA: 0x00A58EFB File Offset: 0x00A570FB
		protected override void OnStart()
		{
			this.RootItem.SetRaycastTarget(false);
			this.SetDelBtnActive(false);
		}

		// Token: 0x06024A4F RID: 150095 RVA: 0x00A58F10 File Offset: 0x00A57110
		protected override void OnBeforeDestroy()
		{
			this.LeftConfirmBtn.Destroy(null);
			this.RightConfirmBtn.Destroy(null);
			this.MiddleCenterBtn.Destroy(null);
		}

		// Token: 0x06024A50 RID: 150096 RVA: 0x00A58F38 File Offset: 0x00A57138
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			MapTipsActivateTipPanel mapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel != null)
			{
				mapTipsActivateTipPanel.SetUiActive(false);
			}
			WorldMapSecondaryUiAutoPilotContext autoPilotContext = this.AutoPilotContext;
			if (autoPilotContext != null)
			{
				autoPilotContext.SetMap(this.Map);
			}
			WorldMapSecondaryUiAutoPilotContext autoPilotContext2 = this.AutoPilotContext;
			if (autoPilotContext2 != null)
			{
				autoPilotContext2.SetDownStateBtnRootActive(true);
			}
			WorldMapSecondaryUiAutoPilotContext autoPilotContext3 = this.AutoPilotContext;
			if (autoPilotContext3 != null)
			{
				autoPilotContext3.SetAutoPilotNavBtnActive(false);
			}
			WorldMapSecondaryUiAutoPilotContext autoPilotContext4 = this.AutoPilotContext;
			if (autoPilotContext4 == null)
			{
				return;
			}
			autoPilotContext4.RefreshAutoPilotTrackBtnGroup(false);
		}

		// Token: 0x06024A51 RID: 150097 RVA: 0x00A58FA3 File Offset: 0x00A571A3
		protected virtual void OnLeftConfirmBtnClick(int index)
		{
		}

		// Token: 0x06024A52 RID: 150098 RVA: 0x00A58FA5 File Offset: 0x00A571A5
		protected virtual void OnRightConfirmBtnClick(int index)
		{
		}

		// Token: 0x06024A53 RID: 150099 RVA: 0x00A58FA7 File Offset: 0x00A571A7
		protected virtual void OnMiddleCenterBtnClick(int index)
		{
		}

		// Token: 0x06024A54 RID: 150100 RVA: 0x00A58FA9 File Offset: 0x00A571A9
		protected virtual void OnDelBtnClick()
		{
		}

		// Token: 0x06024A55 RID: 150101 RVA: 0x00A58FAC File Offset: 0x00A571AC
		protected void SetDelBtnActive(bool active)
		{
			base.GetButton(10).RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x06024A56 RID: 150102 RVA: 0x00A58FD4 File Offset: 0x00A571D4
		protected void SetDelBtnSelfInteractive(bool interactive)
		{
			base.GetButton(10).SetSelfInteractive(interactive);
		}

		// Token: 0x06024A57 RID: 150103 RVA: 0x00A58FE4 File Offset: 0x00A571E4
		protected override void OnAfterShowWorldMapSecondaryUi()
		{
			WorldMapSecondaryUiAutoPilotContext autoPilotContext = this.AutoPilotContext;
			if (autoPilotContext == null)
			{
				return;
			}
			autoPilotContext.UpdateAutoPilotState();
		}

		// Token: 0x06024A58 RID: 150104 RVA: 0x00A58FF6 File Offset: 0x00A571F6
		private void RefreshPanel(MarkItem selectedMarkItem = null)
		{
			this.OnRefreshPanel(selectedMarkItem);
		}

		// Token: 0x06024A59 RID: 150105 RVA: 0x00A58FFF File Offset: 0x00A571FF
		protected virtual void OnRefreshPanel(MarkItem selectedMarkItem = null)
		{
		}

		// Token: 0x040145B2 RID: 83378
		protected ButtonItem LeftConfirmBtn;

		// Token: 0x040145B3 RID: 83379
		protected ButtonItem RightConfirmBtn;

		// Token: 0x040145B4 RID: 83380
		protected ButtonItem MiddleCenterBtn;

		// Token: 0x040145B5 RID: 83381
		protected WorldMapSecondaryUiContext LayoutContext;

		// Token: 0x040145B6 RID: 83382
		protected WorldMapSecondaryUiAutoPilotContext AutoPilotContext;

		// Token: 0x040145B7 RID: 83383
		protected MapTipsActivateTipPanel MapTipsActivateTipPanel;
	}
}
