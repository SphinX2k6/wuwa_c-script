using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001295 RID: 4757
[NullableContext(1)]
[Nullable(0)]
public class ChipHandBookItem : UiPanelBase, IDynamicScrollItem<HandBookChipDynamicData>
{
	// Token: 0x0600BC88 RID: 48264 RVA: 0x0037B9C4 File Offset: 0x00379BC4
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

	// Token: 0x0600BC89 RID: 48265 RVA: 0x0037BA10 File Offset: 0x00379C10
	private UniTask InitChildItem()
	{
		ChipHandBookItem.<InitChildItem>d__5 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<ChipHandBookItem.<InitChildItem>d__5>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600BC8A RID: 48266 RVA: 0x0037BA54 File Offset: 0x00379C54
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

	// Token: 0x0600BC8B RID: 48267 RVA: 0x0037BA9D File Offset: 0x00379C9D
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600BC8C RID: 48268 RVA: 0x0037BAA6 File Offset: 0x00379CA6
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BC8D RID: 48269 RVA: 0x0037BAE0 File Offset: 0x00379CE0
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

	// Token: 0x0600BC8E RID: 48270 RVA: 0x0037BB94 File Offset: 0x00379D94
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

	// Token: 0x0600BC8F RID: 48271 RVA: 0x0037BBB7 File Offset: 0x00379DB7
	public void BindChildToggleCallback(TChildChipToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
	}

	// Token: 0x0600BC90 RID: 48272 RVA: 0x0037BBC0 File Offset: 0x00379DC0
	public void BindToggleCallback(TChipToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x04006C5C RID: 27740
	[Nullable(2)]
	private HandBookChipToggleItem HandBookChipToggleItem;

	// Token: 0x04006C5D RID: 27741
	[Nullable(2)]
	private HandBookChipDesItem HandBookChipDesItem;

	// Token: 0x04006C5E RID: 27742
	[Nullable(2)]
	private TChipToggleFunction OnToggleCallback;

	// Token: 0x04006C5F RID: 27743
	[Nullable(2)]
	private TChildChipToggleFunction OnChildToggleCallback;
}
