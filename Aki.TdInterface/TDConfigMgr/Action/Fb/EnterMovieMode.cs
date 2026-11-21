using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC6 RID: 11718
	[NullableContext(2)]
	[Nullable(0)]
	public class EnterMovieMode : ActionParams
	{
		// Token: 0x0600FF21 RID: 65313 RVA: 0x0024C5CF File Offset: 0x0024A7CF
		[NullableContext(0)]
		public static EnterMovieMode Create(IEnterMovieMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterMovieMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005043 RID: 20547
		// (get) Token: 0x0600FF22 RID: 65314 RVA: 0x0024C5EE File Offset: 0x0024A7EE
		public virtual IMovieCameraConfig MovieCameraConfig
		{
			get
			{
				if (this._MovieCameraConfigInited)
				{
					return this._MovieCameraConfigCache;
				}
				this._MovieCameraConfigInited = true;
				this._MovieCameraConfigCache = IMovieCameraConfig.Create(this.Instance.MovieCameraConfig);
				return this._MovieCameraConfigCache;
			}
		}

		// Token: 0x17005044 RID: 20548
		// (get) Token: 0x0600FF23 RID: 65315 RVA: 0x0024C622 File Offset: 0x0024A822
		public virtual IEnableFuncConfig EnableFuncConfig
		{
			get
			{
				if (this._EnableFuncConfigInited)
				{
					return this._EnableFuncConfigCache;
				}
				this._EnableFuncConfigInited = true;
				this._EnableFuncConfigCache = IEnableFuncConfig.Create(this.Instance.EnableFuncConfig);
				return this._EnableFuncConfigCache;
			}
		}

		// Token: 0x17005045 RID: 20549
		// (get) Token: 0x0600FF24 RID: 65316 RVA: 0x0024C658 File Offset: 0x0024A858
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

		// Token: 0x17005046 RID: 20550
		// (get) Token: 0x0600FF25 RID: 65317 RVA: 0x0024C68E File Offset: 0x0024A88E
		[Nullable(0)]
		public virtual IEnterMovieModeDurationType DurationType
		{
			[NullableContext(0)]
			get
			{
				if (this._DurationTypeInited)
				{
					return this._DurationTypeCache;
				}
				this._DurationTypeInited = true;
				this._DurationTypeCache = ActionReadHelper.ReadEnterMovieMode_DurationType(this.Instance);
				return this._DurationTypeCache;
			}
		}

		// Token: 0x17005047 RID: 20551
		// (get) Token: 0x0600FF26 RID: 65318 RVA: 0x0024C6C0 File Offset: 0x0024A8C0
		public virtual bool? AutoExitInFlow
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.AutoExitInFlow);
			}
		}

		// Token: 0x04008B3E RID: 35646
		private IEnterMovieMode Instance;

		// Token: 0x04008B3F RID: 35647
		private IMovieCameraConfig _MovieCameraConfigCache;

		// Token: 0x04008B40 RID: 35648
		private bool _MovieCameraConfigInited;

		// Token: 0x04008B41 RID: 35649
		private IEnableFuncConfig _EnableFuncConfigCache;

		// Token: 0x04008B42 RID: 35650
		private bool _EnableFuncConfigInited;

		// Token: 0x04008B43 RID: 35651
		[Nullable(0)]
		private IEnterMovieModeDurationType _DurationTypeCache;

		// Token: 0x04008B44 RID: 35652
		private bool _DurationTypeInited;
	}
}
