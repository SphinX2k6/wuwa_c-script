using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB0 RID: 3760
	public class IDynamicSpawnMonsterConfig
	{
		// Token: 0x060054C8 RID: 21704 RVA: 0x000D09FE File Offset: 0x000CEBFE
		public static IDynamicSpawnMonsterConfig Create(IDynamicSpawnMonsterConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicSpawnMonsterConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x060054C9 RID: 21705 RVA: 0x000D0A1D File Offset: 0x000CEC1D
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x000D0A2A File Offset: 0x000CEC2A
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x060054CB RID: 21707 RVA: 0x000D0A37 File Offset: 0x000CEC37
		public virtual ISpawnMonsterCompleteCondition CompleteCondition
		{
			get
			{
				if (this._CompleteConditionInited)
				{
					return this._CompleteConditionCache;
				}
				this._CompleteConditionInited = true;
				this._CompleteConditionCache = ComponentReadHelper.ReadIDynamicSpawnMonsterConfig_CompleteCondition(this.Instance);
				return this._CompleteConditionCache;
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x000D0A66 File Offset: 0x000CEC66
		public virtual ISpawnMonsterPreDependOnPreceding PreCondition
		{
			get
			{
				if (this._PreConditionInited)
				{
					return this._PreConditionCache;
				}
				this._PreConditionInited = true;
				this._PreConditionCache = ISpawnMonsterPreDependOnPreceding.Create(this.Instance.PreCondition);
				return this._PreConditionCache;
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x000D0A9C File Offset: 0x000CEC9C
		public virtual float? Interval
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Interval);
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x000D0AD2 File Offset: 0x000CECD2
		public virtual IRandomPoolChoose MonsterChooseType
		{
			get
			{
				if (this._MonsterChooseTypeInited)
				{
					return this._MonsterChooseTypeCache;
				}
				this._MonsterChooseTypeInited = true;
				this._MonsterChooseTypeCache = IRandomPoolChoose.Create(this.Instance.MonsterChooseType);
				return this._MonsterChooseTypeCache;
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x060054CF RID: 21711 RVA: 0x000D0B06 File Offset: 0x000CED06
		public virtual ISpawnMonsterPoint PointChooseType
		{
			get
			{
				if (this._PointChooseTypeInited)
				{
					return this._PointChooseTypeCache;
				}
				this._PointChooseTypeInited = true;
				this._PointChooseTypeCache = ISpawnMonsterPoint.Create(this.Instance.PointChooseType);
				return this._PointChooseTypeCache;
			}
		}

		// Token: 0x04003073 RID: 12403
		private IDynamicSpawnMonsterConfig Instance;

		// Token: 0x04003074 RID: 12404
		private ISpawnMonsterCompleteCondition _CompleteConditionCache;

		// Token: 0x04003075 RID: 12405
		private bool _CompleteConditionInited;

		// Token: 0x04003076 RID: 12406
		[Nullable(2)]
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x04003077 RID: 12407
		private bool _PreConditionInited;

		// Token: 0x04003078 RID: 12408
		[Nullable(2)]
		private IRandomPoolChoose _MonsterChooseTypeCache;

		// Token: 0x04003079 RID: 12409
		private bool _MonsterChooseTypeInited;

		// Token: 0x0400307A RID: 12410
		[Nullable(2)]
		private ISpawnMonsterPoint _PointChooseTypeCache;

		// Token: 0x0400307B RID: 12411
		private bool _PointChooseTypeInited;
	}
}
