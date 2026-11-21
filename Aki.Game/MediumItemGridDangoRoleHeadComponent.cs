using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DC7 RID: 3527
public class MediumItemGridDangoRoleHeadComponent : MediumItemGridComponent
{
	// Token: 0x06008FE0 RID: 36832 RVA: 0x002B4214 File Offset: 0x002B2414
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

	// Token: 0x06008FE1 RID: 36833 RVA: 0x002B429E File Offset: 0x002B249E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRole";
	}

	// Token: 0x06008FE2 RID: 36834 RVA: 0x002B42A8 File Offset: 0x002B24A8
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

	// Token: 0x02007008 RID: 28680
	private class EChildType
	{
		// Token: 0x04024973 RID: 149875
		public const int HeadTexture = 0;

		// Token: 0x04024974 RID: 149876
		public const int LightSprite = 1;

		// Token: 0x04024975 RID: 149877
		public const int SpriteBg = 2;
	}
}
