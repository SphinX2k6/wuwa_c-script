using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020026B4 RID: 9908
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeLocatingHelper
{
	// Token: 0x060144D3 RID: 83155 RVA: 0x005218A3 File Offset: 0x0051FAA3
	public QuestTreeNodeLocatingHelper(UUIScrollViewComponent scroll)
	{
		this.Scroll = scroll;
	}

	// Token: 0x060144D4 RID: 83156 RVA: 0x005218CC File Offset: 0x0051FACC
	[NullableContext(2)]
	public void LocateToNode(UUIItem target, bool tween = false, bool useScreenAsRoot = false)
	{
		if (this.Scroll == null || target == null)
		{
			return;
		}
		this.Scroll.StopMovement();
		AUIBaseActor content = this.Scroll.GetContent();
		UUIItem uuiitem = (content != null) ? content.GetUIItem() : null;
		if (uuiitem == null)
		{
			return;
		}
		FVector lguispaceAbsolutePosition = target.GetLGUISpaceAbsolutePosition();
		FVector lguispaceAbsolutePosition2 = uuiitem.GetLGUISpaceAbsolutePosition();
		UUIItem uuiitem2 = useScreenAsRoot ? UiLayer.Instance.GetLayerRootUiItem(ELayerType.Normal) : this.Scroll.GetRootComponent();
		if (uuiitem2 == null)
		{
			return;
		}
		float width = uuiitem2.GetWidth();
		float height = uuiitem2.GetHeight();
		float x = uuiitem2.GetLGUISpaceAbsolutePosition().X;
		float y = uuiitem2.GetLGUISpaceAbsolutePosition().Y;
		float num = uuiitem.GetWidth() * uuiitem.RelativeScale3D.X;
		float num2 = uuiitem.GetHeight() * uuiitem.RelativeScale3D.Y;
		float min = x - Math.Max(num - width, 0f) - uuiitem2.GetPivot().X * width + uuiitem.GetPivot().X * num;
		float max = x - uuiitem2.GetPivot().X * width + uuiitem.GetPivot().X * num;
		float max2 = y + Math.Max(num2 - height, 0f) + uuiitem2.GetPivot().Y * height - uuiitem.GetPivot().Y * num2;
		float num3 = y + uuiitem2.GetPivot().Y * height - uuiitem.GetPivot().Y * num2;
		if (num2 < height)
		{
			num3 += (num2 - height) * 0.5f;
			max2 = num3;
		}
		float num4 = width * 0.5f - (0.5f - target.GetPivot().X) * target.GetWidth();
		float num5 = height * 0.5f - (0.5f - target.GetPivot().Y) * target.GetHeight();
		float currentValue = num4 - lguispaceAbsolutePosition.X + lguispaceAbsolutePosition2.X;
		float currentValue2 = num5 - lguispaceAbsolutePosition.Y + lguispaceAbsolutePosition2.Y;
		this.OffsetVector.X = MathUtils.Instance.Clamp(currentValue, min, max);
		this.OffsetVector.Y = MathUtils.Instance.Clamp(currentValue2, num3, max2);
		if (this.MoveTweener != null)
		{
			this.MoveTweener.Kill(false);
		}
		if (tween)
		{
			FVector translation = uuiitem.GetRelativeTransform().Translation;
			float num6 = this.OffsetVector.X - lguispaceAbsolutePosition2.X;
			float num7 = this.OffsetVector.Y - lguispaceAbsolutePosition2.Y;
			translation.X += num6;
			translation.Y += num7;
			this.MoveTweener = ULTweenBPLibrary.LocalPositionTo(uuiitem, translation, 0.5f, 0f, LTweenEase.OutCubic);
			return;
		}
		uuiitem.SetLGUISpaceAbsolutePosition(this.OffsetVector);
	}

	// Token: 0x060144D5 RID: 83157 RVA: 0x00521B71 File Offset: 0x0051FD71
	public void Clear()
	{
		if (this.MoveTweener != null)
		{
			this.MoveTweener.Kill(false);
			this.MoveTweener = null;
		}
	}

	// Token: 0x040098B7 RID: 39095
	private FVector OffsetVector = new FVector(0f, 0f, 0f);

	// Token: 0x040098B8 RID: 39096
	private readonly UUIScrollViewComponent Scroll;

	// Token: 0x040098B9 RID: 39097
	[Nullable(2)]
	public ULTweener MoveTweener;
}
