using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.DreamLink;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.AdvanceNotice
{
	// Token: 0x0200587B RID: 22651
	public class AdvanceNoticeRoleItemView : AdvanceNoticeItemView
	{
		// Token: 0x06037D2E RID: 228654 RVA: 0x00F9CCC8 File Offset: 0x00F9AEC8
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

		// Token: 0x06037D2F RID: 228655 RVA: 0x00F9CD52 File Offset: 0x00F9AF52
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

		// Token: 0x0200B498 RID: 46232
		private enum EComponent
		{
			// Token: 0x04037D90 RID: 228752
			DescItem,
			// Token: 0x04037D91 RID: 228753
			ThemeTextTexture,
			// Token: 0x04037D92 RID: 228754
			SpineActor
		}
	}
}
