using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D2E RID: 23854
	public class FullScreenNiagaraItem : BattleChildView
	{
		// Token: 0x0603C7EC RID: 247788 RVA: 0x00E835D8 File Offset: 0x00E817D8
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

		// Token: 0x0603C7ED RID: 247789 RVA: 0x00E83620 File Offset: 0x00E81820
		public override void Reset()
		{
			UUINiagara fullScreenNiagara = this.FullScreenNiagara;
			if (fullScreenNiagara != null)
			{
				fullScreenNiagara.SetNiagaraSystem(null);
			}
			this.NiagaraPath = null;
			this.FullScreenNiagara = null;
			base.Reset();
		}

		// Token: 0x0603C7EE RID: 247790 RVA: 0x00E83648 File Offset: 0x00E81848
		public UniTask<bool> LoadNiagara([Nullable(2)] string niagaraPath)
		{
			FullScreenNiagaraItem.<LoadNiagara>d__5 <LoadNiagara>d__;
			<LoadNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadNiagara>d__.<>4__this = this;
			<LoadNiagara>d__.niagaraPath = niagaraPath;
			<LoadNiagara>d__.<>1__state = -1;
			<LoadNiagara>d__.<>t__builder.Start<FullScreenNiagaraItem.<LoadNiagara>d__5>(ref <LoadNiagara>d__);
			return <LoadNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x0603C7EF RID: 247791 RVA: 0x00E83693 File Offset: 0x00E81893
		[NullableContext(1)]
		public void SetNiagaraFloatValue(string key, float value)
		{
			UUINiagara fullScreenNiagara = this.FullScreenNiagara;
			if (fullScreenNiagara == null)
			{
				return;
			}
			fullScreenNiagara.SetNiagaraVarFloat(key, value);
		}

		// Token: 0x0603C7F0 RID: 247792 RVA: 0x00E836A8 File Offset: 0x00E818A8
		public void SetVisible(bool bVisible)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (bVisible)
			{
				uiNiagara.ActivateSystem(true);
			}
			else
			{
				this.FullScreenNiagara.SetNiagaraSystem(null);
				this.FullScreenNiagara.DeactivateSystem();
			}
			this.SetActive(bVisible);
		}

		// Token: 0x0401F85A RID: 129114
		[Nullable(2)]
		private string NiagaraPath;

		// Token: 0x0401F85B RID: 129115
		[Nullable(2)]
		private UUINiagara FullScreenNiagara;

		// Token: 0x0200BFC0 RID: 49088
		private enum EChildType
		{
			// Token: 0x04039D97 RID: 236951
			PoisonScreenNiagara
		}
	}
}
