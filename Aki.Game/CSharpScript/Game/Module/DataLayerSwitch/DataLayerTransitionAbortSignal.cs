using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.StepSequence;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.DataLayerSwitch
{
	// Token: 0x02004AB4 RID: 19124
	internal class DataLayerTransitionAbortSignal : ISequenceAbortSignal
	{
		// Token: 0x17006008 RID: 24584
		// (get) Token: 0x0602FDB6 RID: 196022 RVA: 0x00D5B91E File Offset: 0x00D59B1E
		public bool Aborted
		{
			get
			{
				return this.AbortPromise.IsFulfilled;
			}
		}

		// Token: 0x17006009 RID: 24585
		// (get) Token: 0x0602FDB7 RID: 196023 RVA: 0x00D5B92B File Offset: 0x00D59B2B
		public UniTask<bool>? Promise
		{
			get
			{
				return new UniTask<bool>?(this.AbortPromise.Promise);
			}
		}

		// Token: 0x0602FDB8 RID: 196024 RVA: 0x00D5B93D File Offset: 0x00D59B3D
		public void Abort()
		{
			this.AbortPromise.SetResult(true);
		}

		// Token: 0x04019689 RID: 104073
		[Nullable(1)]
		private readonly CustomPromise<bool> AbortPromise = new CustomPromise<bool>();
	}
}
