using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007410 RID: 29712
	public class IPetalGrabMoveType_UnionUnion
	{
		// Token: 0x1700DA49 RID: 55881
		// (get) Token: 0x06033FCA RID: 212938 RVA: 0x00701F35 File Offset: 0x00700135
		// (set) Token: 0x06033FCB RID: 212939 RVA: 0x00701F3D File Offset: 0x0070013D
		public IPetalGrabMoveType_Union Type { get; set; }

		// Token: 0x1700DA4A RID: 55882
		// (get) Token: 0x06033FCC RID: 212940 RVA: 0x00701F46 File Offset: 0x00700146
		// (set) Token: 0x06033FCD RID: 212941 RVA: 0x00701F4E File Offset: 0x0070014E
		public object Value { get; set; }

		// Token: 0x06033FCE RID: 212942 RVA: 0x00701F57 File Offset: 0x00700157
		public IPetalGrabMoveType_UnionUnion()
		{
			this.Type = IPetalGrabMoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033FCF RID: 212943 RVA: 0x00701F6D File Offset: 0x0070016D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033FD0 RID: 212944 RVA: 0x00701F7F File Offset: 0x0070017F
		public IPetalGrabMoveTypeT AsIPetalGrabMoveType()
		{
			return this.As<IPetalGrabMoveTypeT>();
		}

		// Token: 0x06033FD1 RID: 212945 RVA: 0x00701F87 File Offset: 0x00700187
		public static IPetalGrabMoveType_UnionUnion FromIPetalGrabMoveType(IPetalGrabMoveTypeT _ipetalgrabmovetype)
		{
			return new IPetalGrabMoveType_UnionUnion
			{
				Type = IPetalGrabMoveType_Union.IPetalGrabMoveType,
				Value = _ipetalgrabmovetype
			};
		}

		// Token: 0x06033FD2 RID: 212946 RVA: 0x00701F9C File Offset: 0x0070019C
		public IPetalGrabMoveLinearT AsIPetalGrabMoveLinear()
		{
			return this.As<IPetalGrabMoveLinearT>();
		}

		// Token: 0x06033FD3 RID: 212947 RVA: 0x00701FA4 File Offset: 0x007001A4
		public static IPetalGrabMoveType_UnionUnion FromIPetalGrabMoveLinear(IPetalGrabMoveLinearT _ipetalgrabmovelinear)
		{
			return new IPetalGrabMoveType_UnionUnion
			{
				Type = IPetalGrabMoveType_Union.IPetalGrabMoveLinear,
				Value = _ipetalgrabmovelinear
			};
		}

		// Token: 0x06033FD4 RID: 212948 RVA: 0x00701FBC File Offset: 0x007001BC
		public static int Pack(FlatBufferBuilder builder, IPetalGrabMoveType_UnionUnion _o)
		{
			IPetalGrabMoveType_Union type = _o.Type;
			if (type == IPetalGrabMoveType_Union.IPetalGrabMoveType)
			{
				return IPetalGrabMoveType.Pack(builder, _o.AsIPetalGrabMoveType()).Value;
			}
			if (type != IPetalGrabMoveType_Union.IPetalGrabMoveLinear)
			{
				return 0;
			}
			return IPetalGrabMoveLinear.Pack(builder, _o.AsIPetalGrabMoveLinear()).Value;
		}
	}
}
