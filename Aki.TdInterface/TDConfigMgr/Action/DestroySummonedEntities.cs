using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016C7 RID: 5831
	public class DestroySummonedEntities : ActionParams
	{
		// Token: 0x060082A1 RID: 33441 RVA: 0x0013907C File Offset: 0x0013727C
		private DestroySummonedEntities_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroySummonedEntities 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroySummonedEntities_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroySummonedEntities_SetValue());
			}
			return result;
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x001390B4 File Offset: 0x001372B4
		public static DestroySummonedEntities Create([Nullable(2)] DestroySummonedEntities instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroySummonedEntities
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x001390C7 File Offset: 0x001372C7
		public static DestroySummonedEntities CreateFromSetValue([Nullable(2)] DestroySummonedEntities_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroySummonedEntities
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x001390DA File Offset: 0x001372DA
		public DestroySummonedEntities_SetValue ToSetValue()
		{
			return new DestroySummonedEntities_SetValue
			{
				DestroyEntitiesConfig = this.DestroyEntitiesConfig
			};
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x060082A5 RID: 33445 RVA: 0x001390F0 File Offset: 0x001372F0
		// (set) Token: 0x060082A6 RID: 33446 RVA: 0x00139151 File Offset: 0x00137351
		public virtual IDestroySummonedVehicle DestroyEntitiesConfig
		{
			get
			{
				if (this._DestroyEntitiesConfigInited)
				{
					return this._DestroyEntitiesConfigCache;
				}
				this._DestroyEntitiesConfigInited = true;
				if (this.FbInstance != null)
				{
					this._DestroyEntitiesConfigCache = IDestroySummonedVehicle.Create(this.FbInstance.DestroyEntitiesConfig);
				}
				else
				{
					DestroySummonedEntities_SetValue pocoInterface = this.PocoInterface;
					this._DestroyEntitiesConfigCache = ((pocoInterface != null) ? pocoInterface.DestroyEntitiesConfig : null);
				}
				return this._DestroyEntitiesConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().DestroyEntitiesConfig = value;
				this._DestroyEntitiesConfigInited = false;
			}
		}

		// Token: 0x04004ADE RID: 19166
		[Nullable(2)]
		protected new DestroySummonedEntities FbInstance;

		// Token: 0x04004ADF RID: 19167
		[Nullable(2)]
		protected DestroySummonedEntities_SetValue PocoInterface;

		// Token: 0x04004AE0 RID: 19168
		private IDestroySummonedVehicle _DestroyEntitiesConfigCache;

		// Token: 0x04004AE1 RID: 19169
		private bool _DestroyEntitiesConfigInited;
	}
}
