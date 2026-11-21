using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F19 RID: 3865
	public class IIntervalSplineSpawnAudioConfigBase
	{
		// Token: 0x060056E7 RID: 22247 RVA: 0x000D520E File Offset: 0x000D340E
		public static IIntervalSplineSpawnAudioConfigBase Create(IIntervalSplineSpawnAudioConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIntervalSplineSpawnAudioConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x060056E8 RID: 22248 RVA: 0x000D522D File Offset: 0x000D342D
		public virtual EIntervalSplineSpawnAudioConfigType Type
		{
			get
			{
				return (EIntervalSplineSpawnAudioConfigType)this.Instance.Type;
			}
		}

		// Token: 0x040031DC RID: 12764
		private IIntervalSplineSpawnAudioConfigBase Instance;
	}
}
