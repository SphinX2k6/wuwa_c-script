using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A2 RID: 10658
	public class INotifyMonsterPerception : ISendBattleStateType
	{
		// Token: 0x0600EC29 RID: 60457 RVA: 0x0022C3F0 File Offset: 0x0022A5F0
		public static INotifyMonsterPerception Create(INotifyMonsterPerception? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INotifyMonsterPerception
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x0600EC2A RID: 60458 RVA: 0x0022C40F File Offset: 0x0022A60F
		public override ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x0600EC2B RID: 60459 RVA: 0x0022C41C File Offset: 0x0022A61C
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x0600EC2C RID: 60460 RVA: 0x0022C480 File Offset: 0x0022A680
		public virtual IBattleStatePerceptionBehaviorType PerceptionBehaviorOption
		{
			get
			{
				if (this._PerceptionBehaviorOptionInited)
				{
					return this._PerceptionBehaviorOptionCache;
				}
				this._PerceptionBehaviorOptionInited = true;
				this._PerceptionBehaviorOptionCache = ActionReadHelper.ReadINotifyMonsterPerception_PerceptionBehaviorOption(this.Instance);
				return this._PerceptionBehaviorOptionCache;
			}
		}

		// Token: 0x04008206 RID: 33286
		private INotifyMonsterPerception Instance;

		// Token: 0x04008207 RID: 33287
		private List<int> _EntityIdsCache;

		// Token: 0x04008208 RID: 33288
		private bool _EntityIdsInited;

		// Token: 0x04008209 RID: 33289
		private IBattleStatePerceptionBehaviorType _PerceptionBehaviorOptionCache;

		// Token: 0x0400820A RID: 33290
		private bool _PerceptionBehaviorOptionInited;
	}
}
