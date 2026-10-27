using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller
{
	// Token: 0x02004754 RID: 18260
	public abstract class ExecutableUnitBase : IExecutableUnit
	{
		// Token: 0x17007743 RID: 30531
		// (get) Token: 0x0602FB7F RID: 195455 RVA: 0x00B0DE0D File Offset: 0x00B0C00D
		// (set) Token: 0x0602FB80 RID: 195456 RVA: 0x00B0DE15 File Offset: 0x00B0C015
		public bool IsExecute { get; private set; }

		// Token: 0x17007744 RID: 30532
		// (get) Token: 0x0602FB81 RID: 195457
		public abstract int Id { get; }

		// Token: 0x17007745 RID: 30533
		// (get) Token: 0x0602FB82 RID: 195458
		[Nullable(1)]
		public abstract Enum Type { [NullableContext(1)] get; }

		// Token: 0x0602FB83 RID: 195459 RVA: 0x00B0DE1E File Offset: 0x00B0C01E
		public bool Create()
		{
			return this.OnCreate();
		}

		// Token: 0x0602FB84 RID: 195460 RVA: 0x00B0DE26 File Offset: 0x00B0C026
		public void Destroy()
		{
			this.OnDestroy();
		}

		// Token: 0x0602FB85 RID: 195461 RVA: 0x00B0DE30 File Offset: 0x00B0C030
		public UniTask ExecuteAction()
		{
			ExecutableUnitBase.<ExecuteAction>d__11 <ExecuteAction>d__;
			<ExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAction>d__.<>4__this = this;
			<ExecuteAction>d__.<>1__state = -1;
			<ExecuteAction>d__.<>t__builder.Start<ExecutableUnitBase.<ExecuteAction>d__11>(ref <ExecuteAction>d__);
			return <ExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FB86 RID: 195462 RVA: 0x00B0DE73 File Offset: 0x00B0C073
		public void OnTick(float delta)
		{
		}

		// Token: 0x0602FB87 RID: 195463 RVA: 0x00B0DE75 File Offset: 0x00B0C075
		protected virtual bool OnCreate()
		{
			return true;
		}

		// Token: 0x0602FB88 RID: 195464 RVA: 0x00B0DE78 File Offset: 0x00B0C078
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0602FB89 RID: 195465
		protected abstract UniTask OnExecuteAction();

		// Token: 0x0602FB8A RID: 195466 RVA: 0x00B0DE7A File Offset: 0x00B0C07A
		protected virtual void OnBeforeExecuteAction()
		{
		}

		// Token: 0x0602FB8B RID: 195467 RVA: 0x00B0DE7C File Offset: 0x00B0C07C
		protected virtual void OnAfterExecuteAction()
		{
		}

		// Token: 0x0602FB8C RID: 195468 RVA: 0x00B0DE7E File Offset: 0x00B0C07E
		public virtual void OnRollbackRestore()
		{
		}

		// Token: 0x04019C11 RID: 105489
		public static readonly bool EnableTick;
	}
}
