using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001963 RID: 6499
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractGridMediumItemGrid : MediumItemGrid
{
	// Token: 0x060100A9 RID: 65705 RVA: 0x004AD50C File Offset: 0x004AB70C
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

	// Token: 0x060100AA RID: 65706 RVA: 0x004AD608 File Offset: 0x004AB808
	protected override void OnStart()
	{
		base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickEvent));
	}

	// Token: 0x060100AB RID: 65707 RVA: 0x004AD61C File Offset: 0x004AB81C
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

	// Token: 0x060100AC RID: 65708 RVA: 0x004AD66A File Offset: 0x004AB86A
	public void SetOnClickCallBack(Action<IPhantomInteractGridViewModel, int> call)
	{
		this.OnClickCallBack = call;
	}

	// Token: 0x04008E79 RID: 36473
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<IPhantomInteractGridViewModel, int> OnClickCallBack;

	// Token: 0x04008E7A RID: 36474
	private int CurrentIndex = -1;

	// Token: 0x04008E7B RID: 36475
	[Nullable(2)]
	private IPhantomInteractGridViewModel CurrentData;

	// Token: 0x04008E7C RID: 36476
	private bool CurrentRedDot;
}
