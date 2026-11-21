using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C77 RID: 3191
	public class ITargetGearGroupConfig
	{
		// Token: 0x060048D6 RID: 18646 RVA: 0x000B7F65 File Offset: 0x000B6165
		public static ITargetGearGroupConfig Create(ITargetGearGroupConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x000B7F84 File Offset: 0x000B6184
		public virtual List<int> Entitys
		{
			get
			{
				if (this._EntitysInited)
				{
					return this._EntitysCache;
				}
				this._EntitysInited = true;
				int entitysLength = this.Instance.EntitysLength;
				this._EntitysCache = new List<int>(entitysLength);
				for (int i = 0; i < entitysLength; i++)
				{
					this._EntitysCache.Add(this.Instance.Entitys(i));
				}
				return this._EntitysCache;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x000B7FE8 File Offset: 0x000B61E8
		public virtual ITargetGearGroupSuccessContdion SuccessCondition
		{
			get
			{
				if (this._SuccessConditionInited)
				{
					return this._SuccessConditionCache;
				}
				this._SuccessConditionInited = true;
				this._SuccessConditionCache = ComponentReadHelper.ReadITargetGearGroupConfig_SuccessCondition(this.Instance);
				return this._SuccessConditionCache;
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x000B8017 File Offset: 0x000B6217
		public virtual List<ITargetGearGroupFailureCondition> FailureConditions
		{
			get
			{
				if (this._FailureConditionsInited)
				{
					return this._FailureConditionsCache;
				}
				this._FailureConditionsInited = true;
				this._FailureConditionsCache = ComponentReadHelper.ReadITargetGearGroupConfig_FailureConditions(this.Instance);
				return this._FailureConditionsCache;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x000B8048 File Offset: 0x000B6248
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ICheckGearHit> CheckGears
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._CheckGearsInited)
				{
					return this._CheckGearsCache;
				}
				this._CheckGearsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int checkGearsLength = this.Instance.CheckGearsLength;
				this._CheckGearsCache = new List<ICheckGearHit>(checkGearsLength);
				for (int i = 0; i < checkGearsLength; i++)
				{
					this._CheckGearsCache.Add(ICheckGearHit.Create(this.Instance.CheckGears(i)));
				}
				return this._CheckGearsCache;
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x000B80C2 File Offset: 0x000B62C2
		public virtual IGroupFinishConfig FinishConfig
		{
			get
			{
				if (this._FinishConfigInited)
				{
					return this._FinishConfigCache;
				}
				this._FinishConfigInited = true;
				this._FinishConfigCache = ComponentReadHelper.ReadITargetGearGroupConfig_FinishConfig(this.Instance);
				return this._FinishConfigCache;
			}
		}

		// Token: 0x040028F4 RID: 10484
		private ITargetGearGroupConfig Instance;

		// Token: 0x040028F5 RID: 10485
		private List<int> _EntitysCache;

		// Token: 0x040028F6 RID: 10486
		private bool _EntitysInited;

		// Token: 0x040028F7 RID: 10487
		private ITargetGearGroupSuccessContdion _SuccessConditionCache;

		// Token: 0x040028F8 RID: 10488
		private bool _SuccessConditionInited;

		// Token: 0x040028F9 RID: 10489
		private List<ITargetGearGroupFailureCondition> _FailureConditionsCache;

		// Token: 0x040028FA RID: 10490
		private bool _FailureConditionsInited;

		// Token: 0x040028FB RID: 10491
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ICheckGearHit> _CheckGearsCache;

		// Token: 0x040028FC RID: 10492
		private bool _CheckGearsInited;

		// Token: 0x040028FD RID: 10493
		private IGroupFinishConfig _FinishConfigCache;

		// Token: 0x040028FE RID: 10494
		private bool _FinishConfigInited;
	}
}
