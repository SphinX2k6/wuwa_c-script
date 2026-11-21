using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000487 RID: 1159
	public class IHitTimeScaleRatio
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x00047424 File Offset: 0x00045624
		private IHitTimeScaleRatio_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitTimeScaleRatio 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitTimeScaleRatio_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitTimeScaleRatio_SetValue());
			}
			return result;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0004745C File Offset: 0x0004565C
		public static IHitTimeScaleRatio Create([Nullable(2)] IHitTimeScaleRatio instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitTimeScaleRatio
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0004746F File Offset: 0x0004566F
		public static IHitTimeScaleRatio CreateFromSetValue([Nullable(2)] IHitTimeScaleRatio_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitTimeScaleRatio
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00047482 File Offset: 0x00045682
		public IHitTimeScaleRatio_SetValue ToSetValue()
		{
			return new IHitTimeScaleRatio_SetValue
			{
				TimeRatio = this.TimeRatio,
				MaxExtraTime = this.MaxExtraTime,
				ValueRatio = this.ValueRatio
			};
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x000474AD File Offset: 0x000456AD
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x000474DC File Offset: 0x000456DC
		public virtual float TimeRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeRatio;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TimeRatio;
			}
			set
			{
				this.GetOrCreatePoco().TimeRatio = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x000474EC File Offset: 0x000456EC
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x00047526 File Offset: 0x00045726
		public virtual float? MaxExtraTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxExtraTime;
				}
				IHitTimeScaleRatio_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxExtraTime;
			}
			set
			{
				this.GetOrCreatePoco().MaxExtraTime = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00047534 File Offset: 0x00045734
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x00047563 File Offset: 0x00045763
		public virtual float ValueRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ValueRatio;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ValueRatio;
			}
			set
			{
				this.GetOrCreatePoco().ValueRatio = value;
			}
		}

		// Token: 0x040011C5 RID: 4549
		[Nullable(2)]
		protected IHitTimeScaleRatio FbInstance;

		// Token: 0x040011C6 RID: 4550
		[Nullable(2)]
		protected IHitTimeScaleRatio_SetValue PocoInterface;
	}
}
