using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000416 RID: 1046
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletTypeOnlyDropAttack : IHitBulletType
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x00042898 File Offset: 0x00040A98
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

		// Token: 0x0600151C RID: 5404 RVA: 0x000428D0 File Offset: 0x00040AD0
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

		// Token: 0x0600151D RID: 5405 RVA: 0x000428E3 File Offset: 0x00040AE3
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

		// Token: 0x0600151E RID: 5406 RVA: 0x000428F6 File Offset: 0x00040AF6
		public new IHitBulletTypeOnlyDropAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypeOnlyDropAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00042909 File Offset: 0x00040B09
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x00042934 File Offset: 0x00040B34
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

		// Token: 0x04001067 RID: 4199
		[Nullable(2)]
		protected new IHitBulletTypeOnlyDropAttack FbInstance;

		// Token: 0x04001068 RID: 4200
		[Nullable(2)]
		protected new IHitBulletTypeOnlyDropAttack_SetValue PocoInterface;
	}
}
