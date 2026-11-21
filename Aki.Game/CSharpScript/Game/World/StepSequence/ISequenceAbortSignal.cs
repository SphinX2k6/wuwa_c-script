using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.World.StepSequence
{
	// Token: 0x0200344A RID: 13386
	public interface ISequenceAbortSignal
	{
		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x06022268 RID: 139880
		bool Aborted { get; }

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x06022269 RID: 139881
		UniTask<bool>? Promise { get; }

		// Token: 0x0602226A RID: 139882
		void Abort();
	}
}
