using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACC RID: 10956
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovieCameraConfig
	{
		// Token: 0x0600F055 RID: 61525 RVA: 0x0022E65F File Offset: 0x0022C85F
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

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x0600F056 RID: 61526 RVA: 0x0022E67E File Offset: 0x0022C87E
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

		// Token: 0x04008432 RID: 33842
		private IMovieCameraConfig Instance;

		// Token: 0x04008433 RID: 33843
		private IEnterMovieCameraType _MovieCameraTypeCache;

		// Token: 0x04008434 RID: 33844
		private bool _MovieCameraTypeInited;
	}
}
