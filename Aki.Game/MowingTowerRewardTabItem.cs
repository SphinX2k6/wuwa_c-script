using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000844 RID: 2116
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MowingTowerRewardTabItem : GridProxyAbstract<MowingTowerLevelDetailInfo>
{
	// Token: 0x06005FEE RID: 24558 RVA: 0x001EA20C File Offset: 0x001E840C
	public void SetClickCallBack(Action<MowingTowerRewardTabItem> callback)
	{
		this.ClickCallBack = callback;
	}

	// Token: 0x06005FEF RID: 24559 RVA: 0x001EA218 File Offset: 0x001E8418
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list;
	}

	// Token: 0x06005FF0 RID: 24560 RVA: 0x001EA2C8 File Offset: 0x001E84C8
	public override void Refresh(MowingTowerLevelDetailInfo data, bool isSelected, int gridIndex)
	{
		this.LevelData = data;
		if (gridIndex == 0)
		{
			Action<MowingTowerRewardTabItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack != null)
			{
				clickCallBack(this);
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		else
		{
			this.SetToggleUnCheck();
		}
		MowTowerLevelsRe? config = data.GetConfig();
		if (config == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.RewardName, Array.Empty<object>());
		base.SetTextureByPath(config.Value.RewardTexture, base.GetTexture(2), null, null);
	}

	// Token: 0x06005FF1 RID: 24561 RVA: 0x001EA366 File Offset: 0x001E8566
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<MowingTowerRewardTabItem> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this);
	}

	// Token: 0x06005FF2 RID: 24562 RVA: 0x001EA379 File Offset: 0x001E8579
	public void SetToggleUnCheck()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06005FF3 RID: 24563 RVA: 0x001EA38C File Offset: 0x001E858C
	public int? GetLevelId()
	{
		MowingTowerLevelDetailInfo levelData = this.LevelData;
		if (levelData == null)
		{
			return null;
		}
		return new int?(levelData.GetId());
	}

	// Token: 0x06005FF4 RID: 24564 RVA: 0x001EA3B7 File Offset: 0x001E85B7
	public void SetRedDotActive(bool isShow)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isShow);
	}

	// Token: 0x04003EE3 RID: 16099
	[Nullable(2)]
	private MowingTowerLevelDetailInfo LevelData;

	// Token: 0x04003EE4 RID: 16100
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MowingTowerRewardTabItem> ClickCallBack;
}
