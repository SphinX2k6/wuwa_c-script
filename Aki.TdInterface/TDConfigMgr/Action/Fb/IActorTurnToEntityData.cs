using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A8 RID: 9640
	public class IActorTurnToEntityData : IActorTurnToData
	{
		// Token: 0x0600D8E6 RID: 55526 RVA: 0x00205EAA File Offset: 0x002040AA
		[NullableContext(1)]
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

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x0600D8E7 RID: 55527 RVA: 0x00205EC9 File Offset: 0x002040C9
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x0600D8E8 RID: 55528 RVA: 0x00205ED6 File Offset: 0x002040D6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007882 RID: 30850
		private IActorTurnToEntityData Instance;
	}
}
