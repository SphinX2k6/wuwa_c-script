using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02000E01 RID: 3585
[NullableContext(1)]
[Nullable(0)]
public class MediumItemGridVisionRoleHeadComponent : MediumItemGridComponent
{
	// Token: 0x060090FE RID: 37118 RVA: 0x002B6DB8 File Offset: 0x002B4FB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060090FF RID: 37119 RVA: 0x002B6E42 File Offset: 0x002B5042
	protected override string GetResourceId()
	{
		return "UiItem_ItemRole";
	}

	// Token: 0x06009100 RID: 37120 RVA: 0x002B6E4C File Offset: 0x002B504C
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
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId.Value, true);
		if (roleDataById == null)
		{
			this.SetActive(false);
			return;
		}
		UUITexture roleHeadTexture = base.GetTexture(0);
		int roleSkinId = roleDataById.GetRoleSkinId();
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId);
		string text = (roleSkinConfig != null) ? roleSkinConfig.GetValueOrDefault().Card : null;
		if (string.IsNullOrEmpty(text))
		{
			this.SetActive(false);
			return;
		}
		UUITexture roleHeadTexture3 = roleHeadTexture;
		if (roleHeadTexture3 != null)
		{
			roleHeadTexture3.SetUIActive(false);
		}
		base.SetRoleSkinIcon(text, roleHeadTexture, roleSkinId, null, delegate(bool _)
		{
			UUITexture roleHeadTexture2 = roleHeadTexture;
			if (roleHeadTexture2 == null)
			{
				return;
			}
			roleHeadTexture2.SetUIActive(true);
		});
		this.RefreshSpriteBg(visionRoleHeadInfo);
		this.RefreshLightBg(visionRoleHeadInfo);
		this.SetActive(true);
	}

	// Token: 0x06009101 RID: 37121 RVA: 0x002B6F40 File Offset: 0x002B5140
	private void RefreshSpriteBg(VisionRoleHeadInfo roleHeadInfo)
	{
		int? visionUniqueId = roleHeadInfo.VisionUniqueId;
		if (PhantomBattleModel.Instance.GetPhantomBattleData(visionUniqueId.Value) != null)
		{
			string path;
			if (PhantomBattleModel.Instance.CheckPhantomIsMain(visionUniqueId.Value))
			{
				path = PhantomBattleConfig.Instance.GetVisionHeadSprBgB();
			}
			else
			{
				path = PhantomBattleConfig.Instance.GetVisionHeadSprBgA();
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

	// Token: 0x06009102 RID: 37122 RVA: 0x002B6FC0 File Offset: 0x002B51C0
	private void RefreshLightBg(VisionRoleHeadInfo roleHeadInfo)
	{
		int? visionUniqueId = roleHeadInfo.VisionUniqueId;
		if (PhantomBattleModel.Instance.GetPhantomBattleData(visionUniqueId.Value) != null)
		{
			string path;
			if (PhantomBattleModel.Instance.CheckPhantomIsMain(visionUniqueId.Value))
			{
				path = PhantomBattleConfig.Instance.GetVisionHeadLightBgB();
			}
			else
			{
				path = PhantomBattleConfig.Instance.GetVisionHeadLightBgA();
			}
			this.SetSpriteByPath(path, base.GetSprite(1), false, null, null);
		}
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(true);
	}

	// Token: 0x02007033 RID: 28723
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040249C5 RID: 149957
		public const int RoleHeadTexture = 0;

		// Token: 0x040249C6 RID: 149958
		public const int LightSprite = 1;

		// Token: 0x040249C7 RID: 149959
		public const int SpriteBg = 2;
	}
}
