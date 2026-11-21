using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1E RID: 2846
	public class BehaviorFlowComponent : IComponentBase
	{
		// Token: 0x06004108 RID: 16648 RVA: 0x000A5F38 File Offset: 0x000A4138
		public static BehaviorFlowComponent Create(IBehaviorFlowComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BehaviorFlowComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x000A5F58 File Offset: 0x000A4158
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x000A5F90 File Offset: 0x000A4190
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x000A5FA8 File Offset: 0x000A41A8
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x0600410C RID: 16652 RVA: 0x000A5FDE File Offset: 0x000A41DE
		public virtual int InitStateId
		{
			get
			{
				return this.Instance.InitStateId;
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x0600410D RID: 16653 RVA: 0x000A5FEB File Offset: 0x000A41EB
		public virtual IFlowInfo FlowInfo
		{
			get
			{
				if (this._FlowInfoInited)
				{
					return this._FlowInfoCache;
				}
				this._FlowInfoInited = true;
				this._FlowInfoCache = IFlowInfo.Create(this.Instance.FlowInfo);
				return this._FlowInfoCache;
			}
		}

		// Token: 0x04002409 RID: 9225
		private IBehaviorFlowComponent Instance;

		// Token: 0x0400240A RID: 9226
		[Nullable(2)]
		private IFlowInfo _FlowInfoCache;

		// Token: 0x0400240B RID: 9227
		private bool _FlowInfoInited;
	}
}
