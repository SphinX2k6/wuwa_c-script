using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006211 RID: 25105
	public class TCircuitConnectModeUnion
	{
		// Token: 0x1700BB19 RID: 47897
		// (get) Token: 0x0602AB3D RID: 174909 RVA: 0x005D2586 File Offset: 0x005D0786
		// (set) Token: 0x0602AB3E RID: 174910 RVA: 0x005D258E File Offset: 0x005D078E
		public TCircuitConnectMode Type { get; set; }

		// Token: 0x1700BB1A RID: 47898
		// (get) Token: 0x0602AB3F RID: 174911 RVA: 0x005D2597 File Offset: 0x005D0797
		// (set) Token: 0x0602AB40 RID: 174912 RVA: 0x005D259F File Offset: 0x005D079F
		public object Value { get; set; }

		// Token: 0x0602AB41 RID: 174913 RVA: 0x005D25A8 File Offset: 0x005D07A8
		public TCircuitConnectModeUnion()
		{
			this.Type = TCircuitConnectMode.NONE;
			this.Value = null;
		}

		// Token: 0x0602AB42 RID: 174914 RVA: 0x005D25BE File Offset: 0x005D07BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AB43 RID: 174915 RVA: 0x005D25D0 File Offset: 0x005D07D0
		public ICircuitConnectThreeRingsT AsICircuitConnectThreeRings()
		{
			return this.As<ICircuitConnectThreeRingsT>();
		}

		// Token: 0x0602AB44 RID: 174916 RVA: 0x005D25D8 File Offset: 0x005D07D8
		public static TCircuitConnectModeUnion FromICircuitConnectThreeRings(ICircuitConnectThreeRingsT _icircuitconnectthreerings)
		{
			return new TCircuitConnectModeUnion
			{
				Type = TCircuitConnectMode.ICircuitConnectThreeRings,
				Value = _icircuitconnectthreerings
			};
		}

		// Token: 0x0602AB45 RID: 174917 RVA: 0x005D25ED File Offset: 0x005D07ED
		public ICircuitConnectTwoRingsT AsICircuitConnectTwoRings()
		{
			return this.As<ICircuitConnectTwoRingsT>();
		}

		// Token: 0x0602AB46 RID: 174918 RVA: 0x005D25F5 File Offset: 0x005D07F5
		public static TCircuitConnectModeUnion FromICircuitConnectTwoRings(ICircuitConnectTwoRingsT _icircuitconnecttworings)
		{
			return new TCircuitConnectModeUnion
			{
				Type = TCircuitConnectMode.ICircuitConnectTwoRings,
				Value = _icircuitconnecttworings
			};
		}

		// Token: 0x0602AB47 RID: 174919 RVA: 0x005D260C File Offset: 0x005D080C
		public static int Pack(FlatBufferBuilder builder, TCircuitConnectModeUnion _o)
		{
			TCircuitConnectMode type = _o.Type;
			if (type == TCircuitConnectMode.ICircuitConnectThreeRings)
			{
				return ICircuitConnectThreeRings.Pack(builder, _o.AsICircuitConnectThreeRings()).Value;
			}
			if (type != TCircuitConnectMode.ICircuitConnectTwoRings)
			{
				return 0;
			}
			return ICircuitConnectTwoRings.Pack(builder, _o.AsICircuitConnectTwoRings()).Value;
		}
	}
}
