using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02002D46 RID: 11590
public class WeeklyRogueTokenInfoGrid : LoopScrollMediumItemGrid<int>
{
	// Token: 0x170020D8 RID: 8408
	// (get) Token: 0x060185A8 RID: 99752 RVA: 0x006333DF File Offset: 0x006315DF
	// (set) Token: 0x060185A9 RID: 99753 RVA: 0x006333EC File Offset: 0x006315EC
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

	// Token: 0x060185AA RID: 99754 RVA: 0x006333FA File Offset: 0x006315FA
	public WeeklyRogueTokenInfoGrid()
	{
		this.Data = 0;
	}

	// Token: 0x060185AB RID: 99755 RVA: 0x0063340C File Offset: 0x0063160C
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

	// Token: 0x060185AC RID: 99756 RVA: 0x006334E1 File Offset: 0x006316E1
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<int, bool> onSelectedChange = this.OnSelectedChange;
		if (onSelectedChange == null)
		{
			return;
		}
		onSelectedChange(this.Data, state == EToggleState.ETT_Checked);
	}

	// Token: 0x060185AD RID: 99757 RVA: 0x006334FD File Offset: 0x006316FD
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

	// Token: 0x060185AE RID: 99758 RVA: 0x00633521 File Offset: 0x00631721
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x060185AF RID: 99759 RVA: 0x0063352B File Offset: 0x0063172B
	[NullableContext(1)]
	public override object GetKey(int data, int gridIndex)
	{
		return this.Data;
	}

	// Token: 0x0400B4C4 RID: 46276
	[Nullable(2)]
	public Action<int, bool> OnSelectedChange;
}
