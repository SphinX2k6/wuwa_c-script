using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001390 RID: 5008
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MowingTowerRewardTabItem : GridProxyAbstract<MowingTowerLevelDetailInfo>
{
	// Token: 0x06008C53 RID: 35923 RVA: 0x001E13B8 File Offset: 0x001DF5B8
	public void SetClickCallBack(Action<MowingTowerRewardTabItem> callback)
	{
		this.ClickCallBack = callback;
	}

	// Token: 0x06008C54 RID: 35924 RVA: 0x001E13C4 File Offset: 0x001DF5C4
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

	// Token: 0x06008C55 RID: 35925 RVA: 0x001E1474 File Offset: 0x001DF674
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

	// Token: 0x06008C56 RID: 35926 RVA: 0x001E1512 File Offset: 0x001DF712
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<MowingTowerRewardTabItem> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this);
	}

	// Token: 0x06008C57 RID: 35927 RVA: 0x001E1525 File Offset: 0x001DF725
	public void SetToggleUnCheck()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06008C58 RID: 35928 RVA: 0x001E1538 File Offset: 0x001DF738
	public int? GetLevelId()
	{
		MowingTowerLevelDetailInfo levelData = this.LevelData;
		if (levelData == null)
		{
			return null;
		}
		return new int?(levelData.GetId());
	}

	// Token: 0x06008C59 RID: 35929 RVA: 0x001E1563 File Offset: 0x001DF763
	public void SetRedDotActive(bool isShow)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isShow);
	}

	// Token: 0x04003E4B RID: 15947
	[Nullable(2)]
	private MowingTowerLevelDetailInfo LevelData;

	// Token: 0x04003E4C RID: 15948
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MowingTowerRewardTabItem> ClickCallBack;
}
