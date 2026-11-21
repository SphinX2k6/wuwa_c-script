using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062CE RID: 25294
	public class TRenderSpecifiedRangeConfigUnion
	{
		// Token: 0x1700BBA0 RID: 48032
		// (get) Token: 0x0602AFE1 RID: 176097 RVA: 0x005DD138 File Offset: 0x005DB338
		// (set) Token: 0x0602AFE2 RID: 176098 RVA: 0x005DD140 File Offset: 0x005DB340
		public TRenderSpecifiedRangeConfig Type { get; set; }

		// Token: 0x1700BBA1 RID: 48033
		// (get) Token: 0x0602AFE3 RID: 176099 RVA: 0x005DD149 File Offset: 0x005DB349
		// (set) Token: 0x0602AFE4 RID: 176100 RVA: 0x005DD151 File Offset: 0x005DB351
		public object Value { get; set; }

		// Token: 0x0602AFE5 RID: 176101 RVA: 0x005DD15A File Offset: 0x005DB35A
		public TRenderSpecifiedRangeConfigUnion()
		{
			this.Type = TRenderSpecifiedRangeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AFE6 RID: 176102 RVA: 0x005DD170 File Offset: 0x005DB370
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AFE7 RID: 176103 RVA: 0x005DD182 File Offset: 0x005DB382
		public IRenderBeforeYourEyesSceneRevealT AsIRenderBeforeYourEyesSceneReveal()
		{
			return this.As<IRenderBeforeYourEyesSceneRevealT>();
		}

		// Token: 0x0602AFE8 RID: 176104 RVA: 0x005DD18A File Offset: 0x005DB38A
		public static TRenderSpecifiedRangeConfigUnion FromIRenderBeforeYourEyesSceneReveal(IRenderBeforeYourEyesSceneRevealT _irenderbeforeyoureyesscenereveal)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderBeforeYourEyesSceneReveal,
				Value = _irenderbeforeyoureyesscenereveal
			};
		}

		// Token: 0x0602AFE9 RID: 176105 RVA: 0x005DD19F File Offset: 0x005DB39F
		public IRenderBookPageT AsIRenderBookPage()
		{
			return this.As<IRenderBookPageT>();
		}

		// Token: 0x0602AFEA RID: 176106 RVA: 0x005DD1A7 File Offset: 0x005DB3A7
		public static TRenderSpecifiedRangeConfigUnion FromIRenderBookPage(IRenderBookPageT _irenderbookpage)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderBookPage,
				Value = _irenderbookpage
			};
		}

		// Token: 0x0602AFEB RID: 176107 RVA: 0x005DD1BC File Offset: 0x005DB3BC
		public IRenderFlowerBridgeT AsIRenderFlowerBridge()
		{
			return this.As<IRenderFlowerBridgeT>();
		}

		// Token: 0x0602AFEC RID: 176108 RVA: 0x005DD1C4 File Offset: 0x005DB3C4
		public static TRenderSpecifiedRangeConfigUnion FromIRenderFlowerBridge(IRenderFlowerBridgeT _irenderflowerbridge)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderFlowerBridge,
				Value = _irenderflowerbridge
			};
		}

		// Token: 0x0602AFED RID: 176109 RVA: 0x005DD1D9 File Offset: 0x005DB3D9
		public IRenderFogBarrierT AsIRenderFogBarrier()
		{
			return this.As<IRenderFogBarrierT>();
		}

		// Token: 0x0602AFEE RID: 176110 RVA: 0x005DD1E1 File Offset: 0x005DB3E1
		public static TRenderSpecifiedRangeConfigUnion FromIRenderFogBarrier(IRenderFogBarrierT _irenderfogbarrier)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderFogBarrier,
				Value = _irenderfogbarrier
			};
		}

		// Token: 0x0602AFEF RID: 176111 RVA: 0x005DD1F6 File Offset: 0x005DB3F6
		public IRenderQuantumFollowShooterT AsIRenderQuantumFollowShooter()
		{
			return this.As<IRenderQuantumFollowShooterT>();
		}

		// Token: 0x0602AFF0 RID: 176112 RVA: 0x005DD1FE File Offset: 0x005DB3FE
		public static TRenderSpecifiedRangeConfigUnion FromIRenderQuantumFollowShooter(IRenderQuantumFollowShooterT _irenderquantumfollowshooter)
		{
			return new TRenderSpecifiedRangeConfigUnion
			{
				Type = TRenderSpecifiedRangeConfig.IRenderQuantumFollowShooter,
				Value = _irenderquantumfollowshooter
			};
		}

		// Token: 0x0602AFF1 RID: 176113 RVA: 0x005DD214 File Offset: 0x005DB414
		public static int Pack(FlatBufferBuilder builder, TRenderSpecifiedRangeConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TRenderSpecifiedRangeConfig.IRenderBeforeYourEyesSceneReveal:
				return IRenderBeforeYourEyesSceneReveal.Pack(builder, _o.AsIRenderBeforeYourEyesSceneReveal()).Value;
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
