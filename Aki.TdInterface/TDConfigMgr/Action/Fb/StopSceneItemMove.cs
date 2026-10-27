using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282D RID: 10285
	[NullableContext(1)]
	[Nullable(0)]
	public class StopSceneItemMove : ActionParams
	{
		// Token: 0x0600E417 RID: 58391 RVA: 0x0021969E File Offset: 0x0021789E
		public static StopSceneItemMove Create(IStopSceneItemMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopSceneItemMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x0600E418 RID: 58392 RVA: 0x002196C0 File Offset: 0x002178C0
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x0600E419 RID: 58393 RVA: 0x00219724 File Offset: 0x00217924
		public virtual EStopSceneItemMoveType? StopType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EStopSceneItemMoveType?((EStopSceneItemMoveType)this.Instance.StopType);
			}
		}

		// Token: 0x04007E39 RID: 32313
		private IStopSceneItemMove Instance;

		// Token: 0x04007E3A RID: 32314
		private List<int> _EntityIdsCache;

		// Token: 0x04007E3B RID: 32315
		private bool _EntityIdsInited;
	}
}
