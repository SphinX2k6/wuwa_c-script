using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B9 RID: 10425
	[NullableContext(2)]
	[Nullable(0)]
	public class ICutCameraConfig
	{
		// Token: 0x0600E76A RID: 59242 RVA: 0x0021FBF2 File Offset: 0x0021DDF2
		[NullableContext(1)]
		public static ICutCameraConfig Create(ICutCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICutCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x0600E76B RID: 59243 RVA: 0x0021FC11 File Offset: 0x0021DE11
		[Nullable(1)]
		public virtual ICameraParams CameraParams
		{
			[NullableContext(1)]
			get
			{
				if (this._CameraParamsInited)
				{
					return this._CameraParamsCache;
				}
				this._CameraParamsInited = true;
				this._CameraParamsCache = ICameraParams.Create(this.Instance.CameraParams);
				return this._CameraParamsCache;
			}
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x0600E76C RID: 59244 RVA: 0x0021FC45 File Offset: 0x0021DE45
		public virtual PlayFlow CutFlow
		{
			get
			{
				if (this._CutFlowInited)
				{
					return this._CutFlowCache;
				}
				this._CutFlowInited = true;
				this._CutFlowCache = PlayFlow.Create(this.Instance.CutFlow);
				return this._CutFlowCache;
			}
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x0600E76D RID: 59245 RVA: 0x0021FC79 File Offset: 0x0021DE79
		public virtual ICutCameraTimeParams CutTimeParams
		{
			get
			{
				if (this._CutTimeParamsInited)
				{
					return this._CutTimeParamsCache;
				}
				this._CutTimeParamsInited = true;
				this._CutTimeParamsCache = ICutCameraTimeParams.Create(this.Instance.CutTimeParams);
				return this._CutTimeParamsCache;
			}
		}

		// Token: 0x04007FE5 RID: 32741
		private ICutCameraConfig Instance;

		// Token: 0x04007FE6 RID: 32742
		private ICameraParams _CameraParamsCache;

		// Token: 0x04007FE7 RID: 32743
		private bool _CameraParamsInited;

		// Token: 0x04007FE8 RID: 32744
		private PlayFlow _CutFlowCache;

		// Token: 0x04007FE9 RID: 32745
		private bool _CutFlowInited;

		// Token: 0x04007FEA RID: 32746
		private ICutCameraTimeParams _CutTimeParamsCache;

		// Token: 0x04007FEB RID: 32747
		private bool _CutTimeParamsInited;
	}
}
