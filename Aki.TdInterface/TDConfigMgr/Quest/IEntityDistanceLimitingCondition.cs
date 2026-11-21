using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001087 RID: 4231
	public class IEntityDistanceLimitingCondition
	{
		// Token: 0x06005D3C RID: 23868 RVA: 0x000E2654 File Offset: 0x000E0854
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

		// Token: 0x06005D3D RID: 23869 RVA: 0x000E268C File Offset: 0x000E088C
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

		// Token: 0x06005D3E RID: 23870 RVA: 0x000E269F File Offset: 0x000E089F
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

		// Token: 0x06005D3F RID: 23871 RVA: 0x000E26B2 File Offset: 0x000E08B2
		public IEntityDistanceLimitingCondition_SetValue ToSetValue()
		{
			return new IEntityDistanceLimitingCondition_SetValue
			{
				EntityId = this.EntityId,
				MaxDistance = this.MaxDistance,
				OverMaxCountdown = this.OverMaxCountdown
			};
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06005D40 RID: 23872 RVA: 0x000E26DD File Offset: 0x000E08DD
		// (set) Token: 0x06005D41 RID: 23873 RVA: 0x000E2708 File Offset: 0x000E0908
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

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06005D42 RID: 23874 RVA: 0x000E2716 File Offset: 0x000E0916
		// (set) Token: 0x06005D43 RID: 23875 RVA: 0x000E2745 File Offset: 0x000E0945
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

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06005D44 RID: 23876 RVA: 0x000E2753 File Offset: 0x000E0953
		// (set) Token: 0x06005D45 RID: 23877 RVA: 0x000E2782 File Offset: 0x000E0982
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

		// Token: 0x04003810 RID: 14352
		[Nullable(2)]
		protected IEntityDistanceLimitingCondition FbInstance;

		// Token: 0x04003811 RID: 14353
		[Nullable(2)]
		protected IEntityDistanceLimitingCondition_SetValue PocoInterface;
	}
}
