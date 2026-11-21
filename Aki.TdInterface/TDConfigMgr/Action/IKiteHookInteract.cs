using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D19 RID: 7449
	public class IKiteHookInteract : ILeisureInteractType
	{
		// Token: 0x06009E3D RID: 40509 RVA: 0x0016C1A0 File Offset: 0x0016A3A0
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

		// Token: 0x06009E3E RID: 40510 RVA: 0x0016C1D8 File Offset: 0x0016A3D8
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

		// Token: 0x06009E3F RID: 40511 RVA: 0x0016C1EB File Offset: 0x0016A3EB
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

		// Token: 0x06009E40 RID: 40512 RVA: 0x0016C1FE File Offset: 0x0016A3FE
		public new IKiteHookInteract_SetValue ToSetValue()
		{
			return new IKiteHookInteract_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x06009E41 RID: 40513 RVA: 0x0016C21D File Offset: 0x0016A41D
		// (set) Token: 0x06009E42 RID: 40514 RVA: 0x0016C248 File Offset: 0x0016A448
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

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x06009E43 RID: 40515 RVA: 0x0016C256 File Offset: 0x0016A456
		// (set) Token: 0x06009E44 RID: 40516 RVA: 0x0016C281 File Offset: 0x0016A481
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

		// Token: 0x0400608C RID: 24716
		[Nullable(2)]
		protected new IKiteHookInteract FbInstance;

		// Token: 0x0400608D RID: 24717
		[Nullable(2)]
		protected new IKiteHookInteract_SetValue PocoInterface;
	}
}
