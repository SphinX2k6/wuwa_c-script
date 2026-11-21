using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E03 RID: 11779
	public class SetElementalBoxToTarget : ActionParams
	{
		// Token: 0x06010009 RID: 65545 RVA: 0x0024DBA6 File Offset: 0x0024BDA6
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

		// Token: 0x170050B1 RID: 20657
		// (get) Token: 0x0601000A RID: 65546 RVA: 0x0024DBC5 File Offset: 0x0024BDC5
		public virtual int ElementalBoxId
		{
			get
			{
				return this.Instance.ElementalBoxId;
			}
		}

		// Token: 0x170050B2 RID: 20658
		// (get) Token: 0x0601000B RID: 65547 RVA: 0x0024DBD2 File Offset: 0x0024BDD2
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

		// Token: 0x04008BBB RID: 35771
		private ISetElementalBoxToTarget Instance;

		// Token: 0x04008BBC RID: 35772
		private ITargetEntityType _TargetCache;

		// Token: 0x04008BBD RID: 35773
		private bool _TargetInited;
	}
}
