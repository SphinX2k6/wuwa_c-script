using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EF5 RID: 28405
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DollDescriptionItem : SyncGridProxyAbstract<IDollDescriptionItemData>
	{
		// Token: 0x06045298 RID: 283288 RVA: 0x0111B15C File Offset: 0x0111935C
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

		// Token: 0x06045299 RID: 283289 RVA: 0x0111B1E6 File Offset: 0x011193E6
		protected override void OnStart()
		{
			this.DollIconItem = new DollDescriptionIconItemPanel();
			this.DollIconItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
		}

		// Token: 0x0604529A RID: 283290 RVA: 0x0111B20C File Offset: 0x0111940C
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

		// Token: 0x04024074 RID: 147572
		[Nullable(2)]
		private DollDescriptionIconItemPanel DollIconItem;
	}
}
