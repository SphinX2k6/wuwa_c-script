using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001289 RID: 4745
[NullableContext(2)]
[Nullable(0)]
public class FocusItemText : UiPanelBase
{
	// Token: 0x0600BBF4 RID: 48116 RVA: 0x00377822 File Offset: 0x00375A22
	[NullableContext(1)]
	public FocusItemText(GuideFocusItem owner)
	{
		this.Owner = owner;
		this.View = owner.Owner;
	}

	// Token: 0x0600BBF5 RID: 48117 RVA: 0x00377844 File Offset: 0x00375A44
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BBF6 RID: 48118 RVA: 0x003779FC File Offset: 0x00375BFC
	protected override void OnStart()
	{
		float totalDuration = this.View.TotalDuration;
		UUIItem item = base.GetItem(8);
		if (totalDuration > 0f)
		{
			this.CountDownItem = new GuideCountDownItem(totalDuration);
			this.CountDownItem.Init(item);
			item.SetUIActive(true);
		}
		else
		{
			item.SetUIActive(false);
		}
		this.RootItem.SetAnchorOffset(FVector2D.ZeroVector);
	}

	// Token: 0x0600BBF7 RID: 48119 RVA: 0x00377A5D File Offset: 0x00375C5D
	private void ReClampTextPosition(UUILayoutBase _)
	{
		this.ClampDelay = 1;
	}

