using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager
{
	// Token: 0x02005883 RID: 22659
	public class ActivityGameplayTurnStateBase<TStateType> where TStateType : struct, Enum
	{
		// Token: 0x06037D81 RID: 228737 RVA: 0x00F9ECF8 File Offset: 0x00F9CEF8
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x06037D82 RID: 228738 RVA: 0x00F9ECFA File Offset: 0x00F9CEFA
		public virtual void Enter(TStateType? prev)
		{
		}

		// Token: 0x06037D83 RID: 228739 RVA: 0x00F9ECFC File Offset: 0x00F9CEFC
		public virtual void Exit(TStateType? next)
		{
		}

		// Token: 0x06037D84 RID: 228740 RVA: 0x00F9ECFE File Offset: 0x00F9CEFE
		public virtual UniTask EnterAsync(TStateType? prev)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06037D85 RID: 228741 RVA: 0x00F9ED05 File Offset: 0x00F9CF05
		public virtual UniTask ExitAsync(TStateType? next)
		{
			return UniTask.CompletedTask;
		}
	}
}
