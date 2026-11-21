using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F53 RID: 16211
	public class TEnergyFishStateUnion
	{
		// Token: 0x17006DBA RID: 28090
		// (get) Token: 0x060160CF RID: 90319 RVA: 0x0032A7DC File Offset: 0x003289DC
		// (set) Token: 0x060160D0 RID: 90320 RVA: 0x0032A7E4 File Offset: 0x003289E4
		public TEnergyFishState Type { get; set; }

		// Token: 0x17006DBB RID: 28091
		// (get) Token: 0x060160D1 RID: 90321 RVA: 0x0032A7ED File Offset: 0x003289ED
		// (set) Token: 0x060160D2 RID: 90322 RVA: 0x0032A7F5 File Offset: 0x003289F5
		public object Value { get; set; }

		// Token: 0x060160D3 RID: 90323 RVA: 0x0032A7FE File Offset: 0x003289FE
		public TEnergyFishStateUnion()
		{
			this.Type = TEnergyFishState.NONE;
			this.Value = null;
		}

		// Token: 0x060160D4 RID: 90324 RVA: 0x0032A814 File Offset: 0x00328A14
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060160D5 RID: 90325 RVA: 0x0032A826 File Offset: 0x00328A26
		public IEnergyFishFollowStateT AsIEnergyFishFollowState()
		{
			return this.As<IEnergyFishFollowStateT>();
		}

		// Token: 0x060160D6 RID: 90326 RVA: 0x0032A82E File Offset: 0x00328A2E
		public static TEnergyFishStateUnion FromIEnergyFishFollowState(IEnergyFishFollowStateT _ienergyfishfollowstate)
		{
			return new TEnergyFishStateUnion
			{
				Type = TEnergyFishState.IEnergyFishFollowState,
				Value = _ienergyfishfollowstate
			};
		}

		// Token: 0x060160D7 RID: 90327 RVA: 0x0032A843 File Offset: 0x00328A43
		public IEnergyFishSplineStateT AsIEnergyFishSplineState()
		{
			return this.As<IEnergyFishSplineStateT>();
		}

		// Token: 0x060160D8 RID: 90328 RVA: 0x0032A84B File Offset: 0x00328A4B
		public static TEnergyFishStateUnion FromIEnergyFishSplineState(IEnergyFishSplineStateT _ienergyfishsplinestate)
		{
			return new TEnergyFishStateUnion
			{
				Type = TEnergyFishState.IEnergyFishSplineState,
				Value = _ienergyfishsplinestate
			};
		}

		// Token: 0x060160D9 RID: 90329 RVA: 0x0032A860 File Offset: 0x00328A60
		public static int Pack(FlatBufferBuilder builder, TEnergyFishStateUnion _o)
		{
			TEnergyFishState type = _o.Type;
			if (type == TEnergyFishState.IEnergyFishFollowState)
			{
				return IEnergyFishFollowState.Pack(builder, _o.AsIEnergyFishFollowState()).Value;
			}
			if (type != TEnergyFishState.IEnergyFishSplineState)
			{
				return 0;
			}
			return IEnergyFishSplineState.Pack(builder, _o.AsIEnergyFishSplineState()).Value;
		}
	}
}
