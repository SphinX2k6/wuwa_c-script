using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC3 RID: 11459
	public class IVehicleExitPathMove : IVehicleControlType
	{
		// Token: 0x0600FB41 RID: 64321 RVA: 0x002466D5 File Offset: 0x002448D5
		public static IVehicleExitPathMove Create(IVehicleExitPathMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleExitPathMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x0600FB42 RID: 64322 RVA: 0x002466F4 File Offset: 0x002448F4
		public override EVehicleControlType Type
		{
			get
			{
				return (EVehicleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x0600FB43 RID: 64323 RVA: 0x00246701 File Offset: 0x00244901
		public virtual ICloseSplineMovePattern Pattern
		{
			get
			{
				if (this._PatternInited)
				{
					return this._PatternCache;
				}
				this._PatternInited = true;
				this._PatternCache = ActionReadHelper.ReadIVehicleExitPathMove_Pattern(this.Instance);
				return this._PatternCache;
			}
		}

		// Token: 0x04008943 RID: 35139
		private IVehicleExitPathMove Instance;

		// Token: 0x04008944 RID: 35140
		private ICloseSplineMovePattern _PatternCache;

		// Token: 0x04008945 RID: 35141
		private bool _PatternInited;
	}
}
