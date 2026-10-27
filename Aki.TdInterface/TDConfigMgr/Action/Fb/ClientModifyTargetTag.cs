using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295C RID: 10588
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientModifyTargetTag : ActionParams
	{
		// Token: 0x0600EAC0 RID: 60096 RVA: 0x00225EA8 File Offset: 0x002240A8
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

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x0600EAC1 RID: 60097 RVA: 0x00225EC7 File Offset: 0x002240C7
		public virtual bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x0600EAC2 RID: 60098 RVA: 0x00225ED4 File Offset: 0x002240D4
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

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x0600EAC3 RID: 60099 RVA: 0x00225F04 File Offset: 0x00224104
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

		// Token: 0x0400815A RID: 33114
		private IClientModifyTargetTag Instance;

		// Token: 0x0400815B RID: 33115
		private IClientModifyTarget _TargetCache;

		// Token: 0x0400815C RID: 33116
		private bool _TargetInited;

		// Token: 0x0400815D RID: 33117
		private List<string> _PerformanceTagCache;

		// Token: 0x0400815E RID: 33118
		private bool _PerformanceTagInited;
	}
}
