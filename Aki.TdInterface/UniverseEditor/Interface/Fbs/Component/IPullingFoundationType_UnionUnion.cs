using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B5 RID: 22453
	public class IPullingFoundationType_UnionUnion
	{
		// Token: 0x1700A79B RID: 42907
		// (get) Token: 0x06025AE8 RID: 154344 RVA: 0x0053291D File Offset: 0x00530B1D
		// (set) Token: 0x06025AE9 RID: 154345 RVA: 0x00532925 File Offset: 0x00530B25
		public IPullingFoundationType_Union Type { get; set; }

		// Token: 0x1700A79C RID: 42908
		// (get) Token: 0x06025AEA RID: 154346 RVA: 0x0053292E File Offset: 0x00530B2E
		// (set) Token: 0x06025AEB RID: 154347 RVA: 0x00532936 File Offset: 0x00530B36
		public object Value { get; set; }

		// Token: 0x06025AEC RID: 154348 RVA: 0x0053293F File Offset: 0x00530B3F
		public IPullingFoundationType_UnionUnion()
		{
			this.Type = IPullingFoundationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025AED RID: 154349 RVA: 0x00532955 File Offset: 0x00530B55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025AEE RID: 154350 RVA: 0x00532967 File Offset: 0x00530B67
		public IPullingFoundationTypeT AsIPullingFoundationType()
		{
			return this.As<IPullingFoundationTypeT>();
		}

		// Token: 0x06025AEF RID: 154351 RVA: 0x0053296F File Offset: 0x00530B6F
		public static IPullingFoundationType_UnionUnion FromIPullingFoundationType(IPullingFoundationTypeT _ipullingfoundationtype)
		{
			return new IPullingFoundationType_UnionUnion
			{
				Type = IPullingFoundationType_Union.IPullingFoundationType,
				Value = _ipullingfoundationtype
			};
		}

		// Token: 0x06025AF0 RID: 154352 RVA: 0x00532984 File Offset: 0x00530B84
		public IPullingCategoryMatchingFoundationT AsIPullingCategoryMatchingFoundation()
		{
			return this.As<IPullingCategoryMatchingFoundationT>();
		}

		// Token: 0x06025AF1 RID: 154353 RVA: 0x0053298C File Offset: 0x00530B8C
		public static IPullingFoundationType_UnionUnion FromIPullingCategoryMatchingFoundation(IPullingCategoryMatchingFoundationT _ipullingcategorymatchingfoundation)
		{
			return new IPullingFoundationType_UnionUnion
			{
				Type = IPullingFoundationType_Union.IPullingCategoryMatchingFoundation,
				Value = _ipullingcategorymatchingfoundation
			};
		}

		// Token: 0x06025AF2 RID: 154354 RVA: 0x005329A4 File Offset: 0x00530BA4
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
