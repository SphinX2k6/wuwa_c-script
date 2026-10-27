using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200247E RID: 9342
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractGridMediumItemGrid : MediumItemGrid
{
	// Token: 0x06012BF2 RID: 76786 RVA: 0x0049FDB4 File Offset: 0x0049DFB4
	public void Refresh(IPhantomInteractGridViewModel data, bool select, int gridIndex)
	{
		this.CurrentIndex = gridIndex;
		this.CurrentData = data;
		EMediumItemGridPhantomSpecialSkill value = EMediumItemGridPhantomSpecialSkill.Hide;
		if (data.IsSpecial)
		{
			if (data.IsInArea)
			{
				value = EMediumItemGridPhantomSpecialSkill.ShowAvailable;
			}
			else
			{
				value = EMediumItemGridPhantomSpecialSkill.ShowUnavailable;
			}
		}
		this.CurrentRedDot = (PhantomInteractModel.Instance.CheckPhantomInteractUnlockRedDot(data.MonsterId) && data.InSlotIndex < 0);
		PhantomMediumItemGrid parameters = new PhantomMediumItemGrid
		{
			Data = data,
			MonsterId = new int?(data.MonsterInfoId),
			BottomTextId = data.Name,
			Level = new int?(data.Cost),
			IsLevelTextUseChangeColor = new bool?(true),
			SpecialSkill = new EMediumItemGridPhantomSpecialSkill?(value),
			IsDisable = new bool?(!data.IsUnlocked),
			SortNum = new int?(data.InSlotIndex + 1),
			IsRedDotVisible = new bool?(this.CurrentRedDot),
			QualityId = new int?(1)
		};
		base.SetUseFixedAsync(true);
		base.Apply<PhantomMediumItemGrid>(parameters);
	}

	// Token: 0x06012BF3 RID: 76787 RVA: 0x0049FEB0 File Offset: 0x0049E0B0
	protected override void OnStart()
	{
		base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickEvent));
	}

	// Token: 0x06012BF4 RID: 76788 RVA: 0x0049FEC4 File Offset: 0x0049E0C4
	private void OnClickEvent(MediumItemGridExtendCallback callback)
	{
		if (callback.State != EToggleState.ETT_Checked)
		{
			this.GetItemGridExtendToggle().SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		if (this.OnClickCallBack != null && this.CurrentData != null)
		{
			this.OnClickCallBack(this.CurrentData, this.CurrentIndex);
		}
	}

	// Token: 0x06012BF5 RID: 76789 RVA: 0x0049FF12 File Offset: 0x0049E112
	public void SetOnClickCallBack(Action<IPhantomInteractGridViewModel, int> call)
	{
		this.OnClickCallBack = call;
	}

	// Token: 0x04008D32 RID: 36146
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<IPhantomInteractGridViewModel, int> OnClickCallBack;

	// Token: 0x04008D33 RID: 36147
	private int CurrentIndex = -1;

	// Token: 0x04008D34 RID: 36148
	[Nullable(2)]
	private IPhantomInteractGridViewModel CurrentData;

	// Token: 0x04008D35 RID: 36149
	private bool CurrentRedDot;
}
