using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E9 RID: 10217
	public class IGameplayPose2Interact : ILeisureInteractType
	{
		// Token: 0x0600E301 RID: 58113 RVA: 0x00217E43 File Offset: 0x00216043
		[NullableContext(1)]
		public static IGameplayPose2Interact Create(IGameplayPose2Interact? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose2Interact
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x0600E302 RID: 58114 RVA: 0x00217E62 File Offset: 0x00216062
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DCD RID: 32205
		private IGameplayPose2Interact Instance;
	}
}
