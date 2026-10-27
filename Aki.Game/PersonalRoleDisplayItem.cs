using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020023E4 RID: 9188
[NullableContext(1)]
[Nullable(0)]
public class PersonalRoleDisplayItem : GridProxyAbstract<int>
{
	// Token: 0x060125CA RID: 75210 RVA: 0x00486888 File Offset: 0x00484A88
	public PersonalRoleDisplayItem(UUIItem item)
	{
		if (item != null)
		{
			this.CreateThenShowByActor(item.GetOwner());
		}
	}

	// Token: 0x060125CB RID: 75211 RVA: 0x004868A0 File Offset: 0x00484AA0
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

	// Token: 0x060125CC RID: 75212 RVA: 0x004869E8 File Offset: 0x00484BE8
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

	// Token: 0x060125CD RID: 75213 RVA: 0x00486A90 File Offset: 0x00484C90
	private void RefreshQualitySprite()
	{
		int qualityId = RoleConfig.Instance.GetRoleConfig(this.RoleId).Value.QualityId;
		this.SetSpriteByPath(RoleConfig.Instance.GetRoleQualityInfo(qualityId).Value.Image, base.GetSprite(1), false, null, null);
	}

	// Token: 0x060125CE RID: 75214 RVA: 0x00486AF4 File Offset: 0x00484CF4
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

	// Token: 0x060125CF RID: 75215 RVA: 0x00486B50 File Offset: 0x00484D50
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

	// Token: 0x060125D0 RID: 75216 RVA: 0x00486B9C File Offset: 0x00484D9C
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

	// Token: 0x060125D1 RID: 75217 RVA: 0x00486C13 File Offset: 0x00484E13
	private void OnClickItem()
	{
		this.OnClickCallback(this.RoleId, this.GirdIndex);
	}

	// Token: 0x060125D2 RID: 75218 RVA: 0x00486C2C File Offset: 0x00484E2C
	public void SetToggleState(EToggleState state)
	{
	}

	// Token: 0x060125D3 RID: 75219 RVA: 0x00486C2E File Offset: 0x00484E2E
	public void SetClickCallback(TPersonalRoleDisplayItemClickFunction clickFunction)
	{
		this.OnClickCallback = clickFunction;
	}

	// Token: 0x060125D4 RID: 75220 RVA: 0x00486C37 File Offset: 0x00484E37
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x060125D5 RID: 75221 RVA: 0x00486C3F File Offset: 0x00484E3F
	public int GetGirdIndex()
	{
		return this.GirdIndex;
	}

	// Token: 0x060125D6 RID: 75222 RVA: 0x00486C47 File Offset: 0x00484E47
	public void SetUseState(bool isUsing)
	{
		base.GetItem(10).SetUIActive(isUsing);
	}

	// Token: 0x060125D7 RID: 75223 RVA: 0x00486C57 File Offset: 0x00484E57
	public void SetSelectState(int curSelectRoleId, bool bFireEvent = false)
	{
	}

	// Token: 0x04008AF1 RID: 35569
	private int RoleId;

	// Token: 0x04008AF2 RID: 35570
	private int GirdIndex;

	// Token: 0x04008AF3 RID: 35571
	[Nullable(2)]
	private TPersonalRoleDisplayItemClickFunction OnClickCallback;
}
