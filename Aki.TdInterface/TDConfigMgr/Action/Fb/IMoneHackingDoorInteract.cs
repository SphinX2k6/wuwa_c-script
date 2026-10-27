using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002802 RID: 10242
	public class IMoneHackingDoorInteract : ILeisureInteractType
	{
		// Token: 0x0600E351 RID: 58193 RVA: 0x002183C3 File Offset: 0x002165C3
		[NullableContext(1)]
		public static IMoneHackingDoorInteract Create(IMoneHackingDoorInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoneHackingDoorInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x0600E352 RID: 58194 RVA: 0x002183E2 File Offset: 0x002165E2
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DE6 RID: 32230
		private IMoneHackingDoorInteract Instance;
	}
}
