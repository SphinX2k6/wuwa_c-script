using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002298 RID: 8856
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueRolePosItem : GridProxyAbstract<IWeeklyRogueRolePosInfo>
{
	// Token: 0x06015E24 RID: 89636 RVA: 0x00658490 File Offset: 0x00656690
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick))
		};
	}

	// Token: 0x06015E25 RID: 89637 RVA: 0x00658524 File Offset: 0x00656724
	public override void Refresh(IWeeklyRogueRolePosInfo info, bool isSelected, int gridIndex)
	{
		this.Info = info;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (info.Data == null)
		{
			this.SetRoleShow(false);
			base.GetItem(2).SetUIActive(false);
			return;
		}
		RoleDataBase data = info.Data;
		RoleInfo roleConfig = data.GetRoleConfig();
		int itemId = (data.GetRoleSkinId() > 0) ? data.GetRoleSkinId() : roleConfig.SkinId;
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(itemId);
		if (roleSkinConfig == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(roleSkinConfig.Value.RoleHeadIconCircle, base.GetTexture(1), null);
		base.GetItem(2).SetUIActive(info.IsRecommend.GetValueOrDefault());
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(data.GetRoleId());
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(roleSkillBranchIndexInCurrentGamePlay > -1);
		}
		if (roleSkillBranchIndexInCurrentGamePlay > -1)
		{
			this.SetSkillBranchIconToLeft(roleSkillBranchIndexInCurrentGamePlay == 0);
		}
	}

	// Token: 0x06015E26 RID: 89638 RVA: 0x00658617 File Offset: 0x00656817
	private void SetRoleShow(bool bShow)
	{
		base.GetTexture(1).SetUIActive(bShow);
	}

	// Token: 0x06015E27 RID: 89639 RVA: 0x00658626 File Offset: 0x00656826
	private void OnBtnClick()
	{
		Action<RoleDataBase> onBtnClickFunc = this.OnBtnClickFunc;
		if (onBtnClickFunc == null)
		{
			return;
		}
		onBtnClickFunc(this.Info.Data);
	}

	// Token: 0x06015E28 RID: 89640 RVA: 0x00658644 File Offset: 0x00656844
	private void SetSkillBranchIconToLeft(bool isLeft)
	{
		UUIItem item = base.GetItem(3);
		FVector fvector = new FVector(0f, (float)(isLeft ? 0 : 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		if (item == null)
		{
			return;
		}
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0400B830 RID: 47152
	private IWeeklyRogueRolePosInfo Info;

	// Token: 0x0400B831 RID: 47153
	[Nullable(2)]
	public Action<RoleDataBase> OnBtnClickFunc;

	// Token: 0x020084F2 RID: 34034
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402ADAF RID: 175535
		BtnSelf,
		// Token: 0x0402ADB0 RID: 175536
		TexRole,
		// Token: 0x0402ADB1 RID: 175537
		UpItem,
		// Token: 0x0402ADB2 RID: 175538
		ItemSkillBranch
	}
}
