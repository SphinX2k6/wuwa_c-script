using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012BD RID: 4797
[NullableContext(1)]
[Nullable(0)]
public class LordGymBossCard : UiPanelBase
{
	// Token: 0x060083C9 RID: 33737 RVA: 0x001C0FF0 File Offset: 0x001BF1F0
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

	// Token: 0x060083CA RID: 33738 RVA: 0x001C10F4 File Offset: 0x001BF2F4
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

	// Token: 0x060083CB RID: 33739 RVA: 0x001C1222 File Offset: 0x001BF422
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

	// Token: 0x060083CC RID: 33740 RVA: 0x001C1248 File Offset: 0x001BF448
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

	// Token: 0x060083CD RID: 33741 RVA: 0x001C1303 File Offset: 0x001BF503
	private LordGymPageDot InitPageDot()
	{
		return new LordGymPageDot();
	}

	// Token: 0x060083CE RID: 33742 RVA: 0x001C130A File Offset: 0x001BF50A
	private LordGymBossCardItem InitGrid(AActor actor, int index, int showNum)
	{
		LordGymBossCardItem lordGymBossCardItem = new LordGymBossCardItem(actor);
		lordGymBossCardItem.BindOnSelected(new Action<int>(this.OnItemSelected));
		return lordGymBossCardItem;
	}

	// Token: 0x060083CF RID: 33743 RVA: 0x001C1324 File Offset: 0x001BF524
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

	// Token: 0x060083D0 RID: 33744 RVA: 0x001C135C File Offset: 0x001BF55C
	private void MoveToLeft()
	{
		CircleAttachView<int, LordGymBossCardItem> circleExhibitionView = this.CircleExhibitionView;
		if (circleExhibitionView == null)
		{
			return;
		}
		circleExhibitionView.MoveToNextItem(-1);
	}

	// Token: 0x060083D1 RID: 33745 RVA: 0x001C136F File Offset: 0x001BF56F
	private void MoveToRight()
	{
		CircleAttachView<int, LordGymBossCardItem> circleExhibitionView = this.CircleExhibitionView;
		if (circleExhibitionView == null)
		{
			return;
		}
		circleExhibitionView.MoveToNextItem(1);
	}

	// Token: 0x04003B4F RID: 15183
	private const int SHOW_GAP = 4;

	// Token: 0x04003B50 RID: 15184
	private CircleAttachView<int, LordGymBossCardItem> CircleExhibitionView;

	// Token: 0x04003B51 RID: 15185
	private GenericLayout<LordGymPageDot, int> PageDotLayout;

	// Token: 0x04003B52 RID: 15186
	[Nullable(2)]
	private UUIItem LeftBtn;

	// Token: 0x04003B53 RID: 15187
	[Nullable(2)]
	private UUIItem RightBtn;
}
