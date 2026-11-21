using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058D RID: 1421
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorHookConfig
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x0005290C File Offset: 0x00050B0C
		[NullableContext(0)]
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

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00052944 File Offset: 0x00050B44
		[NullableContext(0)]
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

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00052957 File Offset: 0x00050B57
		[NullableContext(0)]
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

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0005296C File Offset: 0x00050B6C
		[NullableContext(0)]
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

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000529E0 File Offset: 0x00050BE0
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00052A41 File Offset: 0x00050C41
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

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00052A58 File Offset: 0x00050C58
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00052A92 File Offset: 0x00050C92
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

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00052AA0 File Offset: 0x00050CA0
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00052ADA File Offset: 0x00050CDA
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

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00052AE8 File Offset: 0x00050CE8
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00052B49 File Offset: 0x00050D49
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00052B60 File Offset: 0x00050D60
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x00052BC1 File Offset: 0x00050DC1
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00052BD6 File Offset: 0x00050DD6
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x00052BFD File Offset: 0x00050DFD
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

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00052C0C File Offset: 0x00050E0C
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x00052C46 File Offset: 0x00050E46
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

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00052C54 File Offset: 0x00050E54
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x00052CB5 File Offset: 0x00050EB5
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

		// Token: 0x040014BC RID: 5308
		protected IMotorHookConfig FbInstance;

		// Token: 0x040014BD RID: 5309
		protected IMotorHookConfig_SetValue PocoInterface;

		// Token: 0x040014BE RID: 5310
		[Nullable(0)]
		private IFaceToTargetMotorInteractConstraint _InteractConstraintCache;

		// Token: 0x040014BF RID: 5311
		private bool _InteractConstraintInited;

		// Token: 0x040014C0 RID: 5312
		[Nullable(0)]
		private IMotorHookEndDir _HookEndDirCache;

		// Token: 0x040014C1 RID: 5313
		private bool _HookEndDirInited;

		// Token: 0x040014C2 RID: 5314
		[Nullable(0)]
		private IMotorHookAcceleration _MotorHookAccelerationCache;

		// Token: 0x040014C3 RID: 5315
		private bool _MotorHookAccelerationInited;

		// Token: 0x040014C4 RID: 5316
		[Nullable(0)]
		private IMotorHookPerformanceConfig _MotorHookPerformanceConfigCache;

		// Token: 0x040014C5 RID: 5317
		private bool _MotorHookPerformanceConfigInited;
	}
}
