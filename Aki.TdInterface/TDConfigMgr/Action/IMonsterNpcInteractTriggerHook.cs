using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BFA RID: 7162
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractTriggerHook : IMonsterNpcInteractConfigBase
	{
		// Token: 0x0600995D RID: 39261 RVA: 0x00160F14 File Offset: 0x0015F114
		private IMonsterNpcInteractTriggerHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractTriggerHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractTriggerHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractTriggerHook_SetValue());
			}
			return result;
		}

		// Token: 0x0600995E RID: 39262 RVA: 0x00160F4C File Offset: 0x0015F14C
		public static IMonsterNpcInteractTriggerHook Create([Nullable(2)] IMonsterNpcInteractTriggerHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractTriggerHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x00160F5F File Offset: 0x0015F15F
		public static IMonsterNpcInteractTriggerHook CreateFromSetValue([Nullable(2)] IMonsterNpcInteractTriggerHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractTriggerHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x00160F72 File Offset: 0x0015F172
		public new IMonsterNpcInteractTriggerHook_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractTriggerHook_SetValue
			{
				Type = this.Type,
				HookEntityId = this.HookEntityId
			};
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x06009961 RID: 39265 RVA: 0x00160F91 File Offset: 0x0015F191
		// (set) Token: 0x06009962 RID: 39266 RVA: 0x00160FBC File Offset: 0x0015F1BC
		public override EMonsterNpcInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractType.TriggerHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x06009963 RID: 39267 RVA: 0x00160FCA File Offset: 0x0015F1CA
		// (set) Token: 0x06009964 RID: 39268 RVA: 0x00160FF5 File Offset: 0x0015F1F5
		public virtual int HookEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HookEntityId;
			}
			set
			{
				this.GetOrCreatePoco().HookEntityId = value;
			}
		}

		// Token: 0x04005D61 RID: 23905
		[Nullable(2)]
		protected new IMonsterNpcInteractTriggerHook FbInstance;

		// Token: 0x04005D62 RID: 23906
		[Nullable(2)]
		protected new IMonsterNpcInteractTriggerHook_SetValue PocoInterface;
	}
}
