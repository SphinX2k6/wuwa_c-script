using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001A62 RID: 6754
public class PhotoToggleSetItem : PhotographSetupBase
{
	// Token: 0x06010AD3 RID: 68307 RVA: 0x004E0CB4 File Offset: 0x004DEEB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleStateChanged))
		};
	}

	// Token: 0x06010AD4 RID: 68308 RVA: 0x004E0D47 File Offset: 0x004DEF47
	protected override void OnStart()
	{
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Combine(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x06010AD5 RID: 68309 RVA: 0x004E0D70 File Offset: 0x004DEF70
	public override void Refresh()
	{
		if (this.SetupConfig == null || this.SetupConfig.Value.Type != 0)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.SetupConfig.Value.Name, Array.Empty<object>());
		bool flag = PhotographModel.Instance.GetPhotographOption(this.SetupValueType).GetValueOrDefault() == 1f;
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		this.RefreshSelectedBg(flag);
	}

	// Token: 0x06010AD6 RID: 68310 RVA: 0x004E0E0C File Offset: 0x004DF00C
	private void OnToggleStateChanged(EToggleState state)
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		int num = (state == EToggleState.ETT_Checked) ? 1 : 0;
		this.RefreshSelectedBg(num == 1);
		PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, (float)num, false, true);
		this.ApplySubOptions((float)num);
	}

	// Token: 0x06010AD7 RID: 68311 RVA: 0x004E0E60 File Offset: 0x004DF060
	private void RefreshSelectedBg(bool isOn)
	{
		bool flag = this.SetupConfig != null && this.SetupConfig.GetValueOrDefault().SubOptionsLength > 0;
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isOn && flag);
	}

	// Token: 0x06010AD8 RID: 68312 RVA: 0x004E0EA4 File Offset: 0x004DF0A4
	public override void SetSubItem(bool bSubItem)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bSubItem);
	}

	// Token: 0x06010AD9 RID: 68313 RVA: 0x004E0EB8 File Offset: 0x004DF0B8
	public void RefreshSubOption()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		float valueOrDefault = PhotographModel.Instance.GetPhotographOption(this.SetupValueType).GetValueOrDefault();
		this.ApplySubOptions(valueOrDefault);
	}

	// Token: 0x06010ADA RID: 68314 RVA: 0x004E0EF4 File Offset: 0x004DF0F4
	private void ApplySubOptions(float currentIndex)
	{
		if (this.SetupConfig == null || this.RefreshSubOptions == null)
		{
			return;
		}
		int subOptionsLength = this.SetupConfig.Value.SubOptionsLength;
		List<EPhotoSetupValueType> list = new List<EPhotoSetupValueType>();
		List<EPhotoSetupValueType> list2 = new List<EPhotoSetupValueType>();
		for (int i = 0; i < subOptionsLength; i++)
		{
			DicIntIntArray? dicIntIntArray = this.SetupConfig.Value.SubOptions(i);
			if (dicIntIntArray != null)
			{
				IntArray? intArray;
				int[] array = (dicIntIntArray.Value.Value != null) ? intArray.GetValueOrDefault().GetArrayIntArray() : null;
				if (array != null)
				{
					bool flag = (float)dicIntIntArray.Value.Key == currentIndex;
					foreach (EPhotoSetupValueType item in array)
					{
						list.Add(item);
						if (flag)
						{
							list2.Add(item);
						}
					}
				}
			}
		}
		EPhotoSubOptionBanType subOptionBanType = (EPhotoSubOptionBanType)this.SetupConfig.Value.SubOptionBanType;
		this.RefreshSubOptions(list, list2, subOptionBanType);
	}

	// Token: 0x06010ADB RID: 68315 RVA: 0x004E100E File Offset: 0x004DF20E
	protected override void OnBeforeDestroy()
	{
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Remove(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x06010ADC RID: 68316 RVA: 0x004E1036 File Offset: 0x004DF236
	private void OnPhotographOptionChanged(EPhotoSetupValueType valueType, float value)
	{
		if (!this.IsInCurrentMode)
		{
			return;
		}
		if (valueType != this.SetupValueType)
		{
			return;
		}
		this.Refresh();
		this.RefreshSubOption();
	}

	// Token: 0x06010ADD RID: 68317 RVA: 0x004E1057 File Offset: 0x004DF257
	[NullableContext(1)]
	public void BindRefreshSubOptions(Action<List<EPhotoSetupValueType>, List<EPhotoSetupValueType>, EPhotoSubOptionBanType> callback)
	{
		this.RefreshSubOptions = callback;
	}

	// Token: 0x0400933D RID: 37693
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<List<EPhotoSetupValueType>, List<EPhotoSetupValueType>, EPhotoSubOptionBanType> RefreshSubOptions;

	// Token: 0x02007CF1 RID: 31985
	private enum EComponents
	{
		// Token: 0x04028761 RID: 165729
		TextSettingTitle,
		// Token: 0x04028762 RID: 165730
		ToggleRoot,
		// Token: 0x04028763 RID: 165731
		ItemSelectedBg,
		// Token: 0x04028764 RID: 165732
		ItemSubIconBg
	}
}
