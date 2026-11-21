using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C39 RID: 3129
	public class IWeaponDamage
	{
		// Token: 0x060047AA RID: 18346 RVA: 0x000B5AD7 File Offset: 0x000B3CD7
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

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x000B5AF6 File Offset: 0x000B3CF6
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x000B5B04 File Offset: 0x000B3D04
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

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x000B5B3C File Offset: 0x000B3D3C
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

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x000B5B74 File Offset: 0x000B3D74
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

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x000B5BAC File Offset: 0x000B3DAC
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

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x060047B0 RID: 18352 RVA: 0x000B5BE4 File Offset: 0x000B3DE4
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

		// Token: 0x04002840 RID: 10304
		private IWeaponDamage Instance;
	}
}
