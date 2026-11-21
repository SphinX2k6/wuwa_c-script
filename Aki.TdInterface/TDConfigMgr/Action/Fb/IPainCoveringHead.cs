using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC4 RID: 10948
	public class IPainCoveringHead : ILeisureInteractType
	{
		// Token: 0x0600F13E RID: 61758 RVA: 0x00234E46 File Offset: 0x00233046
		public static IPainCoveringHead Create(IPainCoveringHead? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPainCoveringHead
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x0600F13F RID: 61759 RVA: 0x00234E65 File Offset: 0x00233065
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008492 RID: 33938
		private IPainCoveringHead Instance;
	}
}
