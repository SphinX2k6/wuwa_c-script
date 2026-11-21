using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B9C RID: 11164
	public class EnterMovieCamera : ActionParams
	{
		// Token: 0x0600F619 RID: 63001 RVA: 0x0023DB78 File Offset: 0x0023BD78
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

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x0600F61A RID: 63002 RVA: 0x0023DB97 File Offset: 0x0023BD97
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

		// Token: 0x040086F2 RID: 34546
		private IEnterMovieCamera Instance;

		// Token: 0x040086F3 RID: 34547
		private IEnterMovieCameraType _MovieCameraConfigCache;

		// Token: 0x040086F4 RID: 34548
		private bool _MovieCameraConfigInited;
	}
}
