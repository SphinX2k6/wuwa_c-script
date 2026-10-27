using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E40 RID: 20032
	public class RoguelikeUnlockTips : UiViewBase
	{
		// Token: 0x06033A4F RID: 211535 RVA: 0x00C16823 File Offset: 0x00C14A23
		[NullableContext(1)]
		public RoguelikeUnlockTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033A50 RID: 211536 RVA: 0x00C1682C File Offset: 0x00C14A2C
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

		// Token: 0x06033A51 RID: 211537 RVA: 0x00C16874 File Offset: 0x00C14A74
		protected override void OnBeforeShow()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "LordGymUnLock", new <>z__ReadOnlySingleElementList<object>(this.OpenParam as string));
		}

		// Token: 0x06033A52 RID: 211538 RVA: 0x00C1689C File Offset: 0x00C14A9C
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200AFFC RID: 45052
		private class EComponents
		{
			// Token: 0x040356D8 RID: 218840
			public const int UnLockText = 0;
		}
	}
}
