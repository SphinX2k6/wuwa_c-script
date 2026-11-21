using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200649E RID: 25758
	public class IUnlockAtlasSystemTypeV2_UnionUnion
	{
		// Token: 0x1700BE0D RID: 48653
		// (get) Token: 0x0602BC89 RID: 179337 RVA: 0x005F4C0D File Offset: 0x005F2E0D
		// (set) Token: 0x0602BC8A RID: 179338 RVA: 0x005F4C15 File Offset: 0x005F2E15
		public IUnlockAtlasSystemTypeV2_Union Type { get; set; }

		// Token: 0x1700BE0E RID: 48654
		// (get) Token: 0x0602BC8B RID: 179339 RVA: 0x005F4C1E File Offset: 0x005F2E1E
		// (set) Token: 0x0602BC8C RID: 179340 RVA: 0x005F4C26 File Offset: 0x005F2E26
		public object Value { get; set; }

		// Token: 0x0602BC8D RID: 179341 RVA: 0x005F4C2F File Offset: 0x005F2E2F
		public IUnlockAtlasSystemTypeV2_UnionUnion()
		{
			this.Type = IUnlockAtlasSystemTypeV2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BC8E RID: 179342 RVA: 0x005F4C45 File Offset: 0x005F2E45
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BC8F RID: 179343 RVA: 0x005F4C57 File Offset: 0x005F2E57
		public IUnlockAtlasSystemTypeV2T AsIUnlockAtlasSystemTypeV2()
		{
			return this.As<IUnlockAtlasSystemTypeV2T>();
		}

		// Token: 0x0602BC90 RID: 179344 RVA: 0x005F4C5F File Offset: 0x005F2E5F
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockAtlasSystemTypeV2(IUnlockAtlasSystemTypeV2T _iunlockatlassystemtypev2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockAtlasSystemTypeV2,
				Value = _iunlockatlassystemtypev2
			};
		}

		// Token: 0x0602BC91 RID: 179345 RVA: 0x005F4C74 File Offset: 0x005F2E74
		public IUnlockGeographicalAtlasV2T AsIUnlockGeographicalAtlasV2()
		{
			return this.As<IUnlockGeographicalAtlasV2T>();
		}

		// Token: 0x0602BC92 RID: 179346 RVA: 0x005F4C7C File Offset: 0x005F2E7C
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockGeographicalAtlasV2(IUnlockGeographicalAtlasV2T _iunlockgeographicalatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockGeographicalAtlasV2,
				Value = _iunlockgeographicalatlasv2
			};
		}

		// Token: 0x0602BC93 RID: 179347 RVA: 0x005F4C91 File Offset: 0x005F2E91
		public IUnlockPlotPhotoAtlasV2T AsIUnlockPlotPhotoAtlasV2()
		{
			return this.As<IUnlockPlotPhotoAtlasV2T>();
		}

		// Token: 0x0602BC94 RID: 179348 RVA: 0x005F4C99 File Offset: 0x005F2E99
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockPlotPhotoAtlasV2(IUnlockPlotPhotoAtlasV2T _iunlockplotphotoatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockPlotPhotoAtlasV2,
				Value = _iunlockplotphotoatlasv2
			};
		}

		// Token: 0x0602BC95 RID: 179349 RVA: 0x005F4CAE File Offset: 0x005F2EAE
		public IUnlockNounAtlasV2T AsIUnlockNounAtlasV2()
		{
			return this.As<IUnlockNounAtlasV2T>();
		}

		// Token: 0x0602BC96 RID: 179350 RVA: 0x005F4CB6 File Offset: 0x005F2EB6
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockNounAtlasV2(IUnlockNounAtlasV2T _iunlocknounatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockNounAtlasV2,
				Value = _iunlocknounatlasv2
			};
		}

		// Token: 0x0602BC97 RID: 179351 RVA: 0x005F4CCB File Offset: 0x005F2ECB
		public IUnlockPanoramaAtlasV2T AsIUnlockPanoramaAtlasV2()
		{
			return this.As<IUnlockPanoramaAtlasV2T>();
		}

		// Token: 0x0602BC98 RID: 179352 RVA: 0x005F4CD3 File Offset: 0x005F2ED3
		public static IUnlockAtlasSystemTypeV2_UnionUnion FromIUnlockPanoramaAtlasV2(IUnlockPanoramaAtlasV2T _iunlockpanoramaatlasv2)
		{
			return new IUnlockAtlasSystemTypeV2_UnionUnion
			{
				Type = IUnlockAtlasSystemTypeV2_Union.IUnlockPanoramaAtlasV2,
				Value = _iunlockpanoramaatlasv2
			};
		}

		// Token: 0x0602BC99 RID: 179353 RVA: 0x005F4CE8 File Offset: 0x005F2EE8
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
