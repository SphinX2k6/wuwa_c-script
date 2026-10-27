using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DD3 RID: 7635
[NullableContext(1)]
[Nullable(0)]
public class ChipHandBookItem : UiPanelBase, IDynamicScrollItem<HandBookChipDynamicData>
{
	// Token: 0x0600E869 RID: 59497 RVA: 0x0036FCD8 File Offset: 0x0036DED8
	public UniTask Init(UUIItem actor)
	{
		ChipHandBookItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ChipHandBookItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600E86A RID: 59498 RVA: 0x0036FD24 File Offset: 0x0036DF24
	private UniTask InitChildItem()
	{
		ChipHandBookItem.<InitChildItem>d__5 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<ChipHandBookItem.<InitChildItem>d__5>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600E86B RID: 59499 RVA: 0x0036FD68 File Offset: 0x0036DF68
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(HandBookChipDynamicData data)
	{
		int? handBookChipConfigId = data.HandBookChipConfigId;
		if (handBookChipConfigId != null && handBookChipConfigId.GetValueOrDefault() != 0)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(0).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600E86C RID: 59500 RVA: 0x0036FDB1 File Offset: 0x0036DFB1
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600E86D RID: 59501 RVA: 0x0036FDBA File Offset: 0x0036DFBA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600E86E RID: 59502 RVA: 0x0036FDF4 File Offset: 0x0036DFF4
	public void Update(HandBookChipDynamicData data, int gridIndex)
	{
		HandBookChipDesItem handBookChipDesItem = this.HandBookChipDesItem;
		if (handBookChipDesItem != null)
		{
			handBookChipDesItem.SetUiActive(false);
		}
		HandBookChipToggleItem handBookChipToggleItem = this.HandBookChipToggleItem;
		if (handBookChipToggleItem != null)
		{
			handBookChipToggleItem.SetUiActive(false);
		}
		int? handBookChipConfigId = data.HandBookChipConfigId;
		if (handBookChipConfigId == null || handBookChipConfigId.GetValueOrDefault() == 0)
		{
			if (data.HandBookCommonItemData != null)
			{
				HandBookChipToggleItem handBookChipToggleItem2 = this.HandBookChipToggleItem;
				if (handBookChipToggleItem2 != null)
				{
					handBookChipToggleItem2.SetUiActive(true);
				}
				HandBookChipToggleItem handBookChipToggleItem3 = this.HandBookChipToggleItem;
				if (handBookChipToggleItem3 == null)
				{
					return;
				}
				handBookChipToggleItem3.Refresh(data.HandBookCommonItemData, data.IsShowContent);
			}
			return;
		}
		HandBookChipDesItem handBookChipDesItem2 = this.HandBookChipDesItem;
		if (handBookChipDesItem2 != null)
		{
			handBookChipDesItem2.SetUiActive(true);
		}
		HandBookChipDesItem handBookChipDesItem3 = this.HandBookChipDesItem;
		if (handBookChipDesItem3 == null)
		{
			return;
		}
		handBookChipDesItem3.Refresh(data.HandBookChipConfigId.Value, data.IsShowContent);
	}

	// Token: 0x0600E86F RID: 59503 RVA: 0x0036FEA8 File Offset: 0x0036E0A8
	public void RefreshNewState()
	{
		HandBookChipToggleItem handBookChipToggleItem = this.HandBookChipToggleItem;
		if (handBookChipToggleItem != null)
		{
			handBookChipToggleItem.RefreshNewState();
		}
		HandBookChipDesItem handBookChipDesItem = this.HandBookChipDesItem;
		if (handBookChipDesItem == null)
		{
			return;
		}
		handBookChipDesItem.RefreshNewState();
	}

	// Token: 0x0600E870 RID: 59504 RVA: 0x0036FECB File Offset: 0x0036E0CB
	public void BindChildToggleCallback(TChildChipToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
	}

	// Token: 0x0600E871 RID: 59505 RVA: 0x0036FED4 File Offset: 0x0036E0D4
	public void BindToggleCallback(TChipToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x04006B7B RID: 27515
	[Nullable(2)]
	private HandBookChipToggleItem HandBookChipToggleItem;

	// Token: 0x04006B7C RID: 27516
	[Nullable(2)]
	private HandBookChipDesItem HandBookChipDesItem;

	// Token: 0x04006B7D RID: 27517
	[Nullable(2)]
	private TChipToggleFunction OnToggleCallback;

	// Token: 0x04006B7E RID: 27518
	[Nullable(2)]
	private TChildChipToggleFunction OnChildToggleCallback;
}
