using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E1 RID: 4321
	public class IHealthAttributeToTarget : IAttributeToTarget
	{
		// Token: 0x06005F84 RID: 24452 RVA: 0x000E7134 File Offset: 0x000E5334
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

		// Token: 0x06005F85 RID: 24453 RVA: 0x000E716C File Offset: 0x000E536C
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

		// Token: 0x06005F86 RID: 24454 RVA: 0x000E717F File Offset: 0x000E537F
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

		// Token: 0x06005F87 RID: 24455 RVA: 0x000E7192 File Offset: 0x000E5392
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

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x000E71C9 File Offset: 0x000E53C9
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x000E71F4 File Offset: 0x000E53F4
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

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x000E7202 File Offset: 0x000E5402
		// (set) Token: 0x06005F8B RID: 24459 RVA: 0x000E7231 File Offset: 0x000E5431
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

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x000E723F File Offset: 0x000E543F
		// (set) Token: 0x06005F8D RID: 24461 RVA: 0x000E726E File Offset: 0x000E546E
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

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x000E727C File Offset: 0x000E547C
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x000E72B6 File Offset: 0x000E54B6
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

		// Token: 0x04003951 RID: 14673
		[Nullable(2)]
		protected new IHealthAttributeToTarget FbInstance;

		// Token: 0x04003952 RID: 14674
		[Nullable(2)]
		protected new IHealthAttributeToTarget_SetValue PocoInterface;
	}
}
