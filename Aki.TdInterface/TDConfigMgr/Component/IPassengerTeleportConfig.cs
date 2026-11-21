using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200062B RID: 1579
	public class IPassengerTeleportConfig
	{
		// Token: 0x0600213C RID: 8508 RVA: 0x0005CBFC File Offset: 0x0005ADFC
		private IPassengerTeleportConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPassengerTeleportConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPassengerTeleportConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPassengerTeleportConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x0005CC34 File Offset: 0x0005AE34
		public static IPassengerTeleportConfig Create([Nullable(2)] IPassengerTeleportConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPassengerTeleportConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0005CC47 File Offset: 0x0005AE47
		public static IPassengerTeleportConfig CreateFromSetValue([Nullable(2)] IPassengerTeleportConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPassengerTeleportConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0005CC5A File Offset: 0x0005AE5A
		public IPassengerTeleportConfig_SetValue ToSetValue()
		{
			return new IPassengerTeleportConfig_SetValue
			{
				PosA = this.PosA
			};
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0005CC70 File Offset: 0x0005AE70
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0005CCD1 File Offset: 0x0005AED1
		[Nullable(2)]
		public virtual PosA PosA
		{
			[NullableContext(2)]
			get
			{
				if (this._PosAInited)
				{
					return this._PosACache;
				}
				this._PosAInited = true;
				if (this.FbInstance != null)
				{
					this._PosACache = PosA.Create(this.FbInstance.PosA);
				}
				else
				{
					IPassengerTeleportConfig_SetValue pocoInterface = this.PocoInterface;
					this._PosACache = ((pocoInterface != null) ? pocoInterface.PosA : null);
				}
				return this._PosACache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PosA = value;
				this._PosAInited = false;
			}
		}

		// Token: 0x0400178D RID: 6029
		[Nullable(2)]
		protected IPassengerTeleportConfig FbInstance;

		// Token: 0x0400178E RID: 6030
		[Nullable(2)]
		protected IPassengerTeleportConfig_SetValue PocoInterface;

		// Token: 0x0400178F RID: 6031
		private PosA _PosACache;

		// Token: 0x04001790 RID: 6032
		private bool _PosAInited;
	}
}
