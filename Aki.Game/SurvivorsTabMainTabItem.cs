using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002080 RID: 8320
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsTabMainTabItem : CommonTabItemBase
{
	// Token: 0x06014887 RID: 84103 RVA: 0x005FBE3C File Offset: 0x005FA03C
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

	// Token: 0x06014888 RID: 84104 RVA: 0x005FBF11 File Offset: 0x005FA111
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014889 RID: 84105 RVA: 0x005FBF2C File Offset: 0x005FA12C
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

	// Token: 0x0601488A RID: 84106 RVA: 0x005FBF81 File Offset: 0x005FA181
	public void RefreshLevel(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x0601488B RID: 84107 RVA: 0x005FBFA4 File Offset: 0x005FA1A4
	public void RefreshUnlockWave(int unlockWave)
	{
		this.CachedUnlockWave = unlockWave;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "SurvivorsWeaponAttribute_WaveUnlockButton", new <>z__ReadOnlySingleElementList<object>(unlockWave));
	}

	// Token: 0x0601488C RID: 84108 RVA: 0x005FBFCE File Offset: 0x005FA1CE
	public void SetTextById(string textId)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(textId);
	}

	// Token: 0x0601488D RID: 84109 RVA: 0x005FBFE4 File Offset: 0x005FA1E4
	public void RefreshInfo(string iconPath, int level)
	{
		this.RefreshLevel(level);
		base.SetTextureByPath(iconPath, base.GetTexture(2), null, null);
	}

	// Token: 0x0601488E RID: 84110 RVA: 0x005FC010 File Offset: 0x005FA210
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

	// Token: 0x0601488F RID: 84111 RVA: 0x005FC09D File Offset: 0x005FA29D
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06014890 RID: 84112 RVA: 0x005FC09F File Offset: 0x005FA29F
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06014891 RID: 84113 RVA: 0x005FC0B2 File Offset: 0x005FA2B2
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0400AE15 RID: 44565
	private ETabState CachedState;

	// Token: 0x0400AE16 RID: 44566
	private int CachedUnlockWave = -1;
}
