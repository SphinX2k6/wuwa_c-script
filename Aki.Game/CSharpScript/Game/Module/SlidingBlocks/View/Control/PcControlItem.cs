using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Control
{
	// Token: 0x02004B9E RID: 19358
	public class PcControlItem : ControlItem
	{
		// Token: 0x0603228E RID: 205454 RVA: 0x00BA7AF4 File Offset: 0x00BA5CF4
		protected unsafe override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
			int num = 3;
			List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
			Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Delegate>(0, new Action(this.OnClimbBtnClick));
			num2++;
			*span[num2] = new ValueTuple<int, Delegate>(1, new Action(this.OnRotateBtnClick));
			num2++;
			*span[num2] = new ValueTuple<int, Delegate>(2, new Action(this.OnFallDownBtnClick));
			this.BtnBindInfo = list;
		}

		// Token: 0x0603228F RID: 205455 RVA: 0x00BA7BD4 File Offset: 0x00BA5DD4
		protected override UniTask OnBeforeStartAsync()
		{
			PcControlItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PcControlItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032290 RID: 205456 RVA: 0x00BA7C17 File Offset: 0x00BA5E17
		protected override void OnClimbBtnClick()
		{
			base.OnClimbBtnClick();
		}

		// Token: 0x06032291 RID: 205457 RVA: 0x00BA7C1F File Offset: 0x00BA5E1F
		protected override void OnRotateBtnClick()
		{
			base.OnRotateBtnClick();
		}

		// Token: 0x06032292 RID: 205458 RVA: 0x00BA7C27 File Offset: 0x00BA5E27
		protected override void OnFallDownBtnClick()
		{
			base.OnFallDownBtnClick();
		}

		// Token: 0x0200ADC8 RID: 44488
		private class EViewComponent
		{
			// Token: 0x04034C86 RID: 216198
			public const int ClimbBtn = 0;

			// Token: 0x04034C87 RID: 216199
			public const int RotateBtn = 1;

			// Token: 0x04034C88 RID: 216200
			public const int FallDownBtn = 2;
		}
	}
}
