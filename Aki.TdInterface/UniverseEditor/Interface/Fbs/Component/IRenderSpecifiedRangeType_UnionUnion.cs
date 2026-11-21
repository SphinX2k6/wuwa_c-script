using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E5D RID: 24157
	public class IRenderSpecifiedRangeType_UnionUnion
	{
		// Token: 0x1700B224 RID: 45604
		// (get) Token: 0x06028627 RID: 165415 RVA: 0x00585BC9 File Offset: 0x00583DC9
		// (set) Token: 0x06028628 RID: 165416 RVA: 0x00585BD1 File Offset: 0x00583DD1
		public IRenderSpecifiedRangeType_Union Type { get; set; }

		// Token: 0x1700B225 RID: 45605
		// (get) Token: 0x06028629 RID: 165417 RVA: 0x00585BDA File Offset: 0x00583DDA
		// (set) Token: 0x0602862A RID: 165418 RVA: 0x00585BE2 File Offset: 0x00583DE2
		public object Value { get; set; }

		// Token: 0x0602862B RID: 165419 RVA: 0x00585BEB File Offset: 0x00583DEB
		public IRenderSpecifiedRangeType_UnionUnion()
		{
			this.Type = IRenderSpecifiedRangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602862C RID: 165420 RVA: 0x00585C01 File Offset: 0x00583E01
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602862D RID: 165421 RVA: 0x00585C13 File Offset: 0x00583E13
		public IRenderSpecifiedRangeTypeT AsIRenderSpecifiedRangeType()
		{
			return this.As<IRenderSpecifiedRangeTypeT>();
		}

		// Token: 0x0602862E RID: 165422 RVA: 0x00585C1B File Offset: 0x00583E1B
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderSpecifiedRangeType(IRenderSpecifiedRangeTypeT _irenderspecifiedrangetype)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderSpecifiedRangeType,
				Value = _irenderspecifiedrangetype
			};
		}

		// Token: 0x0602862F RID: 165423 RVA: 0x00585C30 File Offset: 0x00583E30
		public IRenderFlowerBridgeT AsIRenderFlowerBridge()
		{
			return this.As<IRenderFlowerBridgeT>();
		}

		// Token: 0x06028630 RID: 165424 RVA: 0x00585C38 File Offset: 0x00583E38
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderFlowerBridge(IRenderFlowerBridgeT _irenderflowerbridge)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderFlowerBridge,
				Value = _irenderflowerbridge
			};
		}

		// Token: 0x06028631 RID: 165425 RVA: 0x00585C4D File Offset: 0x00583E4D
		public IRenderBookPageT AsIRenderBookPage()
		{
			return this.As<IRenderBookPageT>();
		}

		// Token: 0x06028632 RID: 165426 RVA: 0x00585C55 File Offset: 0x00583E55
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderBookPage(IRenderBookPageT _irenderbookpage)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderBookPage,
				Value = _irenderbookpage
			};
		}

		// Token: 0x06028633 RID: 165427 RVA: 0x00585C6A File Offset: 0x00583E6A
		public IRenderFogBarrierT AsIRenderFogBarrier()
		{
			return this.As<IRenderFogBarrierT>();
		}

		// Token: 0x06028634 RID: 165428 RVA: 0x00585C72 File Offset: 0x00583E72
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderFogBarrier(IRenderFogBarrierT _irenderfogbarrier)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderFogBarrier,
				Value = _irenderfogbarrier
			};
		}

		// Token: 0x06028635 RID: 165429 RVA: 0x00585C87 File Offset: 0x00583E87
		public IRenderQuantumFollowShooterT AsIRenderQuantumFollowShooter()
		{
			return this.As<IRenderQuantumFollowShooterT>();
		}

		// Token: 0x06028636 RID: 165430 RVA: 0x00585C8F File Offset: 0x00583E8F
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderQuantumFollowShooter(IRenderQuantumFollowShooterT _irenderquantumfollowshooter)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderQuantumFollowShooter,
				Value = _irenderquantumfollowshooter
			};
		}

		// Token: 0x06028637 RID: 165431 RVA: 0x00585CA4 File Offset: 0x00583EA4
		public IRenderBeforeYourEyesSceneRevealT AsIRenderBeforeYourEyesSceneReveal()
		{
			return this.As<IRenderBeforeYourEyesSceneRevealT>();
		}

		// Token: 0x06028638 RID: 165432 RVA: 0x00585CAC File Offset: 0x00583EAC
		public static IRenderSpecifiedRangeType_UnionUnion FromIRenderBeforeYourEyesSceneReveal(IRenderBeforeYourEyesSceneRevealT _irenderbeforeyoureyesscenereveal)
		{
			return new IRenderSpecifiedRangeType_UnionUnion
			{
				Type = IRenderSpecifiedRangeType_Union.IRenderBeforeYourEyesSceneReveal,
				Value = _irenderbeforeyoureyesscenereveal
			};
		}

		// Token: 0x06028639 RID: 165433 RVA: 0x00585CC4 File Offset: 0x00583EC4
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
			case IRenderSpecifiedRangeType_Union.IRenderBeforeYourEyesSceneReveal:
				return IRenderBeforeYourEyesSceneReveal.Pack(builder, _o.AsIRenderBeforeYourEyesSceneReveal()).Value;
			default:
				return 0;
			}
		}
	}
}
