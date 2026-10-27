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
	// Token: 0x02005D17 RID: 23831
	[NullableContext(1)]
	[Nullable(0)]
	public class ChatRowDynamicItem : UiPanelBase, IDynamicScrollItem<ChatRowData>
	{
		// Token: 0x0603C66E RID: 247406 RVA: 0x00E7AED0 File Offset: 0x00E790D0
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

		// Token: 0x0603C66F RID: 247407 RVA: 0x00E7AF39 File Offset: 0x00E79139
		public AUIBaseActor GetUsingItem(ChatRowData data)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603C670 RID: 247408 RVA: 0x00E7AF4C File Offset: 0x00E7914C
		public void Update(ChatRowData chatRowData, int index)
		{
			ChatRowDynamicItemInSide itemInSide = this.ItemInSide;
			if (itemInSide == null)
			{
				return;
			}
			itemInSide.Update(chatRowData, index);
		}

		// Token: 0x0603C671 RID: 247409 RVA: 0x00E7AF60 File Offset: 0x00E79160
		public UniTask Init(UUIItem actor)
		{
			ChatRowDynamicItem.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ChatRowDynamicItem.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603C672 RID: 247410 RVA: 0x00E7AFAC File Offset: 0x00E791AC
		private UniTask InitChildItem()
		{
			ChatRowDynamicItem.<InitChildItem>d__6 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<ChatRowDynamicItem.<InitChildItem>d__6>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C673 RID: 247411 RVA: 0x00E7AFEF File Offset: 0x00E791EF
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0401F78F RID: 128911
		[Nullable(2)]
		private ChatRowDynamicItemInSide ItemInSide;

		// Token: 0x0200BF8C RID: 49036
		[NullableContext(0)]
		private enum EChild
		{
			// Token: 0x04039CA7 RID: 236711
			RootItem,
			// Token: 0x04039CA8 RID: 236712
			PanelHorizon
		}
	}
}
