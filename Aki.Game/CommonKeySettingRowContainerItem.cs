using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200202C RID: 8236
[NullableContext(1)]
[Nullable(0)]
public class CommonKeySettingRowContainerItem : UiPanelBase, IDynamicScrollItem<KeySettingRowData>
{
	// Token: 0x060102A0 RID: 66208 RVA: 0x003F0148 File Offset: 0x003EE348
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060102A1 RID: 66209 RVA: 0x003F01A4 File Offset: 0x003EE3A4
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

	// Token: 0x060102A2 RID: 66210 RVA: 0x003F0208 File Offset: 0x003EE408
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

	// Token: 0x060102A3 RID: 66211 RVA: 0x003F027C File Offset: 0x003EE47C
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

	// Token: 0x060102A4 RID: 66212 RVA: 0x003F02C8 File Offset: 0x003EE4C8
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

	// Token: 0x060102A5 RID: 66213 RVA: 0x003F0372 File Offset: 0x003EE572
	public void ClearItem()
	{
	}

	// Token: 0x060102A6 RID: 66214 RVA: 0x003F0374 File Offset: 0x003EE574
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

	// Token: 0x060102A7 RID: 66215 RVA: 0x003F03B8 File Offset: 0x003EE5B8
	private UniTask NewKeySettingRowKeyItem()
	{
		CommonKeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__11 <NewKeySettingRowKeyItem>d__;
		<NewKeySettingRowKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewKeySettingRowKeyItem>d__.<>4__this = this;
		<NewKeySettingRowKeyItem>d__.<>1__state = -1;
		<NewKeySettingRowKeyItem>d__.<>t__builder.Start<CommonKeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__11>(ref <NewKeySettingRowKeyItem>d__);
		return <NewKeySettingRowKeyItem>d__.<>t__builder.Task;
	}

	// Token: 0x060102A8 RID: 66216 RVA: 0x003F03FC File Offset: 0x003EE5FC
	private UniTask NewKeySettingRowTypeItem()
	{
		CommonKeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__12 <NewKeySettingRowTypeItem>d__;
		<NewKeySettingRowTypeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewKeySettingRowTypeItem>d__.<>4__this = this;
		<NewKeySettingRowTypeItem>d__.<>1__state = -1;
		<NewKeySettingRowTypeItem>d__.<>t__builder.Start<CommonKeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__12>(ref <NewKeySettingRowTypeItem>d__);
		return <NewKeySettingRowTypeItem>d__.<>t__builder.Task;
	}

	// Token: 0x060102A9 RID: 66217 RVA: 0x003F043F File Offset: 0x003EE63F
	private void SetToggleState(bool bChecked)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(bChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060102AA RID: 66218 RVA: 0x003F045D File Offset: 0x003EE65D
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

	// Token: 0x060102AB RID: 66219 RVA: 0x003F0485 File Offset: 0x003EE685
	private void OnHover()
	{
		KeySettingViewModel.HoverKey(this.KeySettingRowData);
	}

	// Token: 0x060102AC RID: 66220 RVA: 0x003F0492 File Offset: 0x003EE692
	private void OnUnHover()
	{
		KeySettingViewModel.UnHoverKey(this.KeySettingRowData);
	}

	// Token: 0x04007782 RID: 30594
	[Nullable(2)]
	public KeySettingRowData KeySettingRowData;

	// Token: 0x04007783 RID: 30595
	[Nullable(2)]
	private CommonKeySettingRowKeyItem KeySettingRowKeyItem;

	// Token: 0x04007784 RID: 30596
	[Nullable(2)]
	private CommonKeySettingRowTypeItem KeySettingRowTypeItem;

	// Token: 0x02008625 RID: 34341
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402BA74 RID: 178804
		public const int Toggle = 0;

		// Token: 0x0402BA75 RID: 178805
		public const int KeyTypeItem = 1;

		// Token: 0x0402BA76 RID: 178806
		public const int KeySettingItem = 2;
	}
}
