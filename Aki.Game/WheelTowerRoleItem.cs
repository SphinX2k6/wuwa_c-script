using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015CE RID: 5582
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerRoleItem : GridProxyAbstract<RoleDataWithBranch>
{
	// Token: 0x17000D81 RID: 3457
	// (get) Token: 0x06009E19 RID: 40473 RVA: 0x00226866 File Offset: 0x00224A66
	// (set) Token: 0x06009E1A RID: 40474 RVA: 0x0022686E File Offset: 0x00224A6E
	public bool IsOnlyShowIcon { get; set; }

	// Token: 0x17000D82 RID: 3458
	// (get) Token: 0x06009E1B RID: 40475 RVA: 0x00226877 File Offset: 0x00224A77
	// (set) Token: 0x06009E1C RID: 40476 RVA: 0x0022687F File Offset: 0x00224A7F
	public bool CanClick { get; set; } = true;

	// Token: 0x06009E1D RID: 40477 RVA: 0x00226888 File Offset: 0x00224A88
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E1E RID: 40478 RVA: 0x002269FC File Offset: 0x00224BFC
	public override void Refresh(RoleDataWithBranch data, bool isSelected, int gridIndex)
	{
		int roleId = data.RoleId;
		bool flag = roleId > 0;
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag && !this.IsOnlyShowIcon);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(flag && !this.IsOnlyShowIcon);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(flag);
		}
		UUIItem item4 = base.GetItem(6);
		if (item4 != null)
		{
			item4.SetUIActive(!flag && this.CanClick);
		}
		UUIItem item5 = base.GetItem(7);
		if (item5 != null)
		{
			item5.SetUIActive(flag && !this.IsOnlyShowIcon);
		}
		UUIItem item6 = base.GetItem(8);
		if (item6 != null)
		{
			item6.SetUIActive(!flag && !this.CanClick);
		}
		if (!flag)
		{
			UUIItem item7 = base.GetItem(9);
			if (item7 == null)
			{
				return;
			}
			item7.SetUIActive(false);
			return;
		}
		else
		{
			WheelTowerModel instance = WheelTowerModel.Instance;
			int roleId2 = instance.TryGetRealRoleId(roleId);
			int itemId = RoleConfig.Instance.GetRoleConfig(roleId).Value.SkinId;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			if (roleDataById != null)
			{
				itemId = roleDataById.GetRoleSkinId();
			}
			RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(itemId);
			if (roleSkinConfig != null)
			{
				base.SetTextureShowUntilLoaded(roleSkinConfig.Value.Card, base.GetTexture(1), null);
			}
			UUIItem item8 = base.GetItem(9);
			int skillBranchIndex = data.SkillBranchIndex;
			bool uiactive = data.RoleId > 0 && skillBranchIndex > -1;
			if (item8 != null)
			{
				item8.SetUIActive(uiactive);
			}
			this.SetSkillBranchIconToLeft(skillBranchIndex == 0);
			if (this.IsOnlyShowIcon)
			{
				return;
			}
			int roleEnergy = instance.SelectedEnergyInfo.GetRoleEnergy(roleId2);
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(roleEnergy.ToString(), true);
			}
			if (text2 != null)
			{
				text2.SetChangeColor(roleEnergy <= 0, TowerData.redColor);
			}
			bool uiactive2 = instance.IsEnhanceRole(roleId2);
			UUIItem item9 = base.GetItem(4);
			if (item9 != null)
			{
				item9.SetUIActive(uiactive2);
			}
			bool uiactive3 = instance.CheckConflict(roleId) != null;
			UUIItem item10 = base.GetItem(7);
			if (item10 == null)
			{
				return;
			}
			item10.SetUIActive(uiactive3);
			return;
		}
	}

	// Token: 0x06009E1F RID: 40479 RVA: 0x00226C48 File Offset: 0x00224E48
	private void SetSkillBranchIconToLeft(bool isLeft)
	{
		UUIItem item = base.GetItem(9);
		FVector fvector = new FVector(0f, (float)(isLeft ? 0 : 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}
}
