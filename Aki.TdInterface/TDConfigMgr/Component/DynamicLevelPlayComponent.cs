using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005E RID: 94
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicLevelPlayComponent : IComponentBase
	{
		// Token: 0x06000316 RID: 790 RVA: 0x0001B144 File Offset: 0x00019344
		private DynamicLevelPlayComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicLevelPlayComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicLevelPlayComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicLevelPlayComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0001B17C File Offset: 0x0001937C
		public static DynamicLevelPlayComponent Create([Nullable(2)] DynamicLevelPlayComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicLevelPlayComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0001B18F File Offset: 0x0001938F
		public static DynamicLevelPlayComponent CreateFromSetValue([Nullable(2)] DynamicLevelPlayComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicLevelPlayComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0001B1A2 File Offset: 0x000193A2
		public new DynamicLevelPlayComponent_SetValue ToSetValue()
		{
			return new DynamicLevelPlayComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DynamicLevelPlayId = this.DynamicLevelPlayId
			};
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001B1D0 File Offset: 0x000193D0
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0001B20A File Offset: 0x0001940A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicLevelPlayComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001B218 File Offset: 0x00019418
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0001B242 File Offset: 0x00019442
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001B250 File Offset: 0x00019450
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0001B27B File Offset: 0x0001947B
		public virtual int DynamicLevelPlayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicLevelPlayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DynamicLevelPlayId;
			}
			set
			{
				this.GetOrCreatePoco().DynamicLevelPlayId = value;
			}
		}

		// Token: 0x040001F7 RID: 503
		[Nullable(2)]
		protected new DynamicLevelPlayComponent FbInstance;

		// Token: 0x040001F8 RID: 504
		[Nullable(2)]
		protected new DynamicLevelPlayComponent_SetValue PocoInterface;
	}
}
