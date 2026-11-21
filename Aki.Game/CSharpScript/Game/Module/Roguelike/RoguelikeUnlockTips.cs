using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E09 RID: 15881
	public class RoguelikeUnlockTips : UiViewBase
	{
		// Token: 0x060288BA RID: 166074 RVA: 0x00B5FD4B File Offset: 0x00B5DF4B
		[NullableContext(1)]
		public RoguelikeUnlockTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060288BB RID: 166075 RVA: 0x00B5FD54 File Offset: 0x00B5DF54
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

		// Token: 0x060288BC RID: 166076 RVA: 0x00B5FD9C File Offset: 0x00B5DF9C
		protected override void OnBeforeShow()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "LordGymUnLock", new <>z__ReadOnlySingleElementList<object>(this.OpenParam as string));
		}

		// Token: 0x060288BD RID: 166077 RVA: 0x00B5FDC4 File Offset: 0x00B5DFC4
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x02009A2E RID: 39470
		private class EComponents
		{
			// Token: 0x04030108 RID: 196872
			public const int UnLockText = 0;
		}
	}
}
