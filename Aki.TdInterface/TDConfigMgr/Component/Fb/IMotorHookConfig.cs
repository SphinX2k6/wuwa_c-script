using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE5 RID: 3045
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorHookConfig
	{
		// Token: 0x060045E0 RID: 17888 RVA: 0x000B2302 File Offset: 0x000B0502
		[NullableContext(0)]
		public static IMotorHookConfig Create(IMotorHookConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorHookConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x000B2321 File Offset: 0x000B0521
		public virtual IFaceToTargetMotorInteractConstraint InteractConstraint
		{
			get
			{
				if (this._InteractConstraintInited)
				{
					return this._InteractConstraintCache;
				}
				this._InteractConstraintInited = true;
				this._InteractConstraintCache = IFaceToTargetMotorInteractConstraint.Create(this.Instance.InteractConstraint);
				return this._InteractConstraintCache;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060045E2 RID: 17890 RVA: 0x000B2358 File Offset: 0x000B0558
		public virtual float? Radius
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Radius);
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x000B2390 File Offset: 0x000B0590
		public virtual float? NonInteractiveInnerRadius
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.NonInteractiveInnerRadius);
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060045E4 RID: 17892 RVA: 0x000B23C6 File Offset: 0x000B05C6
		public virtual IMotorHookEndDir HookEndDir
		{
			get
			{
				if (this._HookEndDirInited)
				{
					return this._HookEndDirCache;
				}
				this._HookEndDirInited = true;
				this._HookEndDirCache = IMotorHookEndDir.Create(this.Instance.HookEndDir);
				return this._HookEndDirCache;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x000B23FA File Offset: 0x000B05FA
		public virtual IMotorHookAcceleration MotorHookAcceleration
		{
			get
			{
				if (this._MotorHookAccelerationInited)
				{
					return this._MotorHookAccelerationCache;
				}
				this._MotorHookAccelerationInited = true;
				this._MotorHookAccelerationCache = IMotorHookAcceleration.Create(this.Instance.MotorHookAcceleration);
				return this._MotorHookAccelerationCache;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x000B242E File Offset: 0x000B062E
		[Nullable(0)]
		public virtual IHookLockScreenDetectTypeBase ScreenDetectType
		{
			[NullableContext(0)]
			get
			{
				if (this._ScreenDetectTypeInited)
				{
					return this._ScreenDetectTypeCache;
				}
				this._ScreenDetectTypeInited = true;
				this._ScreenDetectTypeCache = ComponentReadHelper.ReadIMotorHookConfig_ScreenDetectType(this.Instance);
				return this._ScreenDetectTypeCache;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x000B2460 File Offset: 0x000B0660
		public virtual bool? AutoExit
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.AutoExit);
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x000B2496 File Offset: 0x000B0696
		public virtual IMotorHookPerformanceConfig MotorHookPerformanceConfig
		{
			get
			{
				if (this._MotorHookPerformanceConfigInited)
				{
					return this._MotorHookPerformanceConfigCache;
				}
				this._MotorHookPerformanceConfigInited = true;
				this._MotorHookPerformanceConfigCache = IMotorHookPerformanceConfig.Create(this.Instance.MotorHookPerformanceConfig);
				return this._MotorHookPerformanceConfigCache;
			}
		}

		// Token: 0x04002730 RID: 10032
		private IMotorHookConfig Instance;

		// Token: 0x04002731 RID: 10033
		private IFaceToTargetMotorInteractConstraint _InteractConstraintCache;

		// Token: 0x04002732 RID: 10034
		private bool _InteractConstraintInited;

		// Token: 0x04002733 RID: 10035
		private IMotorHookEndDir _HookEndDirCache;

		// Token: 0x04002734 RID: 10036
		private bool _HookEndDirInited;

		// Token: 0x04002735 RID: 10037
		private IMotorHookAcceleration _MotorHookAccelerationCache;

		// Token: 0x04002736 RID: 10038
		private bool _MotorHookAccelerationInited;

		// Token: 0x04002737 RID: 10039
		[Nullable(0)]
		private IHookLockScreenDetectTypeBase _ScreenDetectTypeCache;

		// Token: 0x04002738 RID: 10040
		private bool _ScreenDetectTypeInited;

		// Token: 0x04002739 RID: 10041
		private IMotorHookPerformanceConfig _MotorHookPerformanceConfigCache;

		// Token: 0x0400273A RID: 10042
		private bool _MotorHookPerformanceConfigInited;
	}
}
