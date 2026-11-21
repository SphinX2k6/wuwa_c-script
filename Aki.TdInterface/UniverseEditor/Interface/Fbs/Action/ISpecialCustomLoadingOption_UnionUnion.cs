using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007945 RID: 31045
	public class ISpecialCustomLoadingOption_UnionUnion
	{
		// Token: 0x1700E3BC RID: 58300
		// (get) Token: 0x06036AD3 RID: 223955 RVA: 0x00750FF9 File Offset: 0x0074F1F9
		// (set) Token: 0x06036AD4 RID: 223956 RVA: 0x00751001 File Offset: 0x0074F201
		public ISpecialCustomLoadingOption_Union Type { get; set; }

		// Token: 0x1700E3BD RID: 58301
		// (get) Token: 0x06036AD5 RID: 223957 RVA: 0x0075100A File Offset: 0x0074F20A
		// (set) Token: 0x06036AD6 RID: 223958 RVA: 0x00751012 File Offset: 0x0074F212
		public object Value { get; set; }

		// Token: 0x06036AD7 RID: 223959 RVA: 0x0075101B File Offset: 0x0074F21B
		public ISpecialCustomLoadingOption_UnionUnion()
		{
			this.Type = ISpecialCustomLoadingOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036AD8 RID: 223960 RVA: 0x00751031 File Offset: 0x0074F231
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036AD9 RID: 223961 RVA: 0x00751043 File Offset: 0x0074F243
		public ISpecialCustomLoadingOptionT AsISpecialCustomLoadingOption()
		{
			return this.As<ISpecialCustomLoadingOptionT>();
		}

		// Token: 0x06036ADA RID: 223962 RVA: 0x0075104B File Offset: 0x0074F24B
		public static ISpecialCustomLoadingOption_UnionUnion FromISpecialCustomLoadingOption(ISpecialCustomLoadingOptionT _ispecialcustomloadingoption)
		{
			return new ISpecialCustomLoadingOption_UnionUnion
			{
				Type = ISpecialCustomLoadingOption_Union.ISpecialCustomLoadingOption,
				Value = _ispecialcustomloadingoption
			};
		}

		// Token: 0x06036ADB RID: 223963 RVA: 0x00751060 File Offset: 0x0074F260
		public IHonamiStoryCustomLoadingT AsIHonamiStoryCustomLoading()
		{
			return this.As<IHonamiStoryCustomLoadingT>();
		}

		// Token: 0x06036ADC RID: 223964 RVA: 0x00751068 File Offset: 0x0074F268
		public static ISpecialCustomLoadingOption_UnionUnion FromIHonamiStoryCustomLoading(IHonamiStoryCustomLoadingT _ihonamistorycustomloading)
		{
			return new ISpecialCustomLoadingOption_UnionUnion
			{
				Type = ISpecialCustomLoadingOption_Union.IHonamiStoryCustomLoading,
				Value = _ihonamistorycustomloading
			};
		}

		// Token: 0x06036ADD RID: 223965 RVA: 0x00751080 File Offset: 0x0074F280
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
