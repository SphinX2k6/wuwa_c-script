using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000FF RID: 255
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityListComponent : IComponentBase
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		private EntityListComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityListComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityListComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityListComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001D504 File Offset: 0x0001B704
		public static EntityListComponent Create([Nullable(2)] EntityListComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityListComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001D517 File Offset: 0x0001B717
		public static EntityListComponent CreateFromSetValue([Nullable(2)] EntityListComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityListComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001D52A File Offset: 0x0001B72A
		public new EntityListComponent_SetValue ToSetValue()
		{
			return new EntityListComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001D54C File Offset: 0x0001B74C
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0001D586 File Offset: 0x0001B786
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityListComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001D594 File Offset: 0x0001B794
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x0001D5BE File Offset: 0x0001B7BE
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

		// Token: 0x04000555 RID: 1365
		[Nullable(2)]
		protected new EntityListComponent FbInstance;

		// Token: 0x04000556 RID: 1366
		[Nullable(2)]
		protected new EntityListComponent_SetValue PocoInterface;
	}
}
