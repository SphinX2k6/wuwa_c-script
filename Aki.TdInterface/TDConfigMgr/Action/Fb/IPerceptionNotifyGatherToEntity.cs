using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026DC RID: 9948
	public class IPerceptionNotifyGatherToEntity : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600DE46 RID: 56902 RVA: 0x0020FB3B File Offset: 0x0020DD3B
		[NullableContext(1)]
		public static IPerceptionNotifyGatherToEntity Create(IPerceptionNotifyGatherToEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x0600DE47 RID: 56903 RVA: 0x0020FB5A File Offset: 0x0020DD5A
		public override EBattleStatePerceptionBehavior Type
		{
			get
			{
				return (EBattleStatePerceptionBehavior)this.Instance.Type;
			}
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x0600DE48 RID: 56904 RVA: 0x0020FB67 File Offset: 0x0020DD67
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007B64 RID: 31588
		private IPerceptionNotifyGatherToEntity Instance;
	}
}
