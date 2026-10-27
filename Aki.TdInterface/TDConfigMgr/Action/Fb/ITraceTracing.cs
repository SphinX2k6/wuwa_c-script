using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287C RID: 10364
	[NullableContext(1)]
	[Nullable(0)]
	public class ITraceTracing : IUiGame
	{
		// Token: 0x0600E59A RID: 58778 RVA: 0x0021C0B9 File Offset: 0x0021A2B9
		public static ITraceTracing Create(ITraceTracing? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITraceTracing
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x0600E59B RID: 58779 RVA: 0x0021C0D8 File Offset: 0x0021A2D8
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x0600E59C RID: 58780 RVA: 0x0021C0E5 File Offset: 0x0021A2E5
		public virtual ETraceTracingImageType ImageResourceType
		{
			get
			{
				return (ETraceTracingImageType)this.Instance.ImageResourceType;
			}
		}

		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x0600E59D RID: 58781 RVA: 0x0021C0F2 File Offset: 0x0021A2F2
		public virtual ITraceTracingGridBoard BoardConfig
		{
			get
			{
				if (this._BoardConfigInited)
				{
					return this._BoardConfigCache;
				}
				this._BoardConfigInited = true;
				this._BoardConfigCache = ITraceTracingGridBoard.Create(this.Instance.BoardConfig);
				return this._BoardConfigCache;
			}
		}

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x0600E59E RID: 58782 RVA: 0x0021C126 File Offset: 0x0021A326
		public virtual int StepLimit
		{
			get
			{
				return this.Instance.StepLimit;
			}
		}

		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x0600E59F RID: 58783 RVA: 0x0021C134 File Offset: 0x0021A334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITraceTracingMaxStepRewardRuleItem> MaxStepRewardRule
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
				this._MaxStepRewardRuleCache = new List<ITraceTracingMaxStepRewardRuleItem>(maxStepRewardRuleLength);
				for (int i = 0; i < maxStepRewardRuleLength; i++)
				{
					this._MaxStepRewardRuleCache.Add(ITraceTracingMaxStepRewardRuleItem.Create(this.Instance.MaxStepRewardRule(i)));
				}
				return this._MaxStepRewardRuleCache;
			}
		}

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x0600E5A0 RID: 58784 RVA: 0x0021C1B0 File Offset: 0x0021A3B0
		public virtual bool? RemainUiAfterCompletion
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RemainUiAfterCompletion);
			}
		}

		// Token: 0x04007EF8 RID: 32504
		private ITraceTracing Instance;

		// Token: 0x04007EF9 RID: 32505
		[Nullable(2)]
		private ITraceTracingGridBoard _BoardConfigCache;

		// Token: 0x04007EFA RID: 32506
		private bool _BoardConfigInited;

		// Token: 0x04007EFB RID: 32507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITraceTracingMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x04007EFC RID: 32508
		private bool _MaxStepRewardRuleInited;
	}
}
