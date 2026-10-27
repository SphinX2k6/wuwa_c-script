using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200630B RID: 25355
	public class PinballRoleClassIconItem : UiPanelBase
	{
		// Token: 0x0603FCBB RID: 261307 RVA: 0x00F6F8D4 File Offset: 0x00F6DAD4
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

		// Token: 0x0603FCBC RID: 261308 RVA: 0x00F6F940 File Offset: 0x00F6DB40
		[NullableContext(1)]
		public void Refresh(IPinballRoleClassIconItemData data)
		{
			base.GetSprite(0).SetColor(FColor.FromHex(data.BgColor));
			base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0200C502 RID: 50434
		private enum EComponent
		{
			// Token: 0x0403B753 RID: 243539
			BgSprite,
			// Token: 0x0403B754 RID: 243540
			ClassIconTexture
		}
	}
}
