using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001637 RID: 5687
	public class ChangeOtherState : ActionParams
	{
		// Token: 0x06008067 RID: 32871 RVA: 0x00131B3C File Offset: 0x0012FD3C
		private ChangeOtherState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeOtherState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeOtherState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeOtherState_SetValue());
			}
			return result;
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x00131B74 File Offset: 0x0012FD74
		public static ChangeOtherState Create([Nullable(2)] ChangeOtherState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeOtherState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00131B87 File Offset: 0x0012FD87
		public static ChangeOtherState CreateFromSetValue([Nullable(2)] ChangeOtherState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeOtherState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x00131B9A File Offset: 0x0012FD9A
		public ChangeOtherState_SetValue ToSetValue()
		{
			return new ChangeOtherState_SetValue
			{
				EntityId = this.EntityId,
				State = this.State
			};
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0600806B RID: 32875 RVA: 0x00131BB9 File Offset: 0x0012FDB9
		// (set) Token: 0x0600806C RID: 32876 RVA: 0x00131BE4 File Offset: 0x0012FDE4
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

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x00131BF4 File Offset: 0x0012FDF4
		// (set) Token: 0x0600806E RID: 32878 RVA: 0x00131C55 File Offset: 0x0012FE55
		public virtual PlayFlow State
		{
			get
			{
				if (this._StateInited)
				{
					return this._StateCache;
				}
				this._StateInited = true;
				if (this.FbInstance != null)
				{
					this._StateCache = PlayFlow.Create(this.FbInstance.State);
				}
				else
				{
					ChangeOtherState_SetValue pocoInterface = this.PocoInterface;
					this._StateCache = ((pocoInterface != null) ? pocoInterface.State : null);
				}
				return this._StateCache;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
				this._StateInited = false;
			}
		}

		// Token: 0x04004A26 RID: 18982
		[Nullable(2)]
		protected new ChangeOtherState FbInstance;

		// Token: 0x04004A27 RID: 18983
		[Nullable(2)]
		protected ChangeOtherState_SetValue PocoInterface;

		// Token: 0x04004A28 RID: 18984
		private PlayFlow _StateCache;

		// Token: 0x04004A29 RID: 18985
		private bool _StateInited;
	}
}
