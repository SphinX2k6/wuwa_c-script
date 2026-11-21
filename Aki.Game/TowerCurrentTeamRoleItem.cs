using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200215E RID: 8542
public class TowerCurrentTeamRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06014F9F RID: 85919 RVA: 0x0061C6BC File Offset: 0x0061A8BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014FA0 RID: 85920 RVA: 0x0061C748 File Offset: 0x0061A948
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		UUITexture roleTexture = base.GetTexture(1);
		if (roleId != 0)
		{
			roleTexture.SetUIActive(false);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			RoleInfo value = ((roleDataById != null) ? new RoleInfo?(roleDataById.GetRoleConfig()) : RoleConfig.Instance.GetRoleConfig(roleId)).Value;
			string roleHeadIconCircle = value.RoleHeadIconCircle;
			int skinId = (roleDataById != null) ? roleDataById.GetRoleSkinId() : value.SkinId;
			base.SetRoleSkinIcon(roleHeadIconCircle, roleTexture, skinId, null, delegate(bool _)
			{
				roleTexture.SetUIActive(true);
			});
			int roleSkillBranchIdInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleId);
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(roleSkillBranchIdInCurrentGamePlay > 0);
			}
			if (roleSkillBranchIdInCurrentGamePlay > 0)
			{
				int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(roleId);
				FVector fvector = new FVector(0f, (float)(roleSkillBranchIndexInCurrentGamePlay * 180), 0f);
				FRotator frotator = FRotator.MakeFromEuler(fvector);
				if (sprite != null)
				{
					sprite.SetUIRelativeRotation(frotator);
				}
			}
			return;
		}
		roleTexture.SetUIActive(false);
		UUISprite sprite2 = base.GetSprite(2);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(false);
	}

	// Token: 0x020083E1 RID: 33761
	private enum EChildType
	{
		// Token: 0x0402A8ED RID: 174317
		RoleItem,
		// Token: 0x0402A8EE RID: 174318
		RoleTexture,
		// Token: 0x0402A8EF RID: 174319
		TagSprite
	}
}
