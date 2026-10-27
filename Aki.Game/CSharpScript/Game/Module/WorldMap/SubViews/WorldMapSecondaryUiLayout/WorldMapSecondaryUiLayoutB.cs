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
	// Token: 0x020047C8 RID: 18376
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapSecondaryUiLayoutB : WorldMapSecondaryUi
	{
		// Token: 0x06030279 RID: 197241 RVA: 0x00B28EE0 File Offset: 0x00B270E0
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

		// Token: 0x0603027A RID: 197242 RVA: 0x00B28F38 File Offset: 0x00B27138
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapSecondaryUiLayoutB.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapSecondaryUiLayoutB.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603027B RID: 197243 RVA: 0x00B28F7C File Offset: 0x00B2717C
		private void InitButtons()
		{
			this.LeftConfirmBtn = new ButtonItem(base.GetItem(7));
			this.LeftConfirmBtn.SetFunction(new Action<int>(this.OnLeftConfirmBtnClick));
			this.RightConfirmBtn = new ButtonItem(base.GetItem(8));
			this.RightConfirmBtn.SetFunction(new Action<int>(this.OnRightConfirmBtnClick));
			this.MiddleCenterBtn = new ButtonItem(base.GetButton(12).RootUIComp);
			this.MiddleCenterBtn.SetFunction(new Action<int>(this.OnMiddleCenterBtnClick));
		}

		// Token: 0x0603027C RID: 197244 RVA: 0x00B29012 File Offset: 0x00B27212
		private void InitLayoutContext()
		{
			this.LayoutContext = new WorldMapSecondaryUiContext();
			this.LayoutContext.TrackButtonItem = this.LeftConfirmBtn;
			this.LayoutContext.MapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
		}

		// Token: 0x0603027D RID: 197245 RVA: 0x00B29044 File Offset: 0x00B27244
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

		// Token: 0x0603027E RID: 197246 RVA: 0x00B2908F File Offset: 0x00B2728F
		protected override void OnStart()
		{
			this.RootItem.SetRaycastTarget(false);
			this.SetDelBtnActive(false);
		}

		// Token: 0x0603027F RID: 197247 RVA: 0x00B290A4 File Offset: 0x00B272A4
		protected override void OnBeforeDestroy()
		{
			this.LeftConfirmBtn.Destroy(null);
			this.RightConfirmBtn.Destroy(null);
			this.MiddleCenterBtn.Destroy(null);
		}

		// Token: 0x06030280 RID: 197248 RVA: 0x00B290CC File Offset: 0x00B272CC
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

		// Token: 0x06030281 RID: 197249 RVA: 0x00B29137 File Offset: 0x00B27337
		protected virtual void OnLeftConfirmBtnClick(int index)
		{
		}

		// Token: 0x06030282 RID: 197250 RVA: 0x00B29139 File Offset: 0x00B27339
		protected virtual void OnRightConfirmBtnClick(int index)
		{
		}

		// Token: 0x06030283 RID: 197251 RVA: 0x00B2913B File Offset: 0x00B2733B
		protected virtual void OnMiddleCenterBtnClick(int index)
		{
		}

		// Token: 0x06030284 RID: 197252 RVA: 0x00B2913D File Offset: 0x00B2733D
		protected virtual void OnDelBtnClick()
		{
		}

		// Token: 0x06030285 RID: 197253 RVA: 0x00B29140 File Offset: 0x00B27340
		protected void SetDelBtnActive(bool active)
		{
			base.GetButton(10).RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x06030286 RID: 197254 RVA: 0x00B29168 File Offset: 0x00B27368
		protected void SetDelBtnSelfInteractive(bool interactive)
		{
			base.GetButton(10).SetSelfInteractive(interactive);
		}

		// Token: 0x06030287 RID: 197255 RVA: 0x00B29178 File Offset: 0x00B27378
		protected override void OnAfterShowWorldMapSecondaryUi()
		{
			WorldMapSecondaryUiAutoPilotContext autoPilotContext = this.AutoPilotContext;
			if (autoPilotContext == null)
			{
				return;
			}
			autoPilotContext.UpdateAutoPilotState();
		}

		// Token: 0x06030288 RID: 197256 RVA: 0x00B2918A File Offset: 0x00B2738A
		private void RefreshPanel(MarkItem selectedMarkItem = null)
		{
			this.OnRefreshPanel(selectedMarkItem);
		}

		// Token: 0x06030289 RID: 197257 RVA: 0x00B29193 File Offset: 0x00B27393
		protected virtual void OnRefreshPanel(MarkItem selectedMarkItem = null)
		{
		}

		// Token: 0x04019EFE RID: 106238
		protected ButtonItem LeftConfirmBtn;

		// Token: 0x04019EFF RID: 106239
		protected ButtonItem RightConfirmBtn;

		// Token: 0x04019F00 RID: 106240
		protected ButtonItem MiddleCenterBtn;

		// Token: 0x04019F01 RID: 106241
		protected WorldMapSecondaryUiContext LayoutContext;

		// Token: 0x04019F02 RID: 106242
		protected WorldMapSecondaryUiAutoPilotContext AutoPilotContext;

		// Token: 0x04019F03 RID: 106243
		protected MapTipsActivateTipPanel MapTipsActivateTipPanel;
	}
}
