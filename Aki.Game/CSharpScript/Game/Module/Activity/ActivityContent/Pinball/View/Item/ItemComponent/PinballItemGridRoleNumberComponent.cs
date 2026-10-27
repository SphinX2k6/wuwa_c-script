using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x0200635C RID: 25436
	public class PinballItemGridRoleNumberComponent : PinballItemGridComponentBase
	{
		// Token: 0x0604000A RID: 262154 RVA: 0x00F7BB68 File Offset: 0x00F79D68
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

		// Token: 0x0604000B RID: 262155 RVA: 0x00F7BBB0 File Offset: 0x00F79DB0
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseNum";
		}

		// Token: 0x0604000C RID: 262156 RVA: 0x00F7BBB8 File Offset: 0x00F79DB8
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

		// Token: 0x0200C57E RID: 50558
		private enum EComponent
		{
			// Token: 0x0403B9B8 RID: 244152
			NumberSprite
		}
	}
}
