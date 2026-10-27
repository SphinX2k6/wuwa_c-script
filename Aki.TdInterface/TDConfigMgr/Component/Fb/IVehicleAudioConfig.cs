using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D48 RID: 3400
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleAudioConfig
	{
		// Token: 0x06004D85 RID: 19845 RVA: 0x000C0CE6 File Offset: 0x000BEEE6
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

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x000C0D05 File Offset: 0x000BEF05
		public virtual float MinVehicleSpeed
		{
			get
			{
				return this.Instance.MinVehicleSpeed;
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06004D87 RID: 19847 RVA: 0x000C0D12 File Offset: 0x000BEF12
		public virtual float MaxVehicleSpeed
		{
			get
			{
				return this.Instance.MaxVehicleSpeed;
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x000C0D1F File Offset: 0x000BEF1F
		public virtual string AudioEvent
		{
			get
			{
				return this.Instance.AudioEvent;
			}
		}

		// Token: 0x04002C71 RID: 11377
		private IVehicleAudioConfig Instance;
	}
}
