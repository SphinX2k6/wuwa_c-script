using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041A RID: 1050
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletTypePlayerOrThrenodianAttack : IHitBulletType
	{
		// Token: 0x0600152B RID: 5419 RVA: 0x00042A10 File Offset: 0x00040C10
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

		// Token: 0x0600152C RID: 5420 RVA: 0x00042A48 File Offset: 0x00040C48
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

		// Token: 0x0600152D RID: 5421 RVA: 0x00042A5B File Offset: 0x00040C5B
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

		// Token: 0x0600152E RID: 5422 RVA: 0x00042A6E File Offset: 0x00040C6E
		public new IHitBulletTypePlayerOrThrenodianAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypePlayerOrThrenodianAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x00042A81 File Offset: 0x00040C81
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x00042AAC File Offset: 0x00040CAC
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

		// Token: 0x0400106D RID: 4205
		[Nullable(2)]
		protected new IHitBulletTypePlayerOrThrenodianAttack FbInstance;

		// Token: 0x0400106E RID: 4206
		[Nullable(2)]
		protected new IHitBulletTypePlayerOrThrenodianAttack_SetValue PocoInterface;
	}
}
