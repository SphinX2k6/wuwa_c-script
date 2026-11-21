using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221D RID: 8733
	public class ITraceTracing : IUiGame
	{
		// Token: 0x0600BE62 RID: 48738 RVA: 0x001B7C8C File Offset: 0x001B5E8C
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

		// Token: 0x0600BE63 RID: 48739 RVA: 0x001B7CC4 File Offset: 0x001B5EC4
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

		// Token: 0x0600BE64 RID: 48740 RVA: 0x001B7CD7 File Offset: 0x001B5ED7
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

		// Token: 0x0600BE65 RID: 48741 RVA: 0x001B7CEC File Offset: 0x001B5EEC
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

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600BE66 RID: 48742 RVA: 0x001B7D46 File Offset: 0x001B5F46
		// (set) Token: 0x0600BE67 RID: 48743 RVA: 0x001B7D71 File Offset: 0x001B5F71
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

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600BE68 RID: 48744 RVA: 0x001B7D7F File Offset: 0x001B5F7F
		// (set) Token: 0x0600BE69 RID: 48745 RVA: 0x001B7DAA File Offset: 0x001B5FAA
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

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600BE6A RID: 48746 RVA: 0x001B7DB8 File Offset: 0x001B5FB8
		// (set) Token: 0x0600BE6B RID: 48747 RVA: 0x001B7E19 File Offset: 0x001B6019
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

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0600BE6C RID: 48748 RVA: 0x001B7E2E File Offset: 0x001B602E
		// (set) Token: 0x0600BE6D RID: 48749 RVA: 0x001B7E59 File Offset: 0x001B6059
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

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0600BE6E RID: 48750 RVA: 0x001B7E68 File Offset: 0x001B6068
		// (set) Token: 0x0600BE6F RID: 48751 RVA: 0x001B7EFB File Offset: 0x001B60FB
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().MaxStepRewardRule = value;
				this._MaxStepRewardRuleInited = false;
			}
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0600BE70 RID: 48752 RVA: 0x001B7F10 File Offset: 0x001B6110
		// (set) Token: 0x0600BE71 RID: 48753 RVA: 0x001B7F4A File Offset: 0x001B614A
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

		// Token: 0x0400722E RID: 29230
		[Nullable(2)]
		protected new ITraceTracing FbInstance;

		// Token: 0x0400722F RID: 29231
		[Nullable(2)]
		protected new ITraceTracing_SetValue PocoInterface;

		// Token: 0x04007230 RID: 29232
		private ITraceTracingGridBoard _BoardConfigCache;

		// Token: 0x04007231 RID: 29233
		private bool _BoardConfigInited;

		// Token: 0x04007232 RID: 29234
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITraceTracingMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x04007233 RID: 29235
		private bool _MaxStepRewardRuleInited;
	}
}
