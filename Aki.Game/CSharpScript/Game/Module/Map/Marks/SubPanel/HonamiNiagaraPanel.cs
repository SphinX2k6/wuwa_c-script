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
	// Token: 0x020054D4 RID: 21716
	public class HonamiNiagaraPanel : UiPanelBase
	{
		// Token: 0x0603771F RID: 227103 RVA: 0x00D2B724 File Offset: 0x00D29924
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

		// Token: 0x06037720 RID: 227104 RVA: 0x00D2B76C File Offset: 0x00D2996C
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

		// Token: 0x0200B740 RID: 46912
		private enum EChildComponents
		{
			// Token: 0x040377DC RID: 227292
			Niagara
		}
	}
}
