using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006870 RID: 26736
	public sealed class DangoBrawlOperationDispatcher
	{
		// Token: 0x06042C35 RID: 273461 RVA: 0x0103FD1D File Offset: 0x0103DF1D
		public DangoBrawlOperationDispatcher()
		{
			this.Register(new RotateOperation());
			this.Register(new ReplaceOperation());
			this.Register(new SellOperation());
			this.Register(new RevertOperation());
		}

		// Token: 0x06042C36 RID: 273462 RVA: 0x0103FD5C File Offset: 0x0103DF5C
		[NullableContext(1)]
		private void Register(IInteractionOperation op)
		{
			this.Operations[op.Type] = op;
		}

		// Token: 0x06042C37 RID: 273463 RVA: 0x0103FD70 File Offset: 0x0103DF70
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

		// Token: 0x06042C38 RID: 273464 RVA: 0x0103FD90 File Offset: 0x0103DF90
		public bool CanExecute(EDangoBrawlOptionType type, int targetUid = -1)
		{
			IInteractionOperation interactionOperation = this.Get(type);
			OperationContext operationContext = new OperationContext(targetUid);
			return interactionOperation.CanExecute(operationContext);
		}

		// Token: 0x06042C39 RID: 273465 RVA: 0x0103FDB4 File Offset: 0x0103DFB4
		public UniTask<bool> Execute(EDangoBrawlOptionType type, int targetUid = -1)
		{
			IInteractionOperation interactionOperation = this.Get(type);
			OperationContext operationContext = new OperationContext(targetUid);
			return interactionOperation.Execute(operationContext);
		}

		// Token: 0x06042C3A RID: 273466 RVA: 0x0103FDD6 File Offset: 0x0103DFD6
		public void Start()
		{
			EventSystem.Instance.Add<int>(EEventName.OnDangoBrawlRotateRequest, new Action<int>(this.OnRotateRequest));
		}

		// Token: 0x06042C3B RID: 273467 RVA: 0x0103FDF4 File Offset: 0x0103DFF4
		public void Stop()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnDangoBrawlRotateRequest, new Action<int>(this.OnRotateRequest));
		}

		// Token: 0x06042C3C RID: 273468 RVA: 0x0103FE12 File Offset: 0x0103E012
		private void OnRotateRequest(int uid)
		{
			this.Execute(EDangoBrawlOptionType.Rotate, uid).Forget<bool>();
		}

		// Token: 0x04022C11 RID: 142353
		[Nullable(1)]
		private readonly Dictionary<EDangoBrawlOptionType, IInteractionOperation> Operations = new Dictionary<EDangoBrawlOptionType, IInteractionOperation>();
	}
}
