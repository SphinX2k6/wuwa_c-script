using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DD8 RID: 11736
	public class IResetPresentationFailure : IPresentationType
	{
		// Token: 0x0600FF63 RID: 65379 RVA: 0x0024CCFE File Offset: 0x0024AEFE
		public static IResetPresentationFailure Create(IResetPresentationFailure? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPresentationFailure
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005061 RID: 20577
		// (get) Token: 0x0600FF64 RID: 65380 RVA: 0x0024CD1D File Offset: 0x0024AF1D
		public override EResetPresentationType Type
		{
			get
			{
				return (EResetPresentationType)this.Instance.Type;
			}
		}

		// Token: 0x17005062 RID: 20578
		// (get) Token: 0x0600FF65 RID: 65381 RVA: 0x0024CD2A File Offset: 0x0024AF2A
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x0600FF66 RID: 65382 RVA: 0x0024CD38 File Offset: 0x0024AF38
		public virtual List<int> GamePlayCues
		{
			get
			{
				if (this._GamePlayCuesInited)
				{
					return this._GamePlayCuesCache;
				}
				this._GamePlayCuesInited = true;
				int gamePlayCuesLength = this.Instance.GamePlayCuesLength;
				this._GamePlayCuesCache = new List<int>(gamePlayCuesLength);
				for (int i = 0; i < gamePlayCuesLength; i++)
				{
					this._GamePlayCuesCache.Add(this.Instance.GamePlayCues(i));
				}
				return this._GamePlayCuesCache;
			}
		}

		// Token: 0x04008B6E RID: 35694
		private IResetPresentationFailure Instance;

		// Token: 0x04008B6F RID: 35695
		private List<int> _GamePlayCuesCache;

		// Token: 0x04008B70 RID: 35696
		private bool _GamePlayCuesInited;
	}
}
