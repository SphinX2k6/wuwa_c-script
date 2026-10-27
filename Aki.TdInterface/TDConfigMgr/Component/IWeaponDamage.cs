using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007DB RID: 2011
	[NullableContext(1)]
	[Nullable(0)]
	public class IWeaponDamage
	{
		// Token: 0x06002BA7 RID: 11175 RVA: 0x00071C58 File Offset: 0x0006FE58
		private IWeaponDamage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWeaponDamage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWeaponDamage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWeaponDamage_SetValue());
			}
			return result;
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00071C90 File Offset: 0x0006FE90
		public static IWeaponDamage Create([Nullable(2)] IWeaponDamage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWeaponDamage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00071CA3 File Offset: 0x0006FEA3
		public static IWeaponDamage CreateFromSetValue([Nullable(2)] IWeaponDamage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWeaponDamage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00071CB8 File Offset: 0x0006FEB8
		public IWeaponDamage_SetValue ToSetValue()
		{
			return new IWeaponDamage_SetValue
			{
				DefaultValue = this.DefaultValue,
				GreatSword = this.GreatSword,
				Dagger = this.Dagger,
				Pistol = this.Pistol,
				Pugilism = this.Pugilism,
				Ring = this.Ring
			};
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x00071D12 File Offset: 0x0006FF12
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x00071D3D File Offset: 0x0006FF3D
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x00071D4C File Offset: 0x0006FF4C
		// (set) Token: 0x06002BAE RID: 11182 RVA: 0x00071D86 File Offset: 0x0006FF86
		public virtual int? GreatSword
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GreatSword;
				}
				IWeaponDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GreatSword;
			}
			set
			{
				this.GetOrCreatePoco().GreatSword = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x00071D94 File Offset: 0x0006FF94
		// (set) Token: 0x06002BB0 RID: 11184 RVA: 0x00071DCE File Offset: 0x0006FFCE
		public virtual int? Dagger
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Dagger;
				}
				IWeaponDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Dagger;
			}
			set
			{
				this.GetOrCreatePoco().Dagger = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x00071DDC File Offset: 0x0006FFDC
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x00071E16 File Offset: 0x00070016
		public virtual int? Pistol
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pistol;
				}
				IWeaponDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pistol;
			}
			set
			{
				this.GetOrCreatePoco().Pistol = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x00071E24 File Offset: 0x00070024
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x00071E5E File Offset: 0x0007005E
		public virtual int? Pugilism
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pugilism;
				}
				IWeaponDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pugilism;
			}
			set
			{
				this.GetOrCreatePoco().Pugilism = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x00071E6C File Offset: 0x0007006C
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x00071EA6 File Offset: 0x000700A6
		public virtual int? Ring
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Ring;
				}
				IWeaponDamage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Ring;
			}
			set
			{
				this.GetOrCreatePoco().Ring = value;
			}
		}

		// Token: 0x04001CF8 RID: 7416
		[Nullable(2)]
		protected IWeaponDamage FbInstance;

		// Token: 0x04001CF9 RID: 7417
		[Nullable(2)]
		protected IWeaponDamage_SetValue PocoInterface;
	}
}
