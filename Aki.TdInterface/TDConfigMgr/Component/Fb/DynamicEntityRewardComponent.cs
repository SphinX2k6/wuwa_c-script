using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB0 RID: 2736
	[NullableContext(2)]
	[Nullable(0)]
	public class DynamicEntityRewardComponent : IComponentBase
	{
		// Token: 0x06003F16 RID: 16150 RVA: 0x000A154E File Offset: 0x0009F74E
		[NullableContext(1)]
		public static DynamicEntityRewardComponent Create(IDynamicEntityRewardComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicEntityRewardComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x000A1570 File Offset: 0x0009F770
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

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x000A15A8 File Offset: 0x0009F7A8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06003F19 RID: 16153 RVA: 0x000A15BE File Offset: 0x0009F7BE
		[Nullable(1)]
		public virtual IDynamicTrafficReward RewardType
		{
			[NullableContext(1)]
			get
			{
				if (this._RewardTypeInited)
				{
					return this._RewardTypeCache;
				}
				this._RewardTypeInited = true;
				this._RewardTypeCache = IDynamicTrafficReward.Create(this.Instance.RewardType);
				return this._RewardTypeCache;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x000A15F4 File Offset: 0x0009F7F4
		public virtual List<EClaimDynamicEntityRewardType> ClaimTypes
		{
			get
			{
				if (this._ClaimTypesInited)
				{
					return this._ClaimTypesCache;
				}
				this._ClaimTypesInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int claimTypesLength = this.Instance.ClaimTypesLength;
				this._ClaimTypesCache = new List<EClaimDynamicEntityRewardType>(claimTypesLength);
				for (int i = 0; i < claimTypesLength; i++)
				{
					this._ClaimTypesCache.Add((EClaimDynamicEntityRewardType)this.Instance.ClaimTypes(i));
				}
				return this._ClaimTypesCache;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003F1B RID: 16155 RVA: 0x000A166C File Offset: 0x0009F86C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> RewardActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._RewardActionsInited)
				{
					return this._RewardActionsCache;
				}
				this._RewardActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int rewardActionsLength = this.Instance.RewardActionsLength;
				this._RewardActionsCache = new List<ActionInfo>(rewardActionsLength);
				for (int i = 0; i < rewardActionsLength; i++)
				{
					this._RewardActionsCache.Add(ActionInfo.Create(this.Instance.RewardActions(i)));
				}
				return this._RewardActionsCache;
			}
		}

		// Token: 0x04002309 RID: 8969
		private IDynamicEntityRewardComponent Instance;

		// Token: 0x0400230A RID: 8970
		private IDynamicTrafficReward _RewardTypeCache;

		// Token: 0x0400230B RID: 8971
		private bool _RewardTypeInited;

		// Token: 0x0400230C RID: 8972
		private List<EClaimDynamicEntityRewardType> _ClaimTypesCache;

		// Token: 0x0400230D RID: 8973
		private bool _ClaimTypesInited;

		// Token: 0x0400230E RID: 8974
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _RewardActionsCache;

		// Token: 0x0400230F RID: 8975
		private bool _RewardActionsInited;
	}
}
