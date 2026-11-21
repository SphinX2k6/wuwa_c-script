using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000771 RID: 1905
[NullableContext(1)]
[Nullable(0)]
public class LordGymBossCard : UiPanelBase
{
	// Token: 0x06005764 RID: 22372 RVA: 0x001C9E4C File Offset: 0x001C804C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIGridLayout))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.MoveToLeft)),
			new ValueTuple<int, Delegate>(5, new Action(this.MoveToRight))
		};
	}

	// Token: 0x06005765 RID: 22373 RVA: 0x001C9F50 File Offset: 0x001C8150
	protected override void OnStart()
	{
		UUIButtonComponent button = base.GetButton(4);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
		this.LeftBtn = ((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null);
		UUIButtonComponent button2 = base.GetButton(5);
		tweakObjectPtr = ((button2 != null) ? new TWeakObjectPtr<UUIItem>?(button2.RootUIComp) : null);
		this.RightBtn = ((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null);
		UUIItem item = base.GetItem(0);
		this.CircleExhibitionView = new CircleAttachView<int, LordGymBossCardItem>((item != null) ? item.GetOwner() : null, false);
		AutoAttachBaseView<int, LordGymBossCardItem> circleExhibitionView = this.CircleExhibitionView;
		UUIItem item2 = base.GetItem(1);
		circleExhibitionView.CreateItems((item2 != null) ? item2.GetOwner() : null, 4f, new Func<AActor, int, int, LordGymBossCardItem>(this.InitGrid), EAttachDirection.Horizontal);
		this.CircleExhibitionView.SetDragBeginCallback(new Action(this.HideSwitchBtn));
		this.CircleExhibitionView.SetPageLimitState(true);
		this.CircleExhibitionView.SetMoveMultiFactor(50f);
		this.PageDotLayout = new GenericLayout<LordGymPageDot, int>(base.GetGridLayout(8), new Func<LordGymPageDot>(this.InitPageDot), null, false, true);
	}

	// Token: 0x06005766 RID: 22374 RVA: 0x001CA07E File Offset: 0x001C827E
	private void HideSwitchBtn()
	{
		UUIItem rightBtn = this.RightBtn;
		if (rightBtn != null)
		{
			rightBtn.SetUIActive(false);
		}
		UUIItem leftBtn = this.LeftBtn;
		if (leftBtn == null)
		{
			return;
		}
		leftBtn.SetUIActive(false);
	}

	// Token: 0x06005767 RID: 22375 RVA: 0x001CA0A4 File Offset: 0x001C82A4
	public void Refresh(List<int> ids)
	{
		if (this.CircleExhibitionView == null || this.PageDotLayout == null)
		{
			return;
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(ids.Count > 1);
		}
		this.CircleExhibitionView.ReloadView(ids.Count, ids.ToArray(), 0);
		if (ids.Count > 1)
		{
			this.CircleExhibitionView.EnableDragEvent();
			int index = this.PageDotLayout.GetSelectedGridIndex();
			this.PageDotLayout.RefreshByData(ids, delegate
			{
				GenericLayout<LordGymPageDot, int> pageDotLayout = this.PageDotLayout;
				if (pageDotLayout == null)
				{
					return;
				}
				pageDotLayout.SelectGridProxy((index < 0) ? 0 : index, true);
			}, false);
		}
		else
		{
			this.CircleExhibitionView.DisableDragEvent();
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x06005768 RID: 22376 RVA: 0x001CA15F File Offset: 0x001C835F
	private LordGymPageDot InitPageDot()
	{
		return new LordGymPageDot();
	}

	// Token: 0x06005769 RID: 22377 RVA: 0x001CA166 File Offset: 0x001C8366
	private LordGymBossCardItem InitGrid(AActor actor, int index, int showNum)
	{
		LordGymBossCardItem lordGymBossCardItem = new LordGymBossCardItem(actor);
		lordGymBossCardItem.BindOnSelected(new Action<int>(this.OnItemSelected));
		return lordGymBossCardItem;
	}

	// Token: 0x0600576A RID: 22378 RVA: 0x001CA180 File Offset: 0x001C8380
	private void OnItemSelected(int index)
	{
		GenericLayout<LordGymPageDot, int> pageDotLayout = this.PageDotLayout;
		if (pageDotLayout != null)
		{
			pageDotLayout.SelectGridProxy(index, true);
		}
		UUIItem rightBtn = this.RightBtn;
		if (rightBtn != null)
		{
			rightBtn.SetUIActive(true);
		}
		UUIItem leftBtn = this.LeftBtn;
		if (leftBtn == null)
		{
			return;
		}
		leftBtn.SetUIActive(true);
	}

	// Token: 0x0600576B RID: 22379 RVA: 0x001CA1B8 File Offset: 0x001C83B8
	private void MoveToLeft()
	{
		CircleAttachView<int, LordGymBossCardItem> circleExhibitionView = this.CircleExhibitionView;
		if (circleExhibitionView == null)
		{
			return;
		}
		circleExhibitionView.MoveToNextItem(-1);
	}

	// Token: 0x0600576C RID: 22380 RVA: 0x001CA1CB File Offset: 0x001C83CB
	private void MoveToRight()
	{
		CircleAttachView<int, LordGymBossCardItem> circleExhibitionView = this.CircleExhibitionView;
		if (circleExhibitionView == null)
		{
			return;
		}
		circleExhibitionView.MoveToNextItem(1);
	}

	// Token: 0x04003BE7 RID: 15335
	private const int SHOW_GAP = 4;

	// Token: 0x04003BE8 RID: 15336
	private CircleAttachView<int, LordGymBossCardItem> CircleExhibitionView;

	// Token: 0x04003BE9 RID: 15337
	private GenericLayout<LordGymPageDot, int> PageDotLayout;

	// Token: 0x04003BEA RID: 15338
	[Nullable(2)]
	private UUIItem LeftBtn;

	// Token: 0x04003BEB RID: 15339
	[Nullable(2)]
	private UUIItem RightBtn;
}
