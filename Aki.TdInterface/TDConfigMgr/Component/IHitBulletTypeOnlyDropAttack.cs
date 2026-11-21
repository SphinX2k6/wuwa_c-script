using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200046F RID: 1135
	public class IHitBulletTypeOnlyDropAttack : IHitBulletType
	{
		// Token: 0x060016B5 RID: 5813 RVA: 0x000465E0 File Offset: 0x000447E0
		private IHitBulletTypeOnlyDropAttack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletTypeOnlyDropAttack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletTypeOnlyDropAttack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletTypeOnlyDropAttack_SetValue());
			}
			return result;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00046618 File Offset: 0x00044818
		public static IHitBulletTypeOnlyDropAttack Create([Nullable(2)] IHitBulletTypeOnlyDropAttack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeOnlyDropAttack
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0004662B File Offset: 0x0004482B
		public static IHitBulletTypeOnlyDropAttack CreateFromSetValue([Nullable(2)] IHitBulletTypeOnlyDropAttack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletTypeOnlyDropAttack
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0004663E File Offset: 0x0004483E
		public new IHitBulletTypeOnlyDropAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypeOnlyDropAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x00046651 File Offset: 0x00044851
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x0004667C File Offset: 0x0004487C
		public override EHitBulletType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitBulletType.OnlyDropAttack;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001189 RID: 4489
		[Nullable(2)]
		protected new IHitBulletTypeOnlyDropAttack FbInstance;

		// Token: 0x0400118A RID: 4490
		[Nullable(2)]
		protected new IHitBulletTypeOnlyDropAttack_SetValue PocoInterface;
	}
}
