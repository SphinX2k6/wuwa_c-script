using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000473 RID: 1139
	public class IHitBulletTypePlayerOrThrenodianAttack : IHitBulletType
	{
		// Token: 0x060016C5 RID: 5829 RVA: 0x00046758 File Offset: 0x00044958
		private IHitBulletTypePlayerOrThrenodianAttack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletTypePlayerOrThrenodianAttack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletTypePlayerOrThrenodianAttack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletTypePlayerOrThrenodianAttack_SetValue());
			}
			return result;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00046790 File Offset: 0x00044990
		public static IHitBulletTypePlayerOrThrenodianAttack Create([Nullable(2)] IHitBulletTypePlayerOrThrenodianAttack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypePlayerOrThrenodianAttack
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000467A3 File Offset: 0x000449A3
		public static IHitBulletTypePlayerOrThrenodianAttack CreateFromSetValue([Nullable(2)] IHitBulletTypePlayerOrThrenodianAttack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletTypePlayerOrThrenodianAttack
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000467B6 File Offset: 0x000449B6
		public new IHitBulletTypePlayerOrThrenodianAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypePlayerOrThrenodianAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x000467C9 File Offset: 0x000449C9
		// (set) Token: 0x060016CA RID: 5834 RVA: 0x000467F4 File Offset: 0x000449F4
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

		// Token: 0x0400118F RID: 4495
		[Nullable(2)]
		protected new IHitBulletTypePlayerOrThrenodianAttack FbInstance;

		// Token: 0x04001190 RID: 4496
		[Nullable(2)]
		protected new IHitBulletTypePlayerOrThrenodianAttack_SetValue PocoInterface;
	}
}
