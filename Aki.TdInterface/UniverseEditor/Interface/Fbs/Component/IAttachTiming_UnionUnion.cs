using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F5 RID: 21493
	public class IAttachTiming_UnionUnion
	{
		// Token: 0x1700981C RID: 38940
		// (get) Token: 0x06021973 RID: 137587 RVA: 0x004A1B0A File Offset: 0x0049FD0A
		// (set) Token: 0x06021974 RID: 137588 RVA: 0x004A1B12 File Offset: 0x0049FD12
		public IAttachTiming_Union Type { get; set; }

		// Token: 0x1700981D RID: 38941
		// (get) Token: 0x06021975 RID: 137589 RVA: 0x004A1B1B File Offset: 0x0049FD1B
		// (set) Token: 0x06021976 RID: 137590 RVA: 0x004A1B23 File Offset: 0x0049FD23
		public object Value { get; set; }

		// Token: 0x06021977 RID: 137591 RVA: 0x004A1B2C File Offset: 0x0049FD2C
		public IAttachTiming_UnionUnion()
		{
			this.Type = IAttachTiming_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021978 RID: 137592 RVA: 0x004A1B42 File Offset: 0x0049FD42
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021979 RID: 137593 RVA: 0x004A1B54 File Offset: 0x0049FD54
		public IAttachTimingT AsIAttachTiming()
		{
			return this.As<IAttachTimingT>();
		}

		// Token: 0x0602197A RID: 137594 RVA: 0x004A1B5C File Offset: 0x0049FD5C
		public static IAttachTiming_UnionUnion FromIAttachTiming(IAttachTimingT _iattachtiming)
		{
			return new IAttachTiming_UnionUnion
			{
				Type = IAttachTiming_Union.IAttachTiming,
				Value = _iattachtiming
			};
		}

		// Token: 0x0602197B RID: 137595 RVA: 0x004A1B71 File Offset: 0x0049FD71
		public IDefaultAttachTimingT AsIDefaultAttachTiming()
		{
			return this.As<IDefaultAttachTimingT>();
		}

		// Token: 0x0602197C RID: 137596 RVA: 0x004A1B79 File Offset: 0x0049FD79
		public static IAttachTiming_UnionUnion FromIDefaultAttachTiming(IDefaultAttachTimingT _idefaultattachtiming)
		{
			return new IAttachTiming_UnionUnion
			{
				Type = IAttachTiming_Union.IDefaultAttachTiming,
				Value = _idefaultattachtiming
			};
		}

		// Token: 0x0602197D RID: 137597 RVA: 0x004A1B8E File Offset: 0x0049FD8E
		public IOnMoveWithSplineEndAttachTimingT AsIOnMoveWithSplineEndAttachTiming()
		{
			return this.As<IOnMoveWithSplineEndAttachTimingT>();
		}

		// Token: 0x0602197E RID: 137598 RVA: 0x004A1B96 File Offset: 0x0049FD96
		public static IAttachTiming_UnionUnion FromIOnMoveWithSplineEndAttachTiming(IOnMoveWithSplineEndAttachTimingT _ionmovewithsplineendattachtiming)
		{
			return new IAttachTiming_UnionUnion
			{
				Type = IAttachTiming_Union.IOnMoveWithSplineEndAttachTiming,
				Value = _ionmovewithsplineendattachtiming
			};
		}

		// Token: 0x0602197F RID: 137599 RVA: 0x004A1BAB File Offset: 0x0049FDAB
		public IOnEntityStateChangeAttachTimingT AsIOnEntityStateChangeAttachTiming()
		{
			return this.As<IOnEntityStateChangeAttachTimingT>();
		}

		// Token: 0x06021980 RID: 137600 RVA: 0x004A1BB3 File Offset: 0x0049FDB3
		public static IAttachTiming_UnionUnion FromIOnEntityStateChangeAttachTiming(IOnEntityStateChangeAttachTimingT _ionentitystatechangeattachtiming)
		{
			return new IAttachTiming_UnionUnion
			{
				Type = IAttachTiming_Union.IOnEntityStateChangeAttachTiming,
				Value = _ionentitystatechangeattachtiming
			};
		}

		// Token: 0x06021981 RID: 137601 RVA: 0x004A1BC8 File Offset: 0x0049FDC8
		public static int Pack(FlatBufferBuilder builder, IAttachTiming_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAttachTiming_Union.IAttachTiming:
				return IAttachTiming.Pack(builder, _o.AsIAttachTiming()).Value;
			case IAttachTiming_Union.IDefaultAttachTiming:
				return IDefaultAttachTiming.Pack(builder, _o.AsIDefaultAttachTiming()).Value;
			case IAttachTiming_Union.IOnMoveWithSplineEndAttachTiming:
				return IOnMoveWithSplineEndAttachTiming.Pack(builder, _o.AsIOnMoveWithSplineEndAttachTiming()).Value;
			case IAttachTiming_Union.IOnEntityStateChangeAttachTiming:
				return IOnEntityStateChangeAttachTiming.Pack(builder, _o.AsIOnEntityStateChangeAttachTiming()).Value;
			default:
				return 0;
			}
		}
	}
}
