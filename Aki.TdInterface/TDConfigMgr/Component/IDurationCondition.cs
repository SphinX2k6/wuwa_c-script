using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002DB RID: 731
	[NullableContext(1)]
	[Nullable(0)]
	public class IDurationCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x06000DF5 RID: 3573 RVA: 0x00033484 File Offset: 0x00031684
		private IDurationCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDurationCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDurationCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDurationCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000334BC File Offset: 0x000316BC
		public static IDurationCondition Create([Nullable(2)] IDurationCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurationCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000334CF File Offset: 0x000316CF
		public static IDurationCondition CreateFromSetValue([Nullable(2)] IDurationCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDurationCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000334E2 File Offset: 0x000316E2
		public new IDurationCondition_SetValue ToSetValue()
		{
			return new IDurationCondition_SetValue
			{
				Type = this.Type,
				Duration = this.Duration,
				Refill = this.Refill
			};
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0003350D File Offset: 0x0003170D
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x00033538 File Offset: 0x00031738
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00033546 File Offset: 0x00031746
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x00033575 File Offset: 0x00031775
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00033584 File Offset: 0x00031784
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000335BE File Offset: 0x000317BE
		public virtual bool? Refill
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Refill;
				}
				IDurationCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Refill;
			}
			set
			{
				this.GetOrCreatePoco().Refill = value;
			}
		}

		// Token: 0x04000C7A RID: 3194
		[Nullable(2)]
		protected new IDurationCondition FbInstance;

		// Token: 0x04000C7B RID: 3195
		[Nullable(2)]
		protected new IDurationCondition_SetValue PocoInterface;
	}
}
