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
	// Token: 0x02004CF9 RID: 19705
	[NullableContext(1)]
	[Nullable(0)]
	public class ChatRowDynamicItem : UiPanelBase, IDynamicScrollItem<ChatRowData>
	{
		// Token: 0x060315C7 RID: 202183 RVA: 0x00DCB550 File Offset: 0x00DC9750
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

		// Token: 0x060315C8 RID: 202184 RVA: 0x00DCB5B9 File Offset: 0x00DC97B9
		public AUIBaseActor GetUsingItem(ChatRowData data)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}

		// Token: 0x060315C9 RID: 202185 RVA: 0x00DCB5CC File Offset: 0x00DC97CC
		public void Update(ChatRowData chatRowData, int index)
		{
			ChatRowDynamicItemInSide itemInSide = this.ItemInSide;
			if (itemInSide == null)
			{
				return;
			}
			itemInSide.Update(chatRowData, index);
		}

		// Token: 0x060315CA RID: 202186 RVA: 0x00DCB5E0 File Offset: 0x00DC97E0
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

		// Token: 0x060315CB RID: 202187 RVA: 0x00DCB62C File Offset: 0x00DC982C
		private UniTask InitChildItem()
		{
			ChatRowDynamicItem.<InitChildItem>d__6 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<ChatRowDynamicItem.<InitChildItem>d__6>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x060315CC RID: 202188 RVA: 0x00DCB66F File Offset: 0x00DC986F
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0401A248 RID: 107080
		[Nullable(2)]
		private ChatRowDynamicItemInSide ItemInSide;

		// Token: 0x0200A992 RID: 43410
		[NullableContext(0)]
		private enum EChild
		{
			// Token: 0x04034669 RID: 214633
			RootItem,
			// Token: 0x0403466A RID: 214634
			PanelHorizon
		}
	}
}
