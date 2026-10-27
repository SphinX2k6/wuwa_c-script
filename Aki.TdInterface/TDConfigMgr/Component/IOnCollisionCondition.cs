using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A6 RID: 1446
	[NullableContext(1)]
	[Nullable(0)]
	public class IOnCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x06001E84 RID: 7812 RVA: 0x00056648 File Offset: 0x00054848
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

		// Token: 0x06001E85 RID: 7813 RVA: 0x00056680 File Offset: 0x00054880
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

		// Token: 0x06001E86 RID: 7814 RVA: 0x00056693 File Offset: 0x00054893
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

		// Token: 0x06001E87 RID: 7815 RVA: 0x000566A6 File Offset: 0x000548A6
		public new IOnCollisionCondition_SetValue ToSetValue()
		{
			return new IOnCollisionCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				TriggerCount = this.TriggerCount
			};
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000566D1 File Offset: 0x000548D1
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x000566FC File Offset: 0x000548FC
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0005670A File Offset: 0x0005490A
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x00056736 File Offset: 0x00054936
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

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00056744 File Offset: 0x00054944
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x000567A5 File Offset: 0x000549A5
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

		// Token: 0x040015BE RID: 5566
		[Nullable(2)]
		protected new IOnCollisionCondition FbInstance;

		// Token: 0x040015BF RID: 5567
		[Nullable(2)]
		protected new IOnCollisionCondition_SetValue PocoInterface;

		// Token: 0x040015C0 RID: 5568
		private ITriggerCountConfig _TriggerCountCache;

		// Token: 0x040015C1 RID: 5569
		private bool _TriggerCountInited;
	}
}
