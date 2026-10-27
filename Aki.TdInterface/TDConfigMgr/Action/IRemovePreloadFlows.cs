using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D96 RID: 7574
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemovePreloadFlows : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600A257 RID: 41559 RVA: 0x00171470 File Offset: 0x0016F670
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

		// Token: 0x0600A258 RID: 41560 RVA: 0x001714A8 File Offset: 0x0016F6A8
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

		// Token: 0x0600A259 RID: 41561 RVA: 0x001714BB File Offset: 0x0016F6BB
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

		// Token: 0x0600A25A RID: 41562 RVA: 0x001714CE File Offset: 0x0016F6CE
		public new IRemovePreloadFlows_SetValue ToSetValue()
		{
			return new IRemovePreloadFlows_SetValue
			{
				Type = this.Type,
				FlowId = this.FlowId
			};
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600A25B RID: 41563 RVA: 0x001714ED File Offset: 0x0016F6ED
		// (set) Token: 0x0600A25C RID: 41564 RVA: 0x00171518 File Offset: 0x0016F718
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

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600A25D RID: 41565 RVA: 0x00171528 File Offset: 0x0016F728
		// (set) Token: 0x0600A25E RID: 41566 RVA: 0x00171589 File Offset: 0x0016F789
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

		// Token: 0x04006184 RID: 24964
		[Nullable(2)]
		protected new IRemovePreloadFlows FbInstance;

		// Token: 0x04006185 RID: 24965
		[Nullable(2)]
		protected new IRemovePreloadFlows_SetValue PocoInterface;

		// Token: 0x04006186 RID: 24966
		private PlayFlow _FlowIdCache;

		// Token: 0x04006187 RID: 24967
		private bool _FlowIdInited;
	}
}
