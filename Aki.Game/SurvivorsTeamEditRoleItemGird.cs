using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020020D5 RID: 8405
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsTeamEditRoleItemGird : LoopScrollMediumItemGrid<SurvivorsRoleData>
{
	// Token: 0x06014A62 RID: 84578 RVA: 0x006049D0 File Offset: 0x00602BD0
	protected override void OnRefresh(SurvivorsRoleData data, bool isSelected, int gridIndex)
	{
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetRoleId()),
			BottomText = data.GetName(null),
			IsNewVisible = new bool?(false),
			IsDisable = new bool?(!data.IsUnLock),
			IsLockVisible = new bool?(!data.IsUnLock),
			IconPath = data.IconPath,
			QualityId = new int?(data.QualityId)
		};
		base.Apply<PropMediumItemGrid>(parameters);
		this.SetSelected(isSelected, false);
		base.SetElement(new int?(data.GetRoleConfig().ElementId));
	}

	// Token: 0x06014A63 RID: 84579 RVA: 0x00604A89 File Offset: 0x00602C89
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06014A64 RID: 84580 RVA: 0x00604A93 File Offset: 0x00602C93
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}
}
