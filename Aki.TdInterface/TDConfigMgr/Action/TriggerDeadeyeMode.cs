using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002258 RID: 8792
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerDeadeyeMode : ActionParams
	{
		// Token: 0x0600C0DE RID: 49374 RVA: 0x001BAC78 File Offset: 0x001B8E78
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

		// Token: 0x0600C0DF RID: 49375 RVA: 0x001BACB0 File Offset: 0x001B8EB0
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

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x001BACC3 File Offset: 0x001B8EC3
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

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x001BACD8 File Offset: 0x001B8ED8
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

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x0600C0E2 RID: 49378 RVA: 0x001BAD64 File Offset: 0x001B8F64
		// (set) Token: 0x0600C0E3 RID: 49379 RVA: 0x001BADC5 File Offset: 0x001B8FC5
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

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0600C0E4 RID: 49380 RVA: 0x001BADDA File Offset: 0x001B8FDA
		// (set) Token: 0x0600C0E5 RID: 49381 RVA: 0x001BAE01 File Offset: 0x001B9001
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

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600C0E6 RID: 49382 RVA: 0x001BAE0F File Offset: 0x001B900F
		// (set) Token: 0x0600C0E7 RID: 49383 RVA: 0x001BAE3E File Offset: 0x001B903E
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

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600C0E8 RID: 49384 RVA: 0x001BAE4C File Offset: 0x001B904C
		// (set) Token: 0x0600C0E9 RID: 49385 RVA: 0x001BAE86 File Offset: 0x001B9086
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

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600C0EA RID: 49386 RVA: 0x001BAE94 File Offset: 0x001B9094
		// (set) Token: 0x0600C0EB RID: 49387 RVA: 0x001BAECE File Offset: 0x001B90CE
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

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0600C0EC RID: 49388 RVA: 0x001BAEDC File Offset: 0x001B90DC
		// (set) Token: 0x0600C0ED RID: 49389 RVA: 0x001BAF3D File Offset: 0x001B913D
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

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0600C0EE RID: 49390 RVA: 0x001BAF54 File Offset: 0x001B9154
		// (set) Token: 0x0600C0EF RID: 49391 RVA: 0x001BAFB5 File Offset: 0x001B91B5
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

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x001BAFCC File Offset: 0x001B91CC
		// (set) Token: 0x0600C0F1 RID: 49393 RVA: 0x001BB02D File Offset: 0x001B922D
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

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x001BB044 File Offset: 0x001B9244
		// (set) Token: 0x0600C0F3 RID: 49395 RVA: 0x001BB0A5 File Offset: 0x001B92A5
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

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x001BB0BA File Offset: 0x001B92BA
		// (set) Token: 0x0600C0F5 RID: 49397 RVA: 0x001BB0E1 File Offset: 0x001B92E1
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

		// Token: 0x040072F0 RID: 29424
		[Nullable(2)]
		protected new TriggerDeadeyeMode FbInstance;

		// Token: 0x040072F1 RID: 29425
		[Nullable(2)]
		protected TriggerDeadeyeMode_SetValue PocoInterface;

		// Token: 0x040072F2 RID: 29426
		private IDeadeyeFollowShooterConfig _FollowShooterConfigCache;

		// Token: 0x040072F3 RID: 29427
		private bool _FollowShooterConfigInited;

		// Token: 0x040072F4 RID: 29428
		private IDeadeyeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x040072F5 RID: 29429
		private bool _FadeOutConfigInited;

		// Token: 0x040072F6 RID: 29430
		private IDeadeyeEnergyConfig _EnergyConfigCache;

		// Token: 0x040072F7 RID: 29431
		private bool _EnergyConfigInited;

		// Token: 0x040072F8 RID: 29432
		private IDeadeyeCameraConfig _DefaultLookAtCache;

		// Token: 0x040072F9 RID: 29433
		private bool _DefaultLookAtInited;

		// Token: 0x040072FA RID: 29434
		private IDeadEyeEffectConfig _EffectConfigCache;

		// Token: 0x040072FB RID: 29435
		private bool _EffectConfigInited;
	}
}
