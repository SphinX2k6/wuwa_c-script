using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD3 RID: 10963
	[NullableContext(1)]
	[Nullable(0)]
	public class ExitMovieMode : ActionParams
	{
		// Token: 0x0600F072 RID: 61554 RVA: 0x0022E9F2 File Offset: 0x0022CBF2
		public static ExitMovieMode Create(IExitMovieMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitMovieMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x0600F073 RID: 61555 RVA: 0x0022EA14 File Offset: 0x0022CC14
		public virtual float? BorderAnimDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.BorderAnimDuration);
			}
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x0600F074 RID: 61556 RVA: 0x0022EA4A File Offset: 0x0022CC4A
		public virtual IEnterMovieModeDurationType DurationType
		{
			get
			{
				if (this._DurationTypeInited)
				{
					return this._DurationTypeCache;
				}
				this._DurationTypeInited = true;
				this._DurationTypeCache = ActionReadHelper.ReadExitMovieMode_DurationType(this.Instance);
				return this._DurationTypeCache;
			}
		}

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x0600F075 RID: 61557 RVA: 0x0022EA79 File Offset: 0x0022CC79
		[Nullable(2)]
		public virtual IMovieModeFadeOutMaskConfig FadeOutMaskConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._FadeOutMaskConfigInited)
				{
					return this._FadeOutMaskConfigCache;
				}
				this._FadeOutMaskConfigInited = true;
				this._FadeOutMaskConfigCache = IMovieModeFadeOutMaskConfig.Create(this.Instance.FadeOutMaskConfig);
				return this._FadeOutMaskConfigCache;
			}
		}

		// Token: 0x04008441 RID: 33857
		private IExitMovieMode Instance;

		// Token: 0x04008442 RID: 33858
		private IEnterMovieModeDurationType _DurationTypeCache;

		// Token: 0x04008443 RID: 33859
		private bool _DurationTypeInited;

		// Token: 0x04008444 RID: 33860
		[Nullable(2)]
		private IMovieModeFadeOutMaskConfig _FadeOutMaskConfigCache;

		// Token: 0x04008445 RID: 33861
		private bool _FadeOutMaskConfigInited;
	}
}
