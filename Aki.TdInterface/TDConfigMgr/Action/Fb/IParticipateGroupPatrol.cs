using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002804 RID: 10244
	public class IParticipateGroupPatrol : ILeisureInteractType
	{
		// Token: 0x0600E357 RID: 58199 RVA: 0x0021842B File Offset: 0x0021662B
		[NullableContext(1)]
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

		// Token: 0x17004511 RID: 17681
		// (get) Token: 0x0600E358 RID: 58200 RVA: 0x0021844A File Offset: 0x0021664A
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004512 RID: 17682
		// (get) Token: 0x0600E359 RID: 58201 RVA: 0x00218457 File Offset: 0x00216657
		public virtual int GroupAiEntityId
		{
			get
			{
				return this.Instance.GroupAiEntityId;
			}
		}

		// Token: 0x04007DE8 RID: 32232
		private IParticipateGroupPatrol Instance;
	}
}
