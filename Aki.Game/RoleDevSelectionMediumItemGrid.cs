using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001D9F RID: 7583
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevSelectionMediumItemGrid : LoopScrollMediumItemGrid<RoleDisplayModelBase>
{
	// Token: 0x06012C8C RID: 76940 RVA: 0x00585BE8 File Offset: 0x00583DE8
	protected override void OnRefresh(RoleDisplayModelBase data, bool isSelected, int gridIndex)
	{
		this.RoleId = data.Id;
		if (data.TypeTag == ERoleTypeTag.Forecast)
		{
			ForecastCharacterMediumItemGrid parameters = new ForecastCharacterMediumItemGrid
			{
				Data = data,
				BottomText = data.Name
			};
			base.Apply<ForecastCharacterMediumItemGrid>(parameters);
		}
		else
		{
			CharacterMediumItemGrid parameters2 = new CharacterMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.Id),
				SkinId = data.SkinId,
				BottomText = data.Name,
				IsInTeam = new bool?(false),
				ElementId = new int?(data.ElementId),
				IsTrialRoleVisible = new bool?(data.IsTrial)
			};
			base.Apply<CharacterMediumItemGrid>(parameters2);
		}
		this.SetSelected(isSelected, false);
	}

	// Token: 0x06012C8D RID: 76941 RVA: 0x00585CA1 File Offset: 0x00583EA1
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06012C8E RID: 76942 RVA: 0x00585CAB File Offset: 0x00583EAB
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06012C8F RID: 76943 RVA: 0x00585CB5 File Offset: 0x00583EB5
	public object GetKey()
	{
		return this.RoleId;
	}

	// Token: 0x0400A268 RID: 41576
	private int RoleId;
}
