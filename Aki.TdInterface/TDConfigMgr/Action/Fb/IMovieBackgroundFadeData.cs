using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D8 RID: 9688
	public class IMovieBackgroundFadeData
	{
		// Token: 0x0600D9CA RID: 55754 RVA: 0x00207AB6 File Offset: 0x00205CB6
		[NullableContext(1)]
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

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x0600D9CB RID: 55755 RVA: 0x00207AD5 File Offset: 0x00205CD5
		public virtual EMovieBackgroundType FadeInBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.Instance.FadeInBackgroundType;
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x0600D9CC RID: 55756 RVA: 0x00207AE2 File Offset: 0x00205CE2
		public virtual EMovieBackgroundType FadeOutBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.Instance.FadeOutBackgroundType;
			}
		}

		// Token: 0x040078F4 RID: 30964
		private IMovieBackgroundFadeData Instance;
	}
}
