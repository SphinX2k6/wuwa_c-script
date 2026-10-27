using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002851 RID: 10321
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceUnlockPoints : IInteractPointConfig
	{
		// Token: 0x0600E4C7 RID: 58567 RVA: 0x0021AA52 File Offset: 0x00218C52
		public static ISequenceUnlockPoints Create(ISequenceUnlockPoints? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceUnlockPoints
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x0600E4C8 RID: 58568 RVA: 0x0021AA71 File Offset: 0x00218C71
		public override EInteractUnlockType Type
		{
			get
			{
				return (EInteractUnlockType)this.Instance.Type;
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x0021AA80 File Offset: 0x00218C80
		public virtual List<ISequenceInteractStage> Stages
		{
			get
			{
				if (this._StagesInited)
				{
					return this._StagesCache;
				}
				this._StagesInited = true;
				int stagesLength = this.Instance.StagesLength;
				this._StagesCache = new List<ISequenceInteractStage>(stagesLength);
				for (int i = 0; i < stagesLength; i++)
				{
					this._StagesCache.Add(ISequenceInteractStage.Create(this.Instance.Stages(i)));
				}
				return this._StagesCache;
			}
		}

		// Token: 0x04007E93 RID: 32403
		private ISequenceUnlockPoints Instance;

		// Token: 0x04007E94 RID: 32404
		private List<ISequenceInteractStage> _StagesCache;

		// Token: 0x04007E95 RID: 32405
		private bool _StagesInited;
	}
}
