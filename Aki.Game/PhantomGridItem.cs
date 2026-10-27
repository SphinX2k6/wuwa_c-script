using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200247C RID: 9340
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomGridItem : SyncGridProxyAbstract<PhantomInteractEditGridViewModel>
{
	// Token: 0x06012BE8 RID: 76776 RVA: 0x0049FC6C File Offset: 0x0049DE6C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x06012BE9 RID: 76777 RVA: 0x0049FC90 File Offset: 0x0049DE90
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

	// Token: 0x06012BEA RID: 76778 RVA: 0x0049FCE8 File Offset: 0x0049DEE8
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

	// Token: 0x06012BEB RID: 76779 RVA: 0x0049FD44 File Offset: 0x0049DF44
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, true);
	}

	// Token: 0x04008D2F RID: 36143
	[Nullable(2)]
	private PhantomInteractGridMediumItemGrid GridItem;

	// Token: 0x04008D30 RID: 36144
	public Action<IPhantomInteractGridViewModel, int> OnClickCb;
}
