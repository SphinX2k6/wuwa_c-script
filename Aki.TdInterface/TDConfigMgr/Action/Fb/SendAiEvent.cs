using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276A RID: 10090
	public class SendAiEvent : ActionParams
	{
		// Token: 0x0600E0BC RID: 57532 RVA: 0x0021364F File Offset: 0x0021184F
		[NullableContext(1)]
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

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x0600E0BD RID: 57533 RVA: 0x00213670 File Offset: 0x00211870
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

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x0600E0BE RID: 57534 RVA: 0x002136A6 File Offset: 0x002118A6
		public virtual EAiEventType EventType
		{
			get
			{
				return (EAiEventType)this.Instance.EventType;
			}
		}

		// Token: 0x04007C72 RID: 31858
		private ISendAiEvent Instance;
	}
}
