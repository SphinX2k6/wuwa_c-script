using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C40 RID: 27712
	public class IOpenSystemBoardWithReturnType_UnionUnion
	{
		// Token: 0x1700CE63 RID: 52835
		// (get) Token: 0x06030CFA RID: 199930 RVA: 0x006A1895 File Offset: 0x0069FA95
		// (set) Token: 0x06030CFB RID: 199931 RVA: 0x006A189D File Offset: 0x0069FA9D
		public IOpenSystemBoardWithReturnType_Union Type { get; set; }

		// Token: 0x1700CE64 RID: 52836
		// (get) Token: 0x06030CFC RID: 199932 RVA: 0x006A18A6 File Offset: 0x0069FAA6
		// (set) Token: 0x06030CFD RID: 199933 RVA: 0x006A18AE File Offset: 0x0069FAAE
		public object Value { get; set; }

		// Token: 0x06030CFE RID: 199934 RVA: 0x006A18B7 File Offset: 0x0069FAB7
		public IOpenSystemBoardWithReturnType_UnionUnion()
		{
			this.Type = IOpenSystemBoardWithReturnType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030CFF RID: 199935 RVA: 0x006A18CD File Offset: 0x0069FACD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030D00 RID: 199936 RVA: 0x006A18DF File Offset: 0x0069FADF
		public IOpenSystemBoardWithReturnTypeT AsIOpenSystemBoardWithReturnType()
		{
			return this.As<IOpenSystemBoardWithReturnTypeT>();
		}

		// Token: 0x06030D01 RID: 199937 RVA: 0x006A18E7 File Offset: 0x0069FAE7
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenSystemBoardWithReturnType(IOpenSystemBoardWithReturnTypeT _iopensystemboardwithreturntype)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenSystemBoardWithReturnType,
				Value = _iopensystemboardwithreturntype
			};
		}

		// Token: 0x06030D02 RID: 199938 RVA: 0x006A18FC File Offset: 0x0069FAFC
		public IOpenConfirmBoxWithReturnT AsIOpenConfirmBoxWithReturn()
		{
			return this.As<IOpenConfirmBoxWithReturnT>();
		}

		// Token: 0x06030D03 RID: 199939 RVA: 0x006A1904 File Offset: 0x0069FB04
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenConfirmBoxWithReturn(IOpenConfirmBoxWithReturnT _iopenconfirmboxwithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenConfirmBoxWithReturn,
				Value = _iopenconfirmboxwithreturn
			};
		}

		// Token: 0x06030D04 RID: 199940 RVA: 0x006A1919 File Offset: 0x0069FB19
		public IOpenConfirmBox2WithReturnT AsIOpenConfirmBox2WithReturn()
		{
			return this.As<IOpenConfirmBox2WithReturnT>();
		}

		// Token: 0x06030D05 RID: 199941 RVA: 0x006A1921 File Offset: 0x0069FB21
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenConfirmBox2WithReturn(IOpenConfirmBox2WithReturnT _iopenconfirmbox2withreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenConfirmBox2WithReturn,
				Value = _iopenconfirmbox2withreturn
			};
		}

		// Token: 0x06030D06 RID: 199942 RVA: 0x006A1936 File Offset: 0x0069FB36
		public IOpenSoaringChallengeResultWithReturnT AsIOpenSoaringChallengeResultWithReturn()
		{
			return this.As<IOpenSoaringChallengeResultWithReturnT>();
		}

		// Token: 0x06030D07 RID: 199943 RVA: 0x006A193E File Offset: 0x0069FB3E
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenSoaringChallengeResultWithReturn(IOpenSoaringChallengeResultWithReturnT _iopensoaringchallengeresultwithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenSoaringChallengeResultWithReturn,
				Value = _iopensoaringchallengeresultwithreturn
			};
		}

		// Token: 0x06030D08 RID: 199944 RVA: 0x006A1953 File Offset: 0x0069FB53
		public IOpenMotorRaceChallengeResultWithReturnT AsIOpenMotorRaceChallengeResultWithReturn()
		{
			return this.As<IOpenMotorRaceChallengeResultWithReturnT>();
		}

		// Token: 0x06030D09 RID: 199945 RVA: 0x006A195B File Offset: 0x0069FB5B
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenMotorRaceChallengeResultWithReturn(IOpenMotorRaceChallengeResultWithReturnT _iopenmotorracechallengeresultwithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenMotorRaceChallengeResultWithReturn,
				Value = _iopenmotorracechallengeresultwithreturn
			};
		}

		// Token: 0x06030D0A RID: 199946 RVA: 0x006A1970 File Offset: 0x0069FB70
		public IOpenFishingItemDeliveryWithReturnT AsIOpenFishingItemDeliveryWithReturn()
		{
			return this.As<IOpenFishingItemDeliveryWithReturnT>();
		}

		// Token: 0x06030D0B RID: 199947 RVA: 0x006A1978 File Offset: 0x0069FB78
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenFishingItemDeliveryWithReturn(IOpenFishingItemDeliveryWithReturnT _iopenfishingitemdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenFishingItemDeliveryWithReturn,
				Value = _iopenfishingitemdeliverywithreturn
			};
		}

		// Token: 0x06030D0C RID: 199948 RVA: 0x006A198D File Offset: 0x0069FB8D
		public IOpenInfrastructureItemDeliveryWithReturnT AsIOpenInfrastructureItemDeliveryWithReturn()
		{
			return this.As<IOpenInfrastructureItemDeliveryWithReturnT>();
		}

		// Token: 0x06030D0D RID: 199949 RVA: 0x006A1995 File Offset: 0x0069FB95
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenInfrastructureItemDeliveryWithReturn(IOpenInfrastructureItemDeliveryWithReturnT _iopeninfrastructureitemdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenInfrastructureItemDeliveryWithReturn,
				Value = _iopeninfrastructureitemdeliverywithreturn
			};
		}

		// Token: 0x06030D0E RID: 199950 RVA: 0x006A19AA File Offset: 0x0069FBAA
		public IOpenVillageInfrDeliveryWithReturnT AsIOpenVillageInfrDeliveryWithReturn()
		{
			return this.As<IOpenVillageInfrDeliveryWithReturnT>();
		}

		// Token: 0x06030D0F RID: 199951 RVA: 0x006A19B2 File Offset: 0x0069FBB2
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenVillageInfrDeliveryWithReturn(IOpenVillageInfrDeliveryWithReturnT _iopenvillageinfrdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenVillageInfrDeliveryWithReturn,
				Value = _iopenvillageinfrdeliverywithreturn
			};
		}

		// Token: 0x06030D10 RID: 199952 RVA: 0x006A19C7 File Offset: 0x0069FBC7
		public IOpenGreatSwordChallengeResultT AsIOpenGreatSwordChallengeResult()
		{
			return this.As<IOpenGreatSwordChallengeResultT>();
		}

		// Token: 0x06030D11 RID: 199953 RVA: 0x006A19CF File Offset: 0x0069FBCF
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenGreatSwordChallengeResult(IOpenGreatSwordChallengeResultT _iopengreatswordchallengeresult)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenGreatSwordChallengeResult,
				Value = _iopengreatswordchallengeresult
			};
		}

		// Token: 0x06030D12 RID: 199954 RVA: 0x006A19E5 File Offset: 0x0069FBE5
		public IOpenGiantDeliveryWithReturnT AsIOpenGiantDeliveryWithReturn()
		{
			return this.As<IOpenGiantDeliveryWithReturnT>();
		}

		// Token: 0x06030D13 RID: 199955 RVA: 0x006A19ED File Offset: 0x0069FBED
		public static IOpenSystemBoardWithReturnType_UnionUnion FromIOpenGiantDeliveryWithReturn(IOpenGiantDeliveryWithReturnT _iopengiantdeliverywithreturn)
		{
			return new IOpenSystemBoardWithReturnType_UnionUnion
			{
				Type = IOpenSystemBoardWithReturnType_Union.IOpenGiantDeliveryWithReturn,
				Value = _iopengiantdeliverywithreturn
			};
		}

		// Token: 0x06030D14 RID: 199956 RVA: 0x006A1A04 File Offset: 0x0069FC04
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
