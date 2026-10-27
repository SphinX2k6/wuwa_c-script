using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763C RID: 30268
	public class TAdjustPlayerCameraOptionUnion
	{
		// Token: 0x1700E5BB RID: 58811
		// (get) Token: 0x060371EE RID: 225774 RVA: 0x00779878 File Offset: 0x00777A78
		// (set) Token: 0x060371EF RID: 225775 RVA: 0x00779880 File Offset: 0x00777A80
		public TAdjustPlayerCameraOption Type { get; set; }

		// Token: 0x1700E5BC RID: 58812
		// (get) Token: 0x060371F0 RID: 225776 RVA: 0x00779889 File Offset: 0x00777A89
		// (set) Token: 0x060371F1 RID: 225777 RVA: 0x00779891 File Offset: 0x00777A91
		public object Value { get; set; }

		// Token: 0x060371F2 RID: 225778 RVA: 0x0077989A File Offset: 0x00777A9A
		public TAdjustPlayerCameraOptionUnion()
		{
			this.Type = TAdjustPlayerCameraOption.NONE;
			this.Value = null;
		}

		// Token: 0x060371F3 RID: 225779 RVA: 0x007798B0 File Offset: 0x00777AB0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060371F4 RID: 225780 RVA: 0x007798C2 File Offset: 0x00777AC2
		public IAdjustAxisLockCameraT AsIAdjustAxisLockCamera()
		{
			return this.As<IAdjustAxisLockCameraT>();
		}

		// Token: 0x060371F5 RID: 225781 RVA: 0x007798CA File Offset: 0x00777ACA
		public static TAdjustPlayerCameraOptionUnion FromIAdjustAxisLockCamera(IAdjustAxisLockCameraT _iadjustaxislockcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustAxisLockCamera,
				Value = _iadjustaxislockcamera
			};
		}

		// Token: 0x060371F6 RID: 225782 RVA: 0x007798DF File Offset: 0x00777ADF
		public IAdjustBasicCameraT AsIAdjustBasicCamera()
		{
			return this.As<IAdjustBasicCameraT>();
		}

		// Token: 0x060371F7 RID: 225783 RVA: 0x007798E7 File Offset: 0x00777AE7
		public static TAdjustPlayerCameraOptionUnion FromIAdjustBasicCamera(IAdjustBasicCameraT _iadjustbasiccamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustBasicCamera,
				Value = _iadjustbasiccamera
			};
		}

		// Token: 0x060371F8 RID: 225784 RVA: 0x007798FC File Offset: 0x00777AFC
		public IAdjustDialogCameraT AsIAdjustDialogCamera()
		{
			return this.As<IAdjustDialogCameraT>();
		}

		// Token: 0x060371F9 RID: 225785 RVA: 0x00779904 File Offset: 0x00777B04
		public static TAdjustPlayerCameraOptionUnion FromIAdjustDialogCamera(IAdjustDialogCameraT _iadjustdialogcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustDialogCamera,
				Value = _iadjustdialogcamera
			};
		}

		// Token: 0x060371FA RID: 225786 RVA: 0x00779919 File Offset: 0x00777B19
		public IAdjustFirstPersonCameraT AsIAdjustFirstPersonCamera()
		{
			return this.As<IAdjustFirstPersonCameraT>();
		}

		// Token: 0x060371FB RID: 225787 RVA: 0x00779921 File Offset: 0x00777B21
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFirstPersonCamera(IAdjustFirstPersonCameraT _iadjustfirstpersoncamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFirstPersonCamera,
				Value = _iadjustfirstpersoncamera
			};
		}

		// Token: 0x060371FC RID: 225788 RVA: 0x00779936 File Offset: 0x00777B36
		public IAdjustFixedCameraT AsIAdjustFixedCamera()
		{
			return this.As<IAdjustFixedCameraT>();
		}

		// Token: 0x060371FD RID: 225789 RVA: 0x0077993E File Offset: 0x00777B3E
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFixedCamera(IAdjustFixedCameraT _iadjustfixedcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFixedCamera,
				Value = _iadjustfixedcamera
			};
		}

		// Token: 0x060371FE RID: 225790 RVA: 0x00779953 File Offset: 0x00777B53
		public IAdjustFixedLookAtCameraT AsIAdjustFixedLookAtCamera()
		{
			return this.As<IAdjustFixedLookAtCameraT>();
		}

		// Token: 0x060371FF RID: 225791 RVA: 0x0077995B File Offset: 0x00777B5B
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFixedLookAtCamera(IAdjustFixedLookAtCameraT _iadjustfixedlookatcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFixedLookAtCamera,
				Value = _iadjustfixedlookatcamera
			};
		}

		// Token: 0x06037200 RID: 225792 RVA: 0x00779970 File Offset: 0x00777B70
		public IAdjustFixedSurveillanceCameraT AsIAdjustFixedSurveillanceCamera()
		{
			return this.As<IAdjustFixedSurveillanceCameraT>();
		}

		// Token: 0x06037201 RID: 225793 RVA: 0x00779978 File Offset: 0x00777B78
		public static TAdjustPlayerCameraOptionUnion FromIAdjustFixedSurveillanceCamera(IAdjustFixedSurveillanceCameraT _iadjustfixedsurveillancecamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustFixedSurveillanceCamera,
				Value = _iadjustfixedsurveillancecamera
			};
		}

		// Token: 0x06037202 RID: 225794 RVA: 0x0077998D File Offset: 0x00777B8D
		public IAdjustHorizontalCameraT AsIAdjustHorizontalCamera()
		{
			return this.As<IAdjustHorizontalCameraT>();
		}

		// Token: 0x06037203 RID: 225795 RVA: 0x00779995 File Offset: 0x00777B95
		public static TAdjustPlayerCameraOptionUnion FromIAdjustHorizontalCamera(IAdjustHorizontalCameraT _iadjusthorizontalcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustHorizontalCamera,
				Value = _iadjusthorizontalcamera
			};
		}

		// Token: 0x06037204 RID: 225796 RVA: 0x007799AA File Offset: 0x00777BAA
		public IAdjustZoneFollowCameraT AsIAdjustZoneFollowCamera()
		{
			return this.As<IAdjustZoneFollowCameraT>();
		}

		// Token: 0x06037205 RID: 225797 RVA: 0x007799B2 File Offset: 0x00777BB2
		public static TAdjustPlayerCameraOptionUnion FromIAdjustZoneFollowCamera(IAdjustZoneFollowCameraT _iadjustzonefollowcamera)
		{
			return new TAdjustPlayerCameraOptionUnion
			{
				Type = TAdjustPlayerCameraOption.IAdjustZoneFollowCamera,
				Value = _iadjustzonefollowcamera
			};
		}

		// Token: 0x06037206 RID: 225798 RVA: 0x007799C8 File Offset: 0x00777BC8
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
