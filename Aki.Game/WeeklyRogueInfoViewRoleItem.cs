using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200228E RID: 8846
public class WeeklyRogueInfoViewRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06015DED RID: 89581 RVA: 0x00657518 File Offset: 0x00655718
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

	// Token: 0x06015DEE RID: 89582 RVA: 0x006575D8 File Offset: 0x006557D8
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

	// Token: 0x06015DEF RID: 89583 RVA: 0x00657726 File Offset: 0x00655926
	private void OnClick(EToggleState toggleState)
	{
		Action<int> onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback(base.GridIndex);
	}

	// Token: 0x06015DF0 RID: 89584 RVA: 0x0065773E File Offset: 0x0065593E
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

	// Token: 0x06015DF1 RID: 89585 RVA: 0x0065776A File Offset: 0x0065596A
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06015DF2 RID: 89586 RVA: 0x00657780 File Offset: 0x00655980
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

	// Token: 0x0400B817 RID: 47127
	[Nullable(2)]
	public Action<int> OnSelectedCallback;

	// Token: 0x020084EB RID: 34027
	private enum EWeeklyRogueInfoViewRoleItemDefine
	{
		// Token: 0x0402AD90 RID: 175504
		TextureIcon,
		// Token: 0x0402AD91 RID: 175505
		SpriteSelect,
		// Token: 0x0402AD92 RID: 175506
		SpriteHover,
		// Token: 0x0402AD93 RID: 175507
		SpriteNormal,
		// Token: 0x0402AD94 RID: 175508
		ItemSkillBranch,
		// Token: 0x0402AD95 RID: 175509
		ExtendToggle
	}
}
