using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200087E RID: 2174
	public class IWeaponDamage
	{
		// Token: 0x06002ED7 RID: 11991 RVA: 0x00078FBC File Offset: 0x000771BC
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

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00078FF4 File Offset: 0x000771F4
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

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00079007 File Offset: 0x00077207
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

		// Token: 0x06002EDA RID: 11994 RVA: 0x0007901C File Offset: 0x0007721C
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

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x00079076 File Offset: 0x00077276
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x000790A1 File Offset: 0x000772A1
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

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000790B0 File Offset: 0x000772B0
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x000790EA File Offset: 0x000772EA
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

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x000790F8 File Offset: 0x000772F8
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00079132 File Offset: 0x00077332
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

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x00079140 File Offset: 0x00077340
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x0007917A File Offset: 0x0007737A
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

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x00079188 File Offset: 0x00077388
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x000791C2 File Offset: 0x000773C2
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

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000791D0 File Offset: 0x000773D0
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x0007920A File Offset: 0x0007740A
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

		// Token: 0x04001F04 RID: 7940
		[Nullable(2)]
		protected IWeaponDamage FbInstance;

		// Token: 0x04001F05 RID: 7941
		[Nullable(2)]
		protected IWeaponDamage_SetValue PocoInterface;
	}
}
