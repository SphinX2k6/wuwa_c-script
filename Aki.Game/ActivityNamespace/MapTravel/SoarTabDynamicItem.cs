using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x020044D0 RID: 17616
	[NullableContext(1)]
	[Nullable(0)]
	public class SoarTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<SoarChallengePlayData>
	{
		// Token: 0x0602D647 RID: 185927 RVA: 0x00A3E5A4 File Offset: 0x00A3C7A4
		public UniTask Init(UUIItem actor)
		{
			SoarTabDynamicItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<SoarTabDynamicItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602D648 RID: 185928 RVA: 0x00A3E5F0 File Offset: 0x00A3C7F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D649 RID: 185929 RVA: 0x00A3E65C File Offset: 0x00A3C85C
		public FVector2D GetItemSize(SoarChallengePlayData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0602D64A RID: 185930 RVA: 0x00A3E695 File Offset: 0x00A3C895
		public void ClearItem()
		{
		}

		// Token: 0x04018473 RID: 99443
		private Vector2D VectorValue;

		// Token: 0x0200A713 RID: 42771
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04032758 RID: 206680
			public const int NormalItem = 0;

			// Token: 0x04032759 RID: 206681
			public const int LockItem = 1;
		}
	}
}
