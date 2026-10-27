using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277B RID: 10107
	[NullableContext(2)]
	[Nullable(0)]
	public class IEndState
	{
		// Token: 0x0600E109 RID: 57609 RVA: 0x00213F95 File Offset: 0x00212195
		[NullableContext(1)]
		public static IEndState Create(IEndState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEndState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043D5 RID: 17365
		// (get) Token: 0x0600E10A RID: 57610 RVA: 0x00213FB4 File Offset: 0x002121B4
		public virtual List<int> StayFlowMontageActors
		{
			get
			{
				if (this._StayFlowMontageActorsInited)
				{
					return this._StayFlowMontageActorsCache;
				}
				this._StayFlowMontageActorsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int stayFlowMontageActorsLength = this.Instance.StayFlowMontageActorsLength;
				this._StayFlowMontageActorsCache = new List<int>(stayFlowMontageActorsLength);
				for (int i = 0; i < stayFlowMontageActorsLength; i++)
				{
					this._StayFlowMontageActorsCache.Add(this.Instance.StayFlowMontageActors(i));
				}
				return this._StayFlowMontageActorsCache;
			}
		}

		// Token: 0x04007CA1 RID: 31905
		private IEndState Instance;

		// Token: 0x04007CA2 RID: 31906
		private List<int> _StayFlowMontageActorsCache;

		// Token: 0x04007CA3 RID: 31907
		private bool _StayFlowMontageActorsInited;
	}
}
