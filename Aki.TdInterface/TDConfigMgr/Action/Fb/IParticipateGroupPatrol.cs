using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD7 RID: 10967
	public class IParticipateGroupPatrol : ILeisureInteractType
	{
		// Token: 0x0600F17C RID: 61820 RVA: 0x0023528F File Offset: 0x0023348F
		public static IParticipateGroupPatrol Create(IParticipateGroupPatrol? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IParticipateGroupPatrol
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x0600F17D RID: 61821 RVA: 0x002352AE File Offset: 0x002334AE
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x0600F17E RID: 61822 RVA: 0x002352BB File Offset: 0x002334BB
		public virtual int GroupAiEntityId
		{
			get
			{
				return this.Instance.GroupAiEntityId;
			}
		}

		// Token: 0x040084A5 RID: 33957
		private IParticipateGroupPatrol Instance;
	}
}
