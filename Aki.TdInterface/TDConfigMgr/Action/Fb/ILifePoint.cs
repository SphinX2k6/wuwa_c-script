using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B36 RID: 11062
	public class ILifePoint : IUiGame
	{
		// Token: 0x0600F347 RID: 62279 RVA: 0x002382C2 File Offset: 0x002364C2
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

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x0600F348 RID: 62280 RVA: 0x002382E1 File Offset: 0x002364E1
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x0600F349 RID: 62281 RVA: 0x002382EE File Offset: 0x002364EE
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

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x0600F34A RID: 62282 RVA: 0x00238322 File Offset: 0x00236522
		public virtual int StepLimit
		{
			get
			{
				return this.Instance.StepLimit;
			}
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x0600F34B RID: 62283 RVA: 0x0023832F File Offset: 0x0023652F
		public virtual string TidDesc
		{
			get
			{
				return this.Instance.TidDesc;
			}
		}

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x0600F34C RID: 62284 RVA: 0x0023833C File Offset: 0x0023653C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ILifePointMaxStepRewardRuleItem> MaxStepRewardRule
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x0600F34D RID: 62285 RVA: 0x002383B8 File Offset: 0x002365B8
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

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x0600F34E RID: 62286 RVA: 0x002383EE File Offset: 0x002365EE
		[Nullable(2)]
		public virtual string EdTidDesc
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x0400857E RID: 34174
		private ILifePoint Instance;

		// Token: 0x0400857F RID: 34175
		[Nullable(2)]
		private ILifePointColorBoard _ColorBoardCache;

		// Token: 0x04008580 RID: 34176
		private bool _ColorBoardInited;

		// Token: 0x04008581 RID: 34177
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ILifePointMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x04008582 RID: 34178
		private bool _MaxStepRewardRuleInited;
	}
}
