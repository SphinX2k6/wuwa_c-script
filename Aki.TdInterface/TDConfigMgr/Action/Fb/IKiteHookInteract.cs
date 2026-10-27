using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E6 RID: 10214
	public class IKiteHookInteract : ILeisureInteractType
	{
		// Token: 0x0600E2F6 RID: 58102 RVA: 0x00217D66 File Offset: 0x00215F66
		[NullableContext(1)]
		public static IKiteHookInteract Create(IKiteHookInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKiteHookInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x00217D85 File Offset: 0x00215F85
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x0600E2F8 RID: 58104 RVA: 0x00217D92 File Offset: 0x00215F92
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007DC8 RID: 32200
		private IKiteHookInteract Instance;
	}
}
