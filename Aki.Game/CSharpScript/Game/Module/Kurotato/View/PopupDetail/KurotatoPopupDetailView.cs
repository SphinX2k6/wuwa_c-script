using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.View.Overview;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.PopupDetail
{
	// Token: 0x0200573C RID: 22332
	public class KurotatoPopupDetailView : UiViewBase
	{
		// Token: 0x06038C60 RID: 232544 RVA: 0x00D7A8C7 File Offset: 0x00D78AC7
		[NullableContext(1)]
		public KurotatoPopupDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038C61 RID: 232545 RVA: 0x00D7A8DC File Offset: 0x00D78ADC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C62 RID: 232546 RVA: 0x00D7A984 File Offset: 0x00D78B84
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoPopupDetailView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoPopupDetailView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C63 RID: 232547 RVA: 0x00D7A9C7 File Offset: 0x00D78BC7
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401DC81 RID: 121985
		[Nullable(1)]
		private readonly KurotatoAttributePanel AttributePanel = new KurotatoAttributePanel();

		// Token: 0x0200B91C RID: 47388
		private enum EComponents
		{
			// Token: 0x04037FC0 RID: 229312
			ItemAttrView,
			// Token: 0x04037FC1 RID: 229313
			BtnClose
		}
	}
}
