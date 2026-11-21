using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Control
{
	// Token: 0x02003B48 RID: 15176
	public class PcControlItem : ControlItem
	{
		// Token: 0x0602701E RID: 159774 RVA: 0x00AEBC40 File Offset: 0x00AE9E40
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

		// Token: 0x0602701F RID: 159775 RVA: 0x00AEBD20 File Offset: 0x00AE9F20
		protected override UniTask OnBeforeStartAsync()
		{
			PcControlItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PcControlItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027020 RID: 159776 RVA: 0x00AEBD63 File Offset: 0x00AE9F63
		protected override void OnClimbBtnClick()
		{
			base.OnClimbBtnClick();
		}

		// Token: 0x06027021 RID: 159777 RVA: 0x00AEBD6B File Offset: 0x00AE9F6B
		protected override void OnRotateBtnClick()
		{
			base.OnRotateBtnClick();
		}

		// Token: 0x06027022 RID: 159778 RVA: 0x00AEBD73 File Offset: 0x00AE9F73
		protected override void OnFallDownBtnClick()
		{
			base.OnFallDownBtnClick();
		}

		// Token: 0x020097E7 RID: 38887
		private class EViewComponent
		{
			// Token: 0x0402F62D RID: 194093
			public const int ClimbBtn = 0;

			// Token: 0x0402F62E RID: 194094
			public const int RotateBtn = 1;

			// Token: 0x0402F62F RID: 194095
			public const int FallDownBtn = 2;
		}
	}
}
