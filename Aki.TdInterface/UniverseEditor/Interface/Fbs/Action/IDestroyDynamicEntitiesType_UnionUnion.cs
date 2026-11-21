using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF1 RID: 27633
	public class IDestroyDynamicEntitiesType_UnionUnion
	{
		// Token: 0x1700CA9C RID: 51868
		// (get) Token: 0x0602F8DF RID: 194783 RVA: 0x0067B70D File Offset: 0x0067990D
		// (set) Token: 0x0602F8E0 RID: 194784 RVA: 0x0067B715 File Offset: 0x00679915
		public IDestroyDynamicEntitiesType_Union Type { get; set; }

		// Token: 0x1700CA9D RID: 51869
		// (get) Token: 0x0602F8E1 RID: 194785 RVA: 0x0067B71E File Offset: 0x0067991E
		// (set) Token: 0x0602F8E2 RID: 194786 RVA: 0x0067B726 File Offset: 0x00679926
		public object Value { get; set; }

		// Token: 0x0602F8E3 RID: 194787 RVA: 0x0067B72F File Offset: 0x0067992F
		public IDestroyDynamicEntitiesType_UnionUnion()
		{
			this.Type = IDestroyDynamicEntitiesType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F8E4 RID: 194788 RVA: 0x0067B745 File Offset: 0x00679945
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F8E5 RID: 194789 RVA: 0x0067B757 File Offset: 0x00679957
		public IDestroyDynamicEntitiesTypeT AsIDestroyDynamicEntitiesType()
		{
			return this.As<IDestroyDynamicEntitiesTypeT>();
		}

		// Token: 0x0602F8E6 RID: 194790 RVA: 0x0067B75F File Offset: 0x0067995F
		public static IDestroyDynamicEntitiesType_UnionUnion FromIDestroyDynamicEntitiesType(IDestroyDynamicEntitiesTypeT _idestroydynamicentitiestype)
		{
			return new IDestroyDynamicEntitiesType_UnionUnion
			{
				Type = IDestroyDynamicEntitiesType_Union.IDestroyDynamicEntitiesType,
				Value = _idestroydynamicentitiestype
			};
		}

		// Token: 0x0602F8E7 RID: 194791 RVA: 0x0067B774 File Offset: 0x00679974
		public IDestroyVisionDisplayT AsIDestroyVisionDisplay()
		{
			return this.As<IDestroyVisionDisplayT>();
		}

		// Token: 0x0602F8E8 RID: 194792 RVA: 0x0067B77C File Offset: 0x0067997C
		public static IDestroyDynamicEntitiesType_UnionUnion FromIDestroyVisionDisplay(IDestroyVisionDisplayT _idestroyvisiondisplay)
		{
			return new IDestroyDynamicEntitiesType_UnionUnion
			{
				Type = IDestroyDynamicEntitiesType_Union.IDestroyVisionDisplay,
				Value = _idestroyvisiondisplay
			};
		}

		// Token: 0x0602F8E9 RID: 194793 RVA: 0x0067B794 File Offset: 0x00679994
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
