using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005289 RID: 21129
	public class PinballRoleClassIconItem : UiPanelBase
	{
		// Token: 0x0603497C RID: 215420 RVA: 0x00EB6830 File Offset: 0x00EB4A30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603497D RID: 215421 RVA: 0x00EB689C File Offset: 0x00EB4A9C
		[NullableContext(1)]
		public void Refresh(IPinballRoleClassIconItemData data)
		{
			base.GetSprite(0).SetColor(FColor.FromHex(data.BgColor));
			base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0200AEE9 RID: 44777
		private enum EComponent
		{
			// Token: 0x040360B5 RID: 221365
			BgSprite,
			// Token: 0x040360B6 RID: 221366
			ClassIconTexture
		}
	}
}
