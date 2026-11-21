using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF9 RID: 6905
	public class IDartPlayableRoleInteractType : IDartInteractTypeBase
	{
		// Token: 0x060092A9 RID: 37545 RVA: 0x00157808 File Offset: 0x00155A08
		private IDartPlayableRoleInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDartPlayableRoleInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDartPlayableRoleInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDartPlayableRoleInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x00157840 File Offset: 0x00155A40
		public static IDartPlayableRoleInteractType Create([Nullable(2)] IDartPlayableRoleInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartPlayableRoleInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x00157853 File Offset: 0x00155A53
		public static IDartPlayableRoleInteractType CreateFromSetValue([Nullable(2)] IDartPlayableRoleInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDartPlayableRoleInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00157866 File Offset: 0x00155A66
		public new IDartPlayableRoleInteractType_SetValue ToSetValue()
		{
			return new IDartPlayableRoleInteractType_SetValue
			{
				Type = this.Type,
				CompetitorId = this.CompetitorId,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x060092AD RID: 37549 RVA: 0x00157891 File Offset: 0x00155A91
		// (set) Token: 0x060092AE RID: 37550 RVA: 0x001578BC File Offset: 0x00155ABC
		public override EDartInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDartInteractType.Machine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x060092AF RID: 37551 RVA: 0x001578CA File Offset: 0x00155ACA
		// (set) Token: 0x060092B0 RID: 37552 RVA: 0x001578F5 File Offset: 0x00155AF5
		public virtual int CompetitorId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompetitorId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CompetitorId;
			}
			set
			{
				this.GetOrCreatePoco().CompetitorId = value;
			}
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x060092B1 RID: 37553 RVA: 0x00157904 File Offset: 0x00155B04
		// (set) Token: 0x060092B2 RID: 37554 RVA: 0x0015793E File Offset: 0x00155B3E
		public virtual int? TargetEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntityId;
				}
				IDartPlayableRoleInteractType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntityId = value;
			}
		}

		// Token: 0x04005B52 RID: 23378
		[Nullable(2)]
		protected new IDartPlayableRoleInteractType FbInstance;

		// Token: 0x04005B53 RID: 23379
		[Nullable(2)]
		protected new IDartPlayableRoleInteractType_SetValue PocoInterface;
	}
}
