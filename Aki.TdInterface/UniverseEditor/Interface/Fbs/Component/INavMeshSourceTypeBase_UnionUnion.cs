using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8C RID: 23436
	public class INavMeshSourceTypeBase_UnionUnion
	{
		// Token: 0x1700AB4D RID: 43853
		// (get) Token: 0x060269F2 RID: 158194 RVA: 0x00549DB1 File Offset: 0x00547FB1
		// (set) Token: 0x060269F3 RID: 158195 RVA: 0x00549DB9 File Offset: 0x00547FB9
		public INavMeshSourceTypeBase_Union Type { get; set; }

		// Token: 0x1700AB4E RID: 43854
		// (get) Token: 0x060269F4 RID: 158196 RVA: 0x00549DC2 File Offset: 0x00547FC2
		// (set) Token: 0x060269F5 RID: 158197 RVA: 0x00549DCA File Offset: 0x00547FCA
		public object Value { get; set; }

		// Token: 0x060269F6 RID: 158198 RVA: 0x00549DD3 File Offset: 0x00547FD3
		public INavMeshSourceTypeBase_UnionUnion()
		{
			this.Type = INavMeshSourceTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060269F7 RID: 158199 RVA: 0x00549DE9 File Offset: 0x00547FE9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060269F8 RID: 158200 RVA: 0x00549DFB File Offset: 0x00547FFB
		public INavMeshSourceTypeBaseT AsINavMeshSourceTypeBase()
		{
			return this.As<INavMeshSourceTypeBaseT>();
		}

		// Token: 0x060269F9 RID: 158201 RVA: 0x00549E03 File Offset: 0x00548003
		public static INavMeshSourceTypeBase_UnionUnion FromINavMeshSourceTypeBase(INavMeshSourceTypeBaseT _inavmeshsourcetypebase)
		{
			return new INavMeshSourceTypeBase_UnionUnion
			{
				Type = INavMeshSourceTypeBase_Union.INavMeshSourceTypeBase,
				Value = _inavmeshsourcetypebase
			};
		}

		// Token: 0x060269FA RID: 158202 RVA: 0x00549E18 File Offset: 0x00548018
		public INavMeshAkiEntitySourceT AsINavMeshAkiEntitySource()
		{
			return this.As<INavMeshAkiEntitySourceT>();
		}

		// Token: 0x060269FB RID: 158203 RVA: 0x00549E20 File Offset: 0x00548020
		public static INavMeshSourceTypeBase_UnionUnion FromINavMeshAkiEntitySource(INavMeshAkiEntitySourceT _inavmeshakientitysource)
		{
			return new INavMeshSourceTypeBase_UnionUnion
			{
				Type = INavMeshSourceTypeBase_Union.INavMeshAkiEntitySource,
				Value = _inavmeshakientitysource
			};
		}

		// Token: 0x060269FC RID: 158204 RVA: 0x00549E38 File Offset: 0x00548038
		public static int Pack(FlatBufferBuilder builder, INavMeshSourceTypeBase_UnionUnion _o)
		{
			INavMeshSourceTypeBase_Union type = _o.Type;
			if (type == INavMeshSourceTypeBase_Union.INavMeshSourceTypeBase)
			{
				return INavMeshSourceTypeBase.Pack(builder, _o.AsINavMeshSourceTypeBase()).Value;
			}
			if (type != INavMeshSourceTypeBase_Union.INavMeshAkiEntitySource)
			{
				return 0;
			}
			return INavMeshAkiEntitySource.Pack(builder, _o.AsINavMeshAkiEntitySource()).Value;
		}
	}
}
