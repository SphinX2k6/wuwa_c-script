using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02002824 RID: 10276
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevSelectionMediumItemGrid : LoopScrollMediumItemGrid<RoleDisplayModelBase>
{
	// Token: 0x0601528E RID: 86670 RVA: 0x0055AED4 File Offset: 0x005590D4
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

	// Token: 0x0601528F RID: 86671 RVA: 0x0055AF8D File Offset: 0x0055918D
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06015290 RID: 86672 RVA: 0x0055AF97 File Offset: 0x00559197
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06015291 RID: 86673 RVA: 0x0055AFA1 File Offset: 0x005591A1
	public object GetKey()
	{
		return this.RoleId;
	}

	// Token: 0x04009E7F RID: 40575
	private int RoleId;
}
