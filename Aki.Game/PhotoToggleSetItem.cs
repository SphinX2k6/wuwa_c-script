using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002577 RID: 9591
public class PhotoToggleSetItem : PhotographSetupBase
{
	// Token: 0x060135F0 RID: 79344 RVA: 0x004D204C File Offset: 0x004D024C
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

	// Token: 0x060135F1 RID: 79345 RVA: 0x004D20DF File Offset: 0x004D02DF
	protected override void OnStart()
	{
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Combine(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x060135F2 RID: 79346 RVA: 0x004D2108 File Offset: 0x004D0308
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

	// Token: 0x060135F3 RID: 79347 RVA: 0x004D21A4 File Offset: 0x004D03A4
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

	// Token: 0x060135F4 RID: 79348 RVA: 0x004D21F8 File Offset: 0x004D03F8
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

	// Token: 0x060135F5 RID: 79349 RVA: 0x004D223C File Offset: 0x004D043C
	public override void SetSubItem(bool bSubItem)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bSubItem);
	}

	// Token: 0x060135F6 RID: 79350 RVA: 0x004D2250 File Offset: 0x004D0450
	public void RefreshSubOption()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		float valueOrDefault = PhotographModel.Instance.GetPhotographOption(this.SetupValueType).GetValueOrDefault();
		this.ApplySubOptions(valueOrDefault);
	}

	// Token: 0x060135F7 RID: 79351 RVA: 0x004D228C File Offset: 0x004D048C
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

	// Token: 0x060135F8 RID: 79352 RVA: 0x004D23A6 File Offset: 0x004D05A6
	protected override void OnBeforeDestroy()
	{
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Remove(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
	}

	// Token: 0x060135F9 RID: 79353 RVA: 0x004D23CE File Offset: 0x004D05CE
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

	// Token: 0x060135FA RID: 79354 RVA: 0x004D23EF File Offset: 0x004D05EF
	[NullableContext(1)]
	public void BindRefreshSubOptions(Action<List<EPhotoSetupValueType>, List<EPhotoSetupValueType>, EPhotoSubOptionBanType> callback)
	{
		this.RefreshSubOptions = callback;
	}

	// Token: 0x040091E4 RID: 37348
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<List<EPhotoSetupValueType>, List<EPhotoSetupValueType>, EPhotoSubOptionBanType> RefreshSubOptions;

	// Token: 0x02008B6B RID: 35691
	private enum EComponents
	{
		// Token: 0x0402D454 RID: 185428
		TextSettingTitle,
		// Token: 0x0402D455 RID: 185429
		ToggleRoot,
		// Token: 0x0402D456 RID: 185430
		ItemSelectedBg,
		// Token: 0x0402D457 RID: 185431
		ItemSubIconBg
	}
}
