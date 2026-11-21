using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E81 RID: 16001
	public class IEnergyFishState_UnionUnion
	{
		// Token: 0x17006C1B RID: 27675
		// (get) Token: 0x0601595A RID: 88410 RVA: 0x0031C700 File Offset: 0x0031A900
		// (set) Token: 0x0601595B RID: 88411 RVA: 0x0031C708 File Offset: 0x0031A908
		public IEnergyFishState_Union Type { get; set; }

		// Token: 0x17006C1C RID: 27676
		// (get) Token: 0x0601595C RID: 88412 RVA: 0x0031C711 File Offset: 0x0031A911
		// (set) Token: 0x0601595D RID: 88413 RVA: 0x0031C719 File Offset: 0x0031A919
		public object Value { get; set; }

		// Token: 0x0601595E RID: 88414 RVA: 0x0031C722 File Offset: 0x0031A922
		public IEnergyFishState_UnionUnion()
		{
			this.Type = IEnergyFishState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601595F RID: 88415 RVA: 0x0031C738 File Offset: 0x0031A938
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015960 RID: 88416 RVA: 0x0031C74A File Offset: 0x0031A94A
		public IEnergyFishStateT AsIEnergyFishState()
		{
			return this.As<IEnergyFishStateT>();
		}

		// Token: 0x06015961 RID: 88417 RVA: 0x0031C752 File Offset: 0x0031A952
		public static IEnergyFishState_UnionUnion FromIEnergyFishState(IEnergyFishStateT _ienergyfishstate)
		{
			return new IEnergyFishState_UnionUnion
			{
				Type = IEnergyFishState_Union.IEnergyFishState,
				Value = _ienergyfishstate
			};
		}

		// Token: 0x06015962 RID: 88418 RVA: 0x0031C767 File Offset: 0x0031A967
		public IEnergyFishSplineStateT AsIEnergyFishSplineState()
		{
			return this.As<IEnergyFishSplineStateT>();
		}

		// Token: 0x06015963 RID: 88419 RVA: 0x0031C76F File Offset: 0x0031A96F
		public static IEnergyFishState_UnionUnion FromIEnergyFishSplineState(IEnergyFishSplineStateT _ienergyfishsplinestate)
		{
			return new IEnergyFishState_UnionUnion
			{
				Type = IEnergyFishState_Union.IEnergyFishSplineState,
				Value = _ienergyfishsplinestate
			};
		}

		// Token: 0x06015964 RID: 88420 RVA: 0x0031C784 File Offset: 0x0031A984
		public IEnergyFishFollowStateT AsIEnergyFishFollowState()
		{
			return this.As<IEnergyFishFollowStateT>();
		}

		// Token: 0x06015965 RID: 88421 RVA: 0x0031C78C File Offset: 0x0031A98C
		public static IEnergyFishState_UnionUnion FromIEnergyFishFollowState(IEnergyFishFollowStateT _ienergyfishfollowstate)
		{
			return new IEnergyFishState_UnionUnion
			{
				Type = IEnergyFishState_Union.IEnergyFishFollowState,
				Value = _ienergyfishfollowstate
			};
		}

		// Token: 0x06015966 RID: 88422 RVA: 0x0031C7A4 File Offset: 0x0031A9A4
		public static int Pack(FlatBufferBuilder builder, IEnergyFishState_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEnergyFishState_Union.IEnergyFishState:
				return IEnergyFishState.Pack(builder, _o.AsIEnergyFishState()).Value;
			case IEnergyFishState_Union.IEnergyFishSplineState:
				return IEnergyFishSplineState.Pack(builder, _o.AsIEnergyFishSplineState()).Value;
			case IEnergyFishState_Union.IEnergyFishFollowState:
				return IEnergyFishFollowState.Pack(builder, _o.AsIEnergyFishFollowState()).Value;
			default:
				return 0;
			}
		}
	}
}
