using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF3 RID: 3315
	[NullableContext(2)]
	[Nullable(0)]
	public class MonsterComponent : IComponentBase
	{
		// Token: 0x06004B89 RID: 19337 RVA: 0x000BD3D7 File Offset: 0x000BB5D7
		[NullableContext(0)]
		public static MonsterComponent Create(IMonsterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MonsterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06004B8A RID: 19338 RVA: 0x000BD3F8 File Offset: 0x000BB5F8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06004B8B RID: 19339 RVA: 0x000BD430 File Offset: 0x000BB630
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06004B8C RID: 19340 RVA: 0x000BD446 File Offset: 0x000BB646
		public virtual int FightConfigId
		{
			get
			{
				return this.Instance.FightConfigId;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06004B8D RID: 19341 RVA: 0x000BD453 File Offset: 0x000BB653
		public virtual IBossStateViewConfig BossViewConfig
		{
			get
			{
				if (this._BossViewConfigInited)
				{
					return this._BossViewConfigCache;
				}
				this._BossViewConfigInited = true;
				this._BossViewConfigCache = IBossStateViewConfig.Create(this.Instance.BossViewConfig);
				return this._BossViewConfigCache;
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x000BD488 File Offset: 0x000BB688
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
				if (this._InitGasTagInited)
				{
					return this._InitGasTagCache;
				}
				this._InitGasTagInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int initGasTagLength = this.Instance.InitGasTagLength;
				this._InitGasTagCache = new List<string>(initGasTagLength);
				for (int i = 0; i < initGasTagLength; i++)
				{
					this._InitGasTagCache.Add(this.Instance.InitGasTag(i));
				}
				return this._InitGasTagCache;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x000BD500 File Offset: 0x000BB700
		public virtual int? SpecialHateAndSenseConfig
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SpecialHateAndSenseConfig);
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06004B90 RID: 19344 RVA: 0x000BD536 File Offset: 0x000BB736
		public virtual IMonsterPerformConfig PerformConfig
		{
			get
			{
				if (this._PerformConfigInited)
				{
					return this._PerformConfigCache;
				}
				this._PerformConfigInited = true;
				this._PerformConfigCache = IMonsterPerformConfig.Create(this.Instance.PerformConfig);
				return this._PerformConfigCache;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x000BD56C File Offset: 0x000BB76C
		public virtual List<int> ShareLifeSubMonsterIds
		{
			get
			{
				if (this._ShareLifeSubMonsterIdsInited)
				{
					return this._ShareLifeSubMonsterIdsCache;
				}
				this._ShareLifeSubMonsterIdsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int shareLifeSubMonsterIdsLength = this.Instance.ShareLifeSubMonsterIdsLength;
				this._ShareLifeSubMonsterIdsCache = new List<int>(shareLifeSubMonsterIdsLength);
				for (int i = 0; i < shareLifeSubMonsterIdsLength; i++)
				{
					this._ShareLifeSubMonsterIdsCache.Add(this.Instance.ShareLifeSubMonsterIds(i));
				}
				return this._ShareLifeSubMonsterIdsCache;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06004B92 RID: 19346 RVA: 0x000BD5E4 File Offset: 0x000BB7E4
		public virtual int? LifeMaxCustomizationId
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.LifeMaxCustomizationId);
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x000BD61B File Offset: 0x000BB81B
		public virtual IMonsterNpcInteractionEnableConfig EnableMonsterNpcInteraction
		{
			get
			{
				if (this._EnableMonsterNpcInteractionInited)
				{
					return this._EnableMonsterNpcInteractionCache;
				}
				this._EnableMonsterNpcInteractionInited = true;
				this._EnableMonsterNpcInteractionCache = IMonsterNpcInteractionEnableConfig.Create(this.Instance.EnableMonsterNpcInteraction);
				return this._EnableMonsterNpcInteractionCache;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x000BD650 File Offset: 0x000BB850
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
				if (this._EnableMonsterCombatInteractionInited)
				{
					return this._EnableMonsterCombatInteractionCache;
				}
				this._EnableMonsterCombatInteractionInited = true;
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				this._EnableMonsterCombatInteractionCache = ComponentReadHelper.ReadMonsterComponent_EnableMonsterCombatInteraction(this.Instance);
				return this._EnableMonsterCombatInteractionCache;
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x000BD69C File Offset: 0x000BB89C
		public virtual IMonsterCommunicationGroupConfig MonsterCommunicationGroup
		{
			get
			{
				if (this._MonsterCommunicationGroupInited)
				{
					return this._MonsterCommunicationGroupCache;
				}
				this._MonsterCommunicationGroupInited = true;
				this._MonsterCommunicationGroupCache = IMonsterCommunicationGroupConfig.Create(this.Instance.MonsterCommunicationGroup);
				return this._MonsterCommunicationGroupCache;
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06004B96 RID: 19350 RVA: 0x000BD6D0 File Offset: 0x000BB8D0
		public virtual List<EExtraMovementAbility> ExtraMovementAbilities
		{
			get
			{
				if (this._ExtraMovementAbilitiesInited)
				{
					return this._ExtraMovementAbilitiesCache;
				}
				this._ExtraMovementAbilitiesInited = true;
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				int extraMovementAbilitiesLength = this.Instance.ExtraMovementAbilitiesLength;
				this._ExtraMovementAbilitiesCache = new List<EExtraMovementAbility>(extraMovementAbilitiesLength);
				for (int i = 0; i < extraMovementAbilitiesLength; i++)
				{
					this._ExtraMovementAbilitiesCache.Add((EExtraMovementAbility)this.Instance.ExtraMovementAbilities(i));
				}
				return this._ExtraMovementAbilitiesCache;
			}
		}

		// Token: 0x04002AAC RID: 10924
		private IMonsterComponent Instance;

		// Token: 0x04002AAD RID: 10925
		private IBossStateViewConfig _BossViewConfigCache;

		// Token: 0x04002AAE RID: 10926
		private bool _BossViewConfigInited;

		// Token: 0x04002AAF RID: 10927
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _InitGasTagCache;

		// Token: 0x04002AB0 RID: 10928
		private bool _InitGasTagInited;

		// Token: 0x04002AB1 RID: 10929
		private IMonsterPerformConfig _PerformConfigCache;

		// Token: 0x04002AB2 RID: 10930
		private bool _PerformConfigInited;

		// Token: 0x04002AB3 RID: 10931
		private List<int> _ShareLifeSubMonsterIdsCache;

		// Token: 0x04002AB4 RID: 10932
		private bool _ShareLifeSubMonsterIdsInited;

		// Token: 0x04002AB5 RID: 10933
		private IMonsterNpcInteractionEnableConfig _EnableMonsterNpcInteractionCache;

		// Token: 0x04002AB6 RID: 10934
		private bool _EnableMonsterNpcInteractionInited;

		// Token: 0x04002AB7 RID: 10935
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMonsterCombatInteractionConfig> _EnableMonsterCombatInteractionCache;

		// Token: 0x04002AB8 RID: 10936
		private bool _EnableMonsterCombatInteractionInited;

		// Token: 0x04002AB9 RID: 10937
		private IMonsterCommunicationGroupConfig _MonsterCommunicationGroupCache;

		// Token: 0x04002ABA RID: 10938
		private bool _MonsterCommunicationGroupInited;

		// Token: 0x04002ABB RID: 10939
		private List<EExtraMovementAbility> _ExtraMovementAbilitiesCache;

		// Token: 0x04002ABC RID: 10940
		private bool _ExtraMovementAbilitiesInited;
	}
}
