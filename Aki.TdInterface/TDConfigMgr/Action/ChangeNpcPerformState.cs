using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001635 RID: 5685
	public class ChangeNpcPerformState : ActionParams
	{
		// Token: 0x0600805D RID: 32861 RVA: 0x00131A3C File Offset: 0x0012FC3C
		private ChangeNpcPerformState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeNpcPerformState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeNpcPerformState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeNpcPerformState_SetValue());
			}
			return result;
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x00131A74 File Offset: 0x0012FC74
		public static ChangeNpcPerformState Create([Nullable(2)] ChangeNpcPerformState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeNpcPerformState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x00131A87 File Offset: 0x0012FC87
		public static ChangeNpcPerformState CreateFromSetValue([Nullable(2)] ChangeNpcPerformState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeNpcPerformState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x00131A9A File Offset: 0x0012FC9A
		public ChangeNpcPerformState_SetValue ToSetValue()
		{
			return new ChangeNpcPerformState_SetValue
			{
				EntityId = this.EntityId,
				State = this.State
			};
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06008061 RID: 32865 RVA: 0x00131AB9 File Offset: 0x0012FCB9
		// (set) Token: 0x06008062 RID: 32866 RVA: 0x00131AE4 File Offset: 0x0012FCE4
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06008063 RID: 32867 RVA: 0x00131AF2 File Offset: 0x0012FCF2
		// (set) Token: 0x06008064 RID: 32868 RVA: 0x00131B1D File Offset: 0x0012FD1D
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04004A22 RID: 18978
		[Nullable(2)]
		protected new ChangeNpcPerformState FbInstance;

		// Token: 0x04004A23 RID: 18979
		[Nullable(2)]
		protected ChangeNpcPerformState_SetValue PocoInterface;
	}
}
