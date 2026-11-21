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
	// Token: 0x02002F5D RID: 12125
	[NullableContext(1)]
	[Nullable(0)]
	public class SoarTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<SoarChallengePlayData>
	{
		// Token: 0x0601CB85 RID: 117637 RVA: 0x008C4204 File Offset: 0x008C2404
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

		// Token: 0x0601CB86 RID: 117638 RVA: 0x008C4250 File Offset: 0x008C2450
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

		// Token: 0x0601CB87 RID: 117639 RVA: 0x008C42BC File Offset: 0x008C24BC
		public FVector2D GetItemSize(SoarChallengePlayData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0601CB88 RID: 117640 RVA: 0x008C42F5 File Offset: 0x008C24F5
		public void ClearItem()
		{
		}

		// Token: 0x0400F21B RID: 61979
		private Vector2D VectorValue;

		// Token: 0x02008BE9 RID: 35817
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402C526 RID: 181542
			public const int NormalItem = 0;

			// Token: 0x0402C527 RID: 181543
			public const int LockItem = 1;
		}
	}
}
