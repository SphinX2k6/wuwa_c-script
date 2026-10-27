using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005853 RID: 22611
	public class IRenderSpecifiedRangeType_UnionUnion
	{
		// Token: 0x1700A8F9 RID: 43257
		// (get) Token: 0x060260DF RID: 155871 RVA: 0x0053F309 File Offset: 0x0053D509
		// (set) Token: 0x060260E0 RID: 155872 RVA: 0x0053F311 File Offset: 0x0053D511
		public IRenderSpecifiedRangeType_Union Type { get; set; }

		// Token: 0x1700A8FA RID: 43258
		// (get) Token: 0x060260E1 RID: 155873 RVA: 0x0053F31A File Offset: 0x0053D51A
		// (set) Token: 0x060260E2 RID: 155874 RVA: 0x0053F322 File Offset: 0x0053D522
		public object Value { get; set; }

		// Token: 0x060260E3 RID: 155875 RVA: 0x0053F32B File Offset: 0x0053D52B
		public IRenderSpecifiedRangeType_UnionUnion()
		{
			this.Type = IRenderSpecifiedRangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060260E4 RID: 155876 RVA: 0x0053F341 File Offset: 0x0053D541
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060260E5 RID: 155877 RVA: 0x0053F353 File Offset: 0x0053D553
		public IRenderSpecifiedRangeTypeT AsIRenderSpecifiedRangeType()
		{
			return this.As<IRenderSpecifiedRangeTypeT>();
		}

		// Token: 0x060260E6 RID: 155878 RVA: 0x0053F35B File Offset: 0x0053D55B
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderSpecifiedRangeType(IRenderSpecifiedRangeTypeT _irenderspecifiedrangetype)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderSpecifiedRangeType,
				Value = _irenderspecifiedrangetype
			};
		}

		// Token: 0x060260E7 RID: 155879 RVA: 0x0053F370 File Offset: 0x0053D570
		public IRenderFlowerBridgeT AsIRenderFlowerBridge()
		{
			return this.As<IRenderFlowerBridgeT>();
		}

		// Token: 0x060260E8 RID: 155880 RVA: 0x0053F378 File Offset: 0x0053D578
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderFlowerBridge(IRenderFlowerBridgeT _irenderflowerbridge)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderFlowerBridge,
				Value = _irenderflowerbridge
			};
		}

		// Token: 0x060260E9 RID: 155881 RVA: 0x0053F38D File Offset: 0x0053D58D
		public IRenderBookPageT AsIRenderBookPage()
		{
			return this.As<IRenderBookPageT>();
		}

		// Token: 0x060260EA RID: 155882 RVA: 0x0053F395 File Offset: 0x0053D595
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderBookPage(IRenderBookPageT _irenderbookpage)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderBookPage,
				Value = _irenderbookpage
			};
		}

		// Token: 0x060260EB RID: 155883 RVA: 0x0053F3AA File Offset: 0x0053D5AA
		public IRenderFogBarrierT AsIRenderFogBarrier()
		{
			return this.As<IRenderFogBarrierT>();
		}

		// Token: 0x060260EC RID: 155884 RVA: 0x0053F3B2 File Offset: 0x0053D5B2
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderFogBarrier(IRenderFogBarrierT _irenderfogbarrier)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderFogBarrier,
				Value = _irenderfogbarrier
			};
		}

		// Token: 0x060260ED RID: 155885 RVA: 0x0053F3C7 File Offset: 0x0053D5C7
		public IRenderQuantumFollowShooterT AsIRenderQuantumFollowShooter()
		{
			return this.As<IRenderQuantumFollowShooterT>();
		}

		// Token: 0x060260EE RID: 155886 RVA: 0x0053F3CF File Offset: 0x0053D5CF
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderQuantumFollowShooter(IRenderQuantumFollowShooterT _irenderquantumfollowshooter)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderQuantumFollowShooter,
				Value = _irenderquantumfollowshooter
			};
		}

		// Token: 0x060260EF RID: 155887 RVA: 0x0053F3E4 File Offset: 0x0053D5E4
		public static int Pack(FlatBufferBuilder builder, IRenderSpecifiedRangeType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRenderSpecifiedRangeType_Union.IRenderSpecifiedRangeType:
				return IRenderSpecifiedRangeType.Pack(builder, _o.AsIRenderSpecifiedRangeType()).Value;
			case IRenderSpecifiedRangeType_Union.IRenderFlowerBridge:
				return IRenderFlowerBridge.Pack(builder, _o.AsIRenderFlowerBridge()).Value;
			case IRenderSpecifiedRangeType_Union.IRenderBookPage:
				return IRenderBookPage.Pack(builder, _o.AsIRenderBookPage()).Value;
			case IRenderSpecifiedRangeType_Union.IRenderFogBarrier:
				return IRenderFogBarrier.Pack(builder, _o.AsIRenderFogBarrier()).Value;
			case IRenderSpecifiedRangeType_Union.IRenderQuantumFollowShooter:
				return IRenderQuantumFollowShooter.Pack(builder, _o.AsIRenderQuantumFollowShooter()).Value;
			default:
				return 0;
			}
		}
	}
}
