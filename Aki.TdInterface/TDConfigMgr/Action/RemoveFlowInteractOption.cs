using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AD RID: 9133
	public class RemoveFlowInteractOption : ActionParams
	{
		// Token: 0x0600C72C RID: 50988 RVA: 0x001C82F8 File Offset: 0x001C64F8
		private RemoveFlowInteractOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveFlowInteractOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveFlowInteractOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveFlowInteractOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x001C8330 File Offset: 0x001C6530
		public static RemoveFlowInteractOption Create([Nullable(2)] RemoveFlowInteractOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveFlowInteractOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x001C8343 File Offset: 0x001C6543
		public static RemoveFlowInteractOption CreateFromSetValue([Nullable(2)] RemoveFlowInteractOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveFlowInteractOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x001C8356 File Offset: 0x001C6556
		public RemoveFlowInteractOption_SetValue ToSetValue()
		{
			return new RemoveFlowInteractOption_SetValue
			{
				Flow = this.Flow,
				EntityId = this.EntityId,
				InteractToken = this.InteractToken
			};
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0600C730 RID: 50992 RVA: 0x001C8384 File Offset: 0x001C6584
		// (set) Token: 0x0600C731 RID: 50993 RVA: 0x001C83E5 File Offset: 0x001C65E5
		public virtual IFlowIndex Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = IFlowIndex.Create(this.FbInstance.Flow);
				}
				else
				{
					RemoveFlowInteractOption_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0600C732 RID: 50994 RVA: 0x001C83FA File Offset: 0x001C65FA
		// (set) Token: 0x0600C733 RID: 50995 RVA: 0x001C8425 File Offset: 0x001C6625
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

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0600C734 RID: 50996 RVA: 0x001C8433 File Offset: 0x001C6633
		// (set) Token: 0x0600C735 RID: 50997 RVA: 0x001C845A File Offset: 0x001C665A
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractToken;
				}
				RemoveFlowInteractOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractToken;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().InteractToken = value;
			}
		}

		// Token: 0x0400765F RID: 30303
		[Nullable(2)]
		protected new RemoveFlowInteractOption FbInstance;

		// Token: 0x04007660 RID: 30304
		[Nullable(2)]
		protected RemoveFlowInteractOption_SetValue PocoInterface;

		// Token: 0x04007661 RID: 30305
		private IFlowIndex _FlowCache;

		// Token: 0x04007662 RID: 30306
		private bool _FlowInited;
	}
}
