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

// Token: 0x020018B0 RID: 6320
[NullableContext(2)]
[Nullable(0)]
public class InputKeyItem : UiPanelBase
{
	// Token: 0x0600B8DF RID: 47327 RVA: 0x0029EF63 File Offset: 0x0029D163
	public InputKeyItem(string uniqueId = null)
	{
		this.UniqueId = uniqueId;
	}

	// Token: 0x0600B8E0 RID: 47328 RVA: 0x0029EF74 File Offset: 0x0029D174
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

	// Token: 0x0600B8E1 RID: 47329 RVA: 0x0029F0A4 File Offset: 0x0029D2A4
	protected override UniTask OnBeforeStartAsync()
	{
		InputKeyItem.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InputKeyItem.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B8E2 RID: 47330 RVA: 0x0029F0E7 File Offset: 0x0029D2E7
	protected override void OnBeforeShow()
	{
		if (!EventSystem.Instance.Has(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey)))
		{
			EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}
	}

	// Token: 0x0600B8E3 RID: 47331 RVA: 0x0029F122 File Offset: 0x0029D322
	protected override void OnAfterHide()
	{
		if (EventSystem.Instance.Has(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey)))
		{
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}
	}

	// Token: 0x0600B8E4 RID: 47332 RVA: 0x0029F15D File Offset: 0x0029D35D
	protected override void OnBeforeDestroy()
	{
		this.LongPressProgressBar = null;
		this.DeactivateLongPress();
	}

	// Token: 0x0600B8E5 RID: 47333 RVA: 0x0029F16C File Offset: 0x0029D36C
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

	// Token: 0x0600B8E6 RID: 47334 RVA: 0x0029F254 File Offset: 0x0029D454
	private void Press()
	{
		if (this.IsShowLongPressWhenPress)
		{
			this.ActivateLongPress();
		}
		this.SetLongPressProgressVisible(this.IsShowLongPressWhenPress);
		this.SetTextArrowVisible(this.IsShowTextArrowWhenPress);
	}

	// Token: 0x0600B8E7 RID: 47335 RVA: 0x0029F27C File Offset: 0x0029D47C
	private void Release()
	{
		this.DeactivateLongPress();
		this.SetLongPressProgressVisible(this.IsShowLongPressWhenRelease);
		this.SetTextArrowVisible(this.IsShowTextArrowWhenRelease);
	}

	// Token: 0x0600B8E8 RID: 47336 RVA: 0x0029F29C File Offset: 0x0029D49C
	private void RemoveDelayPressTimer()
	{
		if (this.DelayPressTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.DelayPressTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.DelayPressTimerHandle);
		}
	}

	// Token: 0x0600B8E9 RID: 47337 RVA: 0x0029F2CC File Offset: 0x0029D4CC
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

	// Token: 0x0600B8EA RID: 47338 RVA: 0x0029F3CE File Offset: 0x0029D5CE
	public void SetLongPressDisable(bool bDisable)
	{
		this.IsLongPressDisable = bDisable;
	}

	// Token: 0x0600B8EB RID: 47339 RVA: 0x0029F3D8 File Offset: 0x0029D5D8
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

	// Token: 0x0600B8EC RID: 47340 RVA: 0x0029F46B File Offset: 0x0029D66B
	public void SetLongPressTime(float time)
	{
		this.LongPressTime = new float?(time);
	}

	// Token: 0x0600B8ED RID: 47341 RVA: 0x0029F479 File Offset: 0x0029D679
	public void SetLongPressPercent(float percent)
	{
		PcAndGamepadProgressBar longPressProgressBar = this.LongPressProgressBar;
		if (longPressProgressBar == null)
		{
			return;
		}
		longPressProgressBar.SetPercent(Math.Min(percent, 1f));
	}

	// Token: 0x0600B8EE RID: 47342 RVA: 0x0029F496 File Offset: 0x0029D696
	public void SetLongPressProgressVisible(bool bVisible)
	{
		PcAndGamepadProgressBar longPressProgressBar = this.LongPressProgressBar;
		if (longPressProgressBar == null)
		{
			return;
		}
		longPressProgressBar.SetProgressVisible(bVisible);
	}

	// Token: 0x0600B8EF RID: 47343 RVA: 0x0029F4A9 File Offset: 0x0029D6A9
	public void SetTextArrowVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(5);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x0600B8F0 RID: 47344 RVA: 0x0029F4BD File Offset: 0x0029D6BD
	public void SetUpArrowVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(6);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x0600B8F1 RID: 47345 RVA: 0x0029F4D1 File Offset: 0x0029D6D1
	public void SetDownArrowVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(7);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x0600B8F2 RID: 47346 RVA: 0x0029F4E8 File Offset: 0x0029D6E8
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

	// Token: 0x0600B8F3 RID: 47347 RVA: 0x0029F52B File Offset: 0x0029D72B
	private void ActivateLongPress()
	{
		this.CurrentPressTime = 0f;
		this.LongPressTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnLongPressRefresh), 20f, 1f, null, null, true);
	}

	// Token: 0x0600B8F4 RID: 47348 RVA: 0x0029F564 File Offset: 0x0029D764
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

	// Token: 0x0600B8F5 RID: 47349 RVA: 0x0029F5B4 File Offset: 0x0029D7B4
	public void ResetLongPress()
	{
		this.DeactivateLongPress();
		this.SetLongPressPercent(0f);
		this.SetLongPressProgressVisible(false);
	}

	// Token: 0x0600B8F6 RID: 47350 RVA: 0x0029F5D0 File Offset: 0x0029D7D0
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

	// Token: 0x0600B8F7 RID: 47351 RVA: 0x0029F63B File Offset: 0x0029D83B
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

	// Token: 0x0600B8F8 RID: 47352 RVA: 0x0029F676 File Offset: 0x0029D876
	public string GetKeyName()
	{
		return this.KeyName;
	}

	// Token: 0x040053DF RID: 21471
	private string KeyName;

	// Token: 0x040053E0 RID: 21472
	private string CurrentDisplayKeyName;

	// Token: 0x040053E1 RID: 21473
	private string CurrentKeyIconPath;

	// Token: 0x040053E2 RID: 21474
	private float? LongPressTime;

	// Token: 0x040053E3 RID: 21475
	private float? DelayLongPressTime;

	// Token: 0x040053E4 RID: 21476
	private bool IsShowLongPressWhenPress;

	// Token: 0x040053E5 RID: 21477
	private bool IsShowLongPressWhenRelease;

	// Token: 0x040053E6 RID: 21478
	private bool IsShowTextArrowWhenPress;

	// Token: 0x040053E7 RID: 21479
	private bool IsShowTextArrowWhenRelease;

	// Token: 0x040053E8 RID: 21480
	private PcAndGamepadProgressBar LongPressProgressBar;

	// Token: 0x040053E9 RID: 21481
	private TimerHandle LongPressTimerId;

	// Token: 0x040053EA RID: 21482
	private float CurrentPressTime;

	// Token: 0x040053EB RID: 21483
	private bool IsEnable;

	// Token: 0x040053EC RID: 21484
	private TimerHandle DelayPressTimerHandle;

	// Token: 0x040053ED RID: 21485
	private bool IsLongPressDisable;

	// Token: 0x040053EE RID: 21486
	public readonly string UniqueId;

	// Token: 0x02007E3C RID: 32316
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040294FE RID: 169214
		public const int KeyTexture = 0;

		// Token: 0x040294FF RID: 169215
		public const int LongPressItem = 1;

		// Token: 0x04029500 RID: 169216
		public const int CircleLongPressItem = 2;

		// Token: 0x04029501 RID: 169217
		public const int SquareLongPressItem = 3;

		// Token: 0x04029502 RID: 169218
		public const int DescriptionText = 4;

		// Token: 0x04029503 RID: 169219
		public const int TextArrowTexture = 5;

		// Token: 0x04029504 RID: 169220
		public const int UpArrowTexture = 6;

		// Token: 0x04029505 RID: 169221
		public const int DownArrowTexture = 7;
	}
}
