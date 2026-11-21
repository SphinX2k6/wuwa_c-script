using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CA8 RID: 3240
[NullableContext(2)]
[Nullable(0)]
public class LongPressButtonItem
{
	// Token: 0x0600872C RID: 34604 RVA: 0x002927F4 File Offset: 0x002909F4
	[NullableContext(1)]
	public LongPressButtonItem([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<UUIButtonComponent, UUIExtendToggle>? longPressComponent = null, LongPressButtonItem.ELongPressConfigId? configId = null, Action<bool> pointClickAction = null)
	{
		if (longPressComponent != null)
		{
			this.Initialize(longPressComponent.Value, pointClickAction, null, null, null);
		}
		if (configId != null)
		{
			this.Activate(configId.Value);
		}
	}

	// Token: 0x0600872D RID: 34605 RVA: 0x00292854 File Offset: 0x00290A54
	public void Initialize([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<UUIButtonComponent, UUIExtendToggle> longPressComponent, Action<bool> pointClickAction = null, Action onPressCallback = null, Action onReleaseCallback = null, Action onCancelCallback = null)
	{
		this.LongPressComponent = longPressComponent;
		if (this.LongPressComponent.IsT1)
		{
			UUIButtonComponent asT = this.LongPressComponent.AsT1;
			asT.OnPointDownCallBack.Bind(delegate()
			{
				this.IsInFirstStage = true;
				this.IsPress = true;
				this.FirstPointDownPos.DeepCopy(LguiEventSystemManager.Instance.GetPointerEventDataPosition(0));
				Action onPressCallback2 = this.OnPressCallback;
				if (onPressCallback2 == null)
				{
					return;
				}
				onPressCallback2();
			});
			asT.OnPointCancelCallBack.Bind(delegate()
			{
				this.IsPress = false;
				this.PressTime = 0f;
				this.TickTime = 0f;
				Action onCancelCallback2 = this.OnCancelCallback;
				if (onCancelCallback2 == null)
				{
					return;
				}
				onCancelCallback2();
			});
			asT.OnPointUpCallBack.Bind(delegate()
			{
				this.IsPress = false;
				Action onReleaseCallback2 = this.OnReleaseCallback;
				if (onReleaseCallback2 == null)
				{
					return;
				}
				onReleaseCallback2();
			});
			asT.OnSelfInteractiveChanged.Bind(new Action<bool>(this.InteractiveChangeEvent));
		}
		else if (this.LongPressComponent.IsT2)
		{
			UUIExtendToggle asT2 = this.LongPressComponent.AsT2;
			asT2.OnPointDownCallBack.Bind(delegate(EToggleState _)
			{
				this.IsInFirstStage = true;
				this.IsPress = true;
				this.FirstPointDownPos.DeepCopy(LguiEventSystemManager.Instance.GetPointerEventDataPosition(0));
				Action onPressCallback2 = this.OnPressCallback;
				if (onPressCallback2 == null)
				{
					return;
				}
				onPressCallback2();
			});
			asT2.OnPointCancelCallBack.Bind(delegate(EToggleState _)
			{
				this.IsPress = false;
				this.PressTime = 0f;
				this.TickTime = 0f;
				Action onCancelCallback2 = this.OnCancelCallback;
				if (onCancelCallback2 == null)
				{
					return;
				}
				onCancelCallback2();
			});
			asT2.OnPointUpCallBack.Bind(delegate(EToggleState _)
			{
				this.IsPress = false;
				Action onReleaseCallback2 = this.OnReleaseCallback;
				if (onReleaseCallback2 == null)
				{
					return;
				}
				onReleaseCallback2();
			});
			asT2.OnSelfInteractiveChanged.Bind(new Action<bool>(this.InteractiveChangeEvent));
		}
		this.PointClickAction = pointClickAction;
		this.OnPressCallback = onPressCallback;
		this.OnReleaseCallback = onReleaseCallback;
		this.OnCancelCallback = onCancelCallback;
		this.BindAudioEvent();
	}

	// Token: 0x0600872E RID: 34606 RVA: 0x00292974 File Offset: 0x00290B74
	public void Activate(LongPressButtonItem.ELongPressConfigId configId)
	{
		this.Config = CommonConfig.Instance.GetLongPressConfig((int)configId);
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.Tick), "LongPressComponent", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.TickId = ((ticker != null) ? ticker.Id : -1);
		this.IsPress = false;
	}

	// Token: 0x0600872F RID: 34607 RVA: 0x002929CA File Offset: 0x00290BCA
	public void Deactivate()
	{
		this.IsPress = false;
		if (this.TickId != -1)
		{
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}
	}

	// Token: 0x06008730 RID: 34608 RVA: 0x002929F4 File Offset: 0x00290BF4
	public bool IsActivate()
	{
		return this.TickId != -1 && TickSystem.Instance.Has(this.TickId);
	}

	// Token: 0x06008731 RID: 34609 RVA: 0x00292A11 File Offset: 0x00290C11
	private void InteractiveChangeEvent(bool selfInteractive)
	{
		if (!selfInteractive)
		{
			this.IsPress = false;
		}
	}

	// Token: 0x06008732 RID: 34610 RVA: 0x00292A20 File Offset: 0x00290C20
	private void BindAudioEvent()
	{
		if (!this.LongPressComponent.HasValue)
		{
			return;
		}
		string componentName;
		if (!this.LongPressComponent.IsT1)
		{
			AActor owner = this.LongPressComponent.AsT2.GetOwner();
			componentName = ((owner != null) ? owner.GetName() : null);
		}
		else
		{
			AActor owner2 = this.LongPressComponent.AsT1.GetOwner();
			componentName = ((owner2 != null) ? owner2.GetName() : null);
		}
		this.ComponentName = componentName;
		UiComponentUtil.BindAudioEvent(this.LongPressComponent.IsT1 ? this.LongPressComponent.AsT1 : this.LongPressComponent.AsT2);
	}

	// Token: 0x06008733 RID: 34611 RVA: 0x00292AB2 File Offset: 0x00290CB2
	private void StopAudioEvent()
	{
		if (!StringUtils.IsBlank(this.ComponentName))
		{
			UiComponentUtil.UnBindAudioEventByName(this.ComponentName);
		}
	}

	// Token: 0x06008734 RID: 34612 RVA: 0x00292ACC File Offset: 0x00290CCC
	private bool CheckTickCondition()
	{
		Func<bool> tickConditionDelegate = this.TickConditionDelegate;
		return tickConditionDelegate == null || tickConditionDelegate();
	}

	// Token: 0x06008735 RID: 34613 RVA: 0x00292AE0 File Offset: 0x00290CE0
	private bool CheckDragging()
	{
		this.SubVector.DeepCopy(LguiEventSystemManager.Instance.GetPointerEventDataPosition(0));
		this.FirstPointDownPos.Subtraction(this.SubVector, this.SubVector);
		return this.SubVector.SizeSquared() >= 40000.0;
	}

	// Token: 0x06008736 RID: 34614 RVA: 0x00292B39 File Offset: 0x00290D39
	private void Tick(float delta)
	{
		if (this.TickPreEnterLongPress(delta))
		{
			return;
		}
		this.TickLongPressAction(delta);
		this.TickAudioEvent(delta);
	}

	// Token: 0x06008737 RID: 34615 RVA: 0x00292B54 File Offset: 0x00290D54
	private bool TickPreEnterLongPress(float delta)
	{
		int? num;
		float? num2;
		if (!this.IsPress)
		{
			float pressTime = this.PressTime;
			num = ((this.Config != null) ? new int?(this.Config.GetValueOrDefault().PressTime(0)) : null);
			num2 = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			if ((pressTime < num2.GetValueOrDefault() & num2 != null) && this.PressTime > 0f)
			{
				Action<bool> pointClickAction = this.PointClickAction;
				if (pointClickAction != null)
				{
					pointClickAction(true);
				}
			}
			this.PressTime = 0f;
			this.TickTime = 0f;
			this.AudioTickTime = 0f;
			return true;
		}
		if (!this.CheckTickCondition())
		{
			this.PressTime = 1f;
			return true;
		}
		if (this.CheckDragging())
		{
			this.IsPress = false;
			this.PressTime = 0f;
			this.TickTime = 0f;
			this.AudioTickTime = 0f;
			return true;
		}
		this.PressTime += delta;
		float pressTime2 = this.PressTime;
		num = ((this.Config != null) ? new int?(this.Config.GetValueOrDefault().PressTime(0)) : null);
		num2 = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
		if (pressTime2 < num2.GetValueOrDefault() & num2 != null)
		{
			return true;
		}
		if (this.IsInFirstStage)
		{
			this.IsInFirstStage = false;
			Action<bool> pointClickAction2 = this.PointClickAction;
			if (pointClickAction2 != null)
			{
				pointClickAction2(true);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06008738 RID: 34616 RVA: 0x00292D00 File Offset: 0x00290F00
	private void TickLongPressAction(float delta)
	{
		this.TickTime += delta;
		int triggerTime = this.GetTriggerTime();
		if (this.TickTime < (float)triggerTime)
		{
			return;
		}
		this.TickTime -= (float)triggerTime;
		Action<bool> pointClickAction = this.PointClickAction;
		if (pointClickAction == null)
		{
			return;
		}
		pointClickAction(false);
	}

	// Token: 0x06008739 RID: 34617 RVA: 0x00292D50 File Offset: 0x00290F50
	private void TickAudioEvent(float delta)
	{
		if (!this.ShouldPlayLongPressSound)
		{
			return;
		}
		this.AudioTickTime += delta;
		int num = Math.Max(this.GetTriggerTime(), (this.Config != null) ? this.Config.GetValueOrDefault().AudioIntervalLimit : 0);
		if (this.AudioTickTime >= (float)num)
		{
			AudioSystem.Instance.PostEvent(this.OverriddenLongPressAudioEvent ?? "play_ui_com_slider_tick");
			this.AudioTickTime -= (float)num;
		}
	}

	// Token: 0x0600873A RID: 34618 RVA: 0x00292DD4 File Offset: 0x00290FD4
	private int GetTriggerTime()
	{
		if (this.Config == null)
		{
			return 0;
		}
		int num = (this.Config != null) ? this.Config.GetValueOrDefault().PressTimeLength : 1;
		for (int i = 1; i < num; i++)
		{
			float pressTime = this.PressTime;
			int? num2 = (this.Config != null) ? new int?(this.Config.GetValueOrDefault().PressTime(i)) : null;
			float? num3 = (num2 != null) ? new float?((float)num2.GetValueOrDefault()) : null;
			if (pressTime < num3.GetValueOrDefault() & num3 != null)
			{
				int num4 = (this.Config != null) ? this.Config.GetValueOrDefault().TriggerTime(i - 1) : 1;
				return 1000 / num4;
			}
		}
		int num5 = (this.Config != null) ? this.Config.GetValueOrDefault().TriggerTime(num - 1) : 1;
		return 1000 / num5;
	}

	// Token: 0x0600873B RID: 34619 RVA: 0x00292EE6 File Offset: 0x002910E6
	[NullableContext(1)]
	public void SetTickConditionDelegate(Func<bool> @delegate)
	{
		this.TickConditionDelegate = @delegate;
	}

	// Token: 0x0600873C RID: 34620 RVA: 0x00292EEF File Offset: 0x002910EF
	public void SetInteractive(bool value)
	{
		if (!this.LongPressComponent.HasValue)
		{
			return;
		}
		UUISelectableComponent selectableComp = this.GetSelectableComp();
		if (selectableComp == null)
		{
			return;
		}
		selectableComp.SetSelfInteractive(value);
	}

	// Token: 0x0600873D RID: 34621 RVA: 0x00292F10 File Offset: 0x00291110
	public void SetActive(bool value)
	{
		if (!this.LongPressComponent.HasValue)
		{
			return;
		}
		UUISelectableComponent selectableComp = this.GetSelectableComp();
		if (selectableComp == null)
		{
			return;
		}
		UUIItem uuiitem = selectableComp.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(value);
	}

	// Token: 0x0600873E RID: 34622 RVA: 0x00292F50 File Offset: 0x00291150
	public void Clear()
	{
		this.Deactivate();
		if (this.LongPressComponent.HasValue)
		{
			if (this.LongPressComponent.IsT1)
			{
				UUIButtonComponent asT = this.LongPressComponent.AsT1;
				asT.OnPointDownCallBack.Unbind();
				asT.OnPointCancelCallBack.Unbind();
				asT.OnPointUpCallBack.Unbind();
				asT.OnSelfInteractiveChanged.Unbind();
			}
			else if (this.LongPressComponent.IsT2)
			{
				UUIExtendToggle asT2 = this.LongPressComponent.AsT2;
				asT2.OnPointDownCallBack.Unbind();
				asT2.OnPointCancelCallBack.Unbind();
				asT2.OnPointUpCallBack.Unbind();
				asT2.OnSelfInteractiveChanged.Unbind();
			}
		}
		this.StopAudioEvent();
		this.LongPressComponent.Clear();
		this.PointClickAction = null;
		this.OnPressCallback = null;
		this.OnReleaseCallback = null;
	}

	// Token: 0x0600873F RID: 34623 RVA: 0x00293024 File Offset: 0x00291224
	private UUISelectableComponent GetSelectableComp()
	{
		if (!this.LongPressComponent.HasValue)
		{
			return null;
		}
		if (this.LongPressComponent.IsT1)
		{
			return this.LongPressComponent.AsT1;
		}
		if (this.LongPressComponent.IsT2)
		{
			return this.LongPressComponent.AsT2;
		}
		return null;
	}

	// Token: 0x040051CE RID: 20942
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<UUIButtonComponent, UUIExtendToggle> LongPressComponent;

	// Token: 0x040051CF RID: 20943
	private LongPressConfig? Config;

	// Token: 0x040051D0 RID: 20944
	private bool IsPress;

	// Token: 0x040051D1 RID: 20945
	private int TickId = -1;

	// Token: 0x040051D2 RID: 20946
	private float PressTime;

	// Token: 0x040051D3 RID: 20947
	private float TickTime;

	// Token: 0x040051D4 RID: 20948
	private float AudioTickTime;

	// Token: 0x040051D5 RID: 20949
	private bool IsInFirstStage;

	// Token: 0x040051D6 RID: 20950
	public string OverriddenLongPressAudioEvent;

	// Token: 0x040051D7 RID: 20951
	public bool ShouldPlayLongPressSound;

	// Token: 0x040051D8 RID: 20952
	private Action<bool> PointClickAction;

	// Token: 0x040051D9 RID: 20953
	private Action OnPressCallback;

	// Token: 0x040051DA RID: 20954
	private Action OnReleaseCallback;

	// Token: 0x040051DB RID: 20955
	private Action OnCancelCallback;

	// Token: 0x040051DC RID: 20956
	private Func<bool> TickConditionDelegate;

	// Token: 0x040051DD RID: 20957
	[Nullable(1)]
	private readonly global::Vector FirstPointDownPos = global::Vector.Create();

	// Token: 0x040051DE RID: 20958
	[Nullable(1)]
	private readonly global::Vector SubVector = global::Vector.Create();

	// Token: 0x040051DF RID: 20959
	private string ComponentName;

	// Token: 0x040051E0 RID: 20960
	private const int DRAG_TOLERANCE = 200;

	// Token: 0x040051E1 RID: 20961
	private const int ONE_SECOND_TO_MILLISECOND = 1000;

	// Token: 0x040051E2 RID: 20962
	[Nullable(1)]
	private const string LONG_PRESS_AUDIO_EVENT = "play_ui_com_slider_tick";

	// Token: 0x02006F63 RID: 28515
	[NullableContext(0)]
	public enum ELongPressConfigId
	{
		// Token: 0x0402464A RID: 149066
		LongPressOne = 1,
		// Token: 0x0402464B RID: 149067
		LongPressSecond,
		// Token: 0x0402464C RID: 149068
		LongPressThird,
		// Token: 0x0402464D RID: 149069
		LongPressFourth
	}
}
