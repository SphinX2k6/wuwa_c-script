using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B52 RID: 11090
	public class ITraceTracing : IUiGame
	{
		// Token: 0x0600F3CB RID: 62411 RVA: 0x0023900D File Offset: 0x0023720D
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

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x0600F3CC RID: 62412 RVA: 0x0023902C File Offset: 0x0023722C
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x0600F3CD RID: 62413 RVA: 0x00239039 File Offset: 0x00237239
		public virtual ETraceTracingImageType ImageResourceType
		{
			get
			{
				return (ETraceTracingImageType)this.Instance.ImageResourceType;
			}
		}

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x0600F3CE RID: 62414 RVA: 0x00239046 File Offset: 0x00237246
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

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x0600F3CF RID: 62415 RVA: 0x0023907A File Offset: 0x0023727A
		public virtual int StepLimit
		{
			get
			{
				return this.Instance.StepLimit;
			}
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x0600F3D0 RID: 62416 RVA: 0x00239088 File Offset: 0x00237288
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ITraceTracingMaxStepRewardRuleItem> MaxStepRewardRule
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
				this._MaxStepRewardRuleCache = new List<ITraceTracingMaxStepRewardRuleItem>(maxStepRewardRuleLength);
				for (int i = 0; i < maxStepRewardRuleLength; i++)
				{
					this._MaxStepRewardRuleCache.Add(ITraceTracingMaxStepRewardRuleItem.Create(this.Instance.MaxStepRewardRule(i)));
				}
				return this._MaxStepRewardRuleCache;
			}
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x0600F3D1 RID: 62417 RVA: 0x00239104 File Offset: 0x00237304
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

		// Token: 0x040085B8 RID: 34232
		private ITraceTracing Instance;

		// Token: 0x040085B9 RID: 34233
		[Nullable(2)]
		private ITraceTracingGridBoard _BoardConfigCache;

		// Token: 0x040085BA RID: 34234
		private bool _BoardConfigInited;

		// Token: 0x040085BB RID: 34235
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITraceTracingMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x040085BC RID: 34236
		private bool _MaxStepRewardRuleInited;
	}
}
