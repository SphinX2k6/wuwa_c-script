using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x020020AA RID: 8362
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRoleTabItem : LoopScrollMediumItemGrid<SurvivorsHandbookItemDataBase>
{
	// Token: 0x0601494F RID: 84303 RVA: 0x005FF8D0 File Offset: 0x005FDAD0
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

	// Token: 0x06014950 RID: 84304 RVA: 0x005FF97B File Offset: 0x005FDB7B
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(this.GetItemGridExtendToggle().ToggleState);
		}
	}

	// Token: 0x06014951 RID: 84305 RVA: 0x005FF999 File Offset: 0x005FDB99
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06014952 RID: 84306 RVA: 0x005FF9A3 File Offset: 0x005FDBA3
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<SurvivorsHandbookItemDataBase, SurvivorsRoleTabItem> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack((SurvivorsHandbookItemDataBase)this.Data, this);
	}

	// Token: 0x0400AEDA RID: 44762
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsHandbookItemDataBase, SurvivorsRoleTabItem> OnClickCallBack;
}
