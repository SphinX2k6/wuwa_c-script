using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C94 RID: 23700
	public class TRefreshConditionUnion
	{
		// Token: 0x1700B240 RID: 45632
		// (get) Token: 0x06028975 RID: 166261 RVA: 0x005946C0 File Offset: 0x005928C0
		// (set) Token: 0x06028976 RID: 166262 RVA: 0x005946C8 File Offset: 0x005928C8
		public TRefreshCondition Type { get; set; }

		// Token: 0x1700B241 RID: 45633
		// (get) Token: 0x06028977 RID: 166263 RVA: 0x005946D1 File Offset: 0x005928D1
		// (set) Token: 0x06028978 RID: 166264 RVA: 0x005946D9 File Offset: 0x005928D9
		public object Value { get; set; }

		// Token: 0x06028979 RID: 166265 RVA: 0x005946E2 File Offset: 0x005928E2
		public TRefreshConditionUnion()
		{
			this.Type = TRefreshCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602897A RID: 166266 RVA: 0x005946F8 File Offset: 0x005928F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602897B RID: 166267 RVA: 0x0059470A File Offset: 0x0059290A
		public IRefreshOnDeathT AsIRefreshOnDeath()
		{
			return this.As<IRefreshOnDeathT>();
		}

		// Token: 0x0602897C RID: 166268 RVA: 0x00594712 File Offset: 0x00592912
		public static TRefreshConditionUnion FromIRefreshOnDeath(IRefreshOnDeathT _irefreshondeath)
		{
			return new TRefreshConditionUnion
			{
				Type = TRefreshCondition.IRefreshOnDeath,
				Value = _irefreshondeath
			};
		}

		// Token: 0x0602897D RID: 166269 RVA: 0x00594727 File Offset: 0x00592927
		public IRefreshOnHostInteractT AsIRefreshOnHostInteract()
		{
			return this.As<IRefreshOnHostInteractT>();
		}

		// Token: 0x0602897E RID: 166270 RVA: 0x0059472F File Offset: 0x0059292F
		public static TRefreshConditionUnion FromIRefreshOnHostInteract(IRefreshOnHostInteractT _irefreshonhostinteract)
		{
			return new TRefreshConditionUnion
			{
				Type = TRefreshCondition.IRefreshOnHostInteract,
				Value = _irefreshonhostinteract
			};
		}

		// Token: 0x0602897F RID: 166271 RVA: 0x00594744 File Offset: 0x00592944
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
