using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200190E RID: 6414
public class MediumItemGridDangoRoleHeadComponent : MediumItemGridComponent
{
	// Token: 0x0600BBF6 RID: 48118 RVA: 0x002A9AB8 File Offset: 0x002A7CB8
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

	// Token: 0x0600BBF7 RID: 48119 RVA: 0x002A9B42 File Offset: 0x002A7D42
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRole";
	}

	// Token: 0x0600BBF8 RID: 48120 RVA: 0x002A9B4C File Offset: 0x002A7D4C
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		DangoRoleHeadInfo dangoRoleHeadInfo = data as DangoRoleHeadInfo;
		if (dangoRoleHeadInfo == null)
		{
			return;
		}
		int? dangoConfigId = dangoRoleHeadInfo.DangoConfigId;
		if (dangoConfigId != null)
		{
			int? num = dangoConfigId;
			int num2 = 0;
			if (!(num.GetValueOrDefault() <= num2 & num != null))
			{
				AbyssLittleRole? dangoRoleById = DangoAbyssConfig.Instance.GetDangoRoleById(dangoConfigId.Value);
				if (dangoRoleById == null)
				{
					base.SetUiActive(false);
					return;
				}
				UUITexture texture = base.GetTexture(0);
				base.SetTextureByPath(dangoRoleById.Value.Icon, texture, null, null);
				UUISprite sprite = base.GetSprite(1);
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				base.SetUiActive(true);
				return;
			}
		}
		base.SetUiActive(false);
	}

	// Token: 0x02007E81 RID: 32385
	private class EChildType
	{
		// Token: 0x04029647 RID: 169543
		public const int HeadTexture = 0;

		// Token: 0x04029648 RID: 169544
		public const int LightSprite = 1;

		// Token: 0x04029649 RID: 169545
		public const int SpriteBg = 2;
	}
}
