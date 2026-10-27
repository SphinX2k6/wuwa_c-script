using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002244 RID: 8772
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleEntityElementalAbility : ActionParams
	{
		// Token: 0x0600C082 RID: 49282 RVA: 0x001BA364 File Offset: 0x001B8564
		private ToggleEntityElementalAbility_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleEntityElementalAbility 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleEntityElementalAbility_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleEntityElementalAbility_SetValue());
			}
			return result;
		}

		// Token: 0x0600C083 RID: 49283 RVA: 0x001BA39C File Offset: 0x001B859C
		public static ToggleEntityElementalAbility Create([Nullable(2)] ToggleEntityElementalAbility instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleEntityElementalAbility
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C084 RID: 49284 RVA: 0x001BA3AF File Offset: 0x001B85AF
		public static ToggleEntityElementalAbility CreateFromSetValue([Nullable(2)] ToggleEntityElementalAbility_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleEntityElementalAbility
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C085 RID: 49285 RVA: 0x001BA3C2 File Offset: 0x001B85C2
		public ToggleEntityElementalAbility_SetValue ToSetValue()
		{
			return new ToggleEntityElementalAbility_SetValue
			{
				EntityId = this.EntityId,
				Enable = this.Enable
			};
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0600C086 RID: 49286 RVA: 0x001BA3E1 File Offset: 0x001B85E1
		// (set) Token: 0x0600C087 RID: 49287 RVA: 0x001BA40C File Offset: 0x001B860C
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

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0600C088 RID: 49288 RVA: 0x001BA41A File Offset: 0x001B861A
		// (set) Token: 0x0600C089 RID: 49289 RVA: 0x001BA445 File Offset: 0x001B8645
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x040072C6 RID: 29382
		[Nullable(2)]
		protected new ToggleEntityElementalAbility FbInstance;

		// Token: 0x040072C7 RID: 29383
		[Nullable(2)]
		protected ToggleEntityElementalAbility_SetValue PocoInterface;
	}
}
