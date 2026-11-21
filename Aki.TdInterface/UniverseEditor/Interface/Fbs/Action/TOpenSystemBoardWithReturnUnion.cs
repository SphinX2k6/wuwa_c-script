using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F6D RID: 32621
	public class TOpenSystemBoardWithReturnUnion
	{
		// Token: 0x1700F2C1 RID: 62145
		// (get) Token: 0x0603ACC5 RID: 240837 RVA: 0x007E754A File Offset: 0x007E574A
		// (set) Token: 0x0603ACC6 RID: 240838 RVA: 0x007E7552 File Offset: 0x007E5752
		public TOpenSystemBoardWithReturn Type { get; set; }

		// Token: 0x1700F2C2 RID: 62146
		// (get) Token: 0x0603ACC7 RID: 240839 RVA: 0x007E755B File Offset: 0x007E575B
		// (set) Token: 0x0603ACC8 RID: 240840 RVA: 0x007E7563 File Offset: 0x007E5763
		public object Value { get; set; }

		// Token: 0x0603ACC9 RID: 240841 RVA: 0x007E756C File Offset: 0x007E576C
		public TOpenSystemBoardWithReturnUnion()
		{
			this.Type = TOpenSystemBoardWithReturn.NONE;
			this.Value = null;
		}

		// Token: 0x0603ACCA RID: 240842 RVA: 0x007E7582 File Offset: 0x007E5782
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ACCB RID: 240843 RVA: 0x007E7594 File Offset: 0x007E5794
		public IOpenConfirmBox2WithReturnT AsIOpenConfirmBox2WithReturn()
		{
			return this.As<IOpenConfirmBox2WithReturnT>();
		}

		// Token: 0x0603ACCC RID: 240844 RVA: 0x007E759C File Offset: 0x007E579C
		public static TOpenSystemBoardWithReturnUnion FromIOpenConfirmBox2WithReturn(IOpenConfirmBox2WithReturnT _iopenconfirmbox2withreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenConfirmBox2WithReturn,
				Value = _iopenconfirmbox2withreturn
			};
		}

		// Token: 0x0603ACCD RID: 240845 RVA: 0x007E75B1 File Offset: 0x007E57B1
		public IOpenConfirmBoxWithReturnT AsIOpenConfirmBoxWithReturn()
		{
			return this.As<IOpenConfirmBoxWithReturnT>();
		}

		// Token: 0x0603ACCE RID: 240846 RVA: 0x007E75B9 File Offset: 0x007E57B9
		public static TOpenSystemBoardWithReturnUnion FromIOpenConfirmBoxWithReturn(IOpenConfirmBoxWithReturnT _iopenconfirmboxwithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenConfirmBoxWithReturn,
				Value = _iopenconfirmboxwithreturn
			};
		}

		// Token: 0x0603ACCF RID: 240847 RVA: 0x007E75CE File Offset: 0x007E57CE
		public IOpenFishingItemDeliveryWithReturnT AsIOpenFishingItemDeliveryWithReturn()
		{
			return this.As<IOpenFishingItemDeliveryWithReturnT>();
		}

		// Token: 0x0603ACD0 RID: 240848 RVA: 0x007E75D6 File Offset: 0x007E57D6
		public static TOpenSystemBoardWithReturnUnion FromIOpenFishingItemDeliveryWithReturn(IOpenFishingItemDeliveryWithReturnT _iopenfishingitemdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenFishingItemDeliveryWithReturn,
				Value = _iopenfishingitemdeliverywithreturn
			};
		}

		// Token: 0x0603ACD1 RID: 240849 RVA: 0x007E75EB File Offset: 0x007E57EB
		public IOpenGiantDeliveryWithReturnT AsIOpenGiantDeliveryWithReturn()
		{
			return this.As<IOpenGiantDeliveryWithReturnT>();
		}

		// Token: 0x0603ACD2 RID: 240850 RVA: 0x007E75F3 File Offset: 0x007E57F3
		public static TOpenSystemBoardWithReturnUnion FromIOpenGiantDeliveryWithReturn(IOpenGiantDeliveryWithReturnT _iopengiantdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenGiantDeliveryWithReturn,
				Value = _iopengiantdeliverywithreturn
			};
		}

		// Token: 0x0603ACD3 RID: 240851 RVA: 0x007E7608 File Offset: 0x007E5808
		public IOpenGreatSwordChallengeResultT AsIOpenGreatSwordChallengeResult()
		{
			return this.As<IOpenGreatSwordChallengeResultT>();
		}

		// Token: 0x0603ACD4 RID: 240852 RVA: 0x007E7610 File Offset: 0x007E5810
		public static TOpenSystemBoardWithReturnUnion FromIOpenGreatSwordChallengeResult(IOpenGreatSwordChallengeResultT _iopengreatswordchallengeresult)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenGreatSwordChallengeResult,
				Value = _iopengreatswordchallengeresult
			};
		}

		// Token: 0x0603ACD5 RID: 240853 RVA: 0x007E7625 File Offset: 0x007E5825
		public IOpenInfrastructureItemDeliveryWithReturnT AsIOpenInfrastructureItemDeliveryWithReturn()
		{
			return this.As<IOpenInfrastructureItemDeliveryWithReturnT>();
		}

		// Token: 0x0603ACD6 RID: 240854 RVA: 0x007E762D File Offset: 0x007E582D
		public static TOpenSystemBoardWithReturnUnion FromIOpenInfrastructureItemDeliveryWithReturn(IOpenInfrastructureItemDeliveryWithReturnT _iopeninfrastructureitemdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenInfrastructureItemDeliveryWithReturn,
				Value = _iopeninfrastructureitemdeliverywithreturn
			};
		}

		// Token: 0x0603ACD7 RID: 240855 RVA: 0x007E7642 File Offset: 0x007E5842
		public IOpenMechaStuntTrackChallengeResultWithReturnT AsIOpenMechaStuntTrackChallengeResultWithReturn()
		{
			return this.As<IOpenMechaStuntTrackChallengeResultWithReturnT>();
		}

		// Token: 0x0603ACD8 RID: 240856 RVA: 0x007E764A File Offset: 0x007E584A
		public static TOpenSystemBoardWithReturnUnion FromIOpenMechaStuntTrackChallengeResultWithReturn(IOpenMechaStuntTrackChallengeResultWithReturnT _iopenmechastunttrackchallengeresultwithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenMechaStuntTrackChallengeResultWithReturn,
				Value = _iopenmechastunttrackchallengeresultwithreturn
			};
		}

		// Token: 0x0603ACD9 RID: 240857 RVA: 0x007E765F File Offset: 0x007E585F
		public IOpenMotorRaceChallengeResultWithReturnT AsIOpenMotorRaceChallengeResultWithReturn()
		{
			return this.As<IOpenMotorRaceChallengeResultWithReturnT>();
		}

		// Token: 0x0603ACDA RID: 240858 RVA: 0x007E7667 File Offset: 0x007E5867
		public static TOpenSystemBoardWithReturnUnion FromIOpenMotorRaceChallengeResultWithReturn(IOpenMotorRaceChallengeResultWithReturnT _iopenmotorracechallengeresultwithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenMotorRaceChallengeResultWithReturn,
				Value = _iopenmotorracechallengeresultwithreturn
			};
		}

		// Token: 0x0603ACDB RID: 240859 RVA: 0x007E767C File Offset: 0x007E587C
		public IOpenSoaringChallengeResultWithReturnT AsIOpenSoaringChallengeResultWithReturn()
		{
			return this.As<IOpenSoaringChallengeResultWithReturnT>();
		}

		// Token: 0x0603ACDC RID: 240860 RVA: 0x007E7684 File Offset: 0x007E5884
		public static TOpenSystemBoardWithReturnUnion FromIOpenSoaringChallengeResultWithReturn(IOpenSoaringChallengeResultWithReturnT _iopensoaringchallengeresultwithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenSoaringChallengeResultWithReturn,
				Value = _iopensoaringchallengeresultwithreturn
			};
		}

		// Token: 0x0603ACDD RID: 240861 RVA: 0x007E769A File Offset: 0x007E589A
		public IOpenVillageInfrDeliveryWithReturnT AsIOpenVillageInfrDeliveryWithReturn()
		{
			return this.As<IOpenVillageInfrDeliveryWithReturnT>();
		}

		// Token: 0x0603ACDE RID: 240862 RVA: 0x007E76A2 File Offset: 0x007E58A2
		public static TOpenSystemBoardWithReturnUnion FromIOpenVillageInfrDeliveryWithReturn(IOpenVillageInfrDeliveryWithReturnT _iopenvillageinfrdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenVillageInfrDeliveryWithReturn,
				Value = _iopenvillageinfrdeliverywithreturn
			};
		}

		// Token: 0x0603ACDF RID: 240863 RVA: 0x007E76B8 File Offset: 0x007E58B8
		public static int Pack(FlatBufferBuilder builder, TOpenSystemBoardWithReturnUnion _o)
		{
			switch (_o.Type)
			{
			case TOpenSystemBoardWithReturn.IOpenConfirmBox2WithReturn:
				return IOpenConfirmBox2WithReturn.Pack(builder, _o.AsIOpenConfirmBox2WithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenConfirmBoxWithReturn:
				return IOpenConfirmBoxWithReturn.Pack(builder, _o.AsIOpenConfirmBoxWithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenFishingItemDeliveryWithReturn:
				return IOpenFishingItemDeliveryWithReturn.Pack(builder, _o.AsIOpenFishingItemDeliveryWithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenGiantDeliveryWithReturn:
				return IOpenGiantDeliveryWithReturn.Pack(builder, _o.AsIOpenGiantDeliveryWithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenGreatSwordChallengeResult:
				return IOpenGreatSwordChallengeResult.Pack(builder, _o.AsIOpenGreatSwordChallengeResult()).Value;
			case TOpenSystemBoardWithReturn.IOpenInfrastructureItemDeliveryWithReturn:
				return IOpenInfrastructureItemDeliveryWithReturn.Pack(builder, _o.AsIOpenInfrastructureItemDeliveryWithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenMechaStuntTrackChallengeResultWithReturn:
				return IOpenMechaStuntTrackChallengeResultWithReturn.Pack(builder, _o.AsIOpenMechaStuntTrackChallengeResultWithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenMotorRaceChallengeResultWithReturn:
				return IOpenMotorRaceChallengeResultWithReturn.Pack(builder, _o.AsIOpenMotorRaceChallengeResultWithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenSoaringChallengeResultWithReturn:
				return IOpenSoaringChallengeResultWithReturn.Pack(builder, _o.AsIOpenSoaringChallengeResultWithReturn()).Value;
			case TOpenSystemBoardWithReturn.IOpenVillageInfrDeliveryWithReturn:
				return IOpenVillageInfrDeliveryWithReturn.Pack(builder, _o.AsIOpenVillageInfrDeliveryWithReturn()).Value;
			default:
				return 0;
			}
		}
	}
}
