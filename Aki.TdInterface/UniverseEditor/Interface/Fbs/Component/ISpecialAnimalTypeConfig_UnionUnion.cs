using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596F RID: 22895
	public class ISpecialAnimalTypeConfig_UnionUnion
	{
		// Token: 0x1700ABD2 RID: 43986
		// (get) Token: 0x06026C15 RID: 158741 RVA: 0x00555EC5 File Offset: 0x005540C5
		// (set) Token: 0x06026C16 RID: 158742 RVA: 0x00555ECD File Offset: 0x005540CD
		public ISpecialAnimalTypeConfig_Union Type { get; set; }

		// Token: 0x1700ABD3 RID: 43987
		// (get) Token: 0x06026C17 RID: 158743 RVA: 0x00555ED6 File Offset: 0x005540D6
		// (set) Token: 0x06026C18 RID: 158744 RVA: 0x00555EDE File Offset: 0x005540DE
		public object Value { get; set; }

		// Token: 0x06026C19 RID: 158745 RVA: 0x00555EE7 File Offset: 0x005540E7
		public ISpecialAnimalTypeConfig_UnionUnion()
		{
			this.Type = ISpecialAnimalTypeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026C1A RID: 158746 RVA: 0x00555EFD File Offset: 0x005540FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026C1B RID: 158747 RVA: 0x00555F0F File Offset: 0x0055410F
		public ISpecialAnimalTypeConfigT AsISpecialAnimalTypeConfig()
		{
			return this.As<ISpecialAnimalTypeConfigT>();
		}

		// Token: 0x06026C1C RID: 158748 RVA: 0x00555F17 File Offset: 0x00554117
		public static ISpecialAnimalTypeConfig_UnionUnion FromISpecialAnimalTypeConfig(ISpecialAnimalTypeConfigT _ispecialanimaltypeconfig)
		{
			return new ISpecialAnimalTypeConfig_UnionUnion
			{
				Type = ISpecialAnimalTypeConfig_Union.ISpecialAnimalTypeConfig,
				Value = _ispecialanimaltypeconfig
			};
		}

		// Token: 0x06026C1D RID: 158749 RVA: 0x00555F2C File Offset: 0x0055412C
		public ICollectAnimalConfigT AsICollectAnimalConfig()
		{
			return this.As<ICollectAnimalConfigT>();
		}

		// Token: 0x06026C1E RID: 158750 RVA: 0x00555F34 File Offset: 0x00554134
		public static ISpecialAnimalTypeConfig_UnionUnion FromICollectAnimalConfig(ICollectAnimalConfigT _icollectanimalconfig)
		{
			return new ISpecialAnimalTypeConfig_UnionUnion
			{
				Type = ISpecialAnimalTypeConfig_Union.ICollectAnimalConfig,
				Value = _icollectanimalconfig
			};
		}

		// Token: 0x06026C1F RID: 158751 RVA: 0x00555F4C File Offset: 0x0055414C
		public static int Pack(FlatBufferBuilder builder, ISpecialAnimalTypeConfig_UnionUnion _o)
		{
			ISpecialAnimalTypeConfig_Union type = _o.Type;
			if (type == ISpecialAnimalTypeConfig_Union.ISpecialAnimalTypeConfig)
			{
				return ISpecialAnimalTypeConfig.Pack(builder, _o.AsISpecialAnimalTypeConfig()).Value;
			}
			if (type != ISpecialAnimalTypeConfig_Union.ICollectAnimalConfig)
			{
				return 0;
			}
			return ICollectAnimalConfig.Pack(builder, _o.AsICollectAnimalConfig()).Value;
		}
	}
}
