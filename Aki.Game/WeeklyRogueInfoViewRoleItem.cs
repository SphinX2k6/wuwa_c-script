using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D34 RID: 11572
public class WeeklyRogueInfoViewRoleItem : GridProxyAbstract<int>
{
	// Token: 0x0601854B RID: 99659 RVA: 0x00631504 File Offset: 0x0062F704
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x0601854C RID: 99660 RVA: 0x006315C4 File Offset: 0x0062F7C4
	public override void Refresh(int roleConfigId, bool isSelected, int gridIndex)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId, true);
		if (roleDataById == null)
		{
			return;
		}
		base.SetRoleSkinIcon(roleDataById.GetRoleConfig().RoleHeadIconBig, base.GetTexture(0), roleDataById.GetRoleSkinId(), null, null);
		int qualityId = roleDataById.GetRoleConfig().QualityId;
		UUISprite sprite = base.GetSprite(1);
		UUISprite sprite2 = base.GetSprite(2);
		UUISprite sprite3 = base.GetSprite(3);
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_RoleIconBgUnCheckedUnHover");
		defaultInterpolatedStringHandler.AppendFormatted<int>(qualityId);
		string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		this.SetSpriteByPath(resourcePath, sprite3, false, null, null);
		UiResourceConfig instance2 = UiResourceConfig.Instance;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_RoleIconBgUnCheckedHover");
		defaultInterpolatedStringHandler.AppendFormatted<int>(qualityId);
		string resourcePath2 = instance2.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		this.SetSpriteByPath(resourcePath2, sprite2, false, null, null);
		UiResourceConfig instance3 = UiResourceConfig.Instance;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_RoleIconBgChecked");
		defaultInterpolatedStringHandler.AppendFormatted<int>(qualityId);
		string resourcePath3 = instance3.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		this.SetSpriteByPath(resourcePath3, sprite, false, null, null);
		this.RefreshSkillBranch(roleConfigId);
	}

	// Token: 0x0601854D RID: 99661 RVA: 0x00631712 File Offset: 0x0062F912
	private void OnClick(EToggleState toggleState)
	{
		Action<int> onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback(base.GridIndex);
	}

	// Token: 0x0601854E RID: 99662 RVA: 0x0063172A File Offset: 0x0062F92A
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		if (fireEvent)
		{
			Action<int> onSelectedCallback = this.OnSelectedCallback;
			if (onSelectedCallback == null)
			{
				return;
			}
			onSelectedCallback(base.GridIndex);
		}
	}

	// Token: 0x0601854F RID: 99663 RVA: 0x00631756 File Offset: 0x0062F956
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06018550 RID: 99664 RVA: 0x0063176C File Offset: 0x0062F96C
	public void RefreshSkillBranch(int roleId)
	{
		UUIItem item = base.GetItem(4);
		int roleCurrentBranchIndex = RoleModel.Instance.GetRoleCurrentBranchIndex(roleId);
		if (roleCurrentBranchIndex < 0)
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		int num = roleCurrentBranchIndex * 180;
		FVector fvector = new FVector(0f, 0f, (float)num);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0400B4A2 RID: 46242
	[Nullable(2)]
	public Action<int> OnSelectedCallback;

	// Token: 0x020092C4 RID: 37572
	private enum EWeeklyRogueInfoViewRoleItemDefine
	{
		// Token: 0x0402F708 RID: 194312
		TextureIcon,
		// Token: 0x0402F709 RID: 194313
		SpriteSelect,
		// Token: 0x0402F70A RID: 194314
		SpriteHover,
		// Token: 0x0402F70B RID: 194315
		SpriteNormal,
		// Token: 0x0402F70C RID: 194316
		ItemSkillBranch,
		// Token: 0x0402F70D RID: 194317
		ExtendToggle
	}
}
