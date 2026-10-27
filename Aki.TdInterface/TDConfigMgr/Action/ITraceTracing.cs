using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD6 RID: 8150
	[NullableContext(1)]
	[Nullable(0)]
	public class ITraceTracing : IUiGame
	{
		// Token: 0x0600B34C RID: 45900 RVA: 0x001A1720 File Offset: 0x0019F920
		private ITraceTracing_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITraceTracing 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITraceTracing_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITraceTracing_SetValue());
			}
			return result;
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x001A1758 File Offset: 0x0019F958
		public static ITraceTracing Create([Nullable(2)] ITraceTracing instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITraceTracing
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B34E RID: 45902 RVA: 0x001A176B File Offset: 0x0019F96B
		public static ITraceTracing CreateFromSetValue([Nullable(2)] ITraceTracing_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITraceTracing
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x001A1780 File Offset: 0x0019F980
		public new ITraceTracing_SetValue ToSetValue()
		{
			return new ITraceTracing_SetValue
			{
				Type = this.Type,
				ImageResourceType = this.ImageResourceType,
				BoardConfig = this.BoardConfig,
				StepLimit = this.StepLimit,
				MaxStepRewardRule = this.MaxStepRewardRule,
				RemainUiAfterCompletion = this.RemainUiAfterCompletion
			};
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600B350 RID: 45904 RVA: 0x001A17DA File Offset: 0x0019F9DA
		// (set) Token: 0x0600B351 RID: 45905 RVA: 0x001A1805 File Offset: 0x0019FA05
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600B352 RID: 45906 RVA: 0x001A1813 File Offset: 0x0019FA13
		// (set) Token: 0x0600B353 RID: 45907 RVA: 0x001A183E File Offset: 0x0019FA3E
		public virtual ETraceTracingImageType ImageResourceType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageResourceType;
				}
				if (this.PocoInterface == null)
				{
					return (ETraceTracingImageType)0;
				}
				return this.PocoInterface.ImageResourceType;
			}
			set
			{
				this.GetOrCreatePoco().ImageResourceType = value;
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600B354 RID: 45908 RVA: 0x001A184C File Offset: 0x0019FA4C
		// (set) Token: 0x0600B355 RID: 45909 RVA: 0x001A18AD File Offset: 0x0019FAAD
		public virtual ITraceTracingGridBoard BoardConfig
		{
			get
			{
				if (this._BoardConfigInited)
				{
					return this._BoardConfigCache;
				}
				this._BoardConfigInited = true;
				if (this.FbInstance != null)
				{
					this._BoardConfigCache = ITraceTracingGridBoard.Create(this.FbInstance.BoardConfig);
				}
				else
				{
					ITraceTracing_SetValue pocoInterface = this.PocoInterface;
					this._BoardConfigCache = ((pocoInterface != null) ? pocoInterface.BoardConfig : null);
				}
				return this._BoardConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().BoardConfig = value;
				this._BoardConfigInited = false;
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600B356 RID: 45910 RVA: 0x001A18C2 File Offset: 0x0019FAC2
		// (set) Token: 0x0600B357 RID: 45911 RVA: 0x001A18ED File Offset: 0x0019FAED
		public virtual int StepLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StepLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StepLimit;
			}
			set
			{
				this.GetOrCreatePoco().StepLimit = value;
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600B358 RID: 45912 RVA: 0x001A18FC File Offset: 0x0019FAFC
		// (set) Token: 0x0600B359 RID: 45913 RVA: 0x001A198F File Offset: 0x0019FB8F
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
				if (this.FbInstance != null)
				{
					List<ITraceTracingMaxStepRewardRuleItem> maxStepRewardRule = this.FbInstance.MaxStepRewardRule;
					if (maxStepRewardRule != null)
					{
						this._MaxStepRewardRuleCache = new List<ITraceTracingMaxStepRewardRuleItem>(maxStepRewardRule.Count);
						for (int i = 0; i < maxStepRewardRule.Count; i++)
						{
							this._MaxStepRewardRuleCache.Add(ITraceTracingMaxStepRewardRuleItem.Create(maxStepRewardRule[i]));
						}
					}
				}
				else
				{
					ITraceTracing_SetValue pocoInterface = this.PocoInterface;
					this._MaxStepRewardRuleCache = ((pocoInterface != null) ? pocoInterface.MaxStepRewardRule : null);
				}
				return this._MaxStepRewardRuleCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().MaxStepRewardRule = value;
				this._MaxStepRewardRuleInited = false;
			}
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x001A19A4 File Offset: 0x0019FBA4
		// (set) Token: 0x0600B35B RID: 45915 RVA: 0x001A19DE File Offset: 0x0019FBDE
		public virtual bool? RemainUiAfterCompletion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RemainUiAfterCompletion;
				}
				ITraceTracing_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RemainUiAfterCompletion;
			}
			set
			{
				this.GetOrCreatePoco().RemainUiAfterCompletion = value;
			}
		}

		// Token: 0x04006C2C RID: 27692
		[Nullable(2)]
		protected new ITraceTracing FbInstance;

		// Token: 0x04006C2D RID: 27693
		[Nullable(2)]
		protected new ITraceTracing_SetValue PocoInterface;

		// Token: 0x04006C2E RID: 27694
		private ITraceTracingGridBoard _BoardConfigCache;

		// Token: 0x04006C2F RID: 27695
		private bool _BoardConfigInited;

		// Token: 0x04006C30 RID: 27696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITraceTracingMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x04006C31 RID: 27697
		private bool _MaxStepRewardRuleInited;
	}
}
