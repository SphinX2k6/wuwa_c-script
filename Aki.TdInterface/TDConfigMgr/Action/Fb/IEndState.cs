using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4D RID: 10829
	[NullableContext(2)]
	[Nullable(0)]
	public class IEndState
	{
		// Token: 0x0600EF27 RID: 61223 RVA: 0x00230D29 File Offset: 0x0022EF29
		[NullableContext(0)]
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

		// Token: 0x1700473B RID: 18235
		// (get) Token: 0x0600EF28 RID: 61224 RVA: 0x00230D48 File Offset: 0x0022EF48
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

		// Token: 0x04008357 RID: 33623
		private IEndState Instance;

		// Token: 0x04008358 RID: 33624
		private List<int> _StayFlowMontageActorsCache;

		// Token: 0x04008359 RID: 33625
		private bool _StayFlowMontageActorsInited;
	}
}
