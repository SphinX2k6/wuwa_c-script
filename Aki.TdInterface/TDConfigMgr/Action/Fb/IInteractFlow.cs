using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C8 RID: 10440
	public class IInteractFlow : IInteractType
	{
		// Token: 0x0600E875 RID: 59509 RVA: 0x00225B35 File Offset: 0x00223D35
		public static IInteractFlow Create(IInteractFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004393 RID: 17299
		// (get) Token: 0x0600E876 RID: 59510 RVA: 0x00225B54 File Offset: 0x00223D54
		public override EInteractOption Type
		{
			get
			{
				return (EInteractOption)this.Instance.Type;
			}
		}

		// Token: 0x17004394 RID: 17300
		// (get) Token: 0x0600E877 RID: 59511 RVA: 0x00225B61 File Offset: 0x00223D61
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x0400800E RID: 32782
		private IInteractFlow Instance;

		// Token: 0x0400800F RID: 32783
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04008010 RID: 32784
		private bool _FlowInited;
	}
}
