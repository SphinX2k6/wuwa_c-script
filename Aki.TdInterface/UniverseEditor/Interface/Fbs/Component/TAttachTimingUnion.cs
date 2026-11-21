using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006205 RID: 25093
	public class TAttachTimingUnion
	{
		// Token: 0x1700BB11 RID: 47889
		// (get) Token: 0x0602AB01 RID: 174849 RVA: 0x005D1FE4 File Offset: 0x005D01E4
		// (set) Token: 0x0602AB02 RID: 174850 RVA: 0x005D1FEC File Offset: 0x005D01EC
		public TAttachTiming Type { get; set; }

		// Token: 0x1700BB12 RID: 47890
		// (get) Token: 0x0602AB03 RID: 174851 RVA: 0x005D1FF5 File Offset: 0x005D01F5
		// (set) Token: 0x0602AB04 RID: 174852 RVA: 0x005D1FFD File Offset: 0x005D01FD
		public object Value { get; set; }

		// Token: 0x0602AB05 RID: 174853 RVA: 0x005D2006 File Offset: 0x005D0206
		public TAttachTimingUnion()
		{
			this.Type = TAttachTiming.NONE;
			this.Value = null;
		}

		// Token: 0x0602AB06 RID: 174854 RVA: 0x005D201C File Offset: 0x005D021C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AB07 RID: 174855 RVA: 0x005D202E File Offset: 0x005D022E
		public IDefaultAttachTimingT AsIDefaultAttachTiming()
		{
			return this.As<IDefaultAttachTimingT>();
		}

		// Token: 0x0602AB08 RID: 174856 RVA: 0x005D2036 File Offset: 0x005D0236
		public static TAttachTimingUnion FromIDefaultAttachTiming(IDefaultAttachTimingT _idefaultattachtiming)
		{
			return new TAttachTimingUnion
			{
				Type = TAttachTiming.IDefaultAttachTiming,
				Value = _idefaultattachtiming
			};
		}

		// Token: 0x0602AB09 RID: 174857 RVA: 0x005D204B File Offset: 0x005D024B
		public IOnEntityStateChangeAttachTimingT AsIOnEntityStateChangeAttachTiming()
		{
			return this.As<IOnEntityStateChangeAttachTimingT>();
		}

		// Token: 0x0602AB0A RID: 174858 RVA: 0x005D2053 File Offset: 0x005D0253
		public static TAttachTimingUnion FromIOnEntityStateChangeAttachTiming(IOnEntityStateChangeAttachTimingT _ionentitystatechangeattachtiming)
		{
			return new TAttachTimingUnion
			{
				Type = TAttachTiming.IOnEntityStateChangeAttachTiming,
				Value = _ionentitystatechangeattachtiming
			};
		}

		// Token: 0x0602AB0B RID: 174859 RVA: 0x005D2068 File Offset: 0x005D0268
		public IOnMoveWithSplineEndAttachTimingT AsIOnMoveWithSplineEndAttachTiming()
		{
			return this.As<IOnMoveWithSplineEndAttachTimingT>();
		}

		// Token: 0x0602AB0C RID: 174860 RVA: 0x005D2070 File Offset: 0x005D0270
		public static TAttachTimingUnion FromIOnMoveWithSplineEndAttachTiming(IOnMoveWithSplineEndAttachTimingT _ionmovewithsplineendattachtiming)
		{
			return new TAttachTimingUnion
			{
				Type = TAttachTiming.IOnMoveWithSplineEndAttachTiming,
				Value = _ionmovewithsplineendattachtiming
			};
		}

		// Token: 0x0602AB0D RID: 174861 RVA: 0x005D2088 File Offset: 0x005D0288
		public static int Pack(FlatBufferBuilder builder, TAttachTimingUnion _o)
		{
			switch (_o.Type)
			{
			case TAttachTiming.IDefaultAttachTiming:
				return IDefaultAttachTiming.Pack(builder, _o.AsIDefaultAttachTiming()).Value;
			case TAttachTiming.IOnEntityStateChangeAttachTiming:
				return IOnEntityStateChangeAttachTiming.Pack(builder, _o.AsIOnEntityStateChangeAttachTiming()).Value;
			case TAttachTiming.IOnMoveWithSplineEndAttachTiming:
				return IOnMoveWithSplineEndAttachTiming.Pack(builder, _o.AsIOnMoveWithSplineEndAttachTiming()).Value;
			default:
				return 0;
			}
		}
	}
}
