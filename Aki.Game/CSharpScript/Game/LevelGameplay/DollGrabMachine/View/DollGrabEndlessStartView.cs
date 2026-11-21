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
	// Token: 0x02006060 RID: 24672
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabEndlessStartView : UiViewBase
	{
		// Token: 0x0603B3E9 RID: 242665 RVA: 0x010C3B9A File Offset: 0x010C1D9A
		public DollGrabEndlessStartView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3EA RID: 242666 RVA: 0x010C3BA4 File Offset: 0x010C1DA4
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

		// Token: 0x0603B3EB RID: 242667 RVA: 0x010C3CAD File Offset: 0x010C1EAD
		protected override void OnStart()
		{
			this.GenericLayout = new GenericLayout<DollGrabEndlessStartItem, IGrabItemData>(base.GetHorizontalLayout(1), new Func<DollGrabEndlessStartItem>(this.CreateDollGrabEndlessStartItem), null, false, true);
			this.TxtDescri = base.GetText(3);
			this.PnlScroll = base.GetItem(4);
		}

		// Token: 0x0603B3EC RID: 242668 RVA: 0x010C3CEC File Offset: 0x010C1EEC
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabEndlessStartView.<OnBeforeShowAsyncImplementImplement>d__6 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabEndlessStartView.<OnBeforeShowAsyncImplementImplement>d__6>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3ED RID: 242669 RVA: 0x010C3D2F File Offset: 0x010C1F2F
		private DollGrabEndlessStartItem CreateDollGrabEndlessStartItem()
		{
			return new DollGrabEndlessStartItem();
		}

		// Token: 0x0603B3EE RID: 242670 RVA: 0x010C3D36 File Offset: 0x010C1F36
		private void OnMaskButtonClick()
		{
			DollGrabMachineController.Instance.OnClickStart();
			base.CloseMe(null);
		}

		// Token: 0x0401F2E4 RID: 127716
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DollGrabEndlessStartItem, IGrabItemData> GenericLayout;

		// Token: 0x0401F2E5 RID: 127717
		[Nullable(2)]
		private UUIText TxtDescri;

		// Token: 0x0401F2E6 RID: 127718
		[Nullable(2)]
		private UUIItem PnlScroll;
	}
}
