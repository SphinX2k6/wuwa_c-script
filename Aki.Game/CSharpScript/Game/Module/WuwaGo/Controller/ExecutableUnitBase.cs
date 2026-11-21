using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller
{
	// Token: 0x02003685 RID: 13957
	public abstract class ExecutableUnitBase : IExecutableUnit
	{
		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x06024349 RID: 148297 RVA: 0x00A3DE01 File Offset: 0x00A3C001
		// (set) Token: 0x0602434A RID: 148298 RVA: 0x00A3DE09 File Offset: 0x00A3C009
		public bool IsExecute { get; private set; }

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x0602434B RID: 148299
		public abstract int Id { get; }

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x0602434C RID: 148300
		[Nullable(1)]
		public abstract Enum Type { [NullableContext(1)] get; }

		// Token: 0x0602434D RID: 148301 RVA: 0x00A3DE12 File Offset: 0x00A3C012
		public bool Create()
		{
			return this.OnCreate();
		}

		// Token: 0x0602434E RID: 148302 RVA: 0x00A3DE1A File Offset: 0x00A3C01A
		public void Destroy()
		{
			this.OnDestroy();
		}

		// Token: 0x0602434F RID: 148303 RVA: 0x00A3DE24 File Offset: 0x00A3C024
		public UniTask ExecuteAction()
		{
			ExecutableUnitBase.<ExecuteAction>d__11 <ExecuteAction>d__;
			<ExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAction>d__.<>4__this = this;
			<ExecuteAction>d__.<>1__state = -1;
			<ExecuteAction>d__.<>t__builder.Start<ExecutableUnitBase.<ExecuteAction>d__11>(ref <ExecuteAction>d__);
			return <ExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x06024350 RID: 148304 RVA: 0x00A3DE67 File Offset: 0x00A3C067
		public void OnTick(float delta)
		{
		}

		// Token: 0x06024351 RID: 148305 RVA: 0x00A3DE69 File Offset: 0x00A3C069
		protected virtual bool OnCreate()
		{
			return true;
		}

		// Token: 0x06024352 RID: 148306 RVA: 0x00A3DE6C File Offset: 0x00A3C06C
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06024353 RID: 148307
		protected abstract UniTask OnExecuteAction();

		// Token: 0x06024354 RID: 148308 RVA: 0x00A3DE6E File Offset: 0x00A3C06E
		protected virtual void OnBeforeExecuteAction()
		{
		}

		// Token: 0x06024355 RID: 148309 RVA: 0x00A3DE70 File Offset: 0x00A3C070
		protected virtual void OnAfterExecuteAction()
		{
		}

		// Token: 0x06024356 RID: 148310 RVA: 0x00A3DE72 File Offset: 0x00A3C072
		public virtual void OnRollbackRestore()
		{
		}

		// Token: 0x040142C1 RID: 82625
		public static readonly bool EnableTick;
	}
}
