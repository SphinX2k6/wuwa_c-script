using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CCD RID: 7373
public class RoleTowerExitButtonView : UiViewBase
{
	// Token: 0x06012423 RID: 74787 RVA: 0x00561F3F File Offset: 0x0056013F
	[NullableContext(1)]
	public RoleTowerExitButtonView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012424 RID: 74788 RVA: 0x00561F48 File Offset: 0x00560148
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickTips)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickExit))
		};
	}

	// Token: 0x06012425 RID: 74789 RVA: 0x00561FC7 File Offset: 0x005601C7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
	}

	// Token: 0x06012426 RID: 74790 RVA: 0x00562001 File Offset: 0x00560201
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
	}

	// Token: 0x06012427 RID: 74791 RVA: 0x0056203B File Offset: 0x0056023B
	protected override void OnBeforeShow()
	{
		this.SetButtonsVisible(UiManager.Instance.IsViewShow(EUiViewName.BattleView));
	}

	// Token: 0x06012428 RID: 74792 RVA: 0x00562052 File Offset: 0x00560252
	private void OnActiveBattleView()
	{
		this.SetButtonsVisible(true);
	}

	// Token: 0x06012429 RID: 74793 RVA: 0x0056205B File Offset: 0x0056025B
	private void OnDisActiveBattleView()
	{
		this.SetButtonsVisible(false);
	}

	// Token: 0x0601242A RID: 74794 RVA: 0x00562064 File Offset: 0x00560264
	private void SetButtonsVisible(bool visible)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(visible);
	}

	// Token: 0x0601242B RID: 74795 RVA: 0x00562077 File Offset: 0x00560277
	private void OnClickTips()
	{
		RoleTowerModel.Instance.OpenGameplayTipsView();
	}

	// Token: 0x0601242C RID: 74796 RVA: 0x00562083 File Offset: 0x00560283
	private void OnClickExit()
	{
		RoleTowerModel.Instance.OpenPauseView();
	}

	// Token: 0x02007FBD RID: 32701
	private static class EChildType
	{
		// Token: 0x0402953B RID: 169275
		public const int BtnTips = 0;

		// Token: 0x0402953C RID: 169276
		public const int BtnExit = 1;
	}
}
