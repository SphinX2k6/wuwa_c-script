using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.World.StepSequence
{
	// Token: 0x02004525 RID: 17701
	public interface ISequenceAbortSignal
	{
		// Token: 0x1700750F RID: 29967
		// (get) Token: 0x0602DBA1 RID: 187297
		bool Aborted { get; }

		// Token: 0x17007510 RID: 29968
		// (get) Token: 0x0602DBA2 RID: 187298
		UniTask<bool>? Promise { get; }

		// Token: 0x0602DBA3 RID: 187299
		void Abort();
	}
}
