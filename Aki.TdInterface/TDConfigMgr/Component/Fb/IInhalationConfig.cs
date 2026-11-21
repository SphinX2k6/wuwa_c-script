using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E5B RID: 3675
	public class IInhalationConfig
	{
		// Token: 0x0600531D RID: 21277 RVA: 0x000CD3C5 File Offset: 0x000CB5C5
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

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x000CD3E4 File Offset: 0x000CB5E4
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

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600531F RID: 21279 RVA: 0x000CD418 File Offset: 0x000CB618
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

		// Token: 0x04002F76 RID: 12150
		private IInhalationConfig Instance;

		// Token: 0x04002F77 RID: 12151
		[Nullable(2)]
		private IInhalationMatching _InhalationMatchingCache;

		// Token: 0x04002F78 RID: 12152
		private bool _InhalationMatchingInited;

		// Token: 0x04002F79 RID: 12153
		private IInhalationPerformanceType _InhalationPerformanceCache;

		// Token: 0x04002F7A RID: 12154
		private bool _InhalationPerformanceInited;
	}
}
