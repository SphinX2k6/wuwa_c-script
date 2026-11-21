using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000108 RID: 264
	public class EntityListComponent : IComponentBase
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x0001DE40 File Offset: 0x0001C040
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

		// Token: 0x0600041B RID: 1051 RVA: 0x0001DE78 File Offset: 0x0001C078
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

		// Token: 0x0600041C RID: 1052 RVA: 0x0001DE8B File Offset: 0x0001C08B
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

		// Token: 0x0600041D RID: 1053 RVA: 0x0001DE9E File Offset: 0x0001C09E
		public new EntityListComponent_SetValue ToSetValue()
		{
			return new EntityListComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x0001DEFA File Offset: 0x0001C0FA
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001DF08 File Offset: 0x0001C108
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0001DF32 File Offset: 0x0001C132
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

		// Token: 0x0400057F RID: 1407
		[Nullable(2)]
		protected new EntityListComponent FbInstance;

		// Token: 0x04000580 RID: 1408
		[Nullable(2)]
		protected new EntityListComponent_SetValue PocoInterface;
	}
}
