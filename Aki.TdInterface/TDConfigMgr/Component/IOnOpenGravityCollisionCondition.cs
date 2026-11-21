using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200061B RID: 1563
	public class IOnOpenGravityCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x060020CC RID: 8396 RVA: 0x0005BCC8 File Offset: 0x00059EC8
		private IOnOpenGravityCollisionCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnOpenGravityCollisionCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnOpenGravityCollisionCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnOpenGravityCollisionCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0005BD00 File Offset: 0x00059F00
		public static IOnOpenGravityCollisionCondition Create([Nullable(2)] IOnOpenGravityCollisionCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnOpenGravityCollisionCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x0005BD13 File Offset: 0x00059F13
		public static IOnOpenGravityCollisionCondition CreateFromSetValue([Nullable(2)] IOnOpenGravityCollisionCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnOpenGravityCollisionCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x0005BD26 File Offset: 0x00059F26
		public new IOnOpenGravityCollisionCondition_SetValue ToSetValue()
		{
			return new IOnOpenGravityCollisionCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0005BD45 File Offset: 0x00059F45
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0005BD70 File Offset: 0x00059F70
		public override EBulletCreateCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBulletCreateCondition.OnHit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0005BD7E File Offset: 0x00059F7E
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0005BDAA File Offset: 0x00059FAA
		public override long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x0400174D RID: 5965
		[Nullable(2)]
		protected new IOnOpenGravityCollisionCondition FbInstance;

		// Token: 0x0400174E RID: 5966
		[Nullable(2)]
		protected new IOnOpenGravityCollisionCondition_SetValue PocoInterface;
	}
}
