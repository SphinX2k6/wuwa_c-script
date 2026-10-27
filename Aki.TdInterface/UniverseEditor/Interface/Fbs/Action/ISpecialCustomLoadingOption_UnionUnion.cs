using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007176 RID: 29046
	public class ISpecialCustomLoadingOption_UnionUnion
	{
		// Token: 0x1700D7CA RID: 55242
		// (get) Token: 0x060337F9 RID: 210937 RVA: 0x006F0069 File Offset: 0x006EE269
		// (set) Token: 0x060337FA RID: 210938 RVA: 0x006F0071 File Offset: 0x006EE271
		public ISpecialCustomLoadingOption_Union Type { get; set; }

		// Token: 0x1700D7CB RID: 55243
		// (get) Token: 0x060337FB RID: 210939 RVA: 0x006F007A File Offset: 0x006EE27A
		// (set) Token: 0x060337FC RID: 210940 RVA: 0x006F0082 File Offset: 0x006EE282
		public object Value { get; set; }

		// Token: 0x060337FD RID: 210941 RVA: 0x006F008B File Offset: 0x006EE28B
		public ISpecialCustomLoadingOption_UnionUnion()
		{
			this.Type = ISpecialCustomLoadingOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060337FE RID: 210942 RVA: 0x006F00A1 File Offset: 0x006EE2A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060337FF RID: 210943 RVA: 0x006F00B3 File Offset: 0x006EE2B3
		public ISpecialCustomLoadingOptionT AsISpecialCustomLoadingOption()
		{
			return this.As<ISpecialCustomLoadingOptionT>();
		}

		// Token: 0x06033800 RID: 210944 RVA: 0x006F00BB File Offset: 0x006EE2BB
		public static ISpecialCustomLoadingOption_UnionUnion FromISpecialCustomLoadingOption(ISpecialCustomLoadingOptionT _ispecialcustomloadingoption)
		{
			return new ISpecialCustomLoadingOption_UnionUnion
			{
				Type = ISpecialCustomLoadingOption_Union.ISpecialCustomLoadingOption,
				Value = _ispecialcustomloadingoption
			};
		}

		// Token: 0x06033801 RID: 210945 RVA: 0x006F00D0 File Offset: 0x006EE2D0
		public IHonamiStoryCustomLoadingT AsIHonamiStoryCustomLoading()
		{
			return this.As<IHonamiStoryCustomLoadingT>();
		}

		// Token: 0x06033802 RID: 210946 RVA: 0x006F00D8 File Offset: 0x006EE2D8
		public static ISpecialCustomLoadingOption_UnionUnion FromIHonamiStoryCustomLoading(IHonamiStoryCustomLoadingT _ihonamistorycustomloading)
		{
			return new ISpecialCustomLoadingOption_UnionUnion
			{
				Type = ISpecialCustomLoadingOption_Union.IHonamiStoryCustomLoading,
				Value = _ihonamistorycustomloading
			};
		}

		// Token: 0x06033803 RID: 210947 RVA: 0x006F00F0 File Offset: 0x006EE2F0
		public static int Pack(FlatBufferBuilder builder, ISpecialCustomLoadingOption_UnionUnion _o)
		{
			ISpecialCustomLoadingOption_Union type = _o.Type;
			if (type == ISpecialCustomLoadingOption_Union.ISpecialCustomLoadingOption)
			{
				return ISpecialCustomLoadingOption.Pack(builder, _o.AsISpecialCustomLoadingOption()).Value;
			}
			if (type != ISpecialCustomLoadingOption_Union.IHonamiStoryCustomLoading)
			{
				return 0;
			}
			return IHonamiStoryCustomLoading.Pack(builder, _o.AsIHonamiStoryCustomLoading()).Value;
		}
	}
}
