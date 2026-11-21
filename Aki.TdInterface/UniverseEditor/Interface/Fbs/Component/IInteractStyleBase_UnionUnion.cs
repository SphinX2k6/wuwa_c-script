using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A00 RID: 23040
	public class IInteractStyleBase_UnionUnion
	{
		// Token: 0x1700A763 RID: 42851
		// (get) Token: 0x060259DF RID: 154079 RVA: 0x005284D9 File Offset: 0x005266D9
		// (set) Token: 0x060259E0 RID: 154080 RVA: 0x005284E1 File Offset: 0x005266E1
		public IInteractStyleBase_Union Type { get; set; }

		// Token: 0x1700A764 RID: 42852
		// (get) Token: 0x060259E1 RID: 154081 RVA: 0x005284EA File Offset: 0x005266EA
		// (set) Token: 0x060259E2 RID: 154082 RVA: 0x005284F2 File Offset: 0x005266F2
		public object Value { get; set; }

		// Token: 0x060259E3 RID: 154083 RVA: 0x005284FB File Offset: 0x005266FB
		public IInteractStyleBase_UnionUnion()
		{
			this.Type = IInteractStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060259E4 RID: 154084 RVA: 0x00528511 File Offset: 0x00526711
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060259E5 RID: 154085 RVA: 0x00528523 File Offset: 0x00526723
		public IInteractStyleBaseT AsIInteractStyleBase()
		{
			return this.As<IInteractStyleBaseT>();
		}

		// Token: 0x060259E6 RID: 154086 RVA: 0x0052852B File Offset: 0x0052672B
		public static IInteractStyleBase_UnionUnion FromIInteractStyleBase(IInteractStyleBaseT _iinteractstylebase)
		{
			return new IInteractStyleBase_UnionUnion
			{
				Type = IInteractStyleBase_Union.IInteractStyleBase,
				Value = _iinteractstylebase
			};
		}

		// Token: 0x060259E7 RID: 154087 RVA: 0x00528540 File Offset: 0x00526740
		public IInteractStylePanoramaT AsIInteractStylePanorama()
		{
			return this.As<IInteractStylePanoramaT>();
		}

		// Token: 0x060259E8 RID: 154088 RVA: 0x00528548 File Offset: 0x00526748
		public static IInteractStyleBase_UnionUnion FromIInteractStylePanorama(IInteractStylePanoramaT _iinteractstylepanorama)
		{
			return new IInteractStyleBase_UnionUnion
			{
				Type = IInteractStyleBase_Union.IInteractStylePanorama,
				Value = _iinteractstylepanorama
			};
		}

		// Token: 0x060259E9 RID: 154089 RVA: 0x0052855D File Offset: 0x0052675D
		public IInteractStyleEntityPartT AsIInteractStyleEntityPart()
		{
			return this.As<IInteractStyleEntityPartT>();
		}

		// Token: 0x060259EA RID: 154090 RVA: 0x00528565 File Offset: 0x00526765
		public static IInteractStyleBase_UnionUnion FromIInteractStyleEntityPart(IInteractStyleEntityPartT _iinteractstyleentitypart)
		{
			return new IInteractStyleBase_UnionUnion
			{
				Type = IInteractStyleBase_Union.IInteractStyleEntityPart,
				Value = _iinteractstyleentitypart
			};
		}

		// Token: 0x060259EB RID: 154091 RVA: 0x0052857C File Offset: 0x0052677C
		public static int Pack(FlatBufferBuilder builder, IInteractStyleBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInteractStyleBase_Union.IInteractStyleBase:
				return IInteractStyleBase.Pack(builder, _o.AsIInteractStyleBase()).Value;
			case IInteractStyleBase_Union.IInteractStylePanorama:
				return IInteractStylePanorama.Pack(builder, _o.AsIInteractStylePanorama()).Value;
			case IInteractStyleBase_Union.IInteractStyleEntityPart:
				return IInteractStyleEntityPart.Pack(builder, _o.AsIInteractStyleEntityPart()).Value;
			default:
				return 0;
			}
		}
	}
}
