using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02001A4B RID: 6731
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RecoveryRewardItem : LoopScrollSmallItemGrid<DangoAbyssDefine.IRecoveryRewardData>
{
	// Token: 0x0600C61E RID: 50718 RVA: 0x002D0614 File Offset: 0x002CE814
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

	// Token: 0x0600C61F RID: 50719 RVA: 0x002D0657 File Offset: 0x002CE857
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600C620 RID: 50720 RVA: 0x002D065C File Offset: 0x002CE85C
	protected override void OnExtendToggleClicked()
	{
		DangoAbyssDefine.IRecoveryRewardData recoveryRewardData = this.Data as DangoAbyssDefine.IRecoveryRewardData;
		ItemController.Instance.OpenItemTipsByItemId(recoveryRewardData.ItemId, true, null);
	}
}
