using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x020057C0 RID: 22464
	public sealed class DangoBrawlOperationDispatcher
	{
		// Token: 0x0603778C RID: 227212 RVA: 0x00F811FD File Offset: 0x00F7F3FD
		public DangoBrawlOperationDispatcher()
		{
			this.Register(new RotateOperation());
			this.Register(new ReplaceOperation());
			this.Register(new SellOperation());
			this.Register(new RevertOperation());
		}

		// Token: 0x0603778D RID: 227213 RVA: 0x00F8123C File Offset: 0x00F7F43C
		[NullableContext(1)]
		private void Register(IInteractionOperation op)
		{
			this.Operations[op.Type] = op;
		}

		// Token: 0x0603778E RID: 227214 RVA: 0x00F81250 File Offset: 0x00F7F450
		[NullableContext(2)]
		public IInteractionOperation Get(EDangoBrawlOptionType type)
		{
			IInteractionOperation result;
			if (!this.Operations.TryGetValue(type, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0603778F RID: 227215 RVA: 0x00F81270 File Offset: 0x00F7F470
		public bool CanExecute(EDangoBrawlOptionType type, int targetUid = -1)
		{
			IInteractionOperation interactionOperation = this.Get(type);
			OperationContext operationContext = new OperationContext(targetUid);
			return interactionOperation.CanExecute(operationContext);
		}

		// Token: 0x06037790 RID: 227216 RVA: 0x00F81294 File Offset: 0x00F7F494
		public UniTask<bool> Execute(EDangoBrawlOptionType type, int targetUid = -1)
		{
			IInteractionOperation interactionOperation = this.Get(type);
			OperationContext operationContext = new OperationContext(targetUid);
			return interactionOperation.Execute(operationContext);
		}

		// Token: 0x06037791 RID: 227217 RVA: 0x00F812B6 File Offset: 0x00F7F4B6
		public void Start()
		{
			EventSystem.Instance.Add<int>(EEventName.OnDangoBrawlRotateRequest, new Action<int>(this.OnRotateRequest));
		}

		// Token: 0x06037792 RID: 227218 RVA: 0x00F812D4 File Offset: 0x00F7F4D4
		public void Stop()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnDangoBrawlRotateRequest, new Action<int>(this.OnRotateRequest));
		}

		// Token: 0x06037793 RID: 227219 RVA: 0x00F812F2 File Offset: 0x00F7F4F2
		private void OnRotateRequest(int uid)
		{
			this.Execute(EDangoBrawlOptionType.Rotate, uid).Forget<bool>();
		}

		// Token: 0x0401D46E RID: 119918
		[Nullable(1)]
		private readonly Dictionary<EDangoBrawlOptionType, IInteractionOperation> Operations = new Dictionary<EDangoBrawlOptionType, IInteractionOperation>();
	}
}
