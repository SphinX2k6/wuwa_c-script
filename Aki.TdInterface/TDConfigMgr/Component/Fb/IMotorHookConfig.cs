using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B17 RID: 2839
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorHookConfig
	{
		// Token: 0x0600418A RID: 16778 RVA: 0x000A82D6 File Offset: 0x000A64D6
		[NullableContext(1)]
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

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x000A82F5 File Offset: 0x000A64F5
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

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x000A832C File Offset: 0x000A652C
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

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x000A8364 File Offset: 0x000A6564
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

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x000A839A File Offset: 0x000A659A
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

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x000A83CE File Offset: 0x000A65CE
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

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06004190 RID: 16784 RVA: 0x000A8402 File Offset: 0x000A6602
		[Nullable(1)]
		public virtual IHookLockScreenDetectTypeBase ScreenDetectType
		{
			[NullableContext(1)]
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

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x000A8434 File Offset: 0x000A6634
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

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x000A846A File Offset: 0x000A666A
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

		// Token: 0x040024EC RID: 9452
		private IMotorHookConfig Instance;

		// Token: 0x040024ED RID: 9453
		private IFaceToTargetMotorInteractConstraint _InteractConstraintCache;

		// Token: 0x040024EE RID: 9454
		private bool _InteractConstraintInited;

		// Token: 0x040024EF RID: 9455
		private IMotorHookEndDir _HookEndDirCache;

		// Token: 0x040024F0 RID: 9456
		private bool _HookEndDirInited;

		// Token: 0x040024F1 RID: 9457
		private IMotorHookAcceleration _MotorHookAccelerationCache;

		// Token: 0x040024F2 RID: 9458
		private bool _MotorHookAccelerationInited;

		// Token: 0x040024F3 RID: 9459
		[Nullable(1)]
		private IHookLockScreenDetectTypeBase _ScreenDetectTypeCache;

		// Token: 0x040024F4 RID: 9460
		private bool _ScreenDetectTypeInited;

		// Token: 0x040024F5 RID: 9461
		private IMotorHookPerformanceConfig _MotorHookPerformanceConfigCache;

		// Token: 0x040024F6 RID: 9462
		private bool _MotorHookPerformanceConfigInited;
	}
}
