using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FCB RID: 8139
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FlySkinGridItem : LoopScrollSmallItemGrid<FlySkinGridData>
{
	// Token: 0x0601431C RID: 82716 RVA: 0x005E3C24 File Offset: 0x005E1E24
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		FlySkinGridData flySkinGridData = this.Data as FlySkinGridData;
		if (flySkinGridData.GetIsNew())
		{
			NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.FlySkinRedDot, flySkinGridData.SkinId);
			base.SetNewFlagVisible(new bool?(false));
			EventSystem.Instance.Emit<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, flySkinGridData.SkinType);
			FlySkinController.Instance.UpdateAllRoleSkinRedDot();
		}
	}

	// Token: 0x0601431D RID: 82717 RVA: 0x005E3C8C File Offset: 0x005E1E8C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0601431E RID: 82718 RVA: 0x005E3C98 File Offset: 0x005E1E98
	protected override void OnRefresh(FlySkinGridData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			IconPath = (data.IsEmptyData ? SkinConfig.Instance.GetDefaultFlySkinIconPath(data.SkinType) : null),
			ItemConfigId = (data.IsEmptyData ? null : new int?(data.SkinId)),
			IsNewVisible = new bool?(data.GetIsNew()),
			IsLockVisibleBlack = new bool?(data.GetIsLock())
		};
		base.Apply<PropSmallItemGrid>(parameters);
		this.SetSelected(isSelected, false);
		this.RefreshEquipState();
		base.SetRoleHead(null);
	}

	// Token: 0x0601431F RID: 82719 RVA: 0x005E3D44 File Offset: 0x005E1F44
	public void RefreshEquipState()
	{
		FlySkinGridData flySkinGridData = this.Data as FlySkinGridData;
		base.SetSelectVisible(flySkinGridData.IsCurrentEquipSkinId());
	}
}
