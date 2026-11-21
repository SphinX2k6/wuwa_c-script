using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D6 RID: 26582
	public class IAdjustPlayerCameraType_UnionUnion
	{
		// Token: 0x1700C33D RID: 49981
		// (get) Token: 0x0602D5ED RID: 185837 RVA: 0x00636900 File Offset: 0x00634B00
		// (set) Token: 0x0602D5EE RID: 185838 RVA: 0x00636908 File Offset: 0x00634B08
		public IAdjustPlayerCameraType_Union Type { get; set; }

		// Token: 0x1700C33E RID: 49982
		// (get) Token: 0x0602D5EF RID: 185839 RVA: 0x00636911 File Offset: 0x00634B11
		// (set) Token: 0x0602D5F0 RID: 185840 RVA: 0x00636919 File Offset: 0x00634B19
		public object Value { get; set; }

		// Token: 0x0602D5F1 RID: 185841 RVA: 0x00636922 File Offset: 0x00634B22
		public IAdjustPlayerCameraType_UnionUnion()
		{
			this.Type = IAdjustPlayerCameraType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D5F2 RID: 185842 RVA: 0x00636938 File Offset: 0x00634B38
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D5F3 RID: 185843 RVA: 0x0063694A File Offset: 0x00634B4A
		public IAdjustPlayerCameraTypeT AsIAdjustPlayerCameraType()
		{
			return this.As<IAdjustPlayerCameraTypeT>();
		}

		// Token: 0x0602D5F4 RID: 185844 RVA: 0x00636952 File Offset: 0x00634B52
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustPlayerCameraType(IAdjustPlayerCameraTypeT _iadjustplayercameratype)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustPlayerCameraType,
				Value = _iadjustplayercameratype
			};
		}

		// Token: 0x0602D5F5 RID: 185845 RVA: 0x00636967 File Offset: 0x00634B67
		public IAdjustBasicCameraT AsIAdjustBasicCamera()
		{
			return this.As<IAdjustBasicCameraT>();
		}

		// Token: 0x0602D5F6 RID: 185846 RVA: 0x0063696F File Offset: 0x00634B6F
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustBasicCamera(IAdjustBasicCameraT _iadjustbasiccamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustBasicCamera,
				Value = _iadjustbasiccamera
			};
		}

		// Token: 0x0602D5F7 RID: 185847 RVA: 0x00636984 File Offset: 0x00634B84
		public IAdjustHorizontalCameraT AsIAdjustHorizontalCamera()
		{
			return this.As<IAdjustHorizontalCameraT>();
		}

		// Token: 0x0602D5F8 RID: 185848 RVA: 0x0063698C File Offset: 0x00634B8C
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustHorizontalCamera(IAdjustHorizontalCameraT _iadjusthorizontalcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustHorizontalCamera,
				Value = _iadjusthorizontalcamera
			};
		}

		// Token: 0x0602D5F9 RID: 185849 RVA: 0x006369A1 File Offset: 0x00634BA1
		public IAdjustDialogCameraT AsIAdjustDialogCamera()
		{
			return this.As<IAdjustDialogCameraT>();
		}

		// Token: 0x0602D5FA RID: 185850 RVA: 0x006369A9 File Offset: 0x00634BA9
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustDialogCamera(IAdjustDialogCameraT _iadjustdialogcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustDialogCamera,
				Value = _iadjustdialogcamera
			};
		}

		// Token: 0x0602D5FB RID: 185851 RVA: 0x006369BE File Offset: 0x00634BBE
		public IAdjustFixedCameraT AsIAdjustFixedCamera()
		{
			return this.As<IAdjustFixedCameraT>();
		}

		// Token: 0x0602D5FC RID: 185852 RVA: 0x006369C6 File Offset: 0x00634BC6
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFixedCamera(IAdjustFixedCameraT _iadjustfixedcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFixedCamera,
				Value = _iadjustfixedcamera
			};
		}

		// Token: 0x0602D5FD RID: 185853 RVA: 0x006369DB File Offset: 0x00634BDB
		public IAdjustAxisLockCameraT AsIAdjustAxisLockCamera()
		{
			return this.As<IAdjustAxisLockCameraT>();
		}

		// Token: 0x0602D5FE RID: 185854 RVA: 0x006369E3 File Offset: 0x00634BE3
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustAxisLockCamera(IAdjustAxisLockCameraT _iadjustaxislockcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustAxisLockCamera,
				Value = _iadjustaxislockcamera
			};
		}

		// Token: 0x0602D5FF RID: 185855 RVA: 0x006369F8 File Offset: 0x00634BF8
		public IAdjustFirstPersonCameraT AsIAdjustFirstPersonCamera()
		{
			return this.As<IAdjustFirstPersonCameraT>();
		}

		// Token: 0x0602D600 RID: 185856 RVA: 0x00636A00 File Offset: 0x00634C00
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFirstPersonCamera(IAdjustFirstPersonCameraT _iadjustfirstpersoncamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFirstPersonCamera,
				Value = _iadjustfirstpersoncamera
			};
		}

		// Token: 0x0602D601 RID: 185857 RVA: 0x00636A15 File Offset: 0x00634C15
		public IAdjustFixedLookAtCameraT AsIAdjustFixedLookAtCamera()
		{
			return this.As<IAdjustFixedLookAtCameraT>();
		}

		// Token: 0x0602D602 RID: 185858 RVA: 0x00636A1D File Offset: 0x00634C1D
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFixedLookAtCamera(IAdjustFixedLookAtCameraT _iadjustfixedlookatcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFixedLookAtCamera,
				Value = _iadjustfixedlookatcamera
			};
		}

		// Token: 0x0602D603 RID: 185859 RVA: 0x00636A32 File Offset: 0x00634C32
		public IAdjustZoneFollowCameraT AsIAdjustZoneFollowCamera()
		{
			return this.As<IAdjustZoneFollowCameraT>();
		}

		// Token: 0x0602D604 RID: 185860 RVA: 0x00636A3A File Offset: 0x00634C3A
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustZoneFollowCamera(IAdjustZoneFollowCameraT _iadjustzonefollowcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustZoneFollowCamera,
				Value = _iadjustzonefollowcamera
			};
		}

		// Token: 0x0602D605 RID: 185861 RVA: 0x00636A50 File Offset: 0x00634C50
		public IAdjustFixedSurveillanceCameraT AsIAdjustFixedSurveillanceCamera()
		{
			return this.As<IAdjustFixedSurveillanceCameraT>();
		}

		// Token: 0x0602D606 RID: 185862 RVA: 0x00636A58 File Offset: 0x00634C58
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFixedSurveillanceCamera(IAdjustFixedSurveillanceCameraT _iadjustfixedsurveillancecamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFixedSurveillanceCamera,
				Value = _iadjustfixedsurveillancecamera
			};
		}

		// Token: 0x0602D607 RID: 185863 RVA: 0x00636A70 File Offset: 0x00634C70
		public static int Pack(FlatBufferBuilder builder, IAdjustPlayerCameraType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAdjustPlayerCameraType_Union.IAdjustPlayerCameraType:
				return IAdjustPlayerCameraType.Pack(builder, _o.AsIAdjustPlayerCameraType()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustBasicCamera:
				return IAdjustBasicCamera.Pack(builder, _o.AsIAdjustBasicCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustHorizontalCamera:
				return IAdjustHorizontalCamera.Pack(builder, _o.AsIAdjustHorizontalCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustDialogCamera:
				return IAdjustDialogCamera.Pack(builder, _o.AsIAdjustDialogCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustFixedCamera:
				return IAdjustFixedCamera.Pack(builder, _o.AsIAdjustFixedCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustAxisLockCamera:
				return IAdjustAxisLockCamera.Pack(builder, _o.AsIAdjustAxisLockCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustFirstPersonCamera:
				return IAdjustFirstPersonCamera.Pack(builder, _o.AsIAdjustFirstPersonCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustFixedLookAtCamera:
				return IAdjustFixedLookAtCamera.Pack(builder, _o.AsIAdjustFixedLookAtCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustZoneFollowCamera:
				return IAdjustZoneFollowCamera.Pack(builder, _o.AsIAdjustZoneFollowCamera()).Value;
			case IAdjustPlayerCameraType_Union.IAdjustFixedSurveillanceCamera:
				return IAdjustFixedSurveillanceCamera.Pack(builder, _o.AsIAdjustFixedSurveillanceCamera()).Value;
			default:
				return 0;
			}
		}
	}
}
