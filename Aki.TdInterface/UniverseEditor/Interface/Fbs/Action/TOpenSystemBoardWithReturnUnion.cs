using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007744 RID: 30532
	public class TOpenSystemBoardWithReturnUnion
	{
		// Token: 0x1700E671 RID: 58993
		// (get) Token: 0x0603778A RID: 227210 RVA: 0x007825BA File Offset: 0x007807BA
		// (set) Token: 0x0603778B RID: 227211 RVA: 0x007825C2 File Offset: 0x007807C2
		public TOpenSystemBoardWithReturn Type { get; set; }

		// Token: 0x1700E672 RID: 58994
		// (get) Token: 0x0603778C RID: 227212 RVA: 0x007825CB File Offset: 0x007807CB
		// (set) Token: 0x0603778D RID: 227213 RVA: 0x007825D3 File Offset: 0x007807D3
		public object Value { get; set; }

		// Token: 0x0603778E RID: 227214 RVA: 0x007825DC File Offset: 0x007807DC
		public TOpenSystemBoardWithReturnUnion()
		{
			this.Type = TOpenSystemBoardWithReturn.NONE;
			this.Value = null;
		}

		// Token: 0x0603778F RID: 227215 RVA: 0x007825F2 File Offset: 0x007807F2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037790 RID: 227216 RVA: 0x00782604 File Offset: 0x00780804
		public IOpenConfirmBox2WithReturnT AsIOpenConfirmBox2WithReturn()
		{
			return this.As<IOpenConfirmBox2WithReturnT>();
		}

		// Token: 0x06037791 RID: 227217 RVA: 0x0078260C File Offset: 0x0078080C
		public static TOpenSystemBoardWithReturnUnion FromIOpenConfirmBox2WithReturn(IOpenConfirmBox2WithReturnT _iopenconfirmbox2withreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenConfirmBox2WithReturn,
				Value = _iopenconfirmbox2withreturn
			};
		}

		// Token: 0x06037792 RID: 227218 RVA: 0x00782621 File Offset: 0x00780821
		public IOpenConfirmBoxWithReturnT AsIOpenConfirmBoxWithReturn()
		{
			return this.As<IOpenConfirmBoxWithReturnT>();
		}

		// Token: 0x06037793 RID: 227219 RVA: 0x00782629 File Offset: 0x00780829
		public static TOpenSystemBoardWithReturnUnion FromIOpenConfirmBoxWithReturn(IOpenConfirmBoxWithReturnT _iopenconfirmboxwithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenConfirmBoxWithReturn,
				Value = _iopenconfirmboxwithreturn
			};
		}

		// Token: 0x06037794 RID: 227220 RVA: 0x0078263E File Offset: 0x0078083E
		public IOpenFishingItemDeliveryWithReturnT AsIOpenFishingItemDeliveryWithReturn()
		{
			return this.As<IOpenFishingItemDeliveryWithReturnT>();
		}

		// Token: 0x06037795 RID: 227221 RVA: 0x00782646 File Offset: 0x00780846
		public static TOpenSystemBoardWithReturnUnion FromIOpenFishingItemDeliveryWithReturn(IOpenFishingItemDeliveryWithReturnT _iopenfishingitemdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenFishingItemDeliveryWithReturn,
				Value = _iopenfishingitemdeliverywithreturn
			};
		}

		// Token: 0x06037796 RID: 227222 RVA: 0x0078265B File Offset: 0x0078085B
		public IOpenGiantDeliveryWithReturnT AsIOpenGiantDeliveryWithReturn()
		{
			return this.As<IOpenGiantDeliveryWithReturnT>();
		}

		// Token: 0x06037797 RID: 227223 RVA: 0x00782663 File Offset: 0x00780863
		public static TOpenSystemBoardWithReturnUnion FromIOpenGiantDeliveryWithReturn(IOpenGiantDeliveryWithReturnT _iopengiantdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenGiantDeliveryWithReturn,
				Value = _iopengiantdeliverywithreturn
			};
		}

		// Token: 0x06037798 RID: 227224 RVA: 0x00782678 File Offset: 0x00780878
		public IOpenGreatSwordChallengeResultT AsIOpenGreatSwordChallengeResult()
		{
			return this.As<IOpenGreatSwordChallengeResultT>();
		}

		// Token: 0x06037799 RID: 227225 RVA: 0x00782680 File Offset: 0x00780880
		public static TOpenSystemBoardWithReturnUnion FromIOpenGreatSwordChallengeResult(IOpenGreatSwordChallengeResultT _iopengreatswordchallengeresult)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenGreatSwordChallengeResult,
				Value = _iopengreatswordchallengeresult
			};
		}

		// Token: 0x0603779A RID: 227226 RVA: 0x00782695 File Offset: 0x00780895
		public IOpenInfrastructureItemDeliveryWithReturnT AsIOpenInfrastructureItemDeliveryWithReturn()
		{
			return this.As<IOpenInfrastructureItemDeliveryWithReturnT>();
		}

		// Token: 0x0603779B RID: 227227 RVA: 0x0078269D File Offset: 0x0078089D
		public static TOpenSystemBoardWithReturnUnion FromIOpenInfrastructureItemDeliveryWithReturn(IOpenInfrastructureItemDeliveryWithReturnT _iopeninfrastructureitemdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenInfrastructureItemDeliveryWithReturn,
				Value = _iopeninfrastructureitemdeliverywithreturn
			};
		}

		// Token: 0x0603779C RID: 227228 RVA: 0x007826B2 File Offset: 0x007808B2
		public IOpenMotorRaceChallengeResultWithReturnT AsIOpenMotorRaceChallengeResultWithReturn()
		{
			return this.As<IOpenMotorRaceChallengeResultWithReturnT>();
		}

		// Token: 0x0603779D RID: 227229 RVA: 0x007826BA File Offset: 0x007808BA
		public static TOpenSystemBoardWithReturnUnion FromIOpenMotorRaceChallengeResultWithReturn(IOpenMotorRaceChallengeResultWithReturnT _iopenmotorracechallengeresultwithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenMotorRaceChallengeResultWithReturn,
				Value = _iopenmotorracechallengeresultwithreturn
			};
		}

		// Token: 0x0603779E RID: 227230 RVA: 0x007826CF File Offset: 0x007808CF
		public IOpenSoaringChallengeResultWithReturnT AsIOpenSoaringChallengeResultWithReturn()
		{
			return this.As<IOpenSoaringChallengeResultWithReturnT>();
		}

		// Token: 0x0603779F RID: 227231 RVA: 0x007826D7 File Offset: 0x007808D7
		public static TOpenSystemBoardWithReturnUnion FromIOpenSoaringChallengeResultWithReturn(IOpenSoaringChallengeResultWithReturnT _iopensoaringchallengeresultwithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenSoaringChallengeResultWithReturn,
				Value = _iopensoaringchallengeresultwithreturn
			};
		}

		// Token: 0x060377A0 RID: 227232 RVA: 0x007826EC File Offset: 0x007808EC
		public IOpenVillageInfrDeliveryWithReturnT AsIOpenVillageInfrDeliveryWithReturn()
		{
			return this.As<IOpenVillageInfrDeliveryWithReturnT>();
		}

		// Token: 0x060377A1 RID: 227233 RVA: 0x007826F4 File Offset: 0x007808F4
		public static TOpenSystemBoardWithReturnUnion FromIOpenVillageInfrDeliveryWithReturn(IOpenVillageInfrDeliveryWithReturnT _iopenvillageinfrdeliverywithreturn)
		{
			return new TOpenSystemBoardWithReturnUnion
			{
				Type = TOpenSystemBoardWithReturn.IOpenVillageInfrDeliveryWithReturn,
				Value = _iopenvillageinfrdeliverywithreturn
			};
		}

		// Token: 0x060377A2 RID: 227234 RVA: 0x0078270C File Offset: 0x0078090C
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
