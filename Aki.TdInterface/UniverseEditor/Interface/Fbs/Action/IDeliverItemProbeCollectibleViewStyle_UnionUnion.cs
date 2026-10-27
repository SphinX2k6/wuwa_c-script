using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006574 RID: 25972
	public class IDeliverItemProbeCollectibleViewStyle_UnionUnion
	{
		// Token: 0x1700C0FA RID: 49402
		// (get) Token: 0x0602D0EA RID: 184554 RVA: 0x0062EB79 File Offset: 0x0062CD79
		// (set) Token: 0x0602D0EB RID: 184555 RVA: 0x0062EB81 File Offset: 0x0062CD81
		public IDeliverItemProbeCollectibleViewStyle_Union Type { get; set; }

		// Token: 0x1700C0FB RID: 49403
		// (get) Token: 0x0602D0EC RID: 184556 RVA: 0x0062EB8A File Offset: 0x0062CD8A
		// (set) Token: 0x0602D0ED RID: 184557 RVA: 0x0062EB92 File Offset: 0x0062CD92
		public object Value { get; set; }

		// Token: 0x0602D0EE RID: 184558 RVA: 0x0062EB9B File Offset: 0x0062CD9B
		public IDeliverItemProbeCollectibleViewStyle_UnionUnion()
		{
			this.Type = IDeliverItemProbeCollectibleViewStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D0EF RID: 184559 RVA: 0x0062EBB1 File Offset: 0x0062CDB1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D0F0 RID: 184560 RVA: 0x0062EBC3 File Offset: 0x0062CDC3
		public IDeliverItemProbeCollectibleViewStyleT AsIDeliverItemProbeCollectibleViewStyle()
		{
			return this.As<IDeliverItemProbeCollectibleViewStyleT>();
		}

		// Token: 0x0602D0F1 RID: 184561 RVA: 0x0062EBCB File Offset: 0x0062CDCB
		public static IDeliverItemProbeCollectibleViewStyle_UnionUnion FromIDeliverItemProbeCollectibleViewStyle(IDeliverItemProbeCollectibleViewStyleT _ideliveritemprobecollectibleviewstyle)
		{
			return new IDeliverItemProbeCollectibleViewStyle_UnionUnion
			{
				Type = IDeliverItemProbeCollectibleViewStyle_Union.IDeliverItemProbeCollectibleViewStyle,
				Value = _ideliveritemprobecollectibleviewstyle
			};
		}

		// Token: 0x0602D0F2 RID: 184562 RVA: 0x0062EBE0 File Offset: 0x0062CDE0
		public IHandInItemViewStyleT AsIHandInItemViewStyle()
		{
			return this.As<IHandInItemViewStyleT>();
		}

		// Token: 0x0602D0F3 RID: 184563 RVA: 0x0062EBE8 File Offset: 0x0062CDE8
		public static IDeliverItemProbeCollectibleViewStyle_UnionUnion FromIHandInItemViewStyle(IHandInItemViewStyleT _ihandinitemviewstyle)
		{
			return new IDeliverItemProbeCollectibleViewStyle_UnionUnion
			{
				Type = IDeliverItemProbeCollectibleViewStyle_Union.IHandInItemViewStyle,
				Value = _ihandinitemviewstyle
			};
		}

		// Token: 0x0602D0F4 RID: 184564 RVA: 0x0062EC00 File Offset: 0x0062CE00
		public static int Pack(FlatBufferBuilder builder, IDeliverItemProbeCollectibleViewStyle_UnionUnion _o)
		{
			IDeliverItemProbeCollectibleViewStyle_Union type = _o.Type;
			if (type == IDeliverItemProbeCollectibleViewStyle_Union.IDeliverItemProbeCollectibleViewStyle)
			{
				return IDeliverItemProbeCollectibleViewStyle.Pack(builder, _o.AsIDeliverItemProbeCollectibleViewStyle()).Value;
			}
			if (type != IDeliverItemProbeCollectibleViewStyle_Union.IHandInItemViewStyle)
			{
				return 0;
			}
			return IHandInItemViewStyle.Pack(builder, _o.AsIHandInItemViewStyle()).Value;
		}
	}
}
