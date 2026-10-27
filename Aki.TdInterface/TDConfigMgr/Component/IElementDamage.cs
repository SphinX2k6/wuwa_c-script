using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000303 RID: 771
	[NullableContext(1)]
	[Nullable(0)]
	public class IElementDamage
	{
		// Token: 0x06000EE1 RID: 3809 RVA: 0x00035304 File Offset: 0x00033504
		private IElementDamage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IElementDamage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IElementDamage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IElementDamage_SetValue());
			}
			return result;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0003533C File Offset: 0x0003353C
		public static IElementDamage Create([Nullable(2)] IElementDamage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementDamage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0003534F File Offset: 0x0003354F
		public static IElementDamage CreateFromSetValue([Nullable(2)] IElementDamage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IElementDamage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00035364 File Offset: 0x00033564
		public IElementDamage_SetValue ToSetValue()
		{
			return new IElementDamage_SetValue
			{
				DefaultValue = this.DefaultValue,
				Physics = this.Physics,
				Ice = this.Ice,
				Fire = this.Fire,
				Thunder = this.Thunder,
				Wind = this.Wind,
				Light = this.Light,
				Dark = this.Dark
			};
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000353D6 File Offset: 0x000335D6
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00035401 File Offset: 0x00033601
		public virtual int DefaultValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DefaultValue;
			}
			set
			{
				this.GetOrCreatePoco().DefaultValue = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00035410 File Offset: 0x00033610
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0003544A File Offset: 0x0003364A
		public virtual int? Physics
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Physics;
				}
				IElementDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Physics;
			}
			set
			{
				this.GetOrCreatePoco().Physics = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00035458 File Offset: 0x00033658
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00035492 File Offset: 0x00033692
		public virtual int? Ice
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Ice;
				}
				IElementDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Ice;
			}
			set
			{
				this.GetOrCreatePoco().Ice = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000354A0 File Offset: 0x000336A0
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000354DA File Offset: 0x000336DA
		public virtual int? Fire
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Fire;
				}
				IElementDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Fire;
			}
			set
			{
				this.GetOrCreatePoco().Fire = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x000354E8 File Offset: 0x000336E8
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00035522 File Offset: 0x00033722
		public virtual int? Thunder
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Thunder;
				}
				IElementDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Thunder;
			}
			set
			{
				this.GetOrCreatePoco().Thunder = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00035530 File Offset: 0x00033730
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x0003556A File Offset: 0x0003376A
		public virtual int? Wind
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Wind;
				}
				IElementDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Wind;
			}
			set
			{
				this.GetOrCreatePoco().Wind = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x00035578 File Offset: 0x00033778
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000355B2 File Offset: 0x000337B2
		public virtual int? Light
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Light;
				}
				IElementDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Light;
			}
			set
			{
				this.GetOrCreatePoco().Light = value;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000355C0 File Offset: 0x000337C0
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000355FA File Offset: 0x000337FA
		public virtual int? Dark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Dark;
				}
				IElementDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Dark;
			}
			set
			{
				this.GetOrCreatePoco().Dark = value;
			}
		}

		// Token: 0x04000D00 RID: 3328
		[Nullable(2)]
		protected IElementDamage FbInstance;

		// Token: 0x04000D01 RID: 3329
		[Nullable(2)]
		protected IElementDamage_SetValue PocoInterface;
	}
}
