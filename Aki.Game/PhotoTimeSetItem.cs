using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A4E RID: 6734
public class PhotoTimeSetItem : UiPanelBase
{
	// Token: 0x060109E5 RID: 68069 RVA: 0x004DCE7C File Offset: 0x004DB07C
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

	// Token: 0x060109E6 RID: 68070 RVA: 0x004DCEEC File Offset: 0x004DB0EC
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

	// Token: 0x060109E7 RID: 68071 RVA: 0x004DCF41 File Offset: 0x004DB141
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

	// Token: 0x060109E8 RID: 68072 RVA: 0x004DCF74 File Offset: 0x004DB174
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

	// Token: 0x060109E9 RID: 68073 RVA: 0x004DCFEC File Offset: 0x004DB1EC
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

	// Token: 0x060109EA RID: 68074 RVA: 0x004DD044 File Offset: 0x004DB244
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

	// Token: 0x060109EB RID: 68075 RVA: 0x004DD09F File Offset: 0x004DB29F
	[NullableContext(2)]
	private PhotoCameraEffectComponent GetEffectComponent()
	{
		return PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
	}

	// Token: 0x060109EC RID: 68076 RVA: 0x004DD0AC File Offset: 0x004DB2AC
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

	// Token: 0x04009307 RID: 37639
	private int CurrentHour = -1;

	// Token: 0x04009308 RID: 37640
	private const float APPLY_DELAY = 200f;

	// Token: 0x04009309 RID: 37641
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x02007CC5 RID: 31941
	private enum EComponents
	{
		// Token: 0x04028664 RID: 165476
		TextTitle,
		// Token: 0x04028665 RID: 165477
		TextTime,
		// Token: 0x04028666 RID: 165478
		Slider,
		// Token: 0x04028667 RID: 165479
		SpriteHandle
	}
}
