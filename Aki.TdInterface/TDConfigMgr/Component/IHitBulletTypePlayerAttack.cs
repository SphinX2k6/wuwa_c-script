using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000418 RID: 1048
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletTypePlayerAttack : IHitBulletType
	{
		// Token: 0x06001523 RID: 5411 RVA: 0x00042954 File Offset: 0x00040B54
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

		// Token: 0x06001524 RID: 5412 RVA: 0x0004298C File Offset: 0x00040B8C
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

		// Token: 0x06001525 RID: 5413 RVA: 0x0004299F File Offset: 0x00040B9F
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

		// Token: 0x06001526 RID: 5414 RVA: 0x000429B2 File Offset: 0x00040BB2
		public new IHitBulletTypePlayerAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypePlayerAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000429C5 File Offset: 0x00040BC5
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x000429F0 File Offset: 0x00040BF0
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

		// Token: 0x0400106A RID: 4202
		[Nullable(2)]
		protected new IHitBulletTypePlayerAttack FbInstance;

		// Token: 0x0400106B RID: 4203
		[Nullable(2)]
		protected new IHitBulletTypePlayerAttack_SetValue PocoInterface;
	}
}
