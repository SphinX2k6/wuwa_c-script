using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SolarSchool;

// Token: 0x02001FF5 RID: 8181
public class SolarSchoolQuestRewardItemGrid : SmallItemGrid
{
	// Token: 0x06014461 RID: 83041 RVA: 0x005E8A5C File Offset: 0x005E6C5C
	public void Refresh(int showItemId, int count)
	{
		this.ShowItemId = showItemId;
		SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(showItemId);
		if (item == null)
		{
			return;
		}
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.IconPath = item.Value.Icon;
		propSmallItemGrid.IsQualityHidden = new bool?(true);
		string bottomText;
		if (count <= 0)
		{
			bottomText = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propSmallItemGrid.BottomText = bottomText;
		PropSmallItemGrid parameters = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06014462 RID: 83042 RVA: 0x005E8ADD File Offset: 0x005E6CDD
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06014463 RID: 83043 RVA: 0x005E8AE0 File Offset: 0x005E6CE0
	protected override void OnExtendToggleClicked()
	{
		if (this.ShowItemId <= 0)
		{
			return;
		}
		SolarSchoolUtils.ShowItemDetailPopup(this.ShowItemId, 0, null);
	}

	// Token: 0x0400AC1A RID: 44058
	private int ShowItemId;
}
