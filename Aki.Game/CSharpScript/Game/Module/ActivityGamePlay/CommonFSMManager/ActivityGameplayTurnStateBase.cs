using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager
{
	// Token: 0x02006933 RID: 26931
	public class ActivityGameplayTurnStateBase<TStateType> where TStateType : struct, Enum
	{
		// Token: 0x06043229 RID: 274985 RVA: 0x0105D6CC File Offset: 0x0105B8CC
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x0604322A RID: 274986 RVA: 0x0105D6CE File Offset: 0x0105B8CE
		public virtual void Enter(TStateType? prev)
		{
		}

		// Token: 0x0604322B RID: 274987 RVA: 0x0105D6D0 File Offset: 0x0105B8D0
		public virtual void Exit(TStateType? next)
		{
		}

		// Token: 0x0604322C RID: 274988 RVA: 0x0105D6D2 File Offset: 0x0105B8D2
		public virtual UniTask EnterAsync(TStateType? prev)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0604322D RID: 274989 RVA: 0x0105D6D9 File Offset: 0x0105B8D9
		public virtual UniTask ExitAsync(TStateType? next)
		{
			return UniTask.CompletedTask;
		}
	}
}
