using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062C5 RID: 25285
	public class TRefreshConditionUnion
	{
		// Token: 0x1700BB9A RID: 48026
		// (get) Token: 0x0602AFBB RID: 176059 RVA: 0x005DCDF8 File Offset: 0x005DAFF8
		// (set) Token: 0x0602AFBC RID: 176060 RVA: 0x005DCE00 File Offset: 0x005DB000
		public TRefreshCondition Type { get; set; }

		// Token: 0x1700BB9B RID: 48027
		// (get) Token: 0x0602AFBD RID: 176061 RVA: 0x005DCE09 File Offset: 0x005DB009
		// (set) Token: 0x0602AFBE RID: 176062 RVA: 0x005DCE11 File Offset: 0x005DB011
		public object Value { get; set; }

		// Token: 0x0602AFBF RID: 176063 RVA: 0x005DCE1A File Offset: 0x005DB01A
		public TRefreshConditionUnion()
		{
			this.Type = TRefreshCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602AFC0 RID: 176064 RVA: 0x005DCE30 File Offset: 0x005DB030
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AFC1 RID: 176065 RVA: 0x005DCE42 File Offset: 0x005DB042
		public IRefreshOnDeathT AsIRefreshOnDeath()
		{
			return this.As<IRefreshOnDeathT>();
		}

		// Token: 0x0602AFC2 RID: 176066 RVA: 0x005DCE4A File Offset: 0x005DB04A
		public static TRefreshConditionUnion FromIRefreshOnDeath(IRefreshOnDeathT _irefreshondeath)
		{
			return new TRefreshConditionUnion
			{
				Type = TRefreshCondition.IRefreshOnDeath,
				Value = _irefreshondeath
			};
		}

		// Token: 0x0602AFC3 RID: 176067 RVA: 0x005DCE5F File Offset: 0x005DB05F
		public IRefreshOnHostInteractT AsIRefreshOnHostInteract()
		{
			return this.As<IRefreshOnHostInteractT>();
		}

		// Token: 0x0602AFC4 RID: 176068 RVA: 0x005DCE67 File Offset: 0x005DB067
		public static TRefreshConditionUnion FromIRefreshOnHostInteract(IRefreshOnHostInteractT _irefreshonhostinteract)
		{
			return new TRefreshConditionUnion
			{
				Type = TRefreshCondition.IRefreshOnHostInteract,
				Value = _irefreshonhostinteract
			};
		}

		// Token: 0x0602AFC5 RID: 176069 RVA: 0x005DCE7C File Offset: 0x005DB07C
		public static int Pack(FlatBufferBuilder builder, TRefreshConditionUnion _o)
		{
			TRefreshCondition type = _o.Type;
			if (type == TRefreshCondition.IRefreshOnDeath)
			{
				return IRefreshOnDeath.Pack(builder, _o.AsIRefreshOnDeath()).Value;
			}
			if (type != TRefreshCondition.IRefreshOnHostInteract)
			{
				return 0;
			}
			return IRefreshOnHostInteract.Pack(builder, _o.AsIRefreshOnHostInteract()).Value;
		}
	}
}
