using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E97 RID: 24215
	public class TUnlockAtlasSystemOptionV2Union
	{
		// Token: 0x1700B4E1 RID: 46305
		// (get) Token: 0x0602976A RID: 169834 RVA: 0x005AE5DA File Offset: 0x005AC7DA
		// (set) Token: 0x0602976B RID: 169835 RVA: 0x005AE5E2 File Offset: 0x005AC7E2
		public TUnlockAtlasSystemOptionV2 Type { get; set; }

		// Token: 0x1700B4E2 RID: 46306
		// (get) Token: 0x0602976C RID: 169836 RVA: 0x005AE5EB File Offset: 0x005AC7EB
		// (set) Token: 0x0602976D RID: 169837 RVA: 0x005AE5F3 File Offset: 0x005AC7F3
		public object Value { get; set; }

		// Token: 0x0602976E RID: 169838 RVA: 0x005AE5FC File Offset: 0x005AC7FC
		public TUnlockAtlasSystemOptionV2Union()
		{
			this.Type = TUnlockAtlasSystemOptionV2.NONE;
			this.Value = null;
		}

		// Token: 0x0602976F RID: 169839 RVA: 0x005AE612 File Offset: 0x005AC812
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029770 RID: 169840 RVA: 0x005AE624 File Offset: 0x005AC824
		public IUnlockGeographicalAtlasV2T AsIUnlockGeographicalAtlasV2()
		{
			return this.As<IUnlockGeographicalAtlasV2T>();
		}

		// Token: 0x06029771 RID: 169841 RVA: 0x005AE62C File Offset: 0x005AC82C
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockGeographicalAtlasV2(IUnlockGeographicalAtlasV2T _iunlockgeographicalatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockGeographicalAtlasV2,
				Value = _iunlockgeographicalatlasv2
			};
		}

		// Token: 0x06029772 RID: 169842 RVA: 0x005AE641 File Offset: 0x005AC841
		public IUnlockNounAtlasV2T AsIUnlockNounAtlasV2()
		{
			return this.As<IUnlockNounAtlasV2T>();
		}

		// Token: 0x06029773 RID: 169843 RVA: 0x005AE649 File Offset: 0x005AC849
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockNounAtlasV2(IUnlockNounAtlasV2T _iunlocknounatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockNounAtlasV2,
				Value = _iunlocknounatlasv2
			};
		}

		// Token: 0x06029774 RID: 169844 RVA: 0x005AE65E File Offset: 0x005AC85E
		public IUnlockPanoramaAtlasV2T AsIUnlockPanoramaAtlasV2()
		{
			return this.As<IUnlockPanoramaAtlasV2T>();
		}

		// Token: 0x06029775 RID: 169845 RVA: 0x005AE666 File Offset: 0x005AC866
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockPanoramaAtlasV2(IUnlockPanoramaAtlasV2T _iunlockpanoramaatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockPanoramaAtlasV2,
				Value = _iunlockpanoramaatlasv2
			};
		}

		// Token: 0x06029776 RID: 169846 RVA: 0x005AE67B File Offset: 0x005AC87B
		public IUnlockPlotPhotoAtlasV2T AsIUnlockPlotPhotoAtlasV2()
		{
			return this.As<IUnlockPlotPhotoAtlasV2T>();
		}

		// Token: 0x06029777 RID: 169847 RVA: 0x005AE683 File Offset: 0x005AC883
		public static TUnlockAtlasSystemOptionV2Union FromIUnlockPlotPhotoAtlasV2(IUnlockPlotPhotoAtlasV2T _iunlockplotphotoatlasv2)
		{
			return new TUnlockAtlasSystemOptionV2Union
			{
				Type = TUnlockAtlasSystemOptionV2.IUnlockPlotPhotoAtlasV2,
				Value = _iunlockplotphotoatlasv2
			};
		}

		// Token: 0x06029778 RID: 169848 RVA: 0x005AE698 File Offset: 0x005AC898
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
