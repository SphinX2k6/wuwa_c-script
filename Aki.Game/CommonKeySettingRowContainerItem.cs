using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014FF RID: 5375
[NullableContext(1)]
[Nullable(0)]
public class CommonKeySettingRowContainerItem : UiPanelBase, IDynamicScrollItem<KeySettingRowData>
{
	// Token: 0x0600D708 RID: 55048 RVA: 0x003FC740 File Offset: 0x003FA940
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600D709 RID: 55049 RVA: 0x003FC79C File Offset: 0x003FA99C
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnStateChanged));
			extendToggle.OnHover.Add(new Action(this.OnHover));
			extendToggle.OnUnHover.Add(new Action(this.OnUnHover));
		}
		this.SetActive(true);
	}

	// Token: 0x0600D70A RID: 55050 RVA: 0x003FC800 File Offset: 0x003FAA00
	protected override void OnBeforeDestroy()
	{
		this.KeySettingRowData = null;
		this.KeySettingRowKeyItem = null;
		this.KeySettingRowTypeItem = null;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnStateChanged));
			extendToggle.OnHover.Remove(new Action(this.OnHover));
			extendToggle.OnUnHover.Remove(new Action(this.OnUnHover));
		}
	}

	// Token: 0x0600D70B RID: 55051 RVA: 0x003FC874 File Offset: 0x003FAA74
	public UniTask Init(UUIItem actor)
	{
		CommonKeySettingRowContainerItem.<Init>d__7 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<CommonKeySettingRowContainerItem.<Init>d__7>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600D70C RID: 55052 RVA: 0x003FC8C0 File Offset: 0x003FAAC0
	public void Update(KeySettingRowData data, int index)
	{
		this.KeySettingRowData = data;
		CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType = KeySettingViewModel.InputControllerType;
		EKeySettingRowType rowType = data.GetRowType();
		if (rowType != EKeySettingRowType.KeyType)
		{
			if (rowType == EKeySettingRowType.KeySetting)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle != null)
				{
					extendToggle.SetSelfInteractive(true);
				}
				this.KeySettingRowKeyItem.Refresh(data, inputControllerType);
				base.GetItem(2).SetUIActive(true);
				base.GetItem(1).SetUIActive(false);
			}
		}
		else
		{
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
			if (extendToggle2 != null)
			{
				extendToggle2.SetSelfInteractive(false);
			}
			this.KeySettingRowTypeItem.Refresh(data);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
		}
		this.SetToggleState(data.IsExpandDetail);
	}

	// Token: 0x0600D70D RID: 55053 RVA: 0x003FC96A File Offset: 0x003FAB6A
	public void ClearItem()
	{
	}

	// Token: 0x0600D70E RID: 55054 RVA: 0x003FC96C File Offset: 0x003FAB6C
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(KeySettingRowData data)
	{
		EKeySettingRowType rowType = data.GetRowType();
		if (rowType == EKeySettingRowType.KeyType)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
		if (rowType != EKeySettingRowType.KeySetting)
		{
			return null;
		}
		return base.GetItem(2).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600D70F RID: 55055 RVA: 0x003FC9B0 File Offset: 0x003FABB0
	private UniTask NewKeySettingRowKeyItem()
	{
		CommonKeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__11 <NewKeySettingRowKeyItem>d__;
		<NewKeySettingRowKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewKeySettingRowKeyItem>d__.<>4__this = this;
		<NewKeySettingRowKeyItem>d__.<>1__state = -1;
		<NewKeySettingRowKeyItem>d__.<>t__builder.Start<CommonKeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__11>(ref <NewKeySettingRowKeyItem>d__);
		return <NewKeySettingRowKeyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D710 RID: 55056 RVA: 0x003FC9F4 File Offset: 0x003FABF4
	private UniTask NewKeySettingRowTypeItem()
	{
		CommonKeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__12 <NewKeySettingRowTypeItem>d__;
		<NewKeySettingRowTypeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewKeySettingRowTypeItem>d__.<>4__this = this;
		<NewKeySettingRowTypeItem>d__.<>1__state = -1;
		<NewKeySettingRowTypeItem>d__.<>t__builder.Start<CommonKeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__12>(ref <NewKeySettingRowTypeItem>d__);
		return <NewKeySettingRowTypeItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D711 RID: 55057 RVA: 0x003FCA37 File Offset: 0x003FAC37
	private void SetToggleState(bool bChecked)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(bChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600D712 RID: 55058 RVA: 0x003FCA55 File Offset: 0x003FAC55
	private void OnStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_UnChecked)
		{
			CommonKeySettingRowKeyItem keySettingRowKeyItem = this.KeySettingRowKeyItem;
			if (keySettingRowKeyItem == null)
			{
				return;
			}
			keySettingRowKeyItem.SetDetailItemVisible(false);
			return;
		}
		else
		{
			CommonKeySettingRowKeyItem keySettingRowKeyItem2 = this.KeySettingRowKeyItem;
			if (keySettingRowKeyItem2 == null)
			{
				return;
			}
			keySettingRowKeyItem2.SetDetailItemVisible(true);
			return;
		}
	}

	// Token: 0x0600D713 RID: 55059 RVA: 0x003FCA7D File Offset: 0x003FAC7D
	private void OnHover()
	{
		KeySettingViewModel.HoverKey(this.KeySettingRowData);
	}

	// Token: 0x0600D714 RID: 55060 RVA: 0x003FCA8A File Offset: 0x003FAC8A
	private void OnUnHover()
	{
		KeySettingViewModel.UnHoverKey(this.KeySettingRowData);
	}

	// Token: 0x0400786B RID: 30827
	[Nullable(2)]
	public KeySettingRowData KeySettingRowData;

	// Token: 0x0400786C RID: 30828
	[Nullable(2)]
	private CommonKeySettingRowKeyItem KeySettingRowKeyItem;

	// Token: 0x0400786D RID: 30829
	[Nullable(2)]
	private CommonKeySettingRowTypeItem KeySettingRowTypeItem;

	// Token: 0x020077AC RID: 30636
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04026D83 RID: 159107
		public const int Toggle = 0;

		// Token: 0x04026D84 RID: 159108
		public const int KeyTypeItem = 1;

		// Token: 0x04026D85 RID: 159109
		public const int KeySettingItem = 2;
	}
}
