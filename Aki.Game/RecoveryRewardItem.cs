using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000F0A RID: 3850
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RecoveryRewardItem : LoopScrollSmallItemGrid<DangoAbyssDefine.IRecoveryRewardData>
{
	// Token: 0x06009A2E RID: 39470 RVA: 0x002DB710 File Offset: 0x002D9910
	protected override void OnRefresh(DangoAbyssDefine.IRecoveryRewardData data, bool isSelected, int gridIndex)
	{
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.ItemId),
			BottomText = data.Count.ToString()
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06009A2F RID: 39471 RVA: 0x002DB753 File Offset: 0x002D9953
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06009A30 RID: 39472 RVA: 0x002DB758 File Offset: 0x002D9958
	protected override void OnExtendToggleClicked()
	{
		DangoAbyssDefine.IRecoveryRewardData recoveryRewardData = this.Data as DangoAbyssDefine.IRecoveryRewardData;
		ItemController.Instance.OpenItemTipsByItemId(recoveryRewardData.ItemId, true, null, false);
	}
}
