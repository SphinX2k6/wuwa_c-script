using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EA RID: 10218
	public class IGameplayPose3Interact : ILeisureInteractType
	{
		// Token: 0x0600E304 RID: 58116 RVA: 0x00217E77 File Offset: 0x00216077
		[NullableContext(1)]
		public static IGameplayPose3Interact Create(IGameplayPose3Interact? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose3Interact
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x0600E305 RID: 58117 RVA: 0x00217E96 File Offset: 0x00216096
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DCE RID: 32206
		private IGameplayPose3Interact Instance;
	}
}
