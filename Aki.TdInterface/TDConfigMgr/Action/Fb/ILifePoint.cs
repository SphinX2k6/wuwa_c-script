using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002863 RID: 10339
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifePoint : IUiGame
	{
		// Token: 0x0600E522 RID: 58658 RVA: 0x0021B45E File Offset: 0x0021965E
		public static ILifePoint Create(ILifePoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifePoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x0600E523 RID: 58659 RVA: 0x0021B47D File Offset: 0x0021967D
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x0600E524 RID: 58660 RVA: 0x0021B48A File Offset: 0x0021968A
		public virtual ILifePointColorBoard ColorBoard
		{
			get
			{
				if (this._ColorBoardInited)
				{
					return this._ColorBoardCache;
				}
				this._ColorBoardInited = true;
				this._ColorBoardCache = ILifePointColorBoard.Create(this.Instance.ColorBoard);
				return this._ColorBoardCache;
			}
		}

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x0600E525 RID: 58661 RVA: 0x0021B4BE File Offset: 0x002196BE
		public virtual int StepLimit
		{
			get
			{
				return this.Instance.StepLimit;
			}
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x0600E526 RID: 58662 RVA: 0x0021B4CB File Offset: 0x002196CB
		public virtual string TidDesc
		{
			get
			{
				return this.Instance.TidDesc;
			}
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x0600E527 RID: 58663 RVA: 0x0021B4D8 File Offset: 0x002196D8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ILifePointMaxStepRewardRuleItem> MaxStepRewardRule
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._MaxStepRewardRuleInited)
				{
					return this._MaxStepRewardRuleCache;
				}
				this._MaxStepRewardRuleInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int maxStepRewardRuleLength = this.Instance.MaxStepRewardRuleLength;
				this._MaxStepRewardRuleCache = new List<ILifePointMaxStepRewardRuleItem>(maxStepRewardRuleLength);
				for (int i = 0; i < maxStepRewardRuleLength; i++)
				{
					this._MaxStepRewardRuleCache.Add(ILifePointMaxStepRewardRuleItem.Create(this.Instance.MaxStepRewardRule(i)));
				}
				return this._MaxStepRewardRuleCache;
			}
		}

		// Token: 0x17004623 RID: 17955
		// (get) Token: 0x0600E528 RID: 58664 RVA: 0x0021B554 File Offset: 0x00219754
		public virtual bool? CloseUiAfterCompletion
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CloseUiAfterCompletion);
			}
		}

		// Token: 0x17004624 RID: 17956
		// (get) Token: 0x0600E529 RID: 58665 RVA: 0x0021B58A File Offset: 0x0021978A
		[Nullable(2)]
		public virtual string EdTidDesc
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007EC1 RID: 32449
		private ILifePoint Instance;

		// Token: 0x04007EC2 RID: 32450
		[Nullable(2)]
		private ILifePointColorBoard _ColorBoardCache;

		// Token: 0x04007EC3 RID: 32451
		private bool _ColorBoardInited;

		// Token: 0x04007EC4 RID: 32452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ILifePointMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x04007EC5 RID: 32453
		private bool _MaxStepRewardRuleInited;
	}
}
