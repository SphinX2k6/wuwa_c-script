using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D69 RID: 3433
[NullableContext(2)]
[Nullable(0)]
public class InputKeyItem : UiPanelBase
{
	// Token: 0x06008CC8 RID: 36040 RVA: 0x002A9683 File Offset: 0x002A7883
	public InputKeyItem(string uniqueId = null)
	{
		this.UniqueId = uniqueId;
	}

	// Token: 0x06008CC9 RID: 36041 RVA: 0x002A9694 File Offset: 0x002A7894
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008CCA RID: 36042 RVA: 0x002A97C4 File Offset: 0x002A79C4
	protected override UniTask OnBeforeStartAsync()
	{
		InputKeyItem.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InputKeyItem.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008CCB RID: 36043 RVA: 0x002A9807 File Offset: 0x002A7A07
	protected override void OnBeforeShow()
	{
		if (!EventSystem.Instance.Has(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey)))
		{
			EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}
	}

	// Token: 0x06008CCC RID: 36044 RVA: 0x002A9842 File Offset: 0x002A7A42
	protected override void OnAfterHide()
	{
		if (EventSystem.Instance.Has(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey)))
		{
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}
	}

	// Token: 0x06008CCD RID: 36045 RVA: 0x002A987D File Offset: 0x002A7A7D
	protected override void OnBeforeDestroy()
	{
		this.LongPressProgressBar = null;
		this.DeactivateLongPress();
	}

	// Token: 0x06008CCE RID: 36046 RVA: 0x002A988C File Offset: 0x002A7A8C
	[NullableContext(1)]
	private void OnInputAnyKey(bool bPress, FKey key)
	{
		if (this.IsLongPressDisable)
		{
			return;
		}
		if (this.LongPressTime != null)
		{
			float? num = this.LongPressTime;
			float num2 = 0f;
			if (!(num.GetValueOrDefault() <= num2 & num != null))
			{
				if (string.IsNullOrEmpty(this.KeyName))
				{
					return;
				}
				string b = key.KeyName.ToString();
				if (this.KeyName != b)
				{
					return;
				}
				if (bPress)
				{
					if (this.DelayLongPressTime != null)
					{
						num = this.DelayLongPressTime;
						num2 = 0f;
						if (num.GetValueOrDefault() > num2 & num != null)
						{
							this.DelayPressTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
							{
								this.Press();
							}, this.DelayLongPressTime.Value, null, null, true, 1f);
							return;
						}
					}
					this.Press();
					return;
				}
				this.Release();
				return;
			}
		}
	}

	// Token: 0x06008CCF RID: 36047 RVA: 0x002A9974 File Offset: 0x002A7B74
	private void Press()
	{
		if (this.IsShowLongPressWhenPress)
		{
			this.ActivateLongPress();
		}
		this.SetLongPressProgressVisible(this.IsShowLongPressWhenPress);
		this.SetTextArrowVisible(this.IsShowTextArrowWhenPress);
	}

	// Token: 0x06008CD0 RID: 36048 RVA: 0x002A999C File Offset: 0x002A7B9C
	private void Release()
	{
		this.DeactivateLongPress();
		this.SetLongPressProgressVisible(this.IsShowLongPressWhenRelease);
		this.SetTextArrowVisible(this.IsShowTextArrowWhenRelease);
	}

	// Token: 0x06008CD1 RID: 36049 RVA: 0x002A99BC File Offset: 0x002A7BBC
	private void RemoveDelayPressTimer()
	{
		if (this.DelayPressTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.DelayPressTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.DelayPressTimerHandle);
		}
	}

	// Token: 0x06008CD2 RID: 36050 RVA: 0x002A99EC File Offset: 0x002A7BEC
	[NullableContext(1)]
	public void Refresh(InputKeyItemData data)
	{
		this.KeyName = data.KeyName;
		this.IsLongPressDisable = data.IsLongPressDisable.GetValueOrDefault();
		this.LongPressTime = data.LongPressTime;
		this.DelayLongPressTime = data.DelayPressTime;
		this.IsShowLongPressWhenPress = data.IsShowLongPressWhenPress.GetValueOrDefault();
		this.IsShowLongPressWhenRelease = data.IsShowLongPressWhenRelease.GetValueOrDefault();
		this.IsShowTextArrowWhenPress = data.IsShowTextArrowWhenPress.GetValueOrDefault();
		this.IsShowTextArrowWhenRelease = data.IsShowTextArrowWhenRelease.GetValueOrDefault();
		bool valueOrDefault = data.IsLongPressProcessVisible.GetValueOrDefault();
		bool valueOrDefault2 = data.IsTextArrowVisible.GetValueOrDefault();
		bool valueOrDefault3 = data.IsUpArrowVisible.GetValueOrDefault();
		bool valueOrDefault4 = data.IsDownArrowVisible.GetValueOrDefault();
		string descriptionId = data.DescriptionId;
		this.SetKeyTexture(this.KeyName);
		this.SetTextArrowVisible(valueOrDefault2);
		this.SetUpArrowVisible(valueOrDefault3);
		this.SetDownArrowVisible(valueOrDefault4);
		this.SetDescription(descriptionId);
		this.DeactivateLongPress();
		this.SetLongPressProgressVisible(valueOrDefault);
		if (valueOrDefault)
		{
			this.SetLongPressPercent(0f);
		}
	}

	// Token: 0x06008CD3 RID: 36051 RVA: 0x002A9AEE File Offset: 0x002A7CEE
	public void SetLongPressDisable(bool bDisable)
	{
		this.IsLongPressDisable = bDisable;
	}

	// Token: 0x06008CD4 RID: 36052 RVA: 0x002A9AF8 File Offset: 0x002A7CF8
	[NullableContext(1)]
	public void SetKeyTexture(string keyName)
	{
		string keyIconPath = InputSettings.Instance.GetKeyIconPath(keyName);
		if (this.CurrentDisplayKeyName == keyName && this.CurrentKeyIconPath == keyIconPath)
		{
			return;
		}
		this.CurrentDisplayKeyName = keyName;
		this.CurrentKeyIconPath = keyIconPath;
		UUITexture keyTexture = base.GetTexture(0);
		if (!string.IsNullOrEmpty(keyIconPath))
		{
			base.SetTextureByPath(keyIconPath, keyTexture, null, delegate(bool _)
			{
				UUITexture keyTexture2 = keyTexture;
				if (keyTexture2 != null)
				{
					keyTexture2.SetSizeFromTexture();
				}
				UUITexture keyTexture3 = keyTexture;
				if (keyTexture3 == null)
				{
					return;
				}
				keyTexture3.SetUIActive(true);
			});
			return;
		}
		UUITexture keyTexture4 = keyTexture;
		if (keyTexture4 == null)
		{
			return;
		}
		keyTexture4.SetUIActive(false);
	}

	// Token: 0x06008CD5 RID: 36053 RVA: 0x002A9B8B File Offset: 0x002A7D8B
	public void SetLongPressTime(float time)
	{
		this.LongPressTime = new float?(time);
	}

	// Token: 0x06008CD6 RID: 36054 RVA: 0x002A9B99 File Offset: 0x002A7D99
	public void SetLongPressPercent(float percent)
	{
		PcAndGamepadProgressBar longPressProgressBar = this.LongPressProgressBar;
		if (longPressProgressBar == null)
		{
			return;
		}
		longPressProgressBar.SetPercent(Math.Min(percent, 1f));
	}

	// Token: 0x06008CD7 RID: 36055 RVA: 0x002A9BB6 File Offset: 0x002A7DB6
	public void SetLongPressProgressVisible(bool bVisible)
	{
		PcAndGamepadProgressBar longPressProgressBar = this.LongPressProgressBar;
		if (longPressProgressBar == null)
		{
			return;
		}
		longPressProgressBar.SetProgressVisible(bVisible);
	}

	// Token: 0x06008CD8 RID: 36056 RVA: 0x002A9BC9 File Offset: 0x002A7DC9
	public void SetTextArrowVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(5);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x06008CD9 RID: 36057 RVA: 0x002A9BDD File Offset: 0x002A7DDD
	public void SetUpArrowVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(6);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x06008CDA RID: 36058 RVA: 0x002A9BF1 File Offset: 0x002A7DF1
	public void SetDownArrowVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(7);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x06008CDB RID: 36059 RVA: 0x002A9C08 File Offset: 0x002A7E08
	public void SetDescription(string descriptionId)
	{
		UUIText text = base.GetText(4);
		if (!string.IsNullOrEmpty(descriptionId))
		{
			LguiUtil.Instance.SetLocalTextNew(text, descriptionId, Array.Empty<object>());
			if (text != null)
			{
				text.SetUIActive(true);
				return;
			}
		}
		else if (text != null)
		{
			text.SetUIActive(false);
		}
	}

	// Token: 0x06008CDC RID: 36060 RVA: 0x002A9C4B File Offset: 0x002A7E4B
	private void ActivateLongPress()
	{
		this.CurrentPressTime = 0f;
		this.LongPressTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnLongPressRefresh), 20f, 1f, null, null, true);
	}

	// Token: 0x06008CDD RID: 36061 RVA: 0x002A9C84 File Offset: 0x002A7E84
	public void DeactivateLongPress()
	{
		if (this.LongPressTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.LongPressTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.LongPressTimerId);
			this.LongPressTimerId = null;
		}
		this.CurrentPressTime = 0f;
		this.RemoveDelayPressTimer();
	}

	// Token: 0x06008CDE RID: 36062 RVA: 0x002A9CD4 File Offset: 0x002A7ED4
	public void ResetLongPress()
	{
		this.DeactivateLongPress();
		this.SetLongPressPercent(0f);
		this.SetLongPressProgressVisible(false);
	}

	// Token: 0x06008CDF RID: 36063 RVA: 0x002A9CF0 File Offset: 0x002A7EF0
	private void OnLongPressRefresh(float _)
	{
		if (this.LongPressTime != null)
		{
			float? longPressTime = this.LongPressTime;
			float num = 0f;
			if (!(longPressTime.GetValueOrDefault() <= num & longPressTime != null))
			{
				float longPressPercent = this.CurrentPressTime / this.LongPressTime.Value;
				this.SetLongPressPercent(longPressPercent);
				this.CurrentPressTime += 20f;
				return;
			}
		}
	}

	// Token: 0x06008CE0 RID: 36064 RVA: 0x002A9D5B File Offset: 0x002A7F5B
	public void SetEnable(bool bEnable, bool bForce = false)
	{
		if (this.IsEnable == bEnable && !bForce)
		{
			return;
		}
		if (bEnable)
		{
			this.RootItem.SetAlpha(1f);
		}
		else
		{
			this.RootItem.SetAlpha(0.2f);
		}
		this.IsEnable = bEnable;
	}

	// Token: 0x06008CE1 RID: 36065 RVA: 0x002A9D96 File Offset: 0x002A7F96
	public string GetKeyName()
	{
		return this.KeyName;
	}

	// Token: 0x0400548A RID: 21642
	private string KeyName;

	// Token: 0x0400548B RID: 21643
	private string CurrentDisplayKeyName;

	// Token: 0x0400548C RID: 21644
	private string CurrentKeyIconPath;

	// Token: 0x0400548D RID: 21645
	private float? LongPressTime;

	// Token: 0x0400548E RID: 21646
	private float? DelayLongPressTime;

	// Token: 0x0400548F RID: 21647
	private bool IsShowLongPressWhenPress;

	// Token: 0x04005490 RID: 21648
	private bool IsShowLongPressWhenRelease;

	// Token: 0x04005491 RID: 21649
	private bool IsShowTextArrowWhenPress;

	// Token: 0x04005492 RID: 21650
	private bool IsShowTextArrowWhenRelease;

	// Token: 0x04005493 RID: 21651
	private PcAndGamepadProgressBar LongPressProgressBar;

	// Token: 0x04005494 RID: 21652
	private TimerHandle LongPressTimerId;

	// Token: 0x04005495 RID: 21653
	private float CurrentPressTime;

	// Token: 0x04005496 RID: 21654
	private bool IsEnable;

	// Token: 0x04005497 RID: 21655
	private TimerHandle DelayPressTimerHandle;

	// Token: 0x04005498 RID: 21656
	private bool IsLongPressDisable;

	// Token: 0x04005499 RID: 21657
	public readonly string UniqueId;

	// Token: 0x02006FC3 RID: 28611
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402482B RID: 149547
		public const int KeyTexture = 0;

		// Token: 0x0402482C RID: 149548
		public const int LongPressItem = 1;

		// Token: 0x0402482D RID: 149549
		public const int CircleLongPressItem = 2;

		// Token: 0x0402482E RID: 149550
		public const int SquareLongPressItem = 3;

		// Token: 0x0402482F RID: 149551
		public const int DescriptionText = 4;

		// Token: 0x04024830 RID: 149552
		public const int TextArrowTexture = 5;

		// Token: 0x04024831 RID: 149553
		public const int UpArrowTexture = 6;

		// Token: 0x04024832 RID: 149554
		public const int DownArrowTexture = 7;
	}
}
