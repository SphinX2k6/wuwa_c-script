using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000064 RID: 100
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicSpawnMonsterPointComponent : IComponentBase
	{
		// Token: 0x0600033A RID: 826 RVA: 0x0001B5F4 File Offset: 0x000197F4
		private DynamicSpawnMonsterPointComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicSpawnMonsterPointComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicSpawnMonsterPointComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicSpawnMonsterPointComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001B62C File Offset: 0x0001982C
		public static DynamicSpawnMonsterPointComponent Create([Nullable(2)] DynamicSpawnMonsterPointComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterPointComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001B63F File Offset: 0x0001983F
		public static DynamicSpawnMonsterPointComponent CreateFromSetValue([Nullable(2)] DynamicSpawnMonsterPointComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterPointComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001B652 File Offset: 0x00019852
		public new DynamicSpawnMonsterPointComponent_SetValue ToSetValue()
		{
			return new DynamicSpawnMonsterPointComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TagId = this.TagId
			};
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001B680 File Offset: 0x00019880
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0001B6BA File Offset: 0x000198BA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicSpawnMonsterPointComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001B6C8 File Offset: 0x000198C8
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0001B6F2 File Offset: 0x000198F2
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

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001B700 File Offset: 0x00019900
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0001B73A File Offset: 0x0001993A
		public virtual int? TagId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagId;
				}
				DynamicSpawnMonsterPointComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TagId;
			}
			set
			{
				this.GetOrCreatePoco().TagId = value;
			}
		}

		// Token: 0x0400020A RID: 522
		[Nullable(2)]
		protected new DynamicSpawnMonsterPointComponent FbInstance;

		// Token: 0x0400020B RID: 523
		[Nullable(2)]
		protected new DynamicSpawnMonsterPointComponent_SetValue PocoInterface;
	}
}
