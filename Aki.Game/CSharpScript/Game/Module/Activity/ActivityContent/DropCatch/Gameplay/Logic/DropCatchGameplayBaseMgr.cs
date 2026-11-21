using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005667 RID: 22119
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayBaseMgr
	{
		// Token: 0x060369CF RID: 223695 RVA: 0x00F3DBCB File Offset: 0x00F3BDCB
		public DropCatchGameplayBaseMgr(IGameplayLogicContext context)
		{
			this.Context = context;
		}

		// Token: 0x060369D0 RID: 223696 RVA: 0x00F3DBDA File Offset: 0x00F3BDDA
		public virtual void Init()
		{
		}

		// Token: 0x060369D1 RID: 223697 RVA: 0x00F3DBDC File Offset: 0x00F3BDDC
		public virtual UniTask InitAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060369D2 RID: 223698 RVA: 0x00F3DBE3 File Offset: 0x00F3BDE3
		public virtual void OnReadyTick(float deltaTime)
		{
		}

		// Token: 0x060369D3 RID: 223699 RVA: 0x00F3DBE5 File Offset: 0x00F3BDE5
		public virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x060369D4 RID: 223700 RVA: 0x00F3DBE7 File Offset: 0x00F3BDE7
		public virtual void Destroy()
		{
		}

		// Token: 0x0401CDD7 RID: 118231
		protected IGameplayLogicContext Context;
	}
}
