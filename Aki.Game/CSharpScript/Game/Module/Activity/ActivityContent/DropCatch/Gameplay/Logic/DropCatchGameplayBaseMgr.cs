using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006717 RID: 26391
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayBaseMgr
	{
		// Token: 0x06041E83 RID: 269955 RVA: 0x00FFC7FF File Offset: 0x00FFA9FF
		public DropCatchGameplayBaseMgr(IGameplayLogicContext context)
		{
			this.Context = context;
		}

		// Token: 0x06041E84 RID: 269956 RVA: 0x00FFC80E File Offset: 0x00FFAA0E
		public virtual void Init()
		{
		}

		// Token: 0x06041E85 RID: 269957 RVA: 0x00FFC810 File Offset: 0x00FFAA10
		public virtual UniTask InitAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06041E86 RID: 269958 RVA: 0x00FFC817 File Offset: 0x00FFAA17
		public virtual void OnReadyTick(float deltaTime)
		{
		}

		// Token: 0x06041E87 RID: 269959 RVA: 0x00FFC819 File Offset: 0x00FFAA19
		public virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x06041E88 RID: 269960 RVA: 0x00FFC81B File Offset: 0x00FFAA1B
		public virtual void Destroy()
		{
		}

		// Token: 0x0402257E RID: 140670
		protected IGameplayLogicContext Context;
	}
}
