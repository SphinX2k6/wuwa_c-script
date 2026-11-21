using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006075 RID: 24693
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DollDescriptionItem : SyncGridProxyAbstract<IDollDescriptionItemData>
	{
		// Token: 0x0603B441 RID: 242753 RVA: 0x010C4EEC File Offset: 0x010C30EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B442 RID: 242754 RVA: 0x010C4F76 File Offset: 0x010C3176
		protected override void OnStart()
		{
			this.DollIconItem = new DollDescriptionIconItemPanel();
			this.DollIconItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
		}

		// Token: 0x0603B443 RID: 242755 RVA: 0x010C4F9C File Offset: 0x010C319C
		public override void Refresh(IDollDescriptionItemData data)
		{
			DollDescriptionIconItemPanel dollIconItem = this.DollIconItem;
			if (dollIconItem != null)
			{
				dollIconItem.SetIconTexture(data.IconPath);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TextTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.TextContent, Array.Empty<object>());
		}

		// Token: 0x0401F327 RID: 127783
		[Nullable(2)]
		private DollDescriptionIconItemPanel DollIconItem;
	}
}
