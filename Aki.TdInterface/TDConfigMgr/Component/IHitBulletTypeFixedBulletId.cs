using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200046D RID: 1133
	public class IHitBulletTypeFixedBulletId : IHitBulletType
	{
		// Token: 0x060016A9 RID: 5801 RVA: 0x00046490 File Offset: 0x00044690
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

		// Token: 0x060016AA RID: 5802 RVA: 0x000464C8 File Offset: 0x000446C8
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

		// Token: 0x060016AB RID: 5803 RVA: 0x000464DB File Offset: 0x000446DB
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

		// Token: 0x060016AC RID: 5804 RVA: 0x000464EE File Offset: 0x000446EE
		public new IHitBulletTypeFixedBulletId_SetValue ToSetValue()
		{
			return new IHitBulletTypeFixedBulletId_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				PlayerAttack = this.PlayerAttack
			};
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00046519 File Offset: 0x00044719
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x00046544 File Offset: 0x00044744
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

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x00046552 File Offset: 0x00044752
		// (set) Token: 0x060016B0 RID: 5808 RVA: 0x00046579 File Offset: 0x00044779
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

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00046588 File Offset: 0x00044788
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x000465C2 File Offset: 0x000447C2
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

		// Token: 0x04001184 RID: 4484
		[Nullable(2)]
		protected new IHitBulletTypeFixedBulletId FbInstance;

		// Token: 0x04001185 RID: 4485
		[Nullable(2)]
		protected new IHitBulletTypeFixedBulletId_SetValue PocoInterface;
	}
}
