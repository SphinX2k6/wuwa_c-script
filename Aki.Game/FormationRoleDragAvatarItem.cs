using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x020010C9 RID: 4297
public class FormationRoleDragAvatarItem : FormationRoleDragItem
{
	// Token: 0x0600AAD5 RID: 43733 RVA: 0x00325984 File Offset: 0x00323B84
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AAD6 RID: 43734 RVA: 0x00325AB4 File Offset: 0x00323CB4
	public override void RefreshRoleIcon(int configId, int roleSkinId)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(configId);
		if (roleConfig == null)
		{
			return;
		}
		RoleSkin? roleSkin = (roleSkinId != 0) ? SkinConfig.Instance.GetRoleSkinConfig(roleSkinId) : null;
		string path = (roleSkin != null) ? roleSkin.Value.RoleHeadIconCircle : roleConfig.Value.RoleHeadIconCircle;
		base.GetItem(1).SetUIActive(true);
		base.SetTextureByPath(path, base.GetTexture(2), null, null);
	}

	// Token: 0x0600AAD7 RID: 43735 RVA: 0x00325B43 File Offset: 0x00323D43
	public void SetHeadVisible(bool visible)
	{
		base.GetItem(1).SetUIActive(visible);
	}

	// Token: 0x0600AAD8 RID: 43736 RVA: 0x00325B52 File Offset: 0x00323D52
	public void SetLockState(bool active)
	{
		base.GetItem(5).SetUIActive(active);
		base.GetTexture(2).SetUIActive(!active);
	}

	// Token: 0x0600AAD9 RID: 43737 RVA: 0x00325B71 File Offset: 0x00323D71
	public void SetBgLightState(bool active)
	{
		base.GetItem(3).SetUIActive(active);
	}

	// Token: 0x0600AADA RID: 43738 RVA: 0x00325B80 File Offset: 0x00323D80
	public void SetBgVisible(bool visible)
	{
		base.GetItem(7).SetUIActive(visible);
	}

	// Token: 0x0600AADB RID: 43739 RVA: 0x00325B8F File Offset: 0x00323D8F
	public void SetExchangeState(bool active)
	{
		base.GetItem(4).SetUIActive(active);
		this.SetBgLightState(active);
		base.GetItem(0).SetAlpha(active ? 0.7f : 1f);
	}

	// Token: 0x0600AADC RID: 43740 RVA: 0x00325BC0 File Offset: 0x00323DC0
	public void SetDraggingState(bool active)
	{
		base.GetItem(6).SetUIActive(active);
	}

	// Token: 0x0600AADD RID: 43741 RVA: 0x00325BCF File Offset: 0x00323DCF
	public void ResetStates()
	{
		this.SetLockState(false);
		this.SetExchangeState(false);
		this.SetDraggingState(false);
	}

	// Token: 0x04006303 RID: 25347
	[Nullable(1)]
	public const string FORMATION_ROLE_DRAG_AVATAR_PREFAB_PATH = "/Game/Aki/UI/UIResources/UiTeam/Prefabs/UiItem_TeamRoleSlotC.UiItem_TeamRoleSlotC";

	// Token: 0x04006304 RID: 25348
	private const float EXCHANGE_STATE_ALPHA = 0.7f;

	// Token: 0x02007345 RID: 29509
	private enum EChildType
	{
		// Token: 0x0402587C RID: 153724
		DragItem,
		// Token: 0x0402587D RID: 153725
		PanelHead,
		// Token: 0x0402587E RID: 153726
		TexHead,
		// Token: 0x0402587F RID: 153727
		SpriteBgLight,
		// Token: 0x04025880 RID: 153728
		SpriteState,
		// Token: 0x04025881 RID: 153729
		SpriteLock,
		// Token: 0x04025882 RID: 153730
		PanelDrag,
		// Token: 0x04025883 RID: 153731
		TexBg
	}
}
