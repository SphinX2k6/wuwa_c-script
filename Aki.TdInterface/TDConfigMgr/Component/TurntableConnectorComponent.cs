using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000975 RID: 2421
	public class TurntableConnectorComponent : IComponentBase
	{
		// Token: 0x0600364D RID: 13901 RVA: 0x0008A468 File Offset: 0x00088668
		private TurntableConnectorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TurntableConnectorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TurntableConnectorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TurntableConnectorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x0008A4A0 File Offset: 0x000886A0
		public static TurntableConnectorComponent Create([Nullable(2)] TurntableConnectorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TurntableConnectorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x0008A4B3 File Offset: 0x000886B3
		public static TurntableConnectorComponent CreateFromSetValue([Nullable(2)] TurntableConnectorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TurntableConnectorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0008A4C6 File Offset: 0x000886C6
		public new TurntableConnectorComponent_SetValue ToSetValue()
		{
			return new TurntableConnectorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Gameplay = this.Gameplay
			};
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x0008A4F4 File Offset: 0x000886F4
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x0008A52E File Offset: 0x0008872E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TurntableConnectorComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x0008A53C File Offset: 0x0008873C
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x0008A566 File Offset: 0x00088766
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x0008A574 File Offset: 0x00088774
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x0008A5D5 File Offset: 0x000887D5
		public virtual ICircuitConnect Gameplay
		{
			get
			{
				if (this._GameplayInited)
				{
					return this._GameplayCache;
				}
				this._GameplayInited = true;
				if (this.FbInstance != null)
				{
					this._GameplayCache = ICircuitConnect.Create(this.FbInstance.Gameplay);
				}
				else
				{
					TurntableConnectorComponent_SetValue pocoInterface = this.PocoInterface;
					this._GameplayCache = ((pocoInterface != null) ? pocoInterface.Gameplay : null);
				}
				return this._GameplayCache;
			}
			set
			{
				this.GetOrCreatePoco().Gameplay = value;
				this._GameplayInited = false;
			}
		}

		// Token: 0x04002396 RID: 9110
		[Nullable(2)]
		protected new TurntableConnectorComponent FbInstance;

		// Token: 0x04002397 RID: 9111
		[Nullable(2)]
		protected new TurntableConnectorComponent_SetValue PocoInterface;

		// Token: 0x04002398 RID: 9112
		private ICircuitConnect _GameplayCache;

		// Token: 0x04002399 RID: 9113
		private bool _GameplayInited;
	}
}
