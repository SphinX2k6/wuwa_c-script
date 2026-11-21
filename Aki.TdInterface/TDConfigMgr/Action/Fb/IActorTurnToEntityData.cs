using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002857 RID: 10327
	public class IActorTurnToEntityData : IActorTurnToData
	{
		// Token: 0x0600E660 RID: 58976 RVA: 0x00221B7E File Offset: 0x0021FD7E
		public static IActorTurnToEntityData Create(IActorTurnToEntityData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToEntityData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x0600E661 RID: 58977 RVA: 0x00221B9D File Offset: 0x0021FD9D
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x0600E662 RID: 58978 RVA: 0x00221BAA File Offset: 0x0021FDAA
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007EE9 RID: 32489
		private IActorTurnToEntityData Instance;
	}
}
