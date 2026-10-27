using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA9 RID: 2985
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetGearGroupConfig
	{
		// Token: 0x0600447D RID: 17533 RVA: 0x000ADEA1 File Offset: 0x000AC0A1
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

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x000ADEC0 File Offset: 0x000AC0C0
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

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x000ADF24 File Offset: 0x000AC124
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

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x000ADF53 File Offset: 0x000AC153
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

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x000ADF84 File Offset: 0x000AC184
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ICheckGearHit> CheckGears
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x000ADFFE File Offset: 0x000AC1FE
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

		// Token: 0x040026AC RID: 9900
		private ITargetGearGroupConfig Instance;

		// Token: 0x040026AD RID: 9901
		private List<int> _EntitysCache;

		// Token: 0x040026AE RID: 9902
		private bool _EntitysInited;

		// Token: 0x040026AF RID: 9903
		private ITargetGearGroupSuccessContdion _SuccessConditionCache;

		// Token: 0x040026B0 RID: 9904
		private bool _SuccessConditionInited;

		// Token: 0x040026B1 RID: 9905
		private List<ITargetGearGroupFailureCondition> _FailureConditionsCache;

		// Token: 0x040026B2 RID: 9906
		private bool _FailureConditionsInited;

		// Token: 0x040026B3 RID: 9907
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICheckGearHit> _CheckGearsCache;

		// Token: 0x040026B4 RID: 9908
		private bool _CheckGearsInited;

		// Token: 0x040026B5 RID: 9909
		private IGroupFinishConfig _FinishConfigCache;

		// Token: 0x040026B6 RID: 9910
		private bool _FinishConfigInited;
	}
}
