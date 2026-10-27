using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017EF RID: 6127
[NullableContext(2)]
[Nullable(0)]
public class LongPressButtonItem
{
	// Token: 0x0600B342 RID: 45890 RVA: 0x00288120 File Offset: 0x00286320
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

	// Token: 0x0600B343 RID: 45891 RVA: 0x00288180 File Offset: 0x00286380
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

	// Token: 0x0600B344 RID: 45892 RVA: 0x002882A0 File Offset: 0x002864A0
	public void Activate(LongPressButtonItem.ELongPressConfigId configId)
	{
		this.Config = CommonConfig.Instance.GetLongPressConfig((int)configId);
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.Tick), "LongPressComponent", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.TickId = ((ticker != null) ? ticker.Id : -1);
		this.IsPress = false;
	}

	// Token: 0x0600B345 RID: 45893 RVA: 0x002882F6 File Offset: 0x002864F6
	public void Deactivate()
	{
		this.IsPress = false;
		if (this.TickId != -1)
		{
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}
	}

	// Token: 0x0600B346 RID: 45894 RVA: 0x00288320 File Offset: 0x00286520
	public bool IsActivate()
	{
		return this.TickId != -1 && TickSystem.Instance.Has(this.TickId);
	}

	// Token: 0x0600B347 RID: 45895 RVA: 0x0028833D File Offset: 0x0028653D
	private void InteractiveChangeEvent(bool selfInteractive)
	{
		if (!selfInteractive)
		{
			this.IsPress = false;
		}
	}

	// Token: 0x0600B348 RID: 45896 RVA: 0x0028834C File Offset: 0x0028654C
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

	// Token: 0x0600B349 RID: 45897 RVA: 0x002883DE File Offset: 0x002865DE
	private void StopAudioEvent()
	{
		if (!StringUtils.IsBlank(this.ComponentName))
		{
			UiComponentUtil.UnBindAudioEventByName(this.ComponentName);
		}
	}

	// Token: 0x0600B34A RID: 45898 RVA: 0x002883F8 File Offset: 0x002865F8
	private bool CheckTickCondition()
	{
		Func<bool> tickConditionDelegate = this.TickConditionDelegate;
		return tickConditionDelegate == null || tickConditionDelegate();
	}

	// Token: 0x0600B34B RID: 45899 RVA: 0x0028840C File Offset: 0x0028660C
	private bool CheckDragging()
	{
		this.SubVector.DeepCopy(LguiEventSystemManager.Instance.GetPointerEventDataPosition(0));
		this.FirstPointDownPos.Subtraction(this.SubVector, this.SubVector);
		return this.SubVector.SizeSquared() >= 40000.0;
	}

	// Token: 0x0600B34C RID: 45900 RVA: 0x00288465 File Offset: 0x00286665
	private void Tick(float delta)
	{
		if (this.TickPreEnterLongPress(delta))
		{
			return;
		}
		this.TickLongPressAction(delta);
		this.TickAudioEvent(delta);
	}

	// Token: 0x0600B34D RID: 45901 RVA: 0x00288480 File Offset: 0x00286680
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

	// Token: 0x0600B34E RID: 45902 RVA: 0x0028862C File Offset: 0x0028682C
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

	// Token: 0x0600B34F RID: 45903 RVA: 0x0028867C File Offset: 0x0028687C
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

	// Token: 0x0600B350 RID: 45904 RVA: 0x00288700 File Offset: 0x00286900
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

	// Token: 0x0600B351 RID: 45905 RVA: 0x00288812 File Offset: 0x00286A12
	[NullableContext(1)]
	public void SetTickConditionDelegate(Func<bool> @delegate)
	{
		this.TickConditionDelegate = @delegate;
	}

	// Token: 0x0600B352 RID: 45906 RVA: 0x0028881B File Offset: 0x00286A1B
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

	// Token: 0x0600B353 RID: 45907 RVA: 0x0028883C File Offset: 0x00286A3C
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

	// Token: 0x0600B354 RID: 45908 RVA: 0x0028887C File Offset: 0x00286A7C
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

	// Token: 0x0600B355 RID: 45909 RVA: 0x00288950 File Offset: 0x00286B50
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

	// Token: 0x04005123 RID: 20771
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<UUIButtonComponent, UUIExtendToggle> LongPressComponent;

	// Token: 0x04005124 RID: 20772
	private LongPressConfig? Config;

	// Token: 0x04005125 RID: 20773
	private bool IsPress;

	// Token: 0x04005126 RID: 20774
	private int TickId = -1;

	// Token: 0x04005127 RID: 20775
	private float PressTime;

	// Token: 0x04005128 RID: 20776
	private float TickTime;

	// Token: 0x04005129 RID: 20777
	private float AudioTickTime;

	// Token: 0x0400512A RID: 20778
	private bool IsInFirstStage;

	// Token: 0x0400512B RID: 20779
	public string OverriddenLongPressAudioEvent;

	// Token: 0x0400512C RID: 20780
	public bool ShouldPlayLongPressSound;

	// Token: 0x0400512D RID: 20781
	private Action<bool> PointClickAction;

	// Token: 0x0400512E RID: 20782
	private Action OnPressCallback;

	// Token: 0x0400512F RID: 20783
	private Action OnReleaseCallback;

	// Token: 0x04005130 RID: 20784
	private Action OnCancelCallback;

	// Token: 0x04005131 RID: 20785
	private Func<bool> TickConditionDelegate;

	// Token: 0x04005132 RID: 20786
	[Nullable(1)]
	private readonly global::Vector FirstPointDownPos = global::Vector.Create();

	// Token: 0x04005133 RID: 20787
	[Nullable(1)]
	private readonly global::Vector SubVector = global::Vector.Create();

	// Token: 0x04005134 RID: 20788
	private string ComponentName;

	// Token: 0x04005135 RID: 20789
	private const int DRAG_TOLERANCE = 200;

	// Token: 0x04005136 RID: 20790
	private const int ONE_SECOND_TO_MILLISECOND = 1000;

	// Token: 0x04005137 RID: 20791
	[Nullable(1)]
	private const string LONG_PRESS_AUDIO_EVENT = "play_ui_com_slider_tick";

	// Token: 0x02007DDD RID: 32221
	[NullableContext(0)]
	public enum ELongPressConfigId
	{
		// Token: 0x0402931F RID: 168735
		LongPressOne = 1,
		// Token: 0x04029320 RID: 168736
		LongPressSecond,
		// Token: 0x04029321 RID: 168737
		LongPressThird,
		// Token: 0x04029322 RID: 168738
		LongPressFourth
	}
}
