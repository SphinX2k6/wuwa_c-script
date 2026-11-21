using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E25 RID: 24101
	public class IRefreshConditionBase_UnionUnion
	{
		// Token: 0x1700B1A4 RID: 45476
		// (get) Token: 0x06028400 RID: 164864 RVA: 0x00580FE5 File Offset: 0x0057F1E5
		// (set) Token: 0x06028401 RID: 164865 RVA: 0x00580FED File Offset: 0x0057F1ED
		public IRefreshConditionBase_Union Type { get; set; }

		// Token: 0x1700B1A5 RID: 45477
		// (get) Token: 0x06028402 RID: 164866 RVA: 0x00580FF6 File Offset: 0x0057F1F6
		// (set) Token: 0x06028403 RID: 164867 RVA: 0x00580FFE File Offset: 0x0057F1FE
		public object Value { get; set; }

		// Token: 0x06028404 RID: 164868 RVA: 0x00581007 File Offset: 0x0057F207
		public IRefreshConditionBase_UnionUnion()
		{
			this.Type = IRefreshConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028405 RID: 164869 RVA: 0x0058101D File Offset: 0x0057F21D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028406 RID: 164870 RVA: 0x0058102F File Offset: 0x0057F22F
		public IRefreshConditionBaseT AsIRefreshConditionBase()
		{
			return this.As<IRefreshConditionBaseT>();
		}

		// Token: 0x06028407 RID: 164871 RVA: 0x00581037 File Offset: 0x0057F237
		public static IRefreshConditionBase_UnionUnion FromIRefreshConditionBase(IRefreshConditionBaseT _irefreshconditionbase)
		{
			return new IRefreshConditionBase_UnionUnion
			{
				Type = IRefreshConditionBase_Union.IRefreshConditionBase,
				Value = _irefreshconditionbase
			};
		}

		// Token: 0x06028408 RID: 164872 RVA: 0x0058104C File Offset: 0x0057F24C
		public IRefreshOnDeathT AsIRefreshOnDeath()
		{
			return this.As<IRefreshOnDeathT>();
		}

		// Token: 0x06028409 RID: 164873 RVA: 0x00581054 File Offset: 0x0057F254
		public static IRefreshConditionBase_UnionUnion FromIRefreshOnDeath(IRefreshOnDeathT _irefreshondeath)
		{
			return new IRefreshConditionBase_UnionUnion
			{
				Type = IRefreshConditionBase_Union.IRefreshOnDeath,
				Value = _irefreshondeath
			};
		}

		// Token: 0x0602840A RID: 164874 RVA: 0x00581069 File Offset: 0x0057F269
		public IRefreshOnHostInteractT AsIRefreshOnHostInteract()
		{
			return this.As<IRefreshOnHostInteractT>();
		}

		// Token: 0x0602840B RID: 164875 RVA: 0x00581071 File Offset: 0x0057F271
		public static IRefreshConditionBase_UnionUnion FromIRefreshOnHostInteract(IRefreshOnHostInteractT _irefreshonhostinteract)
		{
			return new IRefreshConditionBase_UnionUnion
			{
				Type = IRefreshConditionBase_Union.IRefreshOnHostInteract,
				Value = _irefreshonhostinteract
			};
		}

		// Token: 0x0602840C RID: 164876 RVA: 0x00581088 File Offset: 0x0057F288
		public static int Pack(FlatBufferBuilder builder, IRefreshConditionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRefreshConditionBase_Union.IRefreshConditionBase:
				return IRefreshConditionBase.Pack(builder, _o.AsIRefreshConditionBase()).Value;
			case IRefreshConditionBase_Union.IRefreshOnDeath:
				return IRefreshOnDeath.Pack(builder, _o.AsIRefreshOnDeath()).Value;
			case IRefreshConditionBase_Union.IRefreshOnHostInteract:
				return IRefreshOnHostInteract.Pack(builder, _o.AsIRefreshOnHostInteract()).Value;
			default:
				return 0;
			}
		}
	}
}
