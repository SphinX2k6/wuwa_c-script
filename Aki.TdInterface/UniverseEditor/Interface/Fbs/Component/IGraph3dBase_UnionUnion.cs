using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005304 RID: 21252
	public class IGraph3dBase_UnionUnion
	{
		// Token: 0x17009C0C RID: 39948
		// (get) Token: 0x06022B6C RID: 142188 RVA: 0x004CF8D6 File Offset: 0x004CDAD6
		// (set) Token: 0x06022B6D RID: 142189 RVA: 0x004CF8DE File Offset: 0x004CDADE
		public IGraph3dBase_Union Type { get; set; }

		// Token: 0x17009C0D RID: 39949
		// (get) Token: 0x06022B6E RID: 142190 RVA: 0x004CF8E7 File Offset: 0x004CDAE7
		// (set) Token: 0x06022B6F RID: 142191 RVA: 0x004CF8EF File Offset: 0x004CDAEF
		public object Value { get; set; }

		// Token: 0x06022B70 RID: 142192 RVA: 0x004CF8F8 File Offset: 0x004CDAF8
		public IGraph3dBase_UnionUnion()
		{
			this.Type = IGraph3dBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022B71 RID: 142193 RVA: 0x004CF90E File Offset: 0x004CDB0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022B72 RID: 142194 RVA: 0x004CF920 File Offset: 0x004CDB20
		public IGraph3dBaseT AsIGraph3dBase()
		{
			return this.As<IGraph3dBaseT>();
		}

		// Token: 0x06022B73 RID: 142195 RVA: 0x004CF928 File Offset: 0x004CDB28
		public static IGraph3dBase_UnionUnion FromIGraph3dBase(IGraph3dBaseT _igraph3dbase)
		{
			return new IGraph3dBase_UnionUnion
			{
				Type = IGraph3dBase_Union.IGraph3dBase,
				Value = _igraph3dbase
			};
		}

		// Token: 0x06022B74 RID: 142196 RVA: 0x004CF93D File Offset: 0x004CDB3D
		public IGraph3dNormalT AsIGraph3dNormal()
		{
			return this.As<IGraph3dNormalT>();
		}

		// Token: 0x06022B75 RID: 142197 RVA: 0x004CF945 File Offset: 0x004CDB45
		public static IGraph3dBase_UnionUnion FromIGraph3dNormal(IGraph3dNormalT _igraph3dnormal)
		{
			return new IGraph3dBase_UnionUnion
			{
				Type = IGraph3dBase_Union.IGraph3dNormal,
				Value = _igraph3dnormal
			};
		}

		// Token: 0x06022B76 RID: 142198 RVA: 0x004CF95C File Offset: 0x004CDB5C
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
