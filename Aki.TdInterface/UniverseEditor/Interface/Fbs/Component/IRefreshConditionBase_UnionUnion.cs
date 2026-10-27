using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581E RID: 22558
	public class IRefreshConditionBase_UnionUnion
	{
		// Token: 0x1700A880 RID: 43136
		// (get) Token: 0x06025EE0 RID: 155360 RVA: 0x0053AE59 File Offset: 0x00539059
		// (set) Token: 0x06025EE1 RID: 155361 RVA: 0x0053AE61 File Offset: 0x00539061
		public IRefreshConditionBase_Union Type { get; set; }

		// Token: 0x1700A881 RID: 43137
		// (get) Token: 0x06025EE2 RID: 155362 RVA: 0x0053AE6A File Offset: 0x0053906A
		// (set) Token: 0x06025EE3 RID: 155363 RVA: 0x0053AE72 File Offset: 0x00539072
		public object Value { get; set; }

		// Token: 0x06025EE4 RID: 155364 RVA: 0x0053AE7B File Offset: 0x0053907B
		public IRefreshConditionBase_UnionUnion()
		{
			this.Type = IRefreshConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025EE5 RID: 155365 RVA: 0x0053AE91 File Offset: 0x00539091
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025EE6 RID: 155366 RVA: 0x0053AEA3 File Offset: 0x005390A3
		public IRefreshConditionBaseT AsIRefreshConditionBase()
		{
			return this.As<IRefreshConditionBaseT>();
		}

		// Token: 0x06025EE7 RID: 155367 RVA: 0x0053AEAB File Offset: 0x005390AB
		public static IRefreshConditionBase_UnionUnion FromIRefreshConditionBase(IRefreshConditionBaseT _irefreshconditionbase)
		{
			return new IRefreshConditionBase_UnionUnion
			{
				Type = IRefreshConditionBase_Union.IRefreshConditionBase,
				Value = _irefreshconditionbase
			};
		}

		// Token: 0x06025EE8 RID: 155368 RVA: 0x0053AEC0 File Offset: 0x005390C0
		public IRefreshOnDeathT AsIRefreshOnDeath()
		{
			return this.As<IRefreshOnDeathT>();
		}

		// Token: 0x06025EE9 RID: 155369 RVA: 0x0053AEC8 File Offset: 0x005390C8
		public static IRefreshConditionBase_UnionUnion FromIRefreshOnDeath(IRefreshOnDeathT _irefreshondeath)
		{
			return new IRefreshConditionBase_UnionUnion
			{
				Type = IRefreshConditionBase_Union.IRefreshOnDeath,
				Value = _irefreshondeath
			};
		}

		// Token: 0x06025EEA RID: 155370 RVA: 0x0053AEDD File Offset: 0x005390DD
		public IRefreshOnHostInteractT AsIRefreshOnHostInteract()
		{
			return this.As<IRefreshOnHostInteractT>();
		}

		// Token: 0x06025EEB RID: 155371 RVA: 0x0053AEE5 File Offset: 0x005390E5
		public static IRefreshConditionBase_UnionUnion FromIRefreshOnHostInteract(IRefreshOnHostInteractT _irefreshonhostinteract)
		{
			return new IRefreshConditionBase_UnionUnion
			{
				Type = IRefreshConditionBase_Union.IRefreshOnHostInteract,
				Value = _irefreshonhostinteract
			};
		}

		// Token: 0x06025EEC RID: 155372 RVA: 0x0053AEFC File Offset: 0x005390FC
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
