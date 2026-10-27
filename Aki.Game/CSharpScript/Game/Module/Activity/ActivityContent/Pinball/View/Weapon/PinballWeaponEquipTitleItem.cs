using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E3 RID: 25315
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballWeaponEquipTitleItem : SyncGridProxyAbstract<IPinballWeaponEquipTitleItemData>
	{
		// Token: 0x0603FB15 RID: 260885 RVA: 0x00F68C84 File Offset: 0x00F66E84
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

		// Token: 0x0603FB16 RID: 260886 RVA: 0x00F68D30 File Offset: 0x00F66F30
		[NullableContext(1)]
		public override void Refresh(IPinballWeaponEquipTitleItemData data)
		{
			UUIText text = base.GetText(2);
			TableTextArgNew descTextData = data.DescTextData;
			LguiUtil.Instance.SetLocalTextNew(text, descTextData.TextKey ?? "", descTextData.Params);
			this.SetSpriteByPath(data.TypeIconPath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0200C4CF RID: 50383
		private enum EComponent
		{
			// Token: 0x0403B639 RID: 243257
			BgSprite,
			// Token: 0x0403B63A RID: 243258
			TypeIconSprite,
			// Token: 0x0403B63B RID: 243259
			NameText,
			// Token: 0x0403B63C RID: 243260
			StateIconSprite
		}
	}
}
