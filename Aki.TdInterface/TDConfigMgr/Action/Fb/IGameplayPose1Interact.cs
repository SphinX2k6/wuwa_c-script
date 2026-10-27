using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E8 RID: 10216
	public class IGameplayPose1Interact : ILeisureInteractType
	{
		// Token: 0x0600E2FE RID: 58110 RVA: 0x00217E0F File Offset: 0x0021600F
		[NullableContext(1)]
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

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x00217E2E File Offset: 0x0021602E
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DCC RID: 32204
		private IGameplayPose1Interact Instance;
	}
}
