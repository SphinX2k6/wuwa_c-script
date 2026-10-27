using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1D RID: 3613
	public class IIntervalSplineSpawnAudioConfigBase
	{
		// Token: 0x060051C0 RID: 20928 RVA: 0x000C9946 File Offset: 0x000C7B46
		[NullableContext(1)]
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

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x000C9965 File Offset: 0x000C7B65
		public virtual EIntervalSplineSpawnAudioConfigType Type
		{
			get
			{
				return (EIntervalSplineSpawnAudioConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04002F14 RID: 12052
		private IIntervalSplineSpawnAudioConfigBase Instance;
	}
}
