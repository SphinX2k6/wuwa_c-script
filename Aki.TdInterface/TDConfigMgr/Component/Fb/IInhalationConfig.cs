using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D61 RID: 3425
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhalationConfig
	{
		// Token: 0x06004E01 RID: 19969 RVA: 0x000C1C81 File Offset: 0x000BFE81
		public static IInhalationConfig Create(IInhalationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06004E02 RID: 19970 RVA: 0x000C1CA0 File Offset: 0x000BFEA0
		public virtual IInhalationMatching InhalationMatching
		{
			get
			{
				if (this._InhalationMatchingInited)
				{
					return this._InhalationMatchingCache;
				}
				this._InhalationMatchingInited = true;
				this._InhalationMatchingCache = IInhalationMatching.Create(this.Instance.InhalationMatching);
				return this._InhalationMatchingCache;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06004E03 RID: 19971 RVA: 0x000C1CD4 File Offset: 0x000BFED4
		public virtual IInhalationPerformanceType InhalationPerformance
		{
			get
			{
				if (this._InhalationPerformanceInited)
				{
					return this._InhalationPerformanceCache;
				}
				this._InhalationPerformanceInited = true;
				this._InhalationPerformanceCache = ComponentReadHelper.ReadIInhalationConfig_InhalationPerformance(this.Instance);
				return this._InhalationPerformanceCache;
			}
		}

		// Token: 0x04002CB6 RID: 11446
		private IInhalationConfig Instance;

		// Token: 0x04002CB7 RID: 11447
		[Nullable(2)]
		private IInhalationMatching _InhalationMatchingCache;

		// Token: 0x04002CB8 RID: 11448
		private bool _InhalationMatchingInited;

		// Token: 0x04002CB9 RID: 11449
		private IInhalationPerformanceType _InhalationPerformanceCache;

		// Token: 0x04002CBA RID: 11450
		private bool _InhalationPerformanceInited;
	}
}
