using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028B0 RID: 10416
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillIconItem : UiPanelBase
{
	// Token: 0x060157AF RID: 87983 RVA: 0x0056AC47 File Offset: 0x00568E47
	public RoleSkillIconItem(UUIItem uiItem, bool useTexture = false)
	{
		this.UseTexture = useTexture;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060157B0 RID: 87984 RVA: 0x0056AC64 File Offset: 0x00568E64
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

	// Token: 0x060157B1 RID: 87985 RVA: 0x0056AE2E File Offset: 0x0056902E
	private void ToggleCallBackInternal(EToggleState toggleState)
	{
		Action toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack();
	}

	// Token: 0x060157B2 RID: 87986 RVA: 0x0056AE40 File Offset: 0x00569040
	public void Update(int roleId, int skillNodeId)
	{
		this.SetId(roleId, skillNodeId);
		this.Refresh();
	}

	// Token: 0x060157B3 RID: 87987 RVA: 0x0056AE50 File Offset: 0x00569050
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

	// Token: 0x060157B4 RID: 87988 RVA: 0x0056AF11 File Offset: 0x00569111
	public void Refresh()
	{
		this.RefreshSkillIcon();
		this.RefreshState();
	}

	// Token: 0x060157B5 RID: 87989 RVA: 0x0056AF20 File Offset: 0x00569120
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

	// Token: 0x060157B6 RID: 87990 RVA: 0x0056B018 File Offset: 0x00569218
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

	// Token: 0x060157B7 RID: 87991 RVA: 0x0056B076 File Offset: 0x00569276
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

	// Token: 0x060157B8 RID: 87992 RVA: 0x0056B0B4 File Offset: 0x005692B4
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

	// Token: 0x060157B9 RID: 87993 RVA: 0x0056B118 File Offset: 0x00569318
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

	// Token: 0x060157BA RID: 87994 RVA: 0x0056B17C File Offset: 0x0056937C
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x060157BB RID: 87995 RVA: 0x0056B184 File Offset: 0x00569384
	public int GetSkillNodeId()
	{
		return this.SkillNodeId;
	}

	// Token: 0x060157BC RID: 87996 RVA: 0x0056B18C File Offset: 0x0056938C
	public int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x060157BD RID: 87997 RVA: 0x0056B194 File Offset: 0x00569394
	public int GetUpgradeSkillId()
	{
		return this.UpgradeSkillId;
	}

	// Token: 0x060157BE RID: 87998 RVA: 0x0056B19C File Offset: 0x0056939C
	public SkillTree? GetSkillTreeNodeConfig()
	{
		return this.SkillTreeNodeConfig;
	}

	// Token: 0x060157BF RID: 87999 RVA: 0x0056B1A4 File Offset: 0x005693A4
	public Aki.Config.Skill? GetSkillConfig()
	{
		return this.SkillConfig;
	}

	// Token: 0x060157C0 RID: 88000 RVA: 0x0056B1AC File Offset: 0x005693AC
	public Aki.Config.Skill? GetUpgradeSkillConfig()
	{
		return this.UpgradeSkillConfig;
	}

	// Token: 0x060157C1 RID: 88001 RVA: 0x0056B1B4 File Offset: 0x005693B4
	public void SetToggleCallBack(Action callBack)
	{
		this.ToggleCallBack = callBack;
	}

	// Token: 0x060157C2 RID: 88002 RVA: 0x0056B1BD File Offset: 0x005693BD
	public void SetToggleState(EToggleState state, bool bFireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x060157C3 RID: 88003 RVA: 0x0056B1D0 File Offset: 0x005693D0
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(0).GetRootComponent();
	}

	// Token: 0x0400A02D RID: 41005
	private int RoleId;

	// Token: 0x0400A02E RID: 41006
	private int SkillNodeId;

	// Token: 0x0400A02F RID: 41007
	private int SkillId;

	// Token: 0x0400A030 RID: 41008
	private int UpgradeSkillId;

	// Token: 0x0400A031 RID: 41009
	private SkillTree? SkillTreeNodeConfig;

	// Token: 0x0400A032 RID: 41010
	private Aki.Config.Skill? SkillConfig;

	// Token: 0x0400A033 RID: 41011
	private Aki.Config.Skill? UpgradeSkillConfig;

	// Token: 0x0400A034 RID: 41012
	[Nullable(2)]
	private Action ToggleCallBack;

	// Token: 0x0400A035 RID: 41013
	private readonly bool UseTexture;

	// Token: 0x02008EAF RID: 36527
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E43F RID: 189503
		Toggle,
		// Token: 0x0402E440 RID: 189504
		Icon,
		// Token: 0x0402E441 RID: 189505
		ActivatedItem,
		// Token: 0x0402E442 RID: 189506
		InactiveItem,
		// Token: 0x0402E443 RID: 189507
		LockItem,
		// Token: 0x0402E444 RID: 189508
		ExIcon1,
		// Token: 0x0402E445 RID: 189509
		ExIcon2,
		// Token: 0x0402E446 RID: 189510
		ExtendToggleTransition
	}
}
