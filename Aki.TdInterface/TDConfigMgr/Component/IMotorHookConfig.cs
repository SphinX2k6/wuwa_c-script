using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000526 RID: 1318
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorHookConfig
	{
		// Token: 0x06001AC4 RID: 6852 RVA: 0x0004DB50 File Offset: 0x0004BD50
		[NullableContext(1)]
		private IMotorHookConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorHookConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorHookConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorHookConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0004DB88 File Offset: 0x0004BD88
		[NullableContext(1)]
		public static IMotorHookConfig Create([Nullable(2)] IMotorHookConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorHookConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0004DB9B File Offset: 0x0004BD9B
		[NullableContext(1)]
		public static IMotorHookConfig CreateFromSetValue([Nullable(2)] IMotorHookConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorHookConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		[NullableContext(1)]
		public IMotorHookConfig_SetValue ToSetValue()
		{
			return new IMotorHookConfig_SetValue
			{
				InteractConstraint = this.InteractConstraint,
				Radius = this.Radius,
				NonInteractiveInnerRadius = this.NonInteractiveInnerRadius,
				HookEndDir = this.HookEndDir,
				MotorHookAcceleration = this.MotorHookAcceleration,
				ScreenDetectType = this.ScreenDetectType,
				AutoExit = this.AutoExit,
				MotorHookPerformanceConfig = this.MotorHookPerformanceConfig
			};
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0004DC24 File Offset: 0x0004BE24
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0004DC85 File Offset: 0x0004BE85
		public virtual IFaceToTargetMotorInteractConstraint InteractConstraint
		{
			get
			{
				if (this._InteractConstraintInited)
				{
					return this._InteractConstraintCache;
				}
				this._InteractConstraintInited = true;
				if (this.FbInstance != null)
				{
					this._InteractConstraintCache = IFaceToTargetMotorInteractConstraint.Create(this.FbInstance.InteractConstraint);
				}
				else
				{
					IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
					this._InteractConstraintCache = ((pocoInterface != null) ? pocoInterface.InteractConstraint : null);
				}
				return this._InteractConstraintCache;
			}
			set
			{
				this.GetOrCreatePoco().InteractConstraint = value;
				this._InteractConstraintInited = false;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0004DC9C File Offset: 0x0004BE9C
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0004DCD6 File Offset: 0x0004BED6
		public virtual float? Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0004DCE4 File Offset: 0x0004BEE4
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x0004DD1E File Offset: 0x0004BF1E
		public virtual float? NonInteractiveInnerRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NonInteractiveInnerRadius;
				}
				IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NonInteractiveInnerRadius;
			}
			set
			{
				this.GetOrCreatePoco().NonInteractiveInnerRadius = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0004DD2C File Offset: 0x0004BF2C
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0004DD8D File Offset: 0x0004BF8D
		public virtual IMotorHookEndDir HookEndDir
		{
			get
			{
				if (this._HookEndDirInited)
				{
					return this._HookEndDirCache;
				}
				this._HookEndDirInited = true;
				if (this.FbInstance != null)
				{
					this._HookEndDirCache = IMotorHookEndDir.Create(this.FbInstance.HookEndDir);
				}
				else
				{
					IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
					this._HookEndDirCache = ((pocoInterface != null) ? pocoInterface.HookEndDir : null);
				}
				return this._HookEndDirCache;
			}
			set
			{
				this.GetOrCreatePoco().HookEndDir = value;
				this._HookEndDirInited = false;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0004DDA4 File Offset: 0x0004BFA4
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0004DE05 File Offset: 0x0004C005
		public virtual IMotorHookAcceleration MotorHookAcceleration
		{
			get
			{
				if (this._MotorHookAccelerationInited)
				{
					return this._MotorHookAccelerationCache;
				}
				this._MotorHookAccelerationInited = true;
				if (this.FbInstance != null)
				{
					this._MotorHookAccelerationCache = IMotorHookAcceleration.Create(this.FbInstance.MotorHookAcceleration);
				}
				else
				{
					IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
					this._MotorHookAccelerationCache = ((pocoInterface != null) ? pocoInterface.MotorHookAcceleration : null);
				}
				return this._MotorHookAccelerationCache;
			}
			set
			{
				this.GetOrCreatePoco().MotorHookAcceleration = value;
				this._MotorHookAccelerationInited = false;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0004DE1A File Offset: 0x0004C01A
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x0004DE41 File Offset: 0x0004C041
		public virtual IHookLockScreenDetectTypeBase ScreenDetectType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenDetectType;
				}
				IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenDetectType;
			}
			set
			{
				this.GetOrCreatePoco().ScreenDetectType = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0004DE50 File Offset: 0x0004C050
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0004DE8A File Offset: 0x0004C08A
		public virtual bool? AutoExit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExit;
				}
				IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExit;
			}
			set
			{
				this.GetOrCreatePoco().AutoExit = value;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0004DE98 File Offset: 0x0004C098
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0004DEF9 File Offset: 0x0004C0F9
		public virtual IMotorHookPerformanceConfig MotorHookPerformanceConfig
		{
			get
			{
				if (this._MotorHookPerformanceConfigInited)
				{
					return this._MotorHookPerformanceConfigCache;
				}
				this._MotorHookPerformanceConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MotorHookPerformanceConfigCache = IMotorHookPerformanceConfig.Create(this.FbInstance.MotorHookPerformanceConfig);
				}
				else
				{
					IMotorHookConfig_SetValue pocoInterface = this.PocoInterface;
					this._MotorHookPerformanceConfigCache = ((pocoInterface != null) ? pocoInterface.MotorHookPerformanceConfig : null);
				}
				return this._MotorHookPerformanceConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().MotorHookPerformanceConfig = value;
				this._MotorHookPerformanceConfigInited = false;
			}
		}

		// Token: 0x04001352 RID: 4946
		protected IMotorHookConfig FbInstance;

		// Token: 0x04001353 RID: 4947
		protected IMotorHookConfig_SetValue PocoInterface;

		// Token: 0x04001354 RID: 4948
		[Nullable(1)]
		private IFaceToTargetMotorInteractConstraint _InteractConstraintCache;

		// Token: 0x04001355 RID: 4949
		private bool _InteractConstraintInited;

		// Token: 0x04001356 RID: 4950
		[Nullable(1)]
		private IMotorHookEndDir _HookEndDirCache;

		// Token: 0x04001357 RID: 4951
		private bool _HookEndDirInited;

		// Token: 0x04001358 RID: 4952
		[Nullable(1)]
		private IMotorHookAcceleration _MotorHookAccelerationCache;

		// Token: 0x04001359 RID: 4953
		private bool _MotorHookAccelerationInited;

		// Token: 0x0400135A RID: 4954
		[Nullable(1)]
		private IMotorHookPerformanceConfig _MotorHookPerformanceConfigCache;

		// Token: 0x0400135B RID: 4955
		private bool _MotorHookPerformanceConfigInited;
	}
}
