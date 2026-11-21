using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E0A RID: 11786
	public class HandBookModifySystemProgress : ActionParams
	{
		// Token: 0x06010022 RID: 65570 RVA: 0x0024DE44 File Offset: 0x0024C044
		public static HandBookModifySystemProgress Create(IHandBookModifySystemProgress? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HandBookModifySystemProgress
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x06010023 RID: 65571 RVA: 0x0024DE63 File Offset: 0x0024C063
		public virtual IHandBookProgressOption Operation
		{
			get
			{
				if (this._OperationInited)
				{
					return this._OperationCache;
				}
				this._OperationInited = true;
				this._OperationCache = ActionReadHelper.ReadHandBookModifySystemProgress_Operation(this.Instance);
				return this._OperationCache;
			}
		}

		// Token: 0x04008BC8 RID: 35784
		private IHandBookModifySystemProgress Instance;

		// Token: 0x04008BC9 RID: 35785
		private IHandBookProgressOption _OperationCache;

		// Token: 0x04008BCA RID: 35786
		private bool _OperationInited;
	}
}
