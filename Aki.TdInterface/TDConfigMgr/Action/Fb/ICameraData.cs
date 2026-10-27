using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200251D RID: 9501
	[NullableContext(2)]
	[Nullable(0)]
	public class ICameraData
	{
		// Token: 0x0600D3EB RID: 54251 RVA: 0x001F64B2 File Offset: 0x001F46B2
		[NullableContext(1)]
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

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0600D3EC RID: 54252 RVA: 0x001F64D1 File Offset: 0x001F46D1
		[Nullable(1)]
		public virtual IFlowTemplateMode Camera
		{
			[NullableContext(1)]
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

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600D3ED RID: 54253 RVA: 0x001F6505 File Offset: 0x001F4705
		public virtual SetCameraAnim CameraAnim
		{
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

		// Token: 0x0400741F RID: 29727
		private ICameraData Instance;

		// Token: 0x04007420 RID: 29728
		private IFlowTemplateMode _CameraCache;

		// Token: 0x04007421 RID: 29729
		private bool _CameraInited;

		// Token: 0x04007422 RID: 29730
		private SetCameraAnim _CameraAnimCache;

		// Token: 0x04007423 RID: 29731
		private bool _CameraAnimInited;
	}
}
