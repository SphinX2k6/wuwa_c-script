using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x0200198E RID: 6542
public class SmallItemGridRoleHeadComponent : SmallItemGridComponent
{
	// Token: 0x0600BF29 RID: 48937 RVA: 0x002B3570 File Offset: 0x002B1770
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

	// Token: 0x0600BF2A RID: 48938 RVA: 0x002B35FA File Offset: 0x002B17FA
	protected override void OnStart()
	{
		this.RefreshSpriteBg();
		this.RefreshLightBg();
	}

	// Token: 0x0600BF2B RID: 48939 RVA: 0x002B3608 File Offset: 0x002B1808
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleS";
	}

	// Token: 0x0600BF2C RID: 48940 RVA: 0x002B3610 File Offset: 0x002B1810
	[NullableContext(2)]
	protected override void OnRefresh(object roleSkinId)
	{
		if (roleSkinId == null)
		{
			this.SetActive(false);
			return;
		}
		int num = (int)roleSkinId;
		UUITexture roleHeadTexture = base.GetTexture(0);
		RoleSkin? roleSkin;
		string text = (SkinConfig.Instance.GetRoleSkinConfig(num) != null) ? roleSkin.GetValueOrDefault().Card : null;
		if (string.IsNullOrEmpty(text))
		{
			this.SetActive(false);
			return;
		}
		roleHeadTexture.SetUIActive(false);
		base.SetRoleSkinIcon(text, roleHeadTexture, num, null, delegate(bool _)
		{
			roleHeadTexture.SetUIActive(true);
		});
		this.SetActive(true);
	}

	// Token: 0x0600BF2D RID: 48941 RVA: 0x002B36B4 File Offset: 0x002B18B4
	private void RefreshSpriteBg()
	{
		UUISprite sprite = base.GetSprite(2);
		sprite.SetUIActive(true);
		string visionHeadSprBgA = PhantomBattleConfig.Instance.GetVisionHeadSprBgA();
		this.SetSpriteByPath(visionHeadSprBgA, sprite, false, null, null);
	}

	// Token: 0x0600BF2E RID: 48942 RVA: 0x002B36F0 File Offset: 0x002B18F0
	private void RefreshLightBg()
	{
		UUISprite sprite = base.GetSprite(1);
		sprite.SetUIActive(true);
		string visionHeadLightBgA = PhantomBattleConfig.Instance.GetVisionHeadLightBgA();
		this.SetSpriteByPath(visionHeadLightBgA, sprite, false, null, null);
	}

	// Token: 0x02007ECC RID: 32460
	private class EChildType
	{
		// Token: 0x0402970E RID: 169742
		public const int RoleHeadTexture = 0;

		// Token: 0x0402970F RID: 169743
		public const int LightSprite = 1;

		// Token: 0x04029710 RID: 169744
		public const int SpriteBg = 2;
	}
}
