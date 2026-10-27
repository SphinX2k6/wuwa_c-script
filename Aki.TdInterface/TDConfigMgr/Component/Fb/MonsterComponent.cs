using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C20 RID: 3104
	[NullableContext(2)]
	[Nullable(0)]
	public class MonsterComponent : IComponentBase
	{
		// Token: 0x0600471C RID: 18204 RVA: 0x000B3162 File Offset: 0x000B1362
		[NullableContext(1)]
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600471D RID: 18205 RVA: 0x000B3184 File Offset: 0x000B1384
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

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x0600471E RID: 18206 RVA: 0x000B31BC File Offset: 0x000B13BC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x000B31D2 File Offset: 0x000B13D2
		public virtual int FightConfigId
		{
			get
			{
				return this.Instance.FightConfigId;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x000B31DF File Offset: 0x000B13DF
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

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x000B3214 File Offset: 0x000B1414
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x000B328C File Offset: 0x000B148C
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

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x000B32C2 File Offset: 0x000B14C2
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

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x000B32F8 File Offset: 0x000B14F8
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

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x000B3370 File Offset: 0x000B1570
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

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x000B33A7 File Offset: 0x000B15A7
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

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x000B33DB File Offset: 0x000B15DB
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

		// Token: 0x0400285D RID: 10333
		private IMonsterComponent Instance;

		// Token: 0x0400285E RID: 10334
		private IBossStateViewConfig _BossViewConfigCache;

		// Token: 0x0400285F RID: 10335
		private bool _BossViewConfigInited;

		// Token: 0x04002860 RID: 10336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _InitGasTagCache;

		// Token: 0x04002861 RID: 10337
		private bool _InitGasTagInited;

		// Token: 0x04002862 RID: 10338
		private IMonsterPerformConfig _PerformConfigCache;

		// Token: 0x04002863 RID: 10339
		private bool _PerformConfigInited;

		// Token: 0x04002864 RID: 10340
		private List<int> _ShareLifeSubMonsterIdsCache;

		// Token: 0x04002865 RID: 10341
		private bool _ShareLifeSubMonsterIdsInited;

		// Token: 0x04002866 RID: 10342
		private IMonsterNpcInteractionEnableConfig _EnableMonsterNpcInteractionCache;

		// Token: 0x04002867 RID: 10343
		private bool _EnableMonsterNpcInteractionInited;

		// Token: 0x04002868 RID: 10344
		private IMonsterCommunicationGroupConfig _MonsterCommunicationGroupCache;

		// Token: 0x04002869 RID: 10345
		private bool _MonsterCommunicationGroupInited;
	}
}
