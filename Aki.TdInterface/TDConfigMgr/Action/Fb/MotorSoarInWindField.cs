using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA4 RID: 11684
	public class MotorSoarInWindField : ActionParams
	{
		// Token: 0x0600FE9E RID: 65182 RVA: 0x0024B8FE File Offset: 0x00249AFE
		public static MotorSoarInWindField Create(IMotorSoarInWindField? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MotorSoarInWindField
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005004 RID: 20484
		// (get) Token: 0x0600FE9F RID: 65183 RVA: 0x0024B91D File Offset: 0x00249B1D
		public virtual IMotorSoarInWindFieldControlType ControlType
		{
			get
			{
				if (this._ControlTypeInited)
				{
					return this._ControlTypeCache;
				}
				this._ControlTypeInited = true;
				this._ControlTypeCache = ActionReadHelper.ReadMotorSoarInWindField_ControlType(this.Instance);
				return this._ControlTypeCache;
			}
		}

		// Token: 0x04008AFE RID: 35582
		private IMotorSoarInWindField Instance;

		// Token: 0x04008AFF RID: 35583
		private IMotorSoarInWindFieldControlType _ControlTypeCache;

		// Token: 0x04008B00 RID: 35584
		private bool _ControlTypeInited;
	}
}
