using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D18 RID: 23832
	public class ChatRowDynamicItemSize : UiPanelBase, IDynamicScrollBaseItem<ChatRowData>
	{
		// Token: 0x0603C675 RID: 247413 RVA: 0x00E7B000 File Offset: 0x00E79200
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

		// Token: 0x0603C676 RID: 247414 RVA: 0x00E7B06C File Offset: 0x00E7926C
		[NullableContext(1)]
		public FVector2D GetItemSize(ChatRowData data)
		{
			float width = base.GetItem(1).GetWidth();
			float height = base.GetItem(1).GetHeight();
			return new FVector2D(width, height);
		}

		// Token: 0x0603C677 RID: 247415 RVA: 0x00E7B098 File Offset: 0x00E79298
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			ChatRowDynamicItemSize.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ChatRowDynamicItemSize.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603C678 RID: 247416 RVA: 0x00E7B0E3 File Offset: 0x00E792E3
		public void ClearItem()
		{
		}

		// Token: 0x0200BF8F RID: 49039
		private enum EChild
		{
			// Token: 0x04039CB3 RID: 236723
			RootItem,
			// Token: 0x04039CB4 RID: 236724
			PanelHorizon
		}
	}
}
