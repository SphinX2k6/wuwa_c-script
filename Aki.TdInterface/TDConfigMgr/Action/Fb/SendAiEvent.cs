using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3C RID: 10812
	public class SendAiEvent : ActionParams
	{
		// Token: 0x0600EEDA RID: 61146 RVA: 0x002303E3 File Offset: 0x0022E5E3
		public static SendAiEvent Create(ISendAiEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendAiEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004710 RID: 18192
		// (get) Token: 0x0600EEDB RID: 61147 RVA: 0x00230404 File Offset: 0x0022E604
		public virtual int? EntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EntityId);
			}
		}

		// Token: 0x17004711 RID: 18193
		// (get) Token: 0x0600EEDC RID: 61148 RVA: 0x0023043A File Offset: 0x0022E63A
		public virtual EAiEventType EventType
		{
			get
			{
				return (EAiEventType)this.Instance.EventType;
			}
		}

		// Token: 0x04008328 RID: 33576
		private ISendAiEvent Instance;
	}
}
