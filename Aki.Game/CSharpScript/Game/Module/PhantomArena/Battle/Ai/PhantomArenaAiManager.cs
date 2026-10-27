using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052E2 RID: 21218
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAiManager
	{
		// Token: 0x17008305 RID: 33541
		// (get) Token: 0x06036488 RID: 222344 RVA: 0x00CD7463 File Offset: 0x00CD5663
		// (set) Token: 0x06036489 RID: 222345 RVA: 0x00CD746B File Offset: 0x00CD566B
		private protected PhantomArenaBattleProxy BattleProxy { protected get; private set; }

		// Token: 0x0603648A RID: 222346 RVA: 0x00CD7474 File Offset: 0x00CD5674
		public PhantomArenaAiManager(PhantomArenaBattleProxy battleProxy)
		{
			this.BattleProxy = battleProxy;
		}

		// Token: 0x0603648B RID: 222347 RVA: 0x00CD7490 File Offset: 0x00CD5690
		public void SetOperationList(List<NpcAiOperation> operationList)
		{
			foreach (NpcAiOperation element in operationList)
			{
				this.OperationQueue.Push(element);
			}
			this.ExecCount = 0;
		}

		// Token: 0x0603648C RID: 222348 RVA: 0x00CD74EC File Offset: 0x00CD56EC
		public UniTask ExecuteAllOperation()
		{
			PhantomArenaAiManager.<ExecuteAllOperation>d__9 <ExecuteAllOperation>d__;
			<ExecuteAllOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAllOperation>d__.<>4__this = this;
			<ExecuteAllOperation>d__.<>1__state = -1;
			<ExecuteAllOperation>d__.<>t__builder.Start<PhantomArenaAiManager.<ExecuteAllOperation>d__9>(ref <ExecuteAllOperation>d__);
			return <ExecuteAllOperation>d__.<>t__builder.Task;
		}

		// Token: 0x0603648D RID: 222349 RVA: 0x00CD752F File Offset: 0x00CD572F
		public void ClearAllOperation()
		{
			this.OperationQueue.Clear();
		}

		// Token: 0x0603648E RID: 222350 RVA: 0x00CD753C File Offset: 0x00CD573C
		public void Clear()
		{
			this.OperationQueue.Clear();
			this.IsClear = true;
		}

		// Token: 0x0401CB0B RID: 117515
		private readonly Queue<NpcAiOperation> OperationQueue = new Queue<NpcAiOperation>(4);

		// Token: 0x0401CB0C RID: 117516
		public bool IsClear;

		// Token: 0x0401CB0E RID: 117518
		public int ExecCount;
	}
}
