using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.StepSequence;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.DataLayerSwitch
{
	// Token: 0x02005AD3 RID: 23251
	internal class DataLayerTransitionAbortSignal : ISequenceAbortSignal
	{
		// Token: 0x17008C2E RID: 35886
		// (get) Token: 0x0603AE44 RID: 241220 RVA: 0x00E0AC36 File Offset: 0x00E08E36
		public bool Aborted
		{
			get
			{
				return this.AbortPromise.IsFulfilled;
			}
		}

		// Token: 0x17008C2F RID: 35887
		// (get) Token: 0x0603AE45 RID: 241221 RVA: 0x00E0AC43 File Offset: 0x00E08E43
		public UniTask<bool>? Promise
		{
			get
			{
				return new UniTask<bool>?(this.AbortPromise.Promise);
			}
		}

		// Token: 0x0603AE46 RID: 241222 RVA: 0x00E0AC55 File Offset: 0x00E08E55
		public void Abort()
		{
			this.AbortPromise.SetResult(true);
		}

		// Token: 0x0401EBCD RID: 125901
		[Nullable(1)]
		private readonly CustomPromise<bool> AbortPromise = new CustomPromise<bool>();
	}
}
