using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC7 RID: 11719
	public class ExitMovieMode : ActionParams
	{
		// Token: 0x0600FF28 RID: 65320 RVA: 0x0024C6FE File Offset: 0x0024A8FE
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

		// Token: 0x17005048 RID: 20552
		// (get) Token: 0x0600FF29 RID: 65321 RVA: 0x0024C720 File Offset: 0x0024A920
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

		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x0600FF2A RID: 65322 RVA: 0x0024C756 File Offset: 0x0024A956
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

		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x0600FF2B RID: 65323 RVA: 0x0024C785 File Offset: 0x0024A985
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

		// Token: 0x04008B45 RID: 35653
		private IExitMovieMode Instance;

		// Token: 0x04008B46 RID: 35654
		private IEnterMovieModeDurationType _DurationTypeCache;

		// Token: 0x04008B47 RID: 35655
		private bool _DurationTypeInited;

		// Token: 0x04008B48 RID: 35656
		[Nullable(2)]
		private IMovieModeFadeOutMaskConfig _FadeOutMaskConfigCache;

		// Token: 0x04008B49 RID: 35657
		private bool _FadeOutMaskConfigInited;
	}
}
