using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02000E55 RID: 3669
public class SmallItemGridVisionRoleHeadComponent : SmallItemGridComponent
{
	// Token: 0x06009363 RID: 37731 RVA: 0x002BEC30 File Offset: 0x002BCE30
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

	// Token: 0x06009364 RID: 37732 RVA: 0x002BECBA File Offset: 0x002BCEBA
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleS";
	}

	// Token: 0x06009365 RID: 37733 RVA: 0x002BECC4 File Offset: 0x002BCEC4
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

	// Token: 0x06009366 RID: 37734 RVA: 0x002BED7F File Offset: 0x002BCF7F
	private void RefreshSpriteBg(int roleHeadInfo)
	{
		base.GetSprite(2).SetUIActive(false);
	}

	// Token: 0x06009367 RID: 37735 RVA: 0x002BED8E File Offset: 0x002BCF8E
	private void RefreshLightBg(int roleHeadInfo)
	{
		base.GetSprite(1).SetUIActive(true);
	}

	// Token: 0x02007060 RID: 28768
	private class EChildType
	{
		// Token: 0x04024A5C RID: 150108
		public const int RoleHeadTexture = 0;

		// Token: 0x04024A5D RID: 150109
		public const int LightSprite = 1;

		// Token: 0x04024A5E RID: 150110
		public const int SpriteBg = 2;
	}
}
