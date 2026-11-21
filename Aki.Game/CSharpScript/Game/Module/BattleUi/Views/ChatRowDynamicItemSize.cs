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
	// Token: 0x02004CFA RID: 19706
	public class ChatRowDynamicItemSize : UiPanelBase, IDynamicScrollBaseItem<ChatRowData>
	{
		// Token: 0x060315CE RID: 202190 RVA: 0x00DCB680 File Offset: 0x00DC9880
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

		// Token: 0x060315CF RID: 202191 RVA: 0x00DCB6EC File Offset: 0x00DC98EC
		[NullableContext(1)]
		public FVector2D GetItemSize(ChatRowData data)
		{
			float width = base.GetItem(1).GetWidth();
			float height = base.GetItem(1).GetHeight();
			return new FVector2D(width, height);
		}

		// Token: 0x060315D0 RID: 202192 RVA: 0x00DCB718 File Offset: 0x00DC9918
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

		// Token: 0x060315D1 RID: 202193 RVA: 0x00DCB763 File Offset: 0x00DC9963
		public void ClearItem()
		{
		}

		// Token: 0x0200A995 RID: 43413
		private enum EChild
		{
			// Token: 0x04034675 RID: 214645
			RootItem,
			// Token: 0x04034676 RID: 214646
			PanelHorizon
		}
	}
}
