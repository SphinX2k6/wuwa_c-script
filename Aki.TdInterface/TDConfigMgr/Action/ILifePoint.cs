using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7A RID: 7034
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifePoint : IUiGame
	{
		// Token: 0x0600969B RID: 38555 RVA: 0x0015BC48 File Offset: 0x00159E48
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

		// Token: 0x0600969C RID: 38556 RVA: 0x0015BC80 File Offset: 0x00159E80
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

		// Token: 0x0600969D RID: 38557 RVA: 0x0015BC93 File Offset: 0x00159E93
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

		// Token: 0x0600969E RID: 38558 RVA: 0x0015BCA8 File Offset: 0x00159EA8
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

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0600969F RID: 38559 RVA: 0x0015BD0E File Offset: 0x00159F0E
		// (set) Token: 0x060096A0 RID: 38560 RVA: 0x0015BD39 File Offset: 0x00159F39
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

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x060096A1 RID: 38561 RVA: 0x0015BD48 File Offset: 0x00159F48
		// (set) Token: 0x060096A2 RID: 38562 RVA: 0x0015BDA9 File Offset: 0x00159FA9
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

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x060096A3 RID: 38563 RVA: 0x0015BDBE File Offset: 0x00159FBE
		// (set) Token: 0x060096A4 RID: 38564 RVA: 0x0015BDE9 File Offset: 0x00159FE9
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

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x060096A5 RID: 38565 RVA: 0x0015BDF7 File Offset: 0x00159FF7
		// (set) Token: 0x060096A6 RID: 38566 RVA: 0x0015BE22 File Offset: 0x0015A022
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

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x060096A7 RID: 38567 RVA: 0x0015BE30 File Offset: 0x0015A030
		// (set) Token: 0x060096A8 RID: 38568 RVA: 0x0015BEC3 File Offset: 0x0015A0C3
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().MaxStepRewardRule = value;
				this._MaxStepRewardRuleInited = false;
			}
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x060096A9 RID: 38569 RVA: 0x0015BED8 File Offset: 0x0015A0D8
		// (set) Token: 0x060096AA RID: 38570 RVA: 0x0015BF12 File Offset: 0x0015A112
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

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x060096AB RID: 38571 RVA: 0x0015BF20 File Offset: 0x0015A120
		// (set) Token: 0x060096AC RID: 38572 RVA: 0x0015BF37 File Offset: 0x0015A137
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

		// Token: 0x04005C0C RID: 23564
		[Nullable(2)]
		protected new ILifePoint FbInstance;

		// Token: 0x04005C0D RID: 23565
		[Nullable(2)]
		protected new ILifePoint_SetValue PocoInterface;

		// Token: 0x04005C0E RID: 23566
		private ILifePointColorBoard _ColorBoardCache;

		// Token: 0x04005C0F RID: 23567
		private bool _ColorBoardInited;

		// Token: 0x04005C10 RID: 23568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ILifePointMaxStepRewardRuleItem> _MaxStepRewardRuleCache;

		// Token: 0x04005C11 RID: 23569
		private bool _MaxStepRewardRuleInited;
	}
}
