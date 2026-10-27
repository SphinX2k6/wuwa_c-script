using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214C RID: 8524
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveFlowInteractOption : ActionParams
	{
		// Token: 0x0600BB9E RID: 48030 RVA: 0x001B1144 File Offset: 0x001AF344
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

		// Token: 0x0600BB9F RID: 48031 RVA: 0x001B117C File Offset: 0x001AF37C
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

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x001B118F File Offset: 0x001AF38F
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

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x001B11A2 File Offset: 0x001AF3A2
		public RemoveFlowInteractOption_SetValue ToSetValue()
		{
			return new RemoveFlowInteractOption_SetValue
			{
				Flow = this.Flow,
				EntityId = this.EntityId,
				InteractToken = this.InteractToken
			};
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x001B11D0 File Offset: 0x001AF3D0
		// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x001B1231 File Offset: 0x001AF431
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

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x001B1246 File Offset: 0x001AF446
		// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x001B1271 File Offset: 0x001AF471
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

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x001B127F File Offset: 0x001AF47F
		// (set) Token: 0x0600BBA7 RID: 48039 RVA: 0x001B12A6 File Offset: 0x001AF4A6
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

		// Token: 0x0400702A RID: 28714
		[Nullable(2)]
		protected new RemoveFlowInteractOption FbInstance;

		// Token: 0x0400702B RID: 28715
		[Nullable(2)]
		protected RemoveFlowInteractOption_SetValue PocoInterface;

		// Token: 0x0400702C RID: 28716
		private IFlowIndex _FlowCache;

		// Token: 0x0400702D RID: 28717
		private bool _FlowInited;
	}
}
