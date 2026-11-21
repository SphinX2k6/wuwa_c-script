using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FAB RID: 8107
	public class IRemovePreloadFlows : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600AC57 RID: 44119 RVA: 0x00185A98 File Offset: 0x00183C98
		private IRemovePreloadFlows_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemovePreloadFlows 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemovePreloadFlows_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemovePreloadFlows_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC58 RID: 44120 RVA: 0x00185AD0 File Offset: 0x00183CD0
		public static IRemovePreloadFlows Create([Nullable(2)] IRemovePreloadFlows instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadFlows
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x00185AE3 File Offset: 0x00183CE3
		public static IRemovePreloadFlows CreateFromSetValue([Nullable(2)] IRemovePreloadFlows_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemovePreloadFlows
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x00185AF6 File Offset: 0x00183CF6
		public new IRemovePreloadFlows_SetValue ToSetValue()
		{
			return new IRemovePreloadFlows_SetValue
			{
				Type = this.Type,
				FlowId = this.FlowId
			};
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600AC5B RID: 44123 RVA: 0x00185B15 File Offset: 0x00183D15
		// (set) Token: 0x0600AC5C RID: 44124 RVA: 0x00185B40 File Offset: 0x00183D40
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600AC5D RID: 44125 RVA: 0x00185B50 File Offset: 0x00183D50
		// (set) Token: 0x0600AC5E RID: 44126 RVA: 0x00185BB1 File Offset: 0x00183DB1
		public virtual PlayFlow FlowId
		{
			get
			{
				if (this._FlowIdInited)
				{
					return this._FlowIdCache;
				}
				this._FlowIdInited = true;
				if (this.FbInstance != null)
				{
					this._FlowIdCache = PlayFlow.Create(this.FbInstance.FlowId);
				}
				else
				{
					IRemovePreloadFlows_SetValue pocoInterface = this.PocoInterface;
					this._FlowIdCache = ((pocoInterface != null) ? pocoInterface.FlowId : null);
				}
				return this._FlowIdCache;
			}
			set
			{
				this.GetOrCreatePoco().FlowId = value;
				this._FlowIdInited = false;
			}
		}

		// Token: 0x04006708 RID: 26376
		[Nullable(2)]
		protected new IRemovePreloadFlows FbInstance;

		// Token: 0x04006709 RID: 26377
		[Nullable(2)]
		protected new IRemovePreloadFlows_SetValue PocoInterface;

		// Token: 0x0400670A RID: 26378
		private PlayFlow _FlowIdCache;

		// Token: 0x0400670B RID: 26379
		private bool _FlowIdInited;
	}
}
