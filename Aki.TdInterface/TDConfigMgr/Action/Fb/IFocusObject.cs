using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284A RID: 10314
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusObject
	{
		// Token: 0x0600E4A0 RID: 58528 RVA: 0x0021A4D6 File Offset: 0x002186D6
		public static IFocusObject Create(IFocusObject? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusObject
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x0600E4A1 RID: 58529 RVA: 0x0021A4F5 File Offset: 0x002186F5
		public virtual IFocusObjectRotationConfig RotationConfig
		{
			get
			{
				if (this._RotationConfigInited)
				{
					return this._RotationConfigCache;
				}
				this._RotationConfigInited = true;
				this._RotationConfigCache = IFocusObjectRotationConfig.Create(this.Instance.RotationConfig);
				return this._RotationConfigCache;
			}
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x0600E4A2 RID: 58530 RVA: 0x0021A529 File Offset: 0x00218729
		public virtual IFocusObjectCameraConfig CameraConfig
		{
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				this._CameraConfigCache = IFocusObjectCameraConfig.Create(this.Instance.CameraConfig);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x0600E4A3 RID: 58531 RVA: 0x0021A560 File Offset: 0x00218760
		public virtual int? LeaveIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.LeaveIndex);
			}
		}

		// Token: 0x04007E7A RID: 32378
		private IFocusObject Instance;

		// Token: 0x04007E7B RID: 32379
		[Nullable(2)]
		private IFocusObjectRotationConfig _RotationConfigCache;

		// Token: 0x04007E7C RID: 32380
		private bool _RotationConfigInited;

		// Token: 0x04007E7D RID: 32381
		[Nullable(2)]
		private IFocusObjectCameraConfig _CameraConfigCache;

		// Token: 0x04007E7E RID: 32382
		private bool _CameraConfigInited;
	}
}
