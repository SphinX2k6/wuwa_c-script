using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FB5 RID: 4021
	[NullableContext(1)]
	[Nullable(0)]
	public class IHealthAttributeToTarget : IAttributeToTarget
	{
		// Token: 0x060059A6 RID: 22950 RVA: 0x000DA5A8 File Offset: 0x000D87A8
		private IHealthAttributeToTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHealthAttributeToTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHealthAttributeToTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHealthAttributeToTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x000DA5E0 File Offset: 0x000D87E0
		public static IHealthAttributeToTarget Create([Nullable(2)] IHealthAttributeToTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHealthAttributeToTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x000DA5F3 File Offset: 0x000D87F3
		public static IHealthAttributeToTarget CreateFromSetValue([Nullable(2)] IHealthAttributeToTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHealthAttributeToTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x000DA606 File Offset: 0x000D8806
		public new IHealthAttributeToTarget_SetValue ToSetValue()
		{
			return new IHealthAttributeToTarget_SetValue
			{
				Type = this.Type,
				Min = this.Min,
				Max = this.Max,
				ZeroHealthOnDeath = this.ZeroHealthOnDeath
			};
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x000DA63D File Offset: 0x000D883D
		// (set) Token: 0x060059AB RID: 22955 RVA: 0x000DA668 File Offset: 0x000D8868
		public override EAttributeToTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttributeToTarget.Health;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x000DA676 File Offset: 0x000D8876
		// (set) Token: 0x060059AD RID: 22957 RVA: 0x000DA6A5 File Offset: 0x000D88A5
		public virtual float Min
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Min;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Min;
			}
			set
			{
				this.GetOrCreatePoco().Min = value;
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x000DA6B3 File Offset: 0x000D88B3
		// (set) Token: 0x060059AF RID: 22959 RVA: 0x000DA6E2 File Offset: 0x000D88E2
		public virtual float Max
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Max;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Max;
			}
			set
			{
				this.GetOrCreatePoco().Max = value;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x000DA6F0 File Offset: 0x000D88F0
		// (set) Token: 0x060059B1 RID: 22961 RVA: 0x000DA72A File Offset: 0x000D892A
		public virtual bool? ZeroHealthOnDeath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ZeroHealthOnDeath;
				}
				IHealthAttributeToTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ZeroHealthOnDeath;
			}
			set
			{
				this.GetOrCreatePoco().ZeroHealthOnDeath = value;
			}
		}

		// Token: 0x0400361C RID: 13852
		[Nullable(2)]
		protected new IHealthAttributeToTarget FbInstance;

		// Token: 0x0400361D RID: 13853
		[Nullable(2)]
		protected new IHealthAttributeToTarget_SetValue PocoInterface;
	}
}
