using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005667 RID: 22119
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposeGroupTitleItem : SyncGridProxyAbstract<ComposeGroupTitleData_Data>
	{
		// Token: 0x0603844D RID: 230477 RVA: 0x00D56088 File Offset: 0x00D54288
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603844E RID: 230478 RVA: 0x00D560D0 File Offset: 0x00D542D0
		[NullableContext(1)]
		public override void Refresh(ComposeGroupTitleData_Data data)
		{
			if (!data.IsEmpty)
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleTextId, new <>z__ReadOnlySingleElementList<object>(data.TitleParam));
				return;
			}
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x0200B823 RID: 47139
		private class ETitleComp
		{
			// Token: 0x04037B77 RID: 228215
			public const int TxtTitle = 0;
		}
	}
}