	// Token: 0x0600BBF8 RID: 48120 RVA: 0x00377A68 File Offset: 0x00375C68
	public void ShowText()
	{
		UUIText text = base.GetText(7);
		base.GetHorizontalLayout(3).OnRebuildLayoutDelegate.Bind(new Action<UUILayoutBase>(this.ReClampTextPosition));
		GuideDescribeNew guideDescribeNew = new GuideDescribeNew(text);
		GuideFocusNew value = this.View.GetFocusViewConf().Value;
		this.ClampTxtInScreen = value.TextInScreen;
		guideDescribeNew.SetUpText(value.Content, value.Button());
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(2);
		UUIItem item3 = base.GetItem(4);
		UUIItem item4 = base.GetItem(5);
		item.SetUIActive(false);
		item2.SetUIActive(false);
		item3.SetUIActive(false);
		item4.SetUIActive(false);
		if (value.ShowArrow)
		{
			if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Down)
			{
				item.SetUIActive(true);
			}
			else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Up)
			{
				item2.SetUIActive(true);
			}
			else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Left)
			{
				item4.SetUIActive(true);
			}
			else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Right)
			{
				item3.SetUIActive(true);
			}
		}
		int roleHeadId = value.RoleHeadId;
		string headImgPath = value.HeadImgPath;
		if (headImgPath.Length > 0)
		{
			base.SetTextureByPath(headImgPath, base.GetTexture(11), null, null);
			base.GetItem(10).SetUIActive(true);
			return;
		}
		if (roleHeadId != 0)
		{
			base.SetTextureByPath(RoleConfig.Instance.GetRoleConfig(roleHeadId).Value.RoleHeadIconBig, base.GetTexture(11), null, null);
			base.GetItem(10).SetUIActive(true);
			return;
		}
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x0600BBF9 RID: 48121 RVA: 0x00377C69 File Offset: 0x00375E69
	public void OnTick(float delta)
	{
		this.SetUpTextPosition();
		this.ClampTextPosition();
	}

	// Token: 0x0600BBFA RID: 48122 RVA: 0x00377C78 File Offset: 0x00375E78
	private void SetUpTextPosition()
	{
		if (!GuideController.Instance.GmEnableFocusTextPosTick)
		{
			return;
		}
		UUIItem rectItem = this.Owner.RectItem;
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(3);
		GuideFocusNew value = this.View.GetFocusViewConf().Value;
		double x = horizontalLayout.RootUIComp.Get().D_K2_GetComponentScale().X;
		UUIItem rootItem = this.RootItem;
		float anchorOffsetX = value.TextOffset()[0];
		float anchorOffsetY = value.TextOffset()[1];
		if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Up)
		{
			float num = rectItem.Height + rootItem.Height;
			num *= 0.5f;
			rootItem.SetAnchorOffsetY(num);
		}
		else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Down)
		{
			float num = rectItem.Height + rootItem.Height;
			num *= 0.5f;
			rootItem.SetAnchorOffsetY(-num);
		}
		else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Left)
		{
			float num = (float)((double)rectItem.Width + (double)horizontalLayout.RootUIComp.Get().Width * x);
			num *= 0.5f;
			rootItem.SetAnchorOffsetX(-num);
		}
		else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Right)
		{
			float num = (float)((double)rectItem.Width + (double)horizontalLayout.RootUIComp.Get().Width * x);
			num *= 0.5f;
			rootItem.SetAnchorOffsetX(num);
		}
		else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.CenterTop)
		{
			FVectorDouble guideFocusCenterTextPos = GuideConfig.Instance.GetGuideFocusCenterTextPos();
			FHitResult fhitResult = new FHitResult();
			rootItem.D_K2_SetWorldLocation(guideFocusCenterTextPos, false, ref fhitResult, false);
		}
		else if ((EGuideFocusTextDir)value.ContentDirection == EGuideFocusTextDir.Float)
		{
			rootItem.SetAnchorOffsetX(anchorOffsetX);
			rootItem.SetAnchorOffsetY(anchorOffsetY);
		}
		UUIText text = base.GetText(7);
		if (text.GetWidth() > 1120f)
		{
			text.SetWidth(1120f);
			text.SetOverflowType(UITextOverflowType.VerticalOverflow);
		}
	}

	// Token: 0x0600BBFB RID: 48123 RVA: 0x00377EE8 File Offset: 0x003760E8
	private void ClampTextPosition()
	{
		if (this.ClampTxtInScreen && this.ClampDelay > 0)
		{
			int num = this.ClampDelay - 1;
			this.ClampDelay = num;
			if (num <= 0)
			{
				TWeakObjectPtr<UUIItem> rootUIComp = base.GetHorizontalLayout(3).RootUIComp;
				FVectorDouble fvectorDouble = rootUIComp.Get().D_K2_GetComponentLocation();
				FVectorDouble fvectorDouble2 = this.RootItem.D_K2_GetComponentLocation();
				FVectorDouble fvectorDouble3 = rootUIComp.Get().D_K2_GetComponentScale();
				double x = fvectorDouble3.X;
				double y = fvectorDouble3.Y;
				UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
				float width = uiRootItem.Width;
				float height = uiRootItem.Height;
				FVectorDouble fvectorDouble4 = uiRootItem.D_K2_GetComponentLocation();
				float num2 = width / 2f;
				float num3 = height / 2f;
				float width2 = rootUIComp.Get().Width;
				float height2 = rootUIComp.Get().Height;
				double num4 = fvectorDouble4.X - (double)num2 + (double)(rootUIComp.Get().GetPivot().X * width2 + 80f) * x;
				double num5 = fvectorDouble4.X + (double)num2 - (double)((1f - rootUIComp.Get().GetPivot().X) * width2 + 80f) * x;
				double num6 = fvectorDouble4.Y - (double)num3 + (double)(rootUIComp.Get().GetPivot().Y * height2 + 10f) * y;
				double num7 = fvectorDouble4.Y + (double)num3 - (double)((1f - rootUIComp.Get().GetPivot().Y) * height2 + 10f) * y;
				if (num4 > num5)
				{
					num4 += num5;
					num5 = num4 - num5;
					num4 -= num5;
				}
				if (num6 > num7)
				{
					num6 += num7;
					num7 = num6 - num7;
					num6 -= num7;
				}
				fvectorDouble.X = MathUtils.Instance.Clamp(fvectorDouble2.X, num4, num5);
				fvectorDouble.Y = MathUtils.Instance.Clamp(fvectorDouble.Y, num6, num7);
				FHitResult fhitResult = new FHitResult();
				rootUIComp.Get().D_K2_SetWorldLocation(fvectorDouble, false, ref fhitResult, false);
				base.GetVerticalLayout(0).SetEnable(false);
				return;
			}
		}
	}

	// Token: 0x0600BBFC RID: 48124 RVA: 0x003780F3 File Offset: 0x003762F3
	public void OnDurationChange(float remainDuration)
	{
		if (this.CountDownItem != null)
		{
			this.CountDownItem.OnDurationChange(remainDuration);
		}
	}

	// Token: 0x0600BBFD RID: 48125 RVA: 0x00378109 File Offset: 0x00376309
	public void OnBaseViewCloseWhenFinish()
	{
		GuideCountDownItem countDownItem = this.CountDownItem;
		if (countDownItem != null)
		{
			countDownItem.SetActive(false);
		}
		base.GetItem(9).SetUIActive(true);
	}

	// Token: 0x04006C24 RID: 27684
	private const float HorizontalScreenSpace = 80f;

	// Token: 0x04006C25 RID: 27685
	private const float VerticalScreenSpace = 10f;

	// Token: 0x04006C26 RID: 27686
	private const float MaxTextWidth = 1120f;

	// Token: 0x04006C27 RID: 27687
	private int ClampDelay;

	// Token: 0x04006C28 RID: 27688
	private bool ClampTxtInScreen = true;

	// Token: 0x04006C29 RID: 27689
	private GuideCountDownItem CountDownItem;

	// Token: 0x04006C2A RID: 27690
	private readonly GuideFocusView View;

	// Token: 0x04006C2B RID: 27691
	private readonly GuideFocusItem Owner;

	// Token: 0x02007524 RID: 29988
	[NullableContext(0)]
	private enum EFocusItemText
	{
		// Token: 0x04026116 RID: 155926
		Vertical,
		// Token: 0x04026117 RID: 155927
		Up,
		// Token: 0x04026118 RID: 155928
		Down,
		// Token: 0x04026119 RID: 155929
		Horizontal,
		// Token: 0x0402611A RID: 155930
		Left,
		// Token: 0x0402611B RID: 155931
		Right,
		// Token: 0x0402611C RID: 155932
		TextBg,
		// Token: 0x0402611D RID: 155933
		Text,
		// Token: 0x0402611E RID: 155934
		CountDown,
		// Token: 0x0402611F RID: 155935
		Toggle,
		// Token: 0x04026120 RID: 155936
		PanelRoleIcon,
		// Token: 0x04026121 RID: 155937
		RoleHead
	}
}
