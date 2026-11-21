using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001658 RID: 5720
	public class ClientFollowShooterLeisureInteract : ActionParams
	{
		// Token: 0x060080F9 RID: 33017 RVA: 0x00132A50 File Offset: 0x00130C50
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

		// Token: 0x060080FA RID: 33018 RVA: 0x00132A88 File Offset: 0x00130C88
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

		// Token: 0x060080FB RID: 33019 RVA: 0x00132A9B File Offset: 0x00130C9B
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

		// Token: 0x060080FC RID: 33020 RVA: 0x00132AAE File Offset: 0x00130CAE
		public ClientFollowShooterLeisureInteract_SetValue ToSetValue()
		{
			return new ClientFollowShooterLeisureInteract_SetValue
			{
				Id = this.Id,
				InteractType = this.InteractType
			};
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x060080FD RID: 33021 RVA: 0x00132ACD File Offset: 0x00130CCD
		// (set) Token: 0x060080FE RID: 33022 RVA: 0x00132AF8 File Offset: 0x00130CF8
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

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x00132B06 File Offset: 0x00130D06
		// (set) Token: 0x06008100 RID: 33024 RVA: 0x00132B2D File Offset: 0x00130D2D
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

		// Token: 0x04004A68 RID: 19048
		[Nullable(2)]
		protected new ClientFollowShooterLeisureInteract FbInstance;

		// Token: 0x04004A69 RID: 19049
		[Nullable(2)]
		protected ClientFollowShooterLeisureInteract_SetValue PocoInterface;
	}
}
