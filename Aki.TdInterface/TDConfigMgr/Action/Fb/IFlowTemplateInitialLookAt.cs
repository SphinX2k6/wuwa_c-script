using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002787 RID: 10119
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTemplateInitialLookAt
	{
		// Token: 0x0600E147 RID: 57671 RVA: 0x002148ED File Offset: 0x00212AED
		public static IFlowTemplateInitialLookAt Create(IFlowTemplateInitialLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x0600E148 RID: 57672 RVA: 0x0021490C File Offset: 0x00212B0C
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x170043FC RID: 17404
		// (get) Token: 0x0600E149 RID: 57673 RVA: 0x00214919 File Offset: 0x00212B19
		public virtual IActorLookAtData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIFlowTemplateInitialLookAt_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04007CD1 RID: 31953
		private IFlowTemplateInitialLookAt Instance;

		// Token: 0x04007CD2 RID: 31954
		private IActorLookAtData _TargetCache;

		// Token: 0x04007CD3 RID: 31955
		private bool _TargetInited;
	}
}
