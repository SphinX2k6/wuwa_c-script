using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC0 RID: 11712
	public class IMovieCameraConfig
	{
		// Token: 0x0600FF0B RID: 65291 RVA: 0x0024C36B File Offset: 0x0024A56B
		public static IMovieCameraConfig Create(IMovieCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovieCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005039 RID: 20537
		// (get) Token: 0x0600FF0C RID: 65292 RVA: 0x0024C38A File Offset: 0x0024A58A
		public virtual IEnterMovieCameraType MovieCameraType
		{
			get
			{
				if (this._MovieCameraTypeInited)
				{
					return this._MovieCameraTypeCache;
				}
				this._MovieCameraTypeInited = true;
				this._MovieCameraTypeCache = ActionReadHelper.ReadIMovieCameraConfig_MovieCameraType(this.Instance);
				return this._MovieCameraTypeCache;
			}
		}

		// Token: 0x04008B36 RID: 35638
		private IMovieCameraConfig Instance;

		// Token: 0x04008B37 RID: 35639
		private IEnterMovieCameraType _MovieCameraTypeCache;

		// Token: 0x04008B38 RID: 35640
		private bool _MovieCameraTypeInited;
	}
}
