using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B6C RID: 7020
	[NullableContext(1)]
	[Nullable(0)]
	public class IKiteHookInteract : ILeisureInteractType
	{
		// Token: 0x0600965B RID: 38491 RVA: 0x0015B5F4 File Offset: 0x001597F4
		private IKiteHookInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKiteHookInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKiteHookInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKiteHookInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x0015B62C File Offset: 0x0015982C
		public static IKiteHookInteract Create([Nullable(2)] IKiteHookInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKiteHookInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x0015B63F File Offset: 0x0015983F
		public static IKiteHookInteract CreateFromSetValue([Nullable(2)] IKiteHookInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKiteHookInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600965E RID: 38494 RVA: 0x0015B652 File Offset: 0x00159852
		public new IKiteHookInteract_SetValue ToSetValue()
		{
			return new IKiteHookInteract_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600965F RID: 38495 RVA: 0x0015B671 File Offset: 0x00159871
		// (set) Token: 0x06009660 RID: 38496 RVA: 0x0015B69C File Offset: 0x0015989C
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x06009661 RID: 38497 RVA: 0x0015B6AA File Offset: 0x001598AA
		// (set) Token: 0x06009662 RID: 38498 RVA: 0x0015B6D5 File Offset: 0x001598D5
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

		// Token: 0x04005BF3 RID: 23539
		[Nullable(2)]
		protected new IKiteHookInteract FbInstance;

		// Token: 0x04005BF4 RID: 23540
		[Nullable(2)]
		protected new IKiteHookInteract_SetValue PocoInterface;
	}
}
