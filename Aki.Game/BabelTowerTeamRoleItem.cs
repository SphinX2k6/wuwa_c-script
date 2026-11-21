using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000640 RID: 1600
public class BabelTowerTeamRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06004A76 RID: 19062 RVA: 0x00195004 File Offset: 0x00193204
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004A77 RID: 19063 RVA: 0x001950B0 File Offset: 0x001932B0
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RoleId = data;
		if (data == 0)
		{
			base.GetTexture(2).SetUIActive(false);
			base.GetSprite(3).SetUIActive(false);
			return;
		}
		RoleModel instance = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(data, true) : null;
		if (roleDataBase != null)
		{
			int roleSkinId = roleDataBase.GetRoleSkinId();
			string roleHeadIconCircle;
			if (roleSkinId > 0)
			{
				roleHeadIconCircle = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId).Value.RoleHeadIconCircle;
			}
			else
			{
				roleHeadIconCircle = roleDataBase.GetRoleConfig().RoleHeadIconCircle;
			}
			base.SetTextureShowUntilLoaded(roleHeadIconCircle, base.GetTexture(2), null);
		}
		this.RefreshSkillBranchIcon();
	}

	// Token: 0x06004A78 RID: 19064 RVA: 0x00195148 File Offset: 0x00193348
	public void RefreshSkillBranchIcon()
	{
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(this.RoleId);
		bool flag = roleSkillBranchIndexInCurrentGamePlay > -1;
		base.GetSprite(3).SetUIActive(flag);
		if (!flag)
		{
			return;
		}
		bool flag2 = roleSkillBranchIndexInCurrentGamePlay == 0;
		FVector fvector = new FVector(0f, (float)(flag2 ? 0 : 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		base.GetSprite(3).SetUIRelativeRotation(frotator);
	}

	// Token: 0x0400371F RID: 14111
	private int RoleId;

	// Token: 0x020068FD RID: 26877
	private class EComponentDefine
	{
		// Token: 0x0402299B RID: 141723
		public const int Button = 0;

		// Token: 0x0402299C RID: 141724
		public const int BgSprite = 1;

		// Token: 0x0402299D RID: 141725
		public const int RoleTexture = 2;

		// Token: 0x0402299E RID: 141726
		public const int TagSprite = 3;
	}
}
