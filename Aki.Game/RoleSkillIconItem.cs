using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E2B RID: 7723
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillIconItem : UiPanelBase
{
	// Token: 0x060131AF RID: 78255 RVA: 0x00595A8F File Offset: 0x00593C8F
	public RoleSkillIconItem(UUIItem uiItem, bool useTexture = false)
	{
		this.UseTexture = useTexture;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060131B0 RID: 78256 RVA: 0x00595AAC File Offset: 0x00593CAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		if (this.UseTexture)
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(1, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIExtendToggleTextureTransition)));
		}
		else
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(1, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIExtendToggleSpriteTransition)));
		}
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleCallBackInternal));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060131B1 RID: 78257 RVA: 0x00595C76 File Offset: 0x00593E76
	private void ToggleCallBackInternal(EToggleState toggleState)
	{
		Action toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack();
	}

	// Token: 0x060131B2 RID: 78258 RVA: 0x00595C88 File Offset: 0x00593E88
	public void Update(int roleId, int skillNodeId)
	{
		this.SetId(roleId, skillNodeId);
		this.Refresh();
	}

	// Token: 0x060131B3 RID: 78259 RVA: 0x00595C98 File Offset: 0x00593E98
	public void SetId(int roleId, int skillNodeId)
	{
		this.RoleId = roleId;
		this.SkillNodeId = skillNodeId;
		this.SkillTreeNodeConfig = new SkillTree?(RoleSkillConfig.Instance.GetSkillTreeNode(this.SkillNodeId).Value);
		int skillId = this.SkillTreeNodeConfig.Value.SkillId;
		this.SkillId = skillId;
		this.SkillConfig = ((this.SkillId > 0) ? RoleSkillConfig.Instance.GetSkillConfigById(skillId) : null);
		this.UpgradeSkillId = ((skillId > 0) ? RoleModel.Instance.GetUpgradeSkillIdIfUpgraded(skillId, roleId) : 0);
		this.UpgradeSkillConfig = ((this.UpgradeSkillId > 0) ? RoleSkillConfig.Instance.GetSkillConfigById(this.UpgradeSkillId) : null);
	}

	// Token: 0x060131B4 RID: 78260 RVA: 0x00595D59 File Offset: 0x00593F59
	public void Refresh()
	{
		this.RefreshSkillIcon();
		this.RefreshState();
	}

	// Token: 0x060131B5 RID: 78261 RVA: 0x00595D68 File Offset: 0x00593F68
	public void RefreshState()
	{
		int roleSkillTreeNodeLevel = RoleModel.Instance.GetRoleSkillTreeNodeLevel(this.RoleId, this.SkillNodeId);
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(roleSkillTreeNodeLevel > 0);
		}
		UUIItem uuiitem = this.UseTexture ? base.GetTexture(5) : base.GetSprite(5);
		if (uuiitem != null)
		{
			UUIItem uuiitem2 = uuiitem;
			bool bUseChangeColor = roleSkillTreeNodeLevel > 0;
			FColor? fcolor = new FColor?(uuiitem.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor, fcolor);
		}
		uuiitem = (this.UseTexture ? base.GetTexture(6) : base.GetSprite(6));
		if (uuiitem != null)
		{
			UUIItem uuiitem3 = uuiitem;
			bool bUseChangeColor2 = roleSkillTreeNodeLevel > 0;
			FColor? fcolor = new FColor?(uuiitem.changeColor);
			uuiitem3.SetChangeColor(bUseChangeColor2, fcolor);
		}
		ESkillTreeNodeState? roleSkillTreeNodeState = RoleModel.Instance.GetRoleSkillTreeNodeState(this.RoleId, this.SkillNodeId);
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(roleSkillTreeNodeState.GetValueOrDefault() == ESkillTreeNodeState.Lock);
		}
		UUIItem item3 = base.GetItem(3);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(roleSkillTreeNodeState.GetValueOrDefault() != ESkillTreeNodeState.Lock && roleSkillTreeNodeLevel == 0);
	}

	// Token: 0x060131B6 RID: 78262 RVA: 0x00595E60 File Offset: 0x00594060
	public void RefreshSkillIcon()
	{
		string text;
		if (this.SkillId > 0 && this.SkillConfig != null)
		{
			text = this.SkillConfig.Value.Icon;
		}
		else
		{
			text = this.SkillTreeNodeConfig.Value.PropertyNodeIcon;
		}
		if (!string.IsNullOrEmpty(text))
		{
			this.SetSkillIconByPath(text);
		}
	}

	// Token: 0x060131B7 RID: 78263 RVA: 0x00595EBE File Offset: 0x005940BE
	private void SetSkillIconByPath(string iconPath)
	{
		if (this.UseTexture)
		{
			this.SetIconByTexture(1, iconPath);
			this.SetIconByTexture(5, iconPath);
			this.SetIconByTexture(6, iconPath);
			return;
		}
		this.SetIconBySprite(1, iconPath);
		this.SetIconBySprite(5, iconPath);
		this.SetIconBySprite(6, iconPath);
	}

	// Token: 0x060131B8 RID: 78264 RVA: 0x00595EFC File Offset: 0x005940FC
	private void SetIconByTexture(int name, string iconPath)
	{
		UUITexture iconTexture = base.GetTexture(name);
		if (iconTexture != null)
		{
			UUIExtendToggleTextureTransition transition = base.GetUiExtendToggleTextureTransition(7);
			Action<bool> callback = null;
			if (transition != null)
			{
				callback = delegate(bool _)
				{
					UUIExtendToggleTextureTransition transition = transition;
					if (transition == null)
					{
						return;
					}
					transition.SetAllTransitionStateTexture(iconTexture.GetTexture());
				};
			}
			base.SetTextureByPath(iconPath, iconTexture, null, callback);
		}
	}

	// Token: 0x060131B9 RID: 78265 RVA: 0x00595F60 File Offset: 0x00594160
	private void SetIconBySprite(int name, string iconPath)
	{
		UUISprite iconSprite = base.GetSprite(name);
		if (iconSprite != null)
		{
			UUIExtendToggleSpriteTransition transition = base.GetUiExtendToggleSpriteTransition(7);
			Action<bool> callback = null;
			if (transition != null)
			{
				callback = delegate(bool _)
				{
					UUIExtendToggleSpriteTransition transition = transition;
					if (transition == null)
					{
						return;
					}
					transition.SetAllStateSprite(iconSprite.GetSprite());
				};
			}
			this.SetSpriteByPath(iconPath, iconSprite, false, null, callback);
		}
	}

	// Token: 0x060131BA RID: 78266 RVA: 0x00595FC4 File Offset: 0x005941C4
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x060131BB RID: 78267 RVA: 0x00595FCC File Offset: 0x005941CC
	public int GetSkillNodeId()
	{
		return this.SkillNodeId;
	}

	// Token: 0x060131BC RID: 78268 RVA: 0x00595FD4 File Offset: 0x005941D4
	public int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x060131BD RID: 78269 RVA: 0x00595FDC File Offset: 0x005941DC
	public int GetUpgradeSkillId()
	{
		return this.UpgradeSkillId;
	}

	// Token: 0x060131BE RID: 78270 RVA: 0x00595FE4 File Offset: 0x005941E4
	public SkillTree? GetSkillTreeNodeConfig()
	{
		return this.SkillTreeNodeConfig;
	}

	// Token: 0x060131BF RID: 78271 RVA: 0x00595FEC File Offset: 0x005941EC
	public Aki.Config.Skill? GetSkillConfig()
	{
		return this.SkillConfig;
	}

	// Token: 0x060131C0 RID: 78272 RVA: 0x00595FF4 File Offset: 0x005941F4
	public Aki.Config.Skill? GetUpgradeSkillConfig()
	{
		return this.UpgradeSkillConfig;
	}

	// Token: 0x060131C1 RID: 78273 RVA: 0x00595FFC File Offset: 0x005941FC
	public void SetToggleCallBack(Action callBack)
	{
		this.ToggleCallBack = callBack;
	}

	// Token: 0x060131C2 RID: 78274 RVA: 0x00596005 File Offset: 0x00594205
	public void SetToggleState(EToggleState state, bool bFireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x060131C3 RID: 78275 RVA: 0x00596018 File Offset: 0x00594218
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(0).GetRootComponent();
	}

	// Token: 0x0400A416 RID: 42006
	private int RoleId;

	// Token: 0x0400A417 RID: 42007
	private int SkillNodeId;

	// Token: 0x0400A418 RID: 42008
	private int SkillId;

	// Token: 0x0400A419 RID: 42009
	private int UpgradeSkillId;

	// Token: 0x0400A41A RID: 42010
	private SkillTree? SkillTreeNodeConfig;

	// Token: 0x0400A41B RID: 42011
	private Aki.Config.Skill? SkillConfig;

	// Token: 0x0400A41C RID: 42012
	private Aki.Config.Skill? UpgradeSkillConfig;

	// Token: 0x0400A41D RID: 42013
	[Nullable(2)]
	private Action ToggleCallBack;

	// Token: 0x0400A41E RID: 42014
	private readonly bool UseTexture;

	// Token: 0x020080F6 RID: 33014
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04029B3C RID: 170812
		Toggle,
		// Token: 0x04029B3D RID: 170813
		Icon,
		// Token: 0x04029B3E RID: 170814
		ActivatedItem,
		// Token: 0x04029B3F RID: 170815
		InactiveItem,
		// Token: 0x04029B40 RID: 170816
		LockItem,
		// Token: 0x04029B41 RID: 170817
		ExIcon1,
		// Token: 0x04029B42 RID: 170818
		ExIcon2,
		// Token: 0x04029B43 RID: 170819
		ExtendToggleTransition
	}
}
