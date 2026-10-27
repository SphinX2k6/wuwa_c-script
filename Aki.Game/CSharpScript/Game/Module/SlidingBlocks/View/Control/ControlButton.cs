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
	// Token: 0x02004B9B RID: 19355
	public class ControlButton : UiPanelBase
	{
		// Token: 0x06032275 RID: 205429 RVA: 0x00BA74B0 File Offset: 0x00BA56B0
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

		// Token: 0x06032276 RID: 205430 RVA: 0x00BA751C File Offset: 0x00BA571C
		protected override UniTask OnBeforeStartAsync()
		{
			ControlButton.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ControlButton.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032277 RID: 205431 RVA: 0x00BA755F File Offset: 0x00BA575F
		public void PlayClickEffect()
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x0401AB6E RID: 109422
		[Nullable(2)]
		public UUIButtonComponent Button;

		// Token: 0x0401AB6F RID: 109423
		[Nullable(2)]
		protected BattleUiNiagaraItem ClickEffect;

		// Token: 0x0200ADC0 RID: 44480
		private enum EViewComponent
		{
			// Token: 0x04034C64 RID: 216164
			SkillButton = 5,
			// Token: 0x04034C65 RID: 216165
			ClickEffectNiagara = 10
		}
	}
}
