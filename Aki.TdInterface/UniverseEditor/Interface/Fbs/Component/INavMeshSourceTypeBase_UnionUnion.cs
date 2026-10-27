using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EE RID: 21998
	public class INavMeshSourceTypeBase_UnionUnion
	{
		// Token: 0x1700A2C5 RID: 41669
		// (get) Token: 0x060247E5 RID: 149477 RVA: 0x00509839 File Offset: 0x00507A39
		// (set) Token: 0x060247E6 RID: 149478 RVA: 0x00509841 File Offset: 0x00507A41
		public INavMeshSourceTypeBase_Union Type { get; set; }

		// Token: 0x1700A2C6 RID: 41670
		// (get) Token: 0x060247E7 RID: 149479 RVA: 0x0050984A File Offset: 0x00507A4A
		// (set) Token: 0x060247E8 RID: 149480 RVA: 0x00509852 File Offset: 0x00507A52
		public object Value { get; set; }

		// Token: 0x060247E9 RID: 149481 RVA: 0x0050985B File Offset: 0x00507A5B
		public INavMeshSourceTypeBase_UnionUnion()
		{
			this.Type = INavMeshSourceTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060247EA RID: 149482 RVA: 0x00509871 File Offset: 0x00507A71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060247EB RID: 149483 RVA: 0x00509883 File Offset: 0x00507A83
		public INavMeshSourceTypeBaseT AsINavMeshSourceTypeBase()
		{
			return this.As<INavMeshSourceTypeBaseT>();
		}

		// Token: 0x060247EC RID: 149484 RVA: 0x0050988B File Offset: 0x00507A8B
		public static INavMeshSourceTypeBase_UnionUnion FromINavMeshSourceTypeBase(INavMeshSourceTypeBaseT _inavmeshsourcetypebase)
		{
			return new INavMeshSourceTypeBase_UnionUnion
			{
				Type = INavMeshSourceTypeBase_Union.INavMeshSourceTypeBase,
				Value = _inavmeshsourcetypebase
			};
		}

		// Token: 0x060247ED RID: 149485 RVA: 0x005098A0 File Offset: 0x00507AA0
		public INavMeshAkiEntitySourceT AsINavMeshAkiEntitySource()
		{
			return this.As<INavMeshAkiEntitySourceT>();
		}

		// Token: 0x060247EE RID: 149486 RVA: 0x005098A8 File Offset: 0x00507AA8
		public static INavMeshSourceTypeBase_UnionUnion FromINavMeshAkiEntitySource(INavMeshAkiEntitySourceT _inavmeshakientitysource)
		{
			return new INavMeshSourceTypeBase_UnionUnion
			{
				Type = INavMeshSourceTypeBase_Union.INavMeshAkiEntitySource,
				Value = _inavmeshakientitysource
			};
		}

		// Token: 0x060247EF RID: 149487 RVA: 0x005098C0 File Offset: 0x00507AC0
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
