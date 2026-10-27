using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD2 RID: 10962
	[NullableContext(2)]
	[Nullable(0)]
	public class EnterMovieMode : ActionParams
	{
		// Token: 0x0600F06B RID: 61547 RVA: 0x0022E8C3 File Offset: 0x0022CAC3
		[NullableContext(1)]
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

		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x0600F06C RID: 61548 RVA: 0x0022E8E2 File Offset: 0x0022CAE2
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

		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x0600F06D RID: 61549 RVA: 0x0022E916 File Offset: 0x0022CB16
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

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x0600F06E RID: 61550 RVA: 0x0022E94C File Offset: 0x0022CB4C
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

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x0600F06F RID: 61551 RVA: 0x0022E982 File Offset: 0x0022CB82
		[Nullable(1)]
		public virtual IEnterMovieModeDurationType DurationType
		{
			[NullableContext(1)]
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

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x0600F070 RID: 61552 RVA: 0x0022E9B4 File Offset: 0x0022CBB4
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

		// Token: 0x0400843A RID: 33850
		private IEnterMovieMode Instance;

		// Token: 0x0400843B RID: 33851
		private IMovieCameraConfig _MovieCameraConfigCache;

		// Token: 0x0400843C RID: 33852
		private bool _MovieCameraConfigInited;

		// Token: 0x0400843D RID: 33853
		private IEnableFuncConfig _EnableFuncConfigCache;

		// Token: 0x0400843E RID: 33854
		private bool _EnableFuncConfigInited;

		// Token: 0x0400843F RID: 33855
		[Nullable(1)]
		private IEnterMovieModeDurationType _DurationTypeCache;

		// Token: 0x04008440 RID: 33856
		private bool _DurationTypeInited;
	}
}
