using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008DA RID: 2266
	[NullableContext(2)]
	[Nullable(0)]
	public class MonsterComponent : IComponentBase
	{
		// Token: 0x0600312F RID: 12591 RVA: 0x0007E360 File Offset: 0x0007C560
		[NullableContext(0)]
		private MonsterComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MonsterComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MonsterComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MonsterComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x0007E398 File Offset: 0x0007C598
		[NullableContext(0)]
		public static MonsterComponent Create([Nullable(2)] MonsterComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MonsterComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x0007E3AB File Offset: 0x0007C5AB
		[NullableContext(0)]
		public static MonsterComponent CreateFromSetValue([Nullable(2)] MonsterComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MonsterComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x0007E3C0 File Offset: 0x0007C5C0
		[NullableContext(0)]
		public new MonsterComponent_SetValue ToSetValue()
		{
			return new MonsterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				FightConfigId = this.FightConfigId,
				BossViewConfig = this.BossViewConfig,
				InitGasTag = this.InitGasTag,
				SpecialHateAndSenseConfig = this.SpecialHateAndSenseConfig,
				PerformConfig = this.PerformConfig,
				ShareLifeSubMonsterIds = this.ShareLifeSubMonsterIds,
				LifeMaxCustomizationId = this.LifeMaxCustomizationId,
				EnableMonsterNpcInteraction = this.EnableMonsterNpcInteraction,
				EnableMonsterCombatInteraction = this.EnableMonsterCombatInteraction,
				MonsterCommunicationGroup = this.MonsterCommunicationGroup,
				ExtraMovementAbilities = this.ExtraMovementAbilities
			};
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x0007E470 File Offset: 0x0007C670
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x0007E4AA File Offset: 0x0007C6AA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				MonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x0007E4B8 File Offset: 0x0007C6B8
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x0007E4E2 File Offset: 0x0007C6E2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x0007E4F0 File Offset: 0x0007C6F0
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x0007E51B File Offset: 0x0007C71B
		public virtual int FightConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FightConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FightConfigId;
			}
			set
			{
				this.GetOrCreatePoco().FightConfigId = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x0007E52C File Offset: 0x0007C72C
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x0007E58D File Offset: 0x0007C78D
		public virtual IBossStateViewConfig BossViewConfig
		{
			get
			{
				if (this._BossViewConfigInited)
				{
					return this._BossViewConfigCache;
				}
				this._BossViewConfigInited = true;
				if (this.FbInstance != null)
				{
					this._BossViewConfigCache = IBossStateViewConfig.Create(this.FbInstance.BossViewConfig);
				}
				else
				{
					MonsterComponent_SetValue pocoInterface = this.PocoInterface;
					this._BossViewConfigCache = ((pocoInterface != null) ? pocoInterface.BossViewConfig : null);
				}
				return this._BossViewConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().BossViewConfig = value;
				this._BossViewConfigInited = false;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x0007E5A2 File Offset: 0x0007C7A2
		// (set) Token: 0x0600313C RID: 12604 RVA: 0x0007E5C9 File Offset: 0x0007C7C9
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> InitGasTag
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitGasTag;
				}
				MonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitGasTag;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().InitGasTag = value;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x0007E5D8 File Offset: 0x0007C7D8
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x0007E612 File Offset: 0x0007C812
		public virtual int? SpecialHateAndSenseConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpecialHateAndSenseConfig;
				}
				MonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpecialHateAndSenseConfig;
			}
			set
			{
				this.GetOrCreatePoco().SpecialHateAndSenseConfig = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x0007E620 File Offset: 0x0007C820
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x0007E681 File Offset: 0x0007C881
		public virtual IMonsterPerformConfig PerformConfig
		{
			get
			{
				if (this._PerformConfigInited)
				{
					return this._PerformConfigCache;
				}
				this._PerformConfigInited = true;
				if (this.FbInstance != null)
				{
					this._PerformConfigCache = IMonsterPerformConfig.Create(this.FbInstance.PerformConfig);
				}
				else
				{
					MonsterComponent_SetValue pocoInterface = this.PocoInterface;
					this._PerformConfigCache = ((pocoInterface != null) ? pocoInterface.PerformConfig : null);
				}
				return this._PerformConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PerformConfig = value;
				this._PerformConfigInited = false;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x0007E696 File Offset: 0x0007C896
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x0007E6BD File Offset: 0x0007C8BD
		public virtual List<int> ShareLifeSubMonsterIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShareLifeSubMonsterIds;
				}
				MonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShareLifeSubMonsterIds;
			}
			set
			{
				this.GetOrCreatePoco().ShareLifeSubMonsterIds = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x0007E6CC File Offset: 0x0007C8CC
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x0007E706 File Offset: 0x0007C906
		public virtual int? LifeMaxCustomizationId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LifeMaxCustomizationId;
				}
				MonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LifeMaxCustomizationId;
			}
			set
			{
				this.GetOrCreatePoco().LifeMaxCustomizationId = value;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x0007E714 File Offset: 0x0007C914
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x0007E775 File Offset: 0x0007C975
		public virtual IMonsterNpcInteractionEnableConfig EnableMonsterNpcInteraction
		{
			get
			{
				if (this._EnableMonsterNpcInteractionInited)
				{
					return this._EnableMonsterNpcInteractionCache;
				}
				this._EnableMonsterNpcInteractionInited = true;
				if (this.FbInstance != null)
				{
					this._EnableMonsterNpcInteractionCache = IMonsterNpcInteractionEnableConfig.Create(this.FbInstance.EnableMonsterNpcInteraction);
				}
				else
				{
					MonsterComponent_SetValue pocoInterface = this.PocoInterface;
					this._EnableMonsterNpcInteractionCache = ((pocoInterface != null) ? pocoInterface.EnableMonsterNpcInteraction : null);
				}
				return this._EnableMonsterNpcInteractionCache;
			}
			set
			{
				this.GetOrCreatePoco().EnableMonsterNpcInteraction = value;
				this._EnableMonsterNpcInteractionInited = false;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x0007E78A File Offset: 0x0007C98A
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x0007E7B1 File Offset: 0x0007C9B1
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMonsterCombatInteractionConfig> EnableMonsterCombatInteraction
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableMonsterCombatInteraction;
				}
				MonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableMonsterCombatInteraction;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().EnableMonsterCombatInteraction = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x0007E7C0 File Offset: 0x0007C9C0
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x0007E821 File Offset: 0x0007CA21
		public virtual IMonsterCommunicationGroupConfig MonsterCommunicationGroup
		{
			get
			{
				if (this._MonsterCommunicationGroupInited)
				{
					return this._MonsterCommunicationGroupCache;
				}
				this._MonsterCommunicationGroupInited = true;
				if (this.FbInstance != null)
				{
					this._MonsterCommunicationGroupCache = IMonsterCommunicationGroupConfig.Create(this.FbInstance.MonsterCommunicationGroup);
				}
				else
				{
					MonsterComponent_SetValue pocoInterface = this.PocoInterface;
					this._MonsterCommunicationGroupCache = ((pocoInterface != null) ? pocoInterface.MonsterCommunicationGroup : null);
				}
				return this._MonsterCommunicationGroupCache;
			}
			set
			{
				this.GetOrCreatePoco().MonsterCommunicationGroup = value;
				this._MonsterCommunicationGroupInited = false;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x0007E836 File Offset: 0x0007CA36
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x0007E85D File Offset: 0x0007CA5D
		public virtual List<EExtraMovementAbility> ExtraMovementAbilities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExtraMovementAbilities;
				}
				MonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExtraMovementAbilities;
			}
			set
			{
				this.GetOrCreatePoco().ExtraMovementAbilities = value;
			}
		}

		// Token: 0x04002070 RID: 8304
		protected new MonsterComponent FbInstance;

		// Token: 0x04002071 RID: 8305
		protected new MonsterComponent_SetValue PocoInterface;

		// Token: 0x04002072 RID: 8306
		[Nullable(0)]
		private IBossStateViewConfig _BossViewConfigCache;

		// Token: 0x04002073 RID: 8307
		private bool _BossViewConfigInited;

		// Token: 0x04002074 RID: 8308
		[Nullable(0)]
		private IMonsterPerformConfig _PerformConfigCache;

		// Token: 0x04002075 RID: 8309
		private bool _PerformConfigInited;

		// Token: 0x04002076 RID: 8310
		[Nullable(0)]
		private IMonsterNpcInteractionEnableConfig _EnableMonsterNpcInteractionCache;

		// Token: 0x04002077 RID: 8311
		private bool _EnableMonsterNpcInteractionInited;

		// Token: 0x04002078 RID: 8312
		[Nullable(0)]
		private IMonsterCommunicationGroupConfig _MonsterCommunicationGroupCache;

		// Token: 0x04002079 RID: 8313
		private bool _MonsterCommunicationGroupInited;
	}
}
