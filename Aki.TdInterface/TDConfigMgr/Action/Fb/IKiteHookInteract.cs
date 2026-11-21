using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB9 RID: 10937
	public class IKiteHookInteract : ILeisureInteractType
	{
		// Token: 0x0600F11B RID: 61723 RVA: 0x00234BC9 File Offset: 0x00232DC9
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

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x0600F11C RID: 61724 RVA: 0x00234BE8 File Offset: 0x00232DE8
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x0600F11D RID: 61725 RVA: 0x00234BF5 File Offset: 0x00232DF5
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008485 RID: 33925
		private IKiteHookInteract Instance;
	}
}
