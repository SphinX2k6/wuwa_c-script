using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D2B RID: 7467
[NullableContext(2)]
[Nullable(0)]
public class TrapDefenseMachineSelectSlider : UiPanelBase
{
	// Token: 0x0600E22E RID: 57902 RVA: 0x0035212D File Offset: 0x0035032D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent))
		};
	}

	// Token: 0x0600E22F RID: 57903 RVA: 0x00352168 File Offset: 0x00350368
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

	// Token: 0x0600E230 RID: 57904 RVA: 0x00352211 File Offset: 0x00350411
	protected override void OnBeforeDestroy()
	{
		if (this.Sequence != null)
		{
			this.Sequence.Clear();
			this.Sequence = null;
		}
	}

	// Token: 0x0600E231 RID: 57905 RVA: 0x0035222D File Offset: 0x0035042D
	private void OnTouchSliderValueChange(float value)
	{
		Action<float> sliderValueChangeNotify = this.SliderValueChangeNotify;
		if (sliderValueChangeNotify == null)
		{
			return;
		}
		sliderValueChangeNotify(value);
	}

	// Token: 0x0600E232 RID: 57906 RVA: 0x00352240 File Offset: 0x00350440
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

	// Token: 0x0600E233 RID: 57907 RVA: 0x003522D0 File Offset: 0x003504D0
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

	// Token: 0x0600E234 RID: 57908 RVA: 0x00352394 File Offset: 0x00350594
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

	// Token: 0x0600E235 RID: 57909 RVA: 0x003523FC File Offset: 0x003505FC
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

	// Token: 0x0600E236 RID: 57910 RVA: 0x00352449 File Offset: 0x00350649
	public void SetSliderValue(float value, bool bFireEvent)
	{
		this.Slider.SetValue(value, bFireEvent);
	}

	// Token: 0x0600E237 RID: 57911 RVA: 0x00352458 File Offset: 0x00350658
	public void RefreshSliderMaxValue(float maxValue)
	{
		this.Slider.SetMaxValue(maxValue, true, false);
	}

	// Token: 0x0400689C RID: 26780
	private const float INTERVAL = 0.0225f;

	// Token: 0x0400689D RID: 26781
	protected UiSequencePlayer Sequence;

	// Token: 0x0400689E RID: 26782
	protected double Index;

	// Token: 0x0400689F RID: 26783
	[Nullable(1)]
	private readonly Vector2D LastDragPos = Vector2D.Create();

	// Token: 0x040068A0 RID: 26784
	[Nullable(1)]
	private readonly Vector2D CurDragPos = Vector2D.Create();

	// Token: 0x040068A1 RID: 26785
	[Nullable(1)]
	private readonly Vector2D TempVector2D = Vector2D.Create();

	// Token: 0x040068A2 RID: 26786
	private bool IsNeedEndAnim;

	// Token: 0x040068A3 RID: 26787
	[Nullable(1)]
	private UUISliderComponent Slider;

	// Token: 0x040068A4 RID: 26788
	public Action SliderPointerDownNotify;

	// Token: 0x040068A5 RID: 26789
	public Action<float> SliderValueChangeNotify;

	// Token: 0x040068A6 RID: 26790
	public Action SliderEndDragNotify;

	// Token: 0x0200832F RID: 33583
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC8C RID: 175244
		public const int TouchSlider = 0;

		// Token: 0x0402AC8D RID: 175245
		public const int TouchSliderDrag = 1;
	}
}
