using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x020022A0 RID: 8864
public class WeeklyRogueTokenInfoGrid : LoopScrollMediumItemGrid<int>
{
	// Token: 0x17002133 RID: 8499
	// (get) Token: 0x06015E4A RID: 89674 RVA: 0x006593EF File Offset: 0x006575EF
	// (set) Token: 0x06015E4B RID: 89675 RVA: 0x006593FC File Offset: 0x006575FC
	public new int Data
	{
		get
		{
			return (int)this.Data;
		}
		set
		{
			this.Data = value;
		}
	}

	// Token: 0x06015E4C RID: 89676 RVA: 0x0065940A File Offset: 0x0065760A
	public WeeklyRogueTokenInfoGrid()
	{
		this.Data = 0;
	}

	// Token: 0x06015E4D RID: 89677 RVA: 0x0065941C File Offset: 0x0065761C
	protected override void OnRefresh(int data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		if (data == 0)
		{
			PhantomMediumItemGrid parameters = new PhantomMediumItemGrid
			{
				Data = data,
				IsPhantomLock = new bool?(true),
				BottomTextId = "WeRogueMisssingToken"
			};
			base.Apply<PhantomMediumItemGrid>(parameters);
			base.SetToggleInteractive(false);
			return;
		}
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(data);
		if (rogueWeeklyBuffPool == null)
		{
			return;
		}
		PropMediumItemGrid parameters2 = new PropMediumItemGrid
		{
			Data = data,
			IconPath = rogueWeeklyBuffPool.Value.BuffIcon,
			QualityId = new int?(rogueWeeklyBuffPool.Value.Quality),
			QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath),
			BottomTextId = rogueWeeklyBuffPool.Value.BuffName
		};
		base.Apply<PropMediumItemGrid>(parameters2);
		base.SetToggleInteractive(true);
	}

	// Token: 0x06015E4E RID: 89678 RVA: 0x006594F1 File Offset: 0x006576F1
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<int, bool> onSelectedChange = this.OnSelectedChange;
		if (onSelectedChange == null)
		{
			return;
		}
		onSelectedChange(this.Data, state == EToggleState.ETT_Checked);
	}

	// Token: 0x06015E4F RID: 89679 RVA: 0x0065950D File Offset: 0x0065770D
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
		if (fireEvent)
		{
			Action<int, bool> onSelectedChange = this.OnSelectedChange;
			if (onSelectedChange == null)
			{
				return;
			}
			onSelectedChange(this.Data, true);
		}
	}

	// Token: 0x06015E50 RID: 89680 RVA: 0x00659531 File Offset: 0x00657731
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06015E51 RID: 89681 RVA: 0x0065953B File Offset: 0x0065773B
	[NullableContext(1)]
	public override object GetKey(int data, int gridIndex)
	{
		return this.Data;
	}

	// Token: 0x0400B839 RID: 47161
	[Nullable(2)]
	public Action<int, bool> OnSelectedChange;
}
