using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E5E RID: 24158
	public class IUnlockAtlasSystemTypeV2_UnionUnion
	{
		// Token: 0x1700B4A4 RID: 46244
		// (get) Token: 0x060295ED RID: 169453 RVA: 0x005ABD65 File Offset: 0x005A9F65
		// (set) Token: 0x060295EE RID: 169454 RVA: 0x005ABD6D File Offset: 0x005A9F6D
		public IUnlockAtlasSystemTypeV2_Union Type { get; set; }

		// Token: 0x1700B4A5 RID: 46245
		// (get) Token: 0x060295EF RID: 169455 RVA: 0x005ABD76 File Offset: 0x005A9F76
		// (set) Token: 0x060295F0 RID: 169456 RVA: 0x005ABD7E File Offset: 0x005A9F7E
		public object Value { get; set; }

		// Token: 0x060295F1 RID: 169457 RVA: 0x005ABD87 File Offset: 0x005A9F87
		public IUnlockAtlasSystemTypeV2_UnionUnion()
		{
			this.Type = IUnlockAtlasSystemTypeV2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060295F2 RID: 169458 RVA: 0x005ABD9D File Offset: 0x005A9F9D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060295F3 RID: 169459 RVA: 0x005ABDAF File Offset: 0x005A9FAF
		public IUnlockAtlasSystemTypeV2T AsIUnlockAtlasSystemTypeV2()
		{
			return this.As<IUnlockAtlasSystemTypeV2T>();
		}

		// Token: 0x060295F4 RID: 169460 RVA: 0x005ABDB7 File Offset: 0x005A9FB7
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockAtlasSystemTypeV2(IUnlockAtlasSystemTypeV2T _iunlockatlassystemtypev2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockAtlasSystemTypeV2,
				Value = _iunlockatlassystemtypev2
			};
		}

		// Token: 0x060295F5 RID: 169461 RVA: 0x005ABDCC File Offset: 0x005A9FCC
		public IUnlockGeographicalAtlasV2T AsIUnlockGeographicalAtlasV2()
		{
			return this.As<IUnlockGeographicalAtlasV2T>();
		}

		// Token: 0x060295F6 RID: 169462 RVA: 0x005ABDD4 File Offset: 0x005A9FD4
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockGeographicalAtlasV2(IUnlockGeographicalAtlasV2T _iunlockgeographicalatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockGeographicalAtlasV2,
				Value = _iunlockgeographicalatlasv2
			};
		}

		// Token: 0x060295F7 RID: 169463 RVA: 0x005ABDE9 File Offset: 0x005A9FE9
		public IUnlockPlotPhotoAtlasV2T AsIUnlockPlotPhotoAtlasV2()
		{
			return this.As<IUnlockPlotPhotoAtlasV2T>();
		}

		// Token: 0x060295F8 RID: 169464 RVA: 0x005ABDF1 File Offset: 0x005A9FF1
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockPlotPhotoAtlasV2(IUnlockPlotPhotoAtlasV2T _iunlockplotphotoatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockPlotPhotoAtlasV2,
				Value = _iunlockplotphotoatlasv2
			};
		}

		// Token: 0x060295F9 RID: 169465 RVA: 0x005ABE06 File Offset: 0x005AA006
		public IUnlockNounAtlasV2T AsIUnlockNounAtlasV2()
		{
			return this.As<IUnlockNounAtlasV2T>();
		}

		// Token: 0x060295FA RID: 169466 RVA: 0x005ABE0E File Offset: 0x005AA00E
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockNounAtlasV2(IUnlockNounAtlasV2T _iunlocknounatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockNounAtlasV2,
				Value = _iunlocknounatlasv2
			};
		}

		// Token: 0x060295FB RID: 169467 RVA: 0x005ABE23 File Offset: 0x005AA023
		public IUnlockPanoramaAtlasV2T AsIUnlockPanoramaAtlasV2()
		{
			return this.As<IUnlockPanoramaAtlasV2T>();
		}

		// Token: 0x060295FC RID: 169468 RVA: 0x005ABE2B File Offset: 0x005AA02B
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockPanoramaAtlasV2(IUnlockPanoramaAtlasV2T _iunlockpanoramaatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockPanoramaAtlasV2,
				Value = _iunlockpanoramaatlasv2
			};
		}

		// Token: 0x060295FD RID: 169469 RVA: 0x005ABE40 File Offset: 0x005AA040
		public static int Pack(FlatBufferBuilder builder, IUnlockAtlasSystemTypeV2_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUnlockAtlasSystemTypeV2_Union.IUnlockAtlasSystemTypeV2:
				return IUnlockAtlasSystemTypeV2.Pack(builder, _o.AsIUnlockAtlasSystemTypeV2()).Value;
			case IUnlockAtlasSystemTypeV2_Union.IUnlockGeographicalAtlasV2:
				return IUnlockGeographicalAtlasV2.Pack(builder, _o.AsIUnlockGeographicalAtlasV2()).Value;
			case IUnlockAtlasSystemTypeV2_Union.IUnlockPlotPhotoAtlasV2:
				return IUnlockPlotPhotoAtlasV2.Pack(builder, _o.AsIUnlockPlotPhotoAtlasV2()).Value;
			case IUnlockAtlasSystemTypeV2_Union.IUnlockNounAtlasV2:
				return IUnlockNounAtlasV2.Pack(builder, _o.AsIUnlockNounAtlasV2()).Value;
			case IUnlockAtlasSystemTypeV2_Union.IUnlockPanoramaAtlasV2:
				return IUnlockPanoramaAtlasV2.Pack(builder, _o.AsIUnlockPanoramaAtlasV2()).Value;
			default:
				return 0;
			}
		}
	}
}
