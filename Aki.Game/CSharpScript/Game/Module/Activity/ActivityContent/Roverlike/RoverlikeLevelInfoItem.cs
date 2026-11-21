using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050DD RID: 20701
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeLevelInfoItem : GridProxyAbstract<RoverlikeLevelInfoItemData>
	{
		// Token: 0x06033CC9 RID: 212169 RVA: 0x00E7F634 File Offset: 0x00E7D834
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

		// Token: 0x06033CCA RID: 212170 RVA: 0x00E7F67C File Offset: 0x00E7D87C
		public override void Refresh(RoverlikeLevelInfoItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, data.TextId, data.Params);
		}

		// Token: 0x06033CCB RID: 212171 RVA: 0x00E7F6AC File Offset: 0x00E7D8AC
		public void PlayRefreshAnim()
		{
		}

		// Token: 0x06033CCC RID: 212172 RVA: 0x00E7F6AE File Offset: 0x00E7D8AE
		public override object GetKey(RoverlikeLevelInfoItemData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200ADA5 RID: 44453
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A6C RID: 219756
			public const int TxtInfo = 0;
		}
	}
}
