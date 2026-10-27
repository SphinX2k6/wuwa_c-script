using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C7 RID: 10439
	[NullableContext(1)]
	[Nullable(0)]
	public class EnterMovieCamera : ActionParams
	{
		// Token: 0x0600E7EA RID: 59370 RVA: 0x00220BF8 File Offset: 0x0021EDF8
		public static EnterMovieCamera Create(IEnterMovieCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterMovieCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x0600E7EB RID: 59371 RVA: 0x00220C17 File Offset: 0x0021EE17
		public virtual IEnterMovieCameraType MovieCameraConfig
		{
			get
			{
				if (this._MovieCameraConfigInited)
				{
					return this._MovieCameraConfigCache;
				}
				this._MovieCameraConfigInited = true;
				this._MovieCameraConfigCache = ActionReadHelper.ReadEnterMovieCamera_MovieCameraConfig(this.Instance);
				return this._MovieCameraConfigCache;
			}
		}

		// Token: 0x04008033 RID: 32819
		private IEnterMovieCamera Instance;

		// Token: 0x04008034 RID: 32820
		private IEnterMovieCameraType _MovieCameraConfigCache;

		// Token: 0x04008035 RID: 32821
		private bool _MovieCameraConfigInited;
	}
}
