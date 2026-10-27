using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5B RID: 27739
	public class IOverrideLookAtType_UnionUnion
	{
		// Token: 0x1700CE97 RID: 52887
		// (get) Token: 0x06030DF9 RID: 200185 RVA: 0x006A36FD File Offset: 0x006A18FD
		// (set) Token: 0x06030DFA RID: 200186 RVA: 0x006A3705 File Offset: 0x006A1905
		public IOverrideLookAtType_Union Type { get; set; }

		// Token: 0x1700CE98 RID: 52888
		// (get) Token: 0x06030DFB RID: 200187 RVA: 0x006A370E File Offset: 0x006A190E
		// (set) Token: 0x06030DFC RID: 200188 RVA: 0x006A3716 File Offset: 0x006A1916
		public object Value { get; set; }

		// Token: 0x06030DFD RID: 200189 RVA: 0x006A371F File Offset: 0x006A191F
		public IOverrideLookAtType_UnionUnion()
		{
			this.Type = IOverrideLookAtType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030DFE RID: 200190 RVA: 0x006A3735 File Offset: 0x006A1935
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030DFF RID: 200191 RVA: 0x006A3747 File Offset: 0x006A1947
		public IOverrideLookAtTypeT AsIOverrideLookAtType()
		{
			return this.As<IOverrideLookAtTypeT>();
		}

		// Token: 0x06030E00 RID: 200192 RVA: 0x006A374F File Offset: 0x006A194F
		public static IOverrideLookAtType_UnionUnion FromIOverrideLookAtType(IOverrideLookAtTypeT _ioverridelookattype)
		{
			return new IOverrideLookAtType_UnionUnion
			{
				Type = IOverrideLookAtType_Union.IOverrideLookAtType,
				Value = _ioverridelookattype
			};
		}

		// Token: 0x06030E01 RID: 200193 RVA: 0x006A3764 File Offset: 0x006A1964
		public ICheckFlowLookAtT AsICheckFlowLookAt()
		{
			return this.As<ICheckFlowLookAtT>();
		}

		// Token: 0x06030E02 RID: 200194 RVA: 0x006A376C File Offset: 0x006A196C
		public static IOverrideLookAtType_UnionUnion FromICheckFlowLookAt(ICheckFlowLookAtT _icheckflowlookat)
		{
			return new IOverrideLookAtType_UnionUnion
			{
				Type = IOverrideLookAtType_Union.ICheckFlowLookAt,
				Value = _icheckflowlookat
			};
		}

		// Token: 0x06030E03 RID: 200195 RVA: 0x006A3784 File Offset: 0x006A1984
		public static int Pack(FlatBufferBuilder builder, IOverrideLookAtType_UnionUnion _o)
		{
			IOverrideLookAtType_Union type = _o.Type;
			if (type == IOverrideLookAtType_Union.IOverrideLookAtType)
			{
				return IOverrideLookAtType.Pack(builder, _o.AsIOverrideLookAtType()).Value;
			}
			if (type != IOverrideLookAtType_Union.ICheckFlowLookAt)
			{
				return 0;
			}
			return ICheckFlowLookAt.Pack(builder, _o.AsICheckFlowLookAt()).Value;
		}
	}
}
