using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200117F RID: 4479
	public class IPlayerHavingItemCount : IBindingProgressType
	{
		// Token: 0x06006388 RID: 25480 RVA: 0x000EF810 File Offset: 0x000EDA10
		private IPlayerHavingItemCount_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerHavingItemCount 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerHavingItemCount_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerHavingItemCount_SetValue());
			}
			return result;
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x000EF848 File Offset: 0x000EDA48
		public static IPlayerHavingItemCount Create([Nullable(2)] IPlayerHavingItemCount instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerHavingItemCount
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x000EF85B File Offset: 0x000EDA5B
		public static IPlayerHavingItemCount CreateFromSetValue([Nullable(2)] IPlayerHavingItemCount_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerHavingItemCount
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x000EF86E File Offset: 0x000EDA6E
		public new IPlayerHavingItemCount_SetValue ToSetValue()
		{
			return new IPlayerHavingItemCount_SetValue
			{
				Type = this.Type,
				ItemId = this.ItemId
			};
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600638C RID: 25484 RVA: 0x000EF88D File Offset: 0x000EDA8D
		// (set) Token: 0x0600638D RID: 25485 RVA: 0x000EF8B8 File Offset: 0x000EDAB8
		public override EBindingProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBindingProgressType.PlayerHavingItemCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600638E RID: 25486 RVA: 0x000EF8C6 File Offset: 0x000EDAC6
		// (set) Token: 0x0600638F RID: 25487 RVA: 0x000EF8F1 File Offset: 0x000EDAF1
		public virtual int ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x04003BA0 RID: 15264
		[Nullable(2)]
		protected new IPlayerHavingItemCount FbInstance;

		// Token: 0x04003BA1 RID: 15265
		[Nullable(2)]
		protected new IPlayerHavingItemCount_SetValue PocoInterface;
	}
}
