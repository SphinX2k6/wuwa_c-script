using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0E RID: 11022
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeElementalBoxState : ActionParams
	{
		// Token: 0x0600F14F RID: 61775 RVA: 0x0022FE37 File Offset: 0x0022E037
		public static ChangeElementalBoxState Create(IChangeElementalBoxState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeElementalBoxState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x0600F150 RID: 61776 RVA: 0x0022FE56 File Offset: 0x0022E056
		public virtual IChangeElementalBoxStateTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadChangeElementalBoxState_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x0600F151 RID: 61777 RVA: 0x0022FE85 File Offset: 0x0022E085
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040084B4 RID: 33972
		private IChangeElementalBoxState Instance;

		// Token: 0x040084B5 RID: 33973
		private IChangeElementalBoxStateTarget _TargetCache;

		// Token: 0x040084B6 RID: 33974
		private bool _TargetInited;
	}
}
