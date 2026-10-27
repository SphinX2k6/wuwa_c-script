using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0F RID: 11023
	[NullableContext(1)]
	[Nullable(0)]
	public class SetElementalBoxToTarget : ActionParams
	{
		// Token: 0x0600F153 RID: 61779 RVA: 0x0022FE9A File Offset: 0x0022E09A
		public static SetElementalBoxToTarget Create(ISetElementalBoxToTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetElementalBoxToTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x0600F154 RID: 61780 RVA: 0x0022FEB9 File Offset: 0x0022E0B9
		public virtual int ElementalBoxId
		{
			get
			{
				return this.Instance.ElementalBoxId;
			}
		}

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x0600F155 RID: 61781 RVA: 0x0022FEC6 File Offset: 0x0022E0C6
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadSetElementalBoxToTarget_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x040084B7 RID: 33975
		private ISetElementalBoxToTarget Instance;

		// Token: 0x040084B8 RID: 33976
		private ITargetEntityType _TargetCache;

		// Token: 0x040084B9 RID: 33977
		private bool _TargetInited;
	}
}
