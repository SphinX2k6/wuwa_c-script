using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F5D RID: 3933
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityDistanceLimitingCondition
	{
		// Token: 0x06005768 RID: 22376 RVA: 0x000D5BE8 File Offset: 0x000D3DE8
		private IEntityDistanceLimitingCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityDistanceLimitingCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityDistanceLimitingCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityDistanceLimitingCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x000D5C20 File Offset: 0x000D3E20
		public static IEntityDistanceLimitingCondition Create([Nullable(2)] IEntityDistanceLimitingCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityDistanceLimitingCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x000D5C33 File Offset: 0x000D3E33
		public static IEntityDistanceLimitingCondition CreateFromSetValue([Nullable(2)] IEntityDistanceLimitingCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityDistanceLimitingCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x000D5C46 File Offset: 0x000D3E46
		public IEntityDistanceLimitingCondition_SetValue ToSetValue()
		{
			return new IEntityDistanceLimitingCondition_SetValue
			{
				EntityId = this.EntityId,
				MaxDistance = this.MaxDistance,
				OverMaxCountdown = this.OverMaxCountdown
			};
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x0600576C RID: 22380 RVA: 0x000D5C71 File Offset: 0x000D3E71
		// (set) Token: 0x0600576D RID: 22381 RVA: 0x000D5C9C File Offset: 0x000D3E9C
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x0600576E RID: 22382 RVA: 0x000D5CAA File Offset: 0x000D3EAA
		// (set) Token: 0x0600576F RID: 22383 RVA: 0x000D5CD9 File Offset: 0x000D3ED9
		public virtual float MaxDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxDistance = value;
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x000D5CE7 File Offset: 0x000D3EE7
		// (set) Token: 0x06005771 RID: 22385 RVA: 0x000D5D16 File Offset: 0x000D3F16
		public virtual float OverMaxCountdown
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverMaxCountdown;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.OverMaxCountdown;
			}
			set
			{
				this.GetOrCreatePoco().OverMaxCountdown = value;
			}
		}

		// Token: 0x040034DF RID: 13535
		[Nullable(2)]
		protected IEntityDistanceLimitingCondition FbInstance;

		// Token: 0x040034E0 RID: 13536
		[Nullable(2)]
		protected IEntityDistanceLimitingCondition_SetValue PocoInterface;
	}
}
