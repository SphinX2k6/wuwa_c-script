using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AED RID: 10989
	public class ISetStateMachineBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600F0CE RID: 61646 RVA: 0x0022F30A File Offset: 0x0022D50A
		[NullableContext(1)]
		public static ISetStateMachineBlendAnimType Create(ISetStateMachineBlendAnimType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetStateMachineBlendAnimType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB6 RID: 19638
		// (get) Token: 0x0600F0CF RID: 61647 RVA: 0x0022F329 File Offset: 0x0022D529
		public override EBlendAnimType Type
		{
			get
			{
				return (EBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x0600F0D0 RID: 61648 RVA: 0x0022F336 File Offset: 0x0022D536
		public virtual EBlendAnimState State
		{
			get
			{
				return (EBlendAnimState)this.Instance.State;
			}
		}

		// Token: 0x04008479 RID: 33913
		private ISetStateMachineBlendAnimType Instance;
	}
}
