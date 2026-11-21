using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020018C9 RID: 6345
[NullableContext(1)]
[Nullable(0)]
public class PersonalRoleDisplayItem : GridProxyAbstract<int>
{
	// Token: 0x0600FA7C RID: 64124 RVA: 0x00493D94 File Offset: 0x00491F94
	public PersonalRoleDisplayItem(UUIItem item)
	{
		if (item != null)
		{
			this.CreateThenShowByActor(item.GetOwner());
		}
	}

	// Token: 0x0600FA7D RID: 64125 RVA: 0x00493DAC File Offset: 0x00491FAC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickItem))
		};
	}

	// Token: 0x0600FA7E RID: 64126 RVA: 0x00493EF4 File Offset: 0x004920F4
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		this.InitAllItemState();
		this.RoleId = roleId;
		this.GirdIndex = gridIndex;
		base.GetTexture(0).SetUIActive(this.RoleId != -1);
		if (this.RoleId == -1)
		{
			return;
		}
		bool flag = RoleModel.Instance.GetRoleInstanceById(this.RoleId) != null;
		base.GetItem(12).SetUIActive(!flag);
		base.SetTextureByPath(RoleConfig.Instance.GetRoleConfig(this.RoleId).Value.RoleHeadIconBig, base.GetTexture(0), null, null);
		this.RefreshQualitySprite();
	}

	// Token: 0x0600FA7F RID: 64127 RVA: 0x00493F9C File Offset: 0x0049219C
	private void RefreshQualitySprite()
	{
		int qualityId = RoleConfig.Instance.GetRoleConfig(this.RoleId).Value.QualityId;
		this.SetSpriteByPath(RoleConfig.Instance.GetRoleQualityInfo(qualityId).Value.Image, base.GetSprite(1), false, null, null);
	}

	// Token: 0x0600FA80 RID: 64128 RVA: 0x00494000 File Offset: 0x00492200
	public void ShowLevelText()
	{
		UUIText text = base.GetText(2);
		text.SetUIActive(true);
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		if (roleInstanceById != null)
		{
			RoleLevelData levelData = roleInstanceById.GetLevelData();
			if (levelData != null)
			{
				int level = levelData.GetLevel();
				LguiUtil.Instance.SetLocalText(text, "LevelShow", new <>z__ReadOnlySingleElementList<object>(level));
			}
		}
	}

	// Token: 0x0600FA81 RID: 64129 RVA: 0x0049405C File Offset: 0x0049225C
	public void ShowNameText()
	{
		UUIText text = base.GetText(4);
		text.SetUIActive(true);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.RoleId);
		if (roleConfig != null)
		{
			text.ShowTextNew(roleConfig.Value.Name);
		}
	}

	// Token: 0x0600FA82 RID: 64130 RVA: 0x004940A8 File Offset: 0x004922A8
	public void InitAllItemState()
	{
		base.GetText(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		base.GetText(4).SetUIActive(false);
		base.GetTexture(5).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		base.GetText(8).SetUIActive(false);
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
	}

	// Token: 0x0600FA83 RID: 64131 RVA: 0x0049411F File Offset: 0x0049231F
	private void OnClickItem()
	{
		this.OnClickCallback(this.RoleId, this.GirdIndex);
	}

	// Token: 0x0600FA84 RID: 64132 RVA: 0x00494138 File Offset: 0x00492338
	public void SetToggleState(EToggleState state)
	{
	}

	// Token: 0x0600FA85 RID: 64133 RVA: 0x0049413A File Offset: 0x0049233A
	public void SetClickCallback(TPersonalRoleDisplayItemClickFunction clickFunction)
	{
		this.OnClickCallback = clickFunction;
	}

	// Token: 0x0600FA86 RID: 64134 RVA: 0x00494143 File Offset: 0x00492343
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600FA87 RID: 64135 RVA: 0x0049414B File Offset: 0x0049234B
	public int GetGirdIndex()
	{
		return this.GirdIndex;
	}

	// Token: 0x0600FA88 RID: 64136 RVA: 0x00494153 File Offset: 0x00492353
	public void SetUseState(bool isUsing)
	{
		base.GetItem(10).SetUIActive(isUsing);
	}

	// Token: 0x0600FA89 RID: 64137 RVA: 0x00494163 File Offset: 0x00492363
	public void SetSelectState(int curSelectRoleId, bool bFireEvent = false)
	{
	}

	// Token: 0x04008C38 RID: 35896
	private int RoleId;

	// Token: 0x04008C39 RID: 35897
	private int GirdIndex;

	// Token: 0x04008C3A RID: 35898
	[Nullable(2)]
	private TPersonalRoleDisplayItemClickFunction OnClickCallback;
}
