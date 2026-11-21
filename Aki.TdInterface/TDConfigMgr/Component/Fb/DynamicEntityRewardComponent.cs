using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7A RID: 2938
	public class DynamicEntityRewardComponent : IComponentBase
	{
		// Token: 0x06004340 RID: 17216 RVA: 0x000AAB42 File Offset: 0x000A8D42
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

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06004341 RID: 17217 RVA: 0x000AAB64 File Offset: 0x000A8D64
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

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x000AAB9C File Offset: 0x000A8D9C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x000AABB2 File Offset: 0x000A8DB2
		public virtual IDynamicTrafficReward RewardType
		{
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

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x000AABE8 File Offset: 0x000A8DE8
		[Nullable(2)]
		public virtual List<EClaimDynamicEntityRewardType> ClaimTypes
		{
			[NullableContext(2)]
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

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06004345 RID: 17221 RVA: 0x000AAC60 File Offset: 0x000A8E60
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> RewardActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04002525 RID: 9509
		private IDynamicEntityRewardComponent Instance;

		// Token: 0x04002526 RID: 9510
		[Nullable(2)]
		private IDynamicTrafficReward _RewardTypeCache;

		// Token: 0x04002527 RID: 9511
		private bool _RewardTypeInited;

		// Token: 0x04002528 RID: 9512
		[Nullable(2)]
		private List<EClaimDynamicEntityRewardType> _ClaimTypesCache;

		// Token: 0x04002529 RID: 9513
		private bool _ClaimTypesInited;

		// Token: 0x0400252A RID: 9514
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _RewardActionsCache;

		// Token: 0x0400252B RID: 9515
		private bool _RewardActionsInited;
	}
}
