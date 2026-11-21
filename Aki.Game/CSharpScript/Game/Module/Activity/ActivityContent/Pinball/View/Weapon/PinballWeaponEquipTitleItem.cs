using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x02005261 RID: 21089
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballWeaponEquipTitleItem : SyncGridProxyAbstract<IPinballWeaponEquipTitleItemData>
	{
		// Token: 0x060347D6 RID: 214998 RVA: 0x00EAFBE0 File Offset: 0x00EADDE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060347D7 RID: 214999 RVA: 0x00EAFC8C File Offset: 0x00EADE8C
		[NullableContext(1)]
		public override void Refresh(IPinballWeaponEquipTitleItemData data)
		{
			UUIText text = base.GetText(2);
			TableTextArgNew descTextData = data.DescTextData;
			LguiUtil.Instance.SetLocalTextNew(text, descTextData.TextKey ?? "", descTextData.Params);
			this.SetSpriteByPath(data.TypeIconPath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0200AEB6 RID: 44726
		private enum EComponent
		{
			// Token: 0x04035F9B RID: 221083
			BgSprite,
			// Token: 0x04035F9C RID: 221084
			TypeIconSprite,
			// Token: 0x04035F9D RID: 221085
			NameText,
			// Token: 0x04035F9E RID: 221086
			StateIconSprite
		}
	}
}
