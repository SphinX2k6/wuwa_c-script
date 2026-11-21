using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D27 RID: 7463
	public class ILifePoint : IUiGame
	{
		// Token: 0x06009E7D RID: 40573 RVA: 0x0016C7F4 File Offset: 0x0016A9F4
		private ILifePoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILifePoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILifePoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILifePoint_SetValue());
			}
			return result;
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x0016C82C File Offset: 0x0016AA2C
		public static ILifePoint Create([Nullable(2)] ILifePoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifePoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x0016C83F File Offset: 0x0016AA3F
		public static ILifePoint CreateFromSetValue([Nullable(2)] ILifePoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILifePoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x0016C854 File Offset: 0x0016AA54
		public new ILifePoint_SetValue ToSetValue()
		{
			return new ILifePoint_SetValue
			{
				Type = this.Type,
				ColorBoard = this.ColorBoard,
				StepLimit = this.StepLimit,
				TidDesc = this.TidDesc,
				MaxStepRewardRule = this.MaxStepRewardRule,
				CloseUiAfterCompletion = this.CloseUiAfterCompletion,
				EdTidDesc = this.EdTidDesc
			};
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x0016C8BA File Offset: 0x0016AABA
		// (set) Token: 0x06009E82 RID: 40578 RVA: 0x0016C8E5 File Offset: 0x0016AAE5
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

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x06009E83 RID: 40579 RVA: 0x0016C8F4 File Offset: 0x0016AAF4
		// (set) Token: 0x06009E84 RID: 40580 RVA: 0x0016C955 File Offset: 0x0016AB55
		public virtual ILifePointColorBoard ColorBoard
		{
			get
			{
				if (this._ColorBoardInited)
				{
					return this._ColorBoardCache;
				}
				this._ColorBoardInited = true;
				if (this.FbInstance != null)
				{
					this._ColorBoardCache = ILifePointColorBoard.Create(this.FbInstance.ColorBoard);
				}
				else
				{
					ILifePoint_SetValue pocoInterface = this.PocoInterface;
					this._ColorBoardCache = ((pocoInterface != null) ? pocoInterface.ColorBoard : null);
				}
				return this._ColorBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().ColorBoard = value;
				this._ColorBoardInited = false;
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x06009E85 RID: 40581 RVA: 0x0016C96A File Offset: 0x0016AB6A
		// (set) Token: 0x06009E86 RID: 40582 RVA: 0x0016C995 File Offset: 0x0016AB95
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

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x06009E87 RID: 40583 RVA: 0x0016C9A3 File Offset: 0x0016ABA3
		// (set) Token: 0x06009E88 RID: 40584 RVA: 0x0016C9CE File Offset: 0x0016ABCE
		public virtual string TidDesc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDesc;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDesc;
			}
			set
			{
				this.GetOrCreatePoco().TidDesc = value;
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x06009E89 RID: 40585 RVA: 0x0016C9DC File Offset: 0x0016ABDC
		// (set) Token: 0x06009E8A RID: 40586 RVA: 0x0016CA6F File Offset: 0x0016AC6F
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
				if (this.FbInstance != null)
				{
					List<ILifePointMaxStepRewardRuleItem> maxStepRewardRule = this.FbInstance.MaxStepRewardRule;
					if (maxStepRewardRule != null)
					{
						this._MaxStepRewardRuleCache = new List<ILifePointMaxStepRewardRuleItem>(maxStepRewardRule.Count);
						for (int i = 0; i < maxStepRewardRule.Count; i++)
						{
							this._MaxStepRewardRuleCache.Add(ILifePointMaxStepRewardRuleItem.Create(maxStepRewardRule[i]));
						}
					}
				}
				else
				{
					ILifePoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x06009E8B RID: 40587 RVA: 0x0016CA84 File Offset: 0x0016AC84
		// (set) Token: 0x06009E8C RID: 40588 RVA: 0x0016CABE File Offset: 0x0016ACBE
		public virtual bool? CloseUiAfterCompletion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CloseUiAfterCompletion;
				}
				ILifePoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CloseUiAfterCompletion;
			}
			set
			{
				this.GetOrCreatePoco().CloseUiAfterCompletion = value;
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x06009E8D RID: 40589 RVA: 0x0016CACC File Offset: 0x0016ACCC
		// (set) Token: 0x06009E8E RID: 40590 RVA: 0x0016CAE3 File Offset: 0x0016ACE3
		[Nullable(2)]
		public virtual string EdTidDesc
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDesc;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidDesc = value;
			}
		}

		// Token: 0x040060A5 RID: 24741
		[Nullable(2)]
		protected new ILifePoint FbInstance;

		// Token: 0x040060A6 RID: 24742
		[Nullable(2)]
		protected new ILifePoint_SetValue PocoInterface;

		// Token: 0x040060A7 RID: 24743
		private ILifePointColorBoard _ColorBoardCache;

		// Token: 0x040060A8 RID: 24744
		private bool _ColorBoardInited;

		// Token: 0x040060A9 RID: 24745
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ILifePointMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x040060AA RID: 24746
		private bool _MaxStepRewardRuleInited;
	}
}
