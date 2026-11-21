using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C41 RID: 11329
	public class ClientModifyTargetTag : ActionParams
	{
		// Token: 0x0600F936 RID: 63798 RVA: 0x00243560 File Offset: 0x00241760
		public static ClientModifyTargetTag Create(IClientModifyTargetTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientModifyTargetTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x0600F937 RID: 63799 RVA: 0x0024357F File Offset: 0x0024177F
		public virtual bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x0600F938 RID: 63800 RVA: 0x0024358C File Offset: 0x0024178C
		public virtual IClientModifyTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadClientModifyTargetTag_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x0600F939 RID: 63801 RVA: 0x002435BC File Offset: 0x002417BC
		public virtual List<string> PerformanceTag
		{
			get
			{
				if (this._PerformanceTagInited)
				{
					return this._PerformanceTagCache;
				}
				this._PerformanceTagInited = true;
				int performanceTagLength = this.Instance.PerformanceTagLength;
				this._PerformanceTagCache = new List<string>(performanceTagLength);
				for (int i = 0; i < performanceTagLength; i++)
				{
					this._PerformanceTagCache.Add(this.Instance.PerformanceTag(i));
				}
				return this._PerformanceTagCache;
			}
		}

		// Token: 0x0400883B RID: 34875
		private IClientModifyTargetTag Instance;

		// Token: 0x0400883C RID: 34876
		private IClientModifyTarget _TargetCache;

		// Token: 0x0400883D RID: 34877
		private bool _TargetInited;

		// Token: 0x0400883E RID: 34878
		private List<string> _PerformanceTagCache;

		// Token: 0x0400883F RID: 34879
		private bool _PerformanceTagInited;
	}
}
