using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002670 RID: 9840
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeEntityStateBatchDirectly : ChangeEntityState
	{
		// Token: 0x0600DC8D RID: 56461 RVA: 0x0020CE8A File Offset: 0x0020B08A
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

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x0600DC8E RID: 56462 RVA: 0x0020CEA9 File Offset: 0x0020B0A9
		public override EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x0600DC8F RID: 56463 RVA: 0x0020CEB6 File Offset: 0x0020B0B6
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x0600DC90 RID: 56464 RVA: 0x0020CEC4 File Offset: 0x0020B0C4
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

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x0600DC91 RID: 56465 RVA: 0x0020CF28 File Offset: 0x0020B128
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x0600DC92 RID: 56466 RVA: 0x0020CF38 File Offset: 0x0020B138
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

		// Token: 0x04007A98 RID: 31384
		private IChangeEntityStateBatchDirectly Instance;

		// Token: 0x04007A99 RID: 31385
		private List<int> _EntityIdsCache;

		// Token: 0x04007A9A RID: 31386
		private bool _EntityIdsInited;
	}
}
