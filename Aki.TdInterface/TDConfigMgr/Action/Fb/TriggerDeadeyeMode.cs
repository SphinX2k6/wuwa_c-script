using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABB RID: 10939
	[NullableContext(2)]
	[Nullable(0)]
	public class TriggerDeadeyeMode : ActionParams
	{
		// Token: 0x0600F011 RID: 61457 RVA: 0x0022DF0B File Offset: 0x0022C10B
		[NullableContext(1)]
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

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x0600F012 RID: 61458 RVA: 0x0022DF2A File Offset: 0x0022C12A
		[Nullable(1)]
		public virtual IDeadeyeFollowShooterConfig FollowShooterConfig
		{
			[NullableContext(1)]
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

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x0600F013 RID: 61459 RVA: 0x0022DF60 File Offset: 0x0022C160
		[Nullable(1)]
		public virtual List<int> FocusOnTags
		{
			[NullableContext(1)]
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

		// Token: 0x17004C5F RID: 19551
		// (get) Token: 0x0600F014 RID: 61460 RVA: 0x0022DFC4 File Offset: 0x0022C1C4
		public virtual float FocusRadius
		{
			get
			{
				return this.Instance.FocusRadius;
			}
		}

		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x0600F015 RID: 61461 RVA: 0x0022DFD4 File Offset: 0x0022C1D4
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

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x0600F016 RID: 61462 RVA: 0x0022E00C File Offset: 0x0022C20C
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

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x0600F017 RID: 61463 RVA: 0x0022E042 File Offset: 0x0022C242
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

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x0600F018 RID: 61464 RVA: 0x0022E076 File Offset: 0x0022C276
		[Nullable(1)]
		public virtual IDeadeyeEnergyConfig EnergyConfig
		{
			[NullableContext(1)]
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

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x0600F019 RID: 61465 RVA: 0x0022E0AA File Offset: 0x0022C2AA
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

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x0600F01A RID: 61466 RVA: 0x0022E0DE File Offset: 0x0022C2DE
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

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x0600F01B RID: 61467 RVA: 0x0022E112 File Offset: 0x0022C312
		public virtual string FinishSendSelfEvent
		{
			get
			{
				return this.Instance.FinishSendSelfEvent;
			}
		}

		// Token: 0x04008409 RID: 33801
		private ITriggerDeadeyeMode Instance;

		// Token: 0x0400840A RID: 33802
		private IDeadeyeFollowShooterConfig _FollowShooterConfigCache;

		// Token: 0x0400840B RID: 33803
		private bool _FollowShooterConfigInited;

		// Token: 0x0400840C RID: 33804
		[Nullable(1)]
		private List<int> _FocusOnTagsCache;

		// Token: 0x0400840D RID: 33805
		private bool _FocusOnTagsInited;

		// Token: 0x0400840E RID: 33806
		private IDeadeyeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x0400840F RID: 33807
		private bool _FadeOutConfigInited;

		// Token: 0x04008410 RID: 33808
		private IDeadeyeEnergyConfig _EnergyConfigCache;

		// Token: 0x04008411 RID: 33809
		private bool _EnergyConfigInited;

		// Token: 0x04008412 RID: 33810
		private IDeadeyeCameraConfig _DefaultLookAtCache;

		// Token: 0x04008413 RID: 33811
		private bool _DefaultLookAtInited;

		// Token: 0x04008414 RID: 33812
		private IDeadEyeEffectConfig _EffectConfigCache;

		// Token: 0x04008415 RID: 33813
		private bool _EffectConfigInited;
	}
}
