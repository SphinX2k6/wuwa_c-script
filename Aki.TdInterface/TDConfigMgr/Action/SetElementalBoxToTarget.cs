using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021AB RID: 8619
	[NullableContext(1)]
	[Nullable(0)]
	public class SetElementalBoxToTarget : ActionParams
	{
		// Token: 0x0600BD44 RID: 48452 RVA: 0x001B3E64 File Offset: 0x001B2064
		private SetElementalBoxToTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetElementalBoxToTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetElementalBoxToTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetElementalBoxToTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD45 RID: 48453 RVA: 0x001B3E9C File Offset: 0x001B209C
		public static SetElementalBoxToTarget Create([Nullable(2)] SetElementalBoxToTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetElementalBoxToTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x001B3EAF File Offset: 0x001B20AF
		public static SetElementalBoxToTarget CreateFromSetValue([Nullable(2)] SetElementalBoxToTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetElementalBoxToTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x001B3EC2 File Offset: 0x001B20C2
		public SetElementalBoxToTarget_SetValue ToSetValue()
		{
			return new SetElementalBoxToTarget_SetValue
			{
				ElementalBoxId = this.ElementalBoxId,
				Target = this.Target
			};
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x001B3EE1 File Offset: 0x001B20E1
		// (set) Token: 0x0600BD49 RID: 48457 RVA: 0x001B3F0C File Offset: 0x001B210C
		public virtual int ElementalBoxId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ElementalBoxId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ElementalBoxId;
			}
			set
			{
				this.GetOrCreatePoco().ElementalBoxId = value;
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0600BD4A RID: 48458 RVA: 0x001B3F1A File Offset: 0x001B211A
		// (set) Token: 0x0600BD4B RID: 48459 RVA: 0x001B3F41 File Offset: 0x001B2141
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				SetElementalBoxToTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x040070EF RID: 28911
		[Nullable(2)]
		protected new SetElementalBoxToTarget FbInstance;

		// Token: 0x040070F0 RID: 28912
		[Nullable(2)]
		protected SetElementalBoxToTarget_SetValue PocoInterface;
	}
}
