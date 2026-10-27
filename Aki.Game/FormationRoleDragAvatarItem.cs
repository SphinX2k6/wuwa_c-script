using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02001C0A RID: 7178
public class FormationRoleDragAvatarItem : FormationRoleDragItem
{
	// Token: 0x0600D6C2 RID: 54978 RVA: 0x0031A690 File Offset: 0x00318890
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

	// Token: 0x0600D6C3 RID: 54979 RVA: 0x0031A7C0 File Offset: 0x003189C0
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

	// Token: 0x0600D6C4 RID: 54980 RVA: 0x0031A84F File Offset: 0x00318A4F
	public void SetHeadVisible(bool visible)
	{
		base.GetItem(1).SetUIActive(visible);
	}

	// Token: 0x0600D6C5 RID: 54981 RVA: 0x0031A85E File Offset: 0x00318A5E
	public void SetLockState(bool active)
	{
		base.GetItem(5).SetUIActive(active);
		base.GetTexture(2).SetUIActive(!active);
	}

	// Token: 0x0600D6C6 RID: 54982 RVA: 0x0031A87D File Offset: 0x00318A7D
	public void SetBgLightState(bool active)
	{
		base.GetItem(3).SetUIActive(active);
	}

	// Token: 0x0600D6C7 RID: 54983 RVA: 0x0031A88C File Offset: 0x00318A8C
	public void SetBgVisible(bool visible)
	{
		base.GetItem(7).SetUIActive(visible);
	}

	// Token: 0x0600D6C8 RID: 54984 RVA: 0x0031A89B File Offset: 0x00318A9B
	public void SetExchangeState(bool active)
	{
		base.GetItem(4).SetUIActive(active);
		this.SetBgLightState(active);
		base.GetItem(0).SetAlpha(active ? 0.7f : 1f);
	}

	// Token: 0x0600D6C9 RID: 54985 RVA: 0x0031A8CC File Offset: 0x00318ACC
	public void SetDraggingState(bool active)
	{
		base.GetItem(6).SetUIActive(active);
	}

	// Token: 0x0600D6CA RID: 54986 RVA: 0x0031A8DB File Offset: 0x00318ADB
	public void ResetStates()
	{
		this.SetLockState(false);
		this.SetExchangeState(false);
		this.SetDraggingState(false);
	}

	// Token: 0x04006231 RID: 25137
	[Nullable(1)]
	public const string FORMATION_ROLE_DRAG_AVATAR_PREFAB_PATH = "/Game/Aki/UI/UIResources/UiTeam/Prefabs/UiItem_TeamRoleSlotC.UiItem_TeamRoleSlotC";

	// Token: 0x04006232 RID: 25138
	private const float EXCHANGE_STATE_ALPHA = 0.7f;

	// Token: 0x020081BC RID: 33212
	private enum EChildType
	{
		// Token: 0x0402A555 RID: 173397
		DragItem,
		// Token: 0x0402A556 RID: 173398
		PanelHead,
		// Token: 0x0402A557 RID: 173399
		TexHead,
		// Token: 0x0402A558 RID: 173400
		SpriteBgLight,
		// Token: 0x0402A559 RID: 173401
		SpriteState,
		// Token: 0x0402A55A RID: 173402
		SpriteLock,
		// Token: 0x0402A55B RID: 173403
		PanelDrag,
		// Token: 0x0402A55C RID: 173404
		TexBg
	}
}
