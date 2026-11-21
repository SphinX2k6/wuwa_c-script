using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B25 RID: 11045
	public class IRangeCheck
	{
		// Token: 0x0600F2F0 RID: 62192 RVA: 0x00237955 File Offset: 0x00235B55
		public static IRangeCheck Create(IRangeCheck? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeCheck
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x0600F2F1 RID: 62193 RVA: 0x00237974 File Offset: 0x00235B74
		public virtual ERangeCheckType Type
		{
			get
			{
				return (ERangeCheckType)this.Instance.Type;
			}
		}

		// Token: 0x04008553 RID: 34131
		private IRangeCheck Instance;
	}
}
