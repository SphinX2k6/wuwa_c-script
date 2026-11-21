using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064DA RID: 25818
	public class TUnlockAtlasSystemOptionV2Union
	{
		// Token: 0x1700BE4C RID: 48716
		// (get) Token: 0x0602BE12 RID: 179730 RVA: 0x005F757E File Offset: 0x005F577E
		// (set) Token: 0x0602BE13 RID: 179731 RVA: 0x005F7586 File Offset: 0x005F5786
		public TUnlockAtlasSystemOptionV2 Type { get; set; }

		// Token: 0x1700BE4D RID: 48717
		// (get) Token: 0x0602BE14 RID: 179732 RVA: 0x005F758F File Offset: 0x005F578F
		// (set) Token: 0x0602BE15 RID: 179733 RVA: 0x005F7597 File Offset: 0x005F5797
		public object Value { get; set; }

		// Token: 0x0602BE16 RID: 179734 RVA: 0x005F75A0 File Offset: 0x005F57A0
		public TUnlockAtlasSystemOptionV2Union()
		{
			this.Type = TUnlockAtlasSystemOptionV2.NONE;
			this.Value = null;
		}

		// Token: 0x0602BE17 RID: 179735 RVA: 0x005F75B6 File Offset: 0x005F57B6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BE18 RID: 179736 RVA: 0x005F75C8 File Offset: 0x005F57C8
		public IUnlockGeographicalAtlasV2T AsIUnlockGeographicalAtlasV2()
		{
			return this.As<IUnlockGeographicalAtlasV2T>();
		}

		// Token: 0x0602BE19 RID: 179737 RVA: 0x005F75D0 File Offset: 0x005F57D0
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockGeographicalAtlasV2(IUnlockGeographicalAtlasV2T _iunlockgeographicalatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockGeographicalAtlasV2,
				Value = _iunlockgeographicalatlasv2
			};
		}

		// Token: 0x0602BE1A RID: 179738 RVA: 0x005F75E5 File Offset: 0x005F57E5
		public IUnlockNounAtlasV2T AsIUnlockNounAtlasV2()
		{
			return this.As<IUnlockNounAtlasV2T>();
		}

		// Token: 0x0602BE1B RID: 179739 RVA: 0x005F75ED File Offset: 0x005F57ED
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockNounAtlasV2(IUnlockNounAtlasV2T _iunlocknounatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockNounAtlasV2,
				Value = _iunlocknounatlasv2
			};
		}

		// Token: 0x0602BE1C RID: 179740 RVA: 0x005F7602 File Offset: 0x005F5802
		public IUnlockPanoramaAtlasV2T AsIUnlockPanoramaAtlasV2()
		{
			return this.As<IUnlockPanoramaAtlasV2T>();
		}

		// Token: 0x0602BE1D RID: 179741 RVA: 0x005F760A File Offset: 0x005F580A
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockPanoramaAtlasV2(IUnlockPanoramaAtlasV2T _iunlockpanoramaatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockPanoramaAtlasV2,
				Value = _iunlockpanoramaatlasv2
			};
		}

		// Token: 0x0602BE1E RID: 179742 RVA: 0x005F761F File Offset: 0x005F581F
		public IUnlockPlotPhotoAtlasV2T AsIUnlockPlotPhotoAtlasV2()
		{
			return this.As<IUnlockPlotPhotoAtlasV2T>();
		}

		// Token: 0x0602BE1F RID: 179743 RVA: 0x005F7627 File Offset: 0x005F5827
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockPlotPhotoAtlasV2(IUnlockPlotPhotoAtlasV2T _iunlockplotphotoatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockPlotPhotoAtlasV2,
				Value = _iunlockplotphotoatlasv2
			};
		}

		// Token: 0x0602BE20 RID: 179744 RVA: 0x005F763C File Offset: 0x005F583C
		public static int Pack(FlatBufferBuilder builder, TUnlockAtlasSystemOptionV2Union _o)
		{
			switch (_o.Type)
			{
			case TUnlockAtlasSystemOptionV2.IUnlockGeographicalAtlasV2:
				return IUnlockGeographicalAtlasV2.Pack(builder, _o.AsIUnlockGeographicalAtlasV2()).Value;
			case TUnlockAtlasSystemOptionV2.IUnlockNounAtlasV2:
				return IUnlockNounAtlasV2.Pack(builder, _o.AsIUnlockNounAtlasV2()).Value;
			case TUnlockAtlasSystemOptionV2.IUnlockPanoramaAtlasV2:
				return IUnlockPanoramaAtlasV2.Pack(builder, _o.AsIUnlockPanoramaAtlasV2()).Value;
			case TUnlockAtlasSystemOptionV2.IUnlockPlotPhotoAtlasV2:
				return IUnlockPlotPhotoAtlasV2.Pack(builder, _o.AsIUnlockPlotPhotoAtlasV2()).Value;
			default:
				return 0;
			}
		}
	}
}
