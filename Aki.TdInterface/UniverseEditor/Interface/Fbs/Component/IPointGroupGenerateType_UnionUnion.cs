using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005764 RID: 22372
	public class IPointGroupGenerateType_UnionUnion
	{
		// Token: 0x1700A6DE RID: 42718
		// (get) Token: 0x060257D7 RID: 153559 RVA: 0x0052C17D File Offset: 0x0052A37D
		// (set) Token: 0x060257D8 RID: 153560 RVA: 0x0052C185 File Offset: 0x0052A385
		public IPointGroupGenerateType_Union Type { get; set; }

		// Token: 0x1700A6DF RID: 42719
		// (get) Token: 0x060257D9 RID: 153561 RVA: 0x0052C18E File Offset: 0x0052A38E
		// (set) Token: 0x060257DA RID: 153562 RVA: 0x0052C196 File Offset: 0x0052A396
		public object Value { get; set; }

		// Token: 0x060257DB RID: 153563 RVA: 0x0052C19F File Offset: 0x0052A39F
		public IPointGroupGenerateType_UnionUnion()
		{
			this.Type = IPointGroupGenerateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060257DC RID: 153564 RVA: 0x0052C1B5 File Offset: 0x0052A3B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060257DD RID: 153565 RVA: 0x0052C1C7 File Offset: 0x0052A3C7
		public IPointGroupGenerateTypeT AsIPointGroupGenerateType()
		{
			return this.As<IPointGroupGenerateTypeT>();
		}

		// Token: 0x060257DE RID: 153566 RVA: 0x0052C1CF File Offset: 0x0052A3CF
		public static IPointGroupGenerateType_UnionUnion FromIPointGroupGenerateType(IPointGroupGenerateTypeT _ipointgroupgeneratetype)
		{
			return new IPointGroupGenerateType_UnionUnion
			{
				Type = IPointGroupGenerateType_Union.IPointGroupGenerateType,
				Value = _ipointgroupgeneratetype
			};
		}

		// Token: 0x060257DF RID: 153567 RVA: 0x0052C1E4 File Offset: 0x0052A3E4
		public IPointGroupByLayerT AsIPointGroupByLayer()
		{
			return this.As<IPointGroupByLayerT>();
		}

		// Token: 0x060257E0 RID: 153568 RVA: 0x0052C1EC File Offset: 0x0052A3EC
		public static IPointGroupGenerateType_UnionUnion FromIPointGroupByLayer(IPointGroupByLayerT _ipointgroupbylayer)
		{
			return new IPointGroupGenerateType_UnionUnion
			{
				Type = IPointGroupGenerateType_Union.IPointGroupByLayer,
				Value = _ipointgroupbylayer
			};
		}

		// Token: 0x060257E1 RID: 153569 RVA: 0x0052C204 File Offset: 0x0052A404
		public static int Pack(FlatBufferBuilder builder, IPointGroupGenerateType_UnionUnion _o)
		{
			IPointGroupGenerateType_Union type = _o.Type;
			if (type == IPointGroupGenerateType_Union.IPointGroupGenerateType)
			{
				return IPointGroupGenerateType.Pack(builder, _o.AsIPointGroupGenerateType()).Value;
			}
			if (type != IPointGroupGenerateType_Union.IPointGroupByLayer)
			{
				return 0;
			}
			return IPointGroupByLayer.Pack(builder, _o.AsIPointGroupByLayer()).Value;
		}
	}
}
