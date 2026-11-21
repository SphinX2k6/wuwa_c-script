using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DBC RID: 23996
	public class IPullingFoundationType_UnionUnion
	{
		// Token: 0x1700B0BF RID: 45247
		// (get) Token: 0x06028008 RID: 163848 RVA: 0x00578AA9 File Offset: 0x00576CA9
		// (set) Token: 0x06028009 RID: 163849 RVA: 0x00578AB1 File Offset: 0x00576CB1
		public IPullingFoundationType_Union Type { get; set; }

		// Token: 0x1700B0C0 RID: 45248
		// (get) Token: 0x0602800A RID: 163850 RVA: 0x00578ABA File Offset: 0x00576CBA
		// (set) Token: 0x0602800B RID: 163851 RVA: 0x00578AC2 File Offset: 0x00576CC2
		public object Value { get; set; }

		// Token: 0x0602800C RID: 163852 RVA: 0x00578ACB File Offset: 0x00576CCB
		public IPullingFoundationType_UnionUnion()
		{
			this.Type = IPullingFoundationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602800D RID: 163853 RVA: 0x00578AE1 File Offset: 0x00576CE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602800E RID: 163854 RVA: 0x00578AF3 File Offset: 0x00576CF3
		public IPullingFoundationTypeT AsIPullingFoundationType()
		{
			return this.As<IPullingFoundationTypeT>();
		}

		// Token: 0x0602800F RID: 163855 RVA: 0x00578AFB File Offset: 0x00576CFB
		public static IPullingFoundationType_UnionUnion FromIPullingFoundationType(IPullingFoundationTypeT _ipullingfoundationtype)
		{
			return new IPullingFoundationType_UnionUnion
			{
				Type = IPullingFoundationType_Union.IPullingFoundationType,
				Value = _ipullingfoundationtype
			};
		}

		// Token: 0x06028010 RID: 163856 RVA: 0x00578B10 File Offset: 0x00576D10
		public IPullingCategoryMatchingFoundationT AsIPullingCategoryMatchingFoundation()
		{
			return this.As<IPullingCategoryMatchingFoundationT>();
		}

		// Token: 0x06028011 RID: 163857 RVA: 0x00578B18 File Offset: 0x00576D18
		public static IPullingFoundationType_UnionUnion FromIPullingCategoryMatchingFoundation(IPullingCategoryMatchingFoundationT _ipullingcategorymatchingfoundation)
		{
			return new IPullingFoundationType_UnionUnion
			{
				Type = IPullingFoundationType_Union.IPullingCategoryMatchingFoundation,
				Value = _ipullingcategorymatchingfoundation
			};
		}

		// Token: 0x06028012 RID: 163858 RVA: 0x00578B30 File Offset: 0x00576D30
		public static int Pack(FlatBufferBuilder builder, IPullingFoundationType_UnionUnion _o)
		{
			IPullingFoundationType_Union type = _o.Type;
			if (type == IPullingFoundationType_Union.IPullingFoundationType)
			{
				return IPullingFoundationType.Pack(builder, _o.AsIPullingFoundationType()).Value;
			}
			if (type != IPullingFoundationType_Union.IPullingCategoryMatchingFoundation)
			{
				return 0;
			}
			return IPullingCategoryMatchingFoundation.Pack(builder, _o.AsIPullingCategoryMatchingFoundation()).Value;
		}
	}
}
