using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006171 RID: 24945
	public class IAdjustPlayerCameraType_UnionUnion
	{
		// Token: 0x1700B9CD RID: 47565
		// (get) Token: 0x0602AEF4 RID: 175860 RVA: 0x005EC724 File Offset: 0x005EA924
		// (set) Token: 0x0602AEF5 RID: 175861 RVA: 0x005EC72C File Offset: 0x005EA92C
		public IAdjustPlayerCameraType_Union Type { get; set; }

		// Token: 0x1700B9CE RID: 47566
		// (get) Token: 0x0602AEF6 RID: 175862 RVA: 0x005EC735 File Offset: 0x005EA935
		// (set) Token: 0x0602AEF7 RID: 175863 RVA: 0x005EC73D File Offset: 0x005EA93D
		public object Value { get; set; }

		// Token: 0x0602AEF8 RID: 175864 RVA: 0x005EC746 File Offset: 0x005EA946
		public IAdjustPlayerCameraType_UnionUnion()
		{
			this.Type = IAdjustPlayerCameraType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602AEF9 RID: 175865 RVA: 0x005EC75C File Offset: 0x005EA95C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AEFA RID: 175866 RVA: 0x005EC76E File Offset: 0x005EA96E
		public IAdjustPlayerCameraTypeT AsIAdjustPlayerCameraType()
		{
			return this.As<IAdjustPlayerCameraTypeT>();
		}

		// Token: 0x0602AEFB RID: 175867 RVA: 0x005EC776 File Offset: 0x005EA976
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustPlayerCameraType(IAdjustPlayerCameraTypeT _iadjustplayercameratype)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustPlayerCameraType,
				Value = _iadjustplayercameratype
			};
		}

		// Token: 0x0602AEFC RID: 175868 RVA: 0x005EC78B File Offset: 0x005EA98B
		public IAdjustBasicCameraT AsIAdjustBasicCamera()
		{
			return this.As<IAdjustBasicCameraT>();
		}

		// Token: 0x0602AEFD RID: 175869 RVA: 0x005EC793 File Offset: 0x005EA993
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustBasicCamera(IAdjustBasicCameraT _iadjustbasiccamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustBasicCamera,
				Value = _iadjustbasiccamera
			};
		}

		// Token: 0x0602AEFE RID: 175870 RVA: 0x005EC7A8 File Offset: 0x005EA9A8
		public IAdjustHorizontalCameraT AsIAdjustHorizontalCamera()
		{
			return this.As<IAdjustHorizontalCameraT>();
		}

		// Token: 0x0602AEFF RID: 175871 RVA: 0x005EC7B0 File Offset: 0x005EA9B0
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustHorizontalCamera(IAdjustHorizontalCameraT _iadjusthorizontalcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustHorizontalCamera,
				Value = _iadjusthorizontalcamera
			};
		}

		// Token: 0x0602AF00 RID: 175872 RVA: 0x005EC7C5 File Offset: 0x005EA9C5
		public IAdjustDialogCameraT AsIAdjustDialogCamera()
		{
			return this.As<IAdjustDialogCameraT>();
		}

		// Token: 0x0602AF01 RID: 175873 RVA: 0x005EC7CD File Offset: 0x005EA9CD
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustDialogCamera(IAdjustDialogCameraT _iadjustdialogcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustDialogCamera,
				Value = _iadjustdialogcamera
			};
		}

		// Token: 0x0602AF02 RID: 175874 RVA: 0x005EC7E2 File Offset: 0x005EA9E2
		public IAdjustFixedCameraT AsIAdjustFixedCamera()
		{
			return this.As<IAdjustFixedCameraT>();
		}

		// Token: 0x0602AF03 RID: 175875 RVA: 0x005EC7EA File Offset: 0x005EA9EA
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFixedCamera(IAdjustFixedCameraT _iadjustfixedcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFixedCamera,
				Value = _iadjustfixedcamera
			};
		}

		// Token: 0x0602AF04 RID: 175876 RVA: 0x005EC7FF File Offset: 0x005EA9FF
		public IAdjustAxisLockCameraT AsIAdjustAxisLockCamera()
		{
			return this.As<IAdjustAxisLockCameraT>();
		}

		// Token: 0x0602AF05 RID: 175877 RVA: 0x005EC807 File Offset: 0x005EAA07
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustAxisLockCamera(IAdjustAxisLockCameraT _iadjustaxislockcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustAxisLockCamera,
				Value = _iadjustaxislockcamera
			};
		}

		// Token: 0x0602AF06 RID: 175878 RVA: 0x005EC81C File Offset: 0x005EAA1C
		public IAdjustFirstPersonCameraT AsIAdjustFirstPersonCamera()
		{
			return this.As<IAdjustFirstPersonCameraT>();
		}

		// Token: 0x0602AF07 RID: 175879 RVA: 0x005EC824 File Offset: 0x005EAA24
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFirstPersonCamera(IAdjustFirstPersonCameraT _iadjustfirstpersoncamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFirstPersonCamera,
				Value = _iadjustfirstpersoncamera
			};
		}

		// Token: 0x0602AF08 RID: 175880 RVA: 0x005EC839 File Offset: 0x005EAA39
		public IAdjustFixedLookAtCameraT AsIAdjustFixedLookAtCamera()
		{
			return this.As<IAdjustFixedLookAtCameraT>();
		}

		// Token: 0x0602AF09 RID: 175881 RVA: 0x005EC841 File Offset: 0x005EAA41
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFixedLookAtCamera(IAdjustFixedLookAtCameraT _iadjustfixedlookatcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFixedLookAtCamera,
				Value = _iadjustfixedlookatcamera
			};
		}

		// Token: 0x0602AF0A RID: 175882 RVA: 0x005EC856 File Offset: 0x005EAA56
		public IAdjustZoneFollowCameraT AsIAdjustZoneFollowCamera()
		{
			return this.As<IAdjustZoneFollowCameraT>();
		}

		// Token: 0x0602AF0B RID: 175883 RVA: 0x005EC85E File Offset: 0x005EAA5E
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustZoneFollowCamera(IAdjustZoneFollowCameraT _iadjustzonefollowcamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustZoneFollowCamera,
				Value = _iadjustzonefollowcamera
			};
		}

		// Token: 0x0602AF0C RID: 175884 RVA: 0x005EC874 File Offset: 0x005EAA74
		public IAdjustFixedSurveillanceCameraT AsIAdjustFixedSurveillanceCamera()
		{
			return this.As<IAdjustFixedSurveillanceCameraT>();
		}

		// Token: 0x0602AF0D RID: 175885 RVA: 0x005EC87C File Offset: 0x005EAA7C
		public static IAdjustPlayerCameraType_UnionUnion FromIAdjustFixedSurveillanceCamera(IAdjustFixedSurveillanceCameraT _iadjustfixedsurveillancecamera)
		{
			return new IAdjustPlayerCameraType_UnionUnion
			{
				Type = IAdjustPlayerCameraType_Union.IAdjustFixedSurveillanceCamera,
				Value = _iadjustfixedsurveillancecamera
			};
		}

		// Token: 0x0602AF0E RID: 175886 RVA: 0x005EC894 File Offset: 0x005EAA94
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
