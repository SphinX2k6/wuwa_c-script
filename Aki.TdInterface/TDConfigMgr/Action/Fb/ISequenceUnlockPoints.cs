using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B24 RID: 11044
	public class ISequenceUnlockPoints : IInteractPointConfig
	{
		// Token: 0x0600F2EC RID: 62188 RVA: 0x002378B6 File Offset: 0x00235AB6
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

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x0600F2ED RID: 62189 RVA: 0x002378D5 File Offset: 0x00235AD5
		public override EInteractUnlockType Type
		{
			get
			{
				return (EInteractUnlockType)this.Instance.Type;
			}
		}

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x0600F2EE RID: 62190 RVA: 0x002378E4 File Offset: 0x00235AE4
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

		// Token: 0x04008550 RID: 34128
		private ISequenceUnlockPoints Instance;

		// Token: 0x04008551 RID: 34129
		private List<ISequenceInteractStage> _StagesCache;

		// Token: 0x04008552 RID: 34130
		private bool _StagesInited;
	}
}
