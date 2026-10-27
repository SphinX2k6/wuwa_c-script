using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B80 RID: 2944
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterConfig
	{
		// Token: 0x060043C2 RID: 17346 RVA: 0x000AC7E8 File Offset: 0x000AA9E8
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

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x000AC807 File Offset: 0x000AAA07
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x000AC814 File Offset: 0x000AAA14
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x000AC824 File Offset: 0x000AAA24
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

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x060043C6 RID: 17350 RVA: 0x000AC899 File Offset: 0x000AAA99
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

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x000AC8C8 File Offset: 0x000AAAC8
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

		// Token: 0x04002633 RID: 9779
		private ISpawnMonsterConfig Instance;

		// Token: 0x04002634 RID: 9780
		[Nullable(2)]
		private List<int> _TargetsToAwakeCache;

		// Token: 0x04002635 RID: 9781
		private bool _TargetsToAwakeInited;

		// Token: 0x04002636 RID: 9782
		private ISpawnMonsterCompleteCondition _CompleteConditionCache;

		// Token: 0x04002637 RID: 9783
		private bool _CompleteConditionInited;

		// Token: 0x04002638 RID: 9784
		[Nullable(2)]
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x04002639 RID: 9785
		private bool _PreConditionInited;
	}
}
