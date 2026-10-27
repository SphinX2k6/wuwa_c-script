using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02001998 RID: 6552
public class SmallItemGridVisionRoleHeadComponent : SmallItemGridComponent
{
	// Token: 0x0600BF5B RID: 48987 RVA: 0x002B3CAC File Offset: 0x002B1EAC
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

	// Token: 0x0600BF5C RID: 48988 RVA: 0x002B3D36 File Offset: 0x002B1F36
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleS";
	}

	// Token: 0x0600BF5D RID: 48989 RVA: 0x002B3D40 File Offset: 0x002B1F40
	[NullableContext(2)]
	protected override void OnRefresh(object roleHeadInfo)
	{
		if (roleHeadInfo == null)
		{
			this.SetActive(false);
			return;
		}
		int num = (int)roleHeadInfo;
		if (num == 0)
		{
			this.SetActive(false);
			return;
		}
		UUITexture roleHeadTexture = base.GetTexture(0);
		RoleInfo? roleInfo;
		string text = (RoleConfig.Instance.GetRoleConfig(num) != null) ? roleInfo.GetValueOrDefault().Card : null;
		if (string.IsNullOrEmpty(text))
		{
			this.SetActive(false);
			return;
		}
		roleHeadTexture.SetUIActive(false);
		base.SetRoleIcon(text, roleHeadTexture, num, null, delegate(bool _)
		{
			roleHeadTexture.SetUIActive(true);
		});
		this.RefreshSpriteBg(num);
		this.RefreshLightBg(num);
		this.SetActive(true);
	}

	// Token: 0x0600BF5E RID: 48990 RVA: 0x002B3DFB File Offset: 0x002B1FFB
	private void RefreshSpriteBg(int roleHeadInfo)
	{
		base.GetSprite(2).SetUIActive(false);
	}

	// Token: 0x0600BF5F RID: 48991 RVA: 0x002B3E0A File Offset: 0x002B200A
	private void RefreshLightBg(int roleHeadInfo)
	{
		base.GetSprite(1).SetUIActive(true);
	}

	// Token: 0x02007ED1 RID: 32465
	private class EChildType
	{
		// Token: 0x0402971F RID: 169759
		public const int RoleHeadTexture = 0;

		// Token: 0x04029720 RID: 169760
		public const int LightSprite = 1;

		// Token: 0x04029721 RID: 169761
		public const int SpriteBg = 2;
	}
}
