using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D96 RID: 11670
	public class SetMotorSpeed : ActionParams
	{
		// Token: 0x0600FE62 RID: 65122 RVA: 0x0024B2BD File Offset: 0x002494BD
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

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x0600FE63 RID: 65123 RVA: 0x0024B2DC File Offset: 0x002494DC
		[Nullable(2)]
		public virtual IMotorConstraintConfig MotorConstraint
		{
			[NullableContext(2)]
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

		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x0600FE64 RID: 65124 RVA: 0x0024B310 File Offset: 0x00249510
		public virtual ISetMotorSpeedTargetSpeed SpeedConfig
		{
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

		// Token: 0x04008AD8 RID: 35544
		private ISetMotorSpeed Instance;

		// Token: 0x04008AD9 RID: 35545
		[Nullable(2)]
		private IMotorConstraintConfig _MotorConstraintCache;

		// Token: 0x04008ADA RID: 35546
		private bool _MotorConstraintInited;

		// Token: 0x04008ADB RID: 35547
		[Nullable(2)]
		private ISetMotorSpeedTargetSpeed _SpeedConfigCache;

		// Token: 0x04008ADC RID: 35548
		private bool _SpeedConfigInited;
	}
}
