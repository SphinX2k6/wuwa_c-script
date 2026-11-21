using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B3 RID: 9139
	public class RemovePreloadResourceAction : ActionParams
	{
		// Token: 0x0600C748 RID: 51016 RVA: 0x001C85F0 File Offset: 0x001C67F0
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

		// Token: 0x0600C749 RID: 51017 RVA: 0x001C8628 File Offset: 0x001C6828
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

		// Token: 0x0600C74A RID: 51018 RVA: 0x001C863B File Offset: 0x001C683B
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

		// Token: 0x0600C74B RID: 51019 RVA: 0x001C864E File Offset: 0x001C684E
		public RemovePreloadResourceAction_SetValue ToSetValue()
		{
			return new RemovePreloadResourceAction_SetValue
			{
				RemovePreloadResourceObjectType = this.RemovePreloadResourceObjectType
			};
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0600C74C RID: 51020 RVA: 0x001C8661 File Offset: 0x001C6861
		// (set) Token: 0x0600C74D RID: 51021 RVA: 0x001C8688 File Offset: 0x001C6888
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

		// Token: 0x0400766C RID: 30316
		[Nullable(2)]
		protected new RemovePreloadResourceAction FbInstance;

		// Token: 0x0400766D RID: 30317
		[Nullable(2)]
		protected RemovePreloadResourceAction_SetValue PocoInterface;
	}
}
