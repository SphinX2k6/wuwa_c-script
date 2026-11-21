using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABB RID: 10939
	public class IGameplayPose1Interact : ILeisureInteractType
	{
		// Token: 0x0600F123 RID: 61731 RVA: 0x00234C72 File Offset: 0x00232E72
		public static IGameplayPose1Interact Create(IGameplayPose1Interact? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose1Interact
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x0600F124 RID: 61732 RVA: 0x00234C91 File Offset: 0x00232E91
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008489 RID: 33929
		private IGameplayPose1Interact Instance;
	}
}
