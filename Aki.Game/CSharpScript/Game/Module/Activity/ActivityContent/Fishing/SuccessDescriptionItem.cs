using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200662B RID: 26155
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SuccessDescriptionItem : GridProxyAbstract<SingleText>
	{
		// Token: 0x06041913 RID: 268563 RVA: 0x00FE6D54 File Offset: 0x00FE4F54
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

		// Token: 0x06041914 RID: 268564 RVA: 0x00FE6D9C File Offset: 0x00FE4F9C
		public void SetDescriptionText(SingleText text)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), text.TextId, text.Params);
		}

		// Token: 0x06041915 RID: 268565 RVA: 0x00FE6DBB File Offset: 0x00FE4FBB
		public override void Refresh(SingleText data, bool isSelected, int gridIndex)
		{
			this.SetDescriptionText(data);
		}

		// Token: 0x0200C845 RID: 51269
		[NullableContext(0)]
		private class EDescriptionNode
		{
			// Token: 0x0403C7F6 RID: 247798
			public const int TextDescription = 0;
		}
	}
}
