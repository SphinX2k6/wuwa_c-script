using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001051 RID: 4177
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerHavingItemCount : IBindingProgressType
	{
		// Token: 0x06005D96 RID: 23958 RVA: 0x000E283C File Offset: 0x000E0A3C
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

		// Token: 0x06005D97 RID: 23959 RVA: 0x000E2874 File Offset: 0x000E0A74
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

		// Token: 0x06005D98 RID: 23960 RVA: 0x000E2887 File Offset: 0x000E0A87
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

		// Token: 0x06005D99 RID: 23961 RVA: 0x000E289A File Offset: 0x000E0A9A
		public new IPlayerHavingItemCount_SetValue ToSetValue()
		{
			return new IPlayerHavingItemCount_SetValue
			{
				Type = this.Type,
				ItemId = this.ItemId
			};
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x000E28B9 File Offset: 0x000E0AB9
		// (set) Token: 0x06005D9B RID: 23963 RVA: 0x000E28E4 File Offset: 0x000E0AE4
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

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06005D9C RID: 23964 RVA: 0x000E28F2 File Offset: 0x000E0AF2
		// (set) Token: 0x06005D9D RID: 23965 RVA: 0x000E291D File Offset: 0x000E0B1D
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

		// Token: 0x04003858 RID: 14424
		[Nullable(2)]
		protected new IPlayerHavingItemCount FbInstance;

		// Token: 0x04003859 RID: 14425
		[Nullable(2)]
		protected new IPlayerHavingItemCount_SetValue PocoInterface;
	}
}
