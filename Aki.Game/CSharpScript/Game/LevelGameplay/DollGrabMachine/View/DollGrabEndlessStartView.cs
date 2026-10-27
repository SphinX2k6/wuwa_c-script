using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EE0 RID: 28384
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabEndlessStartView : UiViewBase
	{
		// Token: 0x06045240 RID: 283200 RVA: 0x01119E0A File Offset: 0x0111800A
		public DollGrabEndlessStartView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045241 RID: 283201 RVA: 0x01119E14 File Offset: 0x01118014
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnMaskButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06045242 RID: 283202 RVA: 0x01119F1D File Offset: 0x0111811D
		protected override void OnStart()
		{
			this.GenericLayout = new GenericLayout<DollGrabEndlessStartItem, IGrabItemData>(base.GetHorizontalLayout(1), new Func<DollGrabEndlessStartItem>(this.CreateDollGrabEndlessStartItem), null, false, true);
			this.TxtDescri = base.GetText(3);
			this.PnlScroll = base.GetItem(4);
		}

		// Token: 0x06045243 RID: 283203 RVA: 0x01119F5C File Offset: 0x0111815C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabEndlessStartView.<OnBeforeShowAsyncImplementImplement>d__6 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabEndlessStartView.<OnBeforeShowAsyncImplementImplement>d__6>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06045244 RID: 283204 RVA: 0x01119F9F File Offset: 0x0111819F
		private DollGrabEndlessStartItem CreateDollGrabEndlessStartItem()
		{
			return new DollGrabEndlessStartItem();
		}

		// Token: 0x06045245 RID: 283205 RVA: 0x01119FA6 File Offset: 0x011181A6
		private void OnMaskButtonClick()
		{
			DollGrabMachineController.Instance.OnClickStart();
			base.CloseMe(null);
		}

		// Token: 0x04024031 RID: 147505
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DollGrabEndlessStartItem, IGrabItemData> GenericLayout;

		// Token: 0x04024032 RID: 147506
		[Nullable(2)]
		private UUIText TxtDescri;

		// Token: 0x04024033 RID: 147507
		[Nullable(2)]
		private UUIItem PnlScroll;
	}
}
