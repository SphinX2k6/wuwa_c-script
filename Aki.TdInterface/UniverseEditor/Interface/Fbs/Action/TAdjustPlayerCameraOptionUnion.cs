using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E4A RID: 32330
	public class TAdjustPlayerCameraOptionUnion
	{
		// Token: 0x1700F1F9 RID: 61945
		// (get) Token: 0x0603A693 RID: 239251 RVA: 0x007DD974 File Offset: 0x007DBB74
		// (set) Token: 0x0603A694 RID: 239252 RVA: 0x007DD97C File Offset: 0x007DBB7C
		public TAdjustPlayerCameraOption Type { get; set; }

		// Token: 0x1700F1FA RID: 61946
		// (get) Token: 0x0603A695 RID: 239253 RVA: 0x007DD985 File Offset: 0x007DBB85
		// (set) Token: 0x0603A696 RID: 239254 RVA: 0x007DD98D File Offset: 0x007DBB8D
		public object Value { get; set; }

		// Token: 0x0603A697 RID: 239255 RVA: 0x007DD996 File Offset: 0x007DBB96
		public TAdjustPlayerCameraOptionUnion()
		{
			this.Type = TAdjustPlayerCameraOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603A698 RID: 239256 RVA: 0x007DD9AC File Offset: 0x007DBBAC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A699 RID: 239257 RVA: 0x007DD9BE File Offset: 0x007DBBBE
		public IAdjustAxisLockCameraT AsIAdjustAxisLockCamera()
		{
			return this.As<IAdjustAxisLockCameraT>();
		}

		// Token: 0x0603A69A RID: 239258 RVA: 0x007DD9C6 File Offset: 0x007DBBC6
		public static TAdjustPlayerCameraOptionUnion FromIAdjustAxisLockCamera(IAdjustAxisLockCameraT _iadjustaxislockcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustAxisLockCamera,
				Value = _iadjustaxislockcamera
			};
		}

		// Token: 0x0603A69B RID: 239259 RVA: 0x007DD9DB File Offset: 0x007DBBDB
		public IAdjustBasicCameraT AsIAdjustBasicCamera()
		{
			return this.As<IAdjustBasicCameraT>();
		}

		// Token: 0x0603A69C RID: 239260 RVA: 0x007DD9E3 File Offset: 0x007DBBE3
		public static TAdjustPlayerCameraOptionUnion FromIAdjustBasicCamera(IAdjustBasicCameraT _iadjustbasiccamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustBasicCamera,
				Value = _iadjustbasiccamera
			};
		}

		// Token: 0x0603A69D RID: 239261 RVA: 0x007DD9F8 File Offset: 0x007DBBF8
		public IAdjustDialogCameraT AsIAdjustDialogCamera()
		{
			return this.As<IAdjustDialogCameraT>();
		}

		// Token: 0x0603A69E RID: 239262 RVA: 0x007DDA00 File Offset: 0x007DBC00
		public static TAdjustPlayerCameraOptionUnion FromIAdjustDialogCamera(IAdjustDialogCameraT _iadjustdialogcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustDialogCamera,
				Value = _iadjustdialogcamera
			};
		}

		// Token: 0x0603A69F RID: 239263 RVA: 0x007DDA15 File Offset: 0x007DBC15
		public IAdjustFirstPersonCameraT AsIAdjustFirstPersonCamera()
		{
			return this.As<IAdjustFirstPersonCameraT>();
		}

		// Token: 0x0603A6A0 RID: 239264 RVA: 0x007DDA1D File Offset: 0x007DBC1D
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFirstPersonCamera(IAdjustFirstPersonCameraT _iadjustfirstpersoncamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFirstPersonCamera,
				Value = _iadjustfirstpersoncamera
			};
		}

		// Token: 0x0603A6A1 RID: 239265 RVA: 0x007DDA32 File Offset: 0x007DBC32
		public IAdjustFixedCameraT AsIAdjustFixedCamera()
		{
			return this.As<IAdjustFixedCameraT>();
		}

		// Token: 0x0603A6A2 RID: 239266 RVA: 0x007DDA3A File Offset: 0x007DBC3A
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFixedCamera(IAdjustFixedCameraT _iadjustfixedcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFixedCamera,
				Value = _iadjustfixedcamera
			};
		}

		// Token: 0x0603A6A3 RID: 239267 RVA: 0x007DDA4F File Offset: 0x007DBC4F
		public IAdjustFixedLookAtCameraT AsIAdjustFixedLookAtCamera()
		{
			return this.As<IAdjustFixedLookAtCameraT>();
		}

		// Token: 0x0603A6A4 RID: 239268 RVA: 0x007DDA57 File Offset: 0x007DBC57
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFixedLookAtCamera(IAdjustFixedLookAtCameraT _iadjustfixedlookatcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFixedLookAtCamera,
				Value = _iadjustfixedlookatcamera
			};
		}

		// Token: 0x0603A6A5 RID: 239269 RVA: 0x007DDA6C File Offset: 0x007DBC6C
		public IAdjustFixedSurveillanceCameraT AsIAdjustFixedSurveillanceCamera()
		{
			return this.As<IAdjustFixedSurveillanceCameraT>();
		}

		// Token: 0x0603A6A6 RID: 239270 RVA: 0x007DDA74 File Offset: 0x007DBC74
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFixedSurveillanceCamera(IAdjustFixedSurveillanceCameraT _iadjustfixedsurveillancecamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFixedSurveillanceCamera,
				Value = _iadjustfixedsurveillancecamera
			};
		}

		// Token: 0x0603A6A7 RID: 239271 RVA: 0x007DDA89 File Offset: 0x007DBC89
		public IAdjustHorizontalCameraT AsIAdjustHorizontalCamera()
		{
			return this.As<IAdjustHorizontalCameraT>();
		}

		// Token: 0x0603A6A8 RID: 239272 RVA: 0x007DDA91 File Offset: 0x007DBC91
		public static TAdjustPlayerCameraOptionUnion FromIAdjustHorizontalCamera(IAdjustHorizontalCameraT _iadjusthorizontalcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustHorizontalCamera,
				Value = _iadjusthorizontalcamera
			};
		}

		// Token: 0x0603A6A9 RID: 239273 RVA: 0x007DDAA6 File Offset: 0x007DBCA6
		public IAdjustZoneFollowCameraT AsIAdjustZoneFollowCamera()
		{
			return this.As<IAdjustZoneFollowCameraT>();
		}

		// Token: 0x0603A6AA RID: 239274 RVA: 0x007DDAAE File Offset: 0x007DBCAE
		public static TAdjustPlayerCameraOptionUnion FromIAdjustZoneFollowCamera(IAdjustZoneFollowCameraT _iadjustzonefollowcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustZoneFollowCamera,
				Value = _iadjustzonefollowcamera
			};
		}

		// Token: 0x0603A6AB RID: 239275 RVA: 0x007DDAC4 File Offset: 0x007DBCC4
		public static int Pack(FlatBufferBuilder builder, TAdjustPlayerCameraOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TAdjustPlayerCameraOption.IAdjustAxisLockCamera:
				return IAdjustAxisLockCamera.Pack(builder, _o.AsIAdjustAxisLockCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustBasicCamera:
				return IAdjustBasicCamera.Pack(builder, _o.AsIAdjustBasicCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustDialogCamera:
				return IAdjustDialogCamera.Pack(builder, _o.AsIAdjustDialogCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustFirstPersonCamera:
				return IAdjustFirstPersonCamera.Pack(builder, _o.AsIAdjustFirstPersonCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustFixedCamera:
				return IAdjustFixedCamera.Pack(builder, _o.AsIAdjustFixedCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustFixedLookAtCamera:
				return IAdjustFixedLookAtCamera.Pack(builder, _o.AsIAdjustFixedLookAtCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustFixedSurveillanceCamera:
				return IAdjustFixedSurveillanceCamera.Pack(builder, _o.AsIAdjustFixedSurveillanceCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustHorizontalCamera:
				return IAdjustHorizontalCamera.Pack(builder, _o.AsIAdjustHorizontalCamera()).Value;
			case TAdjustPlayerCameraOption.IAdjustZoneFollowCamera:
				return IAdjustZoneFollowCamera.Pack(builder, _o.AsIAdjustZoneFollowCamera()).Value;
			default:
				return 0;
			}
		}
	}
}
