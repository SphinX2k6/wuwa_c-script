using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02000E00 RID: 3584
[NullableContext(1)]
[Nullable(0)]
public class MediumItemGridVisionMainRoleHeadComponent : MediumItemGridComponent
{
	// Token: 0x060090F6 RID: 37110 RVA: 0x002B6A40 File Offset: 0x002B4C40
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060090F7 RID: 37111 RVA: 0x002B6AEB File Offset: 0x002B4CEB
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoverElement";
	}

	// Token: 0x060090F8 RID: 37112 RVA: 0x002B6AF4 File Offset: 0x002B4CF4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		VisionRoleHeadInfo visionRoleHeadInfo = data as VisionRoleHeadInfo;
		if (visionRoleHeadInfo == null)
		{
			return;
		}
		int? roleConfigId = visionRoleHeadInfo.RoleConfigId;
		if (roleConfigId == null)
		{
			this.SetActive(false);
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId.Value);
		if (roleConfig == null)
		{
			this.SetActive(false);
			return;
		}
		this.RefreshRoleHead();
		this.RefreshRoleElement(roleConfig.Value);
		this.RefreshSpriteBg(visionRoleHeadInfo);
		this.RefreshSpriteFrame(visionRoleHeadInfo);
		this.SetActive(true);
	}

	// Token: 0x060090F9 RID: 37113 RVA: 0x002B6B70 File Offset: 0x002B4D70
	private void RefreshRoleHead()
	{
		UUITexture roleHeadTexture = base.GetTexture(0);
		RoleInstance curSelectMainRoleInstance = RoleModel.Instance.GetCurSelectMainRoleInstance();
		if (curSelectMainRoleInstance == null)
		{
			UUITexture roleHeadTexture5 = roleHeadTexture;
			if (roleHeadTexture5 == null)
			{
				return;
			}
			roleHeadTexture5.SetUIActive(false);
			return;
		}
		else
		{
			int roleSkinId = curSelectMainRoleInstance.GetRoleSkinId();
			RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId);
			string text = (roleSkinConfig != null) ? roleSkinConfig.GetValueOrDefault().Card : null;
			if (!string.IsNullOrEmpty(text))
			{
				UUITexture roleHeadTexture2 = roleHeadTexture;
				if (roleHeadTexture2 != null)
				{
					roleHeadTexture2.SetUIActive(false);
				}
				base.SetRoleSkinIcon(text, roleHeadTexture, roleSkinId, null, delegate(bool _)
				{
					UUITexture roleHeadTexture4 = roleHeadTexture;
					if (roleHeadTexture4 == null)
					{
						return;
					}
					roleHeadTexture4.SetUIActive(true);
				});
				return;
			}
			UUITexture roleHeadTexture3 = roleHeadTexture;
			if (roleHeadTexture3 == null)
			{
				return;
			}
			roleHeadTexture3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x060090FA RID: 37114 RVA: 0x002B6C34 File Offset: 0x002B4E34
	private void RefreshRoleElement(RoleInfo roleConfig)
	{
		UUITexture texture = base.GetTexture(1);
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(roleConfig.ElementId);
		if (elementInfo == null)
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			return;
		}
		string itemTexture = elementInfo.Value.ItemTexture;
		if (string.IsNullOrEmpty(itemTexture))
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			return;
		}
		base.SetTextureByPath(itemTexture, texture, null, null);
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
	}

	// Token: 0x060090FB RID: 37115 RVA: 0x002B6CB0 File Offset: 0x002B4EB0
	private void RefreshSpriteBg(VisionRoleHeadInfo roleHeadInfo)
	{
		int? visionUniqueId = roleHeadInfo.VisionUniqueId;
		if (PhantomBattleModel.Instance.GetPhantomBattleData(visionUniqueId.Value) != null)
		{
			string path;
			if (PhantomBattleModel.Instance.CheckPhantomIsMain(visionUniqueId.Value))
			{
				path = PhantomBattleConfig.Instance.GetVisionMainRoleHeadSprBgB();
			}
			else
			{
				path = PhantomBattleConfig.Instance.GetVisionMainRoleHeadSprBgA();
			}
			this.SetSpriteByPath(path, base.GetSprite(2), false, null, null);
		}
		UUISprite sprite = base.GetSprite(2);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(true);
	}

	// Token: 0x060090FC RID: 37116 RVA: 0x002B6D30 File Offset: 0x002B4F30
	private void RefreshSpriteFrame(VisionRoleHeadInfo roleHeadInfo)
	{
		int? visionUniqueId = roleHeadInfo.VisionUniqueId;
		if (PhantomBattleModel.Instance.GetPhantomBattleData(visionUniqueId.Value) != null)
		{
			string path;
			if (PhantomBattleModel.Instance.CheckPhantomIsMain(visionUniqueId.Value))
			{
				path = PhantomBattleConfig.Instance.GetVisionMainRoleHeadFrameBgB();
			}
			else
			{
				path = PhantomBattleConfig.Instance.GetVisionMainRoleHeadFrameBgA();
			}
			this.SetSpriteByPath(path, base.GetSprite(3), false, null, null);
		}
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(true);
	}

	// Token: 0x02007031 RID: 28721
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040249C0 RID: 149952
		public const int RoleHeadTexture = 0;

		// Token: 0x040249C1 RID: 149953
		public const int RoleElementTexture = 1;

		// Token: 0x040249C2 RID: 149954
		public const int BgSprite = 2;

		// Token: 0x040249C3 RID: 149955
		public const int FrameSprite = 3;
	}
}
