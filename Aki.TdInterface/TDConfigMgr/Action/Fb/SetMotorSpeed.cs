using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA2 RID: 10914
	[NullableContext(2)]
	[Nullable(0)]
	public class SetMotorSpeed : ActionParams
	{
		// Token: 0x0600EFAC RID: 61356 RVA: 0x0022D5B1 File Offset: 0x0022B7B1
		[NullableContext(1)]
		public static SetMotorSpeed Create(ISetMotorSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetMotorSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x0600EFAD RID: 61357 RVA: 0x0022D5D0 File Offset: 0x0022B7D0
		public virtual IMotorConstraintConfig MotorConstraint
		{
			get
			{
				if (this._MotorConstraintInited)
				{
					return this._MotorConstraintCache;
				}
				this._MotorConstraintInited = true;
				this._MotorConstraintCache = IMotorConstraintConfig.Create(this.Instance.MotorConstraint);
				return this._MotorConstraintCache;
			}
		}

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x0600EFAE RID: 61358 RVA: 0x0022D604 File Offset: 0x0022B804
		[Nullable(1)]
		public virtual ISetMotorSpeedTargetSpeed SpeedConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._SpeedConfigInited)
				{
					return this._SpeedConfigCache;
				}
				this._SpeedConfigInited = true;
				this._SpeedConfigCache = ISetMotorSpeedTargetSpeed.Create(this.Instance.SpeedConfig);
				return this._SpeedConfigCache;
			}
		}

		// Token: 0x040083D4 RID: 33748
		private ISetMotorSpeed Instance;

		// Token: 0x040083D5 RID: 33749
		private IMotorConstraintConfig _MotorConstraintCache;

		// Token: 0x040083D6 RID: 33750
		private bool _MotorConstraintInited;

		// Token: 0x040083D7 RID: 33751
		private ISetMotorSpeedTargetSpeed _SpeedConfigCache;

		// Token: 0x040083D8 RID: 33752
		private bool _SpeedConfigInited;
	}
}
