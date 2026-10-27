using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.DreamLink;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.AdvanceNotice
{
	// Token: 0x0200692B RID: 26923
	public class AdvanceNoticeRoleItemView : AdvanceNoticeItemView
	{
		// Token: 0x060431D6 RID: 274902 RVA: 0x0105B69C File Offset: 0x0105989C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060431D7 RID: 274903 RVA: 0x0105B726 File Offset: 0x01059926
		protected override void OnStart()
		{
			base.OnStart();
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			base.GetSpine(2).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
		}

		// Token: 0x0200CAD0 RID: 51920
		private enum EComponent
		{
			// Token: 0x0403D4B6 RID: 251062
			DescItem,
			// Token: 0x0403D4B7 RID: 251063
			ThemeTextTexture,
			// Token: 0x0403D4B8 RID: 251064
			SpineActor
		}
	}
}
