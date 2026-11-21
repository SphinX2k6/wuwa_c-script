using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D10 RID: 19728
	public class FullScreenNiagaraItem : BattleChildView
	{
		// Token: 0x06031745 RID: 202565 RVA: 0x00DD3D78 File Offset: 0x00DD1F78
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

		// Token: 0x06031746 RID: 202566 RVA: 0x00DD3DC0 File Offset: 0x00DD1FC0
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

		// Token: 0x06031747 RID: 202567 RVA: 0x00DD3DE8 File Offset: 0x00DD1FE8
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

		// Token: 0x06031748 RID: 202568 RVA: 0x00DD3E33 File Offset: 0x00DD2033
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

		// Token: 0x06031749 RID: 202569 RVA: 0x00DD3E48 File Offset: 0x00DD2048
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

		// Token: 0x0401A313 RID: 107283
		[Nullable(2)]
		private string NiagaraPath;

		// Token: 0x0401A314 RID: 107284
		[Nullable(2)]
		private UUINiagara FullScreenNiagara;

		// Token: 0x0200A9C6 RID: 43462
		private enum EChildType
		{
			// Token: 0x04034759 RID: 214873
			PoisonScreenNiagara
		}
	}
}
