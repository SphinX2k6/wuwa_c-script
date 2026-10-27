using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006589 RID: 25993
	public class IDestroyDynamicEntitiesType_UnionUnion
	{
		// Token: 0x1700C10D RID: 49421
		// (get) Token: 0x0602D15B RID: 184667 RVA: 0x0062F549 File Offset: 0x0062D749
		// (set) Token: 0x0602D15C RID: 184668 RVA: 0x0062F551 File Offset: 0x0062D751
		public IDestroyDynamicEntitiesType_Union Type { get; set; }

		// Token: 0x1700C10E RID: 49422
		// (get) Token: 0x0602D15D RID: 184669 RVA: 0x0062F55A File Offset: 0x0062D75A
		// (set) Token: 0x0602D15E RID: 184670 RVA: 0x0062F562 File Offset: 0x0062D762
		public object Value { get; set; }

		// Token: 0x0602D15F RID: 184671 RVA: 0x0062F56B File Offset: 0x0062D76B
		public IDestroyDynamicEntitiesType_UnionUnion()
		{
			this.Type = IDestroyDynamicEntitiesType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D160 RID: 184672 RVA: 0x0062F581 File Offset: 0x0062D781
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D161 RID: 184673 RVA: 0x0062F593 File Offset: 0x0062D793
		public IDestroyDynamicEntitiesTypeT AsIDestroyDynamicEntitiesType()
		{
			return this.As<IDestroyDynamicEntitiesTypeT>();
		}

		// Token: 0x0602D162 RID: 184674 RVA: 0x0062F59B File Offset: 0x0062D79B
		public static IDestroyDynamicEntitiesType_UnionUnion FromIDestroyDynamicEntitiesType(IDestroyDynamicEntitiesTypeT _idestroydynamicentitiestype)
		{
			return new IDestroyDynamicEntitiesType_UnionUnion
			{
				Type = IDestroyDynamicEntitiesType_Union.IDestroyDynamicEntitiesType,
				Value = _idestroydynamicentitiestype
			};
		}

		// Token: 0x0602D163 RID: 184675 RVA: 0x0062F5B0 File Offset: 0x0062D7B0
		public IDestroyVisionDisplayT AsIDestroyVisionDisplay()
		{
			return this.As<IDestroyVisionDisplayT>();
		}

		// Token: 0x0602D164 RID: 184676 RVA: 0x0062F5B8 File Offset: 0x0062D7B8
		public static IDestroyDynamicEntitiesType_UnionUnion FromIDestroyVisionDisplay(IDestroyVisionDisplayT _idestroyvisiondisplay)
		{
			return new IDestroyDynamicEntitiesType_UnionUnion
			{
				Type = IDestroyDynamicEntitiesType_Union.IDestroyVisionDisplay,
				Value = _idestroyvisiondisplay
			};
		}

		// Token: 0x0602D165 RID: 184677 RVA: 0x0062F5D0 File Offset: 0x0062D7D0
		public static int Pack(FlatBufferBuilder builder, IDestroyDynamicEntitiesType_UnionUnion _o)
		{
			IDestroyDynamicEntitiesType_Union type = _o.Type;
			if (type == IDestroyDynamicEntitiesType_Union.IDestroyDynamicEntitiesType)
			{
				return IDestroyDynamicEntitiesType.Pack(builder, _o.AsIDestroyDynamicEntitiesType()).Value;
			}
			if (type != IDestroyDynamicEntitiesType_Union.IDestroyVisionDisplay)
			{
				return 0;
			}
			return IDestroyVisionDisplay.Pack(builder, _o.AsIDestroyVisionDisplay()).Value;
		}
	}
}
