using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026DE RID: 9950
	[NullableContext(1)]
	[Nullable(0)]
	public class INotifyMonsterPerception : ISendBattleStateType
	{
		// Token: 0x0600DE4D RID: 56909 RVA: 0x0020FBB0 File Offset: 0x0020DDB0
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

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x0020FBCF File Offset: 0x0020DDCF
		public override ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x0600DE4F RID: 56911 RVA: 0x0020FBDC File Offset: 0x0020DDDC
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

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x0600DE50 RID: 56912 RVA: 0x0020FC40 File Offset: 0x0020DE40
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

		// Token: 0x04007B66 RID: 31590
		private INotifyMonsterPerception Instance;

		// Token: 0x04007B67 RID: 31591
		private List<int> _EntityIdsCache;

		// Token: 0x04007B68 RID: 31592
		private bool _EntityIdsInited;

		// Token: 0x04007B69 RID: 31593
		private IBattleStatePerceptionBehaviorType _PerceptionBehaviorOptionCache;

		// Token: 0x04007B6A RID: 31594
		private bool _PerceptionBehaviorOptionInited;
	}
}
