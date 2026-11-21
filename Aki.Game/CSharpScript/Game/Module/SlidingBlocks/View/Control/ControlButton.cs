using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Control
{
	// Token: 0x02003B45 RID: 15173
	public class ControlButton : UiPanelBase
	{
		// Token: 0x06027005 RID: 159749 RVA: 0x00AEB5FC File Offset: 0x00AE97FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027006 RID: 159750 RVA: 0x00AEB668 File Offset: 0x00AE9868
		protected override UniTask OnBeforeStartAsync()
		{
			ControlButton.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ControlButton.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027007 RID: 159751 RVA: 0x00AEB6AB File Offset: 0x00AE98AB
		public void PlayClickEffect()
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x040154C2 RID: 87234
		[Nullable(2)]
		public UUIButtonComponent Button;

		// Token: 0x040154C3 RID: 87235
		[Nullable(2)]
		protected BattleUiNiagaraItem ClickEffect;

		// Token: 0x020097DF RID: 38879
		private enum EViewComponent
		{
			// Token: 0x0402F60B RID: 194059
			SkillButton = 5,
			// Token: 0x0402F60C RID: 194060
			ClickEffectNiagara = 10
		}
	}
}
