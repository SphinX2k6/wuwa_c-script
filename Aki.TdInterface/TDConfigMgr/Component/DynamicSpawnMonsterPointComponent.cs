using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000064 RID: 100
	public class DynamicSpawnMonsterPointComponent : IComponentBase
	{
		// Token: 0x0600033E RID: 830 RVA: 0x0001BF68 File Offset: 0x0001A168
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

		// Token: 0x0600033F RID: 831 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
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

		// Token: 0x06000340 RID: 832 RVA: 0x0001BFB3 File Offset: 0x0001A1B3
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

		// Token: 0x06000341 RID: 833 RVA: 0x0001BFC6 File Offset: 0x0001A1C6
		public new DynamicSpawnMonsterPointComponent_SetValue ToSetValue()
		{
			return new DynamicSpawnMonsterPointComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TagId = this.TagId
			};
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0001C02E File Offset: 0x0001A22E
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0001C03C File Offset: 0x0001A23C
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0001C066 File Offset: 0x0001A266
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0001C074 File Offset: 0x0001A274
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0001C0AE File Offset: 0x0001A2AE
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

		// Token: 0x0400020F RID: 527
		[Nullable(2)]
		protected new DynamicSpawnMonsterPointComponent FbInstance;

		// Token: 0x04000210 RID: 528
		[Nullable(2)]
		protected new DynamicSpawnMonsterPointComponent_SetValue PocoInterface;
	}
}
