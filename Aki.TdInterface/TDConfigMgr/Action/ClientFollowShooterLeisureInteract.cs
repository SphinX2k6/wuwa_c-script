using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014FD RID: 5373
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientFollowShooterLeisureInteract : ActionParams
	{
		// Token: 0x06007A26 RID: 31270 RVA: 0x00123D70 File Offset: 0x00121F70
		private ClientFollowShooterLeisureInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientFollowShooterLeisureInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientFollowShooterLeisureInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientFollowShooterLeisureInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x00123DA8 File Offset: 0x00121FA8
		public static ClientFollowShooterLeisureInteract Create([Nullable(2)] ClientFollowShooterLeisureInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientFollowShooterLeisureInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x00123DBB File Offset: 0x00121FBB
		public static ClientFollowShooterLeisureInteract CreateFromSetValue([Nullable(2)] ClientFollowShooterLeisureInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientFollowShooterLeisureInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x00123DCE File Offset: 0x00121FCE
		public ClientFollowShooterLeisureInteract_SetValue ToSetValue()
		{
			return new ClientFollowShooterLeisureInteract_SetValue
			{
				Id = this.Id,
				InteractType = this.InteractType
			};
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x06007A2A RID: 31274 RVA: 0x00123DED File Offset: 0x00121FED
		// (set) Token: 0x06007A2B RID: 31275 RVA: 0x00123E18 File Offset: 0x00122018
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x06007A2C RID: 31276 RVA: 0x00123E26 File Offset: 0x00122026
		// (set) Token: 0x06007A2D RID: 31277 RVA: 0x00123E4D File Offset: 0x0012204D
		public virtual IClientFollowShooterLeisureInteractType InteractType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractType;
				}
				ClientFollowShooterLeisureInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractType;
			}
			set
			{
				this.GetOrCreatePoco().InteractType = value;
			}
		}

		// Token: 0x040046C9 RID: 18121
		[Nullable(2)]
		protected new ClientFollowShooterLeisureInteract FbInstance;

		// Token: 0x040046CA RID: 18122
		[Nullable(2)]
		protected ClientFollowShooterLeisureInteract_SetValue PocoInterface;
	}
}
