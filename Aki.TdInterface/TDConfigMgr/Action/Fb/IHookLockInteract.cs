using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB8 RID: 10936
	public class IHookLockInteract : ILeisureInteractType
	{
		// Token: 0x0600F117 RID: 61719 RVA: 0x00234B88 File Offset: 0x00232D88
		public static IHookLockInteract Create(IHookLockInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x0600F118 RID: 61720 RVA: 0x00234BA7 File Offset: 0x00232DA7
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x0600F119 RID: 61721 RVA: 0x00234BB4 File Offset: 0x00232DB4
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008484 RID: 33924
		private IHookLockInteract Instance;
	}
}
