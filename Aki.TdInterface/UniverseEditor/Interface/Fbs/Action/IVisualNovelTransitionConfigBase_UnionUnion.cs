using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF2 RID: 32242
	public class IVisualNovelTransitionConfigBase_UnionUnion
	{
		// Token: 0x1700F182 RID: 61826
		// (get) Token: 0x0603A435 RID: 238645 RVA: 0x007D9C91 File Offset: 0x007D7E91
		// (set) Token: 0x0603A436 RID: 238646 RVA: 0x007D9C99 File Offset: 0x007D7E99
		public IVisualNovelTransitionConfigBase_Union Type { get; set; }

		// Token: 0x1700F183 RID: 61827
		// (get) Token: 0x0603A437 RID: 238647 RVA: 0x007D9CA2 File Offset: 0x007D7EA2
		// (set) Token: 0x0603A438 RID: 238648 RVA: 0x007D9CAA File Offset: 0x007D7EAA
		public object Value { get; set; }

		// Token: 0x0603A439 RID: 238649 RVA: 0x007D9CB3 File Offset: 0x007D7EB3
		public IVisualNovelTransitionConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelTransitionConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603A43A RID: 238650 RVA: 0x007D9CC9 File Offset: 0x007D7EC9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A43B RID: 238651 RVA: 0x007D9CDB File Offset: 0x007D7EDB
		public IVisualNovelTransitionConfigBaseT AsIVisualNovelTransitionConfigBase()
		{
			return this.As<IVisualNovelTransitionConfigBaseT>();
		}

		// Token: 0x0603A43C RID: 238652 RVA: 0x007D9CE3 File Offset: 0x007D7EE3
		public static IVisualNovelTransitionConfigBase_UnionUnion FromIVisualNovelTransitionConfigBase(IVisualNovelTransitionConfigBaseT _ivisualnoveltransitionconfigbase)
		{
			return new IVisualNovelTransitionConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionConfigBase,
				Value = _ivisualnoveltransitionconfigbase
			};
		}

		// Token: 0x0603A43D RID: 238653 RVA: 0x007D9CF8 File Offset: 0x007D7EF8
		public IVisualNovelTransitionLocationT AsIVisualNovelTransitionLocation()
		{
			return this.As<IVisualNovelTransitionLocationT>();
		}

		// Token: 0x0603A43E RID: 238654 RVA: 0x007D9D00 File Offset: 0x007D7F00
		public static IVisualNovelTransitionConfigBase_UnionUnion FromIVisualNovelTransitionLocation(IVisualNovelTransitionLocationT _ivisualnoveltransitionlocation)
		{
			return new IVisualNovelTransitionConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionLocation,
				Value = _ivisualnoveltransitionlocation
			};
		}

		// Token: 0x0603A43F RID: 238655 RVA: 0x007D9D15 File Offset: 0x007D7F15
		public IVisualNovelTransitionTimeT AsIVisualNovelTransitionTime()
		{
			return this.As<IVisualNovelTransitionTimeT>();
		}

		// Token: 0x0603A440 RID: 238656 RVA: 0x007D9D1D File Offset: 0x007D7F1D
		public static IVisualNovelTransitionConfigBase_UnionUnion FromIVisualNovelTransitionTime(IVisualNovelTransitionTimeT _ivisualnoveltransitiontime)
		{
			return new IVisualNovelTransitionConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionTime,
				Value = _ivisualnoveltransitiontime
			};
		}

		// Token: 0x0603A441 RID: 238657 RVA: 0x007D9D34 File Offset: 0x007D7F34
		public static int Pack(FlatBufferBuilder builder, IVisualNovelTransitionConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionConfigBase:
				return IVisualNovelTransitionConfigBase.Pack(builder, _o.AsIVisualNovelTransitionConfigBase()).Value;
			case IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionLocation:
				return IVisualNovelTransitionLocation.Pack(builder, _o.AsIVisualNovelTransitionLocation()).Value;
			case IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionTime:
				return IVisualNovelTransitionTime.Pack(builder, _o.AsIVisualNovelTransitionTime()).Value;
			default:
				return 0;
			}
		}
	}
}
