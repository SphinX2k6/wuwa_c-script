using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001569 RID: 5481
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroySummonedEntities : ActionParams
	{
		// Token: 0x06007BC3 RID: 31683 RVA: 0x00129FD0 File Offset: 0x001281D0
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

		// Token: 0x06007BC4 RID: 31684 RVA: 0x0012A008 File Offset: 0x00128208
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

		// Token: 0x06007BC5 RID: 31685 RVA: 0x0012A01B File Offset: 0x0012821B
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

		// Token: 0x06007BC6 RID: 31686 RVA: 0x0012A02E File Offset: 0x0012822E
		public DestroySummonedEntities_SetValue ToSetValue()
		{
			return new DestroySummonedEntities_SetValue
			{
				DestroyEntitiesConfig = this.DestroyEntitiesConfig
			};
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x06007BC7 RID: 31687 RVA: 0x0012A044 File Offset: 0x00128244
		// (set) Token: 0x06007BC8 RID: 31688 RVA: 0x0012A0A5 File Offset: 0x001282A5
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

		// Token: 0x0400473E RID: 18238
		[Nullable(2)]
		protected new DestroySummonedEntities FbInstance;

		// Token: 0x0400473F RID: 18239
		[Nullable(2)]
		protected DestroySummonedEntities_SetValue PocoInterface;

		// Token: 0x04004740 RID: 18240
		private IDestroySummonedVehicle _DestroyEntitiesConfigCache;

		// Token: 0x04004741 RID: 18241
		private bool _DestroyEntitiesConfigInited;
	}
}
