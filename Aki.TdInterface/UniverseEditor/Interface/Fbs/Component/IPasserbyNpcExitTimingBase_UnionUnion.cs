using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C76 RID: 23670
	public class IPasserbyNpcExitTimingBase_UnionUnion
	{
		// Token: 0x1700ADE8 RID: 44520
		// (get) Token: 0x06027433 RID: 160819 RVA: 0x00560AC1 File Offset: 0x0055ECC1
		// (set) Token: 0x06027434 RID: 160820 RVA: 0x00560AC9 File Offset: 0x0055ECC9
		public IPasserbyNpcExitTimingBase_Union Type { get; set; }

		// Token: 0x1700ADE9 RID: 44521
		// (get) Token: 0x06027435 RID: 160821 RVA: 0x00560AD2 File Offset: 0x0055ECD2
		// (set) Token: 0x06027436 RID: 160822 RVA: 0x00560ADA File Offset: 0x0055ECDA
		public object Value { get; set; }

		// Token: 0x06027437 RID: 160823 RVA: 0x00560AE3 File Offset: 0x0055ECE3
		public IPasserbyNpcExitTimingBase_UnionUnion()
		{
			this.Type = IPasserbyNpcExitTimingBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027438 RID: 160824 RVA: 0x00560AF9 File Offset: 0x0055ECF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027439 RID: 160825 RVA: 0x00560B0B File Offset: 0x0055ED0B
		public IPasserbyNpcExitTimingBaseT AsIPasserbyNpcExitTimingBase()
		{
			return this.As<IPasserbyNpcExitTimingBaseT>();
		}

		// Token: 0x0602743A RID: 160826 RVA: 0x00560B13 File Offset: 0x0055ED13
		public static IPasserbyNpcExitTimingBase_UnionUnion FromIPasserbyNpcExitTimingBase(IPasserbyNpcExitTimingBaseT _ipasserbynpcexittimingbase)
		{
			return new IPasserbyNpcExitTimingBase_UnionUnion
			{
				Type = IPasserbyNpcExitTimingBase_Union.IPasserbyNpcExitTimingBase,
				Value = _ipasserbynpcexittimingbase
			};
		}

		// Token: 0x0602743B RID: 160827 RVA: 0x00560B28 File Offset: 0x0055ED28
		public IPasserbyNpcLiftStopExitTimingT AsIPasserbyNpcLiftStopExitTiming()
		{
			return this.As<IPasserbyNpcLiftStopExitTimingT>();
		}

		// Token: 0x0602743C RID: 160828 RVA: 0x00560B30 File Offset: 0x0055ED30
		public static IPasserbyNpcExitTimingBase_UnionUnion FromIPasserbyNpcLiftStopExitTiming(IPasserbyNpcLiftStopExitTimingT _ipasserbynpcliftstopexittiming)
		{
			return new IPasserbyNpcExitTimingBase_UnionUnion
			{
				Type = IPasserbyNpcExitTimingBase_Union.IPasserbyNpcLiftStopExitTiming,
				Value = _ipasserbynpcliftstopexittiming
			};
		}

		// Token: 0x0602743D RID: 160829 RVA: 0x00560B48 File Offset: 0x0055ED48
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcExitTimingBase_UnionUnion _o)
		{
			IPasserbyNpcExitTimingBase_Union type = _o.Type;
			if (type == IPasserbyNpcExitTimingBase_Union.IPasserbyNpcExitTimingBase)
			{
				return IPasserbyNpcExitTimingBase.Pack(builder, _o.AsIPasserbyNpcExitTimingBase()).Value;
			}
			if (type != IPasserbyNpcExitTimingBase_Union.IPasserbyNpcLiftStopExitTiming)
			{
				return 0;
			}
			return IPasserbyNpcLiftStopExitTiming.Pack(builder, _o.AsIPasserbyNpcLiftStopExitTiming()).Value;
		}
	}
}
