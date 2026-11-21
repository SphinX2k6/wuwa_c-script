using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052DA RID: 21210
	public class PinballItemGridRoleNumberComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CCB RID: 216267 RVA: 0x00EC2AC8 File Offset: 0x00EC0CC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034CCC RID: 216268 RVA: 0x00EC2B10 File Offset: 0x00EC0D10
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseNum";
		}

		// Token: 0x06034CCD RID: 216269 RVA: 0x00EC2B18 File Offset: 0x00EC0D18
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			int num = (int)args[0];
			if (num <= 0)
			{
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ComItemNum0" + num.ToString());
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x0200AF65 RID: 44901
		private enum EComponent
		{
			// Token: 0x0403631A RID: 221978
			NumberSprite
		}
	}
}
