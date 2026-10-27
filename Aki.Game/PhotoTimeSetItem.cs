using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002563 RID: 9571
public class PhotoTimeSetItem : UiPanelBase
{
	// Token: 0x06013503 RID: 79107 RVA: 0x004CE244 File Offset: 0x004CC444
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
	}

	// Token: 0x06013504 RID: 79108 RVA: 0x004CE2B4 File Offset: 0x004CC4B4
	protected override void OnStart()
	{
		UUISliderComponent slider = base.GetSlider(2);
		if (slider != null)
		{
			slider.SetMinValue(0f, false, false);
		}
		if (slider != null)
		{
			slider.SetMaxValue(24f, false, false);
		}
		if (slider == null)
		{
			return;
		}
		slider.OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
	}

	// Token: 0x06013505 RID: 79109 RVA: 0x004CE309 File Offset: 0x004CC509
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(2);
		if (slider != null)
		{
			slider.OnValueChangeCb.Unbind();
		}
		TimerHandle timer = this.Timer;
		if (timer != null)
		{
			timer.Remove();
		}
		this.Timer = null;
	}

	// Token: 0x06013506 RID: 79110 RVA: 0x004CE33C File Offset: 0x004CC53C
	public void Refresh()
	{
		TimerHandle timer = this.Timer;
		if (timer != null)
		{
			timer.Remove();
		}
		this.Timer = null;
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		int num = (int)Math.Floor((double)((effectComponent != null) ? effectComponent.GetPhotoTime() : ((float)TodDayTime.ConvertToHour(TimeOfDayModel.Instance.GameTime.Second))));
		this.CurrentHour = num;
		this.SetTimeText(num);
		UUISliderComponent slider = base.GetSlider(2);
		if (slider == null)
		{
			return;
		}
		slider.SetValue((float)num, false);
	}

	// Token: 0x06013507 RID: 79111 RVA: 0x004CE3B4 File Offset: 0x004CC5B4
	private void OnValueChanged(float value)
	{
		int timeText = (int)Math.Round((double)value);
		this.SetTimeText(timeText);
		TimerHandle timer = this.Timer;
		if (timer != null)
		{
			timer.Remove();
		}
		this.Timer = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.OnChangeTime), 200f, null, null, true, 1f);
	}

	// Token: 0x06013508 RID: 79112 RVA: 0x004CE40C File Offset: 0x004CC60C
	private void OnChangeTime(float _)
	{
		this.Timer = null;
		UUISliderComponent slider = base.GetSlider(2);
		int num = (int)Math.Round((double)slider.Value);
		slider.SetValue((float)num, false);
		if (num == this.CurrentHour)
		{
			return;
		}
		this.CurrentHour = num;
		this.SetTimeText(num);
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent == null)
		{
			return;
		}
		effectComponent.SetPhotoTime((float)num);
	}

	// Token: 0x06013509 RID: 79113 RVA: 0x004CE467 File Offset: 0x004CC667
	[NullableContext(2)]
	private PhotoCameraEffectComponent GetEffectComponent()
	{
		return PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
	}

	// Token: 0x0601350A RID: 79114 RVA: 0x004CE474 File Offset: 0x004CC674
	private void SetTimeText(int hour)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(hour, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":00");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x040091AE RID: 37294
	private int CurrentHour = -1;

	// Token: 0x040091AF RID: 37295
	private const float APPLY_DELAY = 200f;

	// Token: 0x040091B0 RID: 37296
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x02008B3F RID: 35647
	private enum EComponents
	{
		// Token: 0x0402D357 RID: 185175
		TextTitle,
		// Token: 0x0402D358 RID: 185176
		TextTime,
		// Token: 0x0402D359 RID: 185177
		Slider,
		// Token: 0x0402D35A RID: 185178
		SpriteHandle
	}
}
