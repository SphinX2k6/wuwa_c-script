using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014C8 RID: 5320
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeBehaviorState : ActionParams
	{
		// Token: 0x06007928 RID: 31016 RVA: 0x001222EC File Offset: 0x001204EC
		private ChangeBehaviorState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeBehaviorState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeBehaviorState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeBehaviorState_SetValue());
			}
			return result;
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x00122324 File Offset: 0x00120524
		public static ChangeBehaviorState Create([Nullable(2)] ChangeBehaviorState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeBehaviorState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x00122337 File Offset: 0x00120537
		public static ChangeBehaviorState CreateFromSetValue([Nullable(2)] ChangeBehaviorState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeBehaviorState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x0012234A File Offset: 0x0012054A
		public ChangeBehaviorState_SetValue ToSetValue()
		{
			return new ChangeBehaviorState_SetValue
			{
				StateId = this.StateId,
				IsInstant = this.IsInstant
			};
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x00122369 File Offset: 0x00120569
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x00122394 File Offset: 0x00120594
		public virtual int StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x0600792E RID: 31022 RVA: 0x001223A2 File Offset: 0x001205A2
		// (set) Token: 0x0600792F RID: 31023 RVA: 0x001223CD File Offset: 0x001205CD
		public virtual bool IsInstant
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsInstant;
				}
				return this.PocoInterface != null && this.PocoInterface.IsInstant;
			}
			set
			{
				this.GetOrCreatePoco().IsInstant = value;
			}
		}

		// Token: 0x04004659 RID: 18009
		[Nullable(2)]
		protected new ChangeBehaviorState FbInstance;

		// Token: 0x0400465A RID: 18010
		[Nullable(2)]
		protected ChangeBehaviorState_SetValue PocoInterface;
	}
}
