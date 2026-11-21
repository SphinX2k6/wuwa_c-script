using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4E RID: 3150
	public class ISpawnMonsterConfig
	{
		// Token: 0x0600481B RID: 18459 RVA: 0x000B68AC File Offset: 0x000B4AAC
		public static ISpawnMonsterConfig Create(ISpawnMonsterConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x000B68CB File Offset: 0x000B4ACB
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x000B68D8 File Offset: 0x000B4AD8
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x000B68E8 File Offset: 0x000B4AE8
		[Nullable(2)]
		public virtual List<int> TargetsToAwake
		{
			[NullableContext(2)]
			get
			{
				if (this._TargetsToAwakeInited)
				{
					return this._TargetsToAwakeCache;
				}
				this._TargetsToAwakeInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int targetsToAwakeLength = this.Instance.TargetsToAwakeLength;
				this._TargetsToAwakeCache = new List<int>(targetsToAwakeLength);
				for (int i = 0; i < targetsToAwakeLength; i++)
				{
					this._TargetsToAwakeCache.Add(this.Instance.TargetsToAwake(i));
				}
				return this._TargetsToAwakeCache;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x000B695D File Offset: 0x000B4B5D
		public virtual ISpawnMonsterCompleteCondition CompleteCondition
		{
			get
			{
				if (this._CompleteConditionInited)
				{
					return this._CompleteConditionCache;
				}
				this._CompleteConditionInited = true;
				this._CompleteConditionCache = ComponentReadHelper.ReadISpawnMonsterConfig_CompleteCondition(this.Instance);
				return this._CompleteConditionCache;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x000B698C File Offset: 0x000B4B8C
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

		// Token: 0x0400287B RID: 10363
		private ISpawnMonsterConfig Instance;

		// Token: 0x0400287C RID: 10364
		[Nullable(2)]
		private List<int> _TargetsToAwakeCache;

		// Token: 0x0400287D RID: 10365
		private bool _TargetsToAwakeInited;

		// Token: 0x0400287E RID: 10366
		private ISpawnMonsterCompleteCondition _CompleteConditionCache;

		// Token: 0x0400287F RID: 10367
		private bool _CompleteConditionInited;

		// Token: 0x04002880 RID: 10368
		[Nullable(2)]
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x04002881 RID: 10369
		private bool _PreConditionInited;
	}
}
