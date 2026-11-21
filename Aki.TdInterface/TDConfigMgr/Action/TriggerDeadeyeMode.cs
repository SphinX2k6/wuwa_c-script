using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C5 RID: 9413
	public class TriggerDeadeyeMode : ActionParams
	{
		// Token: 0x0600CCA4 RID: 52388 RVA: 0x001D23FC File Offset: 0x001D05FC
		private TriggerDeadeyeMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TriggerDeadeyeMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TriggerDeadeyeMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TriggerDeadeyeMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600CCA5 RID: 52389 RVA: 0x001D2434 File Offset: 0x001D0634
		public static TriggerDeadeyeMode Create([Nullable(2)] TriggerDeadeyeMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerDeadeyeMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x001D2447 File Offset: 0x001D0647
		public static TriggerDeadeyeMode CreateFromSetValue([Nullable(2)] TriggerDeadeyeMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TriggerDeadeyeMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x001D245C File Offset: 0x001D065C
		public TriggerDeadeyeMode_SetValue ToSetValue()
		{
			return new TriggerDeadeyeMode_SetValue
			{
				FollowShooterConfig = this.FollowShooterConfig,
				FocusOnTags = this.FocusOnTags,
				FocusRadius = this.FocusRadius,
				TimeScale = this.TimeScale,
				TimeScaleTransitionTime = this.TimeScaleTransitionTime,
				FadeOutConfig = this.FadeOutConfig,
				EnergyConfig = this.EnergyConfig,
				DefaultLookAt = this.DefaultLookAt,
				EffectConfig = this.EffectConfig,
				FinishSendSelfEvent = this.FinishSendSelfEvent
			};
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x0600CCA8 RID: 52392 RVA: 0x001D24E8 File Offset: 0x001D06E8
		// (set) Token: 0x0600CCA9 RID: 52393 RVA: 0x001D2549 File Offset: 0x001D0749
		public virtual IDeadeyeFollowShooterConfig FollowShooterConfig
		{
			get
			{
				if (this._FollowShooterConfigInited)
				{
					return this._FollowShooterConfigCache;
				}
				this._FollowShooterConfigInited = true;
				if (this.FbInstance != null)
				{
					this._FollowShooterConfigCache = IDeadeyeFollowShooterConfig.Create(this.FbInstance.FollowShooterConfig);
				}
				else
				{
					TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
					this._FollowShooterConfigCache = ((pocoInterface != null) ? pocoInterface.FollowShooterConfig : null);
				}
				return this._FollowShooterConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().FollowShooterConfig = value;
				this._FollowShooterConfigInited = false;
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x0600CCAA RID: 52394 RVA: 0x001D255E File Offset: 0x001D075E
		// (set) Token: 0x0600CCAB RID: 52395 RVA: 0x001D2585 File Offset: 0x001D0785
		public virtual List<int> FocusOnTags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocusOnTags;
				}
				TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FocusOnTags;
			}
			set
			{
				this.GetOrCreatePoco().FocusOnTags = value;
			}
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x0600CCAC RID: 52396 RVA: 0x001D2593 File Offset: 0x001D0793
		// (set) Token: 0x0600CCAD RID: 52397 RVA: 0x001D25C2 File Offset: 0x001D07C2
		public virtual float FocusRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocusRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FocusRadius;
			}
			set
			{
				this.GetOrCreatePoco().FocusRadius = value;
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600CCAE RID: 52398 RVA: 0x001D25D0 File Offset: 0x001D07D0
		// (set) Token: 0x0600CCAF RID: 52399 RVA: 0x001D260A File Offset: 0x001D080A
		public virtual float? TimeScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeScale;
				}
				TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TimeScale;
			}
			set
			{
				this.GetOrCreatePoco().TimeScale = value;
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600CCB0 RID: 52400 RVA: 0x001D2618 File Offset: 0x001D0818
		// (set) Token: 0x0600CCB1 RID: 52401 RVA: 0x001D2652 File Offset: 0x001D0852
		public virtual float? TimeScaleTransitionTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeScaleTransitionTime;
				}
				TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TimeScaleTransitionTime;
			}
			set
			{
				this.GetOrCreatePoco().TimeScaleTransitionTime = value;
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600CCB2 RID: 52402 RVA: 0x001D2660 File Offset: 0x001D0860
		// (set) Token: 0x0600CCB3 RID: 52403 RVA: 0x001D26C1 File Offset: 0x001D08C1
		[Nullable(2)]
		public virtual IDeadeyeFadeOutConfig FadeOutConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._FadeOutConfigInited)
				{
					return this._FadeOutConfigCache;
				}
				this._FadeOutConfigInited = true;
				if (this.FbInstance != null)
				{
					this._FadeOutConfigCache = IDeadeyeFadeOutConfig.Create(this.FbInstance.FadeOutConfig);
				}
				else
				{
					TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutConfigCache = ((pocoInterface != null) ? pocoInterface.FadeOutConfig : null);
				}
				return this._FadeOutConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FadeOutConfig = value;
				this._FadeOutConfigInited = false;
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x001D26D8 File Offset: 0x001D08D8
		// (set) Token: 0x0600CCB5 RID: 52405 RVA: 0x001D2739 File Offset: 0x001D0939
		public virtual IDeadeyeEnergyConfig EnergyConfig
		{
			get
			{
				if (this._EnergyConfigInited)
				{
					return this._EnergyConfigCache;
				}
				this._EnergyConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EnergyConfigCache = IDeadeyeEnergyConfig.Create(this.FbInstance.EnergyConfig);
				}
				else
				{
					TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
					this._EnergyConfigCache = ((pocoInterface != null) ? pocoInterface.EnergyConfig : null);
				}
				return this._EnergyConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EnergyConfig = value;
				this._EnergyConfigInited = false;
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0600CCB6 RID: 52406 RVA: 0x001D2750 File Offset: 0x001D0950
		// (set) Token: 0x0600CCB7 RID: 52407 RVA: 0x001D27B1 File Offset: 0x001D09B1
		[Nullable(2)]
		public virtual IDeadeyeCameraConfig DefaultLookAt
		{
			[NullableContext(2)]
			get
			{
				if (this._DefaultLookAtInited)
				{
					return this._DefaultLookAtCache;
				}
				this._DefaultLookAtInited = true;
				if (this.FbInstance != null)
				{
					this._DefaultLookAtCache = IDeadeyeCameraConfig.Create(this.FbInstance.DefaultLookAt);
				}
				else
				{
					TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
					this._DefaultLookAtCache = ((pocoInterface != null) ? pocoInterface.DefaultLookAt : null);
				}
				return this._DefaultLookAtCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DefaultLookAt = value;
				this._DefaultLookAtInited = false;
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x0600CCB8 RID: 52408 RVA: 0x001D27C8 File Offset: 0x001D09C8
		// (set) Token: 0x0600CCB9 RID: 52409 RVA: 0x001D2829 File Offset: 0x001D0A29
		[Nullable(2)]
		public virtual IDeadEyeEffectConfig EffectConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EffectConfigCache = IDeadEyeEffectConfig.Create(this.FbInstance.EffectConfig);
				}
				else
				{
					TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
					this._EffectConfigCache = ((pocoInterface != null) ? pocoInterface.EffectConfig : null);
				}
				return this._EffectConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EffectConfig = value;
				this._EffectConfigInited = false;
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x0600CCBA RID: 52410 RVA: 0x001D283E File Offset: 0x001D0A3E
		// (set) Token: 0x0600CCBB RID: 52411 RVA: 0x001D2865 File Offset: 0x001D0A65
		[Nullable(2)]
		public virtual string FinishSendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishSendSelfEvent;
				}
				TriggerDeadeyeMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinishSendSelfEvent;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FinishSendSelfEvent = value;
			}
		}

		// Token: 0x0400793D RID: 31037
		[Nullable(2)]
		protected new TriggerDeadeyeMode FbInstance;

		// Token: 0x0400793E RID: 31038
		[Nullable(2)]
		protected TriggerDeadeyeMode_SetValue PocoInterface;

		// Token: 0x0400793F RID: 31039
		private IDeadeyeFollowShooterConfig _FollowShooterConfigCache;

		// Token: 0x04007940 RID: 31040
		private bool _FollowShooterConfigInited;

		// Token: 0x04007941 RID: 31041
		private IDeadeyeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x04007942 RID: 31042
		private bool _FadeOutConfigInited;

		// Token: 0x04007943 RID: 31043
		private IDeadeyeEnergyConfig _EnergyConfigCache;

		// Token: 0x04007944 RID: 31044
		private bool _EnergyConfigInited;

		// Token: 0x04007945 RID: 31045
		private IDeadeyeCameraConfig _DefaultLookAtCache;

		// Token: 0x04007946 RID: 31046
		private bool _DefaultLookAtInited;

		// Token: 0x04007947 RID: 31047
		private IDeadEyeEffectConfig _EffectConfigCache;

		// Token: 0x04007948 RID: 31048
		private bool _EffectConfigInited;
	}
}
