using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002182 RID: 8578
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerRoleSimpleItem : GridProxyAbstract<RoleDataWithBranch>
{
	// Token: 0x060150B9 RID: 86201 RVA: 0x0062291C File Offset: 0x00620B1C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060150BA RID: 86202 RVA: 0x00622988 File Offset: 0x00620B88
	[NullableContext(1)]
	public override void Refresh(RoleDataWithBranch data, bool isSelected, int gridIndex)
	{
		if (data.RoleId == 0)
		{
			base.GetItem(1).SetUIActive(false);
			base.GetTexture(0).SetUIActive(false);
			return;
		}
		base.GetTexture(0).SetUIActive(true);
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(data.RoleId).Value.RoleHeadIcon, base.GetTexture(0), data.RoleId, null, null);
		UUIItem item = base.GetItem(1);
		bool flag = data.SkillBranchId > 0;
		item.SetUIActive(flag);
		if (!flag)
		{
			return;
		}
		int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(data.RoleId, data.SkillBranchId);
		FVector fvector = new FVector(0f, (float)(roleBranchIndexById * 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x02008415 RID: 33813
	private enum EChildType
	{
		// Token: 0x0402A9DF RID: 174559
		RoleIcon,
		// Token: 0x0402A9E0 RID: 174560
		ItemSkillTag
	}
}
