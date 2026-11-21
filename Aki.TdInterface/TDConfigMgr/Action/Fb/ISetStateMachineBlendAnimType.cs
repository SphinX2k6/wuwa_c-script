using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE1 RID: 11745
	public class ISetStateMachineBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600FF84 RID: 65412 RVA: 0x0024D016 File Offset: 0x0024B216
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

		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x0600FF85 RID: 65413 RVA: 0x0024D035 File Offset: 0x0024B235
		public override EBlendAnimType Type
		{
			get
			{
				return (EBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x0600FF86 RID: 65414 RVA: 0x0024D042 File Offset: 0x0024B242
		public virtual EBlendAnimState State
		{
			get
			{
				return (EBlendAnimState)this.Instance.State;
			}
		}

		// Token: 0x04008B7D RID: 35709
		private ISetStateMachineBlendAnimType Instance;
	}
}
