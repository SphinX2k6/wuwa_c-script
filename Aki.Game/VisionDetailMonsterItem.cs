using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02002438 RID: 9272
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionDetailMonsterItem : LoopScrollSmallItemGrid<VisionDetailMonsterItemData>
{
	// Token: 0x06012987 RID: 76167 RVA: 0x00496602 File Offset: 0x00494802
	protected override void OnStart()
	{
		base.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickEvent));
		base.SetUseFixedAsync(true);
	}

	// Token: 0x06012988 RID: 76168 RVA: 0x0049661D File Offset: 0x0049481D
	private void OnClickEvent(MediumItemGridExtendCallback data)
	{
	}

	// Token: 0x06012989 RID: 76169 RVA: 0x0049661F File Offset: 0x0049481F
	protected override void OnExtendToggleClicked()
	{
		this.ClickButton();
	}

	// Token: 0x0601298A RID: 76170 RVA: 0x00496627 File Offset: 0x00494827
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0601298B RID: 76171 RVA: 0x00496631 File Offset: 0x00494831
	private void ClickButton()
	{
		AdventureGuideController.Instance.TryJumpToTargetViewByMonsterId(this.MonsterId, null);
	}

	// Token: 0x0601298C RID: 76172 RVA: 0x00496644 File Offset: 0x00494844
	protected override void OnRefresh(VisionDetailMonsterItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
	}

	// Token: 0x0601298D RID: 76173 RVA: 0x00496650 File Offset: 0x00494850
	public override void Refresh(VisionDetailMonsterItemData data, bool isSelected, int gridIndex)
	{
		this.MonsterId = data.MonsterId;
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, this.MonsterId);
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(data.RoleId);
		Dictionary<int, PhantomDataBase> dictionary;
		if (roleInstanceById == null)
		{
			dictionary = null;
		}
		else
		{
			RolePhantomData phantomData = roleInstanceById.GetPhantomData();
			dictionary = ((phantomData != null) ? phantomData.GetDataMap() : null);
		}
		Dictionary<int, PhantomDataBase> dictionary2 = dictionary;
		int? visionRoleHeadInfo = new int?(0);
		if (dictionary2 != null)
		{
			foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in dictionary2)
			{
				PhantomDataBase value = keyValuePair.Value;
				int? num = (value != null) ? new int?(value.GetConfig().MonsterId) : null;
				int monsterId = this.MonsterId;
				if (num.GetValueOrDefault() == monsterId & num != null)
				{
					visionRoleHeadInfo = ((roleInstanceById != null) ? new int?(roleInstanceById.GetRoleId()) : null);
					break;
				}
			}
		}
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.MonsterId);
		if (calabashDevelopRewardByMonsterId == null)
		{
			return;
		}
		bool flag = handBookInfo != null;
		int? itemConfigId = null;
		if (data.QualityId > 0)
		{
			int[] phantomItemIdArrayByMonsterId = PhantomBattleModel.Instance.GetPhantomItemIdArrayByMonsterId(this.MonsterId);
			itemConfigId = new int?(phantomItemIdArrayByMonsterId[data.QualityId - 1]);
		}
		PhantomSmallItemGrid phantomSmallItemGrid = new PhantomSmallItemGrid
		{
			Data = data,
			ItemConfigId = itemConfigId,
			BottomText = "",
			IsNotFoundVisible = new bool?(!flag),
			MonsterId = new int?(calabashDevelopRewardByMonsterId.Value.MonsterInfoId),
			IconHidden = new bool?(!flag)
		};
		phantomSmallItemGrid.VisionRoleHeadInfo = visionRoleHeadInfo;
		base.Apply<PhantomSmallItemGrid>(phantomSmallItemGrid);
	}

	// Token: 0x04008C2E RID: 35886
	private int MonsterId;
}
