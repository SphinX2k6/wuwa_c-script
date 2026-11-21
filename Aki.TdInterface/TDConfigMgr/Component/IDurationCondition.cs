using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000322 RID: 802
	public class IDurationCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x06000F25 RID: 3877 RVA: 0x000363B8 File Offset: 0x000345B8
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

		// Token: 0x06000F26 RID: 3878 RVA: 0x000363F0 File Offset: 0x000345F0
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

		// Token: 0x06000F27 RID: 3879 RVA: 0x00036403 File Offset: 0x00034603
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

		// Token: 0x06000F28 RID: 3880 RVA: 0x00036416 File Offset: 0x00034616
		public new IDurationCondition_SetValue ToSetValue()
		{
			return new IDurationCondition_SetValue
			{
				Type = this.Type,
				Duration = this.Duration,
				Refill = this.Refill
			};
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00036441 File Offset: 0x00034641
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x0003646C File Offset: 0x0003466C
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0003647A File Offset: 0x0003467A
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x000364A9 File Offset: 0x000346A9
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

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000364B8 File Offset: 0x000346B8
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x000364F2 File Offset: 0x000346F2
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

		// Token: 0x04000D64 RID: 3428
		[Nullable(2)]
		protected new IDurationCondition FbInstance;

		// Token: 0x04000D65 RID: 3429
		[Nullable(2)]
		protected new IDurationCondition_SetValue PocoInterface;
	}
}
