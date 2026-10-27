using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015E2 RID: 5602
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerSettlementRoleItem : GridProxyAbstract<RoleDataWithBranch>
{
	// Token: 0x06009E58 RID: 40536 RVA: 0x00228554 File Offset: 0x00226754
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
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
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E59 RID: 40537 RVA: 0x00228684 File Offset: 0x00226884
	public override void Refresh(RoleDataWithBranch data, bool isSelected, int gridIndex)
	{
		int roleId = data.RoleId;
		bool flag = roleId > 0;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (!flag)
		{
			UUIItem item3 = base.GetItem(9);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
		else
		{
			WheelTowerModel instance = WheelTowerModel.Instance;
			bool flag2 = instance.IsTemplateRole(roleId);
			int num = instance.TryGetRealRoleId(roleId);
			RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(num);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(num);
			if (roleConfig == null)
			{
				return;
			}
			string card = roleConfig.Value.Card;
			if (!flag2 && roleSkinDataByRoleId != null)
			{
				card = roleSkinDataByRoleId.GetRoleSkinConfig().Card;
			}
			UUITexture textureRole = base.GetTexture(1);
			if (textureRole == null)
			{
				return;
			}
			textureRole.SetUIActive(false);
			base.SetRoleIconByRoleIdOrSkinId(card, textureRole, num, new int?(roleConfig.Value.SkinId), delegate(bool _)
			{
				textureRole.SetUIActive(true);
			}, null);
			UUIItem item4 = base.GetItem(2);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUIItem item5 = base.GetItem(4);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			this.RefreshSkillBranchTag(roleId, data);
			return;
		}
	}

	// Token: 0x06009E5A RID: 40538 RVA: 0x002287D4 File Offset: 0x002269D4
	private void RefreshSkillBranchTag(int roleId, RoleDataWithBranch data)
	{
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		bool uiactive = data.SkillBranchId > 0;
		item.SetUIActive(uiactive);
		int num = (data.SkillBranchIndex == 1) ? 180 : 0;
		FVector fvector = new FVector(0f, (float)num, 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}
}
