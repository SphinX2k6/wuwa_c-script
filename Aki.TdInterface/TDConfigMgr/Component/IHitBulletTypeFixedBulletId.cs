using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000414 RID: 1044
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletTypeFixedBulletId : IHitBulletType
	{
		// Token: 0x0600150F RID: 5391 RVA: 0x00042748 File Offset: 0x00040948
		private IHitBulletTypeFixedBulletId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletTypeFixedBulletId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletTypeFixedBulletId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletTypeFixedBulletId_SetValue());
			}
			return result;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00042780 File Offset: 0x00040980
		public static IHitBulletTypeFixedBulletId Create([Nullable(2)] IHitBulletTypeFixedBulletId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeFixedBulletId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00042793 File Offset: 0x00040993
		public static IHitBulletTypeFixedBulletId CreateFromSetValue([Nullable(2)] IHitBulletTypeFixedBulletId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletTypeFixedBulletId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000427A6 File Offset: 0x000409A6
		public new IHitBulletTypeFixedBulletId_SetValue ToSetValue()
		{
			return new IHitBulletTypeFixedBulletId_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				PlayerAttack = this.PlayerAttack
			};
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x000427D1 File Offset: 0x000409D1
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x000427FC File Offset: 0x000409FC
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0004280A File Offset: 0x00040A0A
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x00042831 File Offset: 0x00040A31
		public virtual List<long> BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				IHitBulletTypeFixedBulletId_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00042840 File Offset: 0x00040A40
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0004287A File Offset: 0x00040A7A
		public virtual bool? PlayerAttack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerAttack;
				}
				IHitBulletTypeFixedBulletId_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerAttack;
			}
			set
			{
				this.GetOrCreatePoco().PlayerAttack = value;
			}
		}

		// Token: 0x04001062 RID: 4194
		[Nullable(2)]
		protected new IHitBulletTypeFixedBulletId FbInstance;

		// Token: 0x04001063 RID: 4195
		[Nullable(2)]
		protected new IHitBulletTypeFixedBulletId_SetValue PocoInterface;
	}
}
