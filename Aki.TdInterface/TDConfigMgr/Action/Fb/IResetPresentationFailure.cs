using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE4 RID: 10980
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetPresentationFailure : IPresentationType
	{
		// Token: 0x0600F0AD RID: 61613 RVA: 0x0022EFF2 File Offset: 0x0022D1F2
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

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x0600F0AE RID: 61614 RVA: 0x0022F011 File Offset: 0x0022D211
		public override EResetPresentationType Type
		{
			get
			{
				return (EResetPresentationType)this.Instance.Type;
			}
		}

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x0600F0AF RID: 61615 RVA: 0x0022F01E File Offset: 0x0022D21E
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x0600F0B0 RID: 61616 RVA: 0x0022F02C File Offset: 0x0022D22C
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

		// Token: 0x0400846A RID: 33898
		private IResetPresentationFailure Instance;

		// Token: 0x0400846B RID: 33899
		private List<int> _GamePlayCuesCache;

		// Token: 0x0400846C RID: 33900
		private bool _GamePlayCuesInited;
	}
}
