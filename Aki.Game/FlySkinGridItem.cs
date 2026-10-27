using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A50 RID: 10832
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FlySkinGridItem : LoopScrollSmallItemGrid<FlySkinGridData>
{
	// Token: 0x060168FB RID: 92411 RVA: 0x005B7AE0 File Offset: 0x005B5CE0
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

	// Token: 0x060168FC RID: 92412 RVA: 0x005B7B48 File Offset: 0x005B5D48
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x060168FD RID: 92413 RVA: 0x005B7B54 File Offset: 0x005B5D54
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

	// Token: 0x060168FE RID: 92414 RVA: 0x005B7C00 File Offset: 0x005B5E00
	public void RefreshEquipState()
	{
		FlySkinGridData flySkinGridData = this.Data as FlySkinGridData;
		base.SetSelectVisible(flySkinGridData.IsCurrentEquipSkinId());
	}
}
