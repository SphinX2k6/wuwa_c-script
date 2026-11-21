using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C70 RID: 23664
	public class IPasserbyNpcExitOrderBase_UnionUnion
	{
		// Token: 0x1700ADE3 RID: 44515
		// (get) Token: 0x06027415 RID: 160789 RVA: 0x0056084D File Offset: 0x0055EA4D
		// (set) Token: 0x06027416 RID: 160790 RVA: 0x00560855 File Offset: 0x0055EA55
		public IPasserbyNpcExitOrderBase_Union Type { get; set; }

		// Token: 0x1700ADE4 RID: 44516
		// (get) Token: 0x06027417 RID: 160791 RVA: 0x0056085E File Offset: 0x0055EA5E
		// (set) Token: 0x06027418 RID: 160792 RVA: 0x00560866 File Offset: 0x0055EA66
		public object Value { get; set; }

		// Token: 0x06027419 RID: 160793 RVA: 0x0056086F File Offset: 0x0055EA6F
		public IPasserbyNpcExitOrderBase_UnionUnion()
		{
			this.Type = IPasserbyNpcExitOrderBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602741A RID: 160794 RVA: 0x00560885 File Offset: 0x0055EA85
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602741B RID: 160795 RVA: 0x00560897 File Offset: 0x0055EA97
		public IPasserbyNpcExitOrderBaseT AsIPasserbyNpcExitOrderBase()
		{
			return this.As<IPasserbyNpcExitOrderBaseT>();
		}

		// Token: 0x0602741C RID: 160796 RVA: 0x0056089F File Offset: 0x0055EA9F
		public static IPasserbyNpcExitOrderBase_UnionUnion FromIPasserbyNpcExitOrderBase(IPasserbyNpcExitOrderBaseT _ipasserbynpcexitorderbase)
		{
			return new IPasserbyNpcExitOrderBase_UnionUnion
			{
				Type = IPasserbyNpcExitOrderBase_Union.IPasserbyNpcExitOrderBase,
				Value = _ipasserbynpcexitorderbase
			};
		}

		// Token: 0x0602741D RID: 160797 RVA: 0x005608B4 File Offset: 0x0055EAB4
		public IPasserbyNpcNearSplineStartFirstExitOrderT AsIPasserbyNpcNearSplineStartFirstExitOrder()
		{
			return this.As<IPasserbyNpcNearSplineStartFirstExitOrderT>();
		}

		// Token: 0x0602741E RID: 160798 RVA: 0x005608BC File Offset: 0x0055EABC
		public static IPasserbyNpcExitOrderBase_UnionUnion FromIPasserbyNpcNearSplineStartFirstExitOrder(IPasserbyNpcNearSplineStartFirstExitOrderT _ipasserbynpcnearsplinestartfirstexitorder)
		{
			return new IPasserbyNpcExitOrderBase_UnionUnion
			{
				Type = IPasserbyNpcExitOrderBase_Union.IPasserbyNpcNearSplineStartFirstExitOrder,
				Value = _ipasserbynpcnearsplinestartfirstexitorder
			};
		}

		// Token: 0x0602741F RID: 160799 RVA: 0x005608D4 File Offset: 0x0055EAD4
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcExitOrderBase_UnionUnion _o)
		{
			IPasserbyNpcExitOrderBase_Union type = _o.Type;
			if (type == IPasserbyNpcExitOrderBase_Union.IPasserbyNpcExitOrderBase)
			{
				return IPasserbyNpcExitOrderBase.Pack(builder, _o.AsIPasserbyNpcExitOrderBase()).Value;
			}
			if (type != IPasserbyNpcExitOrderBase_Union.IPasserbyNpcNearSplineStartFirstExitOrder)
			{
				return 0;
			}
			return IPasserbyNpcNearSplineStartFirstExitOrder.Pack(builder, _o.AsIPasserbyNpcNearSplineStartFirstExitOrder()).Value;
		}
	}
}
