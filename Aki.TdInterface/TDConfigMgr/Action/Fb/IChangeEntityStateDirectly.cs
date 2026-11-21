using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292E RID: 10542
	public class IChangeEntityStateDirectly : ChangeEntityState
	{
		// Token: 0x0600EA53 RID: 59987 RVA: 0x00229513 File Offset: 0x00227713
		public static IChangeEntityStateDirectly Create(IChangeEntityStateDirectly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateDirectly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x0600EA54 RID: 59988 RVA: 0x00229532 File Offset: 0x00227732
		public override EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x0022953F File Offset: 0x0022773F
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x0600EA56 RID: 59990 RVA: 0x0022954C File Offset: 0x0022774C
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x0022955C File Offset: 0x0022775C
		public virtual bool? DelayChange
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DelayChange);
			}
		}

		// Token: 0x0400812E RID: 33070
		private IChangeEntityStateDirectly Instance;
	}
}
