using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000837 RID: 2103
	[NullableContext(2)]
	[Nullable(0)]
	public class MonsterComponent : IComponentBase
	{
		// Token: 0x06002DFD RID: 11773 RVA: 0x00076FBC File Offset: 0x000751BC
		[NullableContext(1)]
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

		// Token: 0x06002DFE RID: 11774 RVA: 0x00076FF4 File Offset: 0x000751F4
		[NullableContext(1)]
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

		// Token: 0x06002DFF RID: 11775 RVA: 0x00077007 File Offset: 0x00075207
		[NullableContext(1)]
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

		// Token: 0x06002E00 RID: 11776 RVA: 0x0007701C File Offset: 0x0007521C
		[NullableContext(1)]
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
				MonsterCommunicationGroup = this.MonsterCommunicationGroup
			};
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000770B4 File Offset: 0x000752B4
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x000770EE File Offset: 0x000752EE
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

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000770FC File Offset: 0x000752FC
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00077126 File Offset: 0x00075326
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

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x00077134 File Offset: 0x00075334
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x0007715F File Offset: 0x0007535F
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

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x00077170 File Offset: 0x00075370
		// (set) Token: 0x06002E08 RID: 11784 RVA: 0x000771D1 File Offset: 0x000753D1
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

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x000771E6 File Offset: 0x000753E6
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x0007720D File Offset: 0x0007540D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> InitGasTag
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().InitGasTag = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x0007721C File Offset: 0x0007541C
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x00077256 File Offset: 0x00075456
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

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00077264 File Offset: 0x00075464
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x000772C5 File Offset: 0x000754C5
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

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x000772DA File Offset: 0x000754DA
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x00077301 File Offset: 0x00075501
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

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x00077310 File Offset: 0x00075510
		// (set) Token: 0x06002E12 RID: 11794 RVA: 0x0007734A File Offset: 0x0007554A
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

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x00077358 File Offset: 0x00075558
		// (set) Token: 0x06002E14 RID: 11796 RVA: 0x000773B9 File Offset: 0x000755B9
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

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x000773D0 File Offset: 0x000755D0
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x00077431 File Offset: 0x00075631
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

		// Token: 0x04001E63 RID: 7779
		protected new MonsterComponent FbInstance;

		// Token: 0x04001E64 RID: 7780
		protected new MonsterComponent_SetValue PocoInterface;

		// Token: 0x04001E65 RID: 7781
		[Nullable(1)]
		private IBossStateViewConfig _BossViewConfigCache;

		// Token: 0x04001E66 RID: 7782
		private bool _BossViewConfigInited;

		// Token: 0x04001E67 RID: 7783
		[Nullable(1)]
		private IMonsterPerformConfig _PerformConfigCache;

		// Token: 0x04001E68 RID: 7784
		private bool _PerformConfigInited;

		// Token: 0x04001E69 RID: 7785
		[Nullable(1)]
		private IMonsterNpcInteractionEnableConfig _EnableMonsterNpcInteractionCache;

		// Token: 0x04001E6A RID: 7786
		private bool _EnableMonsterNpcInteractionInited;

		// Token: 0x04001E6B RID: 7787
		[Nullable(1)]
		private IMonsterCommunicationGroupConfig _MonsterCommunicationGroupCache;

		// Token: 0x04001E6C RID: 7788
		private bool _MonsterCommunicationGroupInited;
	}
}
