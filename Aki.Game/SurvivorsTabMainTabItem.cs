using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002B04 RID: 11012
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsTabMainTabItem : CommonTabItemBase
{
	// Token: 0x06016E56 RID: 93782 RVA: 0x005CF2BC File Offset: 0x005CD4BC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick))
		};
	}

	// Token: 0x06016E57 RID: 93783 RVA: 0x005CF391 File Offset: 0x005CD591
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06016E58 RID: 93784 RVA: 0x005CF3AC File Offset: 0x005CD5AC
	public void RefreshTabState(ETabState state)
	{
		this.CachedState = state;
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(state == ETabState.Lock);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(state == ETabState.Normal);
		}
		UUIItem item3 = base.GetItem(0);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(state == ETabState.None);
	}

	// Token: 0x06016E59 RID: 93785 RVA: 0x005CF401 File Offset: 0x005CD601
	public void RefreshLevel(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x06016E5A RID: 93786 RVA: 0x005CF424 File Offset: 0x005CD624
	public void RefreshUnlockWave(int unlockWave)
	{
		this.CachedUnlockWave = unlockWave;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "SurvivorsWeaponAttribute_WaveUnlockButton", new <>z__ReadOnlySingleElementList<object>(unlockWave));
	}

	// Token: 0x06016E5B RID: 93787 RVA: 0x005CF44E File Offset: 0x005CD64E
	public void SetTextById(string textId)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(textId);
	}

	// Token: 0x06016E5C RID: 93788 RVA: 0x005CF464 File Offset: 0x005CD664
	public void RefreshInfo(string iconPath, int level)
	{
		this.RefreshLevel(level);
		base.SetTextureByPath(iconPath, base.GetTexture(2), null, null);
	}

	// Token: 0x06016E5D RID: 93789 RVA: 0x005CF490 File Offset: 0x005CD690
	private void ToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		switch (this.CachedState)
		{
		case ETabState.None:
			base.SetForceSwitch(EToggleState.ETT_UnChecked, false);
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsCombat_WeaponNoUsed", Array.Empty<object>());
			return;
		case ETabState.Lock:
			base.SetForceSwitch(EToggleState.ETT_UnChecked, false);
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsWeaponAttribute_WaveUnlockTips", new object[]
			{
				this.CachedUnlockWave
			});
			return;
		case ETabState.Normal:
		{
			Action<int> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack == null)
			{
				return;
			}
			selectedCallBack(base.GridIndex);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x06016E5E RID: 93790 RVA: 0x005CF51D File Offset: 0x005CD71D
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06016E5F RID: 93791 RVA: 0x005CF51F File Offset: 0x005CD71F
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06016E60 RID: 93792 RVA: 0x005CF532 File Offset: 0x005CD732
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0400AA0F RID: 43535
	private ETabState CachedState;

	// Token: 0x0400AA10 RID: 43536
	private int CachedUnlockWave = -1;
}
