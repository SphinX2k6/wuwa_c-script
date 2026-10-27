using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002B2E RID: 11054
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRoleTabItem : LoopScrollMediumItemGrid<SurvivorsHandbookItemDataBase>
{
	// Token: 0x06016F1E RID: 93982 RVA: 0x005D2D5C File Offset: 0x005D0F5C
	protected override void OnRefresh(SurvivorsHandbookItemDataBase data, bool isSelected, int gridIndex)
	{
		SurvivorsRole value = SurvivorsRogueConfig.Instance.GetSurvivorsRole(data.Id).Value;
		RoleInfo value2 = RoleConfig.Instance.GetRoleConfig(value.TrialRoleId).Value;
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			BottomTextId = value2.Name,
			IconPath = value2.RoleHeadIconBig,
			QualityId = new int?(value2.QualityId),
			IsProhibit = data.LockState,
			IsNewVisible = data.IsNew
		};
		base.SetElement(new int?(value2.ElementId));
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x06016F1F RID: 93983 RVA: 0x005D2E07 File Offset: 0x005D1007
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(this.GetItemGridExtendToggle().ToggleState);
		}
	}

	// Token: 0x06016F20 RID: 93984 RVA: 0x005D2E25 File Offset: 0x005D1025
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06016F21 RID: 93985 RVA: 0x005D2E2F File Offset: 0x005D102F
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<SurvivorsHandbookItemDataBase, SurvivorsRoleTabItem> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack((SurvivorsHandbookItemDataBase)this.Data, this);
	}

	// Token: 0x0400AAD4 RID: 43732
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsHandbookItemDataBase, SurvivorsRoleTabItem> OnClickCallBack;
}
