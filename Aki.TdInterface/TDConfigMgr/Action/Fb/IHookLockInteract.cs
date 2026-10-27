using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E5 RID: 10213
	public class IHookLockInteract : ILeisureInteractType
	{
		// Token: 0x0600E2F2 RID: 58098 RVA: 0x00217D25 File Offset: 0x00215F25
		[NullableContext(1)]
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

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x0600E2F3 RID: 58099 RVA: 0x00217D44 File Offset: 0x00215F44
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x0600E2F4 RID: 58100 RVA: 0x00217D51 File Offset: 0x00215F51
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007DC7 RID: 32199
		private IHookLockInteract Instance;
	}
}
