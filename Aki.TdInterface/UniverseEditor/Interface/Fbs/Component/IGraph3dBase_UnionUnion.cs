using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588A RID: 22666
	public class IGraph3dBase_UnionUnion
	{
		// Token: 0x1700A444 RID: 42052
		// (get) Token: 0x06024C20 RID: 150560 RVA: 0x0050C7AA File Offset: 0x0050A9AA
		// (set) Token: 0x06024C21 RID: 150561 RVA: 0x0050C7B2 File Offset: 0x0050A9B2
		public IGraph3dBase_Union Type { get; set; }

		// Token: 0x1700A445 RID: 42053
		// (get) Token: 0x06024C22 RID: 150562 RVA: 0x0050C7BB File Offset: 0x0050A9BB
		// (set) Token: 0x06024C23 RID: 150563 RVA: 0x0050C7C3 File Offset: 0x0050A9C3
		public object Value { get; set; }

		// Token: 0x06024C24 RID: 150564 RVA: 0x0050C7CC File Offset: 0x0050A9CC
		public IGraph3dBase_UnionUnion()
		{
			this.Type = IGraph3dBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024C25 RID: 150565 RVA: 0x0050C7E2 File Offset: 0x0050A9E2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024C26 RID: 150566 RVA: 0x0050C7F4 File Offset: 0x0050A9F4
		public IGraph3dBaseT AsIGraph3dBase()
		{
			return this.As<IGraph3dBaseT>();
		}

		// Token: 0x06024C27 RID: 150567 RVA: 0x0050C7FC File Offset: 0x0050A9FC
		public static IGraph3dBase_UnionUnion FromIGraph3dBase(IGraph3dBaseT _igraph3dbase)
		{
			return new IGraph3dBase_UnionUnion
			{
				Type = IGraph3dBase_Union.IGraph3dBase,
				Value = _igraph3dbase
			};
		}

		// Token: 0x06024C28 RID: 150568 RVA: 0x0050C811 File Offset: 0x0050AA11
		public IGraph3dNormalT AsIGraph3dNormal()
		{
			return this.As<IGraph3dNormalT>();
		}

		// Token: 0x06024C29 RID: 150569 RVA: 0x0050C819 File Offset: 0x0050AA19
		public static IGraph3dBase_UnionUnion FromIGraph3dNormal(IGraph3dNormalT _igraph3dnormal)
		{
			return new IGraph3dBase_UnionUnion
			{
				Type = IGraph3dBase_Union.IGraph3dNormal,
				Value = _igraph3dnormal
			};
		}

		// Token: 0x06024C2A RID: 150570 RVA: 0x0050C830 File Offset: 0x0050AA30
		public static int Pack(FlatBufferBuilder builder, IGraph3dBase_UnionUnion _o)
		{
			IGraph3dBase_Union type = _o.Type;
			if (type == IGraph3dBase_Union.IGraph3dBase)
			{
				return IGraph3dBase.Pack(builder, _o.AsIGraph3dBase()).Value;
			}
			if (type != IGraph3dBase_Union.IGraph3dNormal)
			{
				return 0;
			}
			return IGraph3dNormal.Pack(builder, _o.AsIGraph3dNormal()).Value;
		}
	}
}
