using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001961 RID: 6497
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomGridItem : SyncGridProxyAbstract<PhantomInteractEditGridViewModel>
{
	// Token: 0x0601009F RID: 65695 RVA: 0x004AD3C4 File Offset: 0x004AB5C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x060100A0 RID: 65696 RVA: 0x004AD3E8 File Offset: 0x004AB5E8
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		UUIItem uuiitem = (extendToggle != null) ? extendToggle.GetRootComponent() : null;
		this.GridItem = new PhantomInteractGridMediumItemGrid();
		this.GridItem.CreateThenShowByActor(uuiitem.GetOwner(), null);
		this.GridItem.SetOnClickCallBack(delegate(IPhantomInteractGridViewModel data, int gridIndex)
		{
			this.OnClickCb(data, gridIndex);
		});
	}

	// Token: 0x060100A1 RID: 65697 RVA: 0x004AD440 File Offset: 0x004AB640
	public override void Refresh(PhantomInteractEditGridViewModel data)
	{
		if (data == null)
		{
			return;
		}
		if (data.IsSelected && PhantomInteractModel.Instance.CheckPhantomInteractUnlockRedDot(data.MonsterId))
		{
			PhantomInteractModel.Instance.SetPhantomInteractUnlockRedDot(data.MonsterId, false);
		}
		this.GridItem.Refresh(data, false, base.GridIndex);
		this.SetToggleState(data.IsSelected);
	}

	// Token: 0x060100A2 RID: 65698 RVA: 0x004AD49C File Offset: 0x004AB69C
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, true);
	}

	// Token: 0x04008E76 RID: 36470
	[Nullable(2)]
	private PhantomInteractGridMediumItemGrid GridItem;

	// Token: 0x04008E77 RID: 36471
	public Action<IPhantomInteractGridViewModel, int> OnClickCb;
}
