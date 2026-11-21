using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002897 RID: 10391
	public class IMovieBackgroundFadeData
	{
		// Token: 0x0600E792 RID: 59282 RVA: 0x0022416A File Offset: 0x0022236A
		public static IMovieBackgroundFadeData Create(IMovieBackgroundFadeData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovieBackgroundFadeData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x0600E793 RID: 59283 RVA: 0x00224189 File Offset: 0x00222389
		public virtual EMovieBackgroundType FadeInBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.Instance.FadeInBackgroundType;
			}
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x0600E794 RID: 59284 RVA: 0x00224196 File Offset: 0x00222396
		public virtual EMovieBackgroundType FadeOutBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.Instance.FadeOutBackgroundType;
			}
		}

		// Token: 0x04007F8B RID: 32651
		private IMovieBackgroundFadeData Instance;
	}
}
