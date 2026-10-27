using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DC7 RID: 7623
[NullableContext(2)]
[Nullable(0)]
public class FocusItemText : UiPanelBase
{
	// Token: 0x0600E7D5 RID: 59349 RVA: 0x0036BB8E File Offset: 0x00369D8E
	[NullableContext(1)]
	public FocusItemText(GuideFocusItem owner)
	{
		this.Owner = owner;
		this.View = owner.Owner;
	}

	// Token: 0x0600E7D6 RID: 59350 RVA: 0x0036BBB0 File Offset: 0x00369DB0
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

	// Token: 0x0600E7D7 RID: 59351 RVA: 0x0036BD68 File Offset: 0x00369F68
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

	// Token: 0x0600E7D8 RID: 59352 RVA: 0x0036BDC9 File Offset: 0x00369FC9
	private void ReClampTextPosition(UUILayoutBase _)
	{
		this.ClampDelay = 1;
	}

	// Token: 0x0600E7D9 RID: 59353 RVA: 0x0036BDD4 File Offset: 0x00369FD4
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

	// Token: 0x0600E7DA RID: 59354 RVA: 0x0036BFD5 File Offset: 0x0036A1D5
	public void OnTick(float delta)
	{
		this.SetUpTextPosition();
		this.ClampTextPosition();
	}

	// Token: 0x0600E7DB RID: 59355 RVA: 0x0036BFE4 File Offset: 0x0036A1E4
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

	// Token: 0x0600E7DC RID: 59356 RVA: 0x0036C254 File Offset: 0x0036A454
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

	// Token: 0x0600E7DD RID: 59357 RVA: 0x0036C45F File Offset: 0x0036A65F
	public void OnDurationChange(float remainDuration)
	{
		if (this.CountDownItem != null)
		{
			this.CountDownItem.OnDurationChange(remainDuration);
		}
	}

	// Token: 0x0600E7DE RID: 59358 RVA: 0x0036C475 File Offset: 0x0036A675
	public void OnBaseViewCloseWhenFinish()
	{
		GuideCountDownItem countDownItem = this.CountDownItem;
		if (countDownItem != null)
		{
			countDownItem.SetActive(false);
		}
		base.GetItem(9).SetUIActive(true);
	}

	// Token: 0x04006B43 RID: 27459
	private const float HorizontalScreenSpace = 80f;

	// Token: 0x04006B44 RID: 27460
	private const float VerticalScreenSpace = 10f;

	// Token: 0x04006B45 RID: 27461
	private const float MaxTextWidth = 1120f;

	// Token: 0x04006B46 RID: 27462
	private int ClampDelay;

	// Token: 0x04006B47 RID: 27463
	private bool ClampTxtInScreen = true;

	// Token: 0x04006B48 RID: 27464
	private GuideCountDownItem CountDownItem;

	// Token: 0x04006B49 RID: 27465
	private readonly GuideFocusView View;

	// Token: 0x04006B4A RID: 27466
	private readonly GuideFocusItem Owner;

	// Token: 0x0200839C RID: 33692
	[NullableContext(0)]
	private enum EFocusItemText
	{
		// Token: 0x0402ADF0 RID: 175600
		Vertical,
		// Token: 0x0402ADF1 RID: 175601
		Up,
		// Token: 0x0402ADF2 RID: 175602
		Down,
		// Token: 0x0402ADF3 RID: 175603
		Horizontal,
		// Token: 0x0402ADF4 RID: 175604
		Left,
		// Token: 0x0402ADF5 RID: 175605
		Right,
		// Token: 0x0402ADF6 RID: 175606
		TextBg,
		// Token: 0x0402ADF7 RID: 175607
		Text,
		// Token: 0x0402ADF8 RID: 175608
		CountDown,
		// Token: 0x0402ADF9 RID: 175609
		Toggle,
		// Token: 0x0402ADFA RID: 175610
		PanelRoleIcon,
		// Token: 0x0402ADFB RID: 175611
		RoleHead
	}
}
