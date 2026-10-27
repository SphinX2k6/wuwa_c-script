using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB4 RID: 3508
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicSpawnMonsterConfig
	{
		// Token: 0x06004FA3 RID: 20387 RVA: 0x000C51AE File Offset: 0x000C33AE
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

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x000C51CD File Offset: 0x000C33CD
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x000C51DA File Offset: 0x000C33DA
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x000C51E7 File Offset: 0x000C33E7
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

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x000C5216 File Offset: 0x000C3416
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

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x000C524C File Offset: 0x000C344C
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

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x000C5282 File Offset: 0x000C3482
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

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06004FAA RID: 20394 RVA: 0x000C52B6 File Offset: 0x000C34B6
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

		// Token: 0x04002DAD RID: 11693
		private IDynamicSpawnMonsterConfig Instance;

		// Token: 0x04002DAE RID: 11694
		private ISpawnMonsterCompleteCondition _CompleteConditionCache;

		// Token: 0x04002DAF RID: 11695
		private bool _CompleteConditionInited;

		// Token: 0x04002DB0 RID: 11696
		[Nullable(2)]
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x04002DB1 RID: 11697
		private bool _PreConditionInited;

		// Token: 0x04002DB2 RID: 11698
		[Nullable(2)]
		private IRandomPoolChoose _MonsterChooseTypeCache;

		// Token: 0x04002DB3 RID: 11699
		private bool _MonsterChooseTypeInited;

		// Token: 0x04002DB4 RID: 11700
		[Nullable(2)]
		private ISpawnMonsterPoint _PointChooseTypeCache;

		// Token: 0x04002DB5 RID: 11701
		private bool _PointChooseTypeInited;
	}
}
