using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000469 RID: 1129
	public class IHitBulletTypeAllCharacterAttack : IHitBulletType
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00046294 File Offset: 0x00044494
		private IHitBulletTypeAllCharacterAttack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletTypeAllCharacterAttack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletTypeAllCharacterAttack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletTypeAllCharacterAttack_SetValue());
			}
			return result;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x000462CC File Offset: 0x000444CC
		public static IHitBulletTypeAllCharacterAttack Create([Nullable(2)] IHitBulletTypeAllCharacterAttack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeAllCharacterAttack
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000462DF File Offset: 0x000444DF
		public static IHitBulletTypeAllCharacterAttack CreateFromSetValue([Nullable(2)] IHitBulletTypeAllCharacterAttack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletTypeAllCharacterAttack
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000462F2 File Offset: 0x000444F2
		public new IHitBulletTypeAllCharacterAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypeAllCharacterAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x00046305 File Offset: 0x00044505
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x00046330 File Offset: 0x00044530
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

		// Token: 0x0400117B RID: 4475
		[Nullable(2)]
		protected new IHitBulletTypeAllCharacterAttack FbInstance;

		// Token: 0x0400117C RID: 4476
		[Nullable(2)]
		protected new IHitBulletTypeAllCharacterAttack_SetValue PocoInterface;
	}
}
