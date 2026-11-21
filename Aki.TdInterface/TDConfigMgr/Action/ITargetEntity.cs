using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C7 RID: 8647
	public class ITargetEntity : ITargetEntityType
	{
		// Token: 0x0600BC80 RID: 48256 RVA: 0x001B4690 File Offset: 0x001B2890
		private ITargetEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC81 RID: 48257 RVA: 0x001B46C8 File Offset: 0x001B28C8
		public static ITargetEntity Create([Nullable(2)] ITargetEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC82 RID: 48258 RVA: 0x001B46DB File Offset: 0x001B28DB
		public static ITargetEntity CreateFromSetValue([Nullable(2)] ITargetEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC83 RID: 48259 RVA: 0x001B46EE File Offset: 0x001B28EE
		public new ITargetEntity_SetValue ToSetValue()
		{
			return new ITargetEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600BC84 RID: 48260 RVA: 0x001B470D File Offset: 0x001B290D
		// (set) Token: 0x0600BC85 RID: 48261 RVA: 0x001B4738 File Offset: 0x001B2938
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x001B4746 File Offset: 0x001B2946
		// (set) Token: 0x0600BC87 RID: 48263 RVA: 0x001B4771 File Offset: 0x001B2971
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

		// Token: 0x0400714E RID: 29006
		[Nullable(2)]
		protected new ITargetEntity FbInstance;

		// Token: 0x0400714F RID: 29007
		[Nullable(2)]
		protected new ITargetEntity_SetValue PocoInterface;
	}
}
