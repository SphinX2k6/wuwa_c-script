using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C22 RID: 11298
	public class IEnableMoveOperation : IMoveOperationType
	{
		// Token: 0x0600F89B RID: 63643 RVA: 0x002421E1 File Offset: 0x002403E1
		public static IEnableMoveOperation Create(IEnableMoveOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableMoveOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D05 RID: 19717
		// (get) Token: 0x0600F89C RID: 63644 RVA: 0x00242200 File Offset: 0x00240400
		public override EMoveOperationType Type
		{
			get
			{
				return (EMoveOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008804 RID: 34820
		private IEnableMoveOperation Instance;
	}
}
