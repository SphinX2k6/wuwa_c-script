using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002152 RID: 8530
	[NullableContext(1)]
	[Nullable(0)]
	public class RemovePreloadResourceAction : ActionParams
	{
		// Token: 0x0600BBBA RID: 48058 RVA: 0x001B143C File Offset: 0x001AF63C
		private RemovePreloadResourceAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemovePreloadResourceAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemovePreloadResourceAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemovePreloadResourceAction_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x001B1474 File Offset: 0x001AF674
		public static RemovePreloadResourceAction Create([Nullable(2)] RemovePreloadResourceAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemovePreloadResourceAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBBC RID: 48060 RVA: 0x001B1487 File Offset: 0x001AF687
		public static RemovePreloadResourceAction CreateFromSetValue([Nullable(2)] RemovePreloadResourceAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemovePreloadResourceAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x001B149A File Offset: 0x001AF69A
		public RemovePreloadResourceAction_SetValue ToSetValue()
		{
			return new RemovePreloadResourceAction_SetValue
			{
				RemovePreloadResourceObjectType = this.RemovePreloadResourceObjectType
			};
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0600BBBE RID: 48062 RVA: 0x001B14AD File Offset: 0x001AF6AD
		// (set) Token: 0x0600BBBF RID: 48063 RVA: 0x001B14D4 File Offset: 0x001AF6D4
		public virtual IRemovePreloadResourceCharacterType RemovePreloadResourceObjectType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RemovePreloadResourceObjectType;
				}
				RemovePreloadResourceAction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RemovePreloadResourceObjectType;
			}
			set
			{
				this.GetOrCreatePoco().RemovePreloadResourceObjectType = value;
			}
		}

		// Token: 0x04007037 RID: 28727
		[Nullable(2)]
		protected new RemovePreloadResourceAction FbInstance;

		// Token: 0x04007038 RID: 28728
		[Nullable(2)]
		protected RemovePreloadResourceAction_SetValue PocoInterface;
	}
}
