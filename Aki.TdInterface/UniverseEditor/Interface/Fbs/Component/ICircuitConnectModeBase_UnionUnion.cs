using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EB RID: 21739
	public class ICircuitConnectModeBase_UnionUnion
	{
		// Token: 0x17009B4A RID: 39754
		// (get) Token: 0x0602252D RID: 140589 RVA: 0x004BB3A9 File Offset: 0x004B95A9
		// (set) Token: 0x0602252E RID: 140590 RVA: 0x004BB3B1 File Offset: 0x004B95B1
		public ICircuitConnectModeBase_Union Type { get; set; }

		// Token: 0x17009B4B RID: 39755
		// (get) Token: 0x0602252F RID: 140591 RVA: 0x004BB3BA File Offset: 0x004B95BA
		// (set) Token: 0x06022530 RID: 140592 RVA: 0x004BB3C2 File Offset: 0x004B95C2
		public object Value { get; set; }

		// Token: 0x06022531 RID: 140593 RVA: 0x004BB3CB File Offset: 0x004B95CB
		public ICircuitConnectModeBase_UnionUnion()
		{
			this.Type = ICircuitConnectModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022532 RID: 140594 RVA: 0x004BB3E1 File Offset: 0x004B95E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022533 RID: 140595 RVA: 0x004BB3F3 File Offset: 0x004B95F3
		public ICircuitConnectModeBaseT AsICircuitConnectModeBase()
		{
			return this.As<ICircuitConnectModeBaseT>();
		}

		// Token: 0x06022534 RID: 140596 RVA: 0x004BB3FB File Offset: 0x004B95FB
		public static ICircuitConnectModeBase_UnionUnion FromICircuitConnectModeBase(ICircuitConnectModeBaseT _icircuitconnectmodebase)
		{
			return new ICircuitConnectModeBase_UnionUnion
			{
				Type = ICircuitConnectModeBase_Union.ICircuitConnectModeBase,
				Value = _icircuitconnectmodebase
			};
		}

		// Token: 0x06022535 RID: 140597 RVA: 0x004BB410 File Offset: 0x004B9610
		public ICircuitConnectTwoRingsT AsICircuitConnectTwoRings()
		{
			return this.As<ICircuitConnectTwoRingsT>();
		}

		// Token: 0x06022536 RID: 140598 RVA: 0x004BB418 File Offset: 0x004B9618
		public static ICircuitConnectModeBase_UnionUnion FromICircuitConnectTwoRings(ICircuitConnectTwoRingsT _icircuitconnecttworings)
		{
			return new ICircuitConnectModeBase_UnionUnion
			{
				Type = ICircuitConnectModeBase_Union.ICircuitConnectTwoRings,
				Value = _icircuitconnecttworings
			};
		}

		// Token: 0x06022537 RID: 140599 RVA: 0x004BB42D File Offset: 0x004B962D
		public ICircuitConnectThreeRingsT AsICircuitConnectThreeRings()
		{
			return this.As<ICircuitConnectThreeRingsT>();
		}

		// Token: 0x06022538 RID: 140600 RVA: 0x004BB435 File Offset: 0x004B9635
		public static ICircuitConnectModeBase_UnionUnion FromICircuitConnectThreeRings(ICircuitConnectThreeRingsT _icircuitconnectthreerings)
		{
			return new ICircuitConnectModeBase_UnionUnion
			{
				Type = ICircuitConnectModeBase_Union.ICircuitConnectThreeRings,
				Value = _icircuitconnectthreerings
			};
		}

		// Token: 0x06022539 RID: 140601 RVA: 0x004BB44C File Offset: 0x004B964C
		public static int Pack(FlatBufferBuilder builder, ICircuitConnectModeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICircuitConnectModeBase_Union.ICircuitConnectModeBase:
				return ICircuitConnectModeBase.Pack(builder, _o.AsICircuitConnectModeBase()).Value;
			case ICircuitConnectModeBase_Union.ICircuitConnectTwoRings:
				return ICircuitConnectTwoRings.Pack(builder, _o.AsICircuitConnectTwoRings()).Value;
			case ICircuitConnectModeBase_Union.ICircuitConnectThreeRings:
				return ICircuitConnectThreeRings.Pack(builder, _o.AsICircuitConnectThreeRings()).Value;
			default:
				return 0;
			}
		}
	}
}
