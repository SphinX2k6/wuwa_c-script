using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097B RID: 2427
	public class UnUseComponent : IComponentBase
	{
		// Token: 0x06003677 RID: 13943 RVA: 0x0008A9EC File Offset: 0x00088BEC
		private UnUseComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UnUseComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UnUseComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UnUseComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x0008AA24 File Offset: 0x00088C24
		public static UnUseComponent Create([Nullable(2)] UnUseComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnUseComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x0008AA37 File Offset: 0x00088C37
		public static UnUseComponent CreateFromSetValue([Nullable(2)] UnUseComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UnUseComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x0008AA4A File Offset: 0x00088C4A
		public new UnUseComponent_SetValue ToSetValue()
		{
			return new UnUseComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x0008AA6C File Offset: 0x00088C6C
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x0008AAA6 File Offset: 0x00088CA6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				UnUseComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x0008AAB4 File Offset: 0x00088CB4
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x0008AADE File Offset: 0x00088CDE
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

		// Token: 0x040023AC RID: 9132
		[Nullable(2)]
		protected new UnUseComponent FbInstance;

		// Token: 0x040023AD RID: 9133
		[Nullable(2)]
		protected new UnUseComponent_SetValue PocoInterface;
	}
}
