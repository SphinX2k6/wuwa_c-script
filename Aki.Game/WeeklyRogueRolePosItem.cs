using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D3E RID: 11582
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueRolePosItem : GridProxyAbstract<IWeeklyRogueRolePosInfo>
{
	// Token: 0x06018582 RID: 99714 RVA: 0x00632480 File Offset: 0x00630680
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

	// Token: 0x06018583 RID: 99715 RVA: 0x00632514 File Offset: 0x00630714
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

	// Token: 0x06018584 RID: 99716 RVA: 0x00632607 File Offset: 0x00630807
	private void SetRoleShow(bool bShow)
	{
		base.GetTexture(1).SetUIActive(bShow);
	}

	// Token: 0x06018585 RID: 99717 RVA: 0x00632616 File Offset: 0x00630816
	private void OnBtnClick()
	{
		Action<RoleDataBase> onBtnClickFunc = this.OnBtnClickFunc;
		if (onBtnClickFunc == null)
		{
			return;
		}
		onBtnClickFunc(this.Info.Data);
	}

	// Token: 0x06018586 RID: 99718 RVA: 0x00632634 File Offset: 0x00630834
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

	// Token: 0x0400B4BB RID: 46267
	private IWeeklyRogueRolePosInfo Info;

	// Token: 0x0400B4BC RID: 46268
	[Nullable(2)]
	public Action<RoleDataBase> OnBtnClickFunc;

	// Token: 0x020092CB RID: 37579
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402F727 RID: 194343
		BtnSelf,
		// Token: 0x0402F728 RID: 194344
		TexRole,
		// Token: 0x0402F729 RID: 194345
		UpItem,
		// Token: 0x0402F72A RID: 194346
		ItemSkillBranch
	}
}
