using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200075C RID: 1884
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemFoundation2 : IComponentBase
	{
		// Token: 0x060028B1 RID: 10417 RVA: 0x0006BA10 File Offset: 0x00069C10
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

		// Token: 0x060028B2 RID: 10418 RVA: 0x0006BA48 File Offset: 0x00069C48
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

		// Token: 0x060028B3 RID: 10419 RVA: 0x0006BA5B File Offset: 0x00069C5B
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

		// Token: 0x060028B4 RID: 10420 RVA: 0x0006BA6E File Offset: 0x00069C6E
		public new ItemFoundation2_SetValue ToSetValue()
		{
			return new ItemFoundation2_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x0006BA9C File Offset: 0x00069C9C
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x0006BAD6 File Offset: 0x00069CD6
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

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x0006BAE4 File Offset: 0x00069CE4
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x0006BB0E File Offset: 0x00069D0E
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

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0006BB1C File Offset: 0x00069D1C
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x0006BB43 File Offset: 0x00069D43
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

		// Token: 0x04001B58 RID: 7000
		[Nullable(2)]
		protected new ItemFoundation2 FbInstance;

		// Token: 0x04001B59 RID: 7001
		[Nullable(2)]
		protected new ItemFoundation2_SetValue PocoInterface;
	}
}
