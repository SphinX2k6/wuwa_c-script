using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200509E RID: 20638
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeCollectTitleItem : SyncGridProxyAbstract<IRoverlikeCollectTitleData>
	{
		// Token: 0x06033AA3 RID: 211619 RVA: 0x00E75EE4 File Offset: 0x00E740E4
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

		// Token: 0x06033AA4 RID: 211620 RVA: 0x00E75F2C File Offset: 0x00E7412C
		[NullableContext(1)]
		public override void Refresh(IRoverlikeCollectTitleData data)
		{
			if (!StringUtils.IsEmpty(data.TitleKey))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleKey, Array.Empty<object>());
			}
		}

		// Token: 0x0200AD66 RID: 44390
		private enum EComponents
		{
			// Token: 0x04035951 RID: 219473
			TxtName
		}
	}
}
