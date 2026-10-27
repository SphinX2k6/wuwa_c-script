using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1F RID: 27679
	public class IOpenQteConfig_UnionUnion
	{
		// Token: 0x1700CDD8 RID: 52696
		// (get) Token: 0x06030ACF RID: 199375 RVA: 0x0069B9C5 File Offset: 0x00699BC5
		// (set) Token: 0x06030AD0 RID: 199376 RVA: 0x0069B9CD File Offset: 0x00699BCD
		public IOpenQteConfig_Union Type { get; set; }

		// Token: 0x1700CDD9 RID: 52697
		// (get) Token: 0x06030AD1 RID: 199377 RVA: 0x0069B9D6 File Offset: 0x00699BD6
		// (set) Token: 0x06030AD2 RID: 199378 RVA: 0x0069B9DE File Offset: 0x00699BDE
		public object Value { get; set; }

		// Token: 0x06030AD3 RID: 199379 RVA: 0x0069B9E7 File Offset: 0x00699BE7
		public IOpenQteConfig_UnionUnion()
		{
			this.Type = IOpenQteConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030AD4 RID: 199380 RVA: 0x0069B9FD File Offset: 0x00699BFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030AD5 RID: 199381 RVA: 0x0069BA0F File Offset: 0x00699C0F
		public IOpenQteConfigT AsIOpenQteConfig()
		{
			return this.As<IOpenQteConfigT>();
		}

		// Token: 0x06030AD6 RID: 199382 RVA: 0x0069BA17 File Offset: 0x00699C17
		public static IOpenQteConfig_UnionUnion FromIOpenQteConfig(IOpenQteConfigT _iopenqteconfig)
		{
			return new IOpenQteConfig_UnionUnion
			{
				Type = IOpenQteConfig_Union.IOpenQteConfig,
				Value = _iopenqteconfig
			};
		}

		// Token: 0x06030AD7 RID: 199383 RVA: 0x0069BA2C File Offset: 0x00699C2C
		public IOpenPanelQteQteT AsIOpenPanelQteQte()
		{
			return this.As<IOpenPanelQteQteT>();
		}

		// Token: 0x06030AD8 RID: 199384 RVA: 0x0069BA34 File Offset: 0x00699C34
		public static IOpenQteConfig_UnionUnion FromIOpenPanelQteQte(IOpenPanelQteQteT _iopenpanelqteqte)
		{
			return new IOpenQteConfig_UnionUnion
			{
				Type = IOpenQteConfig_Union.IOpenPanelQteQte,
				Value = _iopenpanelqteqte
			};
		}

		// Token: 0x06030AD9 RID: 199385 RVA: 0x0069BA49 File Offset: 0x00699C49
		public IOpenLevelQteT AsIOpenLevelQte()
		{
			return this.As<IOpenLevelQteT>();
		}

		// Token: 0x06030ADA RID: 199386 RVA: 0x0069BA51 File Offset: 0x00699C51
		public static IOpenQteConfig_UnionUnion FromIOpenLevelQte(IOpenLevelQteT _iopenlevelqte)
		{
			return new IOpenQteConfig_UnionUnion
			{
				Type = IOpenQteConfig_Union.IOpenLevelQte,
				Value = _iopenlevelqte
			};
		}

		// Token: 0x06030ADB RID: 199387 RVA: 0x0069BA68 File Offset: 0x00699C68
		public static int Pack(FlatBufferBuilder builder, IOpenQteConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IOpenQteConfig_Union.IOpenQteConfig:
				return IOpenQteConfig.Pack(builder, _o.AsIOpenQteConfig()).Value;
			case IOpenQteConfig_Union.IOpenPanelQteQte:
				return IOpenPanelQteQte.Pack(builder, _o.AsIOpenPanelQteQte()).Value;
			case IOpenQteConfig_Union.IOpenLevelQte:
				return IOpenLevelQte.Pack(builder, _o.AsIOpenLevelQte()).Value;
			default:
				return 0;
			}
		}
	}
}
