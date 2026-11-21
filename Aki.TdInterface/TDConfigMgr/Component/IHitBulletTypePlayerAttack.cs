using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000471 RID: 1137
	public class IHitBulletTypePlayerAttack : IHitBulletType
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x0004669C File Offset: 0x0004489C
		private IHitBulletTypePlayerAttack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletTypePlayerAttack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletTypePlayerAttack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletTypePlayerAttack_SetValue());
			}
			return result;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000466D4 File Offset: 0x000448D4
		public static IHitBulletTypePlayerAttack Create([Nullable(2)] IHitBulletTypePlayerAttack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypePlayerAttack
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000466E7 File Offset: 0x000448E7
		public static IHitBulletTypePlayerAttack CreateFromSetValue([Nullable(2)] IHitBulletTypePlayerAttack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletTypePlayerAttack
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000466FA File Offset: 0x000448FA
		public new IHitBulletTypePlayerAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypePlayerAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x0004670D File Offset: 0x0004490D
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x00046738 File Offset: 0x00044938
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

		// Token: 0x0400118C RID: 4492
		[Nullable(2)]
		protected new IHitBulletTypePlayerAttack FbInstance;

		// Token: 0x0400118D RID: 4493
		[Nullable(2)]
		protected new IHitBulletTypePlayerAttack_SetValue PocoInterface;
	}
}
