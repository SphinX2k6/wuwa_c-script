using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9D RID: 23709
	public class TRenderSpecifiedRangeConfigUnion
	{
		// Token: 0x1700B246 RID: 45638
		// (get) Token: 0x0602899B RID: 166299 RVA: 0x00594A00 File Offset: 0x00592C00
		// (set) Token: 0x0602899C RID: 166300 RVA: 0x00594A08 File Offset: 0x00592C08
		public TRenderSpecifiedRangeConfig Type { get; set; }

		// Token: 0x1700B247 RID: 45639
		// (get) Token: 0x0602899D RID: 166301 RVA: 0x00594A11 File Offset: 0x00592C11
		// (set) Token: 0x0602899E RID: 166302 RVA: 0x00594A19 File Offset: 0x00592C19
		public object Value { get; set; }

		// Token: 0x0602899F RID: 166303 RVA: 0x00594A22 File Offset: 0x00592C22
		public TRenderSpecifiedRangeConfigUnion()
		{
			this.Type = TRenderSpecifiedRangeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060289A0 RID: 166304 RVA: 0x00594A38 File Offset: 0x00592C38
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060289A1 RID: 166305 RVA: 0x00594A4A File Offset: 0x00592C4A
		public IRenderBookPageT AsIRenderBookPage()
		{
			return this.As<IRenderBookPageT>();
		}

		// Token: 0x060289A2 RID: 166306 RVA: 0x00594A52 File Offset: 0x00592C52
		public static TRenderSpecifiedRangeConfigUnion FromIRenderBookPage(IRenderBookPageT _irenderbookpage)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderBookPage,
				Value = _irenderbookpage
			};
		}

		// Token: 0x060289A3 RID: 166307 RVA: 0x00594A67 File Offset: 0x00592C67
		public IRenderFlowerBridgeT AsIRenderFlowerBridge()
		{
			return this.As<IRenderFlowerBridgeT>();
		}

		// Token: 0x060289A4 RID: 166308 RVA: 0x00594A6F File Offset: 0x00592C6F
		public static TRenderSpecifiedRangeConfigUnion FromIRenderFlowerBridge(IRenderFlowerBridgeT _irenderflowerbridge)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderFlowerBridge,
				Value = _irenderflowerbridge
			};
		}

		// Token: 0x060289A5 RID: 166309 RVA: 0x00594A84 File Offset: 0x00592C84
		public IRenderFogBarrierT AsIRenderFogBarrier()
		{
			return this.As<IRenderFogBarrierT>();
		}

		// Token: 0x060289A6 RID: 166310 RVA: 0x00594A8C File Offset: 0x00592C8C
		public static TRenderSpecifiedRangeConfigUnion FromIRenderFogBarrier(IRenderFogBarrierT _irenderfogbarrier)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderFogBarrier,
				Value = _irenderfogbarrier
			};
		}

		// Token: 0x060289A7 RID: 166311 RVA: 0x00594AA1 File Offset: 0x00592CA1
		public IRenderQuantumFollowShooterT AsIRenderQuantumFollowShooter()
		{
			return this.As<IRenderQuantumFollowShooterT>();
		}

		// Token: 0x060289A8 RID: 166312 RVA: 0x00594AA9 File Offset: 0x00592CA9
		public static TRenderSpecifiedRangeConfigUnion FromIRenderQuantumFollowShooter(IRenderQuantumFollowShooterT _irenderquantumfollowshooter)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderQuantumFollowShooter,
				Value = _irenderquantumfollowshooter
			};
		}

		// Token: 0x060289A9 RID: 166313 RVA: 0x00594AC0 File Offset: 0x00592CC0
		public static int Pack(FlatBufferBuilder builder, TRenderSpecifiedRangeConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TRenderSpecifiedRangeConfig.IRenderBookPage:
				return IRenderBookPage.Pack(builder, _o.AsIRenderBookPage()).Value;
			case TRenderSpecifiedRangeConfig.IRenderFlowerBridge:
				return IRenderFlowerBridge.Pack(builder, _o.AsIRenderFlowerBridge()).Value;
			case TRenderSpecifiedRangeConfig.IRenderFogBarrier:
				return IRenderFogBarrier.Pack(builder, _o.AsIRenderFogBarrier()).Value;
			case TRenderSpecifiedRangeConfig.IRenderQuantumFollowShooter:
				return IRenderQuantumFollowShooter.Pack(builder, _o.AsIRenderQuantumFollowShooter()).Value;
			default:
				return 0;
			}
		}
	}
}
