using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200060F RID: 1551
	public class IOnCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x0600208A RID: 8330 RVA: 0x0005B504 File Offset: 0x00059704
		private IOnCollisionCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnCollisionCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnCollisionCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnCollisionCondition_SetValue());
			}
			return result;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x0005B53C File Offset: 0x0005973C
		public static IOnCollisionCondition Create([Nullable(2)] IOnCollisionCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnCollisionCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x0005B54F File Offset: 0x0005974F
		public static IOnCollisionCondition CreateFromSetValue([Nullable(2)] IOnCollisionCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnCollisionCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x0005B562 File Offset: 0x00059762
		public new IOnCollisionCondition_SetValue ToSetValue()
		{
			return new IOnCollisionCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				TriggerCount = this.TriggerCount
			};
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x0005B58D File Offset: 0x0005978D
		// (set) Token: 0x0600208F RID: 8335 RVA: 0x0005B5B8 File Offset: 0x000597B8
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

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x0005B5C6 File Offset: 0x000597C6
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x0005B5F2 File Offset: 0x000597F2
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

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x0005B600 File Offset: 0x00059800
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x0005B661 File Offset: 0x00059861
		[Nullable(2)]
		public virtual ITriggerCountConfig TriggerCount
		{
			[NullableContext(2)]
			get
			{
				if (this._TriggerCountInited)
				{
					return this._TriggerCountCache;
				}
				this._TriggerCountInited = true;
				if (this.FbInstance != null)
				{
					this._TriggerCountCache = ITriggerCountConfig.Create(this.FbInstance.TriggerCount);
				}
				else
				{
					IOnCollisionCondition_SetValue pocoInterface = this.PocoInterface;
					this._TriggerCountCache = ((pocoInterface != null) ? pocoInterface.TriggerCount : null);
				}
				return this._TriggerCountCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TriggerCount = value;
				this._TriggerCountInited = false;
			}
		}

		// Token: 0x0400172C RID: 5932
		[Nullable(2)]
		protected new IOnCollisionCondition FbInstance;

		// Token: 0x0400172D RID: 5933
		[Nullable(2)]
		protected new IOnCollisionCondition_SetValue PocoInterface;

		// Token: 0x0400172E RID: 5934
		private ITriggerCountConfig _TriggerCountCache;

		// Token: 0x0400172F RID: 5935
		private bool _TriggerCountInited;
	}
}
