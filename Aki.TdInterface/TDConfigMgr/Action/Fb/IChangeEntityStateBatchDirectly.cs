using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292F RID: 10543
	public class IChangeEntityStateBatchDirectly : ChangeEntityState
	{
		// Token: 0x0600EA59 RID: 59993 RVA: 0x0022959A File Offset: 0x0022779A
		public static IChangeEntityStateBatchDirectly Create(IChangeEntityStateBatchDirectly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateBatchDirectly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x0600EA5A RID: 59994 RVA: 0x002295B9 File Offset: 0x002277B9
		public override EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x0600EA5B RID: 59995 RVA: 0x002295C6 File Offset: 0x002277C6
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x0600EA5C RID: 59996 RVA: 0x002295D4 File Offset: 0x002277D4
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x0600EA5D RID: 59997 RVA: 0x00229638 File Offset: 0x00227838
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x0600EA5E RID: 59998 RVA: 0x00229648 File Offset: 0x00227848
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

		// Token: 0x0400812F RID: 33071
		private IChangeEntityStateBatchDirectly Instance;

		// Token: 0x04008130 RID: 33072
		private List<int> _EntityIdsCache;

		// Token: 0x04008131 RID: 33073
		private bool _EntityIdsInited;
	}
}
