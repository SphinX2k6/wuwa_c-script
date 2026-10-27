using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02002B59 RID: 11097
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsTeamEditRoleItemGird : LoopScrollMediumItemGrid<SurvivorsRoleData>
{
	// Token: 0x06017031 RID: 94257 RVA: 0x005D7E64 File Offset: 0x005D6064
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

	// Token: 0x06017032 RID: 94258 RVA: 0x005D7F1D File Offset: 0x005D611D
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06017033 RID: 94259 RVA: 0x005D7F27 File Offset: 0x005D6127
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}
}
