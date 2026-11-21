using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E42 RID: 3650
	public class IVehicleAudioConfig
	{
		// Token: 0x060052A1 RID: 21153 RVA: 0x000CC42A File Offset: 0x000CA62A
		public static IVehicleAudioConfig Create(IVehicleAudioConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleAudioConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060052A2 RID: 21154 RVA: 0x000CC449 File Offset: 0x000CA649
		public virtual float MinVehicleSpeed
		{
			get
			{
				return this.Instance.MinVehicleSpeed;
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060052A3 RID: 21155 RVA: 0x000CC456 File Offset: 0x000CA656
		public virtual float MaxVehicleSpeed
		{
			get
			{
				return this.Instance.MaxVehicleSpeed;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060052A4 RID: 21156 RVA: 0x000CC463 File Offset: 0x000CA663
		public virtual string AudioEvent
		{
			get
			{
				return this.Instance.AudioEvent;
			}
		}

		// Token: 0x04002F31 RID: 12081
		private IVehicleAudioConfig Instance;
	}
}
