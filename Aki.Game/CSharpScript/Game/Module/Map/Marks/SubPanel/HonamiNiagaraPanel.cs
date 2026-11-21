using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.SubPanel
{
	// Token: 0x020044A7 RID: 17575
	public class HonamiNiagaraPanel : UiPanelBase
	{
		// Token: 0x0602C5C4 RID: 181700 RVA: 0x00C7920C File Offset: 0x00C7740C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602C5C5 RID: 181701 RVA: 0x00C79254 File Offset: 0x00C77454
		[NullableContext(1)]
		public UniTask SetNiagaraAndShow(string resourceId, [Nullable(2)] string audioEvent = null)
		{
			HonamiNiagaraPanel.<SetNiagaraAndShow>d__2 <SetNiagaraAndShow>d__;
			<SetNiagaraAndShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetNiagaraAndShow>d__.<>4__this = this;
			<SetNiagaraAndShow>d__.resourceId = resourceId;
			<SetNiagaraAndShow>d__.audioEvent = audioEvent;
			<SetNiagaraAndShow>d__.<>1__state = -1;
			<SetNiagaraAndShow>d__.<>t__builder.Start<HonamiNiagaraPanel.<SetNiagaraAndShow>d__2>(ref <SetNiagaraAndShow>d__);
			return <SetNiagaraAndShow>d__.<>t__builder.Task;
		}

		// Token: 0x0200A16F RID: 41327
		private enum EChildComponents
		{
			// Token: 0x04032215 RID: 205333
			Niagara
		}
	}
}
