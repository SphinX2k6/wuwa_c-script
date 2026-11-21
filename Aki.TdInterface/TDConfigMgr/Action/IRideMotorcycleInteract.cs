using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD5 RID: 8149
	public class IRideMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x0600AD21 RID: 44321 RVA: 0x00186FA0 File Offset: 0x001851A0
		private IRideMotorcycleInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRideMotorcycleInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRideMotorcycleInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRideMotorcycleInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD22 RID: 44322 RVA: 0x00186FD8 File Offset: 0x001851D8
		public static IRideMotorcycleInteract Create([Nullable(2)] IRideMotorcycleInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRideMotorcycleInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD23 RID: 44323 RVA: 0x00186FEB File Offset: 0x001851EB
		public static IRideMotorcycleInteract CreateFromSetValue([Nullable(2)] IRideMotorcycleInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRideMotorcycleInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD24 RID: 44324 RVA: 0x00186FFE File Offset: 0x001851FE
		public new IRideMotorcycleInteract_SetValue ToSetValue()
		{
			return new IRideMotorcycleInteract_SetValue
			{
				Type = this.Type,
				MotorcycleEntityId = this.MotorcycleEntityId
			};
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600AD25 RID: 44325 RVA: 0x0018701D File Offset: 0x0018521D
		// (set) Token: 0x0600AD26 RID: 44326 RVA: 0x00187048 File Offset: 0x00185248
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

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600AD27 RID: 44327 RVA: 0x00187056 File Offset: 0x00185256
		// (set) Token: 0x0600AD28 RID: 44328 RVA: 0x00187081 File Offset: 0x00185281
		public virtual int MotorcycleEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotorcycleEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MotorcycleEntityId;
			}
			set
			{
				this.GetOrCreatePoco().MotorcycleEntityId = value;
			}
		}

		// Token: 0x04006760 RID: 26464
		[Nullable(2)]
		protected new IRideMotorcycleInteract FbInstance;

		// Token: 0x04006761 RID: 26465
		[Nullable(2)]
		protected new IRideMotorcycleInteract_SetValue PocoInterface;
	}
}
