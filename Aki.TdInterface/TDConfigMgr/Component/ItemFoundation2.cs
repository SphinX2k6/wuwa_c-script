using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007FD RID: 2045
	public class ItemFoundation2 : IComponentBase
	{
		// Token: 0x06002BD5 RID: 11221 RVA: 0x00072BB8 File Offset: 0x00070DB8
		private ItemFoundation2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ItemFoundation2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ItemFoundation2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ItemFoundation2_SetValue());
			}
			return result;
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00072BF0 File Offset: 0x00070DF0
		public static ItemFoundation2 Create([Nullable(2)] ItemFoundation2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ItemFoundation2
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00072C03 File Offset: 0x00070E03
		public static ItemFoundation2 CreateFromSetValue([Nullable(2)] ItemFoundation2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ItemFoundation2
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00072C16 File Offset: 0x00070E16
		public new ItemFoundation2_SetValue ToSetValue()
		{
			return new ItemFoundation2_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x00072C44 File Offset: 0x00070E44
		// (set) Token: 0x06002BDA RID: 11226 RVA: 0x00072C7E File Offset: 0x00070E7E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ItemFoundation2_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x00072C8C File Offset: 0x00070E8C
		// (set) Token: 0x06002BDC RID: 11228 RVA: 0x00072CB6 File Offset: 0x00070EB6
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

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x00072CC4 File Offset: 0x00070EC4
		// (set) Token: 0x06002BDE RID: 11230 RVA: 0x00072CEB File Offset: 0x00070EEB
		public virtual IItemFoundationType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ItemFoundation2_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x04001D5D RID: 7517
		[Nullable(2)]
		protected new ItemFoundation2 FbInstance;

		// Token: 0x04001D5E RID: 7518
		[Nullable(2)]
		protected new ItemFoundation2_SetValue PocoInterface;
	}
}
