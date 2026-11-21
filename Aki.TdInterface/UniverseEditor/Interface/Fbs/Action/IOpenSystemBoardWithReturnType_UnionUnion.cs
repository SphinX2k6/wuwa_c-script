using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A7 RID: 29607
	public class IOpenSystemBoardWithReturnType_UnionUnion
	{
		// Token: 0x1700D97E RID: 55678
		// (get) Token: 0x06033C53 RID: 212051 RVA: 0x006FBD55 File Offset: 0x006F9F55
		// (set) Token: 0x06033C54 RID: 212052 RVA: 0x006FBD5D File Offset: 0x006F9F5D
		public IOpenSystemBoardWithReturnType_Union Type { get; set; }

		// Token: 0x1700D97F RID: 55679
		// (get) Token: 0x06033C55 RID: 212053 RVA: 0x006FBD66 File Offset: 0x006F9F66
		// (set) Token: 0x06033C56 RID: 212054 RVA: 0x006FBD6E File Offset: 0x006F9F6E
		public object Value { get; set; }

		// Token: 0x06033C57 RID: 212055 RVA: 0x006FBD77 File Offset: 0x006F9F77
		public IOpenSystemBoardWithReturnType_UnionUnion()
		{
			this.Type = IOpenSystemBoardWithReturnType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033C58 RID: 212056 RVA: 0x006FBD8D File Offset: 0x006F9F8D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033C59 RID: 212057 RVA: 0x006FBD9F File Offset: 0x006F9F9F
		public IOpenSystemBoardWithReturnTypeT AsIOpenSystemBoardWithReturnType()
		{
			return this.As<IOpenSystemBoardWithReturnTypeT>();
		}

		// Token: 0x06033C5A RID: 212058 RVA: 0x006FBDA7 File Offset: 0x006F9FA7
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenSystemBoardWithReturnType(IOpenSystemBoardWithReturnTypeT _iopensystemboardwithreturntype)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenSystemBoardWithReturnType,
				Value = _iopensystemboardwithreturntype
			};
		}

		// Token: 0x06033C5B RID: 212059 RVA: 0x006FBDBC File Offset: 0x006F9FBC
		public IOpenConfirmBoxWithReturnT AsIOpenConfirmBoxWithReturn()
		{
			return this.As<IOpenConfirmBoxWithReturnT>();
		}

		// Token: 0x06033C5C RID: 212060 RVA: 0x006FBDC4 File Offset: 0x006F9FC4
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenConfirmBoxWithReturn(IOpenConfirmBoxWithReturnT _iopenconfirmboxwithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenConfirmBoxWithReturn,
				Value = _iopenconfirmboxwithreturn
			};
		}

		// Token: 0x06033C5D RID: 212061 RVA: 0x006FBDD9 File Offset: 0x006F9FD9
		public IOpenConfirmBox2WithReturnT AsIOpenConfirmBox2WithReturn()
		{
			return this.As<IOpenConfirmBox2WithReturnT>();
		}

		// Token: 0x06033C5E RID: 212062 RVA: 0x006FBDE1 File Offset: 0x006F9FE1
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenConfirmBox2WithReturn(IOpenConfirmBox2WithReturnT _iopenconfirmbox2withreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenConfirmBox2WithReturn,
				Value = _iopenconfirmbox2withreturn
			};
		}

		// Token: 0x06033C5F RID: 212063 RVA: 0x006FBDF6 File Offset: 0x006F9FF6
		public IOpenSoaringChallengeResultWithReturnT AsIOpenSoaringChallengeResultWithReturn()
		{
			return this.As<IOpenSoaringChallengeResultWithReturnT>();
		}

		// Token: 0x06033C60 RID: 212064 RVA: 0x006FBDFE File Offset: 0x006F9FFE
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenSoaringChallengeResultWithReturn(IOpenSoaringChallengeResultWithReturnT _iopensoaringchallengeresultwithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenSoaringChallengeResultWithReturn,
				Value = _iopensoaringchallengeresultwithreturn
			};
		}

		// Token: 0x06033C61 RID: 212065 RVA: 0x006FBE13 File Offset: 0x006FA013
		public IOpenMotorRaceChallengeResultWithReturnT AsIOpenMotorRaceChallengeResultWithReturn()
		{
			return this.As<IOpenMotorRaceChallengeResultWithReturnT>();
		}

		// Token: 0x06033C62 RID: 212066 RVA: 0x006FBE1B File Offset: 0x006FA01B
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenMotorRaceChallengeResultWithReturn(IOpenMotorRaceChallengeResultWithReturnT _iopenmotorracechallengeresultwithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenMotorRaceChallengeResultWithReturn,
				Value = _iopenmotorracechallengeresultwithreturn
			};
		}

		// Token: 0x06033C63 RID: 212067 RVA: 0x006FBE30 File Offset: 0x006FA030
		public IOpenMechaStuntTrackChallengeResultWithReturnT AsIOpenMechaStuntTrackChallengeResultWithReturn()
		{
			return this.As<IOpenMechaStuntTrackChallengeResultWithReturnT>();
		}

		// Token: 0x06033C64 RID: 212068 RVA: 0x006FBE38 File Offset: 0x006FA038
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenMechaStuntTrackChallengeResultWithReturn(IOpenMechaStuntTrackChallengeResultWithReturnT _iopenmechastunttrackchallengeresultwithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenMechaStuntTrackChallengeResultWithReturn,
				Value = _iopenmechastunttrackchallengeresultwithreturn
			};
		}

		// Token: 0x06033C65 RID: 212069 RVA: 0x006FBE4D File Offset: 0x006FA04D
		public IOpenFishingItemDeliveryWithReturnT AsIOpenFishingItemDeliveryWithReturn()
		{
			return this.As<IOpenFishingItemDeliveryWithReturnT>();
		}

		// Token: 0x06033C66 RID: 212070 RVA: 0x006FBE55 File Offset: 0x006FA055
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenFishingItemDeliveryWithReturn(IOpenFishingItemDeliveryWithReturnT _iopenfishingitemdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenFishingItemDeliveryWithReturn,
				Value = _iopenfishingitemdeliverywithreturn
			};
		}

		// Token: 0x06033C67 RID: 212071 RVA: 0x006FBE6A File Offset: 0x006FA06A
		public IOpenInfrastructureItemDeliveryWithReturnT AsIOpenInfrastructureItemDeliveryWithReturn()
		{
			return this.As<IOpenInfrastructureItemDeliveryWithReturnT>();
		}

		// Token: 0x06033C68 RID: 212072 RVA: 0x006FBE72 File Offset: 0x006FA072
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenInfrastructureItemDeliveryWithReturn(IOpenInfrastructureItemDeliveryWithReturnT _iopeninfrastructureitemdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenInfrastructureItemDeliveryWithReturn,
				Value = _iopeninfrastructureitemdeliverywithreturn
			};
		}

		// Token: 0x06033C69 RID: 212073 RVA: 0x006FBE87 File Offset: 0x006FA087
		public IOpenVillageInfrDeliveryWithReturnT AsIOpenVillageInfrDeliveryWithReturn()
		{
			return this.As<IOpenVillageInfrDeliveryWithReturnT>();
		}

		// Token: 0x06033C6A RID: 212074 RVA: 0x006FBE8F File Offset: 0x006FA08F
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenVillageInfrDeliveryWithReturn(IOpenVillageInfrDeliveryWithReturnT _iopenvillageinfrdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenVillageInfrDeliveryWithReturn,
				Value = _iopenvillageinfrdeliverywithreturn
			};
		}

		// Token: 0x06033C6B RID: 212075 RVA: 0x006FBEA5 File Offset: 0x006FA0A5
		public IOpenGreatSwordChallengeResultT AsIOpenGreatSwordChallengeResult()
		{
			return this.As<IOpenGreatSwordChallengeResultT>();
		}

		// Token: 0x06033C6C RID: 212076 RVA: 0x006FBEAD File Offset: 0x006FA0AD
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenGreatSwordChallengeResult(IOpenGreatSwordChallengeResultT _iopengreatswordchallengeresult)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenGreatSwordChallengeResult,
				Value = _iopengreatswordchallengeresult
			};
		}

		// Token: 0x06033C6D RID: 212077 RVA: 0x006FBEC3 File Offset: 0x006FA0C3
		public IOpenGiantDeliveryWithReturnT AsIOpenGiantDeliveryWithReturn()
		{
			return this.As<IOpenGiantDeliveryWithReturnT>();
		}

		// Token: 0x06033C6E RID: 212078 RVA: 0x006FBECB File Offset: 0x006FA0CB
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenGiantDeliveryWithReturn(IOpenGiantDeliveryWithReturnT _iopengiantdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenGiantDeliveryWithReturn,
				Value = _iopengiantdeliverywithreturn
			};
		}

		// Token: 0x06033C6F RID: 212079 RVA: 0x006FBEE4 File Offset: 0x006FA0E4
		public static int Pack(FlatBufferBuilder builder, IOpenSystemBoardWithReturnType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IOpenSystemBoardWithReturnType_Union.IOpenSystemBoardWithReturnType:
				return IOpenSystemBoardWithReturnType.Pack(builder, _o.AsIOpenSystemBoardWithReturnType()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenConfirmBoxWithReturn:
				return IOpenConfirmBoxWithReturn.Pack(builder, _o.AsIOpenConfirmBoxWithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenConfirmBox2WithReturn:
				return IOpenConfirmBox2WithReturn.Pack(builder, _o.AsIOpenConfirmBox2WithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenSoaringChallengeResultWithReturn:
				return IOpenSoaringChallengeResultWithReturn.Pack(builder, _o.AsIOpenSoaringChallengeResultWithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenMotorRaceChallengeResultWithReturn:
				return IOpenMotorRaceChallengeResultWithReturn.Pack(builder, _o.AsIOpenMotorRaceChallengeResultWithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenMechaStuntTrackChallengeResultWithReturn:
				return IOpenMechaStuntTrackChallengeResultWithReturn.Pack(builder, _o.AsIOpenMechaStuntTrackChallengeResultWithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenFishingItemDeliveryWithReturn:
				return IOpenFishingItemDeliveryWithReturn.Pack(builder, _o.AsIOpenFishingItemDeliveryWithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenInfrastructureItemDeliveryWithReturn:
				return IOpenInfrastructureItemDeliveryWithReturn.Pack(builder, _o.AsIOpenInfrastructureItemDeliveryWithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenVillageInfrDeliveryWithReturn:
				return IOpenVillageInfrDeliveryWithReturn.Pack(builder, _o.AsIOpenVillageInfrDeliveryWithReturn()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenGreatSwordChallengeResult:
				return IOpenGreatSwordChallengeResult.Pack(builder, _o.AsIOpenGreatSwordChallengeResult()).Value;
			case IOpenSystemBoardWithReturnType_Union.IOpenGiantDeliveryWithReturn:
				return IOpenGiantDeliveryWithReturn.Pack(builder, _o.AsIOpenGiantDeliveryWithReturn()).Value;
			default:
				return 0;
			}
		}
	}
}
