using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001633 RID: 5683
	public class ChangeNpcAbpState : ActionParams
	{
		// Token: 0x06008053 RID: 32851 RVA: 0x0013193C File Offset: 0x0012FB3C
		private ChangeNpcAbpState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeNpcAbpState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeNpcAbpState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeNpcAbpState_SetValue());
			}
			return result;
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x00131974 File Offset: 0x0012FB74
		public static ChangeNpcAbpState Create([Nullable(2)] ChangeNpcAbpState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeNpcAbpState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x00131987 File Offset: 0x0012FB87
		public static ChangeNpcAbpState CreateFromSetValue([Nullable(2)] ChangeNpcAbpState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeNpcAbpState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x0013199A File Offset: 0x0012FB9A
		public ChangeNpcAbpState_SetValue ToSetValue()
		{
			return new ChangeNpcAbpState_SetValue
			{
				EntityId = this.EntityId,
				AbpState = this.AbpState
			};
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x06008057 RID: 32855 RVA: 0x001319B9 File Offset: 0x0012FBB9
		// (set) Token: 0x06008058 RID: 32856 RVA: 0x001319E4 File Offset: 0x0012FBE4
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

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06008059 RID: 32857 RVA: 0x001319F2 File Offset: 0x0012FBF2
		// (set) Token: 0x0600805A RID: 32858 RVA: 0x00131A1D File Offset: 0x0012FC1D
		public virtual string AbpState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AbpState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AbpState;
			}
			set
			{
				this.GetOrCreatePoco().AbpState = value;
			}
		}

		// Token: 0x04004A1E RID: 18974
		[Nullable(2)]
		protected new ChangeNpcAbpState FbInstance;

		// Token: 0x04004A1F RID: 18975
		[Nullable(2)]
		protected ChangeNpcAbpState_SetValue PocoInterface;
	}
}
