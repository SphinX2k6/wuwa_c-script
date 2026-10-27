using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EF4 RID: 28404
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DollPlayDescriptionItem : SyncGridProxyAbstract<IDollDescriptionItemData>
	{
		// Token: 0x06045295 RID: 283285 RVA: 0x0111B0B0 File Offset: 0x011192B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06045296 RID: 283286 RVA: 0x0111B119 File Offset: 0x01119319
		public override void Refresh(IDollDescriptionItemData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TextTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TextContent, Array.Empty<object>());
		}
	}
}
