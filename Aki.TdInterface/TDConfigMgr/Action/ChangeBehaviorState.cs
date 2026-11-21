using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001621 RID: 5665
	public class ChangeBehaviorState : ActionParams
	{
		// Token: 0x06007FF5 RID: 32757 RVA: 0x00130F38 File Offset: 0x0012F138
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

		// Token: 0x06007FF6 RID: 32758 RVA: 0x00130F70 File Offset: 0x0012F170
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

		// Token: 0x06007FF7 RID: 32759 RVA: 0x00130F83 File Offset: 0x0012F183
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

		// Token: 0x06007FF8 RID: 32760 RVA: 0x00130F96 File Offset: 0x0012F196
		public ChangeBehaviorState_SetValue ToSetValue()
		{
			return new ChangeBehaviorState_SetValue
			{
				StateId = this.StateId,
				IsInstant = this.IsInstant
			};
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x06007FF9 RID: 32761 RVA: 0x00130FB5 File Offset: 0x0012F1B5
		// (set) Token: 0x06007FFA RID: 32762 RVA: 0x00130FE0 File Offset: 0x0012F1E0
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

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x06007FFB RID: 32763 RVA: 0x00130FEE File Offset: 0x0012F1EE
		// (set) Token: 0x06007FFC RID: 32764 RVA: 0x00131019 File Offset: 0x0012F219
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

		// Token: 0x040049F4 RID: 18932
		[Nullable(2)]
		protected new ChangeBehaviorState FbInstance;

		// Token: 0x040049F5 RID: 18933
		[Nullable(2)]
		protected ChangeBehaviorState_SetValue PocoInterface;
	}
}
