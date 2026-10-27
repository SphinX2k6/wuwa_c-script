using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006427 RID: 25639
	public class MotorFightItemTips : UiViewBase
	{
		// Token: 0x06040779 RID: 264057 RVA: 0x00F99B00 File Offset: 0x00F97D00
		[NullableContext(1)]
		public MotorFightItemTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604077A RID: 264058 RVA: 0x00F99B0C File Offset: 0x00F97D0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604077B RID: 264059 RVA: 0x00F99BB4 File Offset: 0x00F97DB4
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightItemTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightItemTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604077C RID: 264060 RVA: 0x00F99BF7 File Offset: 0x00F97DF7
		private void OnClickBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402183F RID: 137279
		[Nullable(2)]
		protected MotorFightItemDetailPanel CollectionItem;

		// Token: 0x04021840 RID: 137280
		[Nullable(2)]
		protected MotorFightItemData Data;

		// Token: 0x0200C65C RID: 50780
		private class EComponentDefine
		{
			// Token: 0x0403BE1B RID: 245275
			public const int ButtonClose = 0;

			// Token: 0x0403BE1C RID: 245276
			public const int ItemTopCollection = 1;
		}
	}
}
