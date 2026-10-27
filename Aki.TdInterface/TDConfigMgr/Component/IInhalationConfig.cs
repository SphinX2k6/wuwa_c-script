using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000456 RID: 1110
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhalationConfig
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x00045428 File Offset: 0x00043628
		private IInhalationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhalationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhalationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhalationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00045460 File Offset: 0x00043660
		public static IInhalationConfig Create([Nullable(2)] IInhalationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00045473 File Offset: 0x00043673
		public static IInhalationConfig CreateFromSetValue([Nullable(2)] IInhalationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhalationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00045486 File Offset: 0x00043686
		public IInhalationConfig_SetValue ToSetValue()
		{
			return new IInhalationConfig_SetValue
			{
				InhalationMatching = this.InhalationMatching,
				InhalationPerformance = this.InhalationPerformance
			};
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x000454A8 File Offset: 0x000436A8
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x00045509 File Offset: 0x00043709
		public virtual IInhalationMatching InhalationMatching
		{
			get
			{
				if (this._InhalationMatchingInited)
				{
					return this._InhalationMatchingCache;
				}
				this._InhalationMatchingInited = true;
				if (this.FbInstance != null)
				{
					this._InhalationMatchingCache = IInhalationMatching.Create(this.FbInstance.InhalationMatching);
				}
				else
				{
					IInhalationConfig_SetValue pocoInterface = this.PocoInterface;
					this._InhalationMatchingCache = ((pocoInterface != null) ? pocoInterface.InhalationMatching : null);
				}
				return this._InhalationMatchingCache;
			}
			set
			{
				this.GetOrCreatePoco().InhalationMatching = value;
				this._InhalationMatchingInited = false;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x0004551E File Offset: 0x0004371E
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x00045545 File Offset: 0x00043745
		public virtual IInhalationPerformanceType InhalationPerformance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InhalationPerformance;
				}
				IInhalationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InhalationPerformance;
			}
			set
			{
				this.GetOrCreatePoco().InhalationPerformance = value;
			}
		}

		// Token: 0x0400111E RID: 4382
		[Nullable(2)]
		protected IInhalationConfig FbInstance;

		// Token: 0x0400111F RID: 4383
		[Nullable(2)]
		protected IInhalationConfig_SetValue PocoInterface;

		// Token: 0x04001120 RID: 4384
		private IInhalationMatching _InhalationMatchingCache;

		// Token: 0x04001121 RID: 4385
		private bool _InhalationMatchingInited;
	}
}
