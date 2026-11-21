using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D86 RID: 32134
	public class IVisualNovelOptionGroupConfigBase_UnionUnion
	{
		// Token: 0x1700F061 RID: 61537
		// (get) Token: 0x0603A010 RID: 237584 RVA: 0x007D1D69 File Offset: 0x007CFF69
		// (set) Token: 0x0603A011 RID: 237585 RVA: 0x007D1D71 File Offset: 0x007CFF71
		public IVisualNovelOptionGroupConfigBase_Union Type { get; set; }

		// Token: 0x1700F062 RID: 61538
		// (get) Token: 0x0603A012 RID: 237586 RVA: 0x007D1D7A File Offset: 0x007CFF7A
		// (set) Token: 0x0603A013 RID: 237587 RVA: 0x007D1D82 File Offset: 0x007CFF82
		public object Value { get; set; }

		// Token: 0x0603A014 RID: 237588 RVA: 0x007D1D8B File Offset: 0x007CFF8B
		public IVisualNovelOptionGroupConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelOptionGroupConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603A015 RID: 237589 RVA: 0x007D1DA1 File Offset: 0x007CFFA1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A016 RID: 237590 RVA: 0x007D1DB3 File Offset: 0x007CFFB3
		public IVisualNovelOptionGroupConfigBaseT AsIVisualNovelOptionGroupConfigBase()
		{
			return this.As<IVisualNovelOptionGroupConfigBaseT>();
		}

		// Token: 0x0603A017 RID: 237591 RVA: 0x007D1DBB File Offset: 0x007CFFBB
		public static IVisualNovelOptionGroupConfigBase_UnionUnion FromIVisualNovelOptionGroupConfigBase(IVisualNovelOptionGroupConfigBaseT _ivisualnoveloptiongroupconfigbase)
		{
			return new IVisualNovelOptionGroupConfigBase_UnionUnion
			{
				Type = IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupConfigBase,
				Value = _ivisualnoveloptiongroupconfigbase
			};
		}

		// Token: 0x0603A018 RID: 237592 RVA: 0x007D1DD0 File Offset: 0x007CFFD0
		public IVisualNovelOptionGroupNormalT AsIVisualNovelOptionGroupNormal()
		{
			return this.As<IVisualNovelOptionGroupNormalT>();
		}

		// Token: 0x0603A019 RID: 237593 RVA: 0x007D1DD8 File Offset: 0x007CFFD8
		public static IVisualNovelOptionGroupConfigBase_UnionUnion FromIVisualNovelOptionGroupNormal(IVisualNovelOptionGroupNormalT _ivisualnoveloptiongroupnormal)
		{
			return new IVisualNovelOptionGroupConfigBase_UnionUnion
			{
				Type = IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupNormal,
				Value = _ivisualnoveloptiongroupnormal
			};
		}

		// Token: 0x0603A01A RID: 237594 RVA: 0x007D1DED File Offset: 0x007CFFED
		public IVisualNovelOptionGroupFullScreenT AsIVisualNovelOptionGroupFullScreen()
		{
			return this.As<IVisualNovelOptionGroupFullScreenT>();
		}

		// Token: 0x0603A01B RID: 237595 RVA: 0x007D1DF5 File Offset: 0x007CFFF5
		public static IVisualNovelOptionGroupConfigBase_UnionUnion FromIVisualNovelOptionGroupFullScreen(IVisualNovelOptionGroupFullScreenT _ivisualnoveloptiongroupfullscreen)
		{
			return new IVisualNovelOptionGroupConfigBase_UnionUnion
			{
				Type = IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupFullScreen,
				Value = _ivisualnoveloptiongroupfullscreen
			};
		}

		// Token: 0x0603A01C RID: 237596 RVA: 0x007D1E0C File Offset: 0x007D000C
		public static int Pack(FlatBufferBuilder builder, IVisualNovelOptionGroupConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupConfigBase:
				return IVisualNovelOptionGroupConfigBase.Pack(builder, _o.AsIVisualNovelOptionGroupConfigBase()).Value;
			case IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupNormal:
				return IVisualNovelOptionGroupNormal.Pack(builder, _o.AsIVisualNovelOptionGroupNormal()).Value;
			case IVisualNovelOptionGroupConfigBase_Union.IVisualNovelOptionGroupFullScreen:
				return IVisualNovelOptionGroupFullScreen.Pack(builder, _o.AsIVisualNovelOptionGroupFullScreen()).Value;
			default:
				return 0;
			}
		}
	}
}
