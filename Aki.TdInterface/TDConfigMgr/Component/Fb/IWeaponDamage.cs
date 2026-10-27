using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6B RID: 2923
	public class IWeaponDamage
	{
		// Token: 0x06004351 RID: 17233 RVA: 0x000ABA13 File Offset: 0x000A9C13
		[NullableContext(1)]
		public static IWeaponDamage Create(IWeaponDamage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWeaponDamage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x000ABA32 File Offset: 0x000A9C32
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x000ABA40 File Offset: 0x000A9C40
		public virtual int? GreatSword
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.GreatSword);
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x000ABA78 File Offset: 0x000A9C78
		public virtual int? Dagger
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Dagger);
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x000ABAB0 File Offset: 0x000A9CB0
		public virtual int? Pistol
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Pistol);
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x000ABAE8 File Offset: 0x000A9CE8
		public virtual int? Pugilism
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Pugilism);
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x000ABB20 File Offset: 0x000A9D20
		public virtual int? Ring
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Ring);
			}
		}

		// Token: 0x040025F8 RID: 9720
		private IWeaponDamage Instance;
	}
}
