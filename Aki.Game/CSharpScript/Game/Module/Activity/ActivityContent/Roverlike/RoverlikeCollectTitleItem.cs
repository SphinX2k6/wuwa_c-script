using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006120 RID: 24864
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeCollectTitleItem : SyncGridProxyAbstract<IRoverlikeCollectTitleData>
	{
		// Token: 0x0603EDE1 RID: 257505 RVA: 0x00F2F0D0 File Offset: 0x00F2D2D0
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

		// Token: 0x0603EDE2 RID: 257506 RVA: 0x00F2F118 File Offset: 0x00F2D318
		[NullableContext(1)]
		public override void Refresh(IRoverlikeCollectTitleData data)
		{
			if (!StringUtils.IsEmpty(data.TitleKey))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleKey, Array.Empty<object>());
			}
		}

		// Token: 0x0200C37E RID: 50046
		private enum EComponents
		{
			// Token: 0x0403AFEC RID: 241644
			TxtName
		}
	}
}
