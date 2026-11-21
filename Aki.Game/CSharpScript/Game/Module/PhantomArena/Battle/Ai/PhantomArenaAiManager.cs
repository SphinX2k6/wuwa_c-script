using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042B2 RID: 17074
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAiManager
	{
		// Token: 0x170056C5 RID: 22213
		// (get) Token: 0x0602B383 RID: 177027 RVA: 0x00C24B86 File Offset: 0x00C22D86
		// (set) Token: 0x0602B384 RID: 177028 RVA: 0x00C24B8E File Offset: 0x00C22D8E
		private protected PhantomArenaBattleProxy BattleProxy { protected get; private set; }

		// Token: 0x0602B385 RID: 177029 RVA: 0x00C24B97 File Offset: 0x00C22D97
		public PhantomArenaAiManager(PhantomArenaBattleProxy battleProxy)
		{
			this.BattleProxy = battleProxy;
		}

		// Token: 0x0602B386 RID: 177030 RVA: 0x00C24BB4 File Offset: 0x00C22DB4
		public void SetOperationList(List<NpcAiOperation> operationList)
		{
			foreach (NpcAiOperation element in operationList)
			{
				this.OperationQueue.Push(element);
			}
			this.ExecCount = 0;
		}

		// Token: 0x0602B387 RID: 177031 RVA: 0x00C24C10 File Offset: 0x00C22E10
		public UniTask ExecuteAllOperation()
		{
			PhantomArenaAiManager.<ExecuteAllOperation>d__9 <ExecuteAllOperation>d__;
			<ExecuteAllOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAllOperation>d__.<>4__this = this;
			<ExecuteAllOperation>d__.<>1__state = -1;
			<ExecuteAllOperation>d__.<>t__builder.Start<PhantomArenaAiManager.<ExecuteAllOperation>d__9>(ref <ExecuteAllOperation>d__);
			return <ExecuteAllOperation>d__.<>t__builder.Task;
		}

		// Token: 0x0602B388 RID: 177032 RVA: 0x00C24C53 File Offset: 0x00C22E53
		public void ClearAllOperation()
		{
			this.OperationQueue.Clear();
		}

		// Token: 0x0602B389 RID: 177033 RVA: 0x00C24C60 File Offset: 0x00C22E60
		public void Clear()
		{
			this.OperationQueue.Clear();
			this.IsClear = true;
		}

		// Token: 0x04017540 RID: 95552
		private readonly Queue<NpcAiOperation> OperationQueue = new Queue<NpcAiOperation>(4);

		// Token: 0x04017541 RID: 95553
		public bool IsClear;

		// Token: 0x04017543 RID: 95555
		public int ExecCount;
	}
}
