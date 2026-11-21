using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200191D RID: 6429
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionDetailMonsterItem : LoopScrollSmallItemGrid<VisionDetailMonsterItemData>
{
	// Token: 0x0600FE3D RID: 65085 RVA: 0x004A3BCE File Offset: 0x004A1DCE
	protected override void OnStart()
	{
		base.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickEvent));
		base.SetUseFixedAsync(true);
	}

	// Token: 0x0600FE3E RID: 65086 RVA: 0x004A3BE9 File Offset: 0x004A1DE9
	private void OnClickEvent(MediumItemGridExtendCallback data)
	{
	}

	// Token: 0x0600FE3F RID: 65087 RVA: 0x004A3BEB File Offset: 0x004A1DEB
	protected override void OnExtendToggleClicked()
	{
		this.ClickButton();
	}

	// Token: 0x0600FE40 RID: 65088 RVA: 0x004A3BF3 File Offset: 0x004A1DF3
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0600FE41 RID: 65089 RVA: 0x004A3BFD File Offset: 0x004A1DFD
	private void ClickButton()
	{
		AdventureGuideController.Instance.TryJumpToTargetViewByMonsterId(this.MonsterId, null);
	}

	// Token: 0x0600FE42 RID: 65090 RVA: 0x004A3C10 File Offset: 0x004A1E10
	protected override void OnRefresh(VisionDetailMonsterItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
	}

	// Token: 0x0600FE43 RID: 65091 RVA: 0x004A3C1C File Offset: 0x004A1E1C
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

	// Token: 0x04008D75 RID: 36213
	private int MonsterId;
}
