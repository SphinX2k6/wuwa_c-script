using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DAF RID: 11695
	[NullableContext(2)]
	[Nullable(0)]
	public class TriggerDeadeyeMode : ActionParams
	{
		// Token: 0x0600FEC7 RID: 65223 RVA: 0x0024BC17 File Offset: 0x00249E17
		[NullableContext(0)]
		public static TriggerDeadeyeMode Create(ITriggerDeadeyeMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerDeadeyeMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x0600FEC8 RID: 65224 RVA: 0x0024BC36 File Offset: 0x00249E36
		[Nullable(0)]
		public virtual IDeadeyeFollowShooterConfig FollowShooterConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._FollowShooterConfigInited)
				{
					return this._FollowShooterConfigCache;
				}
				this._FollowShooterConfigInited = true;
				this._FollowShooterConfigCache = IDeadeyeFollowShooterConfig.Create(this.Instance.FollowShooterConfig);
				return this._FollowShooterConfigCache;
			}
		}

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x0600FEC9 RID: 65225 RVA: 0x0024BC6C File Offset: 0x00249E6C
		[Nullable(0)]
		public virtual List<int> FocusOnTags
		{
			[NullableContext(0)]
			get
			{
				if (this._FocusOnTagsInited)
				{
					return this._FocusOnTagsCache;
				}
				this._FocusOnTagsInited = true;
				int focusOnTagsLength = this.Instance.FocusOnTagsLength;
				this._FocusOnTagsCache = new List<int>(focusOnTagsLength);
				for (int i = 0; i < focusOnTagsLength; i++)
				{
					this._FocusOnTagsCache.Add(this.Instance.FocusOnTags(i));
				}
				return this._FocusOnTagsCache;
			}
		}

		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x0600FECA RID: 65226 RVA: 0x0024BCD0 File Offset: 0x00249ED0
		public virtual float FocusRadius
		{
			get
			{
				return this.Instance.FocusRadius;
			}
		}

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x0600FECB RID: 65227 RVA: 0x0024BCE0 File Offset: 0x00249EE0
		public virtual float? TimeScale
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TimeScale);
			}
		}

		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x0600FECC RID: 65228 RVA: 0x0024BD18 File Offset: 0x00249F18
		public virtual float? TimeScaleTransitionTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TimeScaleTransitionTime);
			}
		}

		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x0600FECD RID: 65229 RVA: 0x0024BD4E File Offset: 0x00249F4E
		public virtual IDeadeyeFadeOutConfig FadeOutConfig
		{
			get
			{
				if (this._FadeOutConfigInited)
				{
					return this._FadeOutConfigCache;
				}
				this._FadeOutConfigInited = true;
				this._FadeOutConfigCache = IDeadeyeFadeOutConfig.Create(this.Instance.FadeOutConfig);
				return this._FadeOutConfigCache;
			}
		}

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x0600FECE RID: 65230 RVA: 0x0024BD82 File Offset: 0x00249F82
		[Nullable(0)]
		public virtual IDeadeyeEnergyConfig EnergyConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._EnergyConfigInited)
				{
					return this._EnergyConfigCache;
				}
				this._EnergyConfigInited = true;
				this._EnergyConfigCache = IDeadeyeEnergyConfig.Create(this.Instance.EnergyConfig);
				return this._EnergyConfigCache;
			}
		}

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x0600FECF RID: 65231 RVA: 0x0024BDB6 File Offset: 0x00249FB6
		public virtual IDeadeyeCameraConfig DefaultLookAt
		{
			get
			{
				if (this._DefaultLookAtInited)
				{
					return this._DefaultLookAtCache;
				}
				this._DefaultLookAtInited = true;
				this._DefaultLookAtCache = IDeadeyeCameraConfig.Create(this.Instance.DefaultLookAt);
				return this._DefaultLookAtCache;
			}
		}

		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x0600FED0 RID: 65232 RVA: 0x0024BDEA File Offset: 0x00249FEA
		public virtual IDeadEyeEffectConfig EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				this._EffectConfigCache = IDeadEyeEffectConfig.Create(this.Instance.EffectConfig);
				return this._EffectConfigCache;
			}
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x0600FED1 RID: 65233 RVA: 0x0024BE1E File Offset: 0x0024A01E
		public virtual string FinishSendSelfEvent
		{
			get
			{
				return this.Instance.FinishSendSelfEvent;
			}
		}

		// Token: 0x04008B0D RID: 35597
		private ITriggerDeadeyeMode Instance;

		// Token: 0x04008B0E RID: 35598
		private IDeadeyeFollowShooterConfig _FollowShooterConfigCache;

		// Token: 0x04008B0F RID: 35599
		private bool _FollowShooterConfigInited;

		// Token: 0x04008B10 RID: 35600
		[Nullable(0)]
		private List<int> _FocusOnTagsCache;

		// Token: 0x04008B11 RID: 35601
		private bool _FocusOnTagsInited;

		// Token: 0x04008B12 RID: 35602
		private IDeadeyeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x04008B13 RID: 35603
		private bool _FadeOutConfigInited;

		// Token: 0x04008B14 RID: 35604
		private IDeadeyeEnergyConfig _EnergyConfigCache;

		// Token: 0x04008B15 RID: 35605
		private bool _EnergyConfigInited;

		// Token: 0x04008B16 RID: 35606
		private IDeadeyeCameraConfig _DefaultLookAtCache;

		// Token: 0x04008B17 RID: 35607
		private bool _DefaultLookAtInited;

		// Token: 0x04008B18 RID: 35608
		private IDeadEyeEffectConfig _EffectConfigCache;

		// Token: 0x04008B19 RID: 35609
		private bool _EffectConfigInited;
	}
}
