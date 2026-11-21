using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011ED RID: 4589
[NullableContext(2)]
[Nullable(0)]
public class TrapDefenseMachineSelectSlider : UiPanelBase
{
	// Token: 0x0600B64B RID: 46667 RVA: 0x0035DB5D File Offset: 0x0035BD5D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent))
		};
	}

	// Token: 0x0600B64C RID: 46668 RVA: 0x0035DB98 File Offset: 0x0035BD98
	protected override void OnStart()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.Slider = base.GetSlider(0);
		this.Slider.OnValueChangeCb.Bind(new Action<float>(this.OnTouchSliderValueChange));
		UUIDraggableComponent draggable = base.GetDraggable(1);
		draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnTouchSliderPointerDown));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnTouchSliderDrag));
		draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnTouchSliderPointerUp));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnTouchSliderEndDrag));
	}

	// Token: 0x0600B64D RID: 46669 RVA: 0x0035DC41 File Offset: 0x0035BE41
	protected override void OnBeforeDestroy()
	{
		if (this.Sequence != null)
		{
			this.Sequence.Clear();
			this.Sequence = null;
		}
	}

	// Token: 0x0600B64E RID: 46670 RVA: 0x0035DC5D File Offset: 0x0035BE5D
	private void OnTouchSliderValueChange(float value)
	{
		Action<float> sliderValueChangeNotify = this.SliderValueChangeNotify;
		if (sliderValueChangeNotify == null)
		{
			return;
		}
		sliderValueChangeNotify(value);
	}

	// Token: 0x0600B64F RID: 46671 RVA: 0x0035DC70 File Offset: 0x0035BE70
	private void OnTouchSliderPointerDown(ULGUIPointerEventData eventData)
	{
		UiSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.StopSequenceByKey("ClickOut", false, true);
		}
		UiSequencePlayer sequence2 = this.Sequence;
		if (sequence2 != null)
		{
			sequence2.PlaySequence("Click", false, null);
		}
		this.Index = (double)((float)Math.Floor((double)this.Slider.Value));
		this.IsNeedEndAnim = true;
		FVector pointerPosition = eventData.pointerPosition;
		LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, this.LastDragPos);
		Action sliderPointerDownNotify = this.SliderPointerDownNotify;
		if (sliderPointerDownNotify == null)
		{
			return;
		}
		sliderPointerDownNotify();
	}

	// Token: 0x0600B650 RID: 46672 RVA: 0x0035DD00 File Offset: 0x0035BF00
	private void OnTouchSliderDrag(ULGUIPointerEventData eventData)
	{
		FVector pointerPosition = eventData.pointerPosition;
		LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, this.CurDragPos);
		this.TempVector2D.DeepCopy(this.CurDragPos);
		this.TempVector2D.SubtractionEqual(this.LastDragPos);
		if (this.TempVector2D.X == 0.0)
		{
			return;
		}
		double num = this.TempVector2D.X * 0.02250000089406967 + this.Index;
		this.LastDragPos.DeepCopy(this.CurDragPos);
		if ((int)Math.Floor(num) == (int)this.Index)
		{
			this.Index = num;
			return;
		}
		this.Index = num;
		int num2 = (int)Math.Floor(this.Index);
		this.SetSliderValue((float)num2, true);
	}

	// Token: 0x0600B651 RID: 46673 RVA: 0x0035DDC4 File Offset: 0x0035BFC4
	private void OnTouchSliderPointerUp(ULGUIPointerEventData eventData)
	{
		if (!this.IsNeedEndAnim)
		{
			return;
		}
		this.IsNeedEndAnim = false;
		UiSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.StopSequenceByKey("Click", false, true);
		}
		UiSequencePlayer sequence2 = this.Sequence;
		if (sequence2 != null)
		{
			sequence2.PlaySequence("ClickOut", false, null);
		}
		Action sliderEndDragNotify = this.SliderEndDragNotify;
		if (sliderEndDragNotify == null)
		{
			return;
		}
		sliderEndDragNotify();
	}

	// Token: 0x0600B652 RID: 46674 RVA: 0x0035DE2C File Offset: 0x0035C02C
	private void OnTouchSliderEndDrag(ULGUIPointerEventData eventData)
	{
		if (!this.IsNeedEndAnim)
		{
			return;
		}
		this.IsNeedEndAnim = false;
		UiSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.PlaySequence("ClickOut", false, null);
		}
		Action sliderEndDragNotify = this.SliderEndDragNotify;
		if (sliderEndDragNotify == null)
		{
			return;
		}
		sliderEndDragNotify();
	}

	// Token: 0x0600B653 RID: 46675 RVA: 0x0035DE79 File Offset: 0x0035C079
	public void SetSliderValue(float value, bool bFireEvent)
	{
		this.Slider.SetValue(value, bFireEvent);
	}

	// Token: 0x0600B654 RID: 46676 RVA: 0x0035DE88 File Offset: 0x0035C088
	public void RefreshSliderMaxValue(float maxValue)
	{
		this.Slider.SetMaxValue(maxValue, true, false);
	}

	// Token: 0x0400697B RID: 27003
	private const float INTERVAL = 0.0225f;

	// Token: 0x0400697C RID: 27004
	protected UiSequencePlayer Sequence;

	// Token: 0x0400697D RID: 27005
	protected double Index;

	// Token: 0x0400697E RID: 27006
	[Nullable(1)]
	private readonly Vector2D LastDragPos = Vector2D.Create();

	// Token: 0x0400697F RID: 27007
	[Nullable(1)]
	private readonly Vector2D CurDragPos = Vector2D.Create();

	// Token: 0x04006980 RID: 27008
	[Nullable(1)]
	private readonly Vector2D TempVector2D = Vector2D.Create();

	// Token: 0x04006981 RID: 27009
	private bool IsNeedEndAnim;

	// Token: 0x04006982 RID: 27010
	[Nullable(1)]
	private UUISliderComponent Slider;

	// Token: 0x04006983 RID: 27011
	public Action SliderPointerDownNotify;

	// Token: 0x04006984 RID: 27012
	public Action<float> SliderValueChangeNotify;

	// Token: 0x04006985 RID: 27013
	public Action SliderEndDragNotify;

	// Token: 0x020074B8 RID: 29880
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025FB4 RID: 155572
		public const int TouchSlider = 0;

		// Token: 0x04025FB5 RID: 155573
		public const int TouchSliderDrag = 1;
	}
}
