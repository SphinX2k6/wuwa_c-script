using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02000E4B RID: 3659
public class SmallItemGridRoleHeadComponent : SmallItemGridComponent
{
	// Token: 0x06009331 RID: 37681 RVA: 0x002BE4F4 File Offset: 0x002BC6F4
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

	// Token: 0x06009332 RID: 37682 RVA: 0x002BE57E File Offset: 0x002BC77E
	protected override void OnStart()
	{
		this.RefreshSpriteBg();
		this.RefreshLightBg();
	}

	// Token: 0x06009333 RID: 37683 RVA: 0x002BE58C File Offset: 0x002BC78C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleS";
	}

	// Token: 0x06009334 RID: 37684 RVA: 0x002BE594 File Offset: 0x002BC794
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

	// Token: 0x06009335 RID: 37685 RVA: 0x002BE638 File Offset: 0x002BC838
	private void RefreshSpriteBg()
	{
		UUISprite sprite = base.GetSprite(2);
		sprite.SetUIActive(true);
		string visionHeadSprBgA = PhantomBattleConfig.Instance.GetVisionHeadSprBgA();
		this.SetSpriteByPath(visionHeadSprBgA, sprite, false, null, null);
	}

	// Token: 0x06009336 RID: 37686 RVA: 0x002BE674 File Offset: 0x002BC874
	private void RefreshLightBg()
	{
		UUISprite sprite = base.GetSprite(1);
		sprite.SetUIActive(true);
		string visionHeadLightBgA = PhantomBattleConfig.Instance.GetVisionHeadLightBgA();
		this.SetSpriteByPath(visionHeadLightBgA, sprite, false, null, null);
	}

	// Token: 0x0200705B RID: 28763
	private class EChildType
	{
		// Token: 0x04024A4B RID: 150091
		public const int RoleHeadTexture = 0;

		// Token: 0x04024A4C RID: 150092
		public const int LightSprite = 1;

		// Token: 0x04024A4D RID: 150093
		public const int SpriteBg = 2;
	}
}
