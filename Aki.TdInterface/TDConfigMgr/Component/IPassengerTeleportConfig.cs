using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C0 RID: 1472
	[NullableContext(1)]
	[Nullable(0)]
	public class IPassengerTeleportConfig
	{
		// Token: 0x06001F2C RID: 7980 RVA: 0x00057BD0 File Offset: 0x00055DD0
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

		// Token: 0x06001F2D RID: 7981 RVA: 0x00057C08 File Offset: 0x00055E08
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

		// Token: 0x06001F2E RID: 7982 RVA: 0x00057C1B File Offset: 0x00055E1B
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

		// Token: 0x06001F2F RID: 7983 RVA: 0x00057C2E File Offset: 0x00055E2E
		public IPassengerTeleportConfig_SetValue ToSetValue()
		{
			return new IPassengerTeleportConfig_SetValue
			{
				PosA = this.PosA
			};
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00057C44 File Offset: 0x00055E44
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x00057CA5 File Offset: 0x00055EA5
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

		// Token: 0x04001619 RID: 5657
		[Nullable(2)]
		protected IPassengerTeleportConfig FbInstance;

		// Token: 0x0400161A RID: 5658
		[Nullable(2)]
		protected IPassengerTeleportConfig_SetValue PocoInterface;

		// Token: 0x0400161B RID: 5659
		private PosA _PosACache;

		// Token: 0x0400161C RID: 5660
		private bool _PosAInited;
	}
}
