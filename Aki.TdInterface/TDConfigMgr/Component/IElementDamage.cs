using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200034A RID: 842
	public class IElementDamage
	{
		// Token: 0x06001011 RID: 4113 RVA: 0x00038238 File Offset: 0x00036438
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

		// Token: 0x06001012 RID: 4114 RVA: 0x00038270 File Offset: 0x00036470
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

		// Token: 0x06001013 RID: 4115 RVA: 0x00038283 File Offset: 0x00036483
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

		// Token: 0x06001014 RID: 4116 RVA: 0x00038298 File Offset: 0x00036498
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x0003830A File Offset: 0x0003650A
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x00038335 File Offset: 0x00036535
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00038344 File Offset: 0x00036544
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x0003837E File Offset: 0x0003657E
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

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x0003838C File Offset: 0x0003658C
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x000383C6 File Offset: 0x000365C6
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x000383D4 File Offset: 0x000365D4
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x0003840E File Offset: 0x0003660E
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

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x0003841C File Offset: 0x0003661C
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x00038456 File Offset: 0x00036656
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00038464 File Offset: 0x00036664
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x0003849E File Offset: 0x0003669E
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

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x000384AC File Offset: 0x000366AC
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x000384E6 File Offset: 0x000366E6
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

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x000384F4 File Offset: 0x000366F4
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x0003852E File Offset: 0x0003672E
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

		// Token: 0x04000DEA RID: 3562
		[Nullable(2)]
		protected IElementDamage FbInstance;

		// Token: 0x04000DEB RID: 3563
		[Nullable(2)]
		protected IElementDamage_SetValue PocoInterface;
	}
}
