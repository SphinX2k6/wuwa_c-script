using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC6 RID: 20166
	public class IAttachTiming_UnionUnion
	{
		// Token: 0x170090A9 RID: 37033
		// (get) Token: 0x0601FC31 RID: 130097 RVA: 0x0046BD7D File Offset: 0x00469F7D
		// (set) Token: 0x0601FC32 RID: 130098 RVA: 0x0046BD85 File Offset: 0x00469F85
		public IAttachTiming_Union Type { get; set; }

		// Token: 0x170090AA RID: 37034
		// (get) Token: 0x0601FC33 RID: 130099 RVA: 0x0046BD8E File Offset: 0x00469F8E
		// (set) Token: 0x0601FC34 RID: 130100 RVA: 0x0046BD96 File Offset: 0x00469F96
		public object Value { get; set; }

		// Token: 0x0601FC35 RID: 130101 RVA: 0x0046BD9F File Offset: 0x00469F9F
		public IAttachTiming_UnionUnion()
		{
			this.Type = IAttachTiming_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FC36 RID: 130102 RVA: 0x0046BDB5 File Offset: 0x00469FB5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FC37 RID: 130103 RVA: 0x0046BDC7 File Offset: 0x00469FC7
		public IAttachTimingT AsIAttachTiming()
		{
			return this.As<IAttachTimingT>();
		}

		// Token: 0x0601FC38 RID: 130104 RVA: 0x0046BDCF File Offset: 0x00469FCF
		public static IAttachTiming_UnionUnion FromIAttachTiming(IAttachTimingT _iattachtiming)
		{
			return new IAttachTiming_UnionUnion
			{
				Type = IAttachTiming_Union.IAttachTiming,
				Value = _iattachtiming
			};
		}

		// Token: 0x0601FC39 RID: 130105 RVA: 0x0046BDE4 File Offset: 0x00469FE4
		public IDefaultAttachTimingT AsIDefaultAttachTiming()
		{
			return this.As<IDefaultAttachTimingT>();
		}

		// Token: 0x0601FC3A RID: 130106 RVA: 0x0046BDEC File Offset: 0x00469FEC
		public static IAttachTiming_UnionUnion FromIDefaultAttachTiming(IDefaultAttachTimingT _idefaultattachtiming)
		{
			return new IAttachTiming_UnionUnion
			{
				Type = IAttachTiming_Union.IDefaultAttachTiming,
				Value = _idefaultattachtiming
			};
		}

		// Token: 0x0601FC3B RID: 130107 RVA: 0x0046BE01 File Offset: 0x0046A001
		public IOnMoveWithSplineEndAttachTimingT AsIOnMoveWithSplineEndAttachTiming()
		{
			return this.As<IOnMoveWithSplineEndAttachTimingT>();
		}

		// Token: 0x0601FC3C RID: 130108 RVA: 0x0046BE09 File Offset: 0x0046A009
		public static IAttachTiming_UnionUnion FromIOnMoveWithSplineEndAttachTiming(IOnMoveWithSplineEndAttachTimingT _ionmovewithsplineendattachtiming)
		{
			return new IAttachTiming_UnionUnion
			{
				Type = IAttachTiming_Union.IOnMoveWithSplineEndAttachTiming,
				Value = _ionmovewithsplineendattachtiming
			};
		}

		// Token: 0x0601FC3D RID: 130109 RVA: 0x0046BE20 File Offset: 0x0046A020
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
			default:
				return 0;
			}
		}
	}
}
