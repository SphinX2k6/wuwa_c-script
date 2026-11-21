using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C4 RID: 10180
	public class ICameraData
	{
		// Token: 0x0600E14B RID: 57675 RVA: 0x00211F12 File Offset: 0x00210112
		public static ICameraData Create(ICameraData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600E14C RID: 57676 RVA: 0x00211F31 File Offset: 0x00210131
		public virtual IFlowTemplateMode Camera
		{
			get
			{
				if (this._CameraInited)
				{
					return this._CameraCache;
				}
				this._CameraInited = true;
				this._CameraCache = IFlowTemplateMode.Create(this.Instance.Camera);
				return this._CameraCache;
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600E14D RID: 57677 RVA: 0x00211F65 File Offset: 0x00210165
		[Nullable(2)]
		public virtual SetCameraAnim CameraAnim
		{
			[NullableContext(2)]
			get
			{
				if (this._CameraAnimInited)
				{
					return this._CameraAnimCache;
				}
				this._CameraAnimInited = true;
				this._CameraAnimCache = SetCameraAnim.Create(this.Instance.CameraAnim);
				return this._CameraAnimCache;
			}
		}

		// Token: 0x04007A74 RID: 31348
		private ICameraData Instance;

		// Token: 0x04007A75 RID: 31349
		[Nullable(2)]
		private IFlowTemplateMode _CameraCache;

		// Token: 0x04007A76 RID: 31350
		private bool _CameraInited;

		// Token: 0x04007A77 RID: 31351
		[Nullable(2)]
		private SetCameraAnim _CameraAnimCache;

		// Token: 0x04007A78 RID: 31352
		private bool _CameraAnimInited;
	}
}
