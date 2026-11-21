using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE2 RID: 27618
	public class IDeliverItemProbeCollectibleViewStyle_UnionUnion
	{
		// Token: 0x1700CA8E RID: 51854
		// (get) Token: 0x0602F88C RID: 194700 RVA: 0x0067AFB1 File Offset: 0x006791B1
		// (set) Token: 0x0602F88D RID: 194701 RVA: 0x0067AFB9 File Offset: 0x006791B9
		public IDeliverItemProbeCollectibleViewStyle_Union Type { get; set; }

		// Token: 0x1700CA8F RID: 51855
		// (get) Token: 0x0602F88E RID: 194702 RVA: 0x0067AFC2 File Offset: 0x006791C2
		// (set) Token: 0x0602F88F RID: 194703 RVA: 0x0067AFCA File Offset: 0x006791CA
		public object Value { get; set; }

		// Token: 0x0602F890 RID: 194704 RVA: 0x0067AFD3 File Offset: 0x006791D3
		public IDeliverItemProbeCollectibleViewStyle_UnionUnion()
		{
			this.Type = IDeliverItemProbeCollectibleViewStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F891 RID: 194705 RVA: 0x0067AFE9 File Offset: 0x006791E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F892 RID: 194706 RVA: 0x0067AFFB File Offset: 0x006791FB
		public IDeliverItemProbeCollectibleViewStyleT AsIDeliverItemProbeCollectibleViewStyle()
		{
			return this.As<IDeliverItemProbeCollectibleViewStyleT>();
		}

		// Token: 0x0602F893 RID: 194707 RVA: 0x0067B003 File Offset: 0x00679203
		public static IDeliverItemProbeCollectibleViewStyle_UnionUnion FromIDeliverItemProbeCollectibleViewStyle(IDeliverItemProbeCollectibleViewStyleT _ideliveritemprobecollectibleviewstyle)
		{
			return new IDeliverItemProbeCollectibleViewStyle_UnionUnion
			{
				Type = IDeliverItemProbeCollectibleViewStyle_Union.IDeliverItemProbeCollectibleViewStyle,
				Value = _ideliveritemprobecollectibleviewstyle
			};
		}

		// Token: 0x0602F894 RID: 194708 RVA: 0x0067B018 File Offset: 0x00679218
		public IHandInItemViewStyleT AsIHandInItemViewStyle()
		{
			return this.As<IHandInItemViewStyleT>();
		}

		// Token: 0x0602F895 RID: 194709 RVA: 0x0067B020 File Offset: 0x00679220
		public static IDeliverItemProbeCollectibleViewStyle_UnionUnion FromIHandInItemViewStyle(IHandInItemViewStyleT _ihandinitemviewstyle)
		{
			return new IDeliverItemProbeCollectibleViewStyle_UnionUnion
			{
				Type = IDeliverItemProbeCollectibleViewStyle_Union.IHandInItemViewStyle,
				Value = _ihandinitemviewstyle
			};
		}

		// Token: 0x0602F896 RID: 194710 RVA: 0x0067B038 File Offset: 0x00679238
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
