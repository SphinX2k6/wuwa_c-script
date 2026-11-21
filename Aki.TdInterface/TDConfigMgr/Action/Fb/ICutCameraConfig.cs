using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B8E RID: 11150
	[NullableContext(2)]
	[Nullable(0)]
	public class ICutCameraConfig
	{
		// Token: 0x0600F599 RID: 62873 RVA: 0x0023CB72 File Offset: 0x0023AD72
		[NullableContext(0)]
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

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x0600F59A RID: 62874 RVA: 0x0023CB91 File Offset: 0x0023AD91
		[Nullable(0)]
		public virtual ICameraParams CameraParams
		{
			[NullableContext(0)]
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

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x0600F59B RID: 62875 RVA: 0x0023CBC5 File Offset: 0x0023ADC5
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

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x0600F59C RID: 62876 RVA: 0x0023CBF9 File Offset: 0x0023ADF9
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

		// Token: 0x040086A4 RID: 34468
		private ICutCameraConfig Instance;

		// Token: 0x040086A5 RID: 34469
		private ICameraParams _CameraParamsCache;

		// Token: 0x040086A6 RID: 34470
		private bool _CameraParamsInited;

		// Token: 0x040086A7 RID: 34471
		private PlayFlow _CutFlowCache;

		// Token: 0x040086A8 RID: 34472
		private bool _CutFlowInited;

		// Token: 0x040086A9 RID: 34473
		private ICutCameraTimeParams _CutTimeParamsCache;

		// Token: 0x040086AA RID: 34474
		private bool _CutTimeParamsInited;
	}
}
